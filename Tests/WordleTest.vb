Imports Clases
Imports Forms
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.IO

<TestClass()> Public Class WordleTest
    'Usuarios
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

    'Gestion
    <TestMethod()>
    Public Sub RegistrarUsuarioTest()
        Dim gestion As New GestionUsuarios()
        Dim actual As String = gestion.RegistrarUsuario("test", "password123")
        Dim expected As String = Nothing 'Devuelve nothing porque ya existe el usuario, ya que sino crea el usuario
        Assert.AreEqual(expected, actual)
    End Sub
    <TestMethod()>
    Public Sub RegistrarUsuarioTestFail()
        Dim gestion As New GestionUsuarios()
        Dim actual As String = gestion.RegistrarUsuario("test", "password123")
        Dim notExpected As String = Nothing 'Devuelve nothing porque ya existe el usuario, ya que sino crea el usuario
        Assert.AreNotEqual(notExpected, actual) ' Comprobamos que no sea nothing
    End Sub

    <TestMethod()>
    Public Sub ListarUsuariosTest()
        Dim gestion As New GestionUsuarios()
        Dim actual As Integer = gestion.ListarUsuarios().Count ' Comprobamos que la lista no esté vacía
        Dim notExpected As Integer = 0
        Assert.AreNotEqual(notExpected, actual)
    End Sub
    <TestMethod()>
    Public Sub ListarUsuariosTestFail()
        Dim gestion As New GestionUsuarios()
        Dim actual As Integer = gestion.ListarUsuarios().Count ' Comprobamos que la lista no esté vacía
        Dim expected As Integer = 0
        Assert.AreEqual(expected, actual)
    End Sub
    <TestMethod()>
    Public Sub BuscarUsuarioTest()
        Dim gestion As New GestionUsuarios()
        Dim actual As Usuario = gestion.BuscarUsuario("test")
        Dim notExpected As Usuario = Nothing
        ' Comprobamos que el usuario no sea nothing
        Assert.AreNotEqual(notExpected, actual)
    End Sub
    <TestMethod()>
    Public Sub BuscarUsuarioTestFail()
        Dim gestion As New GestionUsuarios()
        Dim actual As Usuario = gestion.BuscarUsuario("test")
        Dim expected As Usuario = Nothing
        ' Comprobamos que el usuario sea nothing
        Assert.AreEqual(expected, actual)
    End Sub

    ' Formulario Principal
End Class