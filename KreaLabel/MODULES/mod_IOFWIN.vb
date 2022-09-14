
Module mod_IOFWIN

    Function Leer_Articulo(sXML As String) As Boolean

        Dim miXML As New XmlDataDocument()
        Dim miNodo As XmlNodeList

        Reset_Variables_IOFWIN()

        Try

            miXML.LoadXml(sXML)
            miNodo = miXML.GetElementsByTagName("infoprod")

            sCodigo_Producto = miNodo(0).ChildNodes(0).InnerText
            sNombre_Producto = miNodo(0).ChildNodes(1).InnerText
            sEAN_Producto = miNodo(0).ChildNodes(2).InnerText
            If miNodo(0).ChildNodes(3).InnerText = "" Then
                nPVP_Producto = 0
            Else
                nPVP_Producto = miNodo(0).ChildNodes(3).InnerText.Replace(".", ",")
            End If
            If miNodo(0).ChildNodes(4).InnerText = "" Then
                nPVPOferta_Producto = 0
            Else
                nPVPOferta_Producto = miNodo(0).ChildNodes(4).InnerText.Replace(".", ",")
            End If
            If miNodo(0).ChildNodes(5).ChildNodes(0).InnerText = "" Then
                nEuros_Unidad = 0
            Else
                nEuros_Unidad = miNodo(0).ChildNodes(5).ChildNodes(0).InnerText.Replace(".", ",")
            End If
            If miNodo(0).ChildNodes(5).ChildNodes(1).InnerText = "" Then
                nCantDiv = 1
            Else
                nCantDiv = Sacar_Numeros(miNodo(0).ChildNodes(5).ChildNodes(1).InnerText)
            End If
            sUnidad_Producto = miNodo(0).ChildNodes(6).InnerText
            sDescUnidad_Producto = miNodo(0).ChildNodes(7).InnerText
            If miNodo(0).ChildNodes(8).InnerText = "" Then
                nIVA_Producto = 0
            Else
                nIVA_Producto = miNodo(0).ChildNodes(8).InnerText.Replace(".", ",")
            End If
            If nEuros_Unidad > 0 Then
                nCantidad_Envase = nPVP_Producto / (nEuros_Unidad / nCantDiv)
            Else
                nCantidad_Envase = 0
            End If
            nIVA_Producto = miNodo(0).ChildNodes(8).InnerText
            If miNodo(0).ChildNodes(9).InnerText = "" Then
                nREC_Producto = 0
            Else
                nREC_Producto = miNodo(0).ChildNodes(9).InnerText.Replace(".", ",")
            End If

        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Function Leer_Cambio_Precio(sXML As String) As Boolean

        Dim miXML As New XmlDataDocument()
        Dim miNodo As XmlNodeList

        Try
            Reset_Variables()

            miXML.LoadXml(sXML)
            miNodo = miXML.GetElementsByTagName("productos")

            sCodigo_Producto = miNodo(0).ChildNodes(0).InnerText
            sNombre_Producto = miNodo(0).ChildNodes(1).InnerText
            sEAN_Producto = miNodo(0).ChildNodes(2).InnerText
            If miNodo(0).ChildNodes(3).InnerText = "" Then
                nPVP_Producto = 0
            Else
                nPVP_Producto = miNodo(0).ChildNodes(3).InnerText.Replace(".", ",")
            End If
            If miNodo(0).ChildNodes(4).InnerText = "" Then
                nPVPOferta_Producto = 0
            Else
                nPVPOferta_Producto = miNodo(0).ChildNodes(4).InnerText.Replace(".", ",")
            End If
            If miNodo(0).ChildNodes(5).ChildNodes(0).InnerText = "" Then
                nEuros_Unidad = 0
            Else
                nEuros_Unidad = miNodo(0).ChildNodes(5).ChildNodes(0).InnerText.Replace(".", ",")
            End If
            sUnidad_Producto = miNodo(0).ChildNodes(6).InnerText
            sDescUnidad_Producto = miNodo(0).ChildNodes(7).InnerText
            If miNodo(0).ChildNodes(8).InnerText = "" Then
                nIVA_Producto = 0
            Else
                nIVA_Producto = miNodo(0).ChildNodes(8).InnerText.Replace(".", ",")
            End If
            nIVA_Producto = miNodo(0).ChildNodes(8).InnerText
            If miNodo(0).ChildNodes(9).InnerText = "" Then
                nREC_Producto = 0
            Else
                nREC_Producto = miNodo(0).ChildNodes(9).InnerText.Replace(".", ",")
            End If

        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Sub Reset_Variables_IOFWIN()

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

    End Sub
End Module
