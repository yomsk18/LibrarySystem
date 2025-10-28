<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_Library
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VMpanel2 = New LibrarySystem.VMpanel()
        Me.dgvBooksRented = New System.Windows.Forms.DataGridView()
        Me.TITLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTHOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtAuthor = New LibrarySystem.RJTextBox()
        Me.VMpanel1 = New LibrarySystem.VMpanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.VMpanel2.SuspendLayout()
        CType(Me.dgvBooksRented, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VMpanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(103, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LIBRARY"
        '
        'VMpanel2
        '
        Me.VMpanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.VMpanel2.BorderColor = System.Drawing.Color.Gray
        Me.VMpanel2.BorderRadius = 25
        Me.VMpanel2.BorderSize = 0
        Me.VMpanel2.Controls.Add(Me.dgvBooksRented)
        Me.VMpanel2.GradientColor1 = System.Drawing.Color.Empty
        Me.VMpanel2.GradientColor2 = System.Drawing.Color.Empty
        Me.VMpanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMpanel2.Location = New System.Drawing.Point(55, 205)
        Me.VMpanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.VMpanel2.Name = "VMpanel2"
        Me.VMpanel2.Opacity = 100
        Me.VMpanel2.Size = New System.Drawing.Size(1117, 487)
        Me.VMpanel2.TabIndex = 15
        '
        'dgvBooksRented
        '
        Me.dgvBooksRented.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooksRented.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.dgvBooksRented.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBooksRented.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBooksRented.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooksRented.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBooksRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooksRented.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TITLE, Me.AUTHOR, Me.CATEGORY, Me.ISBN, Me.STOCKS})
        Me.dgvBooksRented.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvBooksRented.Location = New System.Drawing.Point(40, 21)
        Me.dgvBooksRented.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBooksRented.MultiSelect = False
        Me.dgvBooksRented.Name = "dgvBooksRented"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooksRented.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBooksRented.RowHeadersWidth = 51
        Me.dgvBooksRented.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooksRented.Size = New System.Drawing.Size(1033, 433)
        Me.dgvBooksRented.TabIndex = 2
        '
        'TITLE
        '
        Me.TITLE.HeaderText = "TITLE"
        Me.TITLE.MinimumWidth = 6
        Me.TITLE.Name = "TITLE"
        '
        'AUTHOR
        '
        Me.AUTHOR.HeaderText = "AUTHOR"
        Me.AUTHOR.MinimumWidth = 6
        Me.AUTHOR.Name = "AUTHOR"
        '
        'CATEGORY
        '
        Me.CATEGORY.HeaderText = "CATEGORY"
        Me.CATEGORY.MinimumWidth = 6
        Me.CATEGORY.Name = "CATEGORY"
        '
        'ISBN
        '
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.MinimumWidth = 6
        Me.ISBN.Name = "ISBN"
        '
        'STOCKS
        '
        Me.STOCKS.HeaderText = "STOCKS"
        Me.STOCKS.MinimumWidth = 6
        Me.STOCKS.Name = "STOCKS"
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.Silver
        Me.txtAuthor.BorderColor = System.Drawing.Color.Transparent
        Me.txtAuthor.BorderFocusColor = System.Drawing.Color.Green
        Me.txtAuthor.BorderRadius = 10
        Me.txtAuthor.BorderSize = 2
        Me.txtAuthor.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.ForeColor = System.Drawing.Color.DimGray
        Me.txtAuthor.Location = New System.Drawing.Point(923, 154)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAuthor.Multiline = False
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Padding = New System.Windows.Forms.Padding(13, 9, 13, 9)
        Me.txtAuthor.PasswordChar = False
        Me.txtAuthor.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtAuthor.PlaceholderText = "SEARCH TITLE"
        Me.txtAuthor.Size = New System.Drawing.Size(220, 42)
        Me.txtAuthor.TabIndex = 14
        Me.txtAuthor.Texts = ""
        Me.txtAuthor.UnderlinedStyle = False
        '
        'VMpanel1
        '
        Me.VMpanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.VMpanel1.BorderColor = System.Drawing.Color.Gray
        Me.VMpanel1.BorderRadius = 25
        Me.VMpanel1.BorderSize = 0
        Me.VMpanel1.Controls.Add(Me.Label4)
        Me.VMpanel1.Controls.Add(Me.Label3)
        Me.VMpanel1.Controls.Add(Me.Panel4)
        Me.VMpanel1.GradientColor1 = System.Drawing.Color.Empty
        Me.VMpanel1.GradientColor2 = System.Drawing.Color.Empty
        Me.VMpanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMpanel1.Location = New System.Drawing.Point(55, 26)
        Me.VMpanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.VMpanel1.Name = "VMpanel1"
        Me.VMpanel1.Opacity = 100
        Me.VMpanel1.Size = New System.Drawing.Size(1117, 106)
        Me.VMpanel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(152, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "BOOK BORROWING SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(153, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 41)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LIBRARY LEDGER"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.logo
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(19, 7)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(127, 89)
        Me.Panel4.TabIndex = 1
        '
        'uc_Library
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.VMpanel2)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VMpanel1)
        Me.Name = "uc_Library"
        Me.Size = New System.Drawing.Size(1226, 738)
        Me.VMpanel2.ResumeLayout(False)
        CType(Me.dgvBooksRented, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VMpanel1.ResumeLayout(False)
        Me.VMpanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents VMpanel1 As VMpanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAuthor As RJTextBox
    Friend WithEvents VMpanel2 As VMpanel
    Friend WithEvents dgvBooksRented As DataGridView
    Friend WithEvents TITLE As DataGridViewTextBoxColumn
    Friend WithEvents AUTHOR As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORY As DataGridViewTextBoxColumn
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents STOCKS As DataGridViewTextBoxColumn
End Class
