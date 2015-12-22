Imports Dhanifudin.Database

Public Class Form1

    Private userController As UserMySqlController

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _config As New MySqlConfig()
        _config.Server = "localhost"
        _config.Database = "library"
        _config.User = "root"
        _config.Password = "database"
        Configuration.Config = _config

        userController = New UserMySqlController()

        'Dim user As New User()
        'user.Id = "oke"
        'user.Name = "oke update"
        'user.Password = "oke"
        'userController.Insert(user)

        'userController.SelectSql = "select user_id,name from pengguna"
        'Dim dataTable As DataTable = userController.se
    End Sub
End Class
