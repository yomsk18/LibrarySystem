<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_SearchBook
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.VMpanel2 = New LibrarySystem.VMpanel()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.TITLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUTHOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlFilter = New LibrarySystem.VMpanel()
        Me.VMpanel3 = New LibrarySystem.VMpanel()
        Me.VmCalendar1 = New LibrarySystem.VergelControls.VMControls.VMCalendar()
        Me.txtFilter = New LibrarySystem.RJTextBox()
        Me.cbFilter = New LibrarySystem.VMComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.VMpanel4 = New LibrarySystem.VMpanel()
        Me.dtpDateTo = New LibrarySystem.VergelControls.VMControls.VMCalendar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filterBooks = New System.Windows.Forms.Label()
        Me.VMpanel1 = New LibrarySystem.VMpanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnBarrow = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.VMpanel2.SuspendLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter.SuspendLayout()
        Me.VMpanel3.SuspendLayout()
        Me.VMpanel4.SuspendLayout()
        Me.VMpanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VMpanel2
        '
        Me.VMpanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.VMpanel2.BorderColor = System.Drawing.Color.Gray
        Me.VMpanel2.BorderRadius = 25
        Me.VMpanel2.BorderSize = 0
        Me.VMpanel2.Controls.Add(Me.dgvBooks)
        Me.VMpanel2.Controls.Add(Me.pnlFilter)
        Me.VMpanel2.Controls.Add(Me.filterBooks)
        Me.VMpanel2.GradientColor1 = System.Drawing.Color.Empty
        Me.VMpanel2.GradientColor2 = System.Drawing.Color.Empty
        Me.VMpanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMpanel2.Location = New System.Drawing.Point(51, 150)
        Me.VMpanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.VMpanel2.Name = "VMpanel2"
        Me.VMpanel2.Opacity = 100
        Me.VMpanel2.Size = New System.Drawing.Size(1117, 487)
        Me.VMpanel2.TabIndex = 3
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.AllowUserToResizeColumns = False
        Me.dgvBooks.AllowUserToResizeRows = False
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TITLE, Me.AUTHOR, Me.CATEGORY, Me.ISBN, Me.STOCKS})
        Me.dgvBooks.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvBooks.Location = New System.Drawing.Point(36, 170)
        Me.dgvBooks.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBooks.RowHeadersWidth = 51
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(1033, 289)
        Me.dgvBooks.TabIndex = 2
        '
        'TITLE
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.TITLE.DefaultCellStyle = DataGridViewCellStyle2
        Me.TITLE.HeaderText = "TITLE"
        Me.TITLE.MinimumWidth = 6
        Me.TITLE.Name = "TITLE"
        Me.TITLE.ReadOnly = True
        '
        'AUTHOR
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.AUTHOR.DefaultCellStyle = DataGridViewCellStyle3
        Me.AUTHOR.HeaderText = "AUTHOR"
        Me.AUTHOR.MinimumWidth = 6
        Me.AUTHOR.Name = "AUTHOR"
        Me.AUTHOR.ReadOnly = True
        '
        'CATEGORY
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.CATEGORY.DefaultCellStyle = DataGridViewCellStyle4
        Me.CATEGORY.HeaderText = "CATEGORY"
        Me.CATEGORY.MinimumWidth = 6
        Me.CATEGORY.Name = "CATEGORY"
        Me.CATEGORY.ReadOnly = True
        '
        'ISBN
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.ISBN.DefaultCellStyle = DataGridViewCellStyle5
        Me.ISBN.HeaderText = "ISBN"
        Me.ISBN.MinimumWidth = 6
        Me.ISBN.Name = "ISBN"
        Me.ISBN.ReadOnly = True
        '
        'STOCKS
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.STOCKS.DefaultCellStyle = DataGridViewCellStyle6
        Me.STOCKS.HeaderText = "STOCKS"
        Me.STOCKS.MinimumWidth = 6
        Me.STOCKS.Name = "STOCKS"
        Me.STOCKS.ReadOnly = True
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlFilter.BorderColor = System.Drawing.Color.Gray
        Me.pnlFilter.BorderRadius = 20
        Me.pnlFilter.BorderSize = 0
        Me.pnlFilter.Controls.Add(Me.VMpanel3)
        Me.pnlFilter.Controls.Add(Me.txtFilter)
        Me.pnlFilter.Controls.Add(Me.cbFilter)
        Me.pnlFilter.Controls.Add(Me.Label1)
        Me.pnlFilter.Controls.Add(Me.btnSubmit)
        Me.pnlFilter.Controls.Add(Me.VMpanel4)
        Me.pnlFilter.Controls.Add(Me.Label5)
        Me.pnlFilter.Controls.Add(Me.Label2)
        Me.pnlFilter.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlFilter.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlFilter.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlFilter.Location = New System.Drawing.Point(36, 45)
        Me.pnlFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Opacity = 25
        Me.pnlFilter.Size = New System.Drawing.Size(1033, 107)
        Me.pnlFilter.TabIndex = 1
        '
        'VMpanel3
        '
        Me.VMpanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.VMpanel3.BorderColor = System.Drawing.Color.Gray
        Me.VMpanel3.BorderRadius = 10
        Me.VMpanel3.BorderSize = 0
        Me.VMpanel3.Controls.Add(Me.VmCalendar1)
        Me.VMpanel3.GradientColor1 = System.Drawing.Color.Empty
        Me.VMpanel3.GradientColor2 = System.Drawing.Color.Empty
        Me.VMpanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMpanel3.Location = New System.Drawing.Point(43, 43)
        Me.VMpanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.VMpanel3.Name = "VMpanel3"
        Me.VMpanel3.Opacity = 100
        Me.VMpanel3.Size = New System.Drawing.Size(242, 43)
        Me.VMpanel3.TabIndex = 12
        '
        'VmCalendar1
        '
        Me.VmCalendar1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.VmCalendar1.BorderSize = 0
        Me.VmCalendar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VmCalendar1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VmCalendar1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VmCalendar1.Location = New System.Drawing.Point(4, 0)
        Me.VmCalendar1.Margin = New System.Windows.Forms.Padding(4)
        Me.VmCalendar1.MinimumSize = New System.Drawing.Size(4, 35)
        Me.VmCalendar1.Name = "VmCalendar1"
        Me.VmCalendar1.Size = New System.Drawing.Size(238, 35)
        Me.VmCalendar1.SkinColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.VmCalendar1.TabIndex = 4
        Me.VmCalendar1.TextColor = System.Drawing.Color.Black
        '
        'txtFilter
        '
        Me.txtFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtFilter.BorderColor = System.Drawing.Color.Transparent
        Me.txtFilter.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.txtFilter.BorderRadius = 10
        Me.txtFilter.BorderSize = 2
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFilter.Location = New System.Drawing.Point(601, 44)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Multiline = False
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtFilter.PasswordChar = False
        Me.txtFilter.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtFilter.PlaceholderText = ""
        Me.txtFilter.Size = New System.Drawing.Size(231, 40)
        Me.txtFilter.TabIndex = 11
        Me.txtFilter.Texts = ""
        Me.txtFilter.UnderlinedStyle = False
        '
        'cbFilter
        '
        Me.cbFilter.AutoCompleteCustomSource.AddRange(New String() {"Title", "Author", "Category"})
        Me.cbFilter.BackColor = System.Drawing.Color.Transparent
        Me.cbFilter.BorderColor = System.Drawing.Color.Transparent
        Me.cbFilter.BorderSize = 0
        Me.cbFilter.DataSource = Nothing
        Me.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cbFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilter.ForeColor = System.Drawing.Color.Black
        Me.cbFilter.IconColor = System.Drawing.Color.Black
        Me.cbFilter.Items.AddRange(New Object() {"Title", "Author", "Cathegory"})
        Me.cbFilter.ListBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.cbFilter.ListTextColor = System.Drawing.Color.Black
        Me.cbFilter.Location = New System.Drawing.Point(687, 7)
        Me.cbFilter.MinimumSize = New System.Drawing.Size(150, 30)
        Me.cbFilter.Name = "cbFilter"
        Me.cbFilter.Size = New System.Drawing.Size(150, 35)
        Me.cbFilter.TabIndex = 9
        Me.cbFilter.Texts = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(601, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Filter By:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnSubmit.BorderColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BorderRadius = 15
        Me.btnSubmit.BorderSize = 0
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btnSubmit.Location = New System.Drawing.Point(881, 43)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(119, 38)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Enter"
        Me.btnSubmit.TextColor = System.Drawing.Color.BlanchedAlmond
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'VMpanel4
        '
        Me.VMpanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.VMpanel4.BorderColor = System.Drawing.Color.Gray
        Me.VMpanel4.BorderRadius = 10
        Me.VMpanel4.BorderSize = 0
        Me.VMpanel4.Controls.Add(Me.dtpDateTo)
        Me.VMpanel4.GradientColor1 = System.Drawing.Color.Empty
        Me.VMpanel4.GradientColor2 = System.Drawing.Color.Empty
        Me.VMpanel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMpanel4.Location = New System.Drawing.Point(331, 44)
        Me.VMpanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.VMpanel4.Name = "VMpanel4"
        Me.VMpanel4.Opacity = 100
        Me.VMpanel4.Size = New System.Drawing.Size(242, 43)
        Me.VMpanel4.TabIndex = 5
        '
        'dtpDateTo
        '
        Me.dtpDateTo.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtpDateTo.BorderSize = 0
        Me.dtpDateTo.Dock = System.Windows.Forms.DockStyle.Right
        Me.dtpDateTo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateTo.Location = New System.Drawing.Point(4, 0)
        Me.dtpDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDateTo.MinimumSize = New System.Drawing.Size(4, 35)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(238, 35)
        Me.dtpDateTo.SkinColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.dtpDateTo.TabIndex = 4
        Me.dtpDateTo.TextColor = System.Drawing.Color.Black
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(339, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Date To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(45, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date From:"
        '
        'filterBooks
        '
        Me.filterBooks.AutoSize = True
        Me.filterBooks.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterBooks.ForeColor = System.Drawing.Color.Black
        Me.filterBooks.Location = New System.Drawing.Point(29, 9)
        Me.filterBooks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.filterBooks.Name = "filterBooks"
        Me.filterBooks.Size = New System.Drawing.Size(142, 32)
        Me.filterBooks.TabIndex = 0
        Me.filterBooks.Text = "Filter Books"
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
        Me.VMpanel1.Location = New System.Drawing.Point(51, 21)
        Me.VMpanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.VMpanel1.Name = "VMpanel1"
        Me.VMpanel1.Opacity = 100
        Me.VMpanel1.Size = New System.Drawing.Size(1117, 106)
        Me.VMpanel1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(152, 60)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "BOOK BARROWING SYSTEM"
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
        'btnBarrow
        '
        Me.btnBarrow.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnBarrow.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnBarrow.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnBarrow.BorderRadius = 15
        Me.btnBarrow.BorderSize = 0
        Me.btnBarrow.FlatAppearance.BorderSize = 0
        Me.btnBarrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarrow.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarrow.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btnBarrow.Location = New System.Drawing.Point(1010, 655)
        Me.btnBarrow.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBarrow.Name = "btnBarrow"
        Me.btnBarrow.Size = New System.Drawing.Size(134, 54)
        Me.btnBarrow.TabIndex = 9
        Me.btnBarrow.Text = "Borrow"
        Me.btnBarrow.TextColor = System.Drawing.Color.BlanchedAlmond
        Me.btnBarrow.UseVisualStyleBackColor = False
        '
        'uc_SearchBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.VMpanel1)
        Me.Controls.Add(Me.btnBarrow)
        Me.Controls.Add(Me.VMpanel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "uc_SearchBook"
        Me.Size = New System.Drawing.Size(1226, 738)
        Me.VMpanel2.ResumeLayout(False)
        Me.VMpanel2.PerformLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.VMpanel3.ResumeLayout(False)
        Me.VMpanel4.ResumeLayout(False)
        Me.VMpanel1.ResumeLayout(False)
        Me.VMpanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VMpanel2 As VMpanel
    Friend WithEvents pnlFilter As VMpanel
    Friend WithEvents filterBooks As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmit As VergelControls.VMControls.VMButton
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents VMpanel1 As VMpanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnBarrow As VergelControls.VMControls.VMButton
    Friend WithEvents cbFilter As VMComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents VMpanel4 As VMpanel
    Friend WithEvents dtpDateTo As VergelControls.VMControls.VMCalendar
    Friend WithEvents txtFilter As RJTextBox
    Friend WithEvents VMpanel3 As VMpanel
    Friend WithEvents VmCalendar1 As VergelControls.VMControls.VMCalendar
    Friend WithEvents TITLE As DataGridViewTextBoxColumn
    Friend WithEvents AUTHOR As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORY As DataGridViewTextBoxColumn
    Friend WithEvents ISBN As DataGridViewTextBoxColumn
    Friend WithEvents STOCKS As DataGridViewTextBoxColumn
End Class
