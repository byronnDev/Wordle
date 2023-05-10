Public Class FrmAyuda
    Private Sub FrmAyuda_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub

    Private Sub FrmAyuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modoOscuroSino Then
            ModoOscuro(Me)
        End If
    End Sub
End Class