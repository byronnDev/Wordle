Imports Clases
Public Class FrmPrincipal
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If palabra.Length <> LONGITUDPALABRA Then
            Exit Sub
        End If
        ' Validacion
        If palabraAdivinar.Equals(palabra.ToUpper) Then

            Me.Enabled = False
            FrmVictoria.ShowDialog()
            Exit Sub
        End If
        maxPos += 5
        palabra = ""
    End Sub

    Private Sub teclado(sender As Object, e As EventArgs) Handles btnZ.Click, btnY.Click, btnX.Click, btnW.Click, btnV.Click, btnU.Click, btnT.Click, btnS.Click, btnR.Click, btnQ.Click, btnP.Click, btnO.Click, btnÑ.Click, btnN.Click, btnM.Click, btnL.Click, btnK.Click, btnJ.Click, btnI.Click, btnH.Click, btnG.Click, btnF.Click, btnE.Click, btnD.Click, btnC.Click, btnB.Click, btnA.Click
        If posRecuadro > maxPos Then
            Exit Sub
        End If
        posRecuadro += 1
        TextBoxActual().Text += TryCast(sender, Button).Text
        palabra += TryCast(sender, Button).Text
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrayDeTextBox As TextBox() = {txtP1, txtP2, txtP3, txtP4, txtP5, txtP6, txtP7, txtP8, txtP9, txtP10, txtP11, txtP12, txtP13, txtP14, txtP15, txtP16, txtP17, txtP18, txtP19, txtP20, txtP21, txtP22, txtP23, txtP24, txtP25} ' Array de TextBox
        manage = New GestionUsuarios
        listaRecuadros.AddRange(arrayDeTextBox) ' Agregar los TextBox a la lista
        txtP1.Select()
        'Me.Hide()
        'FrmUsuarios.ShowDialog()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        ' Si la posicion del recuadro es una posicion válida (cuenta a partir de 1)
        If posRecuadro <= maxPos - 4 Then
            Exit Sub
        End If
        TextBoxActual().Text = "" ' Borra el texto del recuadro en le que estamos
        posRecuadro -= 1 ' Retrocede una posicion en el recuadro
        palabra = palabra.Substring(0, palabra.Length - 1) ' Elimina el ultimo caracter del string palabra
    End Sub
    ' Cuando se pulsa una tecla
    Private Sub pulsarTecla(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' Si se pulsa enter y la palabra no tiene 5 caracteres
        If e.KeyChar = ControlChars.Cr AndAlso palabra.Length <> 5 Then
            Exit Sub
        End If

        If e.KeyChar = ControlChars.Cr Then ' Si se pulsa enter
            intentosTotales += 1
            ' Colorear palabra
            For i = 0 To LONGITUDPALABRA - 1
                If palabra.ToUpper.Chars(i) = palabraAdivinar.ToUpper.Chars(i) Then
                    DevuelveTextbox(i + 1 + maxPos - 4).BackColor = Color.FromArgb(144, 197, 154)
                ElseIf palabraAdivinar.ToUpper.Contains(palabra.ToUpper.Chars(i)) Then
                    DevuelveTextbox(i + 1 + maxPos - 4).BackColor = Color.FromArgb(244, 180, 132)
                End If
            Next
            ' Si se acaban los intentos
            If intentosTotales >= 5 Then
                MessageBox.Show("Se acabaron los intentos!", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Limpieza() ' Limpiar los TextBox
            End If
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
        TextBoxActual().Text += e.KeyChar
        palabra += e.KeyChar
        e.KeyChar = ""
    End Sub
    ' Devuelve el TextBox en el que estamos
    Public Function TextBoxActual() As TextBox
        For Each textBox In listaRecuadros
            If textBox.Tag = posRecuadro Then
                Return textBox
            End If
        Next
        Return Nothing
    End Function

    Public Function DevuelveTextbox(numeroTag As Byte) As TextBox
        For Each textBox In listaRecuadros
            If textBox.Tag = numeroTag Then
                Return textBox
            End If
        Next
        Return Nothing
    End Function

    ' Limpiar los TextBox TERMINADO
    Public Sub Limpieza()
        For Each textbox In listaRecuadros
            textbox.BackColor = Color.Silver
            textbox.Clear()
        Next
        palabra = ""
        posRecuadro = 0
        maxPos = 4
        intentosTotales = 0
        txtP1.Select()
    End Sub
    'Modo Oscuro TERMINADO
    Private Sub btnModoOscuro_Click(sender As Object, e As EventArgs) Handles btnModoOscuro.Click
        Dim conntrol As Control
        If Me.BackColor = Color.FromArgb(15, 15, 15) Then
            Me.BackColor = Color.White
            For Each conntrol In Me.Controls
                If TypeOf conntrol Is Button Then
                    conntrol.BackColor = Color.White
                    conntrol.ForeColor = Color.Black
                End If
            Next
        Else
            For Each conntrol In Me.Controls
                If TypeOf conntrol Is Button Then
                    conntrol.BackColor = Color.FromArgb(30, 30, 30)
                    conntrol.ForeColor = Color.White
                End If
            Next

            Me.BackColor = Color.FromArgb(15, 15, 15)
        End If

    End Sub

    Private Sub btnReinicio_Click(sender As Object, e As EventArgs) Handles btnReinicio.Click
        Limpieza()
    End Sub
End Class
