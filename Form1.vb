Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim Year As Integer

        Integer.TryParse(txtYear.Text, Year)

        If Year Mod 4 = 0 And (Year Mod 100 <> 0 Or Year Mod 400 = 0) Then

            lbResult.Text = Year.ToString() & "is a leap year."
        Else
            lbResult.Text = Year.ToString() & "is not leap year."
        End If
    End Sub
End Class
