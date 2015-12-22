Public Class Parse

    Public Shared Function Value(obj As Object)
        Return If(IsDBNull(obj), Nothing, obj)
    End Function

End Class
