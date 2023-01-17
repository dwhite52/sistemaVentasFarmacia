<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class validar_pass_productos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtpass = New System.Windows.Forms.TextBox()
        Me.Btnok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese su contraseña:"
        '
        'Txtpass
        '
        Me.Txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpass.Location = New System.Drawing.Point(24, 36)
        Me.Txtpass.Name = "Txtpass"
        Me.Txtpass.Size = New System.Drawing.Size(185, 22)
        Me.Txtpass.TabIndex = 1
        Me.Txtpass.UseSystemPasswordChar = True
        '
        'Btnok
        '
        Me.Btnok.AllowDrop = True
        Me.Btnok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Btnok.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btnok.Location = New System.Drawing.Point(227, 33)
        Me.Btnok.Name = "Btnok"
        Me.Btnok.Size = New System.Drawing.Size(34, 23)
        Me.Btnok.TabIndex = 2
        Me.Btnok.Text = "OK"
        Me.Btnok.UseVisualStyleBackColor = False
        '
        'validar_pass_productos
        '
        Me.AcceptButton = Me.Btnok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 79)
        Me.Controls.Add(Me.Btnok)
        Me.Controls.Add(Me.Txtpass)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "validar_pass_productos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Btnok As System.Windows.Forms.Button
End Class
