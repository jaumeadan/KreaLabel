Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frm_Articulos

    Private bInsertando As Boolean = False

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'Me.Tbl_ConceptosTableAdapter.Connection.ConnectionString = sCadena_Conexion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frm_Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Cargar_Grid()
            Formatear_Grid_Registro()

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al cargar la pantalla" & vbCrLf & vbCrLf & ex.Message, 16, "Error")
        End Try

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Sub Cargar_Grid()

        Dim ds As New DataSet

        ds = myDB.Dame_Dataset("Select ID, FECHA, DESCRIPCION From tbl_Articulos Order By Fecha Desc, Descripcion")

        Me.dgRegistro.DataSource = ds.Tables(0)

    End Sub

    Sub Formatear_Grid_Registro()

        Me.dgRegistro.Columns(0).Visible = False 'Oculto el ID
        Me.dgRegistro.Columns("Fecha").Width = 100
        Me.dgRegistro.Columns("Descripcion").Width = 200

        Me.dgRegistro.Columns("Fecha").HeaderText = "Fecha"
        Me.dgRegistro.Columns("Descripcion").HeaderText = "Descripción"

    End Sub

    Sub Formatear_Grid_Detalle()

        Me.dgDetalle.Columns(0).Visible = False 'Oculto el ID
        Me.dgDetalle.Columns("DESC_ARTICULO").Width = 350
        Me.dgDetalle.Columns("EAN").Width = 100
        Me.dgDetalle.Columns("PRECIO").Width = 150

        Me.dgDetalle.Columns("DESC_ARTICULO").HeaderText = "DESCRIPCIÓN"
        Me.dgDetalle.Columns("EAN").HeaderText = "EAN"
        Me.dgDetalle.Columns("PRECIO").HeaderText = "PRECIO"


    End Sub

    Private Sub dgRegistro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRegistro.CellContentClick

    End Sub

    Private Sub dgRegistro_MouseClick(sender As Object, e As MouseEventArgs) Handles dgRegistro.MouseClick

        Filtrar

    End Sub

    Sub Filtrar()

        Dim xValor As String
        Dim ds2 As New DataSet
        Dim sSQL As String

        Try
            If dgRegistro.RowCount = 0 Then Exit Sub

            xValor = Me.dgRegistro.CurrentRow.Cells(0).Value.ToString & ""

            sSQL = "Select ID, DESC_ARTICULO, EAN, PRECIO From tbl_Articulos_Detalle Where ID_CABECERA=" & xValor & " Order By DESC_ARTICULO"

            ds2 = myDB.Dame_Dataset(sSQL)

            Me.dgDetalle.DataSource = ds2.Tables(0)
            Formatear_Grid_Detalle()

        Catch ex As Exception

        End Try

    End Sub

End Class