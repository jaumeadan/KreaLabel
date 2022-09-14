Module mod_Funciones

    Function Buscar_Diferencia_Precios() As Boolean

        Dim dsArticulos As New DataSet
        Dim dsPvp_Ultimo As New DataSet
        Dim sArticulo As String
        Dim nUltimo As Double
        Dim nActual As Double
        Dim sEAN As String
        Dim bInsertado_Cabecera As Boolean = False
        Dim nID As Long
        Dim i As Long
        Dim nContador As Long = 0
        Dim sTexto As String =""

        sSQL = "Select EAN, Desc_Articulo, Precio From tbl_Articulos_Detalle Order by Desc_Articulo"

        dsArticulos = myDB.Dame_Dataset(sSQL)

        For i = 0 To dsArticulos.Tables(0).Rows.Count - 1
            sArticulo = dsArticulos.Tables(0).Rows(i).Item("Desc_Articulo").ToString
            sEAN = dsArticulos.Tables(0).Rows(i).Item("EAN").ToString
            nActual = CDbl(dsArticulos.Tables(0).Rows(i).Item("Precio").ToString)
            sSQL = "Select Precio From tbl_Datos Where EAN='" & sEAN & "' Order By ID Desc"

            dsPvp_Ultimo = myDB.Dame_Dataset(sSQL)

            If dsPvp_Ultimo.Tables(0).Rows.Count > 0 Then
                nUltimo = CDbl(dsPvp_Ultimo.Tables(0).Rows(0).Item(0).ToString)
                If nUltimo <> nActual Then
                    'Hay diferencia
                    If bInsertado_Cabecera = False Then
                        'Insertamos la cabecera
                        sSQL = "Insert Into tbl_Registro (Fecha) Values ('" & Format(Now, "MM/dd/yyyy") & "')"
                        myDB.Ejecuta_SQL(sSQL)
                        nID = ID_Ultimo_Registro()
                        sSQL = "Insert Into tbl_Registro_Detalle (ID_CABECERA, EAN, DESC_ARTICULO, PRECIO_ANTIGUO, PRECIO_NUEVO, DIFERENCIA) VALUES (" &
                            nID & ",'" & sEAN & "','" & sArticulo & "'," & Replace(nUltimo, ",", ".") & "," & Replace(nActual, ",", ".") & "," & Replace(nUltimo - nActual, ",", ".") & ")"
                        myDB.Ejecuta_SQL(sSQL)
                        sSQL = "Update tbl_Articulos_Detalle Set Precio=" & Replace(nUltimo, ",", ".") & " Where EAN='" & sEAN & "'"
                        myDB.Ejecuta_SQL(sSQL)
                        bInsertado_Cabecera = True
                    Else
                        sSQL = "Insert Into tbl_Registro_Detalle (ID_CABECERA, EAN, DESC_ARTICULO, PRECIO_ANTIGUO, PRECIO_NUEVO, DIFERENCIA) VALUES (" &
                            nID & ",'" & sEAN & "','" & sArticulo & "'," & Replace(nUltimo, ",", ".") & "," & Replace(nActual, ",", ".") & "," & Replace(nUltimo - nActual, ",", ".") & ")"
                        myDB.Ejecuta_SQL(sSQL)
                        sSQL = "Update tbl_Articulos_Detalle Set Precio=" & Replace(nUltimo, ",", ".") & " Where EAN='" & sEAN & "'"
                        myDB.Ejecuta_SQL(sSQL)
                    End If
                    nContador = nContador + 1
                End If
            End If
        Next

        If nContador > 0 Then
            sTexto = nContador & " Artículos con diferencia de precios"
            sSQL = "Update tbl_Registro Set CAMBIOS=" & nContador & ", NOTAS='" & sTexto & "' Where ID=" & nID
            myDB.Ejecuta_SQL(sSQL)
            MsgBox("Proceso finalizado, se han encontrado " & nContador & " artículos con diferencias de precio", 64, "Información")
        Else
            MsgBox("Proceso finalizado, no existen cambios de precios", 64, "Información")
        End If

        Return True

    End Function

    Function ID_Ultimo_Registro() As Long

        Dim ds As New DataSet

        sSQL = "Select ID from tbl_Registro Order By ID Desc"

        ds = myDB.Dame_Dataset(sSQL)

        Return CLng(ds.Tables(0).Rows(0).Item(0).ToString)

    End Function
End Module
