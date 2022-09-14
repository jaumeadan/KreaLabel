Imports System.Threading
Public Class frm_Welcome
    Private Sub frm_Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBD.Visible = False
        txtBD.Visible = False
        imgBD.Visible = False
        imgBarra.Visible = False
        imgValidar.Visible = False
        Me.txtUsuario.Focus()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtContraseña_Validated(sender As Object, e As EventArgs) Handles txtContraseña.Validated
        If Me.txtContraseña.Text & "" = "admin" Then

            bdKrealabel = My.Settings.Ruta_BD.ToString
            If bdKrealabel = "" Then
                MsgBox("No se ha definido la BD Krealabel. Por favor, configúre la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
                lblusuario.Visible = False
                txtUsuario.Visible = False
                lblContraseña.Visible = False
                txtContraseña.Visible = False
                lblBD.Visible = True
                txtBD.Visible = True
                imgBD.Visible = True
                imgValidar.Visible = True
                Exit Sub
            End If
            myDB = New cls_Conexion
            If Not myDB.Test_Conexion Then
                MsgBox("No se ha definido la BD Krealabel. Por favor, configúre la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
                lblusuario.Visible = False
                txtUsuario.Visible = False
                lblContraseña.Visible = False
                txtContraseña.Visible = False
                lblBD.Visible = True
                txtBD.Visible = True
                imgBD.Visible = True
                imgValidar.Visible = True
                Exit Sub
            End If
            imgBarra.Visible = True
            frm_Principal.ShowDialog()
            Me.Close()
        End If
    End Sub
    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub imgBD_Click(sender As Object, e As EventArgs) Handles imgBD.Click
        ofdBDLogo.Title = "Seleccione base de datos"
        ofdBDLogo.FileName = ""
        ofdBDLogo.InitialDirectory = "C:\"
        ofdBDLogo.CheckPathExists = True
        ofdBDLogo.Filter = "BD de Firebird (*.mdb)|*.mdb"
        ofdBDLogo.ShowDialog()
        If ofdBDLogo.FileName <> "" Then
            txtBD.Text = ofdBDLogo.FileName
        End If
    End Sub

    Private Sub imgValidar_Click(sender As Object, e As EventArgs) Handles imgValidar.Click
        If txtBD.Text.Length = 0 Then
            MsgBox("No se ha definido la BD Krealabel. Por favor, configúre la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
            Exit Sub
        End If
        bdKrealabel = txtBD.Text
        If bdKrealabel = "" Then
            MsgBox("No se ha definido la BD Krealabel. Por favor, configúre la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
            lblusuario.Visible = False
            txtUsuario.Visible = False
            lblContraseña.Visible = False
            txtContraseña.Visible = False
            lblBD.Visible = True
            txtBD.Visible = True
            imgBD.Visible = True
            Exit Sub
        End If
        myDB = New cls_Conexion
        If Not myDB.Test_Conexion Then
            MsgBox("No se ha definido la BD Krealabel. Por favor, configúre la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
            lblusuario.Visible = False
            txtUsuario.Visible = False
            lblContraseña.Visible = False
            txtContraseña.Visible = False
            lblBD.Visible = True
            txtBD.Visible = True
            imgBD.Visible = True
            Exit Sub
        End If
        My.Settings.Ruta_BD = bdKrealabel
        imgBarra.Visible = True
        frm_Principal.ShowDialog()
        Me.Close()
    End Sub

    Private Sub imgLogo_Click(sender As Object, e As EventArgs) Handles imgLogo.Click
        Me.Close()
    End Sub
End Class