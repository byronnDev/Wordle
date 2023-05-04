Imports System.Net
Imports Clases
Public Class FrmUsuarios

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnLoginRegister.Focus()
        manage = New GestionUsuarios
        rbtIniciarSesion.Checked = True
    End Sub
    'toDo arreglar inicio de sesion
    Private Sub btnLoginRegister_Click(sender As Object, e As EventArgs) Handles btnLoginRegister.Click
        ' Si existe
        lblLoginError.Text = "Usuario no existe"
        lblLoginError.Visible = False
        lblLoginError.ForeColor = Color.Red
        If String.IsNullOrWhiteSpace(txtUsuarioNombre.Text) OrElse String.IsNullOrWhiteSpace(txtContrasena.Text) Then
            MessageBox.Show("Debe llenar todos los campos")
        Else
            If rbtIniciarSesion.Checked = True Then
                txtRepetirContrasena.Hide()
                lblRepetirContrasena.Hide()
                ' Si el usuario está registrado
                'te notifica 
                usuarioActual = manage.BuscarUsuario(txtUsuarioNombre.Text)
                If usuarioActual = Nothing Then
                    'usuario no existe
                    lblLoginError.Visible = True
                Else ' Si el usuario existe
                    FrmPrincipal.Show()
                    Me.Close()
                End If
            ElseIf rbtRegistrarse.Checked = True Then
                txtRepetirContrasena.Show()
                lblRepetirContrasena.Show()
                If Not txtContrasena.Text.Equals(txtRepetirContrasena.Text) Then
                    lblLoginError.ForeColor = Color.Red
                    lblLoginError.Text = $"Contraseña no coincide"
                    lblLoginError.Visible = Enabled
                Else
                    If manage.RegistrarUsuario(txtUsuarioNombre.Text, txtContrasena.Text) = Nothing Then
                        'usuario no existe
                        lblLoginError.Visible = True
                        lblLoginError.ForeColor = Color.Red
                        lblLoginError.Text = "Usuario ya existe"
                    Else
                        lblLoginError.Visible = True
                        lblLoginError.ForeColor = Color.Green
                        lblLoginError.Text = $"Gracias por registrarte"
                    End If
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
        lblLoginError.Visible = False
        txtRepetirContrasena.Visible = False
        lblRepetirContrasena.Visible = False

    End Sub

    Private Sub rbtRegistrarse_CheckedChanged(sender As Object, e As EventArgs) Handles rbtRegistrarse.CheckedChanged
        txtRepetirContrasena.Visible = True
        lblRepetirContrasena.Visible = True
    End Sub
End Class