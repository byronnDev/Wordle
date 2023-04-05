Imports System.Collections.ObjectModel
Public Class GestionPalabras
    Private _Palabras As New List(Of String) From {"hola"}
    Public ReadOnly Property Palabras As ReadOnlyCollection(Of String)
        Get
            Return _Palabras.AsReadOnly
        End Get
    End Property

End Class