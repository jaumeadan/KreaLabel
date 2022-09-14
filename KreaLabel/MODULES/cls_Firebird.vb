Imports FirebirdSql.Data.FirebirdClient

Public Class cls_Firebird

    Dim Conexion As New FbConnection
    Dim fb_string As FbConnectionStringBuilder = New FbConnectionStringBuilder

    Public Sub conectar(sDB As String, sUsuario As String, sPassword As String)
        ' Se forma la cadena de conexion
        fb_string.ServerType = FbServerType.Default
        fb_string.UserID = sUsuario
        fb_string.Password = sPassword
        fb_string.Dialect = 3
        fb_string.Database = sDB
        fb_string.Pooling = False
        ' se realiza la conexion

        Try
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If

            Conexion.ConnectionString = "User=" & sUsuario & ";Password=" & sPassword & ";Database=" & sDB & ";DataSource=localhost;Port=3050;Dialect=3;"
            Conexion.Open()

            If Conexion.State = ConnectionState.Open Then
                MsgBox("Conexión a [" & fb_string.Database & "] establecida", 64, "Información")
            End If

        Catch err As FbException
            MsgBox("Error: No se pudo realizar la conexión a [" & fb_string.Database & "]" & vbCrLf & vbCrLf & err.Message, 16, "Error")
            Console.WriteLine(err.Message)
        End Try

    End Sub

    Public Sub Desconectar()
        If (ConnectionState.Open) Then
            Conexion.Close()
            Console.WriteLine("Conexión a [" & fb_string.Database & "] cerrada")
        End If
    End Sub

    Public Sub Consulta()
        Dim sql As String = "SELECT * FROM ARTICLES_MESTRE"
        Dim cmd As New FbCommand(sql, Conexion)
        Dim fbdatareader As FbDataReader = cmd.ExecuteReader

        While (fbdatareader.Read)
            Dim id As String = fbdatareader.GetString(0)
            Dim nombre As String = fbdatareader.GetString(1)
            MsgBox("" & id & " | " & nombre)
            Exit Sub
        End While

    End Sub

End Class
