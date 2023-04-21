Imports System.Net
Imports Clases

Public Class FrmUsuarios

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtIniciarSesion.Checked = True
        If rbtRegistrarse.Checked = True Then
            txtRepetirContrasena.Enabled = True
        End If
    End Sub
    'toDo arreglar inicio de sesion
    Private Sub btnLoginRegister_Click(sender As Object, e As EventArgs) Handles btnLoginRegister.Click
        ' Si existe
        If rbtIniciarSesion.Checked = True Then
            txtRepetirContrasena.Enabled = False
            ' Si el usuario está registrado
            If String.IsNullOrWhiteSpace(txtUsuarioNombre.Text) OrElse String.IsNullOrWhiteSpace(txtUsuarioNombre.Text) Then
                MessageBox.Show("Debe llenar todos los campos")
            Else
                'te notifica 
                If manage.RegistrarUsuario(txtUsuarioNombre.Text, txtContrasena.Text) = Nothing Then
                    'si es usuario que inicia sesion esta registrado
                    MessageBox.Show("Sesion iniciada correctamente")
                Else
                    'si no es usuario que inicia sesion esta registrado
                    MessageBox.Show("Usuario no registrado")
                End If

            End If
        ElseIf rbtRegistrarse.Checked = True Then
            txtRepetirContrasena.Enabled = True
            If String.IsNullOrWhiteSpace(txtUsuarioNombre.Text) OrElse String.IsNullOrWhiteSpace(txtUsuarioNombre.Text) OrElse String.IsNullOrWhiteSpace(txtRepetirContrasena.Text) Then
                MessageBox.Show("Debe llenar todos los campos")
            End If
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class