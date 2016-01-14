<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveTransaksiForm
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
        Me.namaText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.barangCombo = New System.Windows.Forms.ComboBox()
        Me.detailListBox = New System.Windows.Forms.ListBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.quantityNumeric = New System.Windows.Forms.NumericUpDown()
        Me.browseButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.quantityNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.idText, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.namaText, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.barangCombo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.detailListBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.addButton, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.quantityNumeric, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.browseButton, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.closeButton, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.saveButton, 3, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(453, 356)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaksi Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'idText
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.idText, 4)
        Me.idText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.idText.Location = New System.Drawing.Point(103, 3)
        Me.idText.Name = "idText"
        Me.idText.ReadOnly = True
        Me.idText.Size = New System.Drawing.Size(347, 20)
        Me.idText.TabIndex = 2
        '
        'namaText
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.namaText, 4)
        Me.namaText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.namaText.Location = New System.Drawing.Point(103, 27)
        Me.namaText.Name = "namaText"
        Me.namaText.Size = New System.Drawing.Size(347, 20)
        Me.namaText.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Barang"
        '
        'barangCombo
        '
        Me.barangCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.barangCombo.FormattingEnabled = True
        Me.barangCombo.Location = New System.Drawing.Point(103, 51)
        Me.barangCombo.Name = "barangCombo"
        Me.barangCombo.Size = New System.Drawing.Size(157, 21)
        Me.barangCombo.TabIndex = 16
        '
        'detailListBox
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.detailListBox, 4)
        Me.detailListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.detailListBox.FormattingEnabled = True
        Me.detailListBox.Location = New System.Drawing.Point(103, 84)
        Me.detailListBox.Name = "detailListBox"
        Me.detailListBox.Size = New System.Drawing.Size(347, 213)
        Me.detailListBox.TabIndex = 17
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(376, 51)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(74, 23)
        Me.addButton.TabIndex = 14
        Me.addButton.Text = "Tambah"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'quantityNumeric
        '
        Me.quantityNumeric.Location = New System.Drawing.Point(296, 51)
        Me.quantityNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.quantityNumeric.Name = "quantityNumeric"
        Me.quantityNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.quantityNumeric.Size = New System.Drawing.Size(74, 20)
        Me.quantityNumeric.TabIndex = 15
        Me.quantityNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.quantityNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'browseButton
        '
        Me.browseButton.Location = New System.Drawing.Point(266, 51)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(24, 23)
        Me.browseButton.TabIndex = 18
        Me.browseButton.Text = "..."
        Me.browseButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(376, 327)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(74, 26)
        Me.closeButton.TabIndex = 13
        Me.closeButton.Text = "Batal"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(296, 327)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(74, 26)
        Me.saveButton.TabIndex = 12
        Me.saveButton.Text = "Simpan"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'SaveTransaksiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 356)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SaveTransaksiForm"
        Me.Text = "SaveTransaksiForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.quantityNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idText As System.Windows.Forms.TextBox
    Friend WithEvents namaText As System.Windows.Forms.TextBox
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents quantityNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents barangCombo As System.Windows.Forms.ComboBox
    Friend WithEvents detailListBox As System.Windows.Forms.ListBox
    Friend WithEvents browseButton As System.Windows.Forms.Button
End Class
