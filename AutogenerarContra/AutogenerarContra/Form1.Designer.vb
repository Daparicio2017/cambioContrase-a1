<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnContra = New System.Windows.Forms.Button()
        Me.TxtCambio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnContra
        '
        Me.BtnContra.Location = New System.Drawing.Point(124, 221)
        Me.BtnContra.Name = "BtnContra"
        Me.BtnContra.Size = New System.Drawing.Size(87, 42)
        Me.BtnContra.TabIndex = 0
        Me.BtnContra.Text = "Generar Contraseña"
        Me.BtnContra.UseVisualStyleBackColor = True
        '
        'TxtCambio
        '
        Me.TxtCambio.Location = New System.Drawing.Point(199, 109)
        Me.TxtCambio.Name = "TxtCambio"
        Me.TxtCambio.Size = New System.Drawing.Size(192, 20)
        Me.TxtCambio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contraseña nueva"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cambiar Contraseña"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 369)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCambio)
        Me.Controls.Add(Me.BtnContra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnContra As Button
    Friend WithEvents TxtCambio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
