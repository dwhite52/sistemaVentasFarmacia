﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Avisoprodexpirar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Avisoprodexpirar))
        Me.Txtdias = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.TxtIdProv = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Txtdias
        '
        Me.Txtdias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdias.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Txtdias.Location = New System.Drawing.Point(84, 114)
        Me.Txtdias.Name = "Txtdias"
        Me.Txtdias.Size = New System.Drawing.Size(116, 22)
        Me.Txtdias.TabIndex = 0
        Me.Txtdias.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(13, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AVISARME "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(206, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DIAS ANTES DE LA FECHA DE EXPIRACION"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SELECCIONE UN PRODUCTO"
        '
        'Btnbuscar
        '
        Me.Btnbuscar.BackColor = System.Drawing.Color.White
        Me.Btnbuscar.FlatAppearance.BorderSize = 0
        Me.Btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbuscar.ForeColor = System.Drawing.Color.White
        Me.Btnbuscar.Image = CType(resources.GetObject("Btnbuscar.Image"), System.Drawing.Image)
        Me.Btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnbuscar.Location = New System.Drawing.Point(250, 51)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(24, 29)
        Me.Btnbuscar.TabIndex = 8
        Me.Btnbuscar.UseVisualStyleBackColor = False
        '
        'TxtIdProv
        '
        Me.TxtIdProv.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtIdProv.Location = New System.Drawing.Point(24, 50)
        Me.TxtIdProv.Multiline = True
        Me.TxtIdProv.Name = "TxtIdProv"
        Me.TxtIdProv.ReadOnly = True
        Me.TxtIdProv.Size = New System.Drawing.Size(244, 31)
        Me.TxtIdProv.TabIndex = 7
        '
        'Avisoprodexpirar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(459, 209)
        Me.Controls.Add(Me.Btnbuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtdias)
        Me.Controls.Add(Me.TxtIdProv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Avisoprodexpirar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avisoprodexpirar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtdias As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents TxtIdProv As System.Windows.Forms.TextBox
End Class
