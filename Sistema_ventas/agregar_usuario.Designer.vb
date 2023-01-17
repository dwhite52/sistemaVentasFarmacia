<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_usuario
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
        Me.txtnom_usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtconfpass = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btncancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbtipousuario = New System.Windows.Forms.ComboBox()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " Nombre de Usuario"
        '
        'txtnom_usuario
        '
        Me.txtnom_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnom_usuario.Location = New System.Drawing.Point(258, 125)
        Me.txtnom_usuario.Name = "txtnom_usuario"
        Me.txtnom_usuario.Size = New System.Drawing.Size(180, 24)
        Me.txtnom_usuario.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(143, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(258, 170)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(180, 24)
        Me.txtpass.TabIndex = 5
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(62, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Confirmar Contraseña"
        '
        'txtconfpass
        '
        Me.txtconfpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfpass.Location = New System.Drawing.Point(258, 214)
        Me.txtconfpass.Name = "txtconfpass"
        Me.txtconfpass.Size = New System.Drawing.Size(180, 24)
        Me.txtconfpass.TabIndex = 7
        Me.txtconfpass.UseSystemPasswordChar = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Btncancelar)
        Me.GroupBox4.Controls.Add(Me.btnGuardar)
        Me.GroupBox4.Location = New System.Drawing.Point(111, 304)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(292, 83)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        '
        'Btncancelar
        '
        Me.Btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncancelar.ForeColor = System.Drawing.Color.Teal
        Me.Btncancelar.Image = Global.Sistema_ventas.My.Resources.Resources.Cancel
        Me.Btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btncancelar.Location = New System.Drawing.Point(150, 16)
        Me.Btncancelar.Name = "Btncancelar"
        Me.Btncancelar.Size = New System.Drawing.Size(118, 47)
        Me.Btncancelar.TabIndex = 1
        Me.Btncancelar.Text = "Cancelar"
        Me.Btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btncancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Teal
        Me.btnGuardar.Image = Global.Sistema_ventas.My.Resources.Resources.save1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(19, 16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 47)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(107, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tipo de Usuario"
        '
        'cmbtipousuario
        '
        Me.cmbtipousuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbtipousuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipousuario.FormattingEnabled = True
        Me.cmbtipousuario.Items.AddRange(New Object() {"Administrador", "Cajero", "Bodega"})
        Me.cmbtipousuario.Location = New System.Drawing.Point(258, 263)
        Me.cmbtipousuario.Name = "cmbtipousuario"
        Me.cmbtipousuario.Size = New System.Drawing.Size(166, 24)
        Me.cmbtipousuario.TabIndex = 11
        '
        'Lbltitulo
        '
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbltitulo.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.Color.White
        Me.Lbltitulo.Location = New System.Drawing.Point(129, 87)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(218, 25)
        Me.Lbltitulo.TabIndex = 51
        Me.Lbltitulo.Text = "REGISTRAR USUARIO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_ventas.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(111, -32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 52
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
        Me.Button2.Location = New System.Drawing.Point(453, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 46)
        Me.Button2.TabIndex = 65
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'agregar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(489, 399)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Lbltitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbtipousuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtconfpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnom_usuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "agregar_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregar_usuario"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnom_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtconfpass As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbtipousuario As System.Windows.Forms.ComboBox
    Friend WithEvents Lbltitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
