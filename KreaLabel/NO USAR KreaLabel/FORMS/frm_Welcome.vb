Imports System.Threading
Public Class frm_Welcome
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        CircularProgressBar1.Value += 1
        CircularProgressBar1.Text = CircularProgressBar1.Value.ToString()
        If (Me.Opacity < 1) Then Me.Opacity += 0.05
        If (CircularProgressBar1.Value = 100) Then
            Timer1.Stop()
            Timer2.Start()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Me.Opacity -= 0.1
        If (Me.Opacity = 0) Then
            Timer2.Stop()
            'Me.Close()
            frm_Principal.ShowDialog()

        End If

    End Sub

    Private Sub frm_Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CircularProgressBar1.Value = 0
        CircularProgressBar1.Maximum = 100
        CircularProgressBar1.Minimum = 0
        Me.txtUsuario.Focus()
        'Me.Opacity = 0.0
        'Timer1.Start()

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtUsuario_Validated(sender As Object, e As EventArgs) Handles txtUsuario.Validated
        If LCase(Me.txtUsuario.Text) & "" = "admin" Then
            Me.lblNomUsuario.Visible = True
            Me.lblNomUsuario.Text = "Administrador"
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtContraseña_Validated(sender As Object, e As EventArgs) Handles txtContraseña.Validated

        If Me.txtContraseña.Text & "" = "admin" Then
            Entrar()
        End If

    End Sub

    Sub Entrar()

        Me.CircularProgressBar1.Visible = True
        Timer1.Start()

        'frm_Principal.ShowDialog()

    End Sub

    Private Sub btn_Entrar_Click(sender As Object, e As EventArgs) Handles btn_Entrar.Click

        Entrar()

    End Sub

    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class