Public Module FormHelper
    Public lastLocation As Point

    Public Sub SwitchForm(currentForm As Form, newForm As Form)
        lastLocation = currentForm.Location
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = lastLocation

        newForm.Show()
        currentForm.Hide()
    End Sub

    Public Sub DefaultButton(pnl As Panel, lbl As Label, pb As PictureBox, pic As Image)
        pnl.BackColor = Color.FromArgb(191, 166, 136)
        lbl.ForeColor = Color.Black
        pb.Image = pic
    End Sub

End Module
