Imports System.Security.Cryptography
Imports System.Text
'toDo Solucionar error de inicio detecta la password la intenta castear a double
Public Class Usuario
    Implements IEquatable(Of Usuario)

    Public Property Username As String
    Public Property Password As String
    Public Property Fallos As Integer
    Public Property Wins As Integer

    Public Sub New(usernme As String, password As String, intentos As Integer, wins As Integer)
        Me._Username = usernme
        Me._Password = Encrypt(password)
        Me._Fallos = intentos
        Me._Wins = wins
    End Sub
    Public Sub New(username As String, password As String)
        Me._Username = username
        Me._Password = Encrypt(password)
        Me._Fallos = 0
        Me._Wins = 0
    End Sub
    Public Sub New(username As String)
        Me._Username = username
    End Sub

    Public Function Encrypt(password As String) As String
        ' Crea una instancia de la clase SHA256
        Dim sha256 As SHA256 = sha256.Create()
        ' Convierte la contraseña en un arreglo de bytes
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        ' Calcula el hash de la contraseña
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        ' Crea una instancia de la clase StringBuilder para construir el hash como una cadena de texto
        Dim passwordEncrypted As New StringBuilder()
        ' Recorre el arreglo de bytes del hash y agrega cada byte como un valor hexadecimal de dos dígitos a la cadena de texto
        For i As Integer = 0 To hash.Length - 1
            passwordEncrypted.Append(hash(i).ToString("x2"))
        Next
        ' Devuelve el hash como una cadena de texto
        Return passwordEncrypted.ToString
    End Function

    Public Overrides Function ToString() As String
        Return _Username & "*" & _Password & "*" & _Fallos & "*" & _Wins ' To String para luego utilizarlo a la hora de agregar al fichero
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
