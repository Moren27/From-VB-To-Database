Public Class LoginForm

    Private mainForm As MainForm

    Private userController As New UserController()

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainForm = TryCast(Me.MdiParent, MainForm)
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Application.User = userController.Login(usernameText.Text, passwordText.Text)
        If (Not Application.User Is Nothing) Then
            mainForm.ShowMenu(True)
            Me.Close()
        Else
        End If
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

End Class