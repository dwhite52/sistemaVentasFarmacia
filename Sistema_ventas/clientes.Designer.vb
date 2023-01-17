<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clientes
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Btncancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Pandir = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtdir1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmbtipodir1 = New System.Windows.Forms.ComboBox()
        Me.Btndiragregar = New System.Windows.Forms.Button()
        Me.txtdir = New System.Windows.Forms.TextBox()
        Me.lbltipodir = New System.Windows.Forms.Label()
        Me.lbldir = New System.Windows.Forms.Label()
        Me.cmbtipodir = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pantel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttel1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmbtipotel1 = New System.Windows.Forms.ComboBox()
        Me.Btntelagregar = New System.Windows.Forms.Button()
        Me.lbltipotel = New System.Windows.Forms.Label()
        Me.txtnumtel = New System.Windows.Forms.TextBox()
        Me.lbltel = New System.Windows.Forms.Label()
        Me.cmbtipotel = New System.Windows.Forms.ComboBox()
        Me.lblced = New System.Windows.Forms.Label()
        Me.lblapell = New System.Windows.Forms.Label()
        Me.lblnomb = New System.Windows.Forms.Label()
        Me.lblCodcliente = New System.Windows.Forms.Label()
        Me.txtapell = New System.Windows.Forms.TextBox()
        Me.txtnomb = New System.Windows.Forms.TextBox()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.txtced = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Pandir.SuspendLayout()
        Me.pantel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(2, -25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1113, 104)
        Me.Panel2.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_ventas.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(437, -15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(466, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "REGISTRO DE CLIENTES"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btncancelar)
        Me.GroupBox4.Controls.Add(Me.btnGuardar)
        Me.GroupBox4.Location = New System.Drawing.Point(385, 489)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(292, 83)
        Me.GroupBox4.TabIndex = 69
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
        Me.Btncancelar.TabIndex = 68
        Me.Btncancelar.Text = "Cancelar"
        Me.Btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btncancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Teal
        Me.btnGuardar.Image = Global.Sistema_ventas.My.Resources.Resources.save1
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(19, 16)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 47)
        Me.btnGuardar.TabIndex = 66
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Pandir)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.pantel)
        Me.GroupBox1.Controls.Add(Me.lblced)
        Me.GroupBox1.Controls.Add(Me.lblapell)
        Me.GroupBox1.Controls.Add(Me.lblnomb)
        Me.GroupBox1.Controls.Add(Me.lblCodcliente)
        Me.GroupBox1.Controls.Add(Me.txtapell)
        Me.GroupBox1.Controls.Add(Me.txtnomb)
        Me.GroupBox1.Controls.Add(Me.txtcodcliente)
        Me.GroupBox1.Controls.Add(Me.txtced)
        Me.GroupBox1.Font = New System.Drawing.Font("Bodoni MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(39, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(941, 471)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(500, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 25)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Direccion"
        '
        'Pandir
        '
        Me.Pandir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pandir.Controls.Add(Me.Button3)
        Me.Pandir.Controls.Add(Me.txtdir1)
        Me.Pandir.Controls.Add(Me.Label3)
        Me.Pandir.Controls.Add(Me.Label4)
        Me.Pandir.Controls.Add(Me.Cmbtipodir1)
        Me.Pandir.Controls.Add(Me.Btndiragregar)
        Me.Pandir.Controls.Add(Me.txtdir)
        Me.Pandir.Controls.Add(Me.lbltipodir)
        Me.Pandir.Controls.Add(Me.lbldir)
        Me.Pandir.Controls.Add(Me.cmbtipodir)
        Me.Pandir.Location = New System.Drawing.Point(505, 265)
        Me.Pandir.Name = "Pandir"
        Me.Pandir.Size = New System.Drawing.Size(408, 96)
        Me.Pandir.TabIndex = 38
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Image = Global.Sistema_ventas.My.Resources.Resources.Everaldo_Crystal_Clear_Action_arrow_blue_up
        Me.Button3.Location = New System.Drawing.Point(335, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 27)
        Me.Button3.TabIndex = 37
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtdir1
        '
        Me.txtdir1.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdir1.Location = New System.Drawing.Point(155, 93)
        Me.txtdir1.Multiline = True
        Me.txtdir1.Name = "txtdir1"
        Me.txtdir1.Size = New System.Drawing.Size(246, 32)
        Me.txtdir1.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(47, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 23)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 23)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Direccion Exacta"
        '
        'Cmbtipodir1
        '
        Me.Cmbtipodir1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Cmbtipodir1.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbtipodir1.FormattingEnabled = True
        Me.Cmbtipodir1.Items.AddRange(New Object() {"DOMICILIO", "TRABAJO"})
        Me.Cmbtipodir1.Location = New System.Drawing.Point(156, 134)
        Me.Cmbtipodir1.Name = "Cmbtipodir1"
        Me.Cmbtipodir1.Size = New System.Drawing.Size(121, 26)
        Me.Cmbtipodir1.TabIndex = 32
        Me.Cmbtipodir1.Text = "TRABAJO"
        '
        'Btndiragregar
        '
        Me.Btndiragregar.FlatAppearance.BorderSize = 0
        Me.Btndiragregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndiragregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btndiragregar.Image = Global.Sistema_ventas.My.Resources.Resources.Add
        Me.Btndiragregar.Location = New System.Drawing.Point(326, 45)
        Me.Btndiragregar.Name = "Btndiragregar"
        Me.Btndiragregar.Size = New System.Drawing.Size(46, 34)
        Me.Btndiragregar.TabIndex = 31
        Me.Btndiragregar.UseVisualStyleBackColor = True
        '
        'txtdir
        '
        Me.txtdir.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdir.Location = New System.Drawing.Point(155, 11)
        Me.txtdir.Multiline = True
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(246, 32)
        Me.txtdir.TabIndex = 30
        '
        'lbltipodir
        '
        Me.lbltipodir.AutoSize = True
        Me.lbltipodir.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipodir.ForeColor = System.Drawing.Color.White
        Me.lbltipodir.Location = New System.Drawing.Point(47, 52)
        Me.lbltipodir.Name = "lbltipodir"
        Me.lbltipodir.Size = New System.Drawing.Size(47, 23)
        Me.lbltipodir.TabIndex = 28
        Me.lbltipodir.Text = "Tipo"
        '
        'lbldir
        '
        Me.lbldir.AutoSize = True
        Me.lbldir.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldir.ForeColor = System.Drawing.Color.White
        Me.lbldir.Location = New System.Drawing.Point(13, 14)
        Me.lbldir.Name = "lbldir"
        Me.lbldir.Size = New System.Drawing.Size(146, 23)
        Me.lbldir.TabIndex = 29
        Me.lbldir.Text = "Direccion Exacta"
        '
        'cmbtipodir
        '
        Me.cmbtipodir.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbtipodir.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipodir.FormattingEnabled = True
        Me.cmbtipodir.Items.AddRange(New Object() {"DOMICILIO", "TRABAJO"})
        Me.cmbtipodir.Location = New System.Drawing.Point(156, 52)
        Me.cmbtipodir.Name = "cmbtipodir"
        Me.cmbtipodir.Size = New System.Drawing.Size(121, 26)
        Me.cmbtipodir.TabIndex = 27
        Me.cmbtipodir.Text = "DOMICILIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bodoni MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(500, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Telefonos"
        '
        'pantel
        '
        Me.pantel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pantel.Controls.Add(Me.Button2)
        Me.pantel.Controls.Add(Me.Label1)
        Me.pantel.Controls.Add(Me.txttel1)
        Me.pantel.Controls.Add(Me.Label2)
        Me.pantel.Controls.Add(Me.Cmbtipotel1)
        Me.pantel.Controls.Add(Me.Btntelagregar)
        Me.pantel.Controls.Add(Me.lbltipotel)
        Me.pantel.Controls.Add(Me.txtnumtel)
        Me.pantel.Controls.Add(Me.lbltel)
        Me.pantel.Controls.Add(Me.cmbtipotel)
        Me.pantel.Location = New System.Drawing.Point(518, 47)
        Me.pantel.Name = "pantel"
        Me.pantel.Size = New System.Drawing.Size(395, 92)
        Me.pantel.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.Sistema_ventas.My.Resources.Resources.Everaldo_Crystal_Clear_Action_arrow_blue_up
        Me.Button2.Location = New System.Drawing.Point(323, 138)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(46, 27)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = " "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(34, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Tipo"
        '
        'txttel1
        '
        Me.txttel1.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel1.Location = New System.Drawing.Point(134, 94)
        Me.txttel1.Name = "txttel1"
        Me.txttel1.Size = New System.Drawing.Size(189, 25)
        Me.txttel1.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Numero"
        '
        'Cmbtipotel1
        '
        Me.Cmbtipotel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Cmbtipotel1.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbtipotel1.FormattingEnabled = True
        Me.Cmbtipotel1.Items.AddRange(New Object() {"MOVIL", "CONVENCIONAL"})
        Me.Cmbtipotel1.Location = New System.Drawing.Point(134, 130)
        Me.Cmbtipotel1.Name = "Cmbtipotel1"
        Me.Cmbtipotel1.Size = New System.Drawing.Size(141, 26)
        Me.Cmbtipotel1.TabIndex = 32
        Me.Cmbtipotel1.Text = "CONVENCIONAL"
        '
        'Btntelagregar
        '
        Me.Btntelagregar.FlatAppearance.BorderSize = 0
        Me.Btntelagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btntelagregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btntelagregar.Image = Global.Sistema_ventas.My.Resources.Resources.Add
        Me.Btntelagregar.Location = New System.Drawing.Point(313, 46)
        Me.Btntelagregar.Name = "Btntelagregar"
        Me.Btntelagregar.Size = New System.Drawing.Size(46, 34)
        Me.Btntelagregar.TabIndex = 31
        Me.Btntelagregar.UseVisualStyleBackColor = True
        '
        'lbltipotel
        '
        Me.lbltipotel.AutoSize = True
        Me.lbltipotel.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipotel.ForeColor = System.Drawing.Color.Cornsilk
        Me.lbltipotel.Location = New System.Drawing.Point(34, 57)
        Me.lbltipotel.Name = "lbltipotel"
        Me.lbltipotel.Size = New System.Drawing.Size(47, 23)
        Me.lbltipotel.TabIndex = 30
        Me.lbltipotel.Text = "Tipo"
        '
        'txtnumtel
        '
        Me.txtnumtel.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumtel.Location = New System.Drawing.Point(134, 18)
        Me.txtnumtel.Name = "txtnumtel"
        Me.txtnumtel.Size = New System.Drawing.Size(189, 25)
        Me.txtnumtel.TabIndex = 29
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltel.ForeColor = System.Drawing.Color.White
        Me.lbltel.Location = New System.Drawing.Point(23, 21)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(74, 23)
        Me.lbltel.TabIndex = 28
        Me.lbltel.Text = "Numero"
        '
        'cmbtipotel
        '
        Me.cmbtipotel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbtipotel.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipotel.FormattingEnabled = True
        Me.cmbtipotel.Items.AddRange(New Object() {"MOVIL", "CONVENCIONAL"})
        Me.cmbtipotel.Location = New System.Drawing.Point(134, 54)
        Me.cmbtipotel.Name = "cmbtipotel"
        Me.cmbtipotel.Size = New System.Drawing.Size(137, 26)
        Me.cmbtipotel.TabIndex = 27
        Me.cmbtipotel.Text = "MOVIL"
        '
        'lblced
        '
        Me.lblced.AutoSize = True
        Me.lblced.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblced.ForeColor = System.Drawing.Color.White
        Me.lblced.Location = New System.Drawing.Point(23, 244)
        Me.lblced.Name = "lblced"
        Me.lblced.Size = New System.Drawing.Size(155, 23)
        Me.lblced.TabIndex = 17
        Me.lblced.Text = "Numero de Cedula"
        '
        'lblapell
        '
        Me.lblapell.AutoSize = True
        Me.lblapell.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapell.ForeColor = System.Drawing.Color.White
        Me.lblapell.Location = New System.Drawing.Point(23, 192)
        Me.lblapell.Name = "lblapell"
        Me.lblapell.Size = New System.Drawing.Size(83, 23)
        Me.lblapell.TabIndex = 16
        Me.lblapell.Text = "Apellidos"
        '
        'lblnomb
        '
        Me.lblnomb.AutoSize = True
        Me.lblnomb.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomb.ForeColor = System.Drawing.Color.White
        Me.lblnomb.Location = New System.Drawing.Point(23, 130)
        Me.lblnomb.Name = "lblnomb"
        Me.lblnomb.Size = New System.Drawing.Size(81, 23)
        Me.lblnomb.TabIndex = 15
        Me.lblnomb.Text = "Nombres"
        '
        'lblCodcliente
        '
        Me.lblCodcliente.AutoSize = True
        Me.lblCodcliente.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodcliente.ForeColor = System.Drawing.Color.White
        Me.lblCodcliente.Location = New System.Drawing.Point(23, 76)
        Me.lblCodcliente.Name = "lblCodcliente"
        Me.lblCodcliente.Size = New System.Drawing.Size(168, 23)
        Me.lblCodcliente.TabIndex = 14
        Me.lblCodcliente.Text = "Codigo de Cliente(a)"
        '
        'txtapell
        '
        Me.txtapell.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapell.Location = New System.Drawing.Point(206, 183)
        Me.txtapell.Name = "txtapell"
        Me.txtapell.Size = New System.Drawing.Size(190, 27)
        Me.txtapell.TabIndex = 6
        '
        'txtnomb
        '
        Me.txtnomb.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomb.Location = New System.Drawing.Point(206, 128)
        Me.txtnomb.Name = "txtnomb"
        Me.txtnomb.Size = New System.Drawing.Size(190, 27)
        Me.txtnomb.TabIndex = 0
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcliente.Location = New System.Drawing.Point(206, 76)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.ReadOnly = True
        Me.txtcodcliente.Size = New System.Drawing.Size(147, 27)
        Me.txtcodcliente.TabIndex = 4
        '
        'txtced
        '
        Me.txtced.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtced.Location = New System.Drawing.Point(206, 240)
        Me.txtced.Name = "txtced"
        Me.txtced.Size = New System.Drawing.Size(242, 27)
        Me.txtced.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(33, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1054, 582)
        Me.Panel1.TabIndex = 22
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1115, 711)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "clientes"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Pandir.ResumeLayout(False)
        Me.Pandir.PerformLayout()
        Me.pantel.ResumeLayout(False)
        Me.pantel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblced As System.Windows.Forms.Label
    Friend WithEvents lblapell As System.Windows.Forms.Label
    Friend WithEvents lblnomb As System.Windows.Forms.Label
    Friend WithEvents lblCodcliente As System.Windows.Forms.Label
    Friend WithEvents txtapell As System.Windows.Forms.TextBox
    Friend WithEvents txtnomb As System.Windows.Forms.TextBox
    Friend WithEvents txtcodcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtced As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Pandir As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtdir1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cmbtipodir1 As System.Windows.Forms.ComboBox
    Friend WithEvents Btndiragregar As System.Windows.Forms.Button
    Friend WithEvents txtdir As System.Windows.Forms.TextBox
    Friend WithEvents lbltipodir As System.Windows.Forms.Label
    Friend WithEvents lbldir As System.Windows.Forms.Label
    Friend WithEvents cmbtipodir As System.Windows.Forms.ComboBox
    Friend WithEvents pantel As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttel1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmbtipotel1 As System.Windows.Forms.ComboBox
    Friend WithEvents Btntelagregar As System.Windows.Forms.Button
    Friend WithEvents lbltipotel As System.Windows.Forms.Label
    Friend WithEvents txtnumtel As System.Windows.Forms.TextBox
    Friend WithEvents lbltel As System.Windows.Forms.Label
    Friend WithEvents cmbtipotel As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
