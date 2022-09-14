Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Public Class frmCrystalReportVisor

    Private reportDocument1 As ReportDocument
    Private enviarAImpresora1 As Boolean
    Private formularioTitulo1 As String
    Private displayGroupTree1 As Boolean = False

    Private Sub frmCrystalReportViewer_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'Centrar(Me)
    End Sub

    Private Sub frmCrystalReportViewer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Normal
        Me.Visible = False
    End Sub

    Private Sub frmCrystalReportViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Opciones generales
        myCrystalReportViewer.ShowRefreshButton = False
        ' Texto del formulario
        If formularioTitulo1 Is Nothing Then
            Me.Text = "Informe"
        Else
            Me.Text = formularioTitulo1
        End If
        ' Muestra el árbol de grupos
        If displayGroupTree1 Then
            'myCrystalReportViewer.ShowGroupTree = True
            'myCrystalReportViewer.DisplayGroupTree = True
            myCrystalReportViewer.ShowGroupTreeButton = True
        End If
        ' Muestra el informe por pantalla
        myCrystalReportViewer.ReportSource = reportDocument1
        If displayGroupTree1 Then
            myCrystalReportViewer.ShowGroupTree()
        End If

        ' Imprimir
        If enviarAImpresora1 Then
            myCrystalReportViewer.PrintReport()
            Close()
        End If
    End Sub

    Public Property informe() As ReportDocument
        Get
            informe = reportDocument1
        End Get
        Set(ByVal Value As ReportDocument)
            reportDocument1 = Value
        End Set
    End Property

    Public Property enviarAImpresora() As Boolean
        Get
            enviarAImpresora = enviarAImpresora1
        End Get
        Set(ByVal Value As Boolean)
            enviarAImpresora1 = Value
        End Set
    End Property

    Public Property formularioTitulo() As String
        Get
            formularioTitulo = formularioTitulo1
        End Get
        Set(ByVal Value As String)
            formularioTitulo1 = Value
        End Set
    End Property

    Public Property displayGroupTree() As Boolean
        Get
            displayGroupTree = displayGroupTree1
        End Get
        Set(ByVal value As Boolean)
            displayGroupTree1 = value
        End Set
    End Property

End Class