Imports System.Reflection.Emit
Imports Clases
Public Class FrmPrincipal
    Private Sub timerParpadeo_Tick(sender As Object, e As EventArgs) Handles timerParpadeo.Tick
        ' Que parpadee el mensaje de enter con 750ms de intervalo
        If lblMensajeEnter.Visible Then
            lblMensajeEnter.Visible = False
        Else
            lblMensajeEnter.Visible = True
        End If
    End Sub
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If palabra.Length <> LONGITUDPALABRA Then
            Exit Sub
        End If
        timerParpadeo.Stop()
        lblMensajeEnter.Visible = False
        If Not palabrasDisponibles.Contains(palabra.ToUpper) Then
            MessageBox.Show("Pon una palabra válida", "ERR00R 002", MessageBoxButtons.OK, MessageBoxIcon.Error)
            timerParpadeo.Stop()
            lblMensajeEnter.Visible = False
            For i = 0 To LONGITUDPALABRA - 1
                TextBoxActual().Text = "" ' Borra el texto del recuadro en le que estamos
                DevuelveTextbox(posRecuadro).BackColor = Color.Silver
                posRecuadro -= 1 ' Retrocede una posicion en el recuadro
            Next
            palabra = ""
            Exit Sub
        End If
        intentosTotales += 1
        ' Validacion
        DevuelveTextbox(posRecuadro).BackColor = Color.Silver ' Poner el textbox en gris
        ColorearPalabras()
        If palabraAdivinar.Equals(palabra.ToUpper) Then
            manage.AnadirWin(usuarioActual)
            FrmVictoria.Show()
            Me.Enabled = False
            Exit Sub
        End If
        maxPos += 5
        palabra = ""
        txtP1.Select()
        If intentosTotales >= 5 Then
            MessageBox.Show("Se acabaron los intentos!" & vbCr & "La palabra era: " & palabraAdivinar, "Fin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            usuarioActual.Puntos -= 50
            NuevaPalabra()
            Limpieza() ' Limpiar los TextBox
        End If
    End Sub

    Private Sub teclado(sender As Object, e As EventArgs) Handles btnZ.Click, btnY.Click, btnX.Click, btnW.Click, btnV.Click, btnU.Click, btnT.Click, btnS.Click, btnR.Click, btnQ.Click, btnP.Click, btnO.Click, btnÑ.Click, btnN.Click, btnM.Click, btnL.Click, btnK.Click, btnJ.Click, btnI.Click, btnH.Click, btnG.Click, btnF.Click, btnE.Click, btnD.Click, btnC.Click, btnB.Click, btnA.Click
        letraElegida(TryCast(sender, Button).Text)
        txtP1.Select()
    End Sub
    ' Funcion que recoge la letra elegida y la pone en el textbox
    Private Function letraElegida(letra As String)
        If palabra.Length = 4 Then
            timerParpadeo.Start() ' Para que parpadee el mensaje de enter
        End If
        If posRecuadro <> maxPos - 4 AndAlso posRecuadro <= maxPos Then
            ' Cambiar el color del recuadro anterior a gris claro
            DevuelveTextbox(posRecuadro).BackColor = Color.Silver
        End If
        If posRecuadro <= maxPos Then
            posRecuadro += 1 ' Avanza una posicion en el recuadro
            TextBoxActual().Text += letra ' Añade la letra al recuadro
            palabra += letra ' Añade la letra al string palabra
        End If
        txtP1.Select()
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrayDeTextBox As TextBox() = {txtP1, txtP2, txtP3, txtP4, txtP5, txtP6, txtP7, txtP8, txtP9, txtP10, txtP11, txtP12, txtP13, txtP14, txtP15, txtP16, txtP17, txtP18, txtP19, txtP20, txtP21, txtP22, txtP23, txtP24, txtP25}

        NuevaPalabra()
        ' Añadimos la palabra elegida aleatoriamente del array
        listaRecuadros.AddRange(arrayDeTextBox) ' Agregar los TextBox a la lista
        txtP1.Select()
        btnReinicio.FlatStyle = FlatStyle.Flat
        btnReinicio.FlatAppearance.BorderSize = 0
        btnModoOscuro.FlatStyle = FlatStyle.Flat
        btnModoOscuro.FlatAppearance.BorderSize = 0
        palabra = ""
        maxPos = 4
        posRecuadro = 0
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        ' Si la posicion del recuadro es una posicion válida (cuenta a partir de 1)
        If posRecuadro <= maxPos - 4 Then
            Exit Sub
        End If
        timerParpadeo.Stop()
        lblMensajeEnter.Visible = False
        TextBoxActual().Text = "" ' Borra el texto del recuadro en le que estamos
        DevuelveTextbox(posRecuadro).BackColor = Color.Silver
        posRecuadro -= 1 ' Retrocede una posicion en el recuadro
        If posRecuadro <> maxPos - 4 Then
            ' Cambiar el color del recuadro anterior a gris claro
            DevuelveTextbox(posRecuadro).BackColor = Color.DarkGray
        End If
        palabra = palabra.Substring(0, palabra.Length - 1) ' Elimina el ultimo caracter del string palabra
    End Sub
    ' Cuando se pulsa una tecla
    Private Sub pulsarTecla(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If palabra.Length = 4 Then
            timerParpadeo.Start()
        End If
        Dim validos As Char() = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", “a”, “b”, “c”, “d”, “e”, “f”, “g”, “h”, “i”, “j”, “k”, “l”, “m”, “n”, “ñ”, “o”, “p”, “q”, “r”, “s”, “t”, “u”, “v”, “w”, “x”, “y”, “z”}

        ' Si se pulsa enter y la palabra no tiene 5 caracteres
        If e.KeyChar = ControlChars.Cr AndAlso palabra.Length <> 5 Then
            Exit Sub
        End If
        If e.KeyChar = ControlChars.Cr Then ' Si se pulsa enter
            timerParpadeo.Stop()
            lblMensajeEnter.Visible = False
            ' Si se acaban los intentos
            btnEnviar_Click(sender, e)
            Exit Sub
        End If
        If e.KeyChar = ControlChars.Back Then
            btnBorrar_Click(sender, e)
            Exit Sub
        End If
        ' Si se pulsa una tecla que no sea una letra o sea el enter
        If Not validos.Contains(e.KeyChar) Then
            Exit Sub
        End If
        letraElegida(e.KeyChar)
    End Sub
    ' Devuelve el TextBox en el que estamos
    Public Function TextBoxActual() As TextBox
        For Each textBox In listaRecuadros
            If textBox.Tag = posRecuadro Then
                'Que cambie el color del borde del textbox
                textBox.BackColor = Color.DarkGray
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
        ' Si el fondo es blanco
        If Me.BackColor = Color.FromArgb(15, 15, 15) Then
            modoOscuroSino = False
            btnReinicio.Image = My.Resources.ReinicioNegro
            btnModoOscuro.Image = My.Resources.LunaNegro
            btnModoOscuro.BackColor = Color.Transparent
            Me.BackColor = Color.White
            For Each conntrol In Me.Controls
                If TypeOf conntrol Is Button Then

                    conntrol.BackColor = Color.White
                    conntrol.ForeColor = Color.Black
                End If
            Next
        Else
            modoOscuroSino = True
            For Each conntrol In Me.Controls
                If TypeOf conntrol Is Button Then
                    conntrol.BackColor = Color.FromArgb(30, 30, 30)
                    conntrol.ForeColor = Color.White
                End If
            Next
            btnReinicio.BackColor = Color.Transparent
            btnModoOscuro.BackColor = Color.Transparent
            btnModoOscuro.Image = My.Resources.SolBlanco
            btnReinicio.Image = My.Resources.ReinicioBlanco
            Me.BackColor = Color.FromArgb(15, 15, 15)
        End If
        txtP1.Select()
    End Sub
    Private Sub btnReinicio_Click(sender As Object, e As EventArgs) Handles btnReinicio.Click
        Limpieza()
        NuevaPalabra()
        timerParpadeo.Stop()
        lblMensajeEnter.Visible = False
    End Sub
    Private Sub ColorearPalabras()
        Dim arrayChars As New List(Of Char)
        arrayChars.AddRange(palabraAdivinar.ToCharArray)
        For i = 0 To LONGITUDPALABRA - 1
            If palabra.ToUpper.Chars(i) = palabraAdivinar.ToUpper.Chars(i) Then ' Si la letra esta en la posicion correcta
                DevuelveTextbox(i + 1 + maxPos - 4).BackColor = Color.FromArgb(144, 197, 154)
                manage.SumarPunto(usuarioActual, 50)
            End If
            If arrayChars.Contains(palabra.ToUpper.Chars(i)) AndAlso DevuelveTextbox(i + 1 + maxPos - 4).BackColor <> Color.FromArgb(144, 197, 154) Then ' Si la palabra contiene la letra
                DevuelveTextbox(i + 1 + maxPos - 4).BackColor = Color.FromArgb(244, 180, 132)
                manage.SumarPunto(usuarioActual, 10)
            End If
        Next
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Visible = False
        Me.Limpieza()
        timerParpadeo.Stop()
        lblMensajeEnter.Visible = False
        FrmUsuarios.Show()
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        txtP1.Select()
        Dim descripcionDelBoton As New ToolTip()
        descripcionDelBoton.SetToolTip(btnAyuda, "Pincháme para las Instrucciones.")
        FrmAyuda.ShowDialog()
    End Sub
End Class