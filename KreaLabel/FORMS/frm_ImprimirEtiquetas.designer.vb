<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ImprimirEtiquetas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ImprimirEtiquetas))
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBD = New System.Windows.Forms.Label()
        Me.txtFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.imgValidar = New System.Windows.Forms.PictureBox()
        Me.imgImprimir = New System.Windows.Forms.PictureBox()
        Me.chkNoImpresos = New System.Windows.Forms.CheckBox()
        Me.chkImpresos = New System.Windows.Forms.CheckBox()
        Me.imgSalir = New System.Windows.Forms.PictureBox()
        Me.imgBuscar = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.images = New System.Windows.Forms.ImageList(Me.components)
        Me.panelDatos.SuspendLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.imgValidar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelDatos
        '
        Me.panelDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDatos.AutoSize = True
        Me.panelDatos.Controls.Add(Me.dgArticulos)
        Me.panelDatos.Location = New System.Drawing.Point(0, 83)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(1231, 488)
        Me.panelDatos.TabIndex = 1
        '
        'dgArticulos
        '
        Me.dgArticulos.AllowUserToAddRows = False
        Me.dgArticulos.AllowUserToDeleteRows = False
        Me.dgArticulos.AllowUserToOrderColumns = True
        Me.dgArticulos.AllowUserToResizeColumns = False
        Me.dgArticulos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("DaxlinePro-Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgArticulos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgArticulos.BackgroundColor = System.Drawing.Color.White
        Me.dgArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("DaxlinePro-Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgArticulos.ColumnHeadersHeight = 30
        Me.dgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("DaxlinePro-Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgArticulos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgArticulos.EnableHeadersVisualStyles = False
        Me.dgArticulos.GridColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgArticulos.Location = New System.Drawing.Point(17, 4)
        Me.dgArticulos.MultiSelect = False
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.ReadOnly = True
        Me.dgArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgArticulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgArticulos.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("DaxlinePro-Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgArticulos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArticulos.Size = New System.Drawing.Size(1202, 478)
        Me.dgArticulos.TabIndex = 0
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.White
        Me.PanelBarraTitulo.Controls.Add(Me.Label2)
        Me.PanelBarraTitulo.Controls.Add(Me.Label1)
        Me.PanelBarraTitulo.Controls.Add(Me.lblBD)
        Me.PanelBarraTitulo.Controls.Add(Me.txtFechaHasta)
        Me.PanelBarraTitulo.Controls.Add(Me.txtHasta)
        Me.PanelBarraTitulo.Controls.Add(Me.txtDesde)
        Me.PanelBarraTitulo.Controls.Add(Me.imgValidar)
        Me.PanelBarraTitulo.Controls.Add(Me.imgImprimir)
        Me.PanelBarraTitulo.Controls.Add(Me.chkNoImpresos)
        Me.PanelBarraTitulo.Controls.Add(Me.chkImpresos)
        Me.PanelBarraTitulo.Controls.Add(Me.imgSalir)
        Me.PanelBarraTitulo.Controls.Add(Me.imgBuscar)
        Me.PanelBarraTitulo.Controls.Add(Me.txtBuscar)
        Me.PanelBarraTitulo.Controls.Add(Me.txtFechaDesde)
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1200, 79)
        Me.PanelBarraTitulo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(479, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CÓDIGO o DESCRIPCIÓN:"
        '
        'lblBD
        '
        Me.lblBD.AutoSize = True
        Me.lblBD.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBD.Location = New System.Drawing.Point(229, 9)
        Me.lblBD.Name = "lblBD"
        Me.lblBD.Size = New System.Drawing.Size(32, 24)
        Me.lblBD.TabIndex = 2
        Me.lblBD.Text = "Nº:"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.CalendarFont = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaHasta.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtFechaHasta.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtFechaHasta.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaHasta.Location = New System.Drawing.Point(74, 42)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(121, 32)
        Me.txtFechaHasta.TabIndex = 1
        '
        'txtHasta
        '
        Me.txtHasta.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!)
        Me.txtHasta.Location = New System.Drawing.Point(263, 39)
        Me.txtHasta.MaxLength = 5
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(74, 32)
        Me.txtHasta.TabIndex = 4
        Me.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesde
        '
        Me.txtDesde.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!)
        Me.txtDesde.Location = New System.Drawing.Point(263, 4)
        Me.txtDesde.MaxLength = 5
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(74, 32)
        Me.txtDesde.TabIndex = 3
        Me.txtDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'imgValidar
        '
        Me.imgValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgValidar.Image = Global.KreaLabel.My.Resources.Resources.ICONO_VISTO
        Me.imgValidar.Location = New System.Drawing.Point(1195, 42)
        Me.imgValidar.Name = "imgValidar"
        Me.imgValidar.Size = New System.Drawing.Size(35, 31)
        Me.imgValidar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgValidar.TabIndex = 28
        Me.imgValidar.TabStop = False
        Me.imgValidar.Visible = False
        '
        'imgImprimir
        '
        Me.imgImprimir.Image = Global.KreaLabel.My.Resources.Resources.boton_impresion_imprimir1
        Me.imgImprimir.InitialImage = Nothing
        Me.imgImprimir.Location = New System.Drawing.Point(896, 12)
        Me.imgImprimir.Name = "imgImprimir"
        Me.imgImprimir.Size = New System.Drawing.Size(145, 52)
        Me.imgImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgImprimir.TabIndex = 8
        Me.imgImprimir.TabStop = False
        '
        'chkNoImpresos
        '
        Me.chkNoImpresos.AutoSize = True
        Me.chkNoImpresos.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!)
        Me.chkNoImpresos.Location = New System.Drawing.Point(359, 39)
        Me.chkNoImpresos.Name = "chkNoImpresos"
        Me.chkNoImpresos.Size = New System.Drawing.Size(118, 28)
        Me.chkNoImpresos.TabIndex = 6
        Me.chkNoImpresos.Text = "No impresos"
        Me.chkNoImpresos.UseVisualStyleBackColor = True
        '
        'chkImpresos
        '
        Me.chkImpresos.AutoSize = True
        Me.chkImpresos.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!)
        Me.chkImpresos.Location = New System.Drawing.Point(359, 4)
        Me.chkImpresos.Name = "chkImpresos"
        Me.chkImpresos.Size = New System.Drawing.Size(94, 28)
        Me.chkImpresos.TabIndex = 5
        Me.chkImpresos.Text = "Impresos"
        Me.chkImpresos.UseVisualStyleBackColor = True
        '
        'imgSalir
        '
        Me.imgSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgSalir.Image = Global.KreaLabel.My.Resources.Resources.BOTON_CERRAR
        Me.imgSalir.Location = New System.Drawing.Point(1048, 16)
        Me.imgSalir.Name = "imgSalir"
        Me.imgSalir.Size = New System.Drawing.Size(171, 45)
        Me.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSalir.TabIndex = 24
        Me.imgSalir.TabStop = False
        '
        'imgBuscar
        '
        Me.imgBuscar.Image = Global.KreaLabel.My.Resources.Resources.BUSCAR_ARTÍCULO1
        Me.imgBuscar.InitialImage = Global.KreaLabel.My.Resources.Resources.BUSCAR_ARTÍCULO1
        Me.imgBuscar.Location = New System.Drawing.Point(797, 7)
        Me.imgBuscar.Name = "imgBuscar"
        Me.imgBuscar.Size = New System.Drawing.Size(78, 68)
        Me.imgBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBuscar.TabIndex = 13
        Me.imgBuscar.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(483, 39)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(308, 32)
        Me.txtBuscar.TabIndex = 8
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.CalendarFont = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaDesde.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtFechaDesde.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtFechaDesde.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaDesde.Location = New System.Drawing.Point(74, 5)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(121, 32)
        Me.txtFechaDesde.TabIndex = 0
        '
        'images
        '
        Me.images.ImageStream = CType(resources.GetObject("images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.images.TransparentColor = System.Drawing.Color.Transparent
        Me.images.Images.SetKeyName(0, "ICONO VISTO.png")
        Me.images.Images.SetKeyName(1, "ICONO NO VISTO.png")
        '
        'frm_ImprimirEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1231, 571)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.Controls.Add(Me.panelDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_ImprimirEtiquetas"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir etiquetas"
        Me.panelDatos.ResumeLayout(False)
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.imgValidar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelDatos As Panel
    Friend WithEvents dgArticulos As DataGridView
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtFechaDesde As DateTimePicker
    Friend WithEvents imgImprimir As PictureBox
    Friend WithEvents imgBuscar As PictureBox
    Friend WithEvents imgSalir As PictureBox
    Friend WithEvents chkNoImpresos As CheckBox
    Friend WithEvents chkImpresos As CheckBox
    Friend WithEvents images As ImageList
    Friend WithEvents imgValidar As PictureBox
    Friend WithEvents txtHasta As TextBox
    Friend WithEvents txtDesde As TextBox
    Friend WithEvents txtFechaHasta As DateTimePicker
    Friend WithEvents lblBD As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
