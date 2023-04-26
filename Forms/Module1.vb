Imports Clases
Module Module1
    'toDo crear tabla de puntuaciones
    'toDo Hacer form de victoria -> hidalgo
    'toDo Boton para reiniciar el juego -> Hidalgo
    'toDo clase de palabras con hijos de diferentes tipos y que cuando gane te de tips -> Arkaitz
    'toDo Avanzado: Añadir o quitar un boton de tecla en la interfaz grafica y que sin tocar codigo siga funcionando
    'toDo Avanzado: Hacer que a la hora de cambiar en la interfaz grafica la cantidad de recuadros de 5 a 6 no afecte al codigo
    Public manage As GestionUsuarios 'Plataforma para gestionar los datos de los usuarios y para agregar estos mismos
    Public palabraAdivinar As String = "AVION" ' Palabra la cual tienen que adivinar
    Public usuarioActual As Usuario ' Guarda el usuario actual
    Public posRecuadro As Integer = 0
    Public listaRecuadros As New List(Of TextBox)
    Public palabra As String
    Public maxPos As Integer = 4
    Public Const LONGITUDPALABRA = 5 ' La longitud de la palabra
    Public intentosTotales As Byte = 0
End Module
