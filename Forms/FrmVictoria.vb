Imports Clases

Public Class FrmVictoria
    Dim cerrarSinPreguntar As Boolean = False
    Private Sub Victoria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If cerrarSinPreguntar Then
            cerrarSinPreguntar = False
            Exit Sub
        End If
        Dim resultado As DialogResult = MessageBox.Show("¿Deseas comenzar una nueva partida?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            ReiniciarJuego()
        ElseIf resultado = DialogResult.No Then
            FrmPrincipal.Close()
            Exit Sub
        End If
    End Sub

    Public Sub ReiniciarJuego()
        FrmPrincipal.Enabled = True
        FrmPrincipal.Limpieza()
        NuevaPalabra()
    End Sub

    Private Sub FrmVictoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modoOscuroSino Then
            ModoOscuro(Me)
        End If
        If usuarioActual.Wins > 5 Then
            ' Si el usuario ha ganado mas de 5 veces, se le suman 50 puntos por cada 5 victorias
            Dim multiplicador As Integer = usuarioActual.Wins / 5
            usuarioActual.Puntos += multiplicador * 50
        End If
        lblPuntuacion.Text = usuarioActual.Puntos
        lblWins.Text = usuarioActual.Wins
    End Sub

    Private Sub btnVolverAJugar_Click(sender As Object, e As EventArgs) Handles btnVolverAJugar.Click
        ReiniciarJuego()
        cerrarSinPreguntar = True
        Me.Close()
    End Sub

    Private Sub btnClasificacion_Click(sender As Object, e As EventArgs) Handles btnClasificacion.Click
        FrmClasificacion.Show()
        cerrarSinPreguntar = True
        Me.Close()
    End Sub
End Class