Public Class Victoria
    Private Sub Victoria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resultado As DialogResult = MessageBox.Show("¿Deseas comenzar una nueva partida?", "ATENCION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If resultado = DialogResult.No Then
            Principal.Close()
        ElseIf resultado = DialogResult.Cancel Then
            e.Cancel = True
        End If
        ReiniciarJuego()
    End Sub

    Private Sub ReiniciarJuego()
        Principal.Enabled = True
        palabra = ""
        posRecuadro = 0
        Principal.Limpieza()
        Principal.txtPrueba.Clear()
        Principal.txtP1.Select()
    End Sub
End Class