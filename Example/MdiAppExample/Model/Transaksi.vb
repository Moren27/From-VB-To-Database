Imports System.ComponentModel

Public Class Transaksi

    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
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

    Private _detailList As BindingList(Of Detail)
    Public Property DetailList() As BindingList(Of Detail)
        Get
            Return _detailList
        End Get
        Set(ByVal value As BindingList(Of Detail))
            _detailList = value
        End Set
    End Property

    Public Sub AddDetail(detail As Detail)
        Me._detailList.Add(detail)
    End Sub

    Public Sub New()
        _detailList = New BindingList(Of Detail)
    End Sub

End Class
