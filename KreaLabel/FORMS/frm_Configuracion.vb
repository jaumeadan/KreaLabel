Imports System.IO

Public Class frm_Configuracion

    Dim imagenLocalizacion As String = ""

    Private Declare Function CreateCaret Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal hBitmap As IntPtr, ByVal nWidth As Int32, ByVal nHeight As Int32) As IntPtr
    Private Declare Function ShowCaret Lib "user32.dll" (ByVal hwnd As IntPtr) As Int32

    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
    End Sub

    Private Sub frm_Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarDatos()
        Call modosPantalla("Lectura")
    End Sub

    Private Sub AbrirFormPanel(ByVal FormHijo As Object)
        If Me.panelForm.Controls.Count > 0 Then
            Me.panelForm.Controls.RemoveAt(0)
        End If

        Dim fh As Windows.Forms.Form = TryCast(FormHijo, Windows.Forms.Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.panelForm.Controls.Add(fh)
        Me.panelForm.Tag = fh
        fh.Show()
    End Sub

    Private Sub txtRazonSocial_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRazonSocial.GotFocus
        txtRazonSocial.SelectionStart = 0
        txtRazonSocial.SelectionLength = txtRazonSocial.TextLength
        CreateCaret(txtRazonSocial.Handle, New IntPtr(1), 3, txtRazonSocial.Height)
        ShowCaret(txtRazonSocial.Handle)
    End Sub

    Private Sub txtRazonSocial_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRazonSocial.LostFocus
        txtRazonSocial.SelectionStart = 0
        txtRazonSocial.SelectionLength = 0
    End Sub

    Private Sub txtNombreComercial_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreComercial.GotFocus
        txtNombreComercial.SelectionStart = 0
        txtNombreComercial.SelectionLength = txtNombreComercial.TextLength
        CreateCaret(txtNombreComercial.Handle, New IntPtr(1), 3, txtNombreComercial.Height)
        ShowCaret(txtNombreComercial.Handle)
    End Sub

    Private Sub txtNombreComercial_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreComercial.LostFocus
        txtNombreComercial.SelectionStart = 0
        txtNombreComercial.SelectionLength = 0
    End Sub

    Private Sub txtNif_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNif.GotFocus
        txtNif.SelectionStart = 0
        txtNif.SelectionLength = txtNif.TextLength
        CreateCaret(txtNif.Handle, New IntPtr(1), 3, txtNif.Height)
        ShowCaret(txtNif.Handle)
    End Sub

    Private Sub txtNif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNif.LostFocus
        txtNif.SelectionStart = 0
        txtNif.SelectionLength = 0
    End Sub

    Private Sub txtLicencia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLicencia.GotFocus
        txtLicencia.SelectionStart = 0
        txtLicencia.SelectionLength = txtLicencia.TextLength
        CreateCaret(txtLicencia.Handle, New IntPtr(1), 3, txtLicencia.Height)
        ShowCaret(txtLicencia.Handle)
    End Sub

    Private Sub txtLicencia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLicencia.LostFocus
        txtLicencia.SelectionStart = 0
        txtLicencia.SelectionLength = 0
    End Sub

    Private Sub txtDireccion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.GotFocus
        txtDireccion.SelectionStart = 0
        txtDireccion.SelectionLength = txtDireccion.TextLength
        CreateCaret(txtDireccion.Handle, New IntPtr(1), 3, txtDireccion.Height)
        ShowCaret(txtDireccion.Handle)
    End Sub

    Private Sub txtDireccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.LostFocus
        txtDireccion.SelectionStart = 0
        txtDireccion.SelectionLength = 0
    End Sub

    Private Sub txtTelefono_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefono.GotFocus
        txtTelefono.SelectionStart = 0
        txtTelefono.SelectionLength = txtTelefono.TextLength
        CreateCaret(txtTelefono.Handle, New IntPtr(1), 3, txtTelefono.Height)
        ShowCaret(txtTelefono.Handle)
    End Sub

    Private Sub txtTelefono_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefono.LostFocus
        txtTelefono.SelectionStart = 0
        txtTelefono.SelectionLength = 0
    End Sub

    Private Sub btnSeleccionarLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarLogo.Click
        Dim strFicheroNombre As String
        Dim strDirectorio As String
        Dim imagen As Image

        Try
            ofdBDLogo.Title = "Indique la ubicación y nombre del fichero del logo"
            ofdBDLogo.FileName = ""
            ofdBDLogo.InitialDirectory = "C:\"
            ofdBDLogo.CheckPathExists = True
            ofdBDLogo.Filter = "Archivos de imagen (*.jpg)|*.jpg"
            ofdBDLogo.ShowDialog()
            strFicheroNombre = ofdBDLogo.FileName
            If Len(strFicheroNombre) > 0 Then
                imgLogo.ImageLocation = strFicheroNombre
                imgLogo.Load(strFicheroNombre)
                Application.DoEvents()

                strDirectorio = Application.StartupPath
                imagen = New Bitmap(imgLogo.Image, New Size(64, 64))
                imagen.Save(strDirectorio & "\logo.jpg", Imaging.ImageFormat.Jpeg)
                Application.DoEvents()

                imagenLocalizacion = strDirectorio & "\logo.jpg"
                imgLogo.ImageLocation = strDirectorio & "\logo.jpg"
                imgLogo.Load(strDirectorio & "\logo.jpg")
            Else
                imgLogo = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " - btnSeleccionarLogo_Click")
        End Try
    End Sub

    Private Sub txtDB_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDB.GotFocus
        txtDB.SelectionStart = 0
        txtDB.SelectionLength = txtDB.TextLength
        CreateCaret(txtDB.Handle, New IntPtr(1), 3, txtDB.Height)
        ShowCaret(txtDB.Handle)
    End Sub

    Private Sub txtDB_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDB.LostFocus
        txtDB.SelectionStart = 0
        txtDB.SelectionLength = 0
    End Sub

    Private Sub modosPantalla(ByVal modoPantalla As String)
        Dim ctl As System.Windows.Forms.Control
        Dim ctlC As System.Windows.Forms.Control
        Dim txt As System.Windows.Forms.TextBox
        Dim mtb As System.Windows.Forms.MaskedTextBox

        If modoPantalla = "Lectura" Then
            ' Campos
            For Each ctl In Me.Controls
                Select Case ctl.GetType.Name
                    Case "Panel"
                        For Each ctlC In ctl.Controls
                            Select Case ctlC.GetType.Name
                                Case "TextBox"
                                    txt = CType(ctlC, System.Windows.Forms.TextBox)
                                    With txt
                                        .BackColor = Color.LightYellow
                                        .Enabled = False
                                        .ReadOnly = True
                                    End With
                                Case "MaskedTextBox"
                                    mtb = CType(ctlC, System.Windows.Forms.MaskedTextBox)
                                    With mtb
                                        .BackColor = Color.LightYellow
                                        .Enabled = False
                                        .ReadOnly = True
                                    End With
                            End Select
                        Next
                End Select
            Next

            ' Botones
            imgEditar.Enabled = True
            imgGuardar.Enabled = False
            imgCancelar.Enabled = False
            imgBrowser.Enabled = False
            btnSeleccionarLogo.Enabled = False
            imgSalir.Enabled = True

        ElseIf modoPantalla = "Edicion" Then
            ' Campos
            For Each ctl In Me.Controls
                Select Case ctl.GetType.Name
                    Case "Panel"
                        For Each ctlC In ctl.Controls
                            Select Case ctlC.GetType.Name
                                Case "TextBox"
                                    txt = CType(ctlC, System.Windows.Forms.TextBox)
                                    With txt
                                        .BackColor = Color.White
                                        .Enabled = True
                                        .ReadOnly = False
                                    End With
                                Case "MaskedTextBox"
                                    mtb = CType(ctlC, System.Windows.Forms.MaskedTextBox)
                                    With mtb
                                        .BackColor = Color.White
                                        .Enabled = True
                                        .ReadOnly = False
                                    End With
                            End Select
                        Next
                End Select
            Next

            ' Botones
            imgEditar.Enabled = False
            imgGuardar.Enabled = True
            imgCancelar.Enabled = True
            imgBrowser.Enabled = True
            btnSeleccionarLogo.Enabled = True
            imgSalir.Enabled = False
        End If
    End Sub

    Private Sub limpiarDatos()
        txtRazonSocial.Clear()
        txtNombreComercial.Clear()
        txtNif.Clear()
        txtLicencia.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtDB.Clear()
        'txtUsuario.Clear()
        'txtPassword.Clear()

        imgLogo.ImageLocation = Nothing
        imagenLocalizacion = ""
    End Sub

    Private Sub cargarDatos()
        Dim strSQL As String
        Dim ds As New DataSet

        Try
            Call limpiarDatos()

            strSQL = "SELECT * FROM tbl_Configuracion"
            ds = myDB.Dame_Dataset(strSQL)

            If ds.Tables(0).Rows.Count = 0 Then
                System.Media.SystemSounds.Beep.Play()
                System.Media.SystemSounds.Exclamation.Play()
            Else
                txtRazonSocial.Text = ds.Tables(0).Rows(0).Item("RazonSocial").ToString
                txtNombreComercial.Text = ds.Tables(0).Rows(0).Item("NombreComercial").ToString
                txtNif.Text = ds.Tables(0).Rows(0).Item("CIF").ToString
                txtLicencia.Text = ds.Tables(0).Rows(0).Item("Licencia").ToString
                txtDireccion.Text = ds.Tables(0).Rows(0).Item("Direccion").ToString
                txtTelefono.Text = ds.Tables(0).Rows(0).Item("Telefono").ToString
                txtDB.Text = ds.Tables(0).Rows(0).Item("DB").ToString
                'txtUsuario.Text = ds.Tables(0).Rows(0).Item("Usuario").ToString
                'txtPassword.Text = ds.Tables(0).Rows(0).Item("Password").ToString

                If ds.Tables(0).Rows(0).Item("RutaLogo") IsNot DBNull.Value Then
                    If ds.Tables(0).Rows(0).Item("RutaLogo").ToString() = "" Then
                        imagenLocalizacion = ""
                    Else
                        imagenLocalizacion = ds.Tables(0).Rows(0).Item("RutaLogo").ToString()
                        imgLogo.ImageLocation = ds.Tables(0).Rows(0).Item("RutaLogo").ToString()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + " - cargarDatos")
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)
    End Function

    Public Function conversionImagen(fichero As String) As Byte()
        Dim fs As New IO.FileStream(fichero, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)

        fs.Position = 0
        Dim imgLength As Integer = CInt(fs.Length)
        Dim bytes(0 To imgLength - 1) As Byte
        fs.Read(bytes, 0, imgLength)
        fs.Close()

        conversionImagen = bytes
    End Function

    Private Sub guardarDatos()
        Dim strSQL As String
        Dim parametros = New List(Of OleDbParameter)

        Try
            strSQL = "DELETE FROM tbl_Configuracion"
            myDB.Ejecuta_SQL(strSQL)

            strSQL = "INSERT INTO tbl_Configuracion ([RazonSocial], [NombreComercial], [CIF], [Licencia], [Direccion], [Telefono], [DB]) "
            strSQL = strSQL & " VALUES ('" & txtRazonSocial.Text & "', "
            strSQL = strSQL & " '" & txtNombreComercial.Text & "', "
            strSQL = strSQL & " '" & txtNif.Text & "', "
            strSQL = strSQL & " '" & txtLicencia.Text & "', "
            strSQL = strSQL & " '" & txtDireccion.Text & "', "
            strSQL = strSQL & " '" & txtTelefono.Text.Trim & "', "
            strSQL = strSQL & " '" & txtDB.Text & "') "

            myDB.Ejecuta_SQL(strSQL)

            'Dim miConexion As New OleDbConnection(sCadena_Conexion)
            'miConexion.Open()
            'Dim miComando As New OleDbCommand("UPDATE tbl_Configuracion SET LOGO = @logo", miConexion)
            'miComando.Parameters.AddWithValue("@logo", conversionImagen(imagenLocalizacion))
            'miComando.ExecuteNonQuery()
            'miConexion.Close()

            bdFirebird = txtDB.Text
            licencia = txtLicencia.Text

        Catch ex As Exception
            MessageBox.Show(ex.Message + " - guardarDatos")
            Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub frm_Configuracion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub imgEditar_Click(sender As Object, e As EventArgs) Handles imgEditar.Click
        Call modosPantalla("Edicion")
    End Sub

    Private Sub imgGuardar_Click(sender As Object, e As EventArgs) Handles imgGuardar.Click
        Call guardarDatos()
        Call cargarDatos()
        Call modosPantalla("Lectura")
    End Sub

    Private Sub imgCancelar_Click(sender As Object, e As EventArgs) Handles imgCancelar.Click
        Call cargarDatos()
        Call modosPantalla("Lectura")
    End Sub
    Private Sub imgSalir_Click(sender As Object, e As EventArgs) Handles imgSalir.Click
        Call botonesOriginal()
        formularioActivo = False
        Close()
    End Sub
    Private Sub imgBrowser_Click(sender As Object, e As EventArgs) Handles imgBrowser.Click
        ofdBDLogo.Title = "Seleccione base de datos Firebird"
        ofdBDLogo.FileName = ""
        ofdBDLogo.InitialDirectory = "C:\"
        ofdBDLogo.CheckPathExists = True
        ofdBDLogo.Filter = "BD de Firebird (*.fdb)|*.fdb"
        ofdBDLogo.ShowDialog()
        If ofdBDLogo.FileName <> "" Then
            txtDB.Text = ofdBDLogo.FileName
        End If
    End Sub

End Class