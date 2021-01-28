Public Class Form1
    Dim RoastDate As Date = Today
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        RoastDate = MonthCalendar1.SelectionStart
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ExpiryDate As Date = DateAdd("m", 18, RoastDate)
        Me.ListView1.Items.Add(RoastDate.ToString).SubItems.AddRange({"+ 18 Monate", ExpiryDate})
        Clipboard.SetText(ExpiryDate)
    End Sub
    Private Sub ListView1_Copy_Click(sender As Object, e As EventArgs) Handles ListView1.Click, ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 0 Then Exit Sub
        Clipboard.SetText(ListView1.SelectedItems(0).SubItems(2).Text)
    End Sub
End Class