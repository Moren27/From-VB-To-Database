Imports Dhanifudin.Database

Public Class MainForm

    Public Sub New()
        InitializeComponent()
        Init()
    End Sub

    Private Sub Init()
        Dim config As New MySqlConfig()
        config.Server = "localhost"
        config.Database = "example"
        config.User = "root"
        config.Password = "database"
        Configuration.Config = config
    End Sub

    Private Sub ShowLoginForm()
        LoginForm.MdiParent = Me
        LoginForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowLoginForm()
        Me.ShowMenu(False)
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If (Application.IsLogin()) Then
            Application.Logout()
            Me.ShowMenu(False)
        Else
            Me.ShowLoginForm()
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click

    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggunaToolStripMenuItem.Click
        ViewUserForm.MdiParent = Me
        ViewUserForm.Show()
    End Sub

    Private Sub BantuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BantuanToolStripMenuItem.Click

    End Sub

    Public Sub ShowMenu(show As Boolean)
        LoginToolStripMenuItem.Text = If(show, "Logout", "Login")
        MasterToolStripMenuItem.Visible = show
    End Sub

End Class
