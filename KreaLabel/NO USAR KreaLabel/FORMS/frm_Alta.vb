Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frm_Alta

    Private bInsertando As Boolean = False

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'Me.Tbl_ConceptosTableAdapter.Connection.ConnectionString = sCadena_Conexion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frm_Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtLectura.Focus()

        'Try

        '    Cargar_Grid()
        '    Formatear_Grid()

        'Catch ex As Exception
        '    MsgBox("Ha ocurrido un error al cargar la pantalla" & vbCrLf & vbCrLf & ex.Message, 16, "Error")
        'End Try

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Sub Formatear_Grid_Detalle()

        Me.dgAlta.Columns(0).Visible = False 'Oculto el ID
        Me.dgAlta.Columns("DESC_ARTICULO").Width = 350
        Me.dgAlta.Columns("EAN").Width = 100
        Me.dgAlta.Columns("PRECIO").Width = 150

        Me.dgAlta.Columns("DESC_ARTICULO").HeaderText = "DESCRIPCIÓN"
        Me.dgAlta.Columns("EAN").HeaderText = "EAN"
        Me.dgAlta.Columns("PRECIO").HeaderText = "PRECIO ANTIGUO"

    End Sub

    Private Sub txtLectura_Validated(sender As Object, e As EventArgs) Handles txtLectura.Validated

        Dim sLectura As String = ""
        Dim dsPvp_Actual As New DataSet
        Dim dsPvp_Ultimo As New DataSet
        Dim nActual As Double = 0
        Dim nUltimo As Double = 0
        Dim sArticulo As String = ""


        If txtLectura.Text & "" = "" Then Exit Sub

        sLectura = txtLectura.Text

        'Primero Busco el precio actual
        sSQL = "Select Descripcion, Precio From tbl_Datos Where EAN='" & sLectura & "'"

        dsPvp_Actual = myDB.Dame_Dataset(sSQL)

        If dsPvp_Actual.Tables(0).Rows.Count = 0 Then
            System.Media.SystemSounds.Beep.Play()
            System.Media.SystemSounds.Exclamation.Play()
            lblInfo.Text = "El artículo leído, no se encuentra en la base de datos."
            lblInfo.ForeColor = Color.Red
            txtLectura.SelectAll()
            txtLectura.Select()
            Exit Sub
        Else
            nActual = CDbl(dsPvp_Actual.Tables(0).Rows(0).Item("Precio").ToString)
            sArticulo = dsPvp_Actual.Tables(0).Rows(0).Item("Descripcion").ToString
        End If

        nActual = CDbl(dsPvp_Actual.Tables(0).Rows(0).Item("Precio").ToString)

        If Existe_Articulo(sLectura) = True Then
            System.Media.SystemSounds.Beep.Play()
            System.Media.SystemSounds.Exclamation.Play()
            lblInfo.Text = "El artículo ya existe"
            lblInfo.ForeColor = Color.Red
            txtLectura.SelectAll()
            txtLectura.Select()
            Exit Sub
        End If
        '*********************************************************************************************************

        ''Ahora buscamos el último precio
        'sSQL = "Select Precio From tbl_Articulos_Detalle Where EAN='" & sLectura & "' Order By ID Desc"

        'dsPvp_Ultimo = myDB.Dame_Dataset(sSQL)

        'If dsPvp_Ultimo.Tables(0).Rows.Count > 0 Then
        '    nUltimo = CDbl(dsPvp_Ultimo.Tables(0).Rows(0).Item(0).ToString)
        'End If

        ''ESTO LO PONGO DESPUÉS DE LA MODIFICACIÓN
        'nUltimo = 0
        sSQL = "INSERT INTO tbl_Articulos_Detalle (ID_CABECERA, EAN, DESC_ARTICULO, PRECIO) VALUES (" & nID_Nuevo & ",'" & sLectura & "','" &
            sArticulo & "'," & Replace(nActual, ",", ".") & ")"

        myDB.Ejecuta_SQL(sSQL)

        sSQL = "Select ID, DESC_ARTICULO, EAN, PRECIO From tbl_Articulos_Detalle Where ID_CABECERA=" & nID_Nuevo & " Order By DESC_ARTICULO"

        Dim ds As New DataSet
        ds = myDB.Dame_Dataset(sSQL)

        Me.dgAlta.DataSource = ds.Tables(0)
        Formatear_Grid_Detalle()

        lblInfo.ForeColor = Color.Green
        System.Media.SystemSounds.Beep.Play()
        System.Media.SystemSounds.Exclamation.Play()
        lblInfo.Text = "Artículo " & sArticulo & " leído correctamente"
        Me.txtLectura.Text = ""
        Me.txtLectura.Focus()

    End Sub


    Private Sub txtLectura_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLectura.KeyDown

        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtLectura_TextChanged(sender As Object, e As EventArgs) Handles txtLectura.TextChanged

    End Sub

    Function Existe_Articulo(sArticulo As String) As Boolean

        Dim dsExiste As New DataSet

        sSQL = "Select Count(*) From tbl_Articulos_Detalle Where EAN='" & sArticulo & "'"

        dsExiste = myDB.Dame_Dataset(sSQL)

        If CLng(dsExiste.Tables(0).Rows(0).Item(0).ToString) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class