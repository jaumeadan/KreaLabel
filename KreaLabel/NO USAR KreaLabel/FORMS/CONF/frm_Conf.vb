Public Class frm_Conf

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

    End Sub

    Private Sub frm_Conf_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Ocultar_Imagenes()
        Seleccionar_Img_DB()

    End Sub

    Sub Ocultar_Imagenes()

        imgAccess.Visible = False
        imgFirebird.Visible = False
        imgJet.Visible = False
        imgMySQL.Visible = False
        imgOracle.Visible = False
        imgPostgres.Visible = False
        imgSQLServer.Visible = False

    End Sub

    Sub Seleccionar_Img_DB()

        Select Case My.Settings.Conexion
            Case "Microsoft SQL Server"
                imgSQLServer.Visible = True
            Case "Microsoft Jet"
                imgJet.Visible = True
            Case "Postgres"
                imgPostgres.Visible = True
            Case "Oracle"
                imgOracle.Visible = True
            Case "My SQL"
                imgMySQL.Visible = True
            Case "Firebird"
                imgFirebird.Visible = True
            Case "Microsoft Access"
                imgAccess.Visible = True
        End Select

    End Sub

    Private Sub lblSQL_Server_Click(sender As Object, e As EventArgs) Handles lblSQL_Server.Click
        Ocultar_Imagenes()
        imgSQLServer.Visible = True
        AbrirFormPanel(New frm_SQLServer)
    End Sub

    Private Sub lblAccess_Click(sender As Object, e As EventArgs) Handles lblAccess.Click
        Ocultar_Imagenes()
        imgAccess.Visible = True
        If Me.panelForm.Controls.Count > 0 Then
            Me.panelForm.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub lblPostgress_Click(sender As Object, e As EventArgs) Handles lblPostgress.Click
        Ocultar_Imagenes()
        imgPostgres.Visible = True
        If Me.panelForm.Controls.Count > 0 Then
            Me.panelForm.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub lblMySQL_Click(sender As Object, e As EventArgs) Handles lblMySQL.Click
        Ocultar_Imagenes()
        imgMySQL.Visible = True
        If Me.panelForm.Controls.Count > 0 Then
            Me.panelForm.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub lblFirebird_Click(sender As Object, e As EventArgs) Handles lblFirebird.Click
        Ocultar_Imagenes()
        imgFirebird.Visible = True
        If Me.panelForm.Controls.Count > 0 Then
            Me.panelForm.Controls.RemoveAt(0)
        End If
        AbrirFormPanel(New frm_Firebird)
    End Sub

    Private Sub lblJet_Click(sender As Object, e As EventArgs) Handles lblJet.Click
        Ocultar_Imagenes()
        imgJet.Visible = True
        AbrirFormPanel(New frm_Access)
    End Sub

    Private Sub lblOracle_Click(sender As Object, e As EventArgs) Handles lblOracle.Click
        Ocultar_Imagenes()
        imgOracle.Visible = True
        If Me.panelForm.Controls.Count > 0 Then
            Me.panelForm.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub AbrirFormPanel(ByVal FormHijo As Object)

        If Me.panelForm.Controls.Count > 0 Then
            Me.panelForm.Controls.RemoveAt(0)
        End If

        Dim fh As Windows.Forms.Form = TryCast(FormHijo, Windows.Forms.Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'fh.Dock = Windows.Forms.DockStyle.Fill
        Me.panelForm.Controls.Add(fh)
        Me.panelForm.Tag = fh
        fh.Show()

    End Sub

End Class