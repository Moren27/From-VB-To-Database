Imports System.ComponentModel

Public Class ViewBarangForm

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

    Private Sub ViewBarangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadGridView(Nothing)
        Me.HandleView()
    End Sub

    Private Sub LoadGridView(filter As String)
        Dim items As BindingList(Of Barang) = controller.Search(filter)
        userGridView.DataSource = items
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        If Me.Tag.Equals("Browse") Then
            _item = Nothing
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Else
            SaveBarangForm.Item = New Barang()
            SaveBarangForm.Tag = "Add"
            SaveBarangForm.ShowDialog()
            Me.LoadGridView(Nothing)
        End If
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim barang As Barang = TryCast(userGridView.CurrentRow.DataBoundItem, Barang)
        SaveBarangForm.Item = barang
        SaveBarangForm.Tag = "Edit"
        SaveBarangForm.ShowDialog()
        Me.LoadGridView(Nothing)
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        If Me.Tag.Equals("Browse") Then
            _item = TryCast(userGridView.CurrentRow.DataBoundItem, Barang)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Dim item As Barang = TryCast(userGridView.CurrentRow.DataBoundItem, Barang)
            If (MessageBox.Show(String.Format("Apakah anda yakin akan menghapus data: {0}", item.Nama), "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
                Dim success As Boolean = controller.Delete(item)
                If success Then
                    Dim filter As String = String.Format("username like '%{0}%' or nama like '%{1}%'", searchText.Text, searchText.Text)
                    LoadGridView(filter)
                End If
            End If
        End If
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        search()
    End Sub

    Private Sub searchText_KeyDown(sender As Object, e As KeyEventArgs) Handles searchText.KeyDown
        If e.KeyCode = Keys.Enter Then
            search()
        End If
    End Sub

    Private Sub search()
        Dim filter As String = String.Format("nama like '%{0}%'", searchText.Text)
        LoadGridView(filter)
    End Sub

    Private Sub HandleView()
        If Me.Tag.Equals("Browse") Then
            Me.addButton.Text = "Batal"
            Me.editButton.Visible = False
            Me.deleteButton.Text = "OK"
        Else
            Me.addButton.Text = "Tambah"
            Me.editButton.Visible = True
            Me.deleteButton.Text = "Hapus"
        End If
    End Sub
End Class