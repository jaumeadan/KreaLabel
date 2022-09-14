Imports System.Drawing.Drawing2D
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
    Private Sub lblTitulo_MouseMove(sender As Object, e As Windows.Forms.MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Public Sub AbrirFormPanel(ByVal FormHijo As Object, centrar As Boolean, validarBD As Boolean)
        If formularioActivo Then
            While Me.panelContenedor.Controls.Count > 1
                Me.panelContenedor.Controls.RemoveAt(1)
            End While
            'MsgBox("Existe un formulario abierto. Cierre e intente abrir el nuevo.", MsgBoxStyle.Exclamation, "Abrir formulario")
            'Exit Sub
        End If

        If validarBD Then
            If bdKrealabel = "" Then
                MsgBox("No se ha definido la BD Krealabel. Por favor, configúre la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
                abrirRutaBD()
                Exit Sub
            End If
            myDB = New cls_Conexion
            If Not myDB.Test_Conexion Then
                MsgBox("No se ha definido la BD Krealabel. Por favor, configúre la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
                abrirRutaBD()
                Exit Sub
            End If
        End If

        If Not centrar Then
            While Me.panelContenedor.Controls.Count > 1
                Me.panelContenedor.Controls.RemoveAt(1)
            End While

            Dim fh As Windows.Forms.Form = TryCast(FormHijo, Windows.Forms.Form)
            fh.TopLevel = False
            fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            fh.Dock = Windows.Forms.DockStyle.Fill
            Me.panelContenedor.Controls.Add(fh)
            Me.panelContenedor.Tag = fh
            fh.Show()
        Else
            Dim fh As Windows.Forms.Form = TryCast(FormHijo, Windows.Forms.Form)
            fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None

            FormHijo.TopLevel = False
            FormHijo.Parent = panelContenedor
            FormHijo.Location = New Point((panelContenedor.Width - FormHijo.Width) / 2, (panelContenedor.Height - FormHijo.Height) / 2)
            FormHijo.Show()
        End If
        formularioActivo = True
    End Sub

    Private Sub frm_Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        formularioActivo = False
        Call botonesOriginal()
        myDB = New cls_Conexion
        bdFirebird = ""
        licencia = ""

        bdKrealabel = My.Settings.Ruta_BD.ToString
        If bdKrealabel = "" Then
            MsgBox("No se ha definido la BD Krealabel. Por favor, configure la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
            abrirRutaBD()
            Exit Sub
        End If
        myDB = New cls_Conexion
        If Not myDB.Test_Conexion Then
            MsgBox("No se ha definido la BD Krealabel. Por favor, configure la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
            abrirRutaBD()
            Exit Sub
        End If

        cargarBDFirebird()
        If bdFirebird = "" Then
            MsgBox("No se ha definido la BD Firebird. Por favor, configúre la ubicación para el correcto funcionamiento del aplicativo.", MsgBoxStyle.Exclamation, "Acceso")
        End If
    End Sub

    Private Sub frm_Principal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
    End Sub

    Private Sub imgArticulos_Click(sender As Object, e As EventArgs) Handles imgArticulos.Click
        AbrirFormPanel(New frm_Articulos, False, True)
        Call botonesOriginal()
        lblTitulo.Text = "ARTÍCULOS"
        'imgLogoFondo.Visible = False
        imgArticulos.Visible = False
        imgArticulosSeleccionado.Visible = True
    End Sub

    Private Sub imgPrecios_Click(sender As Object, e As EventArgs) Handles imgPrecios.Click
        AbrirFormPanel(New frm_ArticulosPrecios, False, True)
        Call botonesOriginal()
        lblTitulo.Text = "BUSCAR CAMBIO DE PRECIOS"
        imgPrecios.Visible = False
        imgPreciosSeleccionado.Visible = True

    End Sub

    Private Sub imgImprimir_Click(sender As Object, e As EventArgs) Handles imgImprimir.Click
        AbrirFormPanel(New frm_ImprimirEtiquetas, False, True)
        Call botonesOriginal()
        lblTitulo.Text = "IMPRESIÓN DE ETIQUETAS"
        imgLogoFondo.Visible = False
        imgImprimir.Visible = False
        imgImprimirSeleccionado.Visible = True
    End Sub

    Private Sub imgConfiguracion_Click(sender As Object, e As EventArgs) Handles imgConfiguracion.Click
        AbrirFormPanel(New frm_Configuracion, True, True)
        Call botonesOriginal()
        lblTitulo.Text = "CONFIGURACIÓN DE USUARIO"
        imgLogoFondo.Visible = False
        imgConfiguracion.Visible = False
        imgConfiguracionSeleccionado.Visible = True
    End Sub

    Private Sub panelCabecera_Paint(sender As Object, e As PaintEventArgs) Handles panelCabecera.Paint
        Dim linearGradientBrush As LinearGradientBrush
        Dim cblend As ColorBlend

        linearGradientBrush = New LinearGradientBrush(panelCabecera.ClientRectangle, Color.Red, Color.Yellow, 0)
        cblend = New ColorBlend(3)
        cblend.Colors = New Color() {Color.DeepSkyBlue, Color.Blue, Color.CadetBlue}
        cblend.Positions = New Single() {0.0, 0.5, 1.0}

        linearGradientBrush.InterpolationColors = cblend
        e.Graphics.FillRectangle(linearGradientBrush, panelCabecera.ClientRectangle)
    End Sub

    Private Sub imgLogo_Click(sender As Object, e As EventArgs) Handles imgLogo.Click
        'abrirRutaBD()

        'Import_FARMANAGER("")
        'Prueba()

    End Sub

    Private Sub abrirRutaBD()
        AbrirFormPanel(New frm_RutaBD, True, False)
        Call botonesOriginal()
        lblTitulo.Text = "RUTA FICHERO DATA"
        imgLogoFondo.Visible = False
    End Sub



    Private Sub imgArticulos_MouseMove(sender As Object, e As MouseEventArgs) Handles imgArticulos.MouseMove
        Me.lblProducto.Visible = True
        Me.lblPrecios.Visible = False
    End Sub

    Private Sub imgPrecios_MouseDown(sender As Object, e As MouseEventArgs) Handles imgPrecios.MouseDown
        Me.lblProducto.Visible = False
        Me.lblPrecios.Visible = True
    End Sub

    Private Sub imgArticulos_MouseDown(sender As Object, e As MouseEventArgs) Handles imgArticulos.MouseDown

        Mostrar_Label("Producto")

    End Sub

    Private Sub imgArticulosSeleccionado_MouseMove(sender As Object, e As MouseEventArgs) Handles imgArticulosSeleccionado.MouseMove
        Mostrar_Label("Producto")

    End Sub

    Private Sub imgPrecios_MouseMove(sender As Object, e As MouseEventArgs) Handles imgPrecios.MouseMove

        Mostrar_Label("Precios")

    End Sub

    Private Sub imgPreciosSeleccionado_MouseMove(sender As Object, e As MouseEventArgs) Handles imgPreciosSeleccionado.MouseMove

        Mostrar_Label("Precios")

    End Sub

    Private Sub imgImprimir_MouseMove(sender As Object, e As MouseEventArgs) Handles imgImprimir.MouseMove

        Mostrar_Label("Imprimir")

    End Sub

    Private Sub imgImprimirSeleccionado_MouseMove(sender As Object, e As MouseEventArgs) Handles imgImprimirSeleccionado.MouseMove

        Mostrar_Label("Imprimir")

    End Sub

    Private Sub imgConfiguracion_MouseMove(sender As Object, e As MouseEventArgs) Handles imgConfiguracion.MouseMove

        Mostrar_Label("Conf")

    End Sub

    Private Sub imgConfiguracionSeleccionado_MouseMove(sender As Object, e As MouseEventArgs) Handles imgConfiguracionSeleccionado.MouseMove

        Mostrar_Label("Conf")

    End Sub

    Private Sub imgConfiguracionSeleccionado_MouseLeave(sender As Object, e As EventArgs) Handles imgConfiguracionSeleccionado.MouseLeave
        Mostrar_Label("")
    End Sub

    Private Sub imgConfiguracion_MouseLeave(sender As Object, e As EventArgs) Handles imgConfiguracion.MouseLeave
        Mostrar_Label("")
    End Sub

    Private Sub imgArticulos_MouseLeave(sender As Object, e As EventArgs) Handles imgArticulos.MouseLeave
        Mostrar_Label("")
    End Sub

    Private Sub imgArticulosSeleccionado_MouseLeave(sender As Object, e As EventArgs) Handles imgArticulosSeleccionado.MouseLeave
        Mostrar_Label("")
    End Sub

    Private Sub imgImprimir_MouseLeave(sender As Object, e As EventArgs) Handles imgImprimir.MouseLeave
        Mostrar_Label("")
    End Sub

    Private Sub imgImprimirSeleccionado_MouseLeave(sender As Object, e As EventArgs) Handles imgImprimirSeleccionado.MouseLeave
        Mostrar_Label("")
    End Sub

    Private Sub imgPrecios_MouseLeave(sender As Object, e As EventArgs) Handles imgPrecios.MouseLeave
        Mostrar_Label("")
    End Sub

    Private Sub imgPreciosSeleccionado_MouseLeave(sender As Object, e As EventArgs) Handles imgPreciosSeleccionado.MouseLeave
        Mostrar_Label("")
    End Sub
End Class