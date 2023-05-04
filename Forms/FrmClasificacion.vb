Imports Clases

Public Class FrmClasificacion
    Private Sub FrmClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'No tener nada focus
        Me.ActiveControl = Nothing
        Dim usuariosClasificados As List(Of Usuario) = manage.Clasificados()
        For i = 0 To usuariosClasificados.ToArray.Length - 1
            lstClasificacion.Items.Add($"{i + 1}º - {usuariosClasificados(i).ToString.Split("*")(0)}")
            lstPuntuacion.Items.Add(usuariosClasificados(i).ToString.Split("*")(2))
        Next
    End Sub

    Private Sub FrmClasificacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resultado As DialogResult = MessageBox.Show("¿Deseas comenzar una nueva partida?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If resultado = DialogResult.OK Then
            FrmVictoria.ReiniciarJuego()
        ElseIf resultado = DialogResult.Cancel Then
            FrmPrincipal.Close()
            e.Cancel = False
        End If
    End Sub
End Class