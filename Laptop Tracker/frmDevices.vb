Imports System.IO

Public Class frmDevices

    Private Sub frmDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim deviceFileLength = File.ReadAllLines("devices.csv").Length
        Dim device As New Devices
        Using sr As New StreamReader("devices.csv")
            For i = 0 To deviceFileLength - 1
                Dim deviceLine As String = sr.ReadLine
                Dim splitLine As String() = deviceLine.Split(",")
                With device
                    .id = splitLine(0)
                    .name = splitLine(1).Replace("&comma;", ",") 'Replaces the formatted comma to display correctly
                    .model = splitLine(2).Replace("&comma;", ",")
                    .serialNumber = splitLine(3).Replace("&comma;", ",")
                    .usage = splitLine(4).Replace("&comma;", ",")
                    grdDevices.Rows.Add(.id, .name, .model, .serialNumber, .usage)
                End With
            Next
        End Using
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        loadNewForm(Me, frmHome)
    End Sub

    Private Sub BookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingsToolStripMenuItem.Click
        loadNewForm(Me, frmBookings)
    End Sub

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click
        loadNewForm(Me, frmAddDevices)
    End Sub
End Class