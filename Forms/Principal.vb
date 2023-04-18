Public Class Principal
    'toDo Hacer el modo oscuro
    'toDo Hacer form de victoria
    'toDo Boton para reiniciar el juego

    ' TODO María: Mejor centrar los formularios con StarPosition. 
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If palabra.Length <> 5 Then ' TODO María: No trabajar con valores absolutos (estos 5 debería ser una constante, por si luego decidís que sean de otra cantidad) 
            Exit Sub
        End If
        ' Validacion
        If palabraAdivinar.Equals(palabra.ToUpper) Then
            Me.Enabled = False ' TODO María ¿Por qué lo deshabilitáis? 
            Victoria.ShowDialog()
        End If
        maxPos += 5
        posBorrar += 5
        palabra = ""
    End Sub

    Private Sub teclado(sender As Object, e As EventArgs) Handles btnZ.Click, btnY.Click, btnX.Click, btnW.Click, btnV.Click, btnU.Click, btnT.Click, btnS.Click, btnR.Click, btnQ.Click, btnP.Click, btnO.Click, btnÑ.Click, btnN.Click, btnM.Click, btnL.Click, btnK.Click, btnJ.Click, btnI.Click, btnH.Click, btnG.Click, btnF.Click, btnE.Click, btnD.Click, btnC.Click, btnB.Click, btnA.Click
        If posRecuadro > maxPos Then
            Exit Sub
        End If
        posRecuadro += 1
        DondeEstoy().Text += TryCast(sender, Button).Text
        palabra += TryCast(sender, Button).Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrayDeTextBox As TextBox() = {txtP1, txtP2, txtP3, txtP4, txtP5, txtP6, txtP7, txtP8, txtP9, txtP10, txtP11, txtP12, txtP13, txtP14, txtP15, txtP16, txtP17, txtP18, txtP19, txtP20, txtP21, txtP22, txtP23, txtP24, txtP25} ' Array de TextBox
        listChar.AddRange(arrayDeTextBox) ' Agregar los TextBox a la lista
        txtP1.Select()

    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        ' Si la posicion del recuadro es una posicion válida (cuenta a partir de 1)
        If posRecuadro <= posBorrar Then
            Exit Sub
        End If
        DondeEstoy().Text = "" ' Borra el texto del recuadro en le que estamos
        posRecuadro -= 1 ' Retrocede una posicion en el recuadro
        palabra = palabra.Substring(0, palabra.Length - 1) ' Elimina el ultimo caracter del string palabra
    End Sub
    ' Cuando se pulsa una tecla
    Private Sub pulsarTecla(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            btnEnviar_Click(sender, e)
            Exit Sub
        End If
        If e.KeyChar = ControlChars.Back Then
            btnBorrar_Click(sender, e)
            Exit Sub
        End If
        If posRecuadro > maxPos Then
            Exit Sub
        End If
        posRecuadro += 1
        DondeEstoy().Text += e.KeyChar
        palabra += e.KeyChar
        e.KeyChar = ""
    End Sub
    ' Devuelve el TextBox en el que estamos
    Public Function DondeEstoy() As TextBox
        For Each caracter In listChar ' todo María Nombre caracter para realmente hablar de un cuadro de texto???
            If caracter.Tag = posRecuadro Then
                Return caracter
            End If
        Next
        Return Nothing
    End Function
    ' Limpiar los TextBox
    Public Sub Limpieza()
        For Each caracter In listChar
            caracter.BackColor = DefaultBackColor
            caracter.Enabled = True
            caracter.Clear()
        Next
    End Sub
End Class
