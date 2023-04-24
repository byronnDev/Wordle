Imports System.Net
Imports Clases
Public Class FrmUsuarios
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtIniciarSesion.Checked = True
    End Sub
    'toDo arreglar inicio de sesion
    Private Sub btnLoginRegister_Click(sender As Object, e As EventArgs) Handles btnLoginRegister.Click
        ' Si existe
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
                    MessageBox.Show("usuario no exite")
                Else
                    MessageBox.Show($"gracias por iniciar sesion {txtUsuarioNombre.Text}, disfrute del juego")
                    Me.Close()
                End If
            ElseIf rbtRegistrarse.Checked = True Then
                txtRepetirContrasena.Show()
                lblRepetirContrasena.Show()
                If manage.RegistrarUsuario(txtUsuarioNombre.Text, txtContrasena.Text) = Nothing Then
                    'usuario no existe
                    MessageBox.Show("usuario no exite")
                Else
                    MessageBox.Show($"gracias por iniciar sesion {txtUsuarioNombre.Text}, disfrute del juego")
                    Me.Close()
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
End Class