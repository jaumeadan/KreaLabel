Imports System.Threading
Public Class frm_RutaBD
    Private Sub frm_RutaBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBD.Text = bdKrealabel
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
            Exit Sub
        End If
        myDB = New cls_Conexion
        If Not myDB.Test_Conexion Then
            MsgBox("No se ha definido la BD Krealabel. Por favor, configúre la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
            Exit Sub
        End If
        My.Settings.Ruta_BD = bdKrealabel
    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub
End Class