Imports Device_Tracker

<TestClass>
Public Class LoginTests

    <TestMethod> Public Sub ValidLoginData1()
        ' Arrange
        Dim loginForm As New frmLogin
        Dim email As String = LoginData.validEmail1
        Dim password As String = LoginData.validPassword1

        ' Act
        Dim result As Boolean = loginForm.verifyLoginDetails(email, password)

        ' Assert
        Assert.IsTrue(result, $"Login should be successful for Email: {email}, Password: {password}.")
    End Sub

    <TestMethod> Public Sub validLoginData2()
        ' Arrange
        Dim loginForm As New frmLogin
        Dim email As String = LoginData.validEmail2
        Dim password As String = LoginData.validPassword2

        ' Act
        Dim result As Boolean = loginForm.verifyLoginDetails(email, password)

        ' Assert
        Assert.IsTrue(result, $"Login should be successful for Email: {email}, Password: {password}.")
    End Sub

    <TestMethod> Public Sub validDataSwapped1()
        ' Arrange
        Dim loginForm As New frmLogin
        Dim email As String = LoginData.validEmail1
        Dim password As String = LoginData.validPassword2

        ' Act
        Dim result As Boolean = loginForm.verifyLoginDetails(email, password)

        ' Assert
        Assert.IsFalse(result, $"Login should not be successful for Email: {email}, Password: {password}.")
    End Sub

    <TestMethod> Public Sub validDataSwapped2()
        ' Arrange
        Dim loginForm As New frmLogin
        Dim email As String = LoginData.validEmail2
        Dim password As String = LoginData.validEmail1

        ' Act
        Dim result As Boolean = loginForm.verifyLoginDetails(email, password)

        ' Assert
        Assert.IsFalse(result, $"Login should not be successful for Email: {email}, Password: {password}.")
    End Sub

    <TestMethod> Public Sub invalidData()
        ' Arrange
        Dim loginForm As New frmLogin
        Dim email As String = LoginData.invalidEmail
        Dim password As String = LoginData.invalidPassword

        ' Act
        Dim result As Boolean = loginForm.verifyLoginDetails(email, password)

        ' Assert
        Assert.IsFalse(result, $"Login should not be successful for Email: {email}, Password: {password}.")
    End Sub

    <TestMethod> Public Sub emptyData()
        ' Arrange
        Dim loginForm As New frmLogin
        Dim email As String = LoginData.emptyEmail
        Dim password As String = LoginData.emptyPassword

        ' Act
        Dim result As Boolean = loginForm.verifyLoginDetails(email, password)

        ' Assert
        Assert.IsFalse(result, $"Login should not be successful for Email: {email}, Password: {password}.")
    End Sub

    <TestMethod> Public Sub incorrectEmailCasing()
        ' Arrange
        Dim loginForm As New frmLogin
        Dim email As String = LoginData.validEmailIncorrectCasing
        Dim password As String = LoginData.validPassword1

        ' Act
        Dim result As Boolean = loginForm.verifyLoginDetails(email, password)

        ' Assert
        Assert.IsTrue(result, $"Login should be successful for Email: {email}, Password: {password}.")
    End Sub

    <TestMethod> Public Sub incorrectPasswordCasing()
        ' Arrange
        Dim loginForm As New frmLogin
        Dim email As String = LoginData.validEmail1
        Dim password As String = LoginData.validPasswordIncorrectCasing

        ' Act
        Dim result As Boolean = loginForm.verifyLoginDetails(email, password)

        ' Assert
        Assert.IsFalse(result, $"Login should be not successful for Email: {email}, Password: {password}.")
    End Sub


    <TestMethod> Public Sub specialCharacterPassword()
        ' Arrange
        Dim loginForm As New frmLogin
        Dim email As String = LoginData.validEmailSpecialCharacter
        Dim password As String = LoginData.validPasswordSpecialCharacter

        ' Act
        Dim result As Boolean = loginForm.verifyLoginDetails(email, password)

        ' Assert
        Assert.IsTrue(result, $"Login should be successful for Email: {email}, Password: {password}.")
    End Sub

    <TestMethod> Public Sub TestConcurrentLogins()
        Dim loginForm As New frmLogin
        Dim email = LoginData.validEmail1
        Dim password = LoginData.validPassword1
        Dim loginAttempts As Integer = 10 ' Number of concurrent login attempts

        ' Create an array to store the results of each login attempt
        Dim results(loginAttempts - 1) As Boolean

        ' Simulate concurrent login attempts
        Parallel.For(0, loginAttempts, Sub(i)
                                           results(i) = loginForm.verifyLoginDetails(email, password)
                                       End Sub)

        ' Assert that all concurrent login attempts are successful
        For Each result In results
            Assert.IsTrue(result, "Concurrent login should be successful.")
        Next
    End Sub



End Class

Public Class LoginData
    Public Shared ReadOnly validEmail1 As String = "kian.bailey@sharpfutures.org.uk"
    Public Shared ReadOnly validPassword1 As String = "Password123!"

    Public Shared ReadOnly validEmail2 As String = "test@gmail.com"
    Public Shared ReadOnly validPassword2 As String = ",pass,word,"

    Public Shared ReadOnly invalidEmail As String = "invalid@email.com"
    Public Shared ReadOnly invalidPassword As String = "invalidPassword"

    Public Shared ReadOnly emptyEmail As String = ""
    Public Shared ReadOnly emptyPassword As String = ""

    Public Shared ReadOnly validEmailIncorrectCasing As String = "kIan.baiLey@SharpFutuRes.org.uk"
    Public Shared ReadOnly validPasswordIncorrectCasing As String = "PassWorD123!"

    Public Shared ReadOnly validEmailSpecialCharacter As String = "test@gmail.com"
    Public Shared ReadOnly validPasswordSpecialCharacter As String = ",pass,word,"

End Class
