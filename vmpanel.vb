Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class vmpanel
    Inherits Panel

    ' Fields
    Private _borderRadius As Integer = 0
    Private _borderSize As Integer = 0
    Private _borderColor As Color = Color.Gray
    Private _opacity As Integer = 100
    Private _gradientColor1 As Color = Color.Empty
    Private _gradientColor2 As Color = Color.Empty
    Private _gradientMode As LinearGradientMode = LinearGradientMode.Vertical

    ' Properties
    <Category("Appearance")>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _borderRadius = value
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("Appearance")>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(value As Integer)
            If value >= 0 Then
                _borderSize = value
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("Appearance")>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property Opacity As Integer
        Get
            Return _opacity
        End Get
        Set(value As Integer)
            If value >= 0 AndAlso value <= 100 Then
                _opacity = value
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("Appearance")>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property GradientColor1 As Color
        Get
            Return _gradientColor1
        End Get
        Set(value As Color)
            _gradientColor1 = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property GradientColor2 As Color
        Get
            Return _gradientColor2
        End Get
        Set(value As Color)
            _gradientColor2 = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property GradientMode As LinearGradientMode
        Get
            Return _gradientMode
        End Get
        Set(value As LinearGradientMode)
            _gradientMode = value
            Me.Invalidate()
        End Set
    End Property

    ' Constructor
    Public Sub New()
        MyBase.New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or
                   ControlStyles.UserPaint Or
                   ControlStyles.ResizeRedraw Or
                   ControlStyles.OptimizedDoubleBuffer Or
                   ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Transparent
        Me.DoubleBuffered = True
    End Sub

    ' Helper method to create rounded rectangle path
    Private Function GetRoundedRectPath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        If radius > 0 Then
            Dim diameter As Integer = radius * 2
            Dim arcRect As New Rectangle(rect.Location, New Size(diameter, diameter))

            ' Top left arc
            path.AddArc(arcRect, 180, 90)
            ' Top right arc
            arcRect.X = rect.Right - diameter
            path.AddArc(arcRect, 270, 90)
            ' Bottom right arc
            arcRect.Y = rect.Bottom - diameter
            path.AddArc(arcRect, 0, 90)
            ' Bottom left arc
            arcRect.X = rect.Left
            path.AddArc(arcRect, 90, 90)
            path.CloseFigure()
        Else
            path.AddRectangle(rect)
        End If
        Return path
    End Function

    ' Override OnPaint to implement custom drawing
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' Calculate the actual opacity value (0-255)
        Dim alpha As Integer = CInt(_opacity * 2.55)

        ' Create the main rectangle
        Dim rect As New Rectangle(0, 0, Me.Width - 1, Me.Heigh
