Imports System.ComponentModel

Public MustInherit Class MySqlController(Of T)

    Protected _database As MySqlDatabase
    Protected _autoId As Boolean

    Public Sub New()
        Me.New(False)
    End Sub

    Public Sub New(autoId As Boolean)
        Me._database = MySqlDatabase.Instance()
        Me._autoId = autoId
    End Sub

    Private _selectSql As String
    Public Property SelectSql() As String
        Get
            Return _selectSql
        End Get
        Set(ByVal value As String)
            _selectSql = value
        End Set
    End Property

    Private _insertSql As String
    Public Property InsertSql() As String
        Get
            Return _insertSql
        End Get
        Set(ByVal value As String)
            _insertSql = value
        End Set
    End Property

    Private _updateSql As String
    Public Property UpdateSql() As String
        Get
            Return _updateSql
        End Get
        Set(ByVal value As String)
            _updateSql = value
        End Set
    End Property

    Private _deleteSql As String
    Public Property DeleteSql() As String
        Get
            Return _deleteSql
        End Get
        Set(ByVal value As String)
            _deleteSql = value
        End Set
    End Property

    Protected MustOverride Sub PopulateData(reader As MySqlDataReader, ByRef result As BindingList(Of T))

    Protected Overridable Function DefaultSelectSql() As String
        Return Nothing
    End Function

    Protected Overridable Function DefaultInsertSql(item As T) As String
        Return Nothing
    End Function
    Protected Overridable Function DefaultUpdateSql(item As T) As String
        Return Nothing
    End Function
    Protected Overridable Function DefaultDeleteSql(item As T) As String
        Return Nothing
    End Function

    Protected Overridable Sub InsertParameters(ByRef command As MySqlCommand, item As T)
    End Sub

    Protected Overridable Sub UpdateParameters(ByRef command As MySqlCommand, item As T)
    End Sub

    Protected Overridable Sub DeleteParameters(ByRef command As MySqlCommand, item As T)
    End Sub

    Public Function Search(filter As String) As BindingList(Of T)
        Dim _result As BindingList(Of T) = Nothing
        Dim _command As MySqlCommand = Nothing
        Dim _reader As MySqlDataReader = Nothing
        Try
            filter = If(filter Is Nothing, String.Empty, String.Format(" where {0}", filter))
            Dim sql As String = If(Me._selectSql Is Nothing, Me.DefaultSelectSql & filter, Me._selectSql & filter)
            _database.Open()
            _command = New MySqlCommand(sql, _database.Connection)
            _reader = _command.ExecuteReader()
            _result = New BindingList(Of T)
            Me.PopulateData(_reader, _result)
        Catch ex As Exception
            Throw
        Finally
            If Not _command Is Nothing Then
                _command.Dispose()
            End If
            If Not _reader Is Nothing Then
                _reader.Close()
            End If
        End Try
        Return _result
    End Function

    Public Function Insert(item As T) As Boolean
        Dim _sql As String = If(Me._insertSql Is Nothing, Me.DefaultInsertSql(item), Me._insertSql)
        Dim _command As New MySqlCommand(_sql)
        Me.InsertParameters(_command, item)
        Return _database.ExecuteNonQuery(_command) > -1
    End Function

    Public Function Update(item As T) As Boolean
        Dim _sql As String = If(Me._updateSql Is Nothing, Me.DefaultUpdateSql(item), Me._updateSql)
        Dim _command As New MySqlCommand(_sql)
        Me.UpdateParameters(_command, item)
        Return _database.ExecuteNonQuery(_command) > -1
    End Function

    Public Function Delete(item As T) As Boolean
        Dim _sql As String = If(Me._deleteSql Is Nothing, Me.DefaultDeleteSql(item), Me._deleteSql)
        Dim _command As New MySqlCommand(_sql)
        Me.DeleteParameters(_command, item)
        Return _database.ExecuteNonQuery(_command) > -1
    End Function

    Public Function Fill() As DataTable
        Dim _sql As String = If(Me._selectSql Is Nothing, Me.DefaultSelectSql(), Me._selectSql)
        Return _database.Fill(_sql)
    End Function

End Class
