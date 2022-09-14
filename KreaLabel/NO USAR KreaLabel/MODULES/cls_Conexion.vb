Public Class cls_Conexion
    'Public conexion_SQLServer As New SqlConnection
    Public conexion_Jet As New OleDbConnection

    Public Sub New()

        Set_Cadena()

    End Sub

    Sub Set_Cadena()
        Select Case My.Settings.Conexion
            Case "Microsoft SQL Server"
                If My.Settings.Autenticacion = True Then
                    sCadena_Conexion = "Server=" & My.Settings.Host &
                        ";Database=" & My.Settings.DB &
                        ";Trusted_connection=True;Persist security info=false;Connection Timeout=10"
                Else
                    sCadena_Conexion = "Server=" & My.Settings.Host &
                        ";Database=" & My.Settings.DB &
                        ";User ID=" & My.Settings.Usuario &
                        ";Password=" & My.Settings.Password &
                        ";Trusted_connection=false;Persist security info=false;Connection Timeout=10"
                End If

            Case "Microsoft Jet"
                sCadena_Conexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Settings.Ruta_MDB.ToString

        End Select
    End Sub

    Public Property Cadena_Conexion() As String

        Get
            Return sCadena_Conexion
        End Get

        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then
                sCadena_Conexion = value
            End If
        End Set

    End Property

    Function Test_Conexion() As Boolean

        Select Case My.Settings.Conexion
            Case "Microsoft SQL Server"
                'Try
                '    If conexion_SQLServer.State = Nothing Then
                '        conexion_SQLServer.ConnectionString = sCadena_Conexion
                '        conexion_SQLServer.Open()
                '        conexion_SQLServer.Close()
                '    End If
                '    If conexion_SQLServer.State = ConnectionState.Closed Then
                '        conexion_SQLServer.ConnectionString = sCadena_Conexion
                '        conexion_SQLServer.Open()
                '        conexion_SQLServer.Close()
                '    End If
                'Catch SqlEx As SqlException
                '    For Each myError In SqlEx.Errors
                '        MsgBox(myError.Number & " - " & myError.Message, 16, "Error Conexión Microsoft SQL Server")
                '    Next
                '    Return False
                'Catch ex As Exception
                '    MsgBox("Error Exception SQL Server: " & vbCrLf & ex.Message, 16, "Error Conexión Microsoft SQL Server")
                '    Return False
                'End Try

            Case "Microsoft Jet"
                Try
                    If conexion_Jet.State = Nothing Then
                        conexion_Jet.ConnectionString = sCadena_Conexion
                        conexion_Jet.Open()
                        conexion_Jet.Close()
                    End If
                    If conexion_Jet.State = ConnectionState.Closed Then
                        conexion_Jet.ConnectionString = sCadena_Conexion
                        conexion_Jet.Open()
                        conexion_Jet.Close()
                    End If
                Catch oleDBex As OleDbException
                    For Each myError In oleDBex.Errors
                        MsgBox(myError.Message, 16, "Error Conexión Microsoft Access")
                    Next
                    Return False
                Catch ex As Exception
                    MsgBox("Error Exception Access: " & vbCrLf & ex.Message, 16, "Error Conexión Microsoft Access")
                    Return False
                End Try
        End Select

        Return True

    End Function

    Function Dame_Dataset(sSQL As String) As DataSet

        Dim miDS As New DataSet

        Try
            Select Case My.Settings.Conexion
                Case "Microsoft SQL Server"
                    'Dim miAdaptador As New SqlDataAdapter(sSQL, sCadena_Conexion)
                    'miAdaptador.Fill(miDS)
                    'miAdaptador.Dispose()
                Case "Microsoft Jet"
                    Dim miAdaptador As New OleDbDataAdapter(sSQL, sCadena_Conexion)
                    miAdaptador.Fill(miDS)
                    miAdaptador.Dispose()
            End Select

        Catch ex As Exception
            MsgBox("Error función Dataset" & vbCrLf & ex.Message, 16, "Error")
        End Try

        Return miDS

    End Function

    Function Ejecuta_SQL(sSQL As String) As Boolean

        Try
            Select Case My.Settings.Conexion
                Case "Microsoft SQL Server"
                    'Try
                    '    Dim miConexion As New SqlConnection(sCadena_Conexion)
                    '    Dim miComando As New SqlCommand(sSQL, miConexion)
                    '    miConexion.Open()
                    '    miComando.ExecuteNonQuery()
                    '    miComando.Dispose()
                    '    miConexion.Close()
                    'Catch sqlex As SqlException
                    '    MsgBox("Error Ejecuta SQL: " & vbCrLf & sqlex.Message, 16, "Error")
                    '    Return False
                    'Catch ex As Exception
                    '    MsgBox("Error Ejecuta SQL2: " & vbCrLf & ex.Message, 16, "Error")
                    '    Return False
                    'End Try
                Case "Microsoft Jet"
                    Try
                        Dim miConexion As New OleDbConnection(sCadena_Conexion)
                        Dim miComando As New OleDbCommand(sSQL, miConexion)
                        miConexion.Open()
                        miComando.ExecuteNonQuery()
                        miComando.Dispose()
                        miConexion.Close()
                    Catch oleex As OleDbException
                        MsgBox("Error Ejecuta SQL3: " & vbCrLf & oleex.Message, 16, "Error")
                        Return False
                    Catch ex As Exception
                        MsgBox("Error Ejecuta SQL4: " & vbCrLf & ex.Message, 16, "Error")
                        Return False
                    End Try
            End Select
        Catch ex As Exception
            MsgBox("Error Ejecuta SQL5: " & vbCrLf & ex.Message, 16, "Error")
            Return False
        End Try

        Return True

    End Function

End Class
