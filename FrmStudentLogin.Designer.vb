<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStudentLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlIcon = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlForgetPass = New System.Windows.Forms.Panel()
        Me.lblForgetPass = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.VmButton1 = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.btnLogin = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.btnPassword = New LibrarySystem.RJTextBox()
        Me.btnUserId = New LibrarySystem.RJTextBox()
        Me.Panel1.SuspendLayout()
        Me.pnlIcon.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlForgetPass.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnlIcon)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1234, 118)
        Me.Panel1.TabIndex = 4
        '
        'pnlIcon
        '
        Me.pnlIcon.Controls.Add(Me.PictureBox1)
        Me.pnlIcon.Location = New System.Drawing.Point(736, -25)
        Me.pnlIcon.Name = "pnlIcon"
        Me.pnlIcon.Size = New System.Drawing.Size(438, 339)
        Me.pnlIcon.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.LibrarySystem.My.Resources.Resources.Circle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(438, 339)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(169, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 30)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "BOOK BARROWING SYSTEM"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.logo
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(12, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(135, 104)
        Me.Panel4.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(179, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 40)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "LIBRARY LEDGER"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.Panel3.Controls.Add(Me.pnlForgetPass)
        Me.Panel3.Controls.Add(Me.VmButton1)
        Me.Panel3.Controls.Add(Me.btnLogin)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnPassword)
        Me.Panel3.Controls.Add(Me.btnUserId)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(685, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(549, 611)
        Me.Panel3.TabIndex = 6
        '
        'pnlForgetPass
        '
        Me.pnlForgetPass.AutoSize = True
        Me.pnlForgetPass.Controls.Add(Me.lblForgetPass)
        Me.pnlForgetPass.Location = New System.Drawing.Point(299, 369)
        Me.pnlForgetPass.Name = "pnlForgetPass"
        Me.pnlForgetPass.Size = New System.Drawing.Size(127, 21)
        Me.pnlForgetPass.TabIndex = 7
        '
        'lblForgetPass
        '
        Me.lblForgetPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblForgetPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgetPass.Location = New System.Drawing.Point(0, 0)
        Me.lblForgetPass.Name = "lblForgetPass"
        Me.lblForgetPass.Size = New System.Drawing.Size(127, 21)
        Me.lblForgetPass.TabIndex = 0
        Me.lblForgetPass.Text = "Forget Password?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(200, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "STUDENT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(155, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign in to your account"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(685, 611)
        Me.Panel2.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.login1
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(685, 611)
        Me.Panel6.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = Global.LibrarySystem.My.Resources.Resources.profile
        Me.PictureBox2.Location = New System.Drawing.Point(901, 88)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(81, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
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
        Me.VmButton1.Location = New System.Drawing.Point(407, 541)
        Me.VmButton1.Name = "VmButton1"
        Me.VmButton1.Size = New System.Drawing.Size(130, 47)
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
        Me.btnLogin.Location = New System.Drawing.Point(125, 396)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(301, 44)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.TextColor = System.Drawing.Color.White
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.Silver
        Me.btnPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnPassword.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPassword.BorderRadius = 20
        Me.btnPassword.BorderSize = 2
        Me.btnPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPassword.Location = New System.Drawing.Point(125, 322)
        Me.btnPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPassword.Multiline = False
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.btnPassword.PasswordChar = False
        Me.btnPassword.PlaceholderColor = System.Drawing.Color.DimGray
        Me.btnPassword.PlaceholderText = "PASSWORD"
        Me.btnPassword.Size = New System.Drawing.Size(301, 40)
        Me.btnPassword.TabIndex = 2
        Me.btnPassword.Texts = ""
        Me.btnPassword.UnderlinedStyle = False
        '
        'btnUserId
        '
        Me.btnUserId.BackColor = System.Drawing.Color.Silver
        Me.btnUserId.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUserId.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUserId.BorderRadius = 20
        Me.btnUserId.BorderSize = 2
        Me.btnUserId.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUserId.Location = New System.Drawing.Point(125, 274)
        Me.btnUserId.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUserId.Multiline = False
        Me.btnUserId.Name = "btnUserId"
        Me.btnUserId.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.btnUserId.PasswordChar = False
        Me.btnUserId.PlaceholderColor = System.Drawing.Color.DimGray
        Me.btnUserId.PlaceholderText = "USER ID"
        Me.btnUserId.Size = New System.Drawing.Size(301, 40)
        Me.btnUserId.TabIndex = 1
        Me.btnUserId.Texts = ""
        Me.btnUserId.UnderlinedStyle = False
        '
        'FrmStudentLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 611)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "FrmStudentLogin"
        Me.Text = "FrmStudentLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlIcon.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlForgetPass.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlIcon As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents VmButton1 As VergelControls.VMControls.VMButton
    Friend WithEvents btnLogin As VergelControls.VMControls.VMButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPassword As RJTextBox
    Friend WithEvents btnUserId As RJTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents pnlForgetPass As Panel
    Friend WithEvents lblForgetPass As Label
End Class
