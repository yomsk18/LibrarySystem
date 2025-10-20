Public Class Landing
    Private Sub Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim iconPath As String = IO.Path.Combine(Application.StartupPath, "Assets", "icons", "library.png")
    End Sub

    Private Sub btnLibrarian_Click(sender As Object, e As EventArgs) Handles btnLibrarian.Click
        SwitchForm(Me, New FrmLibrarianLogin())
    End Sub

    Private Sub VmButton1_Click(sender As Object, e As EventArgs) Handles VmButton1.Click
        SwitchForm(Me, New FrmStudentLogin())
    End Sub
End Class
