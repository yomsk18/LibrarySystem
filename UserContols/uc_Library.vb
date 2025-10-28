Public Class uc_Library
    Private Sub Form_Load1(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBooksRented.Rows.Add("The Great Gatsby", "F. Scott Fitzgerald", "Literature", "9780743273565", "8")
        dgvBooksRented.Rows.Add("To Kill a Mockingbird", "Harper Lee", "Fiction", "9780061120084", "5")
        dgvBooksRented.Rows.Add("1984", "George Orwell", "Dystopian", "9780451524935", "12")

        With dgvBooksRented
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
End Class
