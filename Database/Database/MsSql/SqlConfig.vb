Imports System.Text

Public Class SqlConfig
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

    Private _trustedConnection As Boolean
    Public Property TrustedConnection() As Boolean
        Get
            Return _trustedConnection
        End Get
        Set(ByVal value As Boolean)
            _trustedConnection = value
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

    Public Sub New()
        Me._trustedConnection = False
    End Sub

    Public Overrides Function ToConnectionString() As String
        Dim connectionString As New StringBuilder()
        connectionString.Append(String.Format("Server={0};", _server))
        connectionString.Append(String.Format("Database={0};", _database))
        If _trustedConnection Then
            connectionString.Append(String.Format("Trusted_Connection={0};", _trustedConnection.ToString()))
        Else
            connectionString.Append(String.Format("User Id={0};", _user))
            connectionString.Append(String.Format("Password={0};", _password))
        End If
        Return connectionString.ToString()
    End Function
End Class
