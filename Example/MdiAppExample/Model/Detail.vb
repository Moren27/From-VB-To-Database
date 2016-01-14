Public Class Detail

    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Private _transaksi As Transaksi
    Public Property Transaksi() As Transaksi
        Get
            Return _transaksi
        End Get
        Set(ByVal value As Transaksi)
            _transaksi = value
        End Set
    End Property

    Private _barang As Barang
    Public Property Barang() As Barang
        Get
            Return _barang
        End Get
        Set(ByVal value As Barang)
            _barang = value
        End Set
    End Property

    Private _quantity As Integer
    Public Property Quantity() As Integer
        Get
            Return _quantity
        End Get
        Set(ByVal value As Integer)
            _quantity = value
        End Set
    End Property


    Public Sub New(transaksi As Transaksi, barang As Barang, quantity As Integer)
        Me._transaksi = transaksi
        Me._barang = barang
        Me._quantity = quantity
    End Sub


    Public Overrides Function ToString() As String
        Return String.Format("{0} - {1}", _barang.Nama, _quantity)
    End Function

End Class
