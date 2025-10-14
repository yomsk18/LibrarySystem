Imports System.Windows.Forms
Imports System.Drawing

Partial Public Class VMTextBox
    Inherits UserControl

    'Required designer variable.
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.Location = New System.Drawing.Point(7, 7)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(236, 15)
        Me.textBox1.TabIndex = 0
        '
        'VMTextBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.textBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DimGray
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "VMTextBox"
        Me.Padding = New System.Windows.Forms.Padding(7)
        Me.Size = New System.Drawing.Size(250, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents textBox1 As System.Windows.Forms.TextBox
End Class
