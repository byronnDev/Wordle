Imports Clases
Imports Forms
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class WordleTest

    <TestMethod()>
    Public Sub EncryptTest()
        Dim password As String = "password123"
        Dim expected As String = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f"
        Dim testUser As Usuario = New Usuario("test", password)
        Dim actual As String = testUser.Encrypt(password)
        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod()>
    Public Sub EncryptTestFail()
        Dim password As String = "password1234"
        Dim expected As String = "ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f"
        Dim testUser As Usuario = New Usuario("test", password)
        Dim actual As String = testUser.Encrypt(password)
        Assert.AreEqual(expected, actual)
    End Sub

End Class