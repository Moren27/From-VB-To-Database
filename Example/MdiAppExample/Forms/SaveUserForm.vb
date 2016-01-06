Imports Dhanifudin.Database
Imports System.ComponentModel

Public Class SaveUserForm

    Private userController As New UserController

    Private Shared _user As User
    Public Shared Property User() As User
        Get
            Return _user
        End Get
        Set(ByVal value As User)
            _user = value
        End Set
    End Property

    Private Sub SaveUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _user.UserId Is Nothing Then
            _user.UserId = userController.NextId()
        End If
        Me.SetDataBindings()
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim success As Boolean = False
        If (Me.Tag.Equals("Add")) Then
            success = userController.Insert(_user)
        Else
            success = userController.Update(_user)
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
        Dim genders As New BindingList(Of String)
        genders.Add("-")
        genders.Add("L")
        genders.Add("P")

        idText.DataBindings.Clear()
        idText.DataBindings.Add("Text", _user, "UserId")

        usernameText.DataBindings.Clear()
        usernameText.DataBindings.Add("Text", _user, "Username")

        nameText.DataBindings.Clear()
        nameText.DataBindings.Add("Text", _user, "Nama")

        passwordText.DataBindings.Clear()
        passwordText.DataBindings.Add("Text", _user, "KataSandi")

        genderCombo.DataSource = genders
        genderCombo.DataBindings.Clear()
        genderCombo.DataBindings.Add("SelectedItem", _user, "JenisKelamin", True, DataSourceUpdateMode.OnPropertyChanged)

        placeText.DataBindings.Clear()
        placeText.DataBindings.Add("Text", _user, "TempatLahir")

        birthPicker.DataBindings.Clear()
        birthPicker.DataBindings.Add("Value", _user, "TanggalLahir")

    End Sub
End Class