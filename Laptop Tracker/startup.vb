Public Class startup
    Sub Main()
        If Dir("bookings.csv") <> "" Then
            FileOpen(1, "bookings.csv", OpenMode.Append)
            WriteLine(1, Nothing)
            FileClose(1)
        End If
        If Dir("devices.csv") <> "" Then
            FileOpen(1, "devices.csv", OpenMode.Append)
            WriteLine(1, Nothing)
            FileClose(1)
        End If

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
        End With
    End Sub
End Class
