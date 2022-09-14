Module mod_FARMANAGER
    Function Import_FARMANAGER(sRuta_Fichero As String) As Boolean

        Dim miXML As New XmlDataDocument()
        Dim miNodo As XmlNodeList

        'Try

        'miXML.Load(sRuta_Fichero)
        miXML.Load("E:\KREAMARKET\import.xls")

            miNodo = miXML.GetElementsByTagName("Row")
            For i = 0 To miNodo.Count - 1
                Reset_Variables()
            sEAN_Producto = miNodo(i).ChildNodes(0).InnerText

            If sEAN_Producto = "ccodigo" Then GoTo Siguiente
            sCodigo_Producto = miNodo(i).ChildNodes(0).InnerText
            sNombre_Producto = miNodo(i).ChildNodes(1).InnerText
            nCantidad_Envase = miNodo(i).ChildNodes(2).InnerText.Replace(".", ",")
            sUnidad_Producto = miNodo(i).ChildNodes(3).InnerText
            If miNodo(i).ChildNodes(4).InnerText = "" Then
                nPVP_Producto = 0
            Else
                nPVP_Producto = miNodo(i).ChildNodes(4).InnerText.Replace(".", ",")
            End If
                nIVA_Producto = 0
                nREC_Producto = 0
                sDescUnidad_Producto = ""
                nEuros_Unidad = 0
                nCantDiv = 1
                sSQL = "INSERT INTO tbl_Articulos(" &
                            "FECHA, " &
                            "CODIGO, " &
                            "DESCRIPCION, " &
                            "EAN, " &
                            "PRECIO, " &
                            "PRECIO_OFERTA, " &
                            "UNIDAD, " &
                            "PRECIO_UNIDAD, " &
                            "DESCRIPCION_UNIDAD, " &
                            "IVA, " &
                            "CANTIDAD_ENVASE) "

                sSQL = sSQL & " VALUES (" &
                            "CDate('" & Now.ToString() & "'), " &
                            "'" & sCodigo_Producto & "'," &
                            "'" & sNombre_Producto & "'," &
                            "'" & sEAN_Producto & "'," &
                            Replace(nPVP_Producto, ",", ".") & ",0," &
                            "'" & sUnidad_Producto & "'," &
                            Replace(nEuros_Unidad, ",", ".") & "," &
                            "'" & sDescUnidad_Producto & "'," &
                            Replace(nIVA_Producto, ",", ".") & "," &
                            Replace(nCantidad_Envase, ",", ".") & ")"

                myDB.Ejecuta_SQL(sSQL)
Siguiente:
        Next

        'Catch ex As Exception
        '    Return False
        'End Try

        Return True

    End Function

    Sub Prueba()


        Dim miXML As New XmlDataDocument()
        Dim miNodo As XmlNodeList

        'Try

        'miXML.Load(sRuta_Fichero)
        miXML.Load("E:\KREAMARKET\import.xls")

        miNodo = miXML.GetElementsByTagName("Row")
        For i = 0 To miNodo.Count - 1

            If miNodo(i).ChildNodes(0).InnerText = "8470001629616" Then
                MsgBox("La descripción es: " & miNodo(i).ChildNodes(1).InnerText)
            End If
        Next i

        MsgBox("fin")

    End Sub
End Module


