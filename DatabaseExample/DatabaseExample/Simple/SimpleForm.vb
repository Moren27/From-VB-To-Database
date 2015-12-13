Imports Dhanifudin.Database

Public Class SimpleForm

    Private database As MySqlDatabase

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim _config As New MySqlConfig()
        _config.Server = "localhost"
        _config.Database = "library"
        _config.User = "root"
        _config.Password = "database"
        Application.Config = _config
        database = MySqlDatabase.Instance()
    End Sub

    Private Sub SimpleMVC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As New User()
        user.Id = "paijo"
        user.Name = "paijo"
        user.Password = "rahasia"
        database.ExecuteNonQuery(String.Format("insert into user values('{0}', '{1}', '{2}')", user.Id, user.Name, user.Password))
    End Sub
End Class