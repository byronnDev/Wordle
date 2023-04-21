Imports System.IO
'toDo encriptar contraseñas
'toDo almacenar puntaje de usuarios
'toDo crear tabla de puntuaciones
'toDo getUsuario
'toDo getUsuarioContraseña
Public Class GestionUsuarios
    Private pathUsers As String = "./datos/usuarios.txt"
    Private users As List(Of Usuario)
    Public Sub New()
        ' Creamos un Array con todos los datos de todos los usuarios
        Dim tempDatos As String() = File.ReadAllLines(pathUsers)
        Dim datosSplit As List(Of String) = New List(Of String)
        users = New List(Of Usuario)
        For Each datos In tempDatos
            datos.Split("*")
            datosSplit.AddRange(datos.Split("*"))
        Next
        For i = 0 To datosSplit.ToArray.Length - 1 Step 4
            ' Agregamos a la lista de usuarios todos lo usuarios almacenados en el documento
            users.Add(New Usuario(datosSplit(i), datosSplit(i + 1), datosSplit(i + 2), datosSplit(i + 3)))
        Next
    End Sub
    Public Function RegistrarUsuario(usuario As String, contrasena As String) As String
        Dim tempUser As New Usuario(usuario, contrasena) ' Creamos un usuario auxiliar
        If users.Contains(tempUser) Then ' Comprobamos si no existe el usuario
            Return Nothing
        End If
        ' Agregamos el usuario a la lista de usuarios
        users.Add(tempUser)
        ' Agregamos el usuario al fichero donde estára su contraseña
        File.AppendAllLines(pathUsers, {tempUser.ToString})
        Return "Usuario registrado correctamente"
    End Function

    Public Function ListarUsuarios() As List(Of Usuario)
        Return users
    End Function
    Public Function GetUser(nombreUsuario As String) As Usuario
        Dim tempUser As New Usuario(nombreUsuario)
        Dim posicion As Integer = users.IndexOf(tempUser)
        If posicion = -1 Then ' Si no encuentra el usuario
            Return Nothing ' Devuelve Nothing
        End If
        ' Si lo encuentra, lo devuelve
        Return users(posicion)
    End Function
    Public Function GetScore(nombreUsuario As String) As Integer
        Dim tempUser As Usuario = New Usuario(nombreUsuario) ' Creo un usuairo temporal
        Dim position As Integer = users.IndexOf(tempUser) ' Busca al usuario, devuelve -1 si no lo encuentra
        If position = -1 Then ' Si no encuentra al usuario
            Return Nothing 'Devuelve nothing
        End If
        Return users(position).Score ' Devuelve la puntuación
    End Function


End Class