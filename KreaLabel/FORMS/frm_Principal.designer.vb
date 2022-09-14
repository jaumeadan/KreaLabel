<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Principal))
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgLogoFondo = New System.Windows.Forms.PictureBox()
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btn_Minimizar = New System.Windows.Forms.Button()
        Me.btn_Maximizar = New System.Windows.Forms.Button()
        Me.btn_Restaurar = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblConf = New System.Windows.Forms.Label()
        Me.imgConfiguracion = New System.Windows.Forms.PictureBox()
        Me.imgConfiguracionSeleccionado = New System.Windows.Forms.PictureBox()
        Me.imgArticulos = New System.Windows.Forms.PictureBox()
        Me.imgArticulosSeleccionado = New System.Windows.Forms.PictureBox()
        Me.lblImprimir = New System.Windows.Forms.Label()
        Me.lblPrecios = New System.Windows.Forms.Label()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.imgImprimir = New System.Windows.Forms.PictureBox()
        Me.imgPrecios = New System.Windows.Forms.PictureBox()
        Me.imgPreciosSeleccionado = New System.Windows.Forms.PictureBox()
        Me.imgImprimirSeleccionado = New System.Windows.Forms.PictureBox()
        Me.panelContenedor.SuspendLayout()
        CType(Me.imgLogoFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCabecera.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.imgConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgConfiguracionSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgArticulosSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPreciosSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgImprimirSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.White
        Me.panelContenedor.Controls.Add(Me.Label1)
        Me.panelContenedor.Controls.Add(Me.imgLogoFondo)
        Me.panelContenedor.Location = New System.Drawing.Point(104, 42)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1207, 629)
        Me.panelContenedor.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DaxlinePro-Regular", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(707, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "2.4"
        '
        'imgLogoFondo
        '
        Me.imgLogoFondo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgLogoFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgLogoFondo.Image = Global.KreaLabel.My.Resources.Resources.LOGOTIPO_FONDO
        Me.imgLogoFondo.Location = New System.Drawing.Point(351, 142)
        Me.imgLogoFondo.Name = "imgLogoFondo"
        Me.imgLogoFondo.Size = New System.Drawing.Size(500, 378)
        Me.imgLogoFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogoFondo.TabIndex = 20
        Me.imgLogoFondo.TabStop = False
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.DodgerBlue
        Me.panelCabecera.Controls.Add(Me.btn_Cerrar)
        Me.panelCabecera.Controls.Add(Me.lblTitulo)
        Me.panelCabecera.Controls.Add(Me.btn_Minimizar)
        Me.panelCabecera.Controls.Add(Me.btn_Maximizar)
        Me.panelCabecera.Controls.Add(Me.btn_Restaurar)
        Me.panelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(1314, 41)
        Me.panelCabecera.TabIndex = 1
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cerrar.Image = Global.KreaLabel.My.Resources.Resources.Icono_cerrar_FN
        Me.btn_Cerrar.Location = New System.Drawing.Point(1274, 3)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("DaxlinePro-Regular", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1317, 43)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "TITULO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Minimizar
        '
        Me.btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Minimizar.FlatAppearance.BorderSize = 0
        Me.btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Minimizar.Image = Global.KreaLabel.My.Resources.Resources.Icono_Minimizar
        Me.btn_Minimizar.Location = New System.Drawing.Point(1182, 3)
        Me.btn_Minimizar.Name = "btn_Minimizar"
        Me.btn_Minimizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Minimizar.TabIndex = 2
        Me.btn_Minimizar.UseVisualStyleBackColor = False
        Me.btn_Minimizar.Visible = False
        '
        'btn_Maximizar
        '
        Me.btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Maximizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Maximizar.FlatAppearance.BorderSize = 0
        Me.btn_Maximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Maximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btn_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Maximizar.Image = Global.KreaLabel.My.Resources.Resources.Icono_Maximizar
        Me.btn_Maximizar.Location = New System.Drawing.Point(1228, 3)
        Me.btn_Maximizar.Name = "btn_Maximizar"
        Me.btn_Maximizar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Maximizar.TabIndex = 1
        Me.btn_Maximizar.UseVisualStyleBackColor = False
        Me.btn_Maximizar.Visible = False
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
        Me.btn_Restaurar.Location = New System.Drawing.Point(1228, 3)
        Me.btn_Restaurar.Name = "btn_Restaurar"
        Me.btn_Restaurar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Restaurar.TabIndex = 3
        Me.btn_Restaurar.UseVisualStyleBackColor = True
        Me.btn_Restaurar.Visible = False
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.White
        Me.panelMenu.Controls.Add(Me.lblProducto)
        Me.panelMenu.Controls.Add(Me.lblConf)
        Me.panelMenu.Controls.Add(Me.imgConfiguracion)
        Me.panelMenu.Controls.Add(Me.imgConfiguracionSeleccionado)
        Me.panelMenu.Controls.Add(Me.imgArticulos)
        Me.panelMenu.Controls.Add(Me.imgArticulosSeleccionado)
        Me.panelMenu.Controls.Add(Me.lblImprimir)
        Me.panelMenu.Controls.Add(Me.lblPrecios)
        Me.panelMenu.Controls.Add(Me.imgLogo)
        Me.panelMenu.Controls.Add(Me.imgImprimir)
        Me.panelMenu.Controls.Add(Me.imgPrecios)
        Me.panelMenu.Controls.Add(Me.imgPreciosSeleccionado)
        Me.panelMenu.Controls.Add(Me.imgImprimirSeleccionado)
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(103, 671)
        Me.panelMenu.TabIndex = 0
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.BackColor = System.Drawing.Color.Transparent
        Me.lblProducto.Font = New System.Drawing.Font("DaxlinePro-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblProducto.Location = New System.Drawing.Point(19, 269)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(60, 20)
        Me.lblProducto.TabIndex = 21
        Me.lblProducto.Text = "Artículos"
        Me.lblProducto.Visible = False
        '
        'lblConf
        '
        Me.lblConf.AutoSize = True
        Me.lblConf.BackColor = System.Drawing.Color.Transparent
        Me.lblConf.Font = New System.Drawing.Font("DaxlinePro-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblConf.Location = New System.Drawing.Point(10, 647)
        Me.lblConf.Name = "lblConf"
        Me.lblConf.Size = New System.Drawing.Size(87, 20)
        Me.lblConf.TabIndex = 29
        Me.lblConf.Text = "Configuración"
        Me.lblConf.Visible = False
        '
        'imgConfiguracion
        '
        Me.imgConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgConfiguracion.Image = Global.KreaLabel.My.Resources.Resources.BOTON_CONFIGURACIÓN_USUARIO
        Me.imgConfiguracion.Location = New System.Drawing.Point(1, 554)
        Me.imgConfiguracion.Name = "imgConfiguracion"
        Me.imgConfiguracion.Size = New System.Drawing.Size(103, 96)
        Me.imgConfiguracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgConfiguracion.TabIndex = 22
        Me.imgConfiguracion.TabStop = False
        '
        'imgConfiguracionSeleccionado
        '
        Me.imgConfiguracionSeleccionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgConfiguracionSeleccionado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgConfiguracionSeleccionado.Image = Global.KreaLabel.My.Resources.Resources.BOTON_CONFIGURACIÓN_USUARIO_activo
        Me.imgConfiguracionSeleccionado.Location = New System.Drawing.Point(1, 554)
        Me.imgConfiguracionSeleccionado.Name = "imgConfiguracionSeleccionado"
        Me.imgConfiguracionSeleccionado.Size = New System.Drawing.Size(103, 96)
        Me.imgConfiguracionSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgConfiguracionSeleccionado.TabIndex = 26
        Me.imgConfiguracionSeleccionado.TabStop = False
        Me.imgConfiguracionSeleccionado.Visible = False
        '
        'imgArticulos
        '
        Me.imgArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgArticulos.Image = Global.KreaLabel.My.Resources.Resources.BOTON_ARTÍCULO
        Me.imgArticulos.Location = New System.Drawing.Point(0, 163)
        Me.imgArticulos.Name = "imgArticulos"
        Me.imgArticulos.Size = New System.Drawing.Size(103, 119)
        Me.imgArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgArticulos.TabIndex = 19
        Me.imgArticulos.TabStop = False
        '
        'imgArticulosSeleccionado
        '
        Me.imgArticulosSeleccionado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgArticulosSeleccionado.Image = Global.KreaLabel.My.Resources.Resources.BOTON_ARTÍCULO_activo
        Me.imgArticulosSeleccionado.Location = New System.Drawing.Point(0, 163)
        Me.imgArticulosSeleccionado.Name = "imgArticulosSeleccionado"
        Me.imgArticulosSeleccionado.Size = New System.Drawing.Size(103, 119)
        Me.imgArticulosSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgArticulosSeleccionado.TabIndex = 23
        Me.imgArticulosSeleccionado.TabStop = False
        Me.imgArticulosSeleccionado.Visible = False
        '
        'lblImprimir
        '
        Me.lblImprimir.AutoSize = True
        Me.lblImprimir.BackColor = System.Drawing.Color.Transparent
        Me.lblImprimir.Font = New System.Drawing.Font("DaxlinePro-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblImprimir.Location = New System.Drawing.Point(19, 528)
        Me.lblImprimir.Name = "lblImprimir"
        Me.lblImprimir.Size = New System.Drawing.Size(58, 20)
        Me.lblImprimir.TabIndex = 28
        Me.lblImprimir.Text = "Imprimir"
        Me.lblImprimir.Visible = False
        '
        'lblPrecios
        '
        Me.lblPrecios.AutoSize = True
        Me.lblPrecios.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecios.Font = New System.Drawing.Font("DaxlinePro-Bold", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.lblPrecios.Location = New System.Drawing.Point(4, 395)
        Me.lblPrecios.Name = "lblPrecios"
        Me.lblPrecios.Size = New System.Drawing.Size(96, 20)
        Me.lblPrecios.TabIndex = 27
        Me.lblPrecios.Text = "Cambio Precios"
        Me.lblPrecios.Visible = False
        '
        'imgLogo
        '
        Me.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgLogo.Image = Global.KreaLabel.My.Resources.Resources.LOGOTIPO1
        Me.imgLogo.Location = New System.Drawing.Point(8, 45)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(90, 104)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 18
        Me.imgLogo.TabStop = False
        '
        'imgImprimir
        '
        Me.imgImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgImprimir.Image = Global.KreaLabel.My.Resources.Resources.BOTON_IMPRESIÓN
        Me.imgImprimir.Location = New System.Drawing.Point(1, 426)
        Me.imgImprimir.Name = "imgImprimir"
        Me.imgImprimir.Size = New System.Drawing.Size(103, 119)
        Me.imgImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgImprimir.TabIndex = 21
        Me.imgImprimir.TabStop = False
        '
        'imgPrecios
        '
        Me.imgPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgPrecios.Image = Global.KreaLabel.My.Resources.Resources.BOTON_CAMBIO_PRECIO
        Me.imgPrecios.Location = New System.Drawing.Point(1, 292)
        Me.imgPrecios.Name = "imgPrecios"
        Me.imgPrecios.Size = New System.Drawing.Size(103, 119)
        Me.imgPrecios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPrecios.TabIndex = 20
        Me.imgPrecios.TabStop = False
        '
        'imgPreciosSeleccionado
        '
        Me.imgPreciosSeleccionado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgPreciosSeleccionado.Image = Global.KreaLabel.My.Resources.Resources.BOTON_CAMBIO_PRECIO_activo
        Me.imgPreciosSeleccionado.Location = New System.Drawing.Point(1, 292)
        Me.imgPreciosSeleccionado.Name = "imgPreciosSeleccionado"
        Me.imgPreciosSeleccionado.Size = New System.Drawing.Size(103, 119)
        Me.imgPreciosSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPreciosSeleccionado.TabIndex = 24
        Me.imgPreciosSeleccionado.TabStop = False
        Me.imgPreciosSeleccionado.Visible = False
        '
        'imgImprimirSeleccionado
        '
        Me.imgImprimirSeleccionado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgImprimirSeleccionado.Image = Global.KreaLabel.My.Resources.Resources.BOTON_IMPRESIÓN_activo
        Me.imgImprimirSeleccionado.Location = New System.Drawing.Point(1, 426)
        Me.imgImprimirSeleccionado.Name = "imgImprimirSeleccionado"
        Me.imgImprimirSeleccionado.Size = New System.Drawing.Size(103, 119)
        Me.imgImprimirSeleccionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgImprimirSeleccionado.TabIndex = 25
        Me.imgImprimirSeleccionado.TabStop = False
        Me.imgImprimirSeleccionado.Visible = False
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 672)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelCabecera)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1318, 655)
        Me.Name = "frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Principal"
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        CType(Me.imgLogoFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCabecera.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.imgConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgConfiguracionSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgArticulosSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPreciosSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgImprimirSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents imgLogoFondo As PictureBox
    Friend WithEvents panelCabecera As Panel
    Friend WithEvents btn_Minimizar As Button
    Friend WithEvents btn_Maximizar As Button
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents btn_Restaurar As Button
    Friend WithEvents panelMenu As Panel
    Friend WithEvents imgConfiguracion As PictureBox
    Friend WithEvents imgConfiguracionSeleccionado As PictureBox
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents imgImprimir As PictureBox
    Friend WithEvents imgArticulos As PictureBox
    Friend WithEvents imgPrecios As PictureBox
    Friend WithEvents imgPreciosSeleccionado As PictureBox
    Friend WithEvents imgArticulosSeleccionado As PictureBox
    Friend WithEvents imgImprimirSeleccionado As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblPrecios As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents lblConf As Label
    Friend WithEvents lblImprimir As Label
    Friend WithEvents Label1 As Label
End Class
