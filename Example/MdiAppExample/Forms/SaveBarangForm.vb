Imports Dhanifudin.Database
Imports System.ComponentModel

Public Class SaveBarangForm

    Private controller As New BarangController

    Private Shared _item As Barang
    Public Shared Property Item() As Barang
        Get
            Return _item
        End Get
        Set(ByVal value As Barang)
            _item = value
        End Set
    End Property

    Private Sub SaveBarangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _item.Id Is Nothing Then
            _item.Id = controller.NextId()
        End If
        Me.SetDataBindings()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim success As Boolean = False
        If (Me.Tag.Equals("Add")) Then
            success = controller.Insert(_item)
        Else
            success = controller.Update(_item)
        End If
        If success Then
            MessageBox.Show("Data berhasil disimpan")
            Me.Close()
        End If
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub SetDataBindings()
        idText.DataBindings.Clear()
        idText.DataBindings.Add("Text", _item, "Id")

        nameText.DataBindings.Clear()
        nameText.DataBindings.Add("Text", _item, "Nama")

    End Sub
End Class