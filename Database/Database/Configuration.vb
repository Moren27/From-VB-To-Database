Public Class Configuration

    Private Shared _config As Config
    Public Shared Property Config() As Config
        Get
            Return _config
        End Get
        Set(ByVal value As Config)
            _config = value
        End Set
    End Property

End Class
