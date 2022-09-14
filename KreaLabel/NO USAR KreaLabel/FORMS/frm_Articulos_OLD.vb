Imports System.ComponentModel
Imports System.Windows.Forms

Public Class frm_Articulos_OLD

    Private bInsertando As Boolean = False

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'Me.Tbl_ConceptosTableAdapter.Connection.ConnectionString = sCadena_Conexion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frm_Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Cargar_Grid()
            Formatear_Grid()

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al cargar la pantalla" & vbCrLf & vbCrLf & ex.Message, 16, "Error")
        End Try

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Sub Cargar_Grid()

        Dim ds As New DataSet

        ds = myDB.Dame_Dataset("Select * From tbl_DATOS Order By DESCRIPCION")

        Me.dgArticulos.DataSource = ds.Tables(0)

    End Sub

    Sub Formatear_Grid()

        Me.dgArticulos.Columns(0).Visible = False 'Oculto el ID
        Me.dgArticulos.Columns("DESCRIPCION").Width = 320
        Me.dgArticulos.Columns("PRECIO").Width = 100
        Me.dgArticulos.Columns("EAN").Width = 200

        Me.dgArticulos.Columns("DESCRIPCION").HeaderText = "DESCRIPCIÓN"
        Me.dgArticulos.Columns("PRECIO").HeaderText = "PRECIO"
        Me.dgArticulos.Columns("EAN").HeaderText = "CÓDIGO DE BARRAS"

    End Sub



End Class