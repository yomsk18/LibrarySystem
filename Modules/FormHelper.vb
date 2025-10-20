Public Module FormHelper
    Public lastLocation As Point

    Public Sub SwitchForm(currentForm As Form, newForm As Form)
        lastLocation = currentForm.Location
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = lastLocation

        newForm.Show()
        currentForm.Hide()
    End Sub

End Module
