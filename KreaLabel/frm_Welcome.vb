Imports System.Threading
Public Class frm_Welcome
    Private Sub frm_Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtUsuario.Focus()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtContraseña_Validated(sender As Object, e As EventArgs) Handles txtContraseña.Validated
        If Me.txtContraseña.Text & "" = "admin" Then
            imgBarra.Visible = True
            Me.Close()
            Me.Visible = False
            Application.DoEvents()
            frm_Principal.ShowDialog()
        End If
    End Sub
    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub imgLogo_Click(sender As Object, e As EventArgs) Handles imgLogo.Click
        Me.Close()
    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub
End Class