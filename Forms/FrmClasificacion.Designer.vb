﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClasificacion
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
        Me.lstClasificacion = New System.Windows.Forms.ListBox()
        Me.lstPuntuacion = New System.Windows.Forms.ListBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblUsuarios = New System.Windows.Forms.Label()
        Me.lblPuntos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstClasificacion
        '
        Me.lstClasificacion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lstClasificacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstClasificacion.ForeColor = System.Drawing.Color.Black
        Me.lstClasificacion.FormattingEnabled = True
        Me.lstClasificacion.ItemHeight = 25
        Me.lstClasificacion.Location = New System.Drawing.Point(137, 124)
        Me.lstClasificacion.Name = "lstClasificacion"
        Me.lstClasificacion.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstClasificacion.Size = New System.Drawing.Size(310, 275)
        Me.lstClasificacion.TabIndex = 3
        '
        'lstPuntuacion
        '
        Me.lstPuntuacion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lstPuntuacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstPuntuacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPuntuacion.ForeColor = System.Drawing.Color.Black
        Me.lstPuntuacion.FormattingEnabled = True
        Me.lstPuntuacion.ItemHeight = 25
        Me.lstPuntuacion.Location = New System.Drawing.Point(453, 124)
        Me.lstPuntuacion.Name = "lstPuntuacion"
        Me.lstPuntuacion.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstPuntuacion.Size = New System.Drawing.Size(181, 275)
        Me.lstPuntuacion.TabIndex = 4
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(198, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(423, 76)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "TOP 10 USUARIOS CON " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MAYOR PUNTUACIÓN"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsuarios.Location = New System.Drawing.Point(132, 96)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(97, 25)
        Me.lblUsuarios.TabIndex = 6
        Me.lblUsuarios.Text = "Usuarios"
        '
        'lblPuntos
        '
        Me.lblPuntos.AutoSize = True
        Me.lblPuntos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPuntos.Location = New System.Drawing.Point(448, 96)
        Me.lblPuntos.Name = "lblPuntos"
        Me.lblPuntos.Size = New System.Drawing.Size(79, 25)
        Me.lblPuntos.TabIndex = 7
        Me.lblPuntos.Text = "Puntos"
        '
        'FrmClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPuntos)
        Me.Controls.Add(Me.lblUsuarios)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lstPuntuacion)
        Me.Controls.Add(Me.lstClasificacion)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmClasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstClasificacion As ListBox
    Friend WithEvents lstPuntuacion As ListBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblUsuarios As Label
    Friend WithEvents lblPuntos As Label
End Class
