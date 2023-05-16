<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAyuda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAyuda))
        Me.lblAyuda = New System.Windows.Forms.Label()
        Me.lblTituloAyuda = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAyuda
        '
        Me.lblAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.Location = New System.Drawing.Point(12, 73)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(474, 334)
        Me.lblAyuda.TabIndex = 0
        Me.lblAyuda.Text = resources.GetString("lblAyuda.Text")
        '
        'lblTituloAyuda
        '
        Me.lblTituloAyuda.AutoSize = True
        Me.lblTituloAyuda.Font = New System.Drawing.Font("hooge 05_53", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloAyuda.Location = New System.Drawing.Point(149, 9)
        Me.lblTituloAyuda.Name = "lblTituloAyuda"
        Me.lblTituloAyuda.Size = New System.Drawing.Size(183, 54)
        Me.lblTituloAyuda.TabIndex = 1
        Me.lblTituloAyuda.Text = "AYUDA"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("hooge 05_53", 25.8!)
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(90, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 55)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "💡"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("hooge 05_53", 25.8!)
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(328, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 55)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "💡"
        '
        'FrmAyuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 395)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTituloAyuda)
        Me.Controls.Add(Me.lblAyuda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAyuda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ayuda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAyuda As Label
    Friend WithEvents lblTituloAyuda As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
