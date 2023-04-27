Imports Clases

Public Class FrmVictoria
    Private Sub Victoria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resultado As DialogResult = MessageBox.Show("¿Deseas comenzar una nueva partida?", "ATENCION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            ReiniciarJuego()
        ElseIf resultado = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ReiniciarJuego()
        palabraAdivinar = palabrasDisponibles(rnd.Next(palabrasDisponibles.Length + 1))
        FrmPrincipal.Enabled = True
        FrmPrincipal.Limpieza()
        FrmPrincipal.txtP1.Select()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

    End Sub

    Private Sub FrmVictoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuActual As Usuario = usuarioActual ' Creo un usuario auxiliar para
        'poner el numero de intentos que ha necesitado el usuario para ganar
        lblIntentos.Text = manage.Fallos(usuActual.Username)

    End Sub
End Class