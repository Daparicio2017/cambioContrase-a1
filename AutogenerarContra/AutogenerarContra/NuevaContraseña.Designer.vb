<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaContraseña
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNuevacontra = New System.Windows.Forms.TextBox()
        Me.TxtConfirmar = New System.Windows.Forms.TextBox()
        Me.BtnCambiarcontra = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtContanterior = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña nueva"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Confirmar contraseña"
        '
        'TxtNuevacontra
        '
        Me.TxtNuevacontra.Location = New System.Drawing.Point(209, 98)
        Me.TxtNuevacontra.Name = "TxtNuevacontra"
        Me.TxtNuevacontra.Size = New System.Drawing.Size(139, 20)
        Me.TxtNuevacontra.TabIndex = 2
        '
        'TxtConfirmar
        '
        Me.TxtConfirmar.Location = New System.Drawing.Point(209, 156)
        Me.TxtConfirmar.Name = "TxtConfirmar"
        Me.TxtConfirmar.Size = New System.Drawing.Size(139, 20)
        Me.TxtConfirmar.TabIndex = 3
        '
        'BtnCambiarcontra
        '
        Me.BtnCambiarcontra.Location = New System.Drawing.Point(209, 226)
        Me.BtnCambiarcontra.Name = "BtnCambiarcontra"
        Me.BtnCambiarcontra.Size = New System.Drawing.Size(85, 42)
        Me.BtnCambiarcontra.TabIndex = 4
        Me.BtnCambiarcontra.Text = "Cambiar Contraseña"
        Me.BtnCambiarcontra.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña anterior"
        '
        'TxtContanterior
        '
        Me.TxtContanterior.Location = New System.Drawing.Point(209, 39)
        Me.TxtContanterior.Name = "TxtContanterior"
        Me.TxtContanterior.Size = New System.Drawing.Size(139, 20)
        Me.TxtContanterior.TabIndex = 6
        '
        'NuevaContraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 308)
        Me.Controls.Add(Me.TxtContanterior)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCambiarcontra)
        Me.Controls.Add(Me.TxtConfirmar)
        Me.Controls.Add(Me.TxtNuevacontra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NuevaContraseña"
        Me.Text = "NuevaContraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNuevacontra As TextBox
    Friend WithEvents TxtConfirmar As TextBox
    Friend WithEvents BtnCambiarcontra As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtContanterior As TextBox
End Class
