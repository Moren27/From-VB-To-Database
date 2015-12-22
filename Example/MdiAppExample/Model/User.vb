Public Class User

    Private _userId As String
    Public Property UserId() As String
        Get
            Return _userId
        End Get
        Set(ByVal value As String)
            _userId = value
        End Set
    End Property

    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Private _kataSandi As String
    Public Property KataSandi() As String
        Get
            Return _kataSandi
        End Get
        Set(ByVal value As String)
            _kataSandi = value
        End Set
    End Property


    Private _nama As String
    Public Property Nama() As String
        Get
            Return _nama
        End Get
        Set(ByVal value As String)
            _nama = value
        End Set
    End Property

    Private _jenisKelamin As String
    Public Property JenisKelamin() As String
        Get
            Return _jenisKelamin
        End Get
        Set(ByVal value As String)
            _jenisKelamin = value
        End Set
    End Property

    Private _tempatLahir As String
    Public Property TempatLahir() As String
        Get
            Return _tempatLahir
        End Get
        Set(ByVal value As String)
            _tempatLahir = value
        End Set
    End Property

    Private _tanggalLahir As Date
    Public Property TanggalLahir() As Date
        Get
            Return _tanggalLahir
        End Get
        Set(ByVal value As Date)
            _tanggalLahir = value
        End Set
    End Property

    Public Sub New()
        Me._tanggalLahir = Date.Now
    End Sub

End Class
