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
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtRepetirContrasena = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnLoginRegister = New System.Windows.Forms.Button()
        Me.lblRepertirContrasena = New System.Windows.Forms.Label()
        Me.chcRegister = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(236, 65)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'txtRepetirContrasena
        '
        Me.txtRepetirContrasena.Location = New System.Drawing.Point(223, 142)
        Me.txtRepetirContrasena.Name = "txtRepetirContrasena"
        Me.txtRepetirContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtRepetirContrasena.TabIndex = 1
        Me.txtRepetirContrasena.Visible = False
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(223, 102)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 2
        '
        'btnLoginRegister
        '
        Me.btnLoginRegister.Location = New System.Drawing.Point(247, 220)
        Me.btnLoginRegister.Name = "btnLoginRegister"
        Me.btnLoginRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnLoginRegister.TabIndex = 3
        Me.btnLoginRegister.Text = "Button1"
        Me.btnLoginRegister.UseVisualStyleBackColor = True
        '
        'lblRepertirContrasena
        '
        Me.lblRepertirContrasena.AutoSize = True
        Me.lblRepertirContrasena.Location = New System.Drawing.Point(57, 148)
        Me.lblRepertirContrasena.Name = "lblRepertirContrasena"
        Me.lblRepertirContrasena.Size = New System.Drawing.Size(39, 13)
        Me.lblRepertirContrasena.TabIndex = 4
        Me.lblRepertirContrasena.Text = "Label1"
        Me.lblRepertirContrasena.Visible = False
        '
        'chcRegister
        '
        Me.chcRegister.AutoSize = True
        Me.chcRegister.Location = New System.Drawing.Point(247, 185)
        Me.chcRegister.Name = "chcRegister"
        Me.chcRegister.Size = New System.Drawing.Size(81, 17)
        Me.chcRegister.TabIndex = 5
        Me.chcRegister.Text = "CheckBox1"
        Me.chcRegister.UseVisualStyleBackColor = True
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chcRegister)
        Me.Controls.Add(Me.lblRepertirContrasena)
        Me.Controls.Add(Me.btnLoginRegister)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtRepetirContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Name = "FrmUsuarios"
        Me.Text = "FrmUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtRepetirContrasena As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnLoginRegister As Button
    Friend WithEvents lblRepertirContrasena As Label
    Friend WithEvents chcRegister As CheckBox
End Class
