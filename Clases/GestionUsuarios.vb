Imports System.IO
Public Class GestionUsuarios
    Private pathUsers As String = "./datos/usuarios.txt" ' Path del fichero donde se almacenan los usuarios
    Private users As List(Of Usuario) ' Lista de usuarios almacenados en ./datos/usuarios.txt
    Public Sub New()
        ' Inicializamos la lista de usuarios
        users = New List(Of Usuario)
        ' Si no existe el fichero de usuarios, lo creamos
        If File.Exists(pathUsers) Then
            ' Creamos un Array con todos los datos de todos los usuarios
            Dim tempDatos As String() = File.ReadAllLines(pathUsers)
            For Each datos In tempDatos
                users.Add(New Usuario(datos.Split("*")(0), datos.Split("*")(1), datos.Split("*")(2), datos.Split("*")(3) & vbCrLf))
            Next
        End If
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

    Public Function ListarUsuarios() As List(Of Usuario) ' Devuelve la lista de usuarios actual
        'Devuelve la lista de usuarios actual
        Return users
    End Function
    Public Function BuscarUsuario(nombreUsuario As String) As Usuario ' Busca un usuario por su nombre
        Dim tempUser As New Usuario(nombreUsuario)
        Dim posicion As Integer = users.IndexOf(tempUser)
        If posicion = -1 Then ' Si no encuentra el usuario
            Return Nothing ' Devuelve Nothing
        End If
        ' Si lo encuentra, lo devuelve
        Return users(posicion)
    End Function
    Public Sub SumarPunto(user As Usuario, puntos As Integer) ' Suma puntos al usuario
        Dim posicion = users.IndexOf(user)
        If posicion = -1 Then
            Exit Sub
        End If
        users(posicion).Puntos += puntos
        File.WriteAllLines(pathUsers, users.Select(Function(x) x.ToString)) ' Guardamos los cambios en el fichero
    End Sub
    Public Sub AnadirWin(user As Usuario) ' Añade una victoria al usuario
        Dim posicion = users.IndexOf(user)
        If posicion = -1 Then
            Exit Sub
        End If
        users(posicion).Wins += 1
        File.WriteAllLines(pathUsers, users.Select(Function(x) x.ToString)) ' Guardamos los cambios en el fichero
    End Sub
    Public Function Clasificados() As List(Of Usuario)
        Dim tempArray As New List(Of Usuario)
        Dim maxPuntos As Integer
        Dim maxUser As Usuario
        Do Until tempArray.ToArray.Length = 10 OrElse tempArray.ToArray.Length = users.ToArray.Length
            maxPuntos = Integer.MinValue
            For Each user In users
                If user.Puntos > maxPuntos AndAlso Not tempArray.Contains(user) Then
                    maxPuntos = user.Puntos
                    maxUser = user
                End If
            Next
            tempArray.Add(maxUser)
        Loop
        Return tempArray
    End Function
End Class