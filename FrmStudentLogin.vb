Public Class FrmStudentLogin
    Private Sub VmButton1_Click(sender As Object, e As EventArgs) Handles VmButton1.Click
        Dim landingForm As New Landing()
        landingForm.Show()
        Me.Hide()
    End Sub

    Private Sub lblForgetPass_MouseHover(sender As Object, e As EventArgs) Handles lblForgetPass.MouseHover
        lblForgetPass.ForeColor = Color.Blue
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub lblForgetPass_MouseLeave(sender As Object, e As EventArgs) Handles lblForgetPass.MouseLeave
        lblForgetPass.ForeColor = Color.Black
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub lblForgetPass_Click(sender As Object, e As EventArgs) Handles lblForgetPass.Click
        RJMessageBox.Show("Please contact the librarian to reset your password. Bring reg form and ID", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class