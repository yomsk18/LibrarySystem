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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VmButton1 = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.VmButton2 = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.VmButton3 = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.VmButton4 = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.Panel1.Controls.Add(Me.VmButton4)
        Me.Panel1.Controls.Add(Me.VmButton3)
        Me.Panel1.Controls.Add(Me.VmButton2)
        Me.Panel1.Controls.Add(Me.VmButton1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 600)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(43, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome,"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(148, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAME!"
        '
        'VmButton1
        '
        Me.VmButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.VmButton1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.VmButton1.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.VmButton1.BorderRadius = 0
        Me.VmButton1.BorderSize = 0
        Me.VmButton1.FlatAppearance.BorderSize = 0
        Me.VmButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VmButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VmButton1.ForeColor = System.Drawing.Color.Black
        Me.VmButton1.Location = New System.Drawing.Point(102, 151)
        Me.VmButton1.Name = "VmButton1"
        Me.VmButton1.Size = New System.Drawing.Size(156, 65)
        Me.VmButton1.TabIndex = 1
        Me.VmButton1.Text = "Search Book"
        Me.VmButton1.TextColor = System.Drawing.Color.Black
        Me.VmButton1.UseVisualStyleBackColor = False
        '
        'VmButton2
        '
        Me.VmButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.VmButton2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.VmButton2.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.VmButton2.BorderRadius = 0
        Me.VmButton2.BorderSize = 0
        Me.VmButton2.FlatAppearance.BorderSize = 0
        Me.VmButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VmButton2.ForeColor = System.Drawing.Color.White
        Me.VmButton2.Location = New System.Drawing.Point(22, 239)
        Me.VmButton2.Name = "VmButton2"
        Me.VmButton2.Size = New System.Drawing.Size(236, 65)
        Me.VmButton2.TabIndex = 3
        Me.VmButton2.Text = "VmButton2"
        Me.VmButton2.TextColor = System.Drawing.Color.White
        Me.VmButton2.UseVisualStyleBackColor = False
        '
        'VmButton3
        '
        Me.VmButton3.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.VmButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.VmButton3.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.VmButton3.BorderRadius = 0
        Me.VmButton3.BorderSize = 0
        Me.VmButton3.FlatAppearance.BorderSize = 0
        Me.VmButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VmButton3.ForeColor = System.Drawing.Color.White
        Me.VmButton3.Location = New System.Drawing.Point(22, 322)
        Me.VmButton3.Name = "VmButton3"
        Me.VmButton3.Size = New System.Drawing.Size(236, 65)
        Me.VmButton3.TabIndex = 4
        Me.VmButton3.Text = "VmButton3"
        Me.VmButton3.TextColor = System.Drawing.Color.White
        Me.VmButton3.UseVisualStyleBackColor = False
        '
        'VmButton4
        '
        Me.VmButton4.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.VmButton4.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.VmButton4.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.VmButton4.BorderRadius = 0
        Me.VmButton4.BorderSize = 0
        Me.VmButton4.FlatAppearance.BorderSize = 0
        Me.VmButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VmButton4.ForeColor = System.Drawing.Color.White
        Me.VmButton4.Location = New System.Drawing.Point(22, 411)
        Me.VmButton4.Name = "VmButton4"
        Me.VmButton4.Size = New System.Drawing.Size(236, 65)
        Me.VmButton4.TabIndex = 5
        Me.VmButton4.Text = "VmButton4"
        Me.VmButton4.TextColor = System.Drawing.Color.White
        Me.VmButton4.UseVisualStyleBackColor = False
        '
        'FrmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1216, 600)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "FrmStudent"
        Me.Text = "FrmStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VmButton4 As VergelControls.VMControls.VMButton
    Friend WithEvents VmButton3 As VergelControls.VMControls.VMButton
    Friend WithEvents VmButton2 As VergelControls.VMControls.VMButton
    Friend WithEvents VmButton1 As VergelControls.VMControls.VMButton
End Class
