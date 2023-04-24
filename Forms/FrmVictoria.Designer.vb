<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVictoria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lblIntentos = New System.Windows.Forms.Label()
        Me.lblVictorias = New System.Windows.Forms.Label()
        Me.lblNumIntentos = New System.Windows.Forms.Label()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¡HAS GANADO!"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(336, 305)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(100, 28)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "CERRAR"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblIntentos
        '
        Me.lblIntentos.AutoSize = True
        Me.lblIntentos.Location = New System.Drawing.Point(256, 162)
        Me.lblIntentos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIntentos.Name = "lblIntentos"
        Me.lblIntentos.Size = New System.Drawing.Size(59, 16)
        Me.lblIntentos.TabIndex = 2
        Me.lblIntentos.Text = "Intentos: "
        '
        'lblVictorias
        '
        Me.lblVictorias.AutoSize = True
        Me.lblVictorias.Location = New System.Drawing.Point(255, 204)
        Me.lblVictorias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVictorias.Name = "lblVictorias"
        Me.lblVictorias.Size = New System.Drawing.Size(65, 16)
        Me.lblVictorias.TabIndex = 3
        Me.lblVictorias.Text = "Victorias: "
        '
        'lblNumIntentos
        '
        Me.lblNumIntentos.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblNumIntentos.Location = New System.Drawing.Point(327, 162)
        Me.lblNumIntentos.Name = "lblNumIntentos"
        Me.lblNumIntentos.Size = New System.Drawing.Size(100, 23)
        Me.lblNumIntentos.TabIndex = 4
        '
        'lblWins
        '
        Me.lblWins.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblWins.Location = New System.Drawing.Point(327, 194)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(100, 26)
        Me.lblWins.TabIndex = 5
        '
        'FrmVictoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.lblNumIntentos)
        Me.Controls.Add(Me.lblVictorias)
        Me.Controls.Add(Me.lblIntentos)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmVictoria"
        Me.Text = "Victoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblIntentos As Label
    Friend WithEvents lblVictorias As Label
    Friend WithEvents lblNumIntentos As Label
    Friend WithEvents lblWins As Label
End Class
