<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lstClasificacion.Location = New System.Drawing.Point(229, 86)
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
        Me.lstPuntuacion.Location = New System.Drawing.Point(545, 86)
        Me.lstPuntuacion.Name = "lstPuntuacion"
        Me.lstPuntuacion.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstPuntuacion.Size = New System.Drawing.Size(181, 275)
        Me.lstPuntuacion.TabIndex = 4
        '
        'FrmClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstPuntuacion)
        Me.Controls.Add(Me.lstClasificacion)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmClasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstClasificacion As ListBox
    Friend WithEvents lstPuntuacion As ListBox
End Class
