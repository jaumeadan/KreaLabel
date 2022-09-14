Imports System.ComponentModel
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class frm_Articulos

    Private bInsertando As Boolean = False

    Private Declare Function CreateCaret Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal hBitmap As IntPtr, ByVal nWidth As Int32, ByVal nHeight As Int32) As IntPtr
    Private Declare Function ShowCaret Lib "user32.dll" (ByVal hwnd As IntPtr) As Int32

    Private Declare Sub Conecta Lib "InfoProd.dll" (<MarshalAs(UnmanagedType.BStr)> ByRef [Error] As String, <MarshalAs(UnmanagedType.BStr)> ByVal ruta As String)
    Private Declare Sub getInfoProducto Lib "InfoProd.dll" (<MarshalAs(UnmanagedType.BStr)> ByRef xmlDevuelto As String, <MarshalAs(UnmanagedType.BStr)> ByVal Codigo As String, <MarshalAs(UnmanagedType.BStr)> ByVal Clave As String)
    Private Declare Sub Desconecta Lib "InfoProd.dll" (<MarshalAs(UnmanagedType.BStr)> ByRef [Error] As String)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frm_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtBuscar.Clear()
            txtArticulo.Clear()
            Cargar_Grid()
            txtArticulo.Focus()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al cargar la pantalla" & vbCrLf & vbCrLf & ex.Message, 16, "Error")
        End Try
    End Sub

    Sub Cargar_Grid()
        Dim ds As New DataSet
        Dim strSQL As String
        Dim strWhere As String = ""
        Dim strbuscar As String = ""

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Me.dgArticulos.DataSource = Nothing
            strSQL = "SELECT ID, FECHA, CODIGO, DESCRIPCION, EAN, PRECIO, DIFERENCIA, PRECIO_OFERTA, UNIDAD, PRECIO_UNIDAD, DESCRIPCION_UNIDAD, ACTIVO "
            strSQL = strSQL & " FROM tbl_Articulos "
            If txtBuscar.Text.Trim.Length > 0 Then
                strbuscar = "%" & txtBuscar.Text.Trim & "%"
                If strWhere = "" Then
                    strWhere = " WHERE (DESCRIPCION LIKE '" & strbuscar & "' "
                    strWhere = strWhere & " OR CODIGO LIKE '" & strbuscar & "') "
                Else
                    strWhere = strWhere & " AND (DESCRIPCION LIKE '" & strbuscar & "' "
                    strWhere = strWhere & " OR CODIGO LIKE '" & strbuscar & "') "
                End If
            End If
            If strWhere <> "" Then
                strSQL = strSQL & strWhere
            End If
            strSQL = strSQL & " ORDER BY DESCRIPCION"

            ds = myDB.Dame_Dataset(strSQL)
            Me.dgArticulos.DataSource = ds.Tables(0)

            Call Formatear_Grid()
            Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message + " - Cargar_Grid")
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Sub Formatear_Grid()
        Me.dgArticulos.Columns(0).Visible = False 'Oculto el ID
        Me.dgArticulos.Columns("FECHA").Width = 85
        Me.dgArticulos.Columns("FECHA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("CODIGO").Width = 90
        Me.dgArticulos.Columns("CODIGO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("DESCRIPCION").Width = 520
        Me.dgArticulos.Columns("DESCRIPCION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("EAN").Width = 140
        Me.dgArticulos.Columns("EAN").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("PRECIO").Width = 75
        Me.dgArticulos.Columns("PRECIO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgArticulos.Columns("DIFERENCIA").Width = 0 ' 75
        Me.dgArticulos.Columns("DIFERENCIA").Visible = False
        Me.dgArticulos.Columns("PRECIO_OFERTA").Width = 0 '70
        Me.dgArticulos.Columns("PRECIO_OFERTA").Visible = False
        Me.dgArticulos.Columns("UNIDAD").Width = 70
        Me.dgArticulos.Columns("UNIDAD").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("PRECIO_UNIDAD").Width = 100
        Me.dgArticulos.Columns("PRECIO_UNIDAD").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgArticulos.Columns("DESCRIPCION_UNIDAD").Width = 100
        Me.dgArticulos.Columns("DESCRIPCION_UNIDAD").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("ACTIVO").Width = 0
        Me.dgArticulos.Columns("ACTIVO").Visible = False

        Me.dgArticulos.Columns("FECHA").HeaderText = "FECHA"
        Me.dgArticulos.Columns("FECHA").DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.dgArticulos.Columns("FECHA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("CODIGO").HeaderText = "CÓDIGO"
        Me.dgArticulos.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("DESCRIPCION").HeaderText = "ARTÍCULO"
        Me.dgArticulos.Columns("EAN").HeaderText = "EAN"
        Me.dgArticulos.Columns("EAN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("PRECIO").HeaderText = "PRECIO"
        Me.dgArticulos.Columns("PRECIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgArticulos.Columns("PRECIO").DefaultCellStyle.Format = "#,##0.00"
        Me.dgArticulos.Columns("DIFERENCIA").HeaderText = "DIFERENCIA"
        Me.dgArticulos.Columns("DIFERENCIA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgArticulos.Columns("PRECIO").DefaultCellStyle.Format = "#,##0.00"
        Me.dgArticulos.Columns("PRECIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgArticulos.Columns("UNIDAD").HeaderText = "UNIDAD"
        Me.dgArticulos.Columns("UNIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgArticulos.Columns("PRECIO_UNIDAD").HeaderText = "P/UNIDAD"
        Me.dgArticulos.Columns("PRECIO_UNIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgArticulos.Columns("DESCRIPCION_UNIDAD").HeaderText = "MEDIDA"
        Me.dgArticulos.Columns("ACTIVO").HeaderText = "ACTIVO"

        Dim columna As Integer
        dgArticulos.ReadOnly = False
        For columna = 0 To dgArticulos.Columns.Count - 1
            dgArticulos.Columns(columna).ReadOnly = True
        Next columna
        dgArticulos.Columns("ACTIVO").ReadOnly = False
    End Sub

    Private Sub txtBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.GotFocus
        txtBuscar.SelectionStart = 0
        txtBuscar.SelectionLength = txtBuscar.TextLength
        CreateCaret(txtBuscar.Handle, New IntPtr(1), 3, txtBuscar.Height)
        ShowCaret(txtBuscar.Handle)
    End Sub

    Private Sub txtBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.LostFocus
        txtBuscar.SelectionStart = 0
        txtBuscar.SelectionLength = 0
    End Sub

    Private Sub txtArticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtArticulo.GotFocus
        txtArticulo.SelectionStart = 0
        txtArticulo.SelectionLength = txtArticulo.TextLength
        CreateCaret(txtArticulo.Handle, New IntPtr(1), 3, txtArticulo.Height)
        ShowCaret(txtArticulo.Handle)
    End Sub

    Private Sub frm_Articulos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Escape Then
            Call botonesOriginal()
            formularioActivo = False
            Me.Close()
        End If
    End Sub

    Private Sub BuscarArticulo()

        Dim bResultado As Boolean = False
        Dim bActualizado As Boolean = False

        Dim errorDevuelto As String = " "
        Dim xmlDevuelto As String = ""

        Dim ds As New DataSet

        Try
            bActualizado = False
            If txtArticulo.Text.Trim.Length = 0 Then
                Exit Sub
            End If

            If bdFirebird = "" Then
                Sonido_KO()
                MsgBox("No está definida la BD firebird. Imposible localizar los datos.", MsgBoxStyle.OkOnly, "Incluir artículo")
                Exit Sub
            End If
            If bdKrealabel = "" Then
                Sonido_KO()
                MsgBox("No está definida la BD Krealabel. Imposible localizar los datos.", MsgBoxStyle.OkOnly, "Incluir artículo")
                Exit Sub
            End If
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Conecta(errorDevuelto, "localhost:" + bdFirebird) 'C:\IOFWIN\DATOS\IOFWIN.FDB")
            Call Desconecta("")

            If errorDevuelto = "OK" Then

            Else
                Sonido_KO()
                MessageBox.Show(errorDevuelto)
                Windows.Forms.Cursor.Current = Cursors.Default
                Exit Sub
            End If

            Call getInfoProducto(xmlDevuelto, txtArticulo.Text, licencia)

            If InStr(xmlDevuelto, "Error") <> 0 Then
                Sonido_KO()
                MessageBox.Show("El artículo no existe.", "Incluir artículo", MessageBoxButtons.OK)
                System.Media.SystemSounds.Beep.Play()
                System.Media.SystemSounds.Exclamation.Play()
                Exit Sub
            End If

            xmlDevuelto = Transforma_XML(xmlDevuelto)
            bResultado = Leer_Articulo(xmlDevuelto)

            If bResultado = False Then
                Sonido_KO()
                MessageBox.Show("Error al procesar la petición con IOFWIN.", "Incluir artículo", MessageBoxButtons.OK)
                System.Media.SystemSounds.Beep.Play()
                System.Media.SystemSounds.Exclamation.Play()
                Exit Sub
            End If

            ds = myDB.Dame_Dataset("Select Codigo From tbl_Articulos WHERE Codigo = '" & sCodigo_Producto & "'")
            If ds.Tables(0).Rows.Count > 0 Then
                'UPDATE
                sSQL = "UPDATE tbl_Articulos Set FECHA=CDate('" & Now.ToString() & "'), " &
                    "DESCRIPCION='" & sNombre_Producto & "'," &
                    "EAN='" & sEAN_Producto & "'," &
                    "PRECIO=" & Replace(nPVP_Producto, ",", ".") & "," &
                    "PRECIO_OFERTA=" & Replace(nPVPOferta_Producto, ",", ".") & "," &
                    "UNIDAD='" & sUnidad_Producto & "'," &
                    "PRECIO_UNIDAD=" & Replace(nEuros_Unidad, ",", ".") & "," &
                    "DESCRIPCION_UNIDAD='" & sDescUnidad_Producto & "'," &
                    "IVA=" & Replace(nIVA_Producto, ",", ".") & ", " &
                    "CANTIDAD_ENVASE=" & Replace(nCantidad_Envase, ",", ".") & " " &
                    "WHERE CODIGO='" & sCodigo_Producto & "'"
            Else
                'INSERT
                sSQL = "INSERT INTO tbl_Articulos(" &
                            "FECHA, " &
                            "CODIGO, " &
                            "DESCRIPCION, " &
                            "EAN, " &
                            "PRECIO, " &
                            "PRECIO_OFERTA, " &
                            "UNIDAD, " &
                            "PRECIO_UNIDAD, " &
                            "DESCRIPCION_UNIDAD, " &
                            "IVA, " &
                            "CANTIDAD_ENVASE) "

                sSQL = sSQL & " VALUES (" &
                            "CDate('" & Now.ToString() & "'), " &
                            "'" & sCodigo_Producto & "'," &
                            "'" & sNombre_Producto & "'," &
                            "'" & sEAN_Producto & "'," &
                            Replace(nPVP_Producto, ",", ".") & "," &
                            Replace(nPVPOferta_Producto, ",", ".") & "," &
                            "'" & sUnidad_Producto & "'," &
                            Replace(nEuros_Unidad, ",", ".") & "," &
                            "'" & sDescUnidad_Producto & "'," &
                            Replace(nIVA_Producto, ",", ".") & "," &
                            Replace(nCantidad_Envase, ",", ".") & ")"

            End If

            bActualizado = True
            myDB.Ejecuta_SQL(sSQL)

            sSQL = "Select count(*) as Cuenta From tbl_Precios Where codigo='" & sCodigo_Producto & "' AND FECHA = CDATE('" & DateTime.Now.ToString("dd/MM/yyyy") & "')"
            Dim dsPrecios As New DataSet

            dsPrecios = myDB.Dame_Dataset(sSQL)

            If CLng(dsPrecios.Tables(0).Rows(0).Item(0).ToString) > 0 Then
                'HOY YA HA HABIDO UN CAMBIO DE PRECIO DE ESTE PRODUCTO, EN VEZ DE AÑADIRLO, LO ACTUALIZAMOS
                sSQL = "UPDATE tbl_Precios SET FECHA=CDate('" & DateTime.Now.ToString("dd/MM/yyyy") & "'), " &
                    "CODIGO='" & sCodigo_Producto & "', " &
                    "DESCRIPCION='" & sNombre_Producto & "', " &
                    "PRECIO=" & Replace(nPVP_Producto, ",", ".") & "," &
                    "FECHA_CAMBIO_PRECIO=CDate('" & DateTime.Now.ToString("dd/MM/yyyy") & "')," &
                    "ORIGEN_PRECIO='I'," &
                    "IMPRESO=0 " &
                    "WHERE CODIGO='" & sCodigo_Producto & "' AND FECHA = CDATE('" & DateTime.Now.ToString("dd/MM/yyyy") & "') AND IMPRESO=0"
            Else


                sSQL = "INSERT INTO tbl_Precios (FECHA, CODIGO, DESCRIPCION, PRECIO, FECHA_CAMBIO_PRECIO, ORIGEN_PRECIO, IMPRESO) " &
                    " VALUES (CDate('" & DateTime.Now.ToString("dd/MM/yyyy") & "'), '" & sCodigo_Producto & "', '" & sNombre_Producto & "', " & Replace(nPVP_Producto, ",", ".") & ", " &
                    "CDate('" & DateTime.Now.ToString("dd/MM/yyyy") & "'), 'I', 0)"
            End If

            myDB.Ejecuta_SQL(sSQL)
            Sonido_OK()
            Call Desconecta(errorDevuelto)
            If errorDevuelto = "OK" Then

            Else
                Sonido_KO()
                MessageBox.Show(errorDevuelto)
                Windows.Forms.Cursor.Current = Cursors.Default
                Exit Sub
            End If

            Windows.Forms.Cursor.Current = Cursors.Default
            If bActualizado Then Cargar_Grid()
            txtArticulo.Clear()
            txtArticulo.Focus()

        Catch ex As Exception
            Sonido_KO()
            Call Desconecta(errorDevuelto)
            MessageBox.Show(ex.Message)
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    
    Private Sub imgBuscar_Click(sender As Object, e As EventArgs) Handles imgBuscar.Click
        Call Cargar_Grid()
    End Sub

    Private Sub imgSalir_Click(sender As Object, e As EventArgs) Handles imgSalir.Click
        Call botonesOriginal()
        formularioActivo = False
        Me.Close()
    End Sub

    Private Sub dgArticulos_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgArticulos.CellPainting
        Dim pt As Point
        Dim offset As Integer

        If e.ColumnIndex = 12 And e.RowIndex = -1 Then
            'e.PaintBackground(e.ClipBounds, False)
            'pt = e.CellBounds.Location
            'offset = (e.CellBounds.Width - images.ImageSize.Width) / 2
            'pt.X += offset
            'pt.Y += 1
            'images.Draw(e.Graphics, pt, 0)
            'e.Handled = True
        ElseIf e.ColumnIndex = 11 And e.RowIndex <> -1 Then
            If dgArticulos.Rows(e.RowIndex).Cells(e.ColumnIndex).Value Then
                e.PaintBackground(e.ClipBounds, False)
                pt = e.CellBounds.Location
                offset = (e.CellBounds.Width - images.ImageSize.Width) / 2
                pt.X += offset
                pt.Y += 1
                images.Draw(e.Graphics, pt, 0)
                e.Handled = True
            Else
                e.PaintBackground(e.ClipBounds, False)
                pt = e.CellBounds.Location
                offset = (e.CellBounds.Width - images.ImageSize.Width) / 2
                pt.X += offset
                pt.Y += 1
                images.Draw(e.Graphics, pt, 1)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgArticulos.CellClick
        Dim fila As DataGridViewRow
        Dim vActivo As Boolean

        Dim strSQL As String
        Dim vID As String

        If e.ColumnIndex = 14 And e.RowIndex >= 0 Then
            If dgArticulos.SelectedRows.Count = 0 Then Exit Sub
            fila = dgArticulos.SelectedRows(0)
            If Not fila Is Nothing Then
                vActivo = fila.Cells("ACTIVO").Value
                fila.Cells("ACTIVO").Value = Not vActivo

                vID = fila.Cells("ID").Value
                strSQL = "UPDATE tbl_Articulos SET Activo = (Not Activo) WHERE ID = " & vID
                myDB.Ejecuta_SQL(strSQL)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        MsgBox(Sacar_Numeros(Me.txtArticulo.Text))

    End Sub

    Private Sub txtArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtArticulo.KeyPress

        If e.KeyChar = Convert.ToChar(Windows.Forms.Keys.Return) Or e.KeyChar = Convert.ToChar(Windows.Forms.Keys.Tab) Then
            txtArticulo.SelectionStart = 0
            txtArticulo.SelectionLength = 0
            Call BuscarArticulo()
            txtArticulo.Text = ""
            txtArticulo.Focus()
        End If

    End Sub

    Private Sub dgArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgArticulos.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MsgBox("¿Desea eliminar el artículo: " & dgArticulos.SelectedRows(0).Cells(3).Value, 36, "Pregunta") = vbYes Then
                sSQL = "DELETE From tbl_Articulos Where Codigo='" & dgArticulos.SelectedRows(0).Cells(2).Value & "'"
                myDB.Ejecuta_SQL(sSQL)
                Cargar_Grid()
            End If
        End If
    End Sub


End Class