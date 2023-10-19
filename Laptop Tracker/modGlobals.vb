Imports System.IO
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Security.Cryptography

Friend Module GlobalStructures
    Public Structure Devices 'Structure to hold device information
        Public id As Integer
        Public model As String
        Public name As String
        Public serialNumber As String
        Public status As String
    End Structure



    Public Structure Bookings ' Structure to hold booking information
        Public id As Integer
        Public dateStart As Date
        Public dateEnd As Date
        Public usedBy As String
        Public description As String
        Public deviceID As Integer
    End Structure

    Public Structure Users
        Public id As Integer
        Public email As String
        Public name As String
        Public password As String
        Public role As String
        Public isAdmin As String
        Public encryptionKeyString As String
    End Structure
End Module
Friend Module GlobalFunctions
    Public Function GetLastID(filename As String) 'gets last ID from a file and returns the next value
        If File.ReadLines(filename).Count <> 0 Then
            Dim lastLine = File.ReadLines(filename).Last()
            Dim lastLineSplit As String() = lastLine.Split(",")
            Return lastLineSplit(0) + 1
        Else
            Return 1
        End If
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

    Public Sub displayNavItems(mnuNav)
        For Each item In mnuNav.Items
            With item
                For Each restrictedForm In restrictedForms
                    If .Text = restrictedForm Then
                        If isUserAdmin = True Then
                            .visible = True
                        Else
                            .visible = False
                        End If
                    End If
                Next
            End With
        Next
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

    Public isUserAdmin As Boolean
    Public userName As String
    Public restrictedForms As New List(Of String) From {"Users", "Add Users"}

    Public NotInheritable Class Simple3Des
        Private TripleDes As New TripleDESCryptoServiceProvider
        Private Function TruncateHash(
    ByVal key As String,
    ByVal length As Integer) As Byte()

            Dim sha1 As New SHA1CryptoServiceProvider

            ' Hash the key.
            Dim keyBytes() As Byte =
                Text.Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)

            ' Truncate or pad the hash.
            ReDim Preserve hash(length - 1)
            Return hash
        End Function
        Sub New(ByVal key As String)
            ' Initialize the crypto provider.
            TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
        End Sub

        Public Function EncryptData(
    ByVal plaintext As String) As String

            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte =
                Text.Encoding.Unicode.GetBytes(plaintext)

            ' Create the stream.
            Dim ms As New MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms,
                TripleDes.CreateEncryptor(),
                CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string.
            Return Convert.ToBase64String(ms.ToArray)
        End Function

        Public Function DecryptData(
    ByVal encryptedtext As String) As String

            ' Convert the encrypted text string to a byte array.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

            ' Create the stream.
            Dim ms As New MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms,
                TripleDes.CreateDecryptor(),
                CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string.
            Return Text.Encoding.Unicode.GetString(ms.ToArray)
        End Function
    End Class





End Module
