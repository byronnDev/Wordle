Imports System.Net
Imports Clases
Public Class FrmUsuarios
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLoginRegister.Focus()
        rbtIniciarSesion.Checked = True
    End Sub
    'toDo arreglar inicio de sesion
    Private Sub btnLoginRegister_Click(sender As Object, e As EventArgs) Handles btnLoginRegister.Click
        ' Si existe
        LblLoginError.Text = "Usuario no existe"
        LblLoginError.Visible = False
        LblLoginError.ForeColor = Color.Red
        If String.IsNullOrWhiteSpace(txtUsuarioNombre.Text) OrElse String.IsNullOrWhiteSpace(txtContrasena.Text) Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If rbtIniciarSesion.Checked = True Then
                txtRepetirContrasena.Hide()
                lblRepetirContrasena.Hide()
                ' Si el usuario está registrado
                'te notifica 
                If manage.BuscarUsuario(txtUsuarioNombre.Text) = Nothing Then
                    'usuario no existe
                    LblLoginError.Visible = True
                Else
                    Me.Close()
                End If
            ElseIf rbtRegistrarse.Checked = True Then
                txtRepetirContrasena.Show()
                lblRepetirContrasena.Show()
                If manage.RegistrarUsuario(txtUsuarioNombre.Text, txtContrasena.Text) = Nothing Then
                    'usuario no existe
                    LblLoginError.Visible = True
                Else
                    LblLoginError.Visible = True
                    LblLoginError.ForeColor = Color.Green
                    LblLoginError.Text = $"Gracias por registrarte {txtUsuarioNombre.Text}, recuerda logearte ahora para disfrutar del juego"
                End If
            End If
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' Cierra la ventana
        Me.Close()
        ' Cierra la aplicación
        FrmPrincipal.Close()
    End Sub

    Private Sub rbtIniciarSesion_CheckedChanged(sender As Object, e As EventArgs) Handles rbtIniciarSesion.CheckedChanged
        LblLoginError.Visible = False
        txtRepetirContrasena.Visible = False
        lblRepetirContrasena.Visible = False

    End Sub

    Private Sub rbtRegistrarse_CheckedChanged(sender As Object, e As EventArgs) Handles rbtRegistrarse.CheckedChanged
        txtRepetirContrasena.Visible = True
        lblRepetirContrasena.Visible = True
    End Sub
End Class