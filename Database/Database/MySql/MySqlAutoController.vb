Public MustInherit Class MySqlAutoController(Of T)
    Inherits MySqlController(Of T)

    Protected MustOverride Function GetTableName() As String

    Protected MustOverride Function GetPrimaryKey() As String

    Protected Overridable Function GetPrefixId() As String
        Return Me.GetType().Name.Substring(0, 1)
    End Function

    Protected MustOverride Function LengthId() As Integer

    Public Function NextId() As String
        Dim prefix As String = Me.GetPrefixId()
        Dim sql As String = String.Format("select cast(substring({0}, {1}) as unsigned) from {2} order by {3} desc limit 1", Me.GetPrimaryKey(), prefix.Length + 1, Me.GetTableName(), Me.GetPrimaryKey())
        Dim count = _database.ExecuteScalar(sql)
        count = If(count > 0, count + 1, 1)
        Return prefix & count.ToString().PadLeft(Me.LengthId - prefix.Length, "0")
    End Function

End Class
