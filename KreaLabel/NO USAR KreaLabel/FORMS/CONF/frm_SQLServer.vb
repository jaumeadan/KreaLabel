Public Class frm_SQLServer
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Sub Guardar_Datos1()

        My.Settings.Conexion = "Microsoft SQL Server"
        My.Settings.Host = Me.txtServidor.Text
        My.Settings.Usuario = Me.txtUsuario.Text
        My.Settings.Password = Me.txtPassword.Text
        My.Settings.DB = Me.txtDB.Text
        My.Settings.Autenticacion = Me.chkAutenticacion.CheckState
        My.Settings.Save()
        myDB = New cls_Conexion

    End Sub

    Private Sub btn_Test_Click(sender As Object, e As EventArgs) Handles btn_Test.Click

        Guardar_Datos1()

        Dim sReturn As String = myDB.Test_Conexion

        If sReturn Then
            MsgBox("Conexión realizada correctamente", 64, "Información")
        Else
            MsgBox("Error de conexión", 16, "Error")
        End If

    End Sub

    Sub Activa_Controles(bValor As Boolean, bValor2 As Boolean)

        Me.txtUsuario.Enabled = Not bValor
        Me.txtPassword.Enabled = Not bValor

        Me.txtUsuario2.Enabled = Not bValor2
        Me.txtPassword2.Enabled = Not bValor2

    End Sub

    Private Sub chkAutenticacion_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutenticacion.CheckedChanged

        Activa_Controles(Me.chkAutenticacion.CheckState, Me.chkAutenticacion2.CheckState)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles Panel1.Paint

        Activa_Controles(Me.chkAutenticacion.CheckState, Me.chkAutenticacion2.CheckState)

    End Sub

    Private Sub chkAutenticacion2_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutenticacion2.CheckedChanged

        Activa_Controles(Me.chkAutenticacion.CheckState, Me.chkAutenticacion2.CheckState)

    End Sub

    Private Sub frm_SQLServer_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Cargar()

    End Sub
End Class