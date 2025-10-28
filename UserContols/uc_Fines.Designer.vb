<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Fines
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
        Me.VMpanel1 = New LibrarySystem.VMpanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VMpanel2 = New LibrarySystem.VMpanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFines = New System.Windows.Forms.Label()
        Me.VMpanel3 = New LibrarySystem.VMpanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VMpanel4 = New LibrarySystem.VMpanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAccountStatus = New System.Windows.Forms.Label()
        Me.cbFine = New LibrarySystem.VMComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtReason = New LibrarySystem.RJTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.VMpanel5 = New LibrarySystem.VMpanel()
        Me.VMpanel1.SuspendLayout()
        Me.VMpanel2.SuspendLayout()
        Me.VMpanel3.SuspendLayout()
        Me.VMpanel4.SuspendLayout()
        Me.VMpanel5.SuspendLayout()
        Me.SuspendLayout()
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
        Me.VMpanel1.Location = New System.Drawing.Point(53, 34)
        Me.VMpanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.VMpanel1.Name = "VMpanel1"
        Me.VMpanel1.Opacity = 100
        Me.VMpanel1.Size = New System.Drawing.Size(1117, 106)
        Me.VMpanel1.TabIndex = 13
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(65, 159)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 41)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "DISPUTE FINES"
        '
        'VMpanel2
        '
        Me.VMpanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.VMpanel2.BorderColor = System.Drawing.Color.Gray
        Me.VMpanel2.BorderRadius = 40
        Me.VMpanel2.BorderSize = 0
        Me.VMpanel2.Controls.Add(Me.Label2)
        Me.VMpanel2.Controls.Add(Me.lblFines)
        Me.VMpanel2.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VMpanel2.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VMpanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMpanel2.Location = New System.Drawing.Point(129, 215)
        Me.VMpanel2.Name = "VMpanel2"
        Me.VMpanel2.Opacity = 60
        Me.VMpanel2.Size = New System.Drawing.Size(201, 131)
        Me.VMpanel2.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-3, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 44)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Fines"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFines
        '
        Me.lblFines.BackColor = System.Drawing.Color.Transparent
        Me.lblFines.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFines.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblFines.Location = New System.Drawing.Point(0, 0)
        Me.lblFines.Name = "lblFines"
        Me.lblFines.Size = New System.Drawing.Size(201, 73)
        Me.lblFines.TabIndex = 0
        Me.lblFines.Text = "3"
        Me.lblFines.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VMpanel3
        '
        Me.VMpanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.VMpanel3.BorderColor = System.Drawing.Color.Gray
        Me.VMpanel3.BorderRadius = 40
        Me.VMpanel3.BorderSize = 0
        Me.VMpanel3.Controls.Add(Me.Label5)
        Me.VMpanel3.Controls.Add(Me.Label6)
        Me.VMpanel3.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VMpanel3.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VMpanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMpanel3.Location = New System.Drawing.Point(549, 215)
        Me.VMpanel3.Name = "VMpanel3"
        Me.VMpanel3.Opacity = 60
        Me.VMpanel3.Size = New System.Drawing.Size(201, 131)
        Me.VMpanel3.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(-3, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 44)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Total Price"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 73)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "150"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VMpanel4
        '
        Me.VMpanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.VMpanel4.BorderColor = System.Drawing.Color.Gray
        Me.VMpanel4.BorderRadius = 40
        Me.VMpanel4.BorderSize = 0
        Me.VMpanel4.Controls.Add(Me.Label7)
        Me.VMpanel4.Controls.Add(Me.lblAccountStatus)
        Me.VMpanel4.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VMpanel4.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.VMpanel4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMpanel4.Location = New System.Drawing.Point(910, 215)
        Me.VMpanel4.Name = "VMpanel4"
        Me.VMpanel4.Opacity = 60
        Me.VMpanel4.Size = New System.Drawing.Size(201, 131)
        Me.VMpanel4.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(-3, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 44)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Account Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAccountStatus
        '
        Me.lblAccountStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblAccountStatus.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblAccountStatus.Location = New System.Drawing.Point(0, 15)
        Me.lblAccountStatus.Name = "lblAccountStatus"
        Me.lblAccountStatus.Size = New System.Drawing.Size(201, 73)
        Me.lblAccountStatus.TabIndex = 0
        Me.lblAccountStatus.Text = "Suspended"
        Me.lblAccountStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbFine
        '
        Me.cbFine.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbFine.BorderColor = System.Drawing.SystemColors.AppWorkspace
        Me.cbFine.BorderSize = 1
        Me.cbFine.DataSource = Nothing
        Me.cbFine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFine.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFine.ForeColor = System.Drawing.Color.DimGray
        Me.cbFine.IconColor = System.Drawing.Color.MediumSlateBlue
        Me.cbFine.ListBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbFine.ListTextColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cbFine.Location = New System.Drawing.Point(255, 374)
        Me.cbFine.MinimumSize = New System.Drawing.Size(200, 30)
        Me.cbFine.Name = "cbFine"
        Me.cbFine.Padding = New System.Windows.Forms.Padding(1)
        Me.cbFine.Size = New System.Drawing.Size(248, 45)
        Me.cbFine.TabIndex = 18
        Me.cbFine.Texts = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(143, 378)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 41)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "FINE: "
        '
        'txtReason
        '
        Me.txtReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReason.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtReason.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtReason.BorderRadius = 10
        Me.txtReason.BorderSize = 2
        Me.txtReason.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.txtReason.Location = New System.Drawing.Point(779, 378)
        Me.txtReason.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReason.Multiline = False
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.txtReason.PasswordChar = False
        Me.txtReason.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.txtReason.PlaceholderText = "Reason"
        Me.txtReason.Size = New System.Drawing.Size(268, 46)
        Me.txtReason.TabIndex = 20
        Me.txtReason.Texts = ""
        Me.txtReason.UnderlinedStyle = False
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(837, 191)
        Me.TextBox1.TabIndex = 21
        '
        'VMpanel5
        '
        Me.VMpanel5.BackColor = System.Drawing.Color.Transparent
        Me.VMpanel5.BorderColor = System.Drawing.Color.Gray
        Me.VMpanel5.BorderRadius = 0
        Me.VMpanel5.BorderSize = 0
        Me.VMpanel5.Controls.Add(Me.TextBox1)
        Me.VMpanel5.GradientColor1 = System.Drawing.Color.Empty
        Me.VMpanel5.GradientColor2 = System.Drawing.Color.Empty
        Me.VMpanel5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.VMpanel5.Location = New System.Drawing.Point(210, 494)
        Me.VMpanel5.Name = "VMpanel5"
        Me.VMpanel5.Opacity = 100
        Me.VMpanel5.Size = New System.Drawing.Size(837, 191)
        Me.VMpanel5.TabIndex = 22
        '
        'uc_Fines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.VMpanel5)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbFine)
        Me.Controls.Add(Me.VMpanel4)
        Me.Controls.Add(Me.VMpanel3)
        Me.Controls.Add(Me.VMpanel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VMpanel1)
        Me.Name = "uc_Fines"
        Me.Size = New System.Drawing.Size(1247, 738)
        Me.VMpanel1.ResumeLayout(False)
        Me.VMpanel1.PerformLayout()
        Me.VMpanel2.ResumeLayout(False)
        Me.VMpanel3.ResumeLayout(False)
        Me.VMpanel4.ResumeLayout(False)
        Me.VMpanel5.ResumeLayout(False)
        Me.VMpanel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VMpanel1 As VMpanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents VMpanel2 As VMpanel
    Friend WithEvents lblFines As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VMpanel3 As VMpanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents VMpanel4 As VMpanel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAccountStatus As Label
    Friend WithEvents cbFine As VMComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtReason As RJTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents VMpanel5 As VMpanel
End Class
