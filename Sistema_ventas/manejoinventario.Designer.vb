<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manejoinventario
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
        Me.dtpf_exp = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdescprod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcodprod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.cmbclasificacion = New System.Windows.Forms.ComboBox()
        Me.txtprecioventa = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpf_exp
        '
        Me.dtpf_exp.CalendarFont = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpf_exp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpf_exp.Location = New System.Drawing.Point(682, 278)
        Me.dtpf_exp.Name = "dtpf_exp"
        Me.dtpf_exp.Size = New System.Drawing.Size(301, 24)
        Me.dtpf_exp.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(480, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 22)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Fecha de Expiracion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(519, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 22)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Precio de venta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(540, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 22)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Clasificacion"
        '
        'txtdescprod
        '
        Me.txtdescprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescprod.Location = New System.Drawing.Point(229, 237)
        Me.txtdescprod.Multiline = True
        Me.txtdescprod.Name = "txtdescprod"
        Me.txtdescprod.Size = New System.Drawing.Size(210, 37)
        Me.txtdescprod.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(3, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(198, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Descripcion del producto"
        '
        'txtcosto
        '
        Me.txtcosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto.Location = New System.Drawing.Point(228, 297)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(210, 24)
        Me.txtcosto.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(143, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Costo"
        '
        'txtcodprod
        '
        Me.txtcodprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodprod.Location = New System.Drawing.Point(228, 190)
        Me.txtcodprod.Name = "txtcodprod"
        Me.txtcodprod.ReadOnly = True
        Me.txtcodprod.Size = New System.Drawing.Size(210, 24)
        Me.txtcodprod.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(32, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 22)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Codigo del Producto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(356, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(307, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "EDITAR DATOS DEl PRODUCTO"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGuardar.Image = Global.Sistema_ventas.My.Resources.Resources.save_changes
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(330, 396)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(184, 40)
        Me.btnGuardar.TabIndex = 27
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.Black
        Me.btncancelar.Image = Global.Sistema_ventas.My.Resources.Resources.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(549, 398)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(138, 38)
        Me.btncancelar.TabIndex = 28
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'cmbclasificacion
        '
        Me.cmbclasificacion.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbclasificacion.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbclasificacion.FormattingEnabled = True
        Me.cmbclasificacion.Items.AddRange(New Object() {"Suspension", "Jarabe", "Gotas ", "Tabletas", "Inyeccion", "Caramelo", "Ampollas Bebibles", "Sobres", "Gel", "Pasta", "Locion", "Crema", "Leche", "Alcohol", "Spray", "Supositorio", "Ovulos", "Rollos", "Frasco", "Suero", "Algodon", "Shampoo", "Unguento", "Capsulas", "Efervescente", "Jabon", "Jeringa", "Otros"})
        Me.cmbclasificacion.Location = New System.Drawing.Point(682, 191)
        Me.cmbclasificacion.Name = "cmbclasificacion"
        Me.cmbclasificacion.Size = New System.Drawing.Size(192, 27)
        Me.cmbclasificacion.TabIndex = 29
        '
        'txtprecioventa
        '
        Me.txtprecioventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecioventa.Location = New System.Drawing.Point(682, 235)
        Me.txtprecioventa.Name = "txtprecioventa"
        Me.txtprecioventa.Size = New System.Drawing.Size(210, 24)
        Me.txtprecioventa.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_ventas.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(343, -44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Teal
        Me.Button2.Image = Global.Sistema_ventas.My.Resources.Resources.back
        Me.Button2.Location = New System.Drawing.Point(972, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 46)
        Me.Button2.TabIndex = 51
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'manejoinventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1009, 493)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbclasificacion)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dtpf_exp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtprecioventa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdescprod)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtcosto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcodprod)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "manejoinventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manejoinventario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpf_exp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdescprod As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcosto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcodprod As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents cmbclasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents txtprecioventa As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
