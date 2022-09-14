Imports FirebirdSql.Data.FirebirdClient

Public Class frm_Firebird

    Dim Firebird As New cls_Firebird

    Private Sub btn_Test_Click(sender As Object, e As EventArgs) Handles btn_Test.Click

        Firebird.conectar(Me.txtDB.Text, Me.txtUsuario.Text, Me.txtPassword.Text)

    End Sub

    Private Sub btn_Browser_Click(sender As Object, e As EventArgs) Handles btn_Browser.Click


        Me.OpenFileDialog1.Title = "Seleccione base de datos Firebird..."
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.FileName = ""
        Me.OpenFileDialog1.ShowDialog()
        If Me.OpenFileDialog1.FileName <> "" Then
            Me.txtDB.Text = Me.OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Firebird.Consulta()

    End Sub
End Class