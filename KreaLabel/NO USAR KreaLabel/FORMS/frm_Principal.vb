Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class frm_Principal
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click

        Me.Close()

    End Sub

    Private Sub btn_Maximizar_Click(sender As Object, e As EventArgs) Handles btn_Maximizar.Click

        Me.btn_Maximizar.Visible = False
        Me.btn_Restaurar.Visible = True
        Me.WindowState = Windows.Forms.FormWindowState.Maximized

    End Sub

    Private Sub btn_Minimizar_Click(sender As Object, e As EventArgs) Handles btn_Minimizar.Click
        Me.WindowState = Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btn_Restaurar_Click(sender As Object, e As EventArgs) Handles btn_Restaurar.Click

        Me.btn_Restaurar.Visible = False
        Me.btn_Maximizar.Visible = True
        Me.WindowState = Windows.Forms.FormWindowState.Normal

    End Sub

    Private Sub panelCabecera_MouseMove(sender As Object, e As Windows.Forms.MouseEventArgs) Handles panelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TimerOcultarMenu_Tick(sender As Object, e As EventArgs) Handles TimerOcultarMenu.Tick
        If panelMenu.Width <= 60 Then
            Me.TimerOcultarMenu.Enabled = False
        Else
            Me.panelMenu.Width = Me.panelMenu.Width - 20
            Me.Refresh()
        End If
    End Sub

    Private Sub TimerMostrarMenu_Tick(sender As Object, e As EventArgs) Handles TimerMostrarMenu.Tick
        If panelMenu.Width >= 220 Then
            Me.TimerMostrarMenu.Enabled = False
        Else
            Me.panelMenu.Width = Me.panelMenu.Width + 20
            Me.Refresh()
        End If
    End Sub

    Private Sub btn_Menu_Click(sender As Object, e As EventArgs) Handles btn_Menu.Click
        If panelMenu.Width <= 60 Then
            TimerMostrarMenu.Enabled = True
        Else
            TimerOcultarMenu.Enabled = True
        End If
    End Sub

    Public Sub AbrirFormPanel(ByVal FormHijo As Object)

        If Me.panelContenedor.Controls.Count > 0 Then
            Me.panelContenedor.Controls.RemoveAt(0)
        End If

        Dim fh As Windows.Forms.Form = TryCast(FormHijo, Windows.Forms.Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Controls.Add(fh)
        Me.panelContenedor.Tag = fh
        fh.Show()

    End Sub


    Private Sub btn_Abrir_Conceptos_Click_1(sender As Object, e As EventArgs) Handles btn_Abrir_Conceptos.Click
        AbrirFormPanel(New frm_Registro)
    End Sub

    Private Sub btn_Abrir_Configuracion_Click(sender As Object, e As EventArgs) Handles btn_Abrir_Configuracion.Click
        AbrirFormPanel(New frm_Conf)
    End Sub

    Private Sub frm_Principal_Load(sender As Object, e As EventArgs) Handles Me.Load

        Cargar()

    End Sub


    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub frm_Principal_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Application.Exit()

    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        AbrirFormPanel(New frm_Articulos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim sValor As String
        Dim dsID As New DataSet

        sValor = InputBox("Introduzca una descripción", "Diferencia de Precios")

        If sValor & "" = "" Then
            MsgBox("Debe introducir una descripción", 16, "Error")
            Exit Sub
        End If

        sSQL = "Insert into tbl_Articulos (Fecha, Descripcion) Values ('" & Format(Now, "MM/dd/yyyy") & "','" & sValor & "')"
        myDB.Ejecuta_SQL(sSQL)

        dsID = myDB.Dame_Dataset("Select Max(ID) From tbl_Articulos")

        nID_Nuevo = CLng(dsID.Tables(0).Rows(0).Item(0).ToString)
        AbrirFormPanel(New frm_Alta)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Progreso1.Value += 1
        Progreso1.Text = Progreso1.Value.ToString()
        If (Progreso1.Value = 100) Then
            Timer1.Stop()
            Buscar_Diferencia_Precios()
            Progreso1.Visible = False
            Me.lblInfo.Visible = False
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.lblInfo.Visible = True

        Me.Progreso1.Visible = True
        Me.Progreso1.Value = 0

        Me.Progreso1.Visible = True
        Timer1.Start()

    End Sub


End Class