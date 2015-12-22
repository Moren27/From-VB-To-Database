<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewUserForm
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
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.userGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.userGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.searchText, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.searchButton, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.addButton, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.editButton, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.deleteButton, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.userGridView, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(663, 380)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'searchText
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.searchText, 3)
        Me.searchText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchText.Location = New System.Drawing.Point(3, 3)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(577, 20)
        Me.searchText.TabIndex = 1
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(586, 3)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(74, 23)
        Me.searchButton.TabIndex = 2
        Me.searchButton.Text = "Cari"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(426, 353)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(74, 23)
        Me.addButton.TabIndex = 4
        Me.addButton.Text = "Tambah"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.Location = New System.Drawing.Point(506, 353)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(74, 23)
        Me.editButton.TabIndex = 5
        Me.editButton.Text = "Ubah"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(586, 353)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(74, 23)
        Me.deleteButton.TabIndex = 6
        Me.deleteButton.Text = "Hapus"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'userGridView
        '
        Me.userGridView.AllowUserToAddRows = False
        Me.userGridView.AllowUserToDeleteRows = False
        Me.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.userGridView, 4)
        Me.userGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userGridView.Location = New System.Drawing.Point(3, 33)
        Me.userGridView.Name = "userGridView"
        Me.userGridView.ReadOnly = True
        Me.userGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.userGridView.Size = New System.Drawing.Size(657, 290)
        Me.userGridView.TabIndex = 3
        '
        'ViewUserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 380)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ViewUserForm"
        Me.Text = "ViewUserForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.userGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents searchText As System.Windows.Forms.TextBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents userGridView As System.Windows.Forms.DataGridView
End Class
