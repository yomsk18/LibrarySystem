<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Landing
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
        Me.VmButton1 = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.VmToggleButton1 = New LibrarySystem.VergelControls.VMControls.VMToggleButton()
        Me.VmTextBox1 = New LibrarySystem.VMTextBox()
        Me.VmTextBox2 = New LibrarySystem.VMTextBox()
        Me.SuspendLayout()
        '
        'VmButton1
        '
        Me.VmButton1.BackColor = System.Drawing.Color.SlateBlue
        Me.VmButton1.BackgroundColor = System.Drawing.Color.SlateBlue
        Me.VmButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.VmButton1.BorderRadius = 25
        Me.VmButton1.BorderSize = 0
        Me.VmButton1.FlatAppearance.BorderSize = 0
        Me.VmButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VmButton1.ForeColor = System.Drawing.Color.White
        Me.VmButton1.Location = New System.Drawing.Point(134, 33)
        Me.VmButton1.Name = "VmButton1"
        Me.VmButton1.Size = New System.Drawing.Size(294, 154)
        Me.VmButton1.TabIndex = 0
        Me.VmButton1.Text = "VmButton1"
        Me.VmButton1.TextColor = System.Drawing.Color.White
        Me.VmButton1.UseVisualStyleBackColor = False
        '
        'VmToggleButton1
        '
        Me.VmToggleButton1.Location = New System.Drawing.Point(482, 118)
        Me.VmToggleButton1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.VmToggleButton1.MinimumSize = New System.Drawing.Size(34, 18)
        Me.VmToggleButton1.Name = "VmToggleButton1"
        Me.VmToggleButton1.OffBackColor = System.Drawing.Color.Gray
        Me.VmToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro
        Me.VmToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue
        Me.VmToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke
        Me.VmToggleButton1.Size = New System.Drawing.Size(158, 69)
        Me.VmToggleButton1.TabIndex = 1
        Me.VmToggleButton1.UseVisualStyleBackColor = True
        '
        'VmTextBox1
        '
        Me.VmTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.VmTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.VmTextBox1.BorderFocusColor = System.Drawing.Color.HotPink
        Me.VmTextBox1.BorderSize = 1
        Me.VmTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VmTextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.VmTextBox1.Location = New System.Drawing.Point(292, 273)
        Me.VmTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.VmTextBox1.Multiline = False
        Me.VmTextBox1.Name = "VmTextBox1"
        Me.VmTextBox1.Padding = New System.Windows.Forms.Padding(7)
        Me.VmTextBox1.PasswordChar = False
        Me.VmTextBox1.Size = New System.Drawing.Size(250, 31)
        Me.VmTextBox1.TabIndex = 2
        Me.VmTextBox1.Texts = ""
        Me.VmTextBox1.UnderlinedStyle = False
        '
        'VmTextBox2
        '
        Me.VmTextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.VmTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue
        Me.VmTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.VmTextBox2.BorderSize = 1
        Me.VmTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VmTextBox2.ForeColor = System.Drawing.Color.DimGray
        Me.VmTextBox2.Location = New System.Drawing.Point(292, 323)
        Me.VmTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.VmTextBox2.Multiline = False
        Me.VmTextBox2.Name = "VmTextBox2"
        Me.VmTextBox2.Padding = New System.Windows.Forms.Padding(7)
        Me.VmTextBox2.PasswordChar = False
        Me.VmTextBox2.Size = New System.Drawing.Size(250, 31)
        Me.VmTextBox2.TabIndex = 3
        Me.VmTextBox2.Texts = ""
        Me.VmTextBox2.UnderlinedStyle = False
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VmTextBox2)
        Me.Controls.Add(Me.VmTextBox1)
        Me.Controls.Add(Me.VmToggleButton1)
        Me.Controls.Add(Me.VmButton1)
        Me.Name = "Landing"
        Me.Text = "Landing"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VmButton1 As LibrarySystem.VergelControls.VMControls.VMButton
    Friend WithEvents VmToggleButton1 As LibrarySystem.VergelControls.VMControls.VMToggleButton
    Friend WithEvents VmTextBox1 As VMTextBox
    Friend WithEvents VmTextBox2 As VMTextBox
End Class
