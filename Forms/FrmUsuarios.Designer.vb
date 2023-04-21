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
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnLoginRegister = New System.Windows.Forms.Button()
        Me.rbtIniciarSesion = New System.Windows.Forms.RadioButton()
        Me.rbtRegistrarse = New System.Windows.Forms.RadioButton()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsuarioNombre = New System.Windows.Forms.TextBox()
        Me.txtRepetirContrasena = New System.Windows.Forms.TextBox()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtContrasena.Location = New System.Drawing.Point(228, 140)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(183, 20)
        Me.txtContrasena.TabIndex = 2
        '
        'btnLoginRegister
        '
        Me.btnLoginRegister.Location = New System.Drawing.Point(96, 292)
        Me.btnLoginRegister.Name = "btnLoginRegister"
        Me.btnLoginRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnLoginRegister.TabIndex = 3
        Me.btnLoginRegister.Text = "Aceptar"
        Me.btnLoginRegister.UseVisualStyleBackColor = True
        '
        'rbtIniciarSesion
        '
        Me.rbtIniciarSesion.AutoSize = True
        Me.rbtIniciarSesion.Location = New System.Drawing.Point(155, 238)
        Me.rbtIniciarSesion.Name = "rbtIniciarSesion"
        Me.rbtIniciarSesion.Size = New System.Drawing.Size(86, 17)
        Me.rbtIniciarSesion.TabIndex = 5
        Me.rbtIniciarSesion.TabStop = True
        Me.rbtIniciarSesion.Text = "Iniciar sesion"
        Me.rbtIniciarSesion.UseVisualStyleBackColor = True
        '
        'rbtRegistrarse
        '
        Me.rbtRegistrarse.AutoSize = True
        Me.rbtRegistrarse.Location = New System.Drawing.Point(279, 238)
        Me.rbtRegistrarse.Name = "rbtRegistrarse"
        Me.rbtRegistrarse.Size = New System.Drawing.Size(76, 17)
        Me.rbtRegistrarse.TabIndex = 6
        Me.rbtRegistrarse.TabStop = True
        Me.rbtRegistrarse.Text = "Registrarte"
        Me.rbtRegistrarse.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(349, 292)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Repetir contraseña"
        '
        'txtUsuarioNombre
        '
        Me.txtUsuarioNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUsuarioNombre.Location = New System.Drawing.Point(236, 102)
        Me.txtUsuarioNombre.Name = "txtUsuarioNombre"
        Me.txtUsuarioNombre.Size = New System.Drawing.Size(179, 20)
        Me.txtUsuarioNombre.TabIndex = 10
        '
        'txtRepetirContrasena
        '
        Me.txtRepetirContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtRepetirContrasena.Location = New System.Drawing.Point(228, 184)
        Me.txtRepetirContrasena.Name = "txtRepetirContrasena"
        Me.txtRepetirContrasena.Size = New System.Drawing.Size(179, 20)
        Me.txtRepetirContrasena.TabIndex = 10
        '
        'Titulo
        '
        Me.Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titulo.ForeColor = System.Drawing.Color.White
        Me.Titulo.Location = New System.Drawing.Point(3, 9)
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(82, 67)
        Me.Titulo.TabIndex = 11
        Me.Titulo.Text = "W"
        Me.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(98, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 67)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "O"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(191, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 67)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "R"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(284, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 67)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "D"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(377, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 67)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "L"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(470, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 67)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "E"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(554, 365)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.txtRepetirContrasena)
        Me.Controls.Add(Me.txtUsuarioNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbtRegistrarse)
        Me.Controls.Add(Me.rbtIniciarSesion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLoginRegister)
        Me.Controls.Add(Me.txtContrasena)
        Me.Name = "FrmUsuarios"
        Me.Text = "FrmUsuarios"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsuarioNombre As TextBox
    Friend WithEvents txtRepetirContrasena As TextBox
    Friend WithEvents Titulo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
