Imports System.IO
Module modStructures
    Structure Devices 'Structure to hold device information
        Dim id As Integer
        Dim model As String
        Dim name As String
        Dim serialNumber As String
        Dim usage As String
    End Structure

    Structure Bookings ' Structure to hold booking information
        Dim id As Integer
        Dim dateStart As Date
        Dim dateEnd As Date
        Dim usedBy As String
        Dim description As String
        Dim deviceID As Integer
    End Structure

    Public Function GetLastID(filename As String) 'gets last ID from a file and returns the next value
        Dim lastLine = File.ReadLines(filename).Last()
        Dim lastLineSplit As String() = lastLine.Split(",")
        Return (lastLineSplit(0) + 1)
    End Function

    Public Sub loadNewForm(previousForm, newForm) 'loads a new form while preserving the previous form's state
        With newForm
            .Show()
            .WindowState = previousForm.WindowState
            .Height = previousForm.Height
            .Width = previousForm.Width
            .Left = previousForm.Left
            .Top = previousForm.Top
        End With
        previousForm.Close()
    End Sub
End Module
