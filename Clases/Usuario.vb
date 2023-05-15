Imports System.IO
Imports System.Security.Cryptography
Imports System.Security.Policy
Imports System.Text
'toDo Solucionar error de inicio detecta la password la intenta castear a double
Public Class Usuario
    Implements IEquatable(Of Usuario)

    Public Property Username As String
    Public Property Password As String
    Public Property Puntos As Integer
    Public Property Wins As Integer

    Public Sub New()
    End Sub

    Public Sub New(usernme As String, password As String, intentos As Integer, wins As Integer)
        Me._Username = usernme
        Me._Password = Encrypt(password)
        Me._Puntos = intentos
        Me._Wins = wins
    End Sub
    Public Sub New(username As String, password As String)
        Me._Username = username
        Me._Password = Encrypt(password)
        Me._Puntos = 0
        Me._Wins = 0
    End Sub
    Public Sub New(username As String)
        Me._Username = username
    End Sub
    ' TODO: Solucionar problema encriptado
    Public Shared Function Encrypt(password As String) As String
        ' Define la clave a usar para encriptar y desencriptar contraseñas
        Dim key As String = "m1Cl4v3S3gur4d312345678901234567"

        ' Crea una instancia de la clase Aes
        Using aes As Aes = Aes.Create()
            ' Establece la clave y el vector de inicialización
            aes.Key = Encoding.UTF8.GetBytes(key)
            aes.IV = New Byte(15) {}

            ' Crea una instancia de la clase MemoryStream para almacenar los datos cifrados
            Using memoryStream As New MemoryStream()
                ' Crea una instancia de la clase CryptoStream para cifrar los datos
                Using cryptoStream As New CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write)
                    ' Convierte la contraseña en un arreglo de bytes
                    Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
                    ' Escribe los datos cifrados en el MemoryStream
                    cryptoStream.Write(bytes, 0, bytes.Length)
                End Using

                ' Devuelve los datos cifrados como una cadena de texto en base64
                Return Convert.ToBase64String(memoryStream.ToArray())
            End Using
        End Using
    End Function

    Public Shared Function Decrypt(encryptedPassword As String) As String
        ' Define la clave a usar para encriptar y desencriptar contraseñas
        Dim key As String = "m1Cl4v3S3gur4d312345678901234567"

        ' Crea una instancia de la clase Aes
        Using aes As Aes = Aes.Create()
            ' Establece la clave y el vector de inicialización
            aes.Key = Encoding.UTF8.GetBytes(key)
            aes.IV = New Byte(15) {}

            ' Convierte la contraseña encriptada en un arreglo de bytes
            Dim bytes As Byte() = Convert.FromBase64String(encryptedPassword)

            ' Crea una instancia de la clase MemoryStream para leer los datos cifrados
            Using memoryStream As New MemoryStream(bytes)
                ' Crea una instancia de la clase CryptoStream para descifrar los datos
                Using cryptoStream As New CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read)
                    ' Crea un arreglo de bytes para almacenar los datos descifrados
                    Dim decryptedBytes(bytes.Length - 1) As Byte
                    ' Lee los datos descifrados del CryptoStream
                    Dim count As Integer = cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length)
                    ' Devuelve los datos descifrados como una cadena de texto
                    Return Encoding.UTF8.GetString(decryptedBytes, 0, count)
                End Using
            End Using
        End Using
    End Function

    Public Overrides Function ToString() As String
        Return _Username & "*" & _Password & "*" & _Puntos & "*" & _Wins ' To String para luego utilizarlo a la hora de agregar al fichero
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Usuario))
    End Function

    Public Overloads Function Equals(other As Usuario) As Boolean Implements IEquatable(Of Usuario).Equals
        Return other IsNot Nothing AndAlso
               Username.ToLower = other.Username.ToLower
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = 470340825
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(Username)).GetHashCode()
        Return hashCode
    End Function

    Public Shared Operator =(left As Usuario, right As Usuario) As Boolean
        Return EqualityComparer(Of Usuario).Default.Equals(left, right)
    End Operator

    Public Shared Operator <>(left As Usuario, right As Usuario) As Boolean
        Return Not left = right
    End Operator
End Class
