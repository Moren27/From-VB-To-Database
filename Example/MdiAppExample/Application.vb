Public Class Application

    Private Shared _user As User
    Public Shared Property User() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            _user = value
        End Set
    End Property

    Public Shared Function IsLogin() As Boolean
        Return Not _user Is Nothing
    End Function

    Public Shared Sub Logout()
        _user = Nothing
    End Sub

End Class
