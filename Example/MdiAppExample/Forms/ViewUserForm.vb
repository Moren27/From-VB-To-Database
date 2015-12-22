Imports System.ComponentModel

Public Class ViewUserForm

    Private userController As New UserController

    Private Sub ViewUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadGridView(Nothing)
    End Sub

    Private Sub LoadGridView(filter As String)
        Dim items As BindingList(Of User) = userController.Search(filter)
        userGridView.DataSource = items
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        SaveUserForm.User = New User()
        SaveUserForm.Tag = "Add"
        SaveUserForm.ShowDialog()
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim user As User = TryCast(userGridView.CurrentRow.DataBoundItem, User)
        SaveUserForm.User = user
        SaveUserForm.Tag = "Edit"
        SaveUserForm.ShowDialog()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim user As User = TryCast(userGridView.CurrentRow.DataBoundItem, User)
        If (MessageBox.Show(String.Format("Apakah anda yakin akan menghapus data: {0}", user.Nama), "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            Dim success As Boolean = userController.Delete(user)
            If success Then
                Dim filter As String = String.Format("username like '%{0}%' or nama like '%{1}%'", searchText.Text, searchText.Text)
                LoadGridView(filter)
            End If
        End If
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim filter As String = String.Format("username like '%{0}%' or nama like '%{1}%'", searchText.Text, searchText.Text)
        LoadGridView(filter)
    End Sub
End Class