Public Class frm_Access

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btn_Test_Click(sender As Object, e As EventArgs) Handles btn_Test.Click

        Guardar_Datos()
        Comprobar_Conexión()

    End Sub

    Private Sub btn_Browser_Click(sender As Object, e As EventArgs) Handles btn_Browser.Click

        Me.OpenFileDialog1.Title = "Seleccione base de datos Access..."
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.FileName = ""
        Me.OpenFileDialog1.ShowDialog()
        If Me.OpenFileDialog1.FileName <> "" Then
            Me.txtDB.Text = Me.OpenFileDialog1.FileName
        End If


    End Sub

    Sub Guardar_Datos()

        My.Settings.Conexion = "Microsoft Jet"
        My.Settings.Ruta_MDB = Me.txtDB.Text
        My.Settings.Usuario_MDB = Me.txtUsuario.Text
        My.Settings.Password_MDB = Me.txtPassword.Text
        My.Settings.Save()
        myDB = New cls_Conexion

    End Sub


    Sub Comprobar_Conexión()

        Dim bResultado As Boolean = False

        myDB = New cls_Conexion

        bResultado = myDB.Test_Conexion()

        If bResultado Then
            MsgBox("Conexión realizada con éxito", 64, "Información")
        End If

    End Sub
End Class