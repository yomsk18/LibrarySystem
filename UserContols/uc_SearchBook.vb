Public Class uc_SearchBook
    Private Sub Form_Load1(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBooks.Rows.Add("The Great Gatsby", "F. Scott Fitzgerald", "Literature", "9780743273565", "8")
        dgvBooks.Rows.Add("To Kill a Mockingbird", "Harper Lee", "Fiction", "9780061120084", "5")
        dgvBooks.Rows.Add("1984", "George Orwell", "Dystopian", "9780451524935", "12")
        dgvBooks.Rows.Add("Atomic Habits", "James Clear", "Self-Help", "9780735211292", "10")
        dgvBooks.Rows.Add("The Hobbit", "J.R.R. Tolkien", "Fantasy", "9780547928227", "7")


        With dgvBooks
            ' Remove borders and grid lines
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .GridColor = Color.FromArgb(64, 64, 64)

            ' Header styling
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 68, 44)   ' dark red
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .ColumnHeadersHeight = 35
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

            ' Row styling
            .DefaultCellStyle.BackColor = Color.FromArgb(191, 166, 136)
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 60, 60)
            .DefaultCellStyle.SelectionForeColor = Color.White
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Background
            .BackgroundColor = Color.FromArgb(191, 166, 136)
            .RowHeadersVisible = False

            ' Columns fit nicely
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AllowUserToResizeRows = False
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With
    End Sub

    Private Sub btnBarrow_Click(sender As Object, e As EventArgs) Handles btnBarrow.Click
        ' Check if any rows are selected
        If dgvBooks.SelectedRows.Count > 0 Then
            Dim message As String = "📚 Selected Books:" & vbCrLf & vbCrLf

            ' Loop through each selected row
            For Each row As DataGridViewRow In dgvBooks.SelectedRows
                Dim title As String = row.Cells("TITLE").Value.ToString()
                Dim author As String = row.Cells("AUTHOR").Value.ToString()
                Dim category As String = row.Cells("CATEGORY").Value.ToString()
                Dim isbn As String = row.Cells("ISBN").Value.ToString()
                Dim stocks As String = row.Cells("STOCKS").Value.ToString()

                message &= $"Title: {title}" & vbCrLf &
                            $"Author: {author}" & vbCrLf &
                            $"Category: {category}" & vbCrLf &
                            $"ISBN: {isbn}" & vbCrLf &
                            $"Stocks: {stocks}" & vbCrLf &
                            "------------------------------" & vbCrLf
            Next

            ' Show message
            RJMessageBox.Show(message, "Selected Books", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            RJMessageBox.Show("Please select at least one row.")
        End If
    End Sub
End Class
