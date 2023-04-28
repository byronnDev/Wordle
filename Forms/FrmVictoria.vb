Imports Clases

Public Class FrmVictoria
    Private Sub Victoria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resultado As DialogResult = MessageBox.Show("¿Deseas comenzar una nueva partida?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If resultado = DialogResult.OK Then
            ReiniciarJuego()
        ElseIf resultado = DialogResult.Cancel Then
            FrmPrincipal.Close()
        End If
    End Sub

    Private Sub ReiniciarJuego()
        NuevaPalabra()
        FrmPrincipal.Enabled = True
        FrmPrincipal.Limpieza()
        FrmPrincipal.txtP1.Select()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        FrmPrincipal.Close()
    End Sub

    Private Sub FrmVictoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNumIntentos.Text = usuarioActual.Puntos
        lblWins.Text = usuarioActual.Wins
        If usuarioActual.Wins > 5 Then
            ' Si el usuario ha ganado mas de 5 veces, se le suman 50 puntos por cada 5 victorias
            Dim multiplicador As Integer = usuarioActual.Wins / 5
            usuarioActual.Puntos += multiplicador * 50
        End If
    End Sub

    Private Sub btnVolverAJugar_Click(sender As Object, e As EventArgs) Handles btnVolverAJugar.Click
        ReiniciarJuego()
        Me.Close()
    End Sub
End Class