Public Class FrmStudent
    Dim isSearchSelected As Boolean = False
    Dim isLibrarySelected As Boolean = False
    Dim isFinesSelected As Boolean = False
    Dim isAccountSelected As Boolean = False

    Private Sub Form_Load1(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlSearch.BackColor = Color.FromArgb(44, 68, 44)
        lblSearchBooks.ForeColor = Color.White
        pbSearch.Image = My.Resources.searchPressed
        DefaultButton(pnlLibrary, lblLibrary, pbLibrary, My.Resources.book)
        DefaultButton(pnlFines, lblFines, pbFines, My.Resources.peso)
        DefaultButton(pnlAccount, lblFines, pbAccount, My.Resources.account)
        LoadUserControl(New uc_SearchBook())
    End Sub

    Private Sub LoadUserControl(ctrl As UserControl)
        pnlMainContent.Controls.Clear()
        pnlMainContent.Controls.Add(ctrl)
    End Sub
    ' Search Books Panel Events
    Private Sub pnlSearch_MouseEnter(sender As Object, e As EventArgs) _
    Handles pnlSearch.MouseEnter, pbSearch.MouseEnter, lblSearchBooks.MouseEnter
        If isSearchSelected = True Then
            Return
        End If
        pnlSearch.BackColor = Color.FromArgb(171, 146, 116)
        pnlSearch.Cursor = Cursors.Hand
    End Sub

    Private Sub pnlSearch_MouseLeave(sender As Object, e As EventArgs) _
    Handles pnlSearch.MouseLeave, pbSearch.MouseLeave, lblSearchBooks.MouseLeave
        If isSearchSelected = True Then
            Return
        End If
        ' Check if mouse really left the panel area (not just entered a child)
        Dim mousePos As Point = pnlSearch.PointToClient(Cursor.Position)
        If Not pnlSearch.ClientRectangle.Contains(mousePos) Then
            pnlSearch.BackColor = Color.FromArgb(191, 166, 136)
        End If
    End Sub

    Private Sub pnlSearch_Click(sender As Object, e As MouseEventArgs) Handles pnlSearch.Click, pbSearch.Click, lblSearchBooks.Click
        isSearchSelected = True
        pnlSearch.BackColor = Color.FromArgb(44, 68, 44)
        lblSearchBooks.ForeColor = Color.White
        pbSearch.Image = My.Resources.searchPressed
        DefaultButton(pnlLibrary, lblLibrary, pbLibrary, My.Resources.book)
        DefaultButton(pnlFines, lblFines, pbFines, My.Resources.peso)
        DefaultButton(pnlAccount, lblFines, pbAccount, My.Resources.account)
        LoadUserControl(New uc_SearchBook())

    End Sub
    'library panel events
    Private Sub pnlLibrary_MouseEnter(sender As Object, e As EventArgs) _
    Handles pnlLibrary.MouseEnter, pbLibrary.MouseEnter, lblLibrary.MouseEnter
        If isLibrarySelected = True Then
            Return
        End If
        pnlLibrary.BackColor = Color.FromArgb(171, 146, 116)
        pnlLibrary.Cursor = Cursors.Hand
    End Sub

    Private Sub pnlLibrary_MouseLeave(sender As Object, e As EventArgs) _
    Handles pnlLibrary.MouseLeave, pbLibrary.MouseLeave, lblLibrary.MouseLeave
        If isLibrarySelected = True Then
            Return
        End If
        ' Check if mouse really left the panel area (not just entered a child)
        Dim mousePos As Point = pnlLibrary.PointToClient(Cursor.Position)
        If Not pnlLibrary.ClientRectangle.Contains(mousePos) Then
            pnlLibrary.BackColor = Color.FromArgb(191, 166, 136)
        End If
    End Sub

    Private Sub pnlLibrary_Click(sender As Object, e As MouseEventArgs) Handles pnlLibrary.Click, pbLibrary.Click, lblLibrary.Click
        isLibrarySelected = True
        pnlLibrary.BackColor = Color.FromArgb(44, 68, 44)
        lblLibrary.ForeColor = Color.White
        pbLibrary.Image = My.Resources.bookPressed
        DefaultButton(pnlSearch, lblSearchBooks, pbSearch, My.Resources.search)
        DefaultButton(pnlFines, lblFines, pbFines, My.Resources.peso)
        DefaultButton(pnlAccount, lblFines, pbAccount, My.Resources.account)
    End Sub

    'View Fine panel events
    Private Sub pnlFines_MouseEnter(sender As Object, e As EventArgs) _
Handles pnlFines.MouseEnter, lblFines.MouseEnter, lblFines.MouseEnter
        If isFinesSelected = True Then
            Return
        End If
        pnlFines.BackColor = Color.FromArgb(171, 146, 116)
        pnlFines.Cursor = Cursors.Hand
    End Sub

    Private Sub pnlFines_MouseLeave(sender As Object, e As EventArgs) _
    Handles pnlFines.MouseLeave, pbFines.MouseLeave, lblFines.MouseLeave
        If isFinesSelected = True Then
            Return
        End If
        ' Check if mouse really left the panel area (not just entered a child)
        Dim mousePos As Point = pnlAccount.PointToClient(Cursor.Position)
        If Not pnlFines.ClientRectangle.Contains(mousePos) Then
            pnlFines.BackColor = Color.FromArgb(191, 166, 136)
        End If
    End Sub

    Private Sub pnlFines_Click(sender As Object, e As MouseEventArgs) _
    Handles pnlFines.Click, pbFines.Click, lblFines.Click
        isFinesSelected = True
        pnlFines.BackColor = Color.FromArgb(44, 68, 44)
        lblFines.ForeColor = Color.White
        pbFines.Image = My.Resources.pesoPressed
        DefaultButton(pnlSearch, lblSearchBooks, pbSearch, My.Resources.search)
        DefaultButton(pnlLibrary, lblLibrary, pbLibrary, My.Resources.book)
        DefaultButton(pnlAccount, lblFines, pbAccount, My.Resources.account)
    End Sub
    'account panel events
    Private Sub pnlAccount_MouseEnter(sender As Object, e As EventArgs) _
    Handles pnlAccount.MouseEnter, lblAccount.MouseEnter, lblAccount.MouseEnter
        If isAccountSelected = True Then
            Return
        End If
        pnlAccount.BackColor = Color.FromArgb(171, 146, 116)
        pnlAccount.Cursor = Cursors.Hand
    End Sub

    Private Sub pnlAccount_MouseLeave(sender As Object, e As EventArgs) _
    Handles pnlAccount.MouseLeave, pbAccount.MouseLeave, lblAccount.MouseLeave
        If isAccountSelected = True Then
            Return
        End If
        ' Check if mouse really left the panel area (not just entered a child)
        Dim mousePos As Point = pnlAccount.PointToClient(Cursor.Position)
        If Not pnlAccount.ClientRectangle.Contains(mousePos) Then
            pnlAccount.BackColor = Color.FromArgb(191, 166, 136)
        End If
    End Sub

    Private Sub pnlAccount_Click(sender As Object, e As MouseEventArgs) Handles pnlAccount.Click, pbAccount.Click, lblAccount.Click
        isAccountSelected = True
        pnlAccount.BackColor = Color.FromArgb(44, 68, 44)
        lblAccount.ForeColor = Color.White
        pbAccount.Image = My.Resources.accountPressed
        DefaultButton(pnlSearch, lblSearchBooks, pbSearch, My.Resources.search)
        DefaultButton(pnlLibrary, lblLibrary, pbLibrary, My.Resources.book)
        DefaultButton(pnlFines, lblFines, pbFines, My.Resources.peso)
    End Sub

    Private Sub pnlFines_Click(sender As Object, e As EventArgs) Handles pnlFines.Click, pbFines.Click, lblFines.Click

    End Sub

    Private Sub pnlLibrary_Click(sender As Object, e As EventArgs) Handles pnlLibrary.Click, pbLibrary.Click, lblLibrary.Click

    End Sub

    Private Sub pnlSearch_Click(sender As Object, e As EventArgs) Handles pnlSearch.Click, pbSearch.Click, lblSearchBooks.Click

    End Sub

    Private Sub pnlAccount_Click(sender As Object, e As EventArgs) Handles pnlAccount.Click, pbAccount.Click, lblAccount.Click

    End Sub
End Class