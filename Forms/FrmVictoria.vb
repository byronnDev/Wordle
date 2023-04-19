﻿Public Class FrmVictoria
    Private Sub Victoria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resultado As DialogResult = MessageBox.Show("¿Deseas comenzar una nueva partida?", "ATENCION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            ReiniciarJuego()
        ElseIf resultado = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ReiniciarJuego()
        FrmPrincipal.Enabled = True
        FrmPrincipal.Limpieza()
        FrmPrincipal.txtP1.Select()
    End Sub
End Class