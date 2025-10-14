Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace CustomControls.VMControls
    Public Class VMRadioButton
        Inherits RadioButton

        'Fields
        Private _checkedColor As Color = Color.MediumSlateBlue
        Private _unCheckedColor As Color = Color.Gray

        'Properties
        Public Property CheckedColor As Color
            Get
                Return _checkedColor
            End Get
            Set(value As Color)
                _checkedColor = value
                Me.Invalidate()
            End Set
        End Property

        Public Property UnCheckedColor As Color
            Get
                Return _unCheckedColor
            End Get
            Set(value As Color)
                _unCheckedColor = value
                Me.Invalidate()
            End Set
        End Property

        'Constructor
        Public Sub New()
            Me.MinimumSize = New Size(0, 21)
            'Add a padding of 10 to the left to have a considerable distance between the text and the RadioButton.
            Me.Padding = New Padding(10, 0, 0, 0)
        End Sub

        'Overridden methods
        Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
            'Fields
            Dim graphics As Graphics = pevent.Graphics
            graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim rbBorderSize As Single = 18.0F
            Dim rbCheckSize As Single = 12.0F
            Dim rectRbBorder As New RectangleF() With {
                .X = 0.5F,
                .Y = (Me.Height - rbBorderSize) / 2, 'Center
                .Width = rbBorderSize,
                .Height = rbBorderSize
            }
            Dim rectRbCheck As New RectangleF() With {
                .X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2), 'Center
                .Y = (Me.Height - rbCheckSize) / 2, 'Center
                .Width = rbCheckSize,
                .Height = rbCheckSize
            }

            'Drawing
            Using penBorder As New Pen(_checkedColor, 1.6F)
                Using brushRbCheck As New SolidBrush(_checkedColor)
                    Using brushText As New SolidBrush(Me.ForeColor)
                        'Draw surface
                        graphics.Clear(Me.BackColor)
                        'Draw Radio Button
                        If Me.Checked Then
                            graphics.DrawEllipse(penBorder, rectRbBorder) 'Circle border
                            graphics.FillEllipse(brushRbCheck, rectRbCheck) 'Circle Radio Check
                        Else
                            penBorder.Color = _unCheckedColor
                            graphics.DrawEllipse(penBorder, rectRbBorder) 'Circle border
                        End If
                        'Draw text
                        graphics.DrawString(Me.Text, Me.Font, brushText,
                                            rbBorderSize + 8, (Me.Height - TextRenderer.MeasureText(Me.Text, Me.Font).Height) / 2) 'Y=Center
                    End Using
                End Using
            End Using
        End Sub

        'X-> Obsolete code, this was replaced by the Padding property in the constructor
        '(this.Padding = new Padding(10,0,0,0);)
        'Protected Overrides Sub OnResize(e As EventArgs)
        '    MyBase.OnResize(e)
        '    Me.Width = TextRenderer.MeasureText(Me.Text, Me.Font).Width + 30
        'End Sub
    End Class
End Namespace
