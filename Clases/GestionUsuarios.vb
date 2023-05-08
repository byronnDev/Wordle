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
    ' Devuelve una lista con los 10 usuarios con mas puntos/wins ordenados de mayor a menor
    Public Function Clasificados(puntos As Boolean) As List(Of Usuario)
        Dim tempArray As New List(Of Usuario)
        Dim maxNum As Integer
        Dim maxUser As Usuario
        Dim cantidadUsuarios As Integer = 10
        ' Repetimos el bucle hasta que la lista tenga 10 usuarios o hasta que no queden mas usuarios
        Do Until tempArray.ToArray.Length = cantidadUsuarios OrElse tempArray.ToArray.Length = users.ToArray.Length
            maxNum = Integer.MinValue
            ' Buscamos el usuario con mas puntos/wins
            For Each user In users
                If puntos Then
                    ' Si el usuario tiene mas puntos que el maximo y no está en la lista, se convierte en el maximo
                    If user.Puntos > maxNum AndAlso Not tempArray.Contains(user) Then
                        maxNum = user.Puntos
                        maxUser = user
                    End If
                Else
                    ' Si el usuario tiene mas wins que el maximo y no está en la lista, se convierte en el maximo
                    If user.Wins > maxNum AndAlso Not tempArray.Contains(user) Then
                        maxNum = user.Wins
                        maxUser = user
                    End If
                End If
            Next
            tempArray.Add(maxUser) ' Añadimos el usuario con mas puntos/wins a la lista
        Loop
        Return tempArray
    End Function
End Class