Imports System.IO
Imports System.Text

Module mod_Funciones

    Function Dame_Ultima_Fecha()

        Dim ds As New DataSet
        Dim dr As DataRow
        Dim miFecha As Date

        ds = myDB.Dame_Dataset("Select MAX(FECHA) AS FechaSolicitar From tbl_Precios")

        If ds.Tables(0).Rows.Count <> 0 Then
            dr = ds.Tables(0).Rows(0)
            If dr("FechaSolicitar").ToString() = "" Then
                miFecha = DateAdd("d", -150, Now.Date)
            Else
                miFecha = CDate(dr("FechaSolicitar").ToString())
            End If
        Else
            miFecha = DateAdd("d", 150, Now.Date)
        End If

        Return miFecha

    End Function


    Function Transforma_XML(sTexto As String) As String

        Dim sPath As String = Application.StartupPath & "\convert.krl"
        Dim sFinal As String = ""

        Dim miFichero As New FileStream(sPath, FileMode.Create,
                                       FileAccess.Write)


        Dim miTexto As New StreamWriter(miFichero)
        miTexto.WriteLine(sTexto)
        miTexto.Close()
        miFichero.Close()

        Dim miOrigen As String
        'miOrigen = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\convert.krl", System.Text.Encoding.ASCII)
        miOrigen = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\convert.krl", System.Text.Encoding.UTF8)

        sFinal = Replace(miOrigen, "&lt;![CDATA[", "")
        sFinal = Replace(sFinal, "]]&gt;", "")

        Transforma_XML = sFinal

        'Dim objFichero2 As New FileStream("c:\backups\prueba2.txt", FileMode.Create,
        '                               FileAccess.Write)

        'Dim objStream2 As New StreamWriter(objFichero2)
        'objStream2.WriteLine(sFinal)
        'objStream2.Close()
        'objFichero2.Close()

    End Function

    Function Transforma_XML2(sTexto As String) As String

        Dim sPath As String = Application.StartupPath & "\convert.krl"
        Dim sFinal As String = ""

        Dim miFichero As New FileStream(sPath, FileMode.Create,
                                       FileAccess.Write)


        Dim miTexto As New StreamWriter(miFichero)
        miTexto.WriteLine(sTexto)
        miTexto.Close()
        miFichero.Close()

        Dim miOrigen As String
        miOrigen = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\convert.krl", System.Text.Encoding.ASCII)

        sFinal = Replace(miOrigen, "&lt;![CDATA[", "")
        sFinal = Replace(sFinal, "]]&gt;", "")

        Transforma_XML2 = sFinal

        Dim objFichero2 As New FileStream(Application.StartupPath & "\prueba.txt", FileMode.Create,
                                       FileAccess.Write)

        Dim objStream2 As New StreamWriter(objFichero2)
        objStream2.WriteLine(sFinal)
        objStream2.Close()
        objFichero2.Close()

    End Function

    Function Sacar_Numeros(sTexto As String) As Double

        Dim i As Integer
        Dim sResultado As String = ""

        For i = 1 To Len(sTexto)
            If Not (Mid(sTexto, i, 1) <> "." And Mid(sTexto, i, 1) <> "," And Not IsNumeric(Mid(sTexto, i, 1))) Then
                sResultado = sResultado & Replace(Mid(sTexto, i, 1), ".", ",")
            End If
        Next


        If sResultado = "" Then
            Return 0
        Else
            Return CDbl(sResultado)
        End If
    End Function

    Sub Mostrar_Label(sTipo As String)

        Select Case sTipo
            Case "Producto"
                frm_Principal.lblProducto.Visible = True
                frm_Principal.lblPrecios.Visible = False
                frm_Principal.lblImprimir.Visible = False
                frm_Principal.lblConf.Visible = False
            Case "Precios"
                frm_Principal.lblProducto.Visible = False
                frm_Principal.lblPrecios.Visible = True
                frm_Principal.lblImprimir.Visible = False
                frm_Principal.lblConf.Visible = False
            Case "Imprimir"
                frm_Principal.lblProducto.Visible = False
                frm_Principal.lblPrecios.Visible = False
                frm_Principal.lblImprimir.Visible = True
                frm_Principal.lblConf.Visible = False
            Case "Conf"
                frm_Principal.lblProducto.Visible = False
                frm_Principal.lblPrecios.Visible = False
                frm_Principal.lblImprimir.Visible = False
                frm_Principal.lblConf.Visible = True
            Case Else
                frm_Principal.lblProducto.Visible = False
                frm_Principal.lblPrecios.Visible = False
                frm_Principal.lblImprimir.Visible = False
                frm_Principal.lblConf.Visible = False
        End Select
    End Sub

    Function Mostrar_Unidad_Envase(sUnidad As String) As Boolean

        Mostrar_Unidad_Envase = False
        Select Case LCase(sUnidad)
            Case "mililitros"
                Mostrar_Unidad_Envase = True
            Case "gramos"
                Mostrar_Unidad_Envase = True
            Case "ml"
                Mostrar_Unidad_Envase = True
            Case "ml."
                Mostrar_Unidad_Envase = True
            Case "g"
                Mostrar_Unidad_Envase = True
            Case "g."
                Mostrar_Unidad_Envase = True
            Case "gr"
                Mostrar_Unidad_Envase = True
            Case "gr."
                Mostrar_Unidad_Envase = True
        End Select
    End Function

    'Function Buscar_Diferencia_Precios() As Boolean

    '    Dim dsArticulos As New DataSet
    '    Dim dsPvp_Ultimo As New DataSet
    '    Dim sArticulo As String
    '    Dim nUltimo As Double
    '    Dim nActual As Double
    '    Dim sEAN As String
    '    Dim bInsertado_Cabecera As Boolean = False
    '    Dim nID As Long
    '    Dim i As Long
    '    Dim nContador As Long = 0
    '    Dim sTexto As String =""

    '    sSQL = "Select EAN, Desc_Articulo, Precio From tbl_Articulos_Detalle Order by Desc_Articulo"

    '    dsArticulos = myDB.Dame_Dataset(sSQL)

    '    For i = 0 To dsArticulos.Tables(0).Rows.Count - 1
    '        sArticulo = dsArticulos.Tables(0).Rows(i).Item("Desc_Articulo").ToString
    '        sEAN = dsArticulos.Tables(0).Rows(i).Item("EAN").ToString
    '        nActual = CDbl(dsArticulos.Tables(0).Rows(i).Item("Precio").ToString)
    '        sSQL = "Select Precio From tbl_Datos Where EAN='" & sEAN & "' Order By ID Desc"

    '        dsPvp_Ultimo = myDB.Dame_Dataset(sSQL)

    '        If dsPvp_Ultimo.Tables(0).Rows.Count > 0 Then
    '            nUltimo = CDbl(dsPvp_Ultimo.Tables(0).Rows(0).Item(0).ToString)
    '            If nUltimo <> nActual Then
    '                'Hay diferencia
    '                If bInsertado_Cabecera = False Then
    '                    'Insertamos la cabecera
    '                    sSQL = "Insert Into tbl_Registro (Fecha) Values ('" & Format(Now, "MM/dd/yyyy") & "')"
    '                    myDB.Ejecuta_SQL(sSQL)
    '                    nID = ID_Ultimo_Registro()
    '                    sSQL = "Insert Into tbl_Registro_Detalle (ID_CABECERA, EAN, DESC_ARTICULO, PRECIO_ANTIGUO, PRECIO_NUEVO, DIFERENCIA) VALUES (" &
    '                        nID & ",'" & sEAN & "','" & sArticulo & "'," & Replace(nUltimo, ",", ".") & "," & Replace(nActual, ",", ".") & "," & Replace(nUltimo - nActual, ",", ".") & ")"
    '                    myDB.Ejecuta_SQL(sSQL)
    '                    sSQL = "Update tbl_Articulos_Detalle Set Precio=" & Replace(nUltimo, ",", ".") & " Where EAN='" & sEAN & "'"
    '                    myDB.Ejecuta_SQL(sSQL)
    '                    bInsertado_Cabecera = True
    '                Else
    '                    sSQL = "Insert Into tbl_Registro_Detalle (ID_CABECERA, EAN, DESC_ARTICULO, PRECIO_ANTIGUO, PRECIO_NUEVO, DIFERENCIA) VALUES (" &
    '                        nID & ",'" & sEAN & "','" & sArticulo & "'," & Replace(nUltimo, ",", ".") & "," & Replace(nActual, ",", ".") & "," & Replace(nUltimo - nActual, ",", ".") & ")"
    '                    myDB.Ejecuta_SQL(sSQL)
    '                    sSQL = "Update tbl_Articulos_Detalle Set Precio=" & Replace(nUltimo, ",", ".") & " Where EAN='" & sEAN & "'"
    '                    myDB.Ejecuta_SQL(sSQL)
    '                End If
    '                nContador = nContador + 1
    '            End If
    '        End If
    '    Next

    '    If nContador > 0 Then
    '        sTexto = nContador & " Artículos con diferencia de precios"
    '        sSQL = "Update tbl_Registro Set CAMBIOS=" & nContador & ", NOTAS='" & sTexto & "' Where ID=" & nID
    '        myDB.Ejecuta_SQL(sSQL)
    '        MsgBox("Proceso finalizado, se han encontrado " & nContador & " artículos con diferencias de precio", 64, "Información")
    '    Else
    '        MsgBox("Proceso finalizado, no existen cambios de precios", 64, "Información")
    '    End If

    '    Return True

    'End Function

    'Function ID_Ultimo_Registro() As Long

    '    Dim ds As New DataSet

    '    sSQL = "Select ID from tbl_Registro Order By ID Desc"

    '    ds = myDB.Dame_Dataset(sSQL)

    '    Return CLng(ds.Tables(0).Rows(0).Item(0).ToString)

    'End Function


End Module

