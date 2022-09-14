<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Welcome))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblusuario = New System.Windows.Forms.Label()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.imgBarra = New System.Windows.Forms.PictureBox()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.ofdBDLogo = New System.Windows.Forms.OpenFileDialog()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        CType(Me.imgBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("DaxlinePro-Regular", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(324, 129)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(286, 40)
        Me.txtUsuario.TabIndex = 0
        '
        'lblusuario
        '
        Me.lblusuario.AutoSize = True
        Me.lblusuario.Font = New System.Drawing.Font("DaxlinePro-Regular", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblusuario.Location = New System.Drawing.Point(318, 94)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(91, 32)
        Me.lblusuario.TabIndex = 20
        Me.lblusuario.Text = "Usuario:"
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Font = New System.Drawing.Font("DaxlinePro-Regular", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.lblContraseña.Location = New System.Drawing.Point(318, 188)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(126, 32)
        Me.lblContraseña.TabIndex = 21
        Me.lblContraseña.Text = "Contraseña:"
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("DaxlinePro-Regular", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.txtContraseña.Location = New System.Drawing.Point(324, 223)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(286, 40)
        Me.txtContraseña.TabIndex = 1
        '
        'imgBarra
        '
        Me.imgBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgBarra.Image = Global.KreaLabel.My.Resources.Resources.BARRA_DE_CARGA
        Me.imgBarra.Location = New System.Drawing.Point(0, 355)
        Me.imgBarra.Name = "imgBarra"
        Me.imgBarra.Size = New System.Drawing.Size(622, 10)
        Me.imgBarra.TabIndex = 22
        Me.imgBarra.TabStop = False
        Me.imgBarra.Visible = False
        '
        'imgLogo
        '
        Me.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgLogo.Image = Global.KreaLabel.My.Resources.Resources.LOGOTIPO
        Me.imgLogo.Location = New System.Drawing.Point(0, 0)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(306, 354)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 17
        Me.imgLogo.TabStop = False
        '
        'ofdBDLogo
        '
        Me.ofdBDLogo.FileName = "OpenFileDialog1"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cerrar.Image = Global.KreaLabel.My.Resources.Resources.Icono_cerrar_FN
        Me.btn_Cerrar.Location = New System.Drawing.Point(582, 0)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Cerrar.TabIndex = 28
        Me.btn_Cerrar.UseVisualStyleBackColor = False
        '
        'frm_Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(622, 367)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.imgBarra)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.imgLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Welcome"
        CType(Me.imgBarra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lblusuario As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents imgBarra As PictureBox
    Friend WithEvents ofdBDLogo As OpenFileDialog
    Friend WithEvents btn_Cerrar As Button
End Class
