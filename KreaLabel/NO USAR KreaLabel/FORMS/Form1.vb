Imports FirebirdSql.Data.FirebirdClient
Imports System.Text
Imports System.Net

Public Class Form1

    Dim con As FbConnection
    Dim cs As FbConnectionStringBuilder

    Public Sub New()

        InitializeComponent()

        cs = New FbConnectionStringBuilder
        cs.Database = "C:\database.fdb"
        cs.ServerType = FbServerType.Default
        cs.UserID = "SYSDBA"
        cs.Password = "password"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'con = New FbConnection(cs.ToString)
        'con.Open()

        'Dim sCmd As FbCommand
        'Dim sql As String
        'Dim ds As FbDataReader

        'sql = "SELECT something FROM TABLE"

        'sCmd = New FbCommand()
        'sCmd.Connection = con
        'sCmd.CommandText = sql
        'ds = sCmd.ExecuteReader

        'Dim str As New StringBuilder

        'While (ds.Read)

        '    MsgBox(ds.GetString(0))

        'End While

        'ds.Close()

        'End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myConnection As FbConnection = New FbConnection()
        myConnection.ConnectionString = "User=SYSDBA;Password=masterkey;Database=SampleDatabase.fdb;DataSource=localhost;Port=3050;Dialect=3;"
        myConnection.Open()
    End Sub
End Class