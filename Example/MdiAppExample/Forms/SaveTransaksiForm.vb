Imports System.ComponentModel

Public Class SaveTransaksiForm

    Private controller As New TransaksiController()
    Private transaksi As New Transaksi()

    Private Sub SaveTransaksiForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetDataBindings()
        transaksi.Id = controller.NextId()
    End Sub

    Private Sub SetDataBindings()
        idText.DataBindings.Clear()
        idText.DataBindings.Add("Text", transaksi, "Id")

        namaText.DataBindings.Clear()
        namaText.DataBindings.Add("Text", transaksi, "Nama")

        Dim barangController As New BarangController
        Dim listBarang As BindingList(Of Barang) = barangController.Search(Nothing)
        barangCombo.DataBindings.Clear()
        barangCombo.DataSource = listBarang
        barangCombo.DisplayMember = "Nama"
        barangCombo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        barangCombo.AutoCompleteSource = AutoCompleteSource.ListItems

        detailListBox.DataBindings.Clear()
        detailListBox.DataSource = transaksi.DetailList

    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim success As Boolean = controller.Insert(transaksi)
        If success Then
            MessageBox.Show("Data berhasil disimpan")
            Me.Close()
        End If
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim barang As Barang = barangCombo.SelectedItem
        Dim quantity As Integer = quantityNumeric.Value
        Dim detail As New Detail(transaksi, barang, quantity)
        transaksi.AddDetail(detail)
    End Sub

    Private Sub browseButton_Click(sender As Object, e As EventArgs) Handles browseButton.Click
        ViewBarangForm.Tag = "Browse"
        ViewBarangForm.ShowDialog()
        If ViewBarangForm.DialogResult = Windows.Forms.DialogResult.OK Then
            barangCombo.SelectedItem = barangCombo.FindString(ViewBarangForm.Item.Nama)
        End If
    End Sub
End Class