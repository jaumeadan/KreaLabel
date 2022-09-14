Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frm_ImprimirEtiquetas
    Private myReportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument

    Private Declare Function CreateCaret Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal hBitmap As IntPtr, ByVal nWidth As Int32, ByVal nHeight As Int32) As IntPtr
    Private Declare Function ShowCaret Lib "user32.dll" (ByVal hwnd As IntPtr) As Int32

    Dim valorImpresion As Boolean

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frm_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtFechaDesde.Format = DateTimePickerFormat.Custom
            txtFechaDesde.Value = Date.Today.AddDays(-30)
            txtFechaHasta.Format = DateTimePickerFormat.Custom
            txtFechaHasta.Value = Date.Today
            txtBuscar.Clear()
            chkImpresos.Checked = False
            chkNoImpresos.Checked = True
            valorImpresion = True
            txtDesde.Text = ""
            txtHasta.Text = ""
            Cargar_Grid()
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

            strSQL = "SELECT P.ID, P.FECHA, P.CODIGO, P.DESCRIPCION, P.PRECIO, P.FECHA_CAMBIO_PRECIO, -1 AS IMPRIMIR, A.CANTIDAD_ENVASE, A.UNIDAD " &
                "FROM tbl_Articulos As A INNER JOIN tbl_Precios As P ON A.Codigo=P.Codigo WHERE 1=1 "
            If txtFechaDesde.Text <> "" Then
                'OJO!!! ESTA COMENTANDO LA SIGUIENTE LÍNEA, PERO FUNCIONA IGUAL. SE PONE LA QUE NO ESTÁ CONVENTADA PORQUE TODO EL PROGRAMA ESTÁ ASÍ.
                'strWhere = strWhere & " AND P.FECHA >= #" & Format(CDate(txtFechaDesde.Text), "MM/dd/yyyy") & "# "
                strWhere = strWhere & " AND P.FECHA >= CDATE('" & Format(txtFechaDesde.Value, "dd/MM/yyyy") & "')"
            End If
            If txtFechaHasta.Text <> "" Then
                'OJO!!! ESTA COMENTANDO LA SIGUIENTE LÍNEA, PERO FUNCIONA IGUAL. SE PONE LA QUE NO ESTÁ CONVENTADA PORQUE TODO EL PROGRAMA ESTÁ ASÍ.
                'strWhere = strWhere & " AND P.FECHA <= #" & Format(CDate(txtFechaHasta.Text), "MM/dd/yyyy") & "# "
                strWhere = strWhere & " AND P.FECHA <= CDATE('" & Format(txtFechaHasta.Value, "dd/MM/yyyy") & "')"
            End If
            If txtDesde.Text <> "" Then
                strWhere = strWhere & " AND P.ID  >= " & txtDesde.Text & " "
            End If
            If txtHasta.Text <> "" Then
                strWhere = strWhere & " AND P.ID  <= " & txtHasta.Text & " "
            End If
            If chkImpresos.Checked And chkNoImpresos.Checked Then
                ' TODOS, NO SE FILTRA
            Else
                If chkImpresos.Checked Then
                    strWhere = strWhere & " AND (P.IMPRESO <> 0) "
                ElseIf chkNoImpresos.Checked Then
                    strWhere = strWhere & " AND (P.IMPRESO = 0) "
                Else
                    ' NO DEBE TRAER NADA SI NO SELECCIONA
                    strWhere = strWhere & " AND (P.ID = 0) "
                End If
            End If
            If txtBuscar.Text.Trim.Length > 0 Then
                strbuscar = "%" & txtBuscar.Text.Trim & "%"
                strWhere = strWhere & " AND (P.DESCRIPCION LIKE '" & strbuscar & "' OR  P.CODIGO LIKE '" & strbuscar & "') "
            End If
            strSQL = strSQL & strWhere & " AND Activo <> 0"
            strSQL = strSQL & " ORDER BY P.ID"

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
        'Me.dgArticulos.Columns(0).Visible = False 'Oculto el ID
        Me.dgArticulos.Columns("ID").Width = 60
        Me.dgArticulos.Columns("FECHA").Width = 120
        Me.dgArticulos.Columns("FECHA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("FECHA_CAMBIO_PRECIO").Width = 160
        Me.dgArticulos.Columns("FECHA_CAMBIO_PRECIO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("CODIGO").Width = 110
        Me.dgArticulos.Columns("CODIGO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("DESCRIPCION").Width = 550
        Me.dgArticulos.Columns("DESCRIPCION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("PRECIO").Width = 100
        Me.dgArticulos.Columns("PRECIO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgArticulos.Columns("IMPRIMIR").Width = 80
        Me.dgArticulos.Columns("CANTIDAD_ENVASE").Width = 0
        Me.dgArticulos.Columns("CANTIDAD_ENVASE").Visible = False
        Me.dgArticulos.Columns("UNIDAD").Width = 0
        Me.dgArticulos.Columns("UNIDAD").Visible = False

        Me.dgArticulos.Columns("ID").HeaderText = "Nº"
        Me.dgArticulos.Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("FECHA_CAMBIO_PRECIO").HeaderText = "CAMBIO EN IOFWIN"
        Me.dgArticulos.Columns("FECHA_CAMBIO_PRECIO").DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.dgArticulos.Columns("FECHA_CAMBIO_PRECIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("CODIGO").HeaderText = "CÓDIGO"
        Me.dgArticulos.Columns("CODIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("DESCRIPCION").HeaderText = "ARTÍCULO"
        Me.dgArticulos.Columns("PRECIO").HeaderText = "PRECIO"
        Me.dgArticulos.Columns("PRECIO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.dgArticulos.Columns("PRECIO").DefaultCellStyle.Format = "#,##0.00"
        Me.dgArticulos.Columns("FECHA").HeaderText = "FECHA"
        Me.dgArticulos.Columns("FECHA").DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.dgArticulos.Columns("FECHA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.dgArticulos.Columns("IMPRIMIR").HeaderText = ""
        Me.dgArticulos.Columns("IMPRIMIR").SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub

    Private Sub imgSalir_Click(sender As Object, e As EventArgs) Handles imgSalir.Click
        Call botonesOriginal()
        formularioActivo = False
        Me.Close()
    End Sub

    Private Sub imgBuscar_Click(sender As Object, e As EventArgs) Handles imgBuscar.Click
        Cargar_Grid()
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

    Private Sub imgImprimir_Click(sender As Object, e As EventArgs) Handles imgImprimir.Click

        Dim strSQL As String = ""
        Dim strWhere As String = ""
        Dim strbuscar As String = ""
        Dim f As frmCrystalReportVisor
        Dim informe As String
        Dim crTableLogoninfos As New CrystalDecisions.Shared.TableLogOnInfos
        Dim crTableLogoninfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim crConnectionInfo As New CrystalDecisions.Shared.ConnectionInfo
        Dim CrTables As CrystalDecisions.CrystalReports.Engine.Tables
        Dim CrTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim sUnidad As String = ""
        Dim nPrecio_Unidad As Double = 0
        Dim sPrecio1 As String
        Dim sPrecio2 As String
        Dim sPrecio3 As String

        Try
            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            strSQL = "DELETE FROM tbl_Imprimir"
            myDB.Ejecuta_SQL(strSQL)


            For Each fila As DataGridViewRow In dgArticulos.Rows
                If Not fila Is Nothing Then
                    If CBool(fila.Cells("IMPRIMIR").Value) Then
                        'CALCULO LA UNIDAD
                        If fila.Cells("CANTIDAD_ENVASE").Value > 1 Then
                            'Mostrar_Unidad_Envase
                            '**********************************
                            '**********************************
                            'ESTE IF ES PARA PREMIA (MARC VIDAL), LO QUIERE ASÍ
                            'If CLng(fila.Cells("CANTIDAD_ENVASE").Value.ToString()) >= 50 Or (LCase(fila.Cells("UNIDAD").Value.ToString()) = "uni" Or LCase(fila.Cells("UNIDAD").Value.ToString()) = "un" Or LCase(fila.Cells("UNIDAD").Value.ToString()) = "por unidad") Then
                            '**********************************
                            '**********************************
                            If CLng(fila.Cells("CANTIDAD_ENVASE").Value.ToString()) >= 50 And Mostrar_Unidad_Envase(LCase(fila.Cells("UNIDAD").Value.ToString())) = True Then
                                '002089
                                If CLng(fila.Cells("CANTIDAD_ENVASE").Value.ToString()) < 101 Then
                                    nPrecio_Unidad = CDbl(fila.Cells("PRECIO").Value.ToString()) / CLng(fila.Cells("CANTIDAD_ENVASE").Value.ToString())
                                    sUnidad = Math.Round(nPrecio_Unidad, 3) & "€ / " & fila.Cells("UNIDAD").Value.ToString()
                                Else
                                    nPrecio_Unidad = CDbl(fila.Cells("PRECIO").Value.ToString()) / CLng(fila.Cells("CANTIDAD_ENVASE").Value.ToString())
                                    nPrecio_Unidad = Math.Round(nPrecio_Unidad, 3) * 100
                                    sUnidad = Math.Round(nPrecio_Unidad, 3) & "€ / 100" & fila.Cells("UNIDAD").Value.ToString()
                                End If
                            Else
                                sUnidad = ""
                                End If
                            Else
                                sUnidad = ""
                        End If

                        sPrecio1 = Format(CDbl(fila.Cells("PRECIO").Value.ToString()), "#,##0.00") & " €"
                        sPrecio2 = Math.Truncate(fila.Cells("PRECIO").Value)
                        sPrecio3 = Replace(Format(CDbl(sPrecio1) - CDbl(sPrecio2), "#,##0.00"), "0,", "")
                        strSQL = "INSERT INTO tbl_Imprimir (ID_tbl_Articulos, CODIGO, DESCRIPCION, PRECIO, PRECIO2, PRECIO3, UNIDAD) "
                        strSQL = strSQL & " VALUES ( "
                        strSQL = strSQL & "'" & fila.Cells("ID").Value.ToString() & "', "
                        strSQL = strSQL & "'C.N. " & fila.Cells("CODIGO").Value.ToString() & "', "
                        strSQL = strSQL & "'" & fila.Cells("DESCRIPCION").Value.ToString() & "', "
                        strSQL = strSQL & "'" & sPrecio1 & "','" & sPrecio2 & "','" & sPrecio3 & "', "
                        strSQL = strSQL & "'" & sUnidad & "')"

                        myDB.Ejecuta_SQL(strSQL)
                        Application.DoEvents()

                        strSQL = "UPDATE tbl_Precios SET IMPRESO = 1 WHERE ID = " + fila.Cells("ID").Value.ToString()
                        myDB.Ejecuta_SQL(strSQL)
                        Application.DoEvents()
                    End If
                End If
            Next

            'strSQL = "UPDATE tbl_Imprimir, tbl_Configuracion SET tbl_Imprimir.LOGO = tbl_Configuracion.LOGO"
            'myDB.Ejecuta_SQL(strSQL)
            'Application.DoEvents()

            ' Archivo con el informe
            informe = Application.StartupPath & "\informes\etiqueta.rpt"
            ' Cargo el informe en la clase ReportDocument
            myReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            myReportDocument.Load(informe)
            myReportDocument.Refresh()

            With crConnectionInfo
                .ServerName = bdKrealabel 'Application.StartupPath + "\DATA\data.mdb"
                .DatabaseName = ""
                .UserID = ""
                .Password = ""
            End With
            CrTables = myReportDocument.Database.Tables
            For Each CrTable In CrTables
                crTableLogoninfo = CrTable.LogOnInfo
                crTableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crTableLogoninfo)
            Next

            ' Asigno el informe al visor
            f = New frmCrystalReportVisor
            f.informe = myReportDocument
            f.Owner = Form.ActiveForm
            f.formularioTitulo = "Etiquetas"
            f.enviarAImpresora = False
            f.Show()
            Cargar_Grid()
            Windows.Forms.Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_ImprimirEtiquetas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub dgArticulos_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgArticulos.CellPainting
        Dim pt As Point
        Dim offset As Integer

        If e.ColumnIndex = 6 And e.RowIndex = -1 Then
            e.PaintBackground(e.ClipBounds, False)
            pt = e.CellBounds.Location
            offset = (e.CellBounds.Width - images.ImageSize.Width) / 2
            pt.X += offset
            pt.Y += 1
            images.Draw(e.Graphics, pt, 0)
            e.Handled = True
        ElseIf e.ColumnIndex = 6 And e.RowIndex <> -1 Then
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

    Private Sub dgArticulos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgArticulos.ColumnHeaderMouseClick
        valorImpresion = Not valorImpresion
        If e.ColumnIndex = 6 And e.RowIndex = -1 Then
            If dgArticulos.Rows.Count > 0 Then
                For Each fila As DataGridViewRow In dgArticulos.Rows
                    If Not fila Is Nothing Then
                        fila.Cells("IMPRIMIR").Value = valorImpresion
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub dgArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgArticulos.CellClick
        Dim fila As DataGridViewRow
        Dim vImpresion As Boolean

        If e.ColumnIndex = 6 And e.RowIndex >= 0 Then
            If dgArticulos.SelectedRows.Count = 0 Then Exit Sub
            fila = dgArticulos.SelectedRows(0)
            If Not fila Is Nothing Then
                vImpresion = fila.Cells("IMPRIMIR").Value
                fila.Cells("IMPRIMIR").Value = Not vImpresion
            End If
        End If
    End Sub

    Private Sub txtDesde_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesde.GotFocus
        txtDesde.SelectionStart = 0
        txtDesde.SelectionLength = txtDesde.TextLength
        CreateCaret(txtDesde.Handle, New IntPtr(1), 3, txtDesde.Height)
        ShowCaret(txtDesde.Handle)
    End Sub

    Private Sub txtDesde_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesde.LostFocus
        txtDesde.SelectionStart = 0
        txtDesde.SelectionLength = 0
    End Sub
    Private Sub txtDesde_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDesde.Validating
        If txtDesde.Modified Then
            If txtDesde.TextLength > 0 Then
                If IsNumeric(txtDesde.Text) Then
                    txtDesde.Text = Format(CInt(txtDesde.Text))
                Else
                    MsgBox("Indique el ID desde.", MsgBoxStyle.Information)
                    e.Cancel = True
                End If
            Else
                'txtDesde.Text = "0"
                'txtDesde.Text = Format(CInt(txtDesde.Text))
            End If
        End If
    End Sub
    Private Sub txtDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesde.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> ChrW(System.Windows.Forms.Keys.Back) And e.KeyChar <> ChrW(System.Windows.Forms.Keys.Delete) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHasta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHasta.GotFocus
        txtHasta.SelectionStart = 0
        txtHasta.SelectionLength = txtHasta.TextLength
        CreateCaret(txtHasta.Handle, New IntPtr(1), 3, txtHasta.Height)
        ShowCaret(txtHasta.Handle)
    End Sub
    Private Sub txtHasta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHasta.LostFocus
        txtHasta.SelectionStart = 0
        txtHasta.SelectionLength = 0
    End Sub
    Private Sub txtHasta_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHasta.Validating
        If txtHasta.Modified Then
            If txtHasta.TextLength > 0 Then
                If IsNumeric(txtHasta.Text) Then
                    txtHasta.Text = Format(CInt(txtHasta.Text))
                Else
                    MsgBox("Indique el ID hasta.", MsgBoxStyle.Information)
                    e.Cancel = True
                End If
            Else
                'txtHasta.Text = "0"
                'txtHasta.Text = Format(CInt(txtHasta.Text))
            End If
        End If
    End Sub
    Private Sub txtHasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHasta.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> ChrW(System.Windows.Forms.Keys.Back) And e.KeyChar <> ChrW(System.Windows.Forms.Keys.Delete) Then
            e.Handled = True
        End If
    End Sub

    Private Sub imgValidar_Click(sender As Object, e As EventArgs) Handles imgValidar.Click
        If txtDesde.Text.Length = 0 Or txtHasta.Text.Length = 0 Then
            MsgBox("Debe indicar los valores desde-hasta ID para poder marcarlos.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If CInt(txtDesde.Text) > CInt(txtHasta.Text) Then
            MsgBox("El valor ID desde debe ser menor o igual al valor ID hasta.", MsgBoxStyle.Information)
            Exit Sub
        End If
        For Each fila As DataGridViewRow In dgArticulos.Rows
            If Not fila Is Nothing Then
                If CInt(fila.Cells("ID").Value) >= CInt(txtDesde.Text) And CInt(fila.Cells("ID").Value) <= CInt(txtHasta.Text) Then
                    fila.Cells("IMPRIMIR").Value = True
                End If
            End If
        Next
    End Sub

    Private Sub txtDesde_TextChanged(sender As Object, e As EventArgs) Handles txtDesde.TextChanged

    End Sub
End Class