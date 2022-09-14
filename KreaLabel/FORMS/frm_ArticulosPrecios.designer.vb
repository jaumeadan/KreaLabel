<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ArticulosPrecios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ArticulosPrecios))
        Me.panelDatos = New System.Windows.Forms.Panel()
        Me.dgDetalle = New System.Windows.Forms.DataGridView()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.imgBuscar = New System.Windows.Forms.PictureBox()
        Me.txtFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.imgSalir = New System.Windows.Forms.PictureBox()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.imgConectarDLL = New System.Windows.Forms.PictureBox()
        Me.panelDatos.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.imgBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgConectarDLL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelDatos
        '
        Me.panelDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDatos.AutoSize = True
        Me.panelDatos.Controls.Add(Me.dgDetalle)
        Me.panelDatos.Location = New System.Drawing.Point(0, 58)
        Me.panelDatos.Name = "panelDatos"
        Me.panelDatos.Size = New System.Drawing.Size(1200, 512)
        Me.panelDatos.TabIndex = 1
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.AllowUserToDeleteRows = False
        Me.dgDetalle.AllowUserToOrderColumns = True
        Me.dgDetalle.AllowUserToResizeColumns = False
        Me.dgDetalle.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("DaxlinePro-Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dgDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("DaxlinePro-Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgDetalle.ColumnHeadersHeight = 30
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("DaxlinePro-Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDetalle.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgDetalle.EnableHeadersVisualStyles = False
        Me.dgDetalle.GridColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgDetalle.Location = New System.Drawing.Point(10, 0)
        Me.dgDetalle.MultiSelect = False
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.ReadOnly = True
        Me.dgDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgDetalle.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("DaxlinePro-Regular", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDetalle.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetalle.Size = New System.Drawing.Size(1182, 506)
        Me.dgDetalle.TabIndex = 1
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.White
        Me.PanelBarraTitulo.Controls.Add(Me.Label2)
        Me.PanelBarraTitulo.Controls.Add(Me.Label1)
        Me.PanelBarraTitulo.Controls.Add(Me.imgBuscar)
        Me.PanelBarraTitulo.Controls.Add(Me.txtFecha2)
        Me.PanelBarraTitulo.Controls.Add(Me.imgSalir)
        Me.PanelBarraTitulo.Controls.Add(Me.txtFecha)
        Me.PanelBarraTitulo.Controls.Add(Me.imgConectarDLL)
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1200, 53)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("DaxlinePro-Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(655, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 52)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Visualizar los cambios de precio a fecha:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("DaxlinePro-Regular", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 52)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Buscar cambios de precios hasta fecha:"
        '
        'imgBuscar
        '
        Me.imgBuscar.Image = Global.KreaLabel.My.Resources.Resources.BUSCAR_ARTÍCULO1
        Me.imgBuscar.InitialImage = Global.KreaLabel.My.Resources.Resources.BUSCAR_ARTÍCULO1
        Me.imgBuscar.Location = New System.Drawing.Point(973, 9)
        Me.imgBuscar.Name = "imgBuscar"
        Me.imgBuscar.Size = New System.Drawing.Size(43, 32)
        Me.imgBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBuscar.TabIndex = 28
        Me.imgBuscar.TabStop = False
        '
        'txtFecha2
        '
        Me.txtFecha2.CalendarFont = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha2.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtFecha2.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtFecha2.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha2.Location = New System.Drawing.Point(835, 9)
        Me.txtFecha2.Name = "txtFecha2"
        Me.txtFecha2.Size = New System.Drawing.Size(132, 32)
        Me.txtFecha2.TabIndex = 27
        '
        'imgSalir
        '
        Me.imgSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgSalir.Image = Global.KreaLabel.My.Resources.Resources.BOTON_CERRAR
        Me.imgSalir.Location = New System.Drawing.Point(1048, -3)
        Me.imgSalir.Name = "imgSalir"
        Me.imgSalir.Size = New System.Drawing.Size(171, 45)
        Me.imgSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSalir.TabIndex = 25
        Me.imgSalir.TabStop = False
        '
        'txtFecha
        '
        Me.txtFecha.CalendarFont = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtFecha.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtFecha.Font = New System.Drawing.Font("DaxlinePro-Regular", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(187, 9)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(132, 32)
        Me.txtFecha.TabIndex = 11
        '
        'imgConectarDLL
        '
        Me.imgConectarDLL.Image = Global.KreaLabel.My.Resources.Resources.BOTON_CAMBIO_DE_PRECIO1
        Me.imgConectarDLL.InitialImage = Nothing
        Me.imgConectarDLL.Location = New System.Drawing.Point(334, 8)
        Me.imgConectarDLL.Name = "imgConectarDLL"
        Me.imgConectarDLL.Size = New System.Drawing.Size(155, 33)
        Me.imgConectarDLL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgConectarDLL.TabIndex = 8
        Me.imgConectarDLL.TabStop = False
        '
        'frm_ArticulosPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 571)
        Me.Controls.Add(Me.panelDatos)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_ArticulosPrecios"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Artículos: precios modificados"
        Me.panelDatos.ResumeLayout(False)
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        CType(Me.imgBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgConectarDLL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelDatos As Panel
    Friend WithEvents dgDetalle As DataGridView
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents txtFecha As DateTimePicker
    Friend WithEvents imgConectarDLL As PictureBox
    Friend WithEvents imgSalir As PictureBox
    Friend WithEvents txtFecha2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents imgBuscar As PictureBox
    Friend WithEvents Label2 As Label
End Class
