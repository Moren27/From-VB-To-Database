<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveUserForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.usernameText = New System.Windows.Forms.TextBox()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.placeText = New System.Windows.Forms.TextBox()
        Me.genderCombo = New System.Windows.Forms.ComboBox()
        Me.birthPicker = New System.Windows.Forms.DateTimePicker()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.idText, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.usernameText, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nameText, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.saveButton, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.closeButton, 3, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.birthPicker, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.placeText, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.genderCombo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.passwordText, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 12
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(606, 345)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'idText
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.idText, 3)
        Me.idText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.idText.Location = New System.Drawing.Point(103, 3)
        Me.idText.Name = "idText"
        Me.idText.ReadOnly = True
        Me.idText.Size = New System.Drawing.Size(500, 20)
        Me.idText.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tanggal Lahir"
        '
        'usernameText
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.usernameText, 3)
        Me.usernameText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.usernameText.Location = New System.Drawing.Point(103, 27)
        Me.usernameText.Name = "usernameText"
        Me.usernameText.Size = New System.Drawing.Size(500, 20)
        Me.usernameText.TabIndex = 7
        '
        'nameText
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.nameText, 3)
        Me.nameText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nameText.Location = New System.Drawing.Point(103, 51)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(500, 20)
        Me.nameText.TabIndex = 8
        '
        'placeText
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.placeText, 3)
        Me.placeText.Location = New System.Drawing.Point(103, 123)
        Me.placeText.Name = "placeText"
        Me.placeText.Size = New System.Drawing.Size(500, 20)
        Me.placeText.TabIndex = 9
        '
        'genderCombo
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.genderCombo, 3)
        Me.genderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.genderCombo.FormattingEnabled = True
        Me.genderCombo.Location = New System.Drawing.Point(103, 99)
        Me.genderCombo.Name = "genderCombo"
        Me.genderCombo.Size = New System.Drawing.Size(500, 21)
        Me.genderCombo.TabIndex = 10
        '
        'birthPicker
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.birthPicker, 3)
        Me.birthPicker.Location = New System.Drawing.Point(103, 147)
        Me.birthPicker.Name = "birthPicker"
        Me.birthPicker.Size = New System.Drawing.Size(500, 20)
        Me.birthPicker.TabIndex = 11
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(449, 267)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(74, 23)
        Me.saveButton.TabIndex = 12
        Me.saveButton.Text = "Simpan"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(529, 267)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(74, 23)
        Me.closeButton.TabIndex = 13
        Me.closeButton.Text = "Batal"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kata Sandi"
        '
        'passwordText
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.passwordText, 3)
        Me.passwordText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.passwordText.Location = New System.Drawing.Point(103, 75)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.Size = New System.Drawing.Size(500, 20)
        Me.passwordText.TabIndex = 15
        Me.passwordText.UseSystemPasswordChar = True
        '
        'SaveUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 345)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SaveUserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SaveUserForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents usernameText As System.Windows.Forms.TextBox
    Friend WithEvents nameText As System.Windows.Forms.TextBox
    Friend WithEvents placeText As System.Windows.Forms.TextBox
    Friend WithEvents genderCombo As System.Windows.Forms.ComboBox
    Friend WithEvents birthPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents passwordText As System.Windows.Forms.TextBox
End Class
