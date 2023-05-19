Imports Clases
Imports Forms
Imports System.IO

<TestClass()> Public Class WordleTest
    'Usuarios
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
        Dim actual As Usuario = gestion.BuscarUsuario("admin")
        Dim notExpected As Usuario = Nothing
        ' Comprobamos que el usuario no sea nothing
        Assert.AreNotEqual(notExpected, actual)
    End Sub
    <TestMethod()>
    Public Sub BuscarUsuarioTestFail()
        Dim gestion As New GestionUsuarios()
        Dim actual As Usuario = gestion.BuscarUsuario("admin")
        Dim expected As Usuario = Nothing
        ' Comprobamos que el usuario sea nothing
        Assert.AreEqual(expected, actual)
    End Sub

    ' Comprobar si los archivos existen
    <TestMethod()>
    Public Sub ComprobarFicheros()
        Dim pathPalabras As String = "./datos/palabras.txt"
        Dim pathUsuarios As String = "./datos/usuarios.txt"
        If File.Exists(pathPalabras) AndAlso File.Exists(pathUsuarios) Then
            Assert.IsTrue(True)
        Else
            Assert.IsTrue(False)
        End If
    End Sub

    <TestMethod()>
    Public Sub ComprobarFicherosFail()
        Dim pathPalabras As String = "./datos/palabrass.txt"
        Dim pathUsuarios As String = "./datos/usuarioss.txt"
        If File.Exists(pathPalabras) AndAlso File.Exists(pathUsuarios) Then
            Assert.IsTrue(True)
        Else
            Assert.IsTrue(False)
        End If
    End Sub
    ' Comprobar que los usuarios tienen la información correcta
    <TestMethod()>
    Public Sub ComprobarUsuarios()
        Dim pathUsuarios As String = "./datos/usuarios.txt"
        Dim usuarios As String()
        usuarios = File.ReadAllLines(pathUsuarios)
        For Each usuario As String In usuarios
            Dim datos As String() = usuario.Split("*")
            Dim nombre As String = datos(0)
            Dim password As String = datos(1)
            Dim actual As Usuario = New Usuario(nombre, password)
            Dim expected As Usuario = New Usuario(nombre, password)
            Assert.AreEqual(expected.Username, actual.Username)
            Assert.AreEqual(expected.Password, actual.Password)
        Next
    End Sub
    <TestMethod()>
    Public Sub ComprobarUsuariosFail()
        Dim pathUsuarios As String = "./datos/usuarios.txt"
        Dim usuarios As String()
        usuarios = File.ReadAllLines(pathUsuarios)
        For Each usuario As String In usuarios
            Dim datos As String() = usuario.Split("*")
            Dim nombre As String = datos(0)
            Dim password As String = datos(1)
            Dim actual As Usuario = New Usuario(nombre, password)
            Dim expected As Usuario = New Usuario("Roberto", password)
            Assert.AreEqual(expected.Username, actual.Username)
            Assert.AreEqual(expected.Password, actual.Password)
        Next
    End Sub

    ' Comprobar que el fichero palabras tiene los carácteres adecuados
    <TestMethod()>
    Public Sub ComprobarPalabras()
        Dim pathPalabras As String = "./datos/palabras.txt"
        Dim palabras As String()
        Dim expected As Integer = 5
        palabras = File.ReadAllLines(pathPalabras)
        For Each palabra As String In palabras
            Dim actual As String = palabra
            Assert.AreEqual(expected, actual.Length)
        Next
    End Sub
    <TestMethod()>
    Public Sub ComprobarPalabrasFail()
        Dim pathPalabras As String = "./datos/palabras.txt"
        Dim palabras As String()
        Dim expected As Integer = 6
        palabras = File.ReadAllLines(pathPalabras)
        For Each palabra As String In palabras
            Dim actual As String = palabra
            Assert.AreEqual(expected, actual.Length)
        Next
    End Sub
End Class