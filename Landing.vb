Public Class Landing
    Private Sub Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim iconPath As String = IO.Path.Combine(Application.StartupPath, "Assets", "icons", "library.png")
    End Sub

    Private Sub btnLibrarian_Click(sender As Object, e As EventArgs) Handles btnLibrarian.Click
        Dim loginForm As New FrmLibrarianLogin()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub VmButton1_Click(sender As Object, e As EventArgs) Handles VmButton1.Click
        Dim loginForm As New FrmStudentLogin()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub VmButton2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
