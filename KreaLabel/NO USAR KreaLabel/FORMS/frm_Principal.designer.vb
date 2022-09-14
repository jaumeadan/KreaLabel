<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Restaurar = New System.Windows.Forms.Button()
        Me.btn_Minimizar = New System.Windows.Forms.Button()
        Me.btn_Maximizar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_Abrir_Configuracion = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Abrir_Conceptos = New System.Windows.Forms.Button()
        Me.btn_Menu = New System.Windows.Forms.PictureBox()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TimerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Progreso1 = New CircularProgressBar.CircularProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelCabecera.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btn_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.panelCabecera.Controls.Add(Me.PictureBox2)
        Me.panelCabecera.Controls.Add(Me.Label1)
        Me.panelCabecera.Controls.Add(Me.PictureBox1)
        Me.panelCabecera.Controls.Add(Me.btn_Restaurar)
        Me.panelCabecera.Controls.Add(Me.btn_Minimizar)
        Me.panelCabecera.Controls.Add(Me.btn_Maximizar)
        Me.panelCabecera.Controls.Add(Me.btn_Cerrar)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(1500, 60)
        Me.panelCabecera.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.KreaLabel.My.Resources.Resources.CUADRADO
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(237, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "GESTIÓN DE PRECIOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.KreaLabel.My.Resources.Resources.TEXTO
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(59, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 60)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btn_Restaurar
        '
        Me.btn_Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Restaurar.FlatAppearance.BorderSize = 0
        Me.btn_Restaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Restaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btn_Restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Restaurar.Image = Global.KreaLabel.My.Resources.Resources.Icono_Restaurar
        Me.btn_Restaurar.Location = New System.Drawing.Point(1414, 10)
        Me.btn_Restaurar.Name = "btn_Restaurar"
        Me.btn_Restaurar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Restaurar.TabIndex = 3
        Me.btn_Restaurar.UseVisualStyleBackColor = True
        Me.btn_Restaurar.Visible = False
        '
        'btn_Minimizar
        '
        Me.btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Minimizar.FlatAppearance.BorderSize = 0
        Me.btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Minimizar.Image = Global.KreaLabel.My.Resources.Resources.Icono_Minimizar
        Me.btn_Minimizar.Location = New System.Drawing.Point(1368, 10)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Minimizar.TabIndex = 2
        Me.btn_Minimizar.UseVisualStyleBackColor = True
        '
        'btn_Maximizar
        '
        Me.btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Maximizar.FlatAppearance.BorderSize = 0
        Me.btn_Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Maximizar.Image = Global.KreaLabel.My.Resources.Resources.Icono_Maximizar
        Me.btn_Maximizar.Location = New System.Drawing.Point(1414, 10)
        Me.btn_Maximizar.Name = "btn_Maximizar"
        Me.btn_Maximizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Maximizar.TabIndex = 1
        Me.btn_Maximizar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cerrar.Image = Global.KreaLabel.My.Resources.Resources.Icono_cerrar_FN
        Me.btn_Cerrar.Location = New System.Drawing.Point(1460, 10)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.Panel8)
        Me.panelMenu.Controls.Add(Me.Panel6)
        Me.panelMenu.Controls.Add(Me.Panel5)
        Me.panelMenu.Controls.Add(Me.Panel4)
        Me.panelMenu.Controls.Add(Me.Panel3)
        Me.panelMenu.Controls.Add(Me.Button4)
        Me.panelMenu.Controls.Add(Me.btn_Abrir_Configuracion)
        Me.panelMenu.Controls.Add(Me.Button2)
        Me.panelMenu.Controls.Add(Me.Panel2)
        Me.panelMenu.Controls.Add(Me.Button1)
        Me.panelMenu.Controls.Add(Me.Panel1)
        Me.panelMenu.Controls.Add(Me.btn_Abrir_Conceptos)
        Me.panelMenu.Controls.Add(Me.btn_Menu)
        Me.panelMenu.Controls.Add(Me.btn_Exportar)
        Me.panelMenu.Controls.Add(Me.Button3)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 60)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 740)
        Me.panelMenu.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Location = New System.Drawing.Point(0, 253)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 50)
        Me.Panel8.TabIndex = 13
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(0, 57)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(5, 50)
        Me.Panel9.TabIndex = 12
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Location = New System.Drawing.Point(0, 496)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Location = New System.Drawing.Point(0, 440)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 311)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(0, 196)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 11
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 57)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 50)
        Me.Panel7.TabIndex = 12
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.KreaLabel.My.Resources.Resources.usuarios
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 496)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(220, 50)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Usuarios"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btn_Abrir_Configuracion
        '
        Me.btn_Abrir_Configuracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Abrir_Configuracion.FlatAppearance.BorderSize = 0
        Me.btn_Abrir_Configuracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_Abrir_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Abrir_Configuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Abrir_Configuracion.ForeColor = System.Drawing.Color.White
        Me.btn_Abrir_Configuracion.Image = Global.KreaLabel.My.Resources.Resources.conf
        Me.btn_Abrir_Configuracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Abrir_Configuracion.Location = New System.Drawing.Point(0, 440)
        Me.btn_Abrir_Configuracion.Name = "btn_Abrir_Configuracion"
        Me.btn_Abrir_Configuracion.Size = New System.Drawing.Size(220, 50)
        Me.btn_Abrir_Configuracion.TabIndex = 9
        Me.btn_Abrir_Configuracion.Text = "Configuración"
        Me.btn_Abrir_Configuracion.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.KreaLabel.My.Resources.Resources.list_white
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 50)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "              Imprimir Etiquetas"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.KreaLabel.My.Resources.Resources.list
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "              Añadir artículos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 5
        '
        'btn_Abrir_Conceptos
        '
        Me.btn_Abrir_Conceptos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Abrir_Conceptos.FlatAppearance.BorderSize = 0
        Me.btn_Abrir_Conceptos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_Abrir_Conceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Abrir_Conceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Abrir_Conceptos.ForeColor = System.Drawing.Color.White
        Me.btn_Abrir_Conceptos.Image = Global.KreaLabel.My.Resources.Resources.conceptos
        Me.btn_Abrir_Conceptos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Abrir_Conceptos.Location = New System.Drawing.Point(0, 140)
        Me.btn_Abrir_Conceptos.Name = "btn_Abrir_Conceptos"
        Me.btn_Abrir_Conceptos.Size = New System.Drawing.Size(220, 50)
        Me.btn_Abrir_Conceptos.TabIndex = 1
        Me.btn_Abrir_Conceptos.Text = "              Histórico de Precios"
        Me.btn_Abrir_Conceptos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Abrir_Conceptos.UseVisualStyleBackColor = True
        '
        'btn_Menu
        '
        Me.btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Menu.Image = Global.KreaLabel.My.Resources.Resources.Mobile_Menu_Icon
        Me.btn_Menu.Location = New System.Drawing.Point(4, 11)
        Me.btn_Menu.Name = "btn_Menu"
        Me.btn_Menu.Size = New System.Drawing.Size(38, 31)
        Me.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Menu.TabIndex = 0
        Me.btn_Menu.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exportar.FlatAppearance.BorderSize = 0
        Me.btn_Exportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.btn_Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exportar.ForeColor = System.Drawing.Color.White
        Me.btn_Exportar.Image = Global.KreaLabel.My.Resources.Resources.nominas
        Me.btn_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exportar.Location = New System.Drawing.Point(0, 84)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(220, 50)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "              Artículos"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.KreaLabel.My.Resources.Resources.list
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 253)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(220, 50)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "              Diferencia precios"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TimerOcultarMenu
        '
        '
        'TimerMostrarMenu
        '
        '
        'panelContenedor
        '
        Me.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelContenedor.Controls.Add(Me.lblInfo)
        Me.panelContenedor.Controls.Add(Me.Progreso1)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(220, 60)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1280, 740)
        Me.panelContenedor.TabIndex = 2
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(522, 231)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(239, 20)
        Me.lblInfo.TabIndex = 15
        Me.lblInfo.Text = "Calculando diferencias de Precio"
        Me.lblInfo.Visible = False
        '
        'Progreso1
        '
        Me.Progreso1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.Progreso1.AnimationSpeed = 500
        Me.Progreso1.BackColor = System.Drawing.Color.Transparent
        Me.Progreso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Progreso1.ForeColor = System.Drawing.Color.LightGray
        Me.Progreso1.InnerColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Progreso1.InnerMargin = 2
        Me.Progreso1.InnerWidth = -1
        Me.Progreso1.Location = New System.Drawing.Point(539, 271)
        Me.Progreso1.MarqueeAnimationSpeed = 2000
        Me.Progreso1.Name = "Progreso1"
        Me.Progreso1.OuterColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Progreso1.OuterMargin = -25
        Me.Progreso1.OuterWidth = 25
        Me.Progreso1.ProgressColor = System.Drawing.Color.Blue
        Me.Progreso1.ProgressWidth = 20
        Me.Progreso1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Progreso1.Size = New System.Drawing.Size(202, 199)
        Me.Progreso1.StartAngle = 270
        Me.Progreso1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.Progreso1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Progreso1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.Progreso1.SubscriptText = "%"
        Me.Progreso1.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Progreso1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.Progreso1.SuperscriptText = ""
        Me.Progreso1.TabIndex = 14
        Me.Progreso1.Text = "0"
        Me.Progreso1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.Progreso1.Value = 68
        Me.Progreso1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1500, 800)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Principal"
        Me.panelCabecera.ResumeLayout(False)
        Me.panelCabecera.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.btn_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelCabecera As Windows.Forms.Panel
    Friend WithEvents panelMenu As Windows.Forms.Panel
    Friend WithEvents btn_Cerrar As Windows.Forms.Button
    Friend WithEvents btn_Maximizar As Windows.Forms.Button
    Friend WithEvents btn_Minimizar As Windows.Forms.Button
    Friend WithEvents btn_Restaurar As Windows.Forms.Button
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents btn_Menu As Windows.Forms.PictureBox
    Friend WithEvents TimerOcultarMenu As Windows.Forms.Timer
    Friend WithEvents TimerMostrarMenu As Windows.Forms.Timer
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents btn_Abrir_Conceptos As Windows.Forms.Button
    Friend WithEvents btn_Exportar As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents btn_Abrir_Configuracion As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents Panel6 As Windows.Forms.Panel
    Friend WithEvents Panel5 As Windows.Forms.Panel
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Progreso1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblInfo As Label
End Class
