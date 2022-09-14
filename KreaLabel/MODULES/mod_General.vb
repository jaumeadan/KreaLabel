
Module mod_General

    Public formularioActivo As Boolean

    Public myDB As cls_Conexion
    Public sCadena_Conexion As String = ""
    Public sCadena_Izaro As String = ""
    Public sError_Global As String = ""  ' Para controlar los errores de las llamadas a las funciones
    Public aSQL As New ArrayList
    Public sSQL As String = ""
    Public miFormPrincipal As Windows.Forms.Form
    Public bCargado_OK As Boolean = False
    Public nID_Nuevo As Long

    Public bdKrealabel As String
    Public bdFirebird As String
    Public licencia As String

    Public fecha As String
    '----------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------
    Public sCodigo_Producto As String = ""
    Public sNombre_Producto As String = ""
    Public sEAN_Producto As String = ""
    Public nPVP_Producto As Double = 0
    Public nPVPOferta_Producto As Double = 0
    Public nEuros_Unidad As Double = 0
    Public sUnidad_Producto As String = ""
    Public sDescUnidad_Producto As String = ""
    Public nIVA_Producto As Double = 0
    Public nREC_Producto As Double = 0
    Public dFecha_Cambio As Date
    Public sOrigen_Cambio As String = ""
    Public nCantidad_Envase As Long = 0
    Public nCantDiv As Double = 0

    Sub Main()
        miFormPrincipal = New frm_Principal
        miFormPrincipal.ShowDialog()
    End Sub

    Sub cargarBDFirebird()
        Dim strSQL As String
        Dim ds As New DataSet

        strSQL = "SELECT * FROM tbl_Configuracion"
        ds = myDB.Dame_Dataset(strSQL)

        If ds.Tables(0).Rows.Count = 0 Then

        Else
            bdFirebird = ds.Tables(0).Rows(0).Item("DB").ToString
            licencia = ds.Tables(0).Rows(0).Item("Licencia").ToString
        End If
    End Sub

    Public Function datStringToDate(ByVal strDataUsr As String, Optional ByVal boolErrorMsg As Boolean = False, Optional ByVal boolMes As Boolean = False) As Object
        '-------------------------------------------------------------------------------------
        '   Passa un str de format "DDMMAA", "DDMMAAAA" o un altre que el VB ja reconegui
        '   com a data a format data. Pensat per camps d'introducció de dates.
        '
        '	Pot retornar una data vàlida, o bé DBNull.Value
        ' 
        '   El tercer paràmetre indica que es vol introduir un mes, no un dia.
        '-------------------------------------------------------------------------------------
        Dim strData As String
        Dim datRes As Object

        Try
            strDataUsr = strDataUsr.Trim

            If strDataUsr.Length = 0 Then
                datRes = DBNull.Value

            ElseIf Not IsNumeric(strDataUsr) Then
                If IsDate(strDataUsr) Then
                    datRes = CDate(strDataUsr)
                Else
                    datRes = DBNull.Value
                End If
            Else
                Select Case strDataUsr.Length
                    Case 1, 2
                        If boolMes Then
                            strData = "01/" & strDataUsr & "/" & Year(Now)
                        Else
                            strData = strDataUsr & "/" & Month(Now) & "/" & Year(Now)
                        End If
                    Case 4
                        If boolMes Then
                            strData = "01/" & Left$(strDataUsr, 2) & "/" & Right$(strDataUsr, 2)
                        Else
                            strData = Left$(strDataUsr, 2) & "/" & Right$(strDataUsr, 2) & "/" & Year(Now)
                        End If
                    Case 6
                        If boolMes Then
                            strData = "01/" & Left$(strDataUsr, 2) & "/" & Right$(strDataUsr, 4)
                        Else
                            strData = Left$(strDataUsr, 2) & "/" & Mid$(strDataUsr, 3, 2) & "/" & Right$(strDataUsr, 2)
                        End If
                    Case 8
                        strData = Left$(strDataUsr, 2) & "/" & Mid$(strDataUsr, 3, 2) & "/" & Right$(strDataUsr, 4)
                    Case Else
                        strData = ""
                End Select

                If IsDate(strData) Then
                    datRes = CDate(strData)
                Else
                    datRes = DBNull.Value
                End If
            End If

            If boolErrorMsg Then
                If (strDataUsr.Length <> 0) AndAlso IsDBNull(datRes) Then
                    MsgBox("Debe introducir una fecha.")
                End If
            End If

            Return datRes

        Catch ex As Exception
            'ShowException(ex)
            Return Nothing
        End Try
    End Function

    'Sub Cargar()
    '    myDB = New cls_Conexion
    '    If myDB.Test_Conexion() = False Then
    '        MsgBox("Hay un error de conexión con la base de datos.", 16, "Error")
    '        bCargado_OK = False
    '    Else
    '        bCargado_OK = True
    '    End If
    'End Sub

    Public Sub botonesOriginal()
        frm_Principal.lblTitulo.Text = ""
        frm_Principal.imgLogoFondo.Visible = True
        frm_Principal.imgArticulos.Visible = True
        frm_Principal.imgPrecios.Visible = True
        frm_Principal.imgImprimir.Visible = True
        frm_Principal.imgConfiguracion.Visible = True
        frm_Principal.imgArticulosSeleccionado.Visible = False
        frm_Principal.imgPreciosSeleccionado.Visible = False
        frm_Principal.imgImprimirSeleccionado.Visible = False
        frm_Principal.imgConfiguracionSeleccionado.Visible = False
        frm_Principal.imgLogoFondo.Visible = True
    End Sub

    Sub Reset_Variables()

        sCodigo_Producto = ""
        sNombre_Producto = ""
        sEAN_Producto = ""
        nPVP_Producto = 0
        nPVPOferta_Producto = 0
        nEuros_Unidad = 0
        sUnidad_Producto = ""
        sDescUnidad_Producto = ""
        nIVA_Producto = 0
        nREC_Producto = 0
        sOrigen_Cambio = ""
        nCantidad_Envase = 0
        nCantDiv = 0

    End Sub

End Module
