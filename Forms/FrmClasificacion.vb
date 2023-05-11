Imports Clases

Public Class FrmClasificacion
    Private Sub FrmClasificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modoOscuroSino Then
            ModoOscuro(Me)
            lblUsuarios.BackColor = Color.Cyan
            lblPuntos.BackColor = Color.Cyan
        End If
        'No tener nada focus
        lblUsuarios.Select()
        Dim usuariosClasificados As List(Of Usuario) = manage.Clasificados(True)
        For i = 0 To usuariosClasificados.ToArray.Length - 1
            lstClasificacion.Items.Add($"{i + 1}º - {usuariosClasificados(i).ToString.Split("*")(0)}")
            lstPuntuacion.Items.Add(usuariosClasificados(i).ToString.Split("*")(2))
        Next
    End Sub

    Private Sub FrmClasificacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resultado As DialogResult = MessageBox.Show("¿Deseas comenzar una nueva partida?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If resultado = DialogResult.Yes Then
            FrmPrincipal.Enabled = True
            lstClasificacion.Items.Clear()
            lstPuntuacion.Items.Clear()
            FrmPrincipal.Limpieza()
        ElseIf resultado = DialogResult.No Then
            FrmPrincipal.Close()
            e.Cancel = False
        End If
    End Sub

    Private Sub btnPuntosWins_Click(sender As Object, e As EventArgs) Handles btnPuntosWins.Click
        Dim usuariosClasificados As List(Of Usuario)
        ' Limpiar listas
        lstClasificacion.Items.Clear()
        lstPuntuacion.Items.Clear()
        ' Comprobar si quiere ver las clasificaciones por puntos o wins
        If btnPuntosWins.Text.Equals("Wins") Then
            usuariosClasificados = manage.Clasificados(False) ' Obtener usuarios clasificados por wins
            btnPuntosWins.Text = "Puntos" ' Cambiar el texto del boton
            ' Rellenar listas con los usuarios clasificados por wins
            lblPuntos.Text = "Wins" ' Cambiar el texto de la etiqueta
            For i = 0 To usuariosClasificados.ToArray.Length - 1
                lstClasificacion.Items.Add($"{i + 1}º - {usuariosClasificados(i).ToString.Split("*")(0)}")
                lstPuntuacion.Items.Add(usuariosClasificados(i).ToString.Split("*")(3))
            Next
        Else
            usuariosClasificados = manage.Clasificados(True) ' Obtener usuarios clasificados por puntos
            btnPuntosWins.Text = "Wins" ' Cambiar el texto del boton
            ' Rellenar listas con los usuarios clasificados por puntos
            lblPuntos.Text = "Puntos" ' Cambiar el texto de la etiqueta
            For i = 0 To usuariosClasificados.ToArray.Length - 1
                lstClasificacion.Items.Add($"{i + 1}º - {usuariosClasificados(i).ToString.Split("*")(0)}")
                lstPuntuacion.Items.Add(usuariosClasificados(i).ToString.Split("*")(2))
            Next
        End If
    End Sub

End Class