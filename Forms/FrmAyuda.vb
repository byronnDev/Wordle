Public Class FrmAyuda
    Private Sub FrmAyuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modoOscuro Then
            PonerModoOscuro(Me)
        End If
    End Sub
End Class