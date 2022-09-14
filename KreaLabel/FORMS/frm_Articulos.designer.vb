<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Articulos))
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.imgSalir = New System.Windows.Forms.PictureBox()
        Me.imgIncluir = New System.Windows.Forms.PictureBox()
        Me.imgBuscar = New System.Windows.Forms.PictureBox()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.dgArticulos = New System.Windows.Forms.DataGridView()
        Me.images = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.imgSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgIncluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDatos.SuspendLayout()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.White
        Me.PanelBarraTitulo.Controls.Add(Me.imgSalir)
        Me.PanelBarraTitulo.Controls.Add(Me.imgIncluir)
        Me.PanelBarraTitulo.Controls.Add(Me.imgBuscar)
        Me.PanelBarraTitulo.Controls.Add(Me.txtArticulo)
        Me.PanelBarraTitulo.Controls.Add(Me.txtBuscar)
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1197, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'imgSalir
        '
        Me.imgSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgSalir.Image = Global.KreaLabel.My.Resources.Resources.BOTON_CERRAR
        Me.imgSalir.Location = New System.Drawing.Point(1048, 0)
        Me.imgSalir.Name = "imgSalir"
        Me.imgSalir.Size = New System.Drawing.Size(171, 45)
        Me.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSalir.TabIndex = 25
        Me.imgSalir.TabStop = False
        '
        'imgIncluir
        '
        Me.imgIncluir.Image = Global.KreaLabel.My.Resources.Resources.INCLUIR_ARTÍCULO
        Me.imgIncluir.InitialImage = Nothing
        Me.imgIncluir.Location = New System.Drawing.Point(339, 5)
        Me.imgIncluir.Name = "imgIncluir"
        Me.imgIncluir.Size = New System.Drawing.Size(35, 30)
        Me.imgIncluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgIncluir.TabIndex = 8
        Me.imgIncluir.TabStop = False
        '
        'imgBuscar
        '
        Me.imgBuscar.Image = Global.KreaLabel.My.Resources.Resources.BUSCAR_ARTÍCULO1
        Me.imgBuscar.InitialImage = Global.KreaLabel.My.Resources.Resources.BUSCAR_ARTÍCULO1
        Me.imgBuscar.Location = New System.Drawing.Point(8, 5)
        Me.imgBuscar.Name = "imgBuscar"
        Me.imgBuscar.Size = New System.Drawing.Size(35, 30)
        Me.imgBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBuscar.TabIndex = 7
        Me.imgBuscar.TabStop = False
        '
        'txtArticulo
        '
        Me.txtArticulo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtArticulo.Location = New System.Drawing.Point(380, 5)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(328, 29)
        Me.txtArticulo.TabIndex = 5
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBuscar.Location = New System.Drawing.Point(49, 5)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(282, 29)
        Me.txtBuscar.TabIndex = 2
        Me.txtBuscar.TabStop = False
        '
        'panelDatos
        '
        Me.panelDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDatos.AutoSize = True
        Me.panelDatos.Controls.Add(Me.dgArticulos)
        Me.panelDatos.Location = New System.Drawing.Point(0, 45)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(1200, 524)
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
        Me.dgArticulos.Location = New System.Drawing.Point(10, 4)
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
        Me.dgArticulos.RowHeadersWidth = 51
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("DaxlinePro-Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgArticulos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArticulos.Size = New System.Drawing.Size(1177, 517)
        Me.dgArticulos.TabIndex = 1
        Me.dgArticulos.TabStop = False
        '
        'images
        '
        Me.images.ImageStream = CType(resources.GetObject("images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.images.TransparentColor = System.Drawing.Color.Transparent
        Me.images.Images.SetKeyName(0, "ICONO VISTO.png")
        Me.images.Images.SetKeyName(1, "ICONO NO VISTO.png")
        '
        'frm_Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 571)
        Me.Controls.Add(Me.panelDatos)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_Articulos"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Mantenimiento de Artículos"
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.imgSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgIncluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDatos.ResumeLayout(False)
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelBarraTitulo As Windows.Forms.Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtArticulo As TextBox
    Friend WithEvents imgBuscar As PictureBox
    Friend WithEvents imgIncluir As PictureBox
    Friend WithEvents panelDatos As Panel
    Friend WithEvents dgArticulos As DataGridView
    Friend WithEvents images As ImageList
    Friend WithEvents imgSalir As PictureBox
End Class
