<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Conf
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.imgOracle = New System.Windows.Forms.PictureBox()
        Me.imgJet = New System.Windows.Forms.PictureBox()
        Me.imgFirebird = New System.Windows.Forms.PictureBox()
        Me.imgMySQL = New System.Windows.Forms.PictureBox()
        Me.imgPostgres = New System.Windows.Forms.PictureBox()
        Me.imgAccess = New System.Windows.Forms.PictureBox()
        Me.lblOracle = New System.Windows.Forms.Label()
        Me.lblJet = New System.Windows.Forms.Label()
        Me.lblFirebird = New System.Windows.Forms.Label()
        Me.lblMySQL = New System.Windows.Forms.Label()
        Me.lblPostgress = New System.Windows.Forms.Label()
        Me.lblAccess = New System.Windows.Forms.Label()
        Me.lblSQL_Server = New System.Windows.Forms.Label()
        Me.imgSQLServer = New System.Windows.Forms.PictureBox()
        Me.panelMenu.SuspendLayout()
        CType(Me.imgOracle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgJet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFirebird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgMySQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPostgres, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSQLServer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'panelForm
        '
        Me.panelForm.BackColor = System.Drawing.SystemColors.Control
        Me.panelForm.Location = New System.Drawing.Point(370, 2)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(944, 373)
        Me.panelForm.TabIndex = 1
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.SystemColors.Control
        Me.panelMenu.BackgroundImage = Global.KreaLabel.My.Resources.Resources.fondo_database
        Me.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelMenu.Controls.Add(Me.imgOracle)
        Me.panelMenu.Controls.Add(Me.imgJet)
        Me.panelMenu.Controls.Add(Me.imgFirebird)
        Me.panelMenu.Controls.Add(Me.imgMySQL)
        Me.panelMenu.Controls.Add(Me.imgPostgres)
        Me.panelMenu.Controls.Add(Me.imgAccess)
        Me.panelMenu.Controls.Add(Me.lblOracle)
        Me.panelMenu.Controls.Add(Me.lblJet)
        Me.panelMenu.Controls.Add(Me.lblFirebird)
        Me.panelMenu.Controls.Add(Me.lblMySQL)
        Me.panelMenu.Controls.Add(Me.lblPostgress)
        Me.panelMenu.Controls.Add(Me.lblAccess)
        Me.panelMenu.Controls.Add(Me.lblSQL_Server)
        Me.panelMenu.Controls.Add(Me.imgSQLServer)
        Me.panelMenu.Location = New System.Drawing.Point(1, 2)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(363, 373)
        Me.panelMenu.TabIndex = 0
        '
        'imgOracle
        '
        Me.imgOracle.BackColor = System.Drawing.Color.Transparent
        Me.imgOracle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgOracle.Image = Global.KreaLabel.My.Resources.Resources.producto2
        Me.imgOracle.Location = New System.Drawing.Point(316, 333)
        Me.imgOracle.Name = "imgOracle"
        Me.imgOracle.Size = New System.Drawing.Size(33, 30)
        Me.imgOracle.TabIndex = 14
        Me.imgOracle.TabStop = False
        '
        'imgJet
        '
        Me.imgJet.BackColor = System.Drawing.Color.Transparent
        Me.imgJet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgJet.Image = Global.KreaLabel.My.Resources.Resources.producto2
        Me.imgJet.Location = New System.Drawing.Point(316, 279)
        Me.imgJet.Name = "imgJet"
        Me.imgJet.Size = New System.Drawing.Size(33, 30)
        Me.imgJet.TabIndex = 13
        Me.imgJet.TabStop = False
        '
        'imgFirebird
        '
        Me.imgFirebird.BackColor = System.Drawing.Color.Transparent
        Me.imgFirebird.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgFirebird.Image = Global.KreaLabel.My.Resources.Resources.producto2
        Me.imgFirebird.Location = New System.Drawing.Point(316, 225)
        Me.imgFirebird.Name = "imgFirebird"
        Me.imgFirebird.Size = New System.Drawing.Size(33, 30)
        Me.imgFirebird.TabIndex = 12
        Me.imgFirebird.TabStop = False
        '
        'imgMySQL
        '
        Me.imgMySQL.BackColor = System.Drawing.Color.Transparent
        Me.imgMySQL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgMySQL.Image = Global.KreaLabel.My.Resources.Resources.producto2
        Me.imgMySQL.Location = New System.Drawing.Point(316, 172)
        Me.imgMySQL.Name = "imgMySQL"
        Me.imgMySQL.Size = New System.Drawing.Size(33, 30)
        Me.imgMySQL.TabIndex = 11
        Me.imgMySQL.TabStop = False
        '
        'imgPostgres
        '
        Me.imgPostgres.BackColor = System.Drawing.Color.Transparent
        Me.imgPostgres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgPostgres.Image = Global.KreaLabel.My.Resources.Resources.producto2
        Me.imgPostgres.Location = New System.Drawing.Point(316, 119)
        Me.imgPostgres.Name = "imgPostgres"
        Me.imgPostgres.Size = New System.Drawing.Size(33, 30)
        Me.imgPostgres.TabIndex = 10
        Me.imgPostgres.TabStop = False
        '
        'imgAccess
        '
        Me.imgAccess.BackColor = System.Drawing.Color.Transparent
        Me.imgAccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgAccess.Image = Global.KreaLabel.My.Resources.Resources.producto2
        Me.imgAccess.Location = New System.Drawing.Point(316, 65)
        Me.imgAccess.Name = "imgAccess"
        Me.imgAccess.Size = New System.Drawing.Size(33, 30)
        Me.imgAccess.TabIndex = 9
        Me.imgAccess.TabStop = False
        '
        'lblOracle
        '
        Me.lblOracle.BackColor = System.Drawing.Color.Transparent
        Me.lblOracle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOracle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblOracle.Location = New System.Drawing.Point(45, 327)
        Me.lblOracle.Name = "lblOracle"
        Me.lblOracle.Size = New System.Drawing.Size(273, 34)
        Me.lblOracle.TabIndex = 8
        '
        'lblJet
        '
        Me.lblJet.BackColor = System.Drawing.Color.Transparent
        Me.lblJet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblJet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblJet.Location = New System.Drawing.Point(45, 274)
        Me.lblJet.Name = "lblJet"
        Me.lblJet.Size = New System.Drawing.Size(273, 34)
        Me.lblJet.TabIndex = 7
        '
        'lblFirebird
        '
        Me.lblFirebird.BackColor = System.Drawing.Color.Transparent
        Me.lblFirebird.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFirebird.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFirebird.Location = New System.Drawing.Point(45, 221)
        Me.lblFirebird.Name = "lblFirebird"
        Me.lblFirebird.Size = New System.Drawing.Size(273, 34)
        Me.lblFirebird.TabIndex = 6
        '
        'lblMySQL
        '
        Me.lblMySQL.BackColor = System.Drawing.Color.Transparent
        Me.lblMySQL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMySQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMySQL.Location = New System.Drawing.Point(45, 167)
        Me.lblMySQL.Name = "lblMySQL"
        Me.lblMySQL.Size = New System.Drawing.Size(273, 34)
        Me.lblMySQL.TabIndex = 5
        '
        'lblPostgress
        '
        Me.lblPostgress.BackColor = System.Drawing.Color.Transparent
        Me.lblPostgress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPostgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPostgress.Location = New System.Drawing.Point(41, 114)
        Me.lblPostgress.Name = "lblPostgress"
        Me.lblPostgress.Size = New System.Drawing.Size(273, 34)
        Me.lblPostgress.TabIndex = 4
        '
        'lblAccess
        '
        Me.lblAccess.BackColor = System.Drawing.Color.Transparent
        Me.lblAccess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAccess.Location = New System.Drawing.Point(41, 60)
        Me.lblAccess.Name = "lblAccess"
        Me.lblAccess.Size = New System.Drawing.Size(273, 34)
        Me.lblAccess.TabIndex = 3
        '
        'lblSQL_Server
        '
        Me.lblSQL_Server.BackColor = System.Drawing.Color.Transparent
        Me.lblSQL_Server.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSQL_Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSQL_Server.Location = New System.Drawing.Point(41, 7)
        Me.lblSQL_Server.Name = "lblSQL_Server"
        Me.lblSQL_Server.Size = New System.Drawing.Size(273, 34)
        Me.lblSQL_Server.TabIndex = 2
        '
        'imgSQLServer
        '
        Me.imgSQLServer.BackColor = System.Drawing.Color.Transparent
        Me.imgSQLServer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgSQLServer.Image = Global.KreaLabel.My.Resources.Resources.producto2
        Me.imgSQLServer.Location = New System.Drawing.Point(316, 11)
        Me.imgSQLServer.Name = "imgSQLServer"
        Me.imgSQLServer.Size = New System.Drawing.Size(33, 30)
        Me.imgSQLServer.TabIndex = 1
        Me.imgSQLServer.TabStop = False
        '
        'frm_Conf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1314, 378)
        Me.Controls.Add(Me.panelForm)
        Me.Controls.Add(Me.panelMenu)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Conf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de Base de datos"
        Me.panelMenu.ResumeLayout(False)
        CType(Me.imgOracle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgJet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFirebird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgMySQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPostgres, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSQLServer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents panelMenu As Windows.Forms.Panel
    Friend WithEvents panelForm As Windows.Forms.Panel
    Friend WithEvents imgSQLServer As Windows.Forms.PictureBox
    Friend WithEvents lblSQL_Server As Windows.Forms.Label
    Friend WithEvents imgOracle As Windows.Forms.PictureBox
    Friend WithEvents imgJet As Windows.Forms.PictureBox
    Friend WithEvents imgFirebird As Windows.Forms.PictureBox
    Friend WithEvents imgMySQL As Windows.Forms.PictureBox
    Friend WithEvents imgPostgres As Windows.Forms.PictureBox
    Friend WithEvents imgAccess As Windows.Forms.PictureBox
    Friend WithEvents lblOracle As Windows.Forms.Label
    Friend WithEvents lblJet As Windows.Forms.Label
    Friend WithEvents lblFirebird As Windows.Forms.Label
    Friend WithEvents lblMySQL As Windows.Forms.Label
    Friend WithEvents lblPostgress As Windows.Forms.Label
    Friend WithEvents lblAccess As Windows.Forms.Label
End Class
