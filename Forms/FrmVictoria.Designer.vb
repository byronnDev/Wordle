﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¡HAS GANADO!"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(252, 248)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "CERRAR"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblIntentos
        '
        Me.lblIntentos.AutoSize = True
        Me.lblIntentos.Location = New System.Drawing.Point(192, 132)
        Me.lblIntentos.Name = "lblIntentos"
        Me.lblIntentos.Size = New System.Drawing.Size(51, 13)
        Me.lblIntentos.TabIndex = 2
        Me.lblIntentos.Text = "Intentos: "
        '
        'lblVictorias
        '
        Me.lblVictorias.AutoSize = True
        Me.lblVictorias.Location = New System.Drawing.Point(191, 166)
        Me.lblVictorias.Name = "lblVictorias"
        Me.lblVictorias.Size = New System.Drawing.Size(53, 13)
        Me.lblVictorias.TabIndex = 3
        Me.lblVictorias.Text = "Victorias: "
        '
        'FrmVictoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblVictorias)
        Me.Controls.Add(Me.lblIntentos)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmVictoria"
        Me.Text = "Victoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblIntentos As Label
    Friend WithEvents lblVictorias As Label
End Class