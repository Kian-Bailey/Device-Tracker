Imports System.IO

Public Class frmStartup
    Private Sub frmStartup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePaths As String() = {
            "bookings.csv",
            "devices.csv"
        }

        For Each filePath In filePaths
            If Not File.Exists(filePath) Then
                Dim fileStream As FileStream = File.Create(filePath)
                fileStream.Close()
            End If
        Next

        'Launch application in maximized state if screen width is not greater than 1080px
        With frmHome
            If Screen.PrimaryScreen.Bounds.Height > 1080 Then
                .Width = Screen.PrimaryScreen.Bounds.Width * 0.75
                .Height = Screen.PrimaryScreen.Bounds.Height * 0.75
                .WindowState = FormWindowState.Normal
            Else
                .WindowState = FormWindowState.Maximized
            End If
            .updateNavButtons()
            .Show()
        End With
        Close()
    End Sub
End Class