<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dolar
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
        Me.Lblcnatidaddolar = New System.Windows.Forms.Label()
        Me.Lbltipocambio = New System.Windows.Forms.Label()
        Me.Txtcantidaddolar = New System.Windows.Forms.TextBox()
        Me.txttipodecambio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalcor = New System.Windows.Forms.Label()
        Me.Btnok = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lblcnatidaddolar
        '
        Me.Lblcnatidaddolar.AutoSize = True
        Me.Lblcnatidaddolar.BackColor = System.Drawing.Color.Transparent
        Me.Lblcnatidaddolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcnatidaddolar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lblcnatidaddolar.Location = New System.Drawing.Point(3, 44)
        Me.Lblcnatidaddolar.Name = "Lblcnatidaddolar"
        Me.Lblcnatidaddolar.Size = New System.Drawing.Size(66, 18)
        Me.Lblcnatidaddolar.TabIndex = 0
        Me.Lblcnatidaddolar.Text = "Cantidad"
        '
        'Lbltipocambio
        '
        Me.Lbltipocambio.AutoSize = True
        Me.Lbltipocambio.BackColor = System.Drawing.Color.Transparent
        Me.Lbltipocambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltipocambio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbltipocambio.Location = New System.Drawing.Point(160, 44)
        Me.Lbltipocambio.Name = "Lbltipocambio"
        Me.Lbltipocambio.Size = New System.Drawing.Size(162, 18)
        Me.Lbltipocambio.TabIndex = 1
        Me.Lbltipocambio.Text = "Tipo de Cambio del Dia"
        '
        'Txtcantidaddolar
        '
        Me.Txtcantidaddolar.Location = New System.Drawing.Point(68, 42)
        Me.Txtcantidaddolar.Name = "Txtcantidaddolar"
        Me.Txtcantidaddolar.Size = New System.Drawing.Size(86, 20)
        Me.Txtcantidaddolar.TabIndex = 2
        '
        'txttipodecambio
        '
        Me.txttipodecambio.Location = New System.Drawing.Point(323, 44)
        Me.txttipodecambio.Name = "txttipodecambio"
        Me.txttipodecambio.Size = New System.Drawing.Size(86, 20)
        Me.txttipodecambio.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(122, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total C$"
        '
        'lblTotalcor
        '
        Me.lblTotalcor.AutoSize = True
        Me.lblTotalcor.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalcor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalcor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotalcor.Location = New System.Drawing.Point(198, 102)
        Me.lblTotalcor.Name = "lblTotalcor"
        Me.lblTotalcor.Size = New System.Drawing.Size(0, 18)
        Me.lblTotalcor.TabIndex = 5
        '
        'Btnok
        '
        Me.Btnok.AllowDrop = True
        Me.Btnok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Btnok.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btnok.Location = New System.Drawing.Point(192, 127)
        Me.Btnok.Name = "Btnok"
        Me.Btnok.Size = New System.Drawing.Size(34, 23)
        Me.Btnok.TabIndex = 6
        Me.Btnok.Text = "OK"
        Me.Btnok.UseVisualStyleBackColor = False
        '
        'dolar
        '
        Me.AcceptButton = Me.Btnok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(418, 155)
        Me.Controls.Add(Me.Btnok)
        Me.Controls.Add(Me.lblTotalcor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttipodecambio)
        Me.Controls.Add(Me.Txtcantidaddolar)
        Me.Controls.Add(Me.Lbltipocambio)
        Me.Controls.Add(Me.Lblcnatidaddolar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dolar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dolar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lblcnatidaddolar As System.Windows.Forms.Label
    Friend WithEvents Lbltipocambio As System.Windows.Forms.Label
    Friend WithEvents Txtcantidaddolar As System.Windows.Forms.TextBox
    Friend WithEvents txttipodecambio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalcor As System.Windows.Forms.Label
    Friend WithEvents Btnok As System.Windows.Forms.Button
End Class
