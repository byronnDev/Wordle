<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnLoginRegister = New System.Windows.Forms.Button()
        Me.rbtIniciarSesion = New System.Windows.Forms.RadioButton()
        Me.rbtRegistrarse = New System.Windows.Forms.RadioButton()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRepetirContrasena = New System.Windows.Forms.Label()
        Me.txtUsuarioNombre = New System.Windows.Forms.TextBox()
        Me.txtRepetirContrasena = New System.Windows.Forms.TextBox()
        Me.lblLoginError = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtContrasena.Location = New System.Drawing.Point(304, 172)
        Me.txtContrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(237, 22)
        Me.txtContrasena.TabIndex = 2
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'btnLoginRegister
        '
        Me.btnLoginRegister.Location = New System.Drawing.Point(128, 359)
        Me.btnLoginRegister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoginRegister.Name = "btnLoginRegister"
        Me.btnLoginRegister.Size = New System.Drawing.Size(100, 28)
        Me.btnLoginRegister.TabIndex = 6
        Me.btnLoginRegister.Text = "Aceptar"
        Me.btnLoginRegister.UseVisualStyleBackColor = True
        '
        'rbtIniciarSesion
        '
        Me.rbtIniciarSesion.AutoSize = True
        Me.rbtIniciarSesion.Location = New System.Drawing.Point(218, 293)
        Me.rbtIniciarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtIniciarSesion.Name = "rbtIniciarSesion"
        Me.rbtIniciarSesion.Size = New System.Drawing.Size(106, 20)
        Me.rbtIniciarSesion.TabIndex = 4
        Me.rbtIniciarSesion.TabStop = True
        Me.rbtIniciarSesion.Text = "Iniciar sesión"
        Me.rbtIniciarSesion.UseVisualStyleBackColor = True
        '
        'rbtRegistrarse
        '
        Me.rbtRegistrarse.AutoSize = True
        Me.rbtRegistrarse.Location = New System.Drawing.Point(383, 293)
        Me.rbtRegistrarse.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtRegistrarse.Name = "rbtRegistrarse"
        Me.rbtRegistrarse.Size = New System.Drawing.Size(94, 20)
        Me.rbtRegistrarse.TabIndex = 5
        Me.rbtRegistrarse.TabStop = True
        Me.rbtRegistrarse.Text = "Regístrarte"
        Me.rbtRegistrarse.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(465, 359)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 176)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'lblRepetirContrasena
        '
        Me.lblRepetirContrasena.AutoSize = True
        Me.lblRepetirContrasena.Location = New System.Drawing.Point(127, 230)
        Me.lblRepetirContrasena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRepetirContrasena.Name = "lblRepetirContrasena"
        Me.lblRepetirContrasena.Size = New System.Drawing.Size(121, 16)
        Me.lblRepetirContrasena.TabIndex = 9
        Me.lblRepetirContrasena.Text = "Repetir contraseña"
        Me.lblRepetirContrasena.Visible = False
        '
        'txtUsuarioNombre
        '
        Me.txtUsuarioNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsuarioNombre.Location = New System.Drawing.Point(304, 124)
        Me.txtUsuarioNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuarioNombre.Name = "txtUsuarioNombre"
        Me.txtUsuarioNombre.Size = New System.Drawing.Size(237, 22)
        Me.txtUsuarioNombre.TabIndex = 0
        '
        'txtRepetirContrasena
        '
        Me.txtRepetirContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtRepetirContrasena.Location = New System.Drawing.Point(304, 226)
        Me.txtRepetirContrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRepetirContrasena.Name = "txtRepetirContrasena"
        Me.txtRepetirContrasena.Size = New System.Drawing.Size(237, 22)
        Me.txtRepetirContrasena.TabIndex = 3
        Me.txtRepetirContrasena.UseSystemPasswordChar = True
        Me.txtRepetirContrasena.Visible = False
        '
        'lblLoginError
        '
        Me.lblLoginError.ForeColor = System.Drawing.Color.Red
        Me.lblLoginError.Location = New System.Drawing.Point(300, 261)
        Me.lblLoginError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoginError.Name = "lblLoginError"
        Me.lblLoginError.Size = New System.Drawing.Size(241, 33)
        Me.lblLoginError.TabIndex = 12
        Me.lblLoginError.Text = "El usuario no existe"
        Me.lblLoginError.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblLoginError.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, -33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(726, 150)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(739, 449)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLoginError)
        Me.Controls.Add(Me.txtRepetirContrasena)
        Me.Controls.Add(Me.txtUsuarioNombre)
        Me.Controls.Add(Me.lblRepetirContrasena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbtRegistrarse)
        Me.Controls.Add(Me.rbtIniciarSesion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLoginRegister)
        Me.Controls.Add(Me.txtContrasena)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión / Registrarse"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnLoginRegister As Button
    Friend WithEvents rbtIniciarSesion As RadioButton
    Friend WithEvents rbtRegistrarse As RadioButton
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRepetirContrasena As Label
    Friend WithEvents txtUsuarioNombre As TextBox
    Friend WithEvents txtRepetirContrasena As TextBox
    Friend WithEvents lblLoginError As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
