Imports Device_Tracker.modStructures

Public Class frmHome 'Loads on start
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Launch application in maximized state if screen width is not greater than 1080px
        If Screen.PrimaryScreen.Bounds.Height > 1080 Then
            Width = Screen.PrimaryScreen.Bounds.Width * 0.75
            Height = Screen.PrimaryScreen.Bounds.Height * 0.75
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If

        'Create files if they don't already exist
        If Dir("bookings.csv") <> "" Then
            FileOpen(1, "bookings.csv", OpenMode.Append) 'Create
            FileClose(1)
        End If
        If Dir("devices.csv") <> "" Then
            FileOpen(1, "devices.csv", OpenMode.Append)
            FileClose(1)
        End If

    End Sub
    Private Sub btnDevices_Click(sender As Object, e As EventArgs) Handles btnDevices.Click
        loadNewForm(Me, frmDevices)
    End Sub

    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        loadNewForm(Me, frmBookings)
    End Sub
End Class
