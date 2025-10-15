Public Class FrmLibrarianLogin
    Private Sub VmButton1_Click(sender As Object, e As EventArgs) Handles VmButton1.Click
        Dim landingForm As New Landing()
        landingForm.Show()
        Me.Hide()
    End Sub
End Class