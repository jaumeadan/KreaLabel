Imports System.Xml
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.IO.FileStream

Public Class frm_ArticulosPrecios
    Private Declare Sub Conecta Lib "InfoProd.dll" (<MarshalAs(UnmanagedType.BStr)> ByRef [Error] As String, <MarshalAs(UnmanagedType.BStr)> ByVal ruta As String)
    Private Declare Sub FechaUltimoCambiosPrecios Lib "InfoProd.dll" (<MarshalAs(UnmanagedType.BStr)> ByRef xmlDevuelto As String, <MarshalAs(UnmanagedType.BStr)> ByVal DesdeFecha As String, <MarshalAs(UnmanagedType.Bool)> ByVal generarEtiqueta As Boolean, <MarshalAs(UnmanagedType.BStr)> ByVal OrigenPrecios As String)
    Private Declare Sub Desconecta Lib "InfoProd.dll" (<MarshalAs(UnmanagedType.BStr)> ByRef [Error] As String)

    Private bInsertando As Boolean = False

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frm_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cargar_Grid()
            Me.txtFecha.Text = Dame_Ultima_Fecha()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al cargar la pantalla" & vbCrLf & vbCrLf & ex.Message, 16, "Error")
        End Try
    End Sub

    Sub Cargar_Grid()
        Dim dsPrecios As New DataSet
        Dim strSQL As String

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            strSQL = "SELECT ID, FECHA, CODIGO, DESCRIPCION, PRECIO, FECHA_CAMBIO_PRECIO FROM tbl_Precios WHERE FECHA = CDATE('" & Format(Me.txtFecha2.Value, "dd/MM/yyyy") & "') ORDER BY DESCRIPCION"
            dsPrecios = myDB.Dame_Dataset(strSQL)
            Me.dgDetalle.DataSource = dsPrecios.Tables(0)
            Formatear_Grid_Detalle()
            Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message + " - Cargar_Grid")
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub Formatear_Grid_Detalle()
        Me.dgDetalle.Columns(0).Visible = False 'Oculto el ID
        Me.dgDetalle.Columns("FECHA").Width = 100
        Me.dgDetalle.Columns("FECHA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgDetalle.Columns("CODIGO").Width = 125
        Me.dgDetalle.Columns("CODIGO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgDetalle.Columns("DESCRIPCION").Width = 650
        Me.dgDetalle.Columns("DESCRIPCION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgDetalle.Columns("PRECIO").Width = 100
        Me.dgDetalle.Columns("PRECIO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgDetalle.Columns("FECHA_CAMBIO_PRECIO").Width = 200
        Me.dgDetalle.Columns("FECHA_CAMBIO_PRECIO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft

        Me.dgDetalle.Columns("FECHA").HeaderText = "FECHA"
        Me.dgDetalle.Columns("FECHA").DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.dgDetalle.Columns("FECHA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgDetalle.Columns("CODIGO").HeaderText = "CÓDIGO"
        Me.dgDetalle.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgDetalle.Columns("DESCRIPCION").HeaderText = "ARTÍCULO"
        Me.dgDetalle.Columns("PRECIO").HeaderText = "PRECIO"
        Me.dgDetalle.Columns("PRECIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgDetalle.Columns("PRECIO").DefaultCellStyle.Format = "#,##0.00"
        Me.dgDetalle.Columns("FECHA_CAMBIO_PRECIO").HeaderText = "CAMBIO PRECIO"
        'Me.dgDetalle.Columns("FECHA_CAMBIO_PRECIO").DefaultCellStyle.Format = "dd/MM/yyyy hh24:mm:ss"
        Me.dgDetalle.Columns("FECHA_CAMBIO_PRECIO").DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.dgDetalle.Columns("FECHA_CAMBIO_PRECIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
    End Sub

    Private Sub imgConectarDLL_Click(sender As Object, e As EventArgs) Handles imgConectarDLL.Click

        Dim sCodigoAnterior As String = ""
        Dim errorDevuelto As String = " "
        Dim xmlDevuelto As String = ""
        Dim bActualizado As Boolean = False

        Dim dsArticulos As New DataSet
        Dim dsPrecios As New DataSet

        Try
            'miBarra.Visible = False
            If bdFirebird = "" Then
                MsgBox("No está definida la BD firebird. Imposible localizar los datos.", MsgBoxStyle.OkOnly, "Incluir artículo")
                Exit Sub
            End If
            If bdKrealabel = "" Then
                MsgBox("No está definida la BD Krealabel. Imposible localizar los datos.", MsgBoxStyle.OkOnly, "Incluir artículo")
                Exit Sub
            End If
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            fecha = Me.txtFecha.Text

            Conecta(errorDevuelto, "localhost:" + bdFirebird) 'C:\IOFWIN\DATOS\IOFWIN.FDB")
            If Not errorDevuelto = "OK" Then
                Call Desconecta(errorDevuelto)
                MessageBox.Show(errorDevuelto)
                Windows.Forms.Cursor.Current = Cursors.Default
                Exit Sub
            End If

            Call Desconecta(errorDevuelto)

            Application.DoEvents()
            Call FechaUltimoCambiosPrecios(xmlDevuelto, fecha, False, "")
            xmlDevuelto = Transforma_XML(xmlDevuelto)

            Dim miXML As New XmlDataDocument()
            Dim miNodo As XmlNodeList
            Dim nCuenta As Long
            Dim i As Integer

            miXML.LoadXml(xmlDevuelto)
            miNodo = miXML.GetElementsByTagName("productos")

            If InStr(xmlDevuelto, "Error") Then
                MsgBox("No existen cambios de precio hasta la fecha indicada", MsgBoxStyle.OkOnly, "Incluir artículo")
                Exit Sub
            End If

            nCuenta = miNodo(0).ChildNodes.Count

            If nCuenta = 0 Then
                MsgBox("No existen cambios de precio hasta la fecha indicada", MsgBoxStyle.OkOnly, "Incluir artículo")
                Exit Sub
            End If
            dsArticulos = myDB.Dame_Dataset("Select * From tbl_Articulos")

            For i = 0 To nCuenta - 1
                sCodigo_Producto = miNodo(0).ChildNodes(i).ChildNodes(0).InnerText
                If sCodigo_Producto = sCodigoAnterior Then
                    GoTo Siguiente
                Else
                    sCodigoAnterior = sCodigo_Producto
                End If
                If sCodigo_Producto = "" Then
                    GoTo Siguiente
                End If
                Dim miRegistro() As DataRow
                miRegistro = dsArticulos.Tables(0).Select("codigo='" & sCodigo_Producto & "'")
                If miRegistro.Length = 0 Then
                    GoTo Siguiente
                End If

                sNombre_Producto = miNodo(0).ChildNodes(i).ChildNodes(1).InnerText
                If miNodo(0).ChildNodes(i).ChildNodes(3).InnerText = "" Then
                    nPVP_Producto = 0
                Else
                    nPVP_Producto = miNodo(0).ChildNodes(i).ChildNodes(3).InnerText.Replace(".", ",")
                End If

                dFecha_Cambio = miNodo(0).ChildNodes(i).ChildNodes(10).InnerText
                sOrigen_Cambio = miNodo(0).ChildNodes(i).ChildNodes(12).InnerText

                'NO COGEMOS ESTE VALOR, PORQUE NO NOS LO ENVIAN BIEN LOS DE IOFWIN (FEDEFARMA)
                'If miNodo(0).ChildNodes(i).ChildNodes(5).ChildNodes(0).InnerText = "" Then
                '    nEuros_Unidad = 0
                'Else
                '    nEuros_Unidad = miNodo(0).ChildNodes(i).ChildNodes(5).ChildNodes(0).InnerText.Replace(".", ",")
                'End If

                'Miro si ya hay algún precio hoy, si es así lo machaco, sino lo creo
                sSQL = "Select count(*) as Cuenta From tbl_Precios Where codigo='" & sCodigo_Producto & "' AND FECHA = CDATE('" & DateTime.Now.ToString("dd/MM/yyyy") & "')"
                dsPrecios = myDB.Dame_Dataset(sSQL)

                If CLng(dsPrecios.Tables(0).Rows(0).Item(0).ToString) > 0 Then
                    'HOY YA HA HABIDO UN CAMBIO DE PRECIO DE ESTE PRODUCTO, EN VEZ DE AÑADIRLO, LO ACTUALIZAMOS
                    sSQL = "UPDATE tbl_Precios SET FECHA=CDate('" & DateTime.Now.ToString("dd/MM/yyyy") & "'), " &
                        "CODIGO='" & sCodigo_Producto & "', " &
                        "DESCRIPCION='" & sNombre_Producto & "', " &
                        "PRECIO=" & Replace(nPVP_Producto, ",", ".") & "," &
                        "FECHA_CAMBIO_PRECIO='" & dFecha_Cambio & "'," &
                        "ORIGEN_PRECIO='" & sOrigen_Cambio & "'," &
                        "IMPRESO=0 " &
                        "WHERE CODIGO='" & sCodigo_Producto & "' AND FECHA = CDATE('" & DateTime.Now.ToString("dd/MM/yyyy") & "') AND IMPRESO=0"
                    bActualizado = True
                Else
                    'INSERTO
                    sSQL = "INSERT INTO tbl_Precios (FECHA, CODIGO, DESCRIPCION, PRECIO, FECHA_CAMBIO_PRECIO, ORIGEN_PRECIO, IMPRESO) " &
                    " VALUES (CDate('" & DateTime.Now.ToString("dd/MM/yyyy") & "'), '" & sCodigo_Producto & "', '" & sNombre_Producto & "', " & Replace(nPVP_Producto, ",", ".") & ", " &
                    "'" & dFecha_Cambio & "', '" & sOrigen_Cambio & "', 0)"
                    bActualizado = True
                End If

                myDB.Ejecuta_SQL(sSQL)

Siguiente:
                Application.DoEvents()
            Next

            If errorDevuelto = "OK" Then

            Else
                MessageBox.Show(errorDevuelto)
                Windows.Forms.Cursor.Current = Cursors.Default
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = Cursors.Default
            Cargar_Grid()
            If bActualizado = True Then
                MsgBox("Se han encontrado actualizaciones de precio", 64, "Información")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub frm_ArticulosPrecios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Escape Then
            Call botonesOriginal()
            formularioActivo = False
            Me.Close()
        End If
    End Sub

    Private Sub imgSalir_Click(sender As Object, e As EventArgs) Handles imgSalir.Click
        Call botonesOriginal()
        formularioActivo = False
        Close()
    End Sub


    Private Sub txtFecha2_ValueChanged(sender As Object, e As EventArgs) Handles txtFecha2.ValueChanged

        Cargar_Grid()

    End Sub

    Private Sub imgBuscar_Click(sender As Object, e As EventArgs) Handles imgBuscar.Click
        Cargar_Grid()
    End Sub

    Private Sub panelDatos_MouseMove(sender As Object, e As MouseEventArgs) Handles panelDatos.MouseMove
        Mostrar_Label("")

    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        Mostrar_Label("")
    End Sub
End Class