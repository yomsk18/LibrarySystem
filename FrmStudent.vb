Public Class FrmStudent
    Dim isSelected As Boolean = False
    Private Sub pnlSearch_MouseEnter(sender As Object, e As EventArgs) _
    Handles pnlSearch.MouseEnter, pbSearch.MouseEnter, lblSearchBooks.MouseEnter
        If isSelected = True Then
            Return
        End If
        pnlSearch.BackColor = Color.FromArgb(171, 146, 116)
        pnlSearch.Cursor = Cursors.Hand
    End Sub

    Private Sub pnlSearch_MouseLeave(sender As Object, e As EventArgs) _
    Handles pnlSearch.MouseLeave, pbSearch.MouseLeave, lblSearchBooks.MouseLeave
        If isSelected = True Then
            Return
        End If
        ' Check if mouse really left the panel area (not just entered a child)
        Dim mousePos As Point = pnlSearch.PointToClient(Cursor.Position)
        If Not pnlSearch.ClientRectangle.Contains(mousePos) Then
            pnlSearch.BackColor = Color.FromArgb(191, 166, 136)
        End If
    End Sub

    Private Sub pnlSearch_Click(sender As Object, e As MouseEventArgs) Handles pnlSearch.Click, pbSearch.Click, lblSearchBooks.Click
        isSelected = True
        pnlSearch.BackColor = Color.FromArgb(44, 68, 44)
        lblSearchBooks.ForeColor = Color.White

    End Sub
End Class