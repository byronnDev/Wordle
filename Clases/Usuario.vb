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
        Me._Password = password
        Me._Puntos = intentos
        Me._Wins = wins
    End Sub
    Public Sub New(username As String, password As String)
        Me._Username = username
        Me._Password = password
        Me._Puntos = 0
        Me._Wins = 0
    End Sub
    Public Sub New(username As String)
        Me._Username = username
    End Sub

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
