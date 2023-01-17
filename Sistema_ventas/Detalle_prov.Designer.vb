<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle_prov
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnumfact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.mtxtfecha = New System.Windows.Forms.MaskedTextBox()
        Me.Btnprim = New System.Windows.Forms.Button()
        Me.Btnsig = New System.Windows.Forms.Button()
        Me.Btnultimo = New System.Windows.Forms.Button()
        Me.Btnanterior = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(71, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 22)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "N° Factura "
        '
        'txtnumfact
        '
        Me.txtnumfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumfact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtnumfact.Location = New System.Drawing.Point(214, 346)
        Me.txtnumfact.Name = "txtnumfact"
        Me.txtnumfact.ReadOnly = True
        Me.txtnumfact.Size = New System.Drawing.Size(131, 26)
        Me.txtnumfact.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(62, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 22)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fecha de Ingreso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre Comercial"
        '
        'txtnom
        '
        Me.txtnom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtnom.Location = New System.Drawing.Point(214, 201)
        Me.txtnom.Multiline = True
        Me.txtnom.Name = "txtnom"
        Me.txtnom.ReadOnly = True
        Me.txtnom.Size = New System.Drawing.Size(188, 28)
        Me.txtnom.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Codigo de Proveedor"
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtcodigo.Location = New System.Drawing.Point(214, 154)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.ReadOnly = True
        Me.txtcodigo.Size = New System.Drawing.Size(188, 26)
        Me.txtcodigo.TabIndex = 17
        '
        'mtxtfecha
        '
        Me.mtxtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtfecha.Location = New System.Drawing.Point(217, 264)
        Me.mtxtfecha.Mask = "00/00/0000"
        Me.mtxtfecha.Name = "mtxtfecha"
        Me.mtxtfecha.ReadOnly = True
        Me.mtxtfecha.Size = New System.Drawing.Size(106, 24)
        Me.mtxtfecha.TabIndex = 26
        Me.mtxtfecha.ValidatingType = GetType(Date)
        '
        'Btnprim
        '
        Me.Btnprim.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprim.Location = New System.Drawing.Point(46, 387)
        Me.Btnprim.Name = "Btnprim"
        Me.Btnprim.Size = New System.Drawing.Size(75, 28)
        Me.Btnprim.TabIndex = 27
        Me.Btnprim.Text = "|<<"
        Me.Btnprim.UseVisualStyleBackColor = True
        '
        'Btnsig
        '
        Me.Btnsig.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsig.Location = New System.Drawing.Point(241, 387)
        Me.Btnsig.Name = "Btnsig"
        Me.Btnsig.Size = New System.Drawing.Size(75, 28)
        Me.Btnsig.TabIndex = 28
        Me.Btnsig.Text = ">|"
        Me.Btnsig.UseVisualStyleBackColor = True
        '
        'Btnultimo
        '
        Me.Btnultimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnultimo.Location = New System.Drawing.Point(322, 387)
        Me.Btnultimo.Name = "Btnultimo"
        Me.Btnultimo.Size = New System.Drawing.Size(75, 28)
        Me.Btnultimo.TabIndex = 29
        Me.Btnultimo.Text = ">>|"
        Me.Btnultimo.UseVisualStyleBackColor = True
        '
        'Btnanterior
        '
        Me.Btnanterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnanterior.Location = New System.Drawing.Point(127, 387)
        Me.Btnanterior.Name = "Btnanterior"
        Me.Btnanterior.Size = New System.Drawing.Size(75, 28)
        Me.Btnanterior.TabIndex = 30
        Me.Btnanterior.Text = "|<"
        Me.Btnanterior.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(71, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 22)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Cantidad"
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtcantidad.Location = New System.Drawing.Point(214, 307)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.ReadOnly = True
        Me.txtcantidad.Size = New System.Drawing.Size(131, 26)
        Me.txtcantidad.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_ventas.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(75, -44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(123, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 22)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "PROVEEDOR DEL ITEM"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Teal
        Me.Button1.Image = Global.Sistema_ventas.My.Resources.Resources.back
        Me.Button1.Location = New System.Drawing.Point(409, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 46)
        Me.Button1.TabIndex = 51
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Detalle_prov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(473, 420)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Btnanterior)
        Me.Controls.Add(Me.Btnultimo)
        Me.Controls.Add(Me.Btnsig)
        Me.Controls.Add(Me.Btnprim)
        Me.Controls.Add(Me.mtxtfecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnumfact)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtcodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Detalle_prov"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnumfact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents mtxtfecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Btnprim As System.Windows.Forms.Button
    Friend WithEvents Btnsig As System.Windows.Forms.Button
    Friend WithEvents Btnultimo As System.Windows.Forms.Button
    Friend WithEvents Btnanterior As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
