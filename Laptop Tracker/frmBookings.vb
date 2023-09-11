Imports System.IO

Public Class frmBookings
    Private Sub btnAddBooking_Click(sender As Object, e As EventArgs) Handles btnAddBooking.Click
        loadNewForm(Me, frmAddBooking)

    End Sub

    Private Sub frmBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim deviceFileLength = File.ReadAllLines("bookings.csv").Length
        Dim booking As New Bookings
        Using sr As New StreamReader("bookings.csv")
            For i = 0 To deviceFileLength - 1
                Dim deviceLine As String = sr.ReadLine
                Dim splitLine As String() = deviceLine.Split(",")
                With booking
                    .id = splitLine(0)
                    .dateStart = splitLine(1)
                    .dateEnd = splitLine(2)
                    .usedBy = splitLine(3).Replace("&comma;", ",") 'Replaces the formatted comma to display correctly
                    .description = splitLine(4).Replace("&comma;", ",")
                    .deviceID = splitLine(5)
                    grdBookings.Rows.Add(.id, .dateStart.ToShortDateString, .dateEnd.ToShortDateString, .usedBy, .description, .deviceID)
                End With
            Next
        End Using
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        loadNewForm(Me, frmHome)
    End Sub

    Private Sub DevicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevicesToolStripMenuItem.Click
        loadNewForm(Me, frmDevices)

    End Sub

End Class