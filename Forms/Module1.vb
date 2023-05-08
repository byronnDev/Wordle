Imports Clases
Imports System.IO
Module Module1
    'toDo hacer que cuando le de al boton tambien cambien los colores
    'toDo Cambiar los controles a tiempo de ejecucion -> Hidalgo(Pospuesto)
    'toDo Avanzado: Añadir o quitar un boton de tecla en la interfaz grafica y que sin tocar codigo siga funcionando
    'toDo Avanzado: Hacer que a la hora de cambiar en la interfaz grafica la cantidad de recuadros de 5 a 6 no afecte al codigo

    Public modoOscuro As Boolean
    'Public function ModoOscuro(nombre as string)
    '    If modoOscuro() Then
    '        BackColor = Color.FromArgb(15, 15, 15)
    '        For Each conntrol In Me.Controls
    '            If TypeOf conntrol Is Button And TypeOf conntrol Is TextBox And TypeOf conntrol Is Label Then
    '                conntrol.BackColor = Color.FromArgb(30, 30, 30)
    '                conntrol.ForeColor = Color.White
    '            ElseIf TypeOf conntrol Is Label Then

    '            End If
    '        Next
    '    Else
    '        Me.BackColor = Color.White
    '        For Each conntrol In Me.Controls
    '            If TypeOf conntrol Is Button And TypeOf conntrol Is TextBox And TypeOf conntrol Is Label Then
    '                conntrol.BackColor = Color.White
    '                conntrol.ForeColor = Color.Black
    '            End If
    '        Next
    '    End If
    'End Sub
    Public manage As GestionUsuarios 'Plataforma para gestionar los datos de los usuarios y para agregar estos mismos
    Public palabrasDisponibles As String() = File.ReadAllLines("./datos/palabras.txt") ' Palabra la cual tienen que adivinar
    Public rnd As New Random()
    Public palabraAdivinar As String
    Public usuarioActual As Usuario ' Guarda el usuario actual
    Public posRecuadro As Integer
    Public listaRecuadros As New List(Of TextBox)
    Public palabra As String
    Public maxPos As Integer
    Public Const LONGITUDPALABRA = 5 ' La longitud de la palabra
    Public intentosTotales As Byte = 0

    Public Sub NuevaPalabra()
        Dim tempPalabra As String = palabraAdivinar
        Do
            palabraAdivinar = palabrasDisponibles(rnd.Next(palabrasDisponibles.Length))
        Loop Until palabraAdivinar <> tempPalabra ' Comprueba que la palabra no sea la misma que la anterior
    End Sub
End Module
