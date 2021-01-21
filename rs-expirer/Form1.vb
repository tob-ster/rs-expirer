Public Class Form1
    Dim RoastDate As DateTime = Now
    Dim DataObject As DataObject

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        RoastDate = MonthCalendar1.SelectionStart
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ExpiryDate As DateTime = DateAdd("m", 18, RoastDate)
        Dim RoastDateString As String = FormatDateTime(RoastDate, DateFormat.ShortDate)
        Dim ExpiryDateString As String = FormatDateTime(ExpiryDate, DateFormat.ShortDate)
        With ListView1
            ListView1.AutoResizeColumns(True)
            ListView1.Items.Insert(0, RoastDateString)
            ListView1.Items.Insert(1, "__________")
            ListView1.Items.Insert(2, ExpiryDateString)
        End With
        With DataObject
            Clipboard.SetText(ExpiryDateString)
        End With
    End Sub
    Private Sub ListView1_Copy_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 0 Then Exit Sub
        Clipboard.SetText(ListView1.SelectedItems(0).Text)
    End Sub
End Class