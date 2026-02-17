<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.btnSaludo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaludo
        '
        Me.btnSaludo.Location = New System.Drawing.Point(230, 374)
        Me.btnSaludo.Name = "btnSaludo"
        Me.btnSaludo.Size = New System.Drawing.Size(277, 37)
        Me.btnSaludo.TabIndex = 0
        Me.btnSaludo.Text = "Saludo"
        Me.btnSaludo.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSaludo)
        Me.Name = "frmPrincipal"
        Me.Text = "Formulario Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSaludo As Button
End Class
