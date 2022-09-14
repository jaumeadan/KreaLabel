
Module mod_General

    Public myDB As cls_Conexion
    Public sCadena_Conexion As String = ""
    Public sCadena_Izaro As String = ""
    Public sError_Global As String = ""  ' Para controlar los errores de las llamadas a las funciones
    Public aSQL As New ArrayList
    Public sSQL As String = ""
    Public miFormPrincipal As Windows.Forms.Form
    Public bCargado_OK As Boolean = False
    Public nID_Nuevo As Long

    Sub Main()

        miFormPrincipal = New frm_Principal

        miFormPrincipal.ShowDialog()

    End Sub
    Sub Cargar()

        myDB = New cls_Conexion

        If myDB.Test_Conexion() = False Then
            MsgBox("Hay un error de conexión con la base de datos.", 16, "Error")
            bCargado_OK = False
        Else
            bCargado_OK = True
        End If

    End Sub

End Module
