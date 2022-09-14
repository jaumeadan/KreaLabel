<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RutaBD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RutaBD))
        Me.imgBD = New System.Windows.Forms.PictureBox()
        Me.txtBD = New System.Windows.Forms.TextBox()
        Me.lblBD = New System.Windows.Forms.Label()
        Me.ofdBDLogo = New System.Windows.Forms.OpenFileDialog()
        Me.imgValidar = New System.Windows.Forms.PictureBox()
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btn_Minimizar = New System.Windows.Forms.Button()
        Me.btn_Maximizar = New System.Windows.Forms.Button()
        Me.btn_Restaurar = New System.Windows.Forms.Button()
        CType(Me.imgBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgValidar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgBD
        '
        Me.imgBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgBD.Image = Global.KreaLabel.My.Resources.Resources.BUSCAR_ARTÍCULO1
        Me.imgBD.Location = New System.Drawing.Point(828, 54)
        Me.imgBD.Name = "imgBD"
        Me.imgBD.Size = New System.Drawing.Size(35, 31)
        Me.imgBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBD.TabIndex = 26
        Me.imgBD.TabStop = False
        '
        'txtBD
        '
        Me.txtBD.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBD.Location = New System.Drawing.Point(12, 88)
        Me.txtBD.MaxLength = 255
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(892, 32)
        Me.txtBD.TabIndex = 25
        '
        'lblBD
        '
        Me.lblBD.AutoSize = True
        Me.lblBD.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBD.Location = New System.Drawing.Point(8, 61)
        Me.lblBD.Name = "lblBD"
        Me.lblBD.Size = New System.Drawing.Size(159, 24)
        Me.lblBD.TabIndex = 24
        Me.lblBD.Text = "RUTA FICHERO DATA:"
        '
        'ofdBDLogo
        '
        Me.ofdBDLogo.FileName = "OpenFileDialog1"
        '
        'imgValidar
        '
        Me.imgValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgValidar.Image = Global.KreaLabel.My.Resources.Resources.ICONO_VISTO
        Me.imgValidar.Location = New System.Drawing.Point(869, 54)
        Me.imgValidar.Name = "imgValidar"
        Me.imgValidar.Size = New System.Drawing.Size(35, 31)
        Me.imgValidar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgValidar.TabIndex = 27
        Me.imgValidar.TabStop = False
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
        Me.panelCabecera.Size = New System.Drawing.Size(916, 41)
        Me.panelCabecera.TabIndex = 28
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(876, 3)
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
        Me.lblTitulo.Size = New System.Drawing.Size(919, 43)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "BASE DE DATOS"
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
        Me.btn_Minimizar.Location = New System.Drawing.Point(784, 3)
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
        Me.btn_Maximizar.Location = New System.Drawing.Point(830, 3)
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
        Me.btn_Restaurar.Location = New System.Drawing.Point(830, 3)
        Me.btn_Restaurar.Name = "btn_Restaurar"
        Me.btn_Restaurar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Restaurar.TabIndex = 3
        Me.btn_Restaurar.UseVisualStyleBackColor = True
        Me.btn_Restaurar.Visible = False
        '
        'frm_RutaBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(916, 131)
        Me.Controls.Add(Me.panelCabecera)
        Me.Controls.Add(Me.imgValidar)
        Me.Controls.Add(Me.imgBD)
        Me.Controls.Add(Me.txtBD)
        Me.Controls.Add(Me.lblBD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_RutaBD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_RutaBD"
        CType(Me.imgBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgValidar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCabecera.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgBD As PictureBox
    Friend WithEvents txtBD As TextBox
    Friend WithEvents lblBD As Label
    Friend WithEvents ofdBDLogo As OpenFileDialog
    Friend WithEvents imgValidar As PictureBox
    Friend WithEvents panelCabecera As Panel
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btn_Minimizar As Button
    Friend WithEvents btn_Maximizar As Button
    Friend WithEvents btn_Restaurar As Button
End Class
