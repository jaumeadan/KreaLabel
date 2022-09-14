<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Configuracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Configuracion))
        Me.ofdBDLogo = New System.Windows.Forms.OpenFileDialog()
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.imgBrowser = New System.Windows.Forms.PictureBox()
        Me.txtLicencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtNombreComercial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.btnSeleccionarLogo = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.imgSalir = New System.Windows.Forms.PictureBox()
        Me.imgCancelar = New System.Windows.Forms.PictureBox()
        Me.imgGuardar = New System.Windows.Forms.PictureBox()
        Me.imgEditar = New System.Windows.Forms.PictureBox()
        Me.panelForm.SuspendLayout()
        CType(Me.imgBrowser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.imgSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdBDLogo
        '
        Me.ofdBDLogo.FileName = "OpenFileDialog1"
        '
        'panelForm
        '
        Me.panelForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelForm.BackColor = System.Drawing.Color.White
        Me.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelForm.Controls.Add(Me.imgBrowser)
        Me.panelForm.Controls.Add(Me.txtLicencia)
        Me.panelForm.Controls.Add(Me.Label6)
        Me.panelForm.Controls.Add(Me.txtDB)
        Me.panelForm.Controls.Add(Me.Label3)
        Me.panelForm.Controls.Add(Me.lblUsuario)
        Me.panelForm.Controls.Add(Me.txtNombreComercial)
        Me.panelForm.Controls.Add(Me.Label2)
        Me.panelForm.Controls.Add(Me.txtTelefono)
        Me.panelForm.Controls.Add(Me.txtNif)
        Me.panelForm.Controls.Add(Me.txtDireccion)
        Me.panelForm.Controls.Add(Me.txtRazonSocial)
        Me.panelForm.Controls.Add(Me.Label1)
        Me.panelForm.Controls.Add(Me.Label4)
        Me.panelForm.Controls.Add(Me.Label5)
        Me.panelForm.Controls.Add(Me.Label9)
        Me.panelForm.Controls.Add(Me.imgLogo)
        Me.panelForm.Controls.Add(Me.btnSeleccionarLogo)
        Me.panelForm.Controls.Add(Me.Label21)
        Me.panelForm.Location = New System.Drawing.Point(0, 0)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(926, 386)
        Me.panelForm.TabIndex = 0
        '
        'imgBrowser
        '
        Me.imgBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgBrowser.Image = Global.KreaLabel.My.Resources.Resources.BUSCAR_ARTÍCULO1
        Me.imgBrowser.Location = New System.Drawing.Point(879, 335)
        Me.imgBrowser.Name = "imgBrowser"
        Me.imgBrowser.Size = New System.Drawing.Size(35, 31)
        Me.imgBrowser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBrowser.TabIndex = 23
        Me.imgBrowser.TabStop = False
        '
        'txtLicencia
        '
        Me.txtLicencia.BackColor = System.Drawing.Color.White
        Me.txtLicencia.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicencia.Location = New System.Drawing.Point(579, 176)
        Me.txtLicencia.MaxLength = 255
        Me.txtLicencia.Name = "txtLicencia"
        Me.txtLicencia.Size = New System.Drawing.Size(334, 32)
        Me.txtLicencia.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(576, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "LICENCIA:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDB
        '
        Me.txtDB.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDB.Location = New System.Drawing.Point(12, 335)
        Me.txtDB.MaxLength = 255
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(864, 32)
        Me.txtDB.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "RUTA FICHERO FIREBIRD:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(11, 311)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(63, 24)
        Me.lblUsuario.TabIndex = 15
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.Visible = False
        '
        'txtNombreComercial
        '
        Me.txtNombreComercial.BackColor = System.Drawing.Color.White
        Me.txtNombreComercial.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreComercial.Location = New System.Drawing.Point(12, 108)
        Me.txtNombreComercial.MaxLength = 255
        Me.txtNombreComercial.Name = "txtNombreComercial"
        Me.txtNombreComercial.Size = New System.Drawing.Size(901, 32)
        Me.txtNombreComercial.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE COMERCIAL:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(283, 176)
        Me.txtTelefono.Mask = "000 000 000"
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(269, 32)
        Me.txtTelefono.TabIndex = 7
        Me.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNif
        '
        Me.txtNif.BackColor = System.Drawing.Color.White
        Me.txtNif.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNif.Location = New System.Drawing.Point(13, 176)
        Me.txtNif.MaxLength = 50
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(245, 32)
        Me.txtNif.TabIndex = 5
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(12, 245)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(902, 51)
        Me.txtDireccion.TabIndex = 11
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.White
        Me.txtRazonSocial.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Location = New System.Drawing.Point(12, 41)
        Me.txtRazonSocial.MaxLength = 255
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(901, 32)
        Me.txtRazonSocial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RAZÓN SOCIAL:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "N.I.F.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 24)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "DIRECCIÓN:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(280, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 24)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "TELÉFONO:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'imgLogo
        '
        Me.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imgLogo.InitialImage = Nothing
        Me.imgLogo.Location = New System.Drawing.Point(721, 49)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(193, 160)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 194
        Me.imgLogo.TabStop = False
        Me.imgLogo.Visible = False
        '
        'btnSeleccionarLogo
        '
        Me.btnSeleccionarLogo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarLogo.Image = Global.KreaLabel.My.Resources.Resources.logo
        Me.btnSeleccionarLogo.Location = New System.Drawing.Point(865, 17)
        Me.btnSeleccionarLogo.Name = "btnSeleccionarLogo"
        Me.btnSeleccionarLogo.Size = New System.Drawing.Size(49, 30)
        Me.btnSeleccionarLogo.TabIndex = 16
        Me.btnSeleccionarLogo.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnSeleccionarLogo.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(717, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(147, 24)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Logo (.jpg 2 x 2 cm)"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label21.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.imgSalir)
        Me.Panel1.Controls.Add(Me.imgCancelar)
        Me.Panel1.Controls.Add(Me.imgGuardar)
        Me.Panel1.Controls.Add(Me.imgEditar)
        Me.Panel1.Location = New System.Drawing.Point(0, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 60)
        Me.Panel1.TabIndex = 195
        '
        'imgSalir
        '
        Me.imgSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgSalir.Image = Global.KreaLabel.My.Resources.Resources.BOTON_CERRAR
        Me.imgSalir.Location = New System.Drawing.Point(743, 3)
        Me.imgSalir.Name = "imgSalir"
        Me.imgSalir.Size = New System.Drawing.Size(170, 53)
        Me.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSalir.TabIndex = 22
        Me.imgSalir.TabStop = False
        '
        'imgCancelar
        '
        Me.imgCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgCancelar.Image = Global.KreaLabel.My.Resources.Resources.BOTON_CANCELAR
        Me.imgCancelar.Location = New System.Drawing.Point(506, 3)
        Me.imgCancelar.Name = "imgCancelar"
        Me.imgCancelar.Size = New System.Drawing.Size(170, 53)
        Me.imgCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgCancelar.TabIndex = 21
        Me.imgCancelar.TabStop = False
        '
        'imgGuardar
        '
        Me.imgGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgGuardar.Image = Global.KreaLabel.My.Resources.Resources.BOTON_GUARDAR
        Me.imgGuardar.Location = New System.Drawing.Point(262, 3)
        Me.imgGuardar.Name = "imgGuardar"
        Me.imgGuardar.Size = New System.Drawing.Size(170, 53)
        Me.imgGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgGuardar.TabIndex = 20
        Me.imgGuardar.TabStop = False
        '
        'imgEditar
        '
        Me.imgEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgEditar.Image = Global.KreaLabel.My.Resources.Resources.BOTON_EDITAR
        Me.imgEditar.Location = New System.Drawing.Point(13, 3)
        Me.imgEditar.Name = "imgEditar"
        Me.imgEditar.Size = New System.Drawing.Size(170, 53)
        Me.imgEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgEditar.TabIndex = 19
        Me.imgEditar.TabStop = False
        '
        'frm_Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(926, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelForm)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelForm.ResumeLayout(False)
        Me.panelForm.PerformLayout()
        CType(Me.imgBrowser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.imgSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdBDLogo As Windows.Forms.OpenFileDialog
    Friend WithEvents panelForm As Windows.Forms.Panel
    Friend WithEvents txtNombreComercial As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelefono As MaskedTextBox
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents btnSeleccionarLogo As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents txtNif As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtRazonSocial As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtLicencia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents imgEditar As PictureBox
    Friend WithEvents imgGuardar As PictureBox
    Friend WithEvents imgCancelar As PictureBox
    Friend WithEvents imgSalir As PictureBox
    Friend WithEvents imgBrowser As PictureBox
End Class
