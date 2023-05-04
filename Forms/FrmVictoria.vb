Imports Clases

Public Class FrmVictoria
    Private Sub Victoria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.None Then
            Exit Sub
        End If
        Dim resultado As DialogResult = MessageBox.Show("¿Deseas comenzar una nueva partida?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If resultado = DialogResult.OK Then
            ReiniciarJuego()
        ElseIf resultado = DialogResult.Cancel Then
            Victoria_FormClosing(sender, New FormClosingEventArgs(CloseReason.None, False))
        End If
    End Sub

    Public Sub ReiniciarJuego()
        NuevaPalabra()
        FrmPrincipal.Show()
        FrmPrincipal.Limpieza()
        FrmPrincipal.txtP1.Select()
    End Sub

    Private Sub FrmVictoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Victoria_FormClosing(sender, New FormClosingEventArgs(CloseReason.None, False))
    End Sub

    Private Sub btnClasificacion_Click(sender As Object, e As EventArgs) Handles btnClasificacion.Click
        FrmClasificacion.Show()
    End Sub
End Class