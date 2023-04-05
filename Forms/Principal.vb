Public Class Principal
    'toDo Cambiar color por defecto de cajas a Gris claro
    'toDo Hacer el modo oscuro
    'toDo Hacer form de victoria
    'toDo Finalizar el juego bien agregando el 5x5 de boxes
    'toDo Boton para reiniciar el juego
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        ' Si tiene menos de 5 caracteres, no se envía
        If palabra.Length <> 5 Then
            Exit Sub
        End If
        ' Validacion
        If palabraAdivinar.Equals(palabra.ToUpper) Then
            txtPrueba.Clear()
            txtPrueba.Text = "Valido"
        Else
            txtPrueba.Clear()
            txtPrueba.Text = "No valido"
        End If

        If txtPrueba.Text = "VALIDO" Then
            For Each caracter In listChar
                caracter.Enabled = False
                caracter.BackColor = Color.LightGreen
            Next
            Me.Enabled = False
            Victoria.ShowDialog()
        End If
    End Sub

    Private Sub teclado(sender As Object, e As EventArgs) Handles btnZ.Click, btnY.Click, btnX.Click, btnW.Click, btnV.Click, btnU.Click, btnT.Click, btnS.Click, btnR.Click, btnQ.Click, btnP.Click, btnO.Click, btnÑ.Click, btnN.Click, btnM.Click, btnL.Click, btnK.Click, btnJ.Click, btnI.Click, btnH.Click, btnG.Click, btnF.Click, btnE.Click, btnD.Click, btnC.Click, btnB.Click, btnA.Click
        If posRecuadro > 4 Then
            Exit Sub
        End If
        posRecuadro += 1
        DondeEstoy().Text += TryCast(sender, Button).Text
        palabra += TryCast(sender, Button).Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrayDeTextBox As TextBox() = {txtP1, txtP2, txtP3, txtP4, txtP5}
        listChar.AddRange(arrayDeTextBox) ' Agregar los TextBox a la lista
        txtP1.Select()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        ' Si la posicion del recuadro es una posicion válida (cuenta a partir de 1)
        If posRecuadro > 0 Then
            DondeEstoy().Text = "" ' Borra el texto del recuadro en le que estamos
            posRecuadro -= 1 ' Retrocede una posicion en el recuadro
            palabra = palabra.Substring(0, palabra.Length - 1) ' Elimina el ultimo caracter del string palabra
        End If
    End Sub
    ' Cuando se pulsa una tecla
    Private Sub pulsarTecla(sender As Object, e As KeyPressEventArgs) Handles txtP5.KeyPress, txtP4.KeyPress, txtP3.KeyPress, txtP2.KeyPress, txtP1.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            btnEnviar_Click(sender, e)
            Exit Sub
        End If
        If e.KeyChar = ControlChars.Back Then
            btnBorrar_Click(sender, e)
            Exit Sub
        End If
        If posRecuadro > 4 Then
            Exit Sub
        End If
        posRecuadro += 1
        DondeEstoy().Text += e.KeyChar
        palabra += e.KeyChar
    End Sub
    ' Devuelve el TextBox en el que estamos
    Public Function DondeEstoy() As TextBox
        For Each caracter In listChar
            If caracter.Tag = posRecuadro Then
                Return caracter
            End If
        Next
        Return Nothing
    End Function
    ' Limpiar los TextBox
    Public Function Limpieza()
        For Each caracter In listChar
            caracter.BackColor = DefaultBackColor
            caracter.Enabled = True
            caracter.Clear()
        Next
    End Function
End Class
