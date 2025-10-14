Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

<DefaultEvent("_TextChanged")>
Partial Public Class RJTextBox
    Inherits UserControl

#Region "-> Fields"
    'Fields
    Private _borderColor As Color = Color.MediumSlateBlue
    Private _borderFocusColor As Color = Color.HotPink
    Private _borderSize As Integer = 2
    Private _underlinedStyle As Boolean = False
    Private _isFocused As Boolean = False

    Private _borderRadius As Integer = 0
    Private _placeholderColor As Color = Color.DarkGray
    Private _placeholderText As String = ""
    Private _isPlaceholder As Boolean = False
    Private _isPasswordChar As Boolean = False

    'Events
    Public Event _TextChanged As EventHandler
#End Region

    '-> Constructor
    Public Sub New()
        'Created by designer
        InitializeComponent()
    End Sub

#Region "-> Properties"
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
    Public Property BorderFocusColor As Color
        Get
            Return _borderFocusColor
        End Get
        Set(value As Color)
            _borderFocusColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            If value >= 1 Then
                _borderSize = value
                Me.Invalidate()
            End If
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
            Return _isPasswordChar
        End Get
        Set(value As Boolean)
            _isPasswordChar = value
            If Not _isPlaceholder Then
                textBox1.UseSystemPasswordChar = value
            End If
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
            If _isPlaceholder Then
                Return ""
            Else
                Return textBox1.Text
            End If
        End Get
        Set(value As String)
            textBox1.Text = value
            SetPlaceholder()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _borderRadius = value
                Me.Invalidate() 'Redraw control
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property PlaceholderColor As Color
        Get
            Return _placeholderColor
        End Get
        Set(value As Color)
            _placeholderColor = value
            If _isPlaceholder Then
                textBox1.ForeColor = value
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property PlaceholderText As String
        Get
            Return _placeholderText
        End Get
        Set(value As String)
            _placeholderText = value
            textBox1.Text = ""
            SetPlaceholder()
        End Set
    End Property
#End Region

#Region "-> Overridden methods"
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

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graph As Graphics = e.Graphics

        If _borderRadius > 1 Then 'Rounded TextBox
            '-Fields
            Dim rectBorderSmooth As Rectangle = Me.ClientRectangle
            Dim rectBorder As Rectangle = Rectangle.Inflate(rectBorderSmooth, -_borderSize, -_borderSize)
            Dim smoothSize As Integer = If(_borderSize > 0, _borderSize, 1)

            Using pathBorderSmooth As GraphicsPath = GetFigurePath(rectBorderSmooth, _borderRadius),
                  pathBorder As GraphicsPath = GetFigurePath(rectBorder, _borderRadius - _borderSize),
                  penBorderSmooth As New Pen(Me.Parent.BackColor, smoothSize),
                  penBorder As New Pen(_borderColor, _borderSize)

                '-Drawing
                Me.Region = New Region(pathBorderSmooth) 'Set the rounded region of UserControl
                If _borderRadius > 15 Then SetTextBoxRoundedRegion() 'Set the rounded region of TextBox component
                graph.SmoothingMode = SmoothingMode.AntiAlias
                penBorder.Alignment = PenAlignment.Center
                If _isFocused Then penBorder.Color = _borderFocusColor

                If _underlinedStyle Then 'Line Style
                    'Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth)
                    'Draw border
                    graph.SmoothingMode = SmoothingMode.None
                    graph.DrawLine(penBorder, 0, Me.Height - 1, Me.Width, Me.Height - 1)
                Else 'Normal Style
                    'Draw border smoothing
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth)
                    'Draw border
                    graph.DrawPath(penBorder, pathBorder)
                End If
            End Using
        Else 'Square/Normal TextBox
            'Draw border
            Using penBorder As New Pen(_borderColor, _borderSize)
                Me.Region = New Region(Me.ClientRectangle)
                penBorder.Alignment = PenAlignment.Inset
                If _isFocused Then penBorder.Color = _borderFocusColor

                If _underlinedStyle Then 'Line Style
                    graph.DrawLine(penBorder, 0, Me.Height - 1, Me.Width, Me.Height - 1)
                Else 'Normal Style
                    graph.DrawRectangle(penBorder, 0, 0, Me.Width - 0.5F, Me.Height - 0.5F)
                End If
            End Using
        End If
    End Sub
#End Region

#Region "-> Private methods"
    Private Sub SetPlaceholder()
        If String.IsNullOrWhiteSpace(textBox1.Text) AndAlso _placeholderText <> "" Then
            _isPlaceholder = True
            textBox1.Text = _placeholderText
            textBox1.ForeColor = _placeholderColor
            If _isPasswordChar Then
                textBox1.UseSystemPasswordChar = False
            End If
        End If
    End Sub

    Private Sub RemovePlaceholder()
        If _isPlaceholder AndAlso _placeholderText <> "" Then
            _isPlaceholder = False
            textBox1.Text = ""
            textBox1.ForeColor = Me.ForeColor
            If _isPasswordChar Then
                textBox1.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    Private Function GetFigurePath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim curveSize As Single = radius * 2.0F

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub SetTextBoxRoundedRegion()
        Dim pathTxt As GraphicsPath
        If Multiline Then
            pathTxt = GetFigurePath(textBox1.ClientRectangle, _borderRadius - _borderSize)
            textBox1.Region = New Region(pathTxt)
        Else
            pathTxt = GetFigurePath(textBox1.ClientRectangle, _borderSize * 2)
            textBox1.Region = New Region(pathTxt)
        End If
        pathTxt.Dispose()
    End Sub

    Private Sub UpdateControlHeight()
        If textBox1.Multiline = False Then
            Dim txtHeight As Integer = TextRenderer.MeasureText("Text", Me.Font).Height + 1
            textBox1.Multiline = True
            textBox1.MinimumSize = New Size(0, txtHeight)
            textBox1.Multiline = False

            Me.Height = textBox1.Height + Me.Padding.Top + Me.Padding.Bottom
        End If
    End Sub
#End Region

#Region "-> TextBox events"
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
        RemovePlaceholder()
    End Sub

    Private Sub textBox1_Leave(sender As Object, e As EventArgs) Handles textBox1.Leave
        _isFocused = False
        Me.Invalidate()
        SetPlaceholder()
    End Sub
#End Region
End Class