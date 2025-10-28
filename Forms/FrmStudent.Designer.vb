<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlMainContent = New LibrarySystem.VMpanel()
        Me.pnlAccount = New LibrarySystem.VMpanel()
        Me.pbAccount = New System.Windows.Forms.PictureBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.pnlFines = New LibrarySystem.VMpanel()
        Me.pbFines = New System.Windows.Forms.PictureBox()
        Me.lblFines = New System.Windows.Forms.Label()
        Me.pnlLibrary = New LibrarySystem.VMpanel()
        Me.pbLibrary = New System.Windows.Forms.PictureBox()
        Me.lblLibrary = New System.Windows.Forms.Label()
        Me.pnlSearch = New LibrarySystem.VMpanel()
        Me.lblSearchBooks = New System.Windows.Forms.Label()
        Me.pbSearch = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.pnlAccount.SuspendLayout()
        CType(Me.pbAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFines.SuspendLayout()
        CType(Me.pbFines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLibrary.SuspendLayout()
        CType(Me.pbLibrary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        CType(Me.pbSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnlAccount)
        Me.Panel1.Controls.Add(Me.pnlFines)
        Me.Panel1.Controls.Add(Me.pnlLibrary)
        Me.Panel1.Controls.Add(Me.pnlSearch)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 738)
        Me.Panel1.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(197, 84)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(99, 37)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Vergel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(57, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome,"
        '
        'pnlMainContent
        '
        Me.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlMainContent.BorderColor = System.Drawing.Color.Gray
        Me.pnlMainContent.BorderRadius = 0
        Me.pnlMainContent.BorderSize = 0
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlMainContent.GradientColor1 = System.Drawing.Color.Empty
        Me.pnlMainContent.GradientColor2 = System.Drawing.Color.Empty
        Me.pnlMainContent.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlMainContent.Location = New System.Drawing.Point(413, 0)
        Me.pnlMainContent.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Opacity = 100
        Me.pnlMainContent.Size = New System.Drawing.Size(1208, 738)
        Me.pnlMainContent.TabIndex = 1
        '
        'pnlAccount
        '
        Me.pnlAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.pnlAccount.BorderColor = System.Drawing.Color.Gray
        Me.pnlAccount.BorderRadius = 25
        Me.pnlAccount.BorderSize = 0
        Me.pnlAccount.Controls.Add(Me.pbAccount)
        Me.pnlAccount.Controls.Add(Me.lblAccount)
        Me.pnlAccount.GradientColor1 = System.Drawing.Color.Empty
        Me.pnlAccount.GradientColor2 = System.Drawing.Color.Empty
        Me.pnlAccount.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlAccount.Location = New System.Drawing.Point(20, 537)
        Me.pnlAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlAccount.Name = "pnlAccount"
        Me.pnlAccount.Opacity = 100
        Me.pnlAccount.Size = New System.Drawing.Size(315, 94)
        Me.pnlAccount.TabIndex = 10
        '
        'pbAccount
        '
        Me.pbAccount.Image = Global.LibrarySystem.My.Resources.Resources.account
        Me.pbAccount.Location = New System.Drawing.Point(24, 17)
        Me.pbAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.pbAccount.Name = "pbAccount"
        Me.pbAccount.Size = New System.Drawing.Size(77, 60)
        Me.pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAccount.TabIndex = 8
        Me.pbAccount.TabStop = False
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.ForeColor = System.Drawing.Color.Black
        Me.lblAccount.Location = New System.Drawing.Point(125, 30)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(121, 38)
        Me.lblAccount.TabIndex = 3
        Me.lblAccount.Text = "Account"
        '
        'pnlFines
        '
        Me.pnlFines.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.pnlFines.BorderColor = System.Drawing.Color.Gray
        Me.pnlFines.BorderRadius = 25
        Me.pnlFines.BorderSize = 0
        Me.pnlFines.Controls.Add(Me.pbFines)
        Me.pnlFines.Controls.Add(Me.lblFines)
        Me.pnlFines.GradientColor1 = System.Drawing.Color.Empty
        Me.pnlFines.GradientColor2 = System.Drawing.Color.Empty
        Me.pnlFines.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlFines.Location = New System.Drawing.Point(20, 423)
        Me.pnlFines.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlFines.Name = "pnlFines"
        Me.pnlFines.Opacity = 100
        Me.pnlFines.Size = New System.Drawing.Size(315, 94)
        Me.pnlFines.TabIndex = 9
        '
        'pbFines
        '
        Me.pbFines.Image = Global.LibrarySystem.My.Resources.Resources.peso
        Me.pbFines.Location = New System.Drawing.Point(24, 17)
        Me.pbFines.Margin = New System.Windows.Forms.Padding(4)
        Me.pbFines.Name = "pbFines"
        Me.pbFines.Size = New System.Drawing.Size(77, 60)
        Me.pbFines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFines.TabIndex = 8
        Me.pbFines.TabStop = False
        '
        'lblFines
        '
        Me.lblFines.AutoSize = True
        Me.lblFines.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFines.ForeColor = System.Drawing.Color.Black
        Me.lblFines.Location = New System.Drawing.Point(125, 30)
        Me.lblFines.Name = "lblFines"
        Me.lblFines.Size = New System.Drawing.Size(150, 38)
        Me.lblFines.TabIndex = 3
        Me.lblFines.Text = "View Fines"
        '
        'pnlLibrary
        '
        Me.pnlLibrary.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.pnlLibrary.BorderColor = System.Drawing.Color.Gray
        Me.pnlLibrary.BorderRadius = 25
        Me.pnlLibrary.BorderSize = 0
        Me.pnlLibrary.Controls.Add(Me.pbLibrary)
        Me.pnlLibrary.Controls.Add(Me.lblLibrary)
        Me.pnlLibrary.GradientColor1 = System.Drawing.Color.Empty
        Me.pnlLibrary.GradientColor2 = System.Drawing.Color.Empty
        Me.pnlLibrary.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlLibrary.Location = New System.Drawing.Point(20, 311)
        Me.pnlLibrary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLibrary.Name = "pnlLibrary"
        Me.pnlLibrary.Opacity = 100
        Me.pnlLibrary.Size = New System.Drawing.Size(315, 94)
        Me.pnlLibrary.TabIndex = 7
        '
        'pbLibrary
        '
        Me.pbLibrary.Image = Global.LibrarySystem.My.Resources.Resources.book
        Me.pbLibrary.Location = New System.Drawing.Point(24, 17)
        Me.pbLibrary.Margin = New System.Windows.Forms.Padding(4)
        Me.pbLibrary.Name = "pbLibrary"
        Me.pbLibrary.Size = New System.Drawing.Size(77, 60)
        Me.pbLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLibrary.TabIndex = 8
        Me.pbLibrary.TabStop = False
        '
        'lblLibrary
        '
        Me.lblLibrary.AutoSize = True
        Me.lblLibrary.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibrary.ForeColor = System.Drawing.Color.Black
        Me.lblLibrary.Location = New System.Drawing.Point(137, 30)
        Me.lblLibrary.Name = "lblLibrary"
        Me.lblLibrary.Size = New System.Drawing.Size(105, 38)
        Me.lblLibrary.TabIndex = 3
        Me.lblLibrary.Text = "Library"
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.pnlSearch.BorderColor = System.Drawing.Color.Gray
        Me.pnlSearch.BorderRadius = 25
        Me.pnlSearch.BorderSize = 0
        Me.pnlSearch.Controls.Add(Me.lblSearchBooks)
        Me.pnlSearch.Controls.Add(Me.pbSearch)
        Me.pnlSearch.GradientColor1 = System.Drawing.Color.Empty
        Me.pnlSearch.GradientColor2 = System.Drawing.Color.Empty
        Me.pnlSearch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlSearch.Location = New System.Drawing.Point(20, 190)
        Me.pnlSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Opacity = 100
        Me.pnlSearch.Size = New System.Drawing.Size(315, 94)
        Me.pnlSearch.TabIndex = 6
        '
        'lblSearchBooks
        '
        Me.lblSearchBooks.AutoSize = True
        Me.lblSearchBooks.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBooks.ForeColor = System.Drawing.Color.Black
        Me.lblSearchBooks.Location = New System.Drawing.Point(101, 30)
        Me.lblSearchBooks.Name = "lblSearchBooks"
        Me.lblSearchBooks.Size = New System.Drawing.Size(187, 38)
        Me.lblSearchBooks.TabIndex = 3
        Me.lblSearchBooks.Text = "Search Books"
        '
        'pbSearch
        '
        Me.pbSearch.BackColor = System.Drawing.Color.Transparent
        Me.pbSearch.Image = Global.LibrarySystem.My.Resources.Resources.search
        Me.pbSearch.Location = New System.Drawing.Point(24, 20)
        Me.pbSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbSearch.Name = "pbSearch"
        Me.pbSearch.Size = New System.Drawing.Size(77, 60)
        Me.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSearch.TabIndex = 2
        Me.pbSearch.TabStop = False
        '
        'FrmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1621, 738)
        Me.Controls.Add(Me.pnlMainContent)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(2133, 1108)
        Me.MinimumSize = New System.Drawing.Size(1365, 738)
        Me.Name = "FrmStudent"
        Me.Text = "FrmStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlAccount.ResumeLayout(False)
        Me.pnlAccount.PerformLayout()
        CType(Me.pbAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFines.ResumeLayout(False)
        Me.pnlFines.PerformLayout()
        CType(Me.pbFines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLibrary.ResumeLayout(False)
        Me.pnlLibrary.PerformLayout()
        CType(Me.pbLibrary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.pbSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents pnlSearch As VMpanel
    Friend WithEvents lblSearchBooks As Label
    Friend WithEvents pbSearch As PictureBox
    Friend WithEvents pnlLibrary As VMpanel
    Friend WithEvents lblLibrary As Label
    Friend WithEvents pbLibrary As PictureBox
    Friend WithEvents pnlFines As VMpanel
    Friend WithEvents pbFines As PictureBox
    Friend WithEvents lblFines As Label
    Friend WithEvents pnlAccount As VMpanel
    Friend WithEvents pbAccount As PictureBox
    Friend WithEvents lblAccount As Label
    Friend WithEvents pnlMainContent As VMpanel
End Class
