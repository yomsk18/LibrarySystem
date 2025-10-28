<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmStudentLogin
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.linklblSignUp = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlForgetPass = New System.Windows.Forms.Panel()
        Me.lblForgetPass = New System.Windows.Forms.Label()
        Me.VmButton1 = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.btnLogin = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New LibrarySystem.RJTextBox()
        Me.txtUserId = New LibrarySystem.RJTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlIcon = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.pnlForgetPass.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIcon.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel3.Controls.Add(Me.linklblSignUp)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.pnlForgetPass)
        Me.Panel3.Controls.Add(Me.VmButton1)
        Me.Panel3.Controls.Add(Me.btnLogin)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.Controls.Add(Me.txtUserId)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(913, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(732, 752)
        Me.Panel3.TabIndex = 6
        '
        'linklblSignUp
        '
        Me.linklblSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.linklblSignUp.AutoSize = True
        Me.linklblSignUp.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklblSignUp.LinkColor = System.Drawing.Color.Blue
        Me.linklblSignUp.Location = New System.Drawing.Point(459, 549)
        Me.linklblSignUp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linklblSignUp.Name = "linklblSignUp"
        Me.linklblSignUp.Size = New System.Drawing.Size(67, 20)
        Me.linklblSignUp.TabIndex = 9
        Me.linklblSignUp.TabStop = True
        Me.linklblSignUp.Text = "Sign Up"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 545)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Do you have account?"
        '
        'pnlForgetPass
        '
        Me.pnlForgetPass.AutoSize = True
        Me.pnlForgetPass.Controls.Add(Me.lblForgetPass)
        Me.pnlForgetPass.Location = New System.Drawing.Point(399, 454)
        Me.pnlForgetPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlForgetPass.Name = "pnlForgetPass"
        Me.pnlForgetPass.Size = New System.Drawing.Size(169, 26)
        Me.pnlForgetPass.TabIndex = 7
        '
        'lblForgetPass
        '
        Me.lblForgetPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblForgetPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgetPass.Location = New System.Drawing.Point(0, 0)
        Me.lblForgetPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForgetPass.Name = "lblForgetPass"
        Me.lblForgetPass.Size = New System.Drawing.Size(169, 26)
        Me.lblForgetPass.TabIndex = 0
        Me.lblForgetPass.Text = "Forget Password?"
        '
        'VmButton1
        '
        Me.VmButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.VmButton1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.VmButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.VmButton1.BorderRadius = 20
        Me.VmButton1.BorderSize = 0
        Me.VmButton1.FlatAppearance.BorderSize = 0
        Me.VmButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VmButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VmButton1.ForeColor = System.Drawing.Color.White
        Me.VmButton1.Location = New System.Drawing.Point(543, 666)
        Me.VmButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.VmButton1.Name = "VmButton1"
        Me.VmButton1.Size = New System.Drawing.Size(173, 58)
        Me.VmButton1.TabIndex = 5
        Me.VmButton1.Text = "BACK"
        Me.VmButton1.TextColor = System.Drawing.Color.White
        Me.VmButton1.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.btnLogin.BorderRadius = 20
        Me.btnLogin.BorderSize = 0
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(167, 487)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(401, 54)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.TextColor = System.Drawing.Color.White
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(267, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "STUDENT"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Silver
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPassword.BorderRadius = 20
        Me.txtPassword.BorderSize = 2
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(167, 396)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Padding = New System.Windows.Forms.Padding(13, 9, 13, 9)
        Me.txtPassword.PasswordChar = True
        Me.txtPassword.PlaceholderColor = System.Drawing.Color.DimGray
        Me.txtPassword.PlaceholderText = "PASSWORD"
        Me.txtPassword.Size = New System.Drawing.Size(401, 51)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Texts = ""
        Me.txtPassword.UnderlinedStyle = False
        '
        'txtUserId
        '
        Me.txtUserId.BackColor = System.Drawing.Color.Silver
        Me.txtUserId.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUserId.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtUserId.BorderRadius = 20
        Me.txtUserId.BorderSize = 2
        Me.txtUserId.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUserId.Location = New System.Drawing.Point(167, 337)
        Me.txtUserId.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtUserId.Multiline = False
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Padding = New System.Windows.Forms.Padding(13, 9, 13, 9)
        Me.txtUserId.PasswordChar = False
        Me.txtUserId.PlaceholderColor = System.Drawing.Color.DimGray
        Me.txtUserId.PlaceholderText = "USER ID"
        Me.txtUserId.Size = New System.Drawing.Size(401, 51)
        Me.txtUserId.TabIndex = 1
        Me.txtUserId.Texts = ""
        Me.txtUserId.UnderlinedStyle = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(207, 279)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign in to your account"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(913, 752)
        Me.Panel2.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.login1
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(913, 752)
        Me.Panel6.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = Global.LibrarySystem.My.Resources.Resources.profile
        Me.PictureBox2.Location = New System.Drawing.Point(1201, 108)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(108, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(239, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(319, 50)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "LIBRARY LEDGER"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.logo
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(16, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(180, 128)
        Me.Panel4.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(225, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(366, 37)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "BOOK BARROWING SYSTEM"
        '
        'pnlIcon
        '
        Me.pnlIcon.Controls.Add(Me.PictureBox1)
        Me.pnlIcon.Location = New System.Drawing.Point(981, -31)
        Me.pnlIcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlIcon.Name = "pnlIcon"
        Me.pnlIcon.Size = New System.Drawing.Size(584, 417)
        Me.pnlIcon.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.Circle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(584, 417)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnlIcon)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1645, 145)
        Me.Panel1.TabIndex = 4
        '
        'FrmStudentLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1645, 752)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(2133, 1108)
        Me.MinimumSize = New System.Drawing.Size(1365, 738)
        Me.Name = "FrmStudentLogin"
        Me.Text = "FrmStudentLogin"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlForgetPass.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIcon.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents VmButton1 As VergelControls.VMControls.VMButton
    Friend WithEvents btnLogin As VergelControls.VMControls.VMButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As RJTextBox
    Friend WithEvents txtUserId As RJTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents pnlForgetPass As Panel
    Friend WithEvents lblForgetPass As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents linklblSignUp As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlIcon As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
