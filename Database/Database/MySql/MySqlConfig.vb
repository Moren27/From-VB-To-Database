Imports System.Text

Public Class MySqlConfig
    Inherits Config

    Private _server As String
    Public Property Server() As String
        Get
            Return _server
        End Get
        Set(ByVal value As String)
            _server = value
        End Set
    End Property

    Private _database As String
    Public Property Database() As String
        Get
            Return _database
        End Get
        Set(ByVal value As String)
            _database = value
        End Set
    End Property

    Private _user As String
    Public Property User() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property

    Private _password As String
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Public Overrides Function ToConnectionString() As String
        Dim connectionString As New StringBuilder()
        connectionString.Append(String.Format("Server={0};", _server))
        connectionString.Append(String.Format("Database={0};", _database))
        connectionString.Append(String.Format("Uid={0};", _user))
        connectionString.Append(String.Format("Password={0};", _password))
        Return connectionString.ToString()
    End Function

End Class
