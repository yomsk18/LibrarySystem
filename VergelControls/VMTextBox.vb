Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

<DefaultEvent("_TextChanged")>
Partial Public Class VMTextBox
    Inherits UserControl

    'Fields
    Private _borderColor As Color = Color.MediumSlateBlue
    Private _borderSize As Integer = 2
    Private _underlinedStyle As Boolean = False
    Private _borderFocusColor As Color = Color.HotPink
    Private _isFocused As Boolean = False

    'Constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    'Events
    Public Event _TextChanged As EventHandler

    'Properties
    <Category("RJ Code Advance")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            _borderSize = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property UnderlinedStyle As Boolean
        Get
            Return _underlinedStyle
        End Get
        Set(value As Boolean)
            _underlinedStyle = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property PasswordChar As Boolean
        Get
            Return textBox1.UseSystemPasswordChar
        End Get
        Set(value As Boolean)
            textBox1.UseSystemPasswordChar = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Multiline As Boolean
        Get
            Return textBox1.Multiline
        End Get
        Set(value As Boolean)
            textBox1.Multiline = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
            textBox1.BackColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
            textBox1.ForeColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
            textBox1.Font = value
            If Me.DesignMode Then
                UpdateControlHeight()
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Texts As String
        Get
            Return textBox1.Text
        End Get
        Set(value As String)
            textBox1.Text = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderFocusColor As Color
        Get
            Return _borderFocusColor
        End Get
        Set(value As Color)
            _borderFocusColor = value
        End Set
    End Property

    'Overridden methods
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graph As Graphics = e.Graphics

        'Draw border
        Using penBorder As New Pen(_borderColor, _borderSize)
            penBorder.Alignment = PenAlignment.Inset
            If _isFocused Then
                penBorder.Color = _borderFocusColor
            End If

            If _underlinedStyle Then 'Line Style
                graph.DrawLine(penBorder, 0, Me.Height - 1, Me.Width, Me.Height - 1)
            Else 'Normal Style
                graph.DrawRectangle(penBorder, 0, 0, Me.Width - 0.5F, Me.Height - 0.5F)
            End If
        End Using
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If Me.DesignMode Then
            UpdateControlHeight()
        End If
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        UpdateControlHeight()
    End Sub

    'Private methods
    Private Sub UpdateControlHeight()
        If textBox1.Multiline = False Then
            Dim txtHeight As Integer = TextRenderer.MeasureText("Text", Me.Font).Height + 1
            textBox1.Multiline = True
            textBox1.MinimumSize = New Size(0, txtHeight)
            textBox1.Multiline = False

            Me.Height = textBox1.Height + Me.Padding.Top + Me.Padding.Bottom
        End If
    End Sub

    'TextBox events
    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
        RaiseEvent _TextChanged(sender, e)
    End Sub

    Private Sub textBox1_Click(sender As Object, e As EventArgs) Handles textBox1.Click
        Me.OnClick(e)
    End Sub

    Private Sub textBox1_MouseEnter(sender As Object, e As EventArgs) Handles textBox1.MouseEnter
        Me.OnMouseEnter(e)
    End Sub

    Private Sub textBox1_MouseLeave(sender As Object, e As EventArgs) Handles textBox1.MouseLeave
        Me.OnMouseLeave(e)
    End Sub

    Private Sub textBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBox1.KeyPress
        Me.OnKeyPress(e)
    End Sub

    Private Sub textBox1_Enter(sender As Object, e As EventArgs) Handles textBox1.Enter
        _isFocused = True
        Me.Invalidate()
    End Sub

    Private Sub textBox1_Leave(sender As Object, e As EventArgs) Handles textBox1.Leave
        _isFocused = False
        Me.Invalidate()
    End Sub
End Class
