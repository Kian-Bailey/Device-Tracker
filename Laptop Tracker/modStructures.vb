Imports System.IO

Friend Module GlobalStructures
    Public Structure Devices 'Structure to hold device information
        Public id As Integer
        Public model As String
        Public name As String
        Public serialNumber As String
        Public usage As String
    End Structure

    Public Structure Bookings ' Structure to hold booking information
        Public id As Integer
        Public dateStart As Date
        Public dateEnd As Date
        Public usedBy As String
        Public description As String
        Public deviceID As Integer
    End Structure
End Module
Friend Module GlobalFunctions
    Public Function GetLastID(filename As String) 'gets last ID from a file and returns the next value
        Dim lastLine = File.ReadLines(filename).Last()
        Dim lastLineSplit As String() = lastLine.Split(",")
        Return lastLineSplit(0) + 1
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
        previousForm.close()
        newForm.updateNavButtons()
    End Sub

    Public navStackPrev As New Stack(Of Type)
    Public navStackNext As New Stack(Of Type)

    Public Class NavigationFunctions
        Public Shared Sub btnNavPrev_Click(currentForm)
            Dim newForm As Type = navStackPrev.Pop()
            navStackNext.Push(currentForm.GetType)
            loadNewForm(currentForm, CType(Activator.CreateInstance(newForm), Form))
        End Sub
        Public Shared Sub btnNavNext_Click(currentForm)
            Dim newForm As Type = navStackNext.Pop()
            navStackPrev.Push(currentForm.GetType)
            loadNewForm(currentForm, CType(Activator.CreateInstance(newForm), Form))
        End Sub
    End Class


End Module
