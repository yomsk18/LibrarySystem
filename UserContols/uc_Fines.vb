Public Class uc_Fines
    Private Sub uc_Fines_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbFine.Items.Add("12345: Over due")
        cbFine.Items.Add("54321: Over due")
        cbFine.Items.Add("67890: Damage book")
    End Sub
End Class
