Public Class MySqlDatabase

    Protected Shared _instance As MySqlDatabase = Nothing
    Public Shared Function Instance() As MySqlDatabase
        If _instance Is Nothing Then
            _instance = New MySqlDatabase()
        End If
        Return _instance
    End Function

    Private _connection As MySqlConnection

    Public ReadOnly Property Connection As MySqlConnection
        Get
            Return _connection
        End Get
    End Property

    Protected Sub New()
        Dim _config As Config = Configuration.Config
        _connection = New MySqlConnection(_config.ToConnectionString())
    End Sub

    Protected Overrides Sub Finalize()
        Me.Close()
        MyBase.Finalize()
    End Sub

    Public Sub Open()
        Try
            If _connection.State = ConnectionState.Closed Then
                _connection.Open()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub close()
        Try
            If Not _connection Is Nothing Then
                _connection.Close()
            End If
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function ExecuteNonQuery(sql As String) As Integer
        Dim _command As New MySqlCommand(sql)
        Return Me.ExecuteNonQuery(_command)
    End Function

    Public Function ExecuteNonQuery(command As MySqlCommand) As Integer
        Dim result As Integer = -1
        Dim transaction As MySqlTransaction = Nothing
        Try
            Me.Open()
            transaction = _connection.BeginTransaction()
            command.Connection = _connection
            command.Transaction = transaction
            result = command.ExecuteNonQuery()
            transaction.Commit()
        Catch ex As Exception
            If Not transaction Is Nothing Then
                transaction.Rollback()
            End If
            Throw
        Finally
            If Not command Is Nothing Then
                command.Dispose()
            End If
            If Not transaction Is Nothing Then
                transaction.Dispose()
            End If
        End Try
        Return result
    End Function

    Public Function ExecuteScalar(sql As String) As Object
        Dim result As Object = Nothing
        Dim command As MySqlCommand = Nothing
        Try
            Me.Open()
            command = New MySqlCommand(sql, _connection)
            result = command.ExecuteScalar()
        Catch ex As Exception
            Throw
        Finally
            If Not command Is Nothing Then
                command.Dispose()
            End If
        End Try
        Return Parse.Value(result)
    End Function

    Public Function Fill(sql As String) As DataTable
        Dim dataTable As New DataTable()
        Try
            Dim dataAdapter As New MySqlDataAdapter(sql, _connection)
            dataAdapter.Fill(dataTable)
        Catch ex As Exception
            Throw
        End Try
        Return dataTable
    End Function

End Class
