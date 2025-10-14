Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace CustomControls.VMControls
    Public Class VMCalendar
        Inherits DateTimePicker

        'Fields
        '-> Appearance
        Private _skinColor As Color = Color.MediumSlateBlue
        Private _textColor As Color = Color.White
        Private _borderColor As Color = Color.PaleVioletRed
        Private _borderSize As Integer = 0

        '-> Other Values
        Private _droppedDown As Boolean = False
        ' Private _calendarIcon As Image = My.Resources.Resources.calendarWhite
        Private _iconButtonArea As RectangleF
        Private Const calendarIconWidth As Integer = 34
        Private Const arrowIconWidth As Integer = 17

        'Properties
        Public Property SkinColor As Color
            Get
                Return _skinColor
            End Get
            Set(value As Color)
                _skinColor = value
                If _skinColor.GetBrightness() >= 0.6F Then
                    '_calendarIcon = My.Resources.Resources.calendarDark
                Else
                    '_calendarIcon = My.Resources.Resources.calendarWhite
                End If
                Me.Invalidate()
            End Set
        End Property

        Public Property TextColor As Color
            Get
                Return _textColor
            End Get
            Set(value As Color)
                _textColor = value
                Me.Invalidate()
            End Set
        End Property

        Public Property BorderColor As Color
            Get
                Return _borderColor
            End Get
            Set(value As Color)
                _borderColor = value
                Me.Invalidate()
            End Set
        End Property

        Public Property BorderSize As Integer
            Get
                Return _borderSize
            End Get
            Set(value As Integer)
                _borderSize = value
                Me.Invalidate()
            End Set
        End Property

        'Constructor
        Public Sub New()
            Me.SetStyle(ControlStyles.UserPaint, True)
            Me.MinimumSize = New Size(0, 35)
            Me.Font = New Font(Me.Font.Name, 9.5F)
        End Sub

        'Overridden methods
        Protected Overrides Sub OnDropDown(eventargs As EventArgs)
            MyBase.OnDropDown(eventargs)
            _droppedDown = True
        End Sub

        Protected Overrides Sub OnCloseUp(eventargs As EventArgs)
            MyBase.OnCloseUp(eventargs)
            _droppedDown = False
        End Sub

        Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
            MyBase.OnKeyPress(e)
            e.Handled = True
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            Using graphics As Graphics = Me.CreateGraphics()
                Using penBorder As New Pen(_borderColor, _borderSize)
                    Using skinBrush As New SolidBrush(_skinColor)
                        Using openIconBrush As New SolidBrush(Color.FromArgb(50, 64, 64, 64))
                            Using textBrush As New SolidBrush(_textColor)
                                Using textFormat As New StringFormat()
                                    Dim clientArea As New RectangleF(0, 0, Me.Width - 0.5F, Me.Height - 0.5F)
                                    Dim iconArea As New RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height)
                                    penBorder.Alignment = PenAlignment.Inset
                                    textFormat.LineAlignment = StringAlignment.Center

                                    'Draw surface
                                    graphics.FillRectangle(skinBrush, clientArea)
                                    'Draw text
                                    graphics.DrawString("   " & Me.Text, Me.Font, textBrush, clientArea, textFormat)
                                    'Draw open calendar icon highlight
                                    If _droppedDown = True Then graphics.FillRectangle(openIconBrush, iconArea)
                                    'Draw border 
                                    If _borderSize >= 1 Then graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height)
                                    'Draw icon
                                    'graphics.DrawImage(_calendarIcon, Me.Width - _calendarIcon.Width - 9, (Me.Height - _calendarIcon.Height) / 2)
                                End Using
                            End Using
                        End Using
                    End Using
                End Using
            End Using
        End Sub

        Protected Overrides Sub OnHandleCreated(e As EventArgs)
            MyBase.OnHandleCreated(e)
            Dim iconWidth As Integer = GetIconButtonWidth()
            _iconButtonArea = New RectangleF(Me.Width - iconWidth, 0, iconWidth, Me.Height)
        End Sub

        Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
            MyBase.OnMouseMove(e)
            If _iconButtonArea.Contains(e.Location) Then
                Me.Cursor = Cursors.Hand
            Else
                Me.Cursor = Cursors.Default
            End If
        End Sub

        'Private methods
        Private Function GetIconButtonWidth() As Integer
            Dim textWidth As Integer = TextRenderer.MeasureText(Me.Text, Me.Font).Width
            If textWidth <= Me.Width - (calendarIconWidth + 20) Then
                Return calendarIconWidth
            Else
                Return arrowIconWidth
            End If
        End Function
    End Class
End Namespace