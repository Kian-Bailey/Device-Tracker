Imports System.IO

Public Class frmAddDevices
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Check if all necessary fields are filled
        If txtModel.Text = "" Or txtName.Text = "" Or txtSerialNumber.Text = "" Or comUsage.Text = "" Then
            MsgBox("Error: Empty Fields." & vbNewLine &
                   "Please make sure you have filled in all of the fields" & vbNewLine &
                   "The device has NOT been saved.", MsgBoxStyle.Critical, "Error")
            resetFields()
            Exit Sub
        End If
        Dim device As New Devices
        Dim sw As New StreamWriter("devices.csv", True)
        With device
            .id = txtDeviceID.Text
            .model = txtModel.Text.Replace(",", "&comma;") 'Ensures that the format of the CSV functions correctly
            .name = txtName.Text.Replace(",", "&comma;")
            .serialNumber = txtSerialNumber.Text.Replace(",", "&comma;")
            .usage = comUsage.Text.Replace(",", "&comma;")

            'Converts the fields into a formatted string
            Dim lineOutput As String = $"{ .id },{ .model },{ .name },{ .serialNumber },{ .usage}"
            sw.WriteLine(lineOutput) 'Writes the line to the file


        End With
        MsgBox("Device Added")
        sw.Close()
        resetFields()
    End Sub

    Private Sub frmAddDevices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayNavItems(mnuNav)
        resetFields()
    End Sub

    Private Sub resetFields() 'resets all input fields and loads default values
        txtDeviceID.Text = GetLastID("devices.csv")
        txtModel.Text = ""
        txtName.Text = ""
        txtSerialNumber.Text = ""
        comUsage.SelectedIndex = -1
    End Sub

    Private Sub DevicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevicesToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        loadNewForm(Me, frmDevices)
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        loadNewForm(Me, frmHome)
    End Sub

    Private Sub BookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookingsToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        loadNewForm(Me, frmBookings)
    End Sub

    Private Sub btnNavPrev_Click(sender As Object, e As EventArgs) Handles btnNavPrev.Click
        NavigationFunctions.btnNavPrev_Click(Me)
    End Sub

    Private Sub btnNavNext_Click(sender As Object, e As EventArgs) Handles btnNavNext.Click
        NavigationFunctions.btnNavNext_Click(Me)
    End Sub

    Public Sub updateNavButtons()
        With btnNavPrev
            If navStackPrev.Count < 1 Then
                .Enabled = False
                .BackColor = Color.Gray
                navStackPrev.Clear()
            Else
                .Enabled = True
                .BackColor = Color.FromArgb(44, 158, 221)
            End If
        End With
        With btnNavNext
            If navStackNext.Count = 0 OrElse navStackNext.Peek.Name = Name Then
                .Enabled = False
                .BackColor = Color.Gray
                navStackNext.Clear()
            Else
                .Enabled = True
                .BackColor = Color.FromArgb(44, 158, 221)
            End If
        End With
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        navStackPrev.Push([GetType])
        navStackNext.Clear()
        loadNewForm(Me, frmUsers)
    End Sub
End Class