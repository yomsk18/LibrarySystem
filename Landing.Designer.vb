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
        Me.VmButton1 = New LibrarySystem.CustomControls.VMControls.VMButton()
        Me.VmToggleButton1 = New LibrarySystem.CustomControls.VMControls.VMToggleButton()
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
        Me.VmButton1.Location = New System.Drawing.Point(179, 41)
        Me.VmButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.VmButton1.Name = "VmButton1"
        Me.VmButton1.Size = New System.Drawing.Size(392, 189)
        Me.VmButton1.TabIndex = 0
        Me.VmButton1.Text = "VmButton1"
        Me.VmButton1.TextColor = System.Drawing.Color.White
        Me.VmButton1.UseVisualStyleBackColor = False
        '
        'VmToggleButton1
        '
        Me.VmToggleButton1.Location = New System.Drawing.Point(642, 145)
        Me.VmToggleButton1.MinimumSize = New System.Drawing.Size(45, 22)
        Me.VmToggleButton1.Name = "VmToggleButton1"
        Me.VmToggleButton1.OffBackColor = System.Drawing.Color.Gray
        Me.VmToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro
        Me.VmToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue
        Me.VmToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke
        Me.VmToggleButton1.Size = New System.Drawing.Size(210, 85)
        Me.VmToggleButton1.TabIndex = 1
        Me.VmToggleButton1.UseVisualStyleBackColor = True
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.VmToggleButton1)
        Me.Controls.Add(Me.VmButton1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Landing"
        Me.Text = "Landing"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VmButton1 As LibrarySystem.CustomControls.VMControls.VMButton
    Friend WithEvents VmToggleButton1 As LibrarySystem.CustomControls.VMControls.VMToggleButton
End Class
