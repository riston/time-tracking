Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, EventLabel.Click, Label2.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker.ValueChanged
        Dim dateTime As DateTime = DateTimePicker.Value

        If DateDiff("s", dateTime, Now) < 0 Then
            ' Picked is later than Now
            Timer1.Enabled = True
        Else
            ' Now is later than picked
            MessageBox.Show("Vali aeg tulevikust, mitte minevikust!")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker.Enabled = False

        Dim currentDateTime As DateTime = TimeOfDay
        Dim dateTime As DateTime = DateTimePicker.Value
        Dim diff As TimeSpan = dateTime.Subtract(Now)

        EventLabel.Text = diff.Days.ToString + " päeva " +
            diff.Hours.ToString + " tundi " +
            diff.Minutes.ToString + " minutit " +
            diff.Seconds.ToString + " sekundit"


    End Sub
End Class
