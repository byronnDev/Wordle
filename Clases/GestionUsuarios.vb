Imports System.IO
'toDo encriptar contraseñas
'toDo almacenar puntaje de usuarios
'toDo crear tabla de puntuaciones
'toDo getUsuario
'toDo getUsuarioContraseña
Public Class GestionUsuarios
    Private pathUsuarios As String = "./datos/usuarios.txt"
    Private pathPuntaje As String = "./datos/puntaje.txt"
    Private datosPuntaje() As String
    Private usuarios() As String
    Public Sub Gestion()
    End Sub
    Public Function agregarUsuario(usuario As String, contrasena As String) As String
        If Not File.Exists(pathUsuarios) Then
            Return Nothing
        End If
        usuarios = File.ReadAllLines(pathUsuarios)
        If usuarios.Contains(usuario & "*" & contrasena) Then
            Return Nothing
        End If
        Dim usuarioContrasena() As String = {usuario & "*" & contrasena}
        File.AppendAllLines(pathUsuarios, usuarioContrasena)
        Return "Usuario creado exitosamente"
    End Function
    Public Function listarUsuarios() As String()
        usuarios = File.ReadAllLines(pathUsuarios)
        Return usuarios
    End Function
End Class