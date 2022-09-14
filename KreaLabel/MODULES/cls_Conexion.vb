Public Class cls_Conexion
    Public conexion_Jet As New OleDbConnection

    Public Sub New()
        Set_Cadena()
    End Sub

    Sub Set_Cadena()
        'MsgBox(bdKrealabel)
        sCadena_Conexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + bdKrealabel 'Application.StartupPath & "\DATA\data.mdb"
        'sCadena_Conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath & "\DATA\data.mdb"
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
        Return True
    End Function

    Function Dame_Dataset(sSQL As String) As DataSet
        Dim miDS As New DataSet

        Try
            Dim miAdaptador As New OleDbDataAdapter(sSQL, sCadena_Conexion)
            miAdaptador.Fill(miDS)
            miAdaptador.Dispose()

        Catch ex As Exception
            MsgBox("Error función Dataset" & vbCrLf & ex.Message, 16, "Error")
        End Try

        Return miDS
    End Function

    Function Ejecuta_SQL(sSQL As String) As Boolean
        Try
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
        Catch ex As Exception
            MsgBox("Error Ejecuta SQL5: " & vbCrLf & ex.Message, 16, "Error")
            Return False
        End Try

        Return True
    End Function

    'Function Ejecuta_SQL(sSQL As String, parametros As List(Of OleDbParameter)) As Boolean
    '    Dim par As OleDbParameter
    '    Try
    '        Try
    '            Dim miConexion As New OleDbConnection(sCadena_Conexion)
    '            Dim miComando As New OleDbCommand(sSQL, miConexion)
    '            miConexion.Open()
    '            For Each par In parametros
    '                miComando.Parameters.AddWithValue(par.ParameterName, par.Value)
    '            Next
    '            miComando.ExecuteNonQuery()
    '            miComando.Dispose()
    '            miConexion.Close()
    '        Catch oleex As OleDbException
    '            MsgBox("Error Ejecuta SQL3: " & vbCrLf & oleex.Message, 16, "Error")
    '            Return False
    '        Catch ex As Exception
    '            MsgBox("Error Ejecuta SQL4: " & vbCrLf & ex.Message, 16, "Error")
    '            Return False
    '        End Try
    '    Catch ex As Exception
    '        MsgBox("Error Ejecuta SQL5: " & vbCrLf & ex.Message, 16, "Error")
    '        Return False
    '    End Try

    '    Return True
    'End Function

End Class
