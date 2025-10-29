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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VmButton1 = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.btnLibrarian = New LibrarySystem.VergelControls.VMControls.VMButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(494, 45)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME TO LIBRARY LEDGER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(520, 60)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Press the key corresponding to your current position" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " and continue"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.LibrarySystem.My.Resources.Resources.library
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(673, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 404)
        Me.Panel1.TabIndex = 0
        '
        'VmButton1
        '
        Me.VmButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.VmButton1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.VmButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.VmButton1.BorderRadius = 30
        Me.VmButton1.BorderSize = 0
        Me.VmButton1.FlatAppearance.BorderSize = 0
        Me.VmButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VmButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VmButton1.ForeColor = System.Drawing.Color.White
        Me.VmButton1.Location = New System.Drawing.Point(174, 381)
        Me.VmButton1.Name = "VmButton1"
        Me.VmButton1.Size = New System.Drawing.Size(323, 61)
        Me.VmButton1.TabIndex = 4
        Me.VmButton1.Text = "STUDENTS"
        Me.VmButton1.TextColor = System.Drawing.Color.White
        Me.VmButton1.UseVisualStyleBackColor = False
        '
        'btnLibrarian
        '
        Me.btnLibrarian.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLibrarian.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLibrarian.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLibrarian.BorderRadius = 30
        Me.btnLibrarian.BorderSize = 0
        Me.btnLibrarian.FlatAppearance.BorderSize = 0
        Me.btnLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibrarian.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibrarian.ForeColor = System.Drawing.Color.White
        Me.btnLibrarian.Location = New System.Drawing.Point(174, 299)
        Me.btnLibrarian.Name = "btnLibrarian"
        Me.btnLibrarian.Size = New System.Drawing.Size(323, 61)
        Me.btnLibrarian.TabIndex = 3
        Me.btnLibrarian.Text = "LIBRARIAN"
        Me.btnLibrarian.TextColor = System.Drawing.Color.White
        Me.btnLibrarian.UseVisualStyleBackColor = False
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 611)
        Me.Controls.Add(Me.VmButton1)
        Me.Controls.Add(Me.btnLibrarian)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "Landing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Landing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLibrarian As VergelControls.VMControls.VMButton
    Friend WithEvents VmButton1 As VergelControls.VMControls.VMButton
End Class
