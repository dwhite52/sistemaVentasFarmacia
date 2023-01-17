<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editarclientes
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
        Me.txtapell = New System.Windows.Forms.TextBox()
        Me.txtnomb = New System.Windows.Forms.TextBox()
        Me.txtced = New System.Windows.Forms.TextBox()
        Me.lblced = New System.Windows.Forms.Label()
        Me.lblapell = New System.Windows.Forms.Label()
        Me.lblnomb = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtap = New System.Windows.Forms.TextBox()
        Me.Gboxdir = New System.Windows.Forms.GroupBox()
        Me.txtdir1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmbtipodir1 = New System.Windows.Forms.ComboBox()
        Me.txtdir = New System.Windows.Forms.TextBox()
        Me.lbltipodir = New System.Windows.Forms.Label()
        Me.lbldir = New System.Windows.Forms.Label()
        Me.cmbtipodir = New System.Windows.Forms.ComboBox()
        Me.Txtnom = New System.Windows.Forms.TextBox()
        Me.Txtcedula = New System.Windows.Forms.TextBox()
        Me.Gboxtel = New System.Windows.Forms.GroupBox()
        Me.cmbtipotel1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttel1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltipotel = New System.Windows.Forms.Label()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.lbltel = New System.Windows.Forms.Label()
        Me.cmbtipotel = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.lblcapnum1 = New System.Windows.Forms.Label()
        Me.lblcaptipotel = New System.Windows.Forms.Label()
        Me.lblcapnum2 = New System.Windows.Forms.Label()
        Me.lblcaptipotel2 = New System.Windows.Forms.Label()
        Me.lblcaptipodir2 = New System.Windows.Forms.Label()
        Me.lblcapdir2 = New System.Windows.Forms.Label()
        Me.lblcaptipodir1 = New System.Windows.Forms.Label()
        Me.lblcapdir1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Gboxdir.SuspendLayout()
        Me.Gboxtel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtapell
        '
        Me.txtapell.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapell.Location = New System.Drawing.Point(143, 250)
        Me.txtapell.Name = "txtapell"
        Me.txtapell.Size = New System.Drawing.Size(190, 27)
        Me.txtapell.TabIndex = 9
        '
        'txtnomb
        '
        Me.txtnomb.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomb.Location = New System.Drawing.Point(143, 195)
        Me.txtnomb.Name = "txtnomb"
        Me.txtnomb.Size = New System.Drawing.Size(190, 27)
        Me.txtnomb.TabIndex = 8
        '
        'txtced
        '
        Me.txtced.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtced.Location = New System.Drawing.Point(143, 307)
        Me.txtced.Name = "txtced"
        Me.txtced.Size = New System.Drawing.Size(242, 27)
        Me.txtced.TabIndex = 10
        '
        'lblced
        '
        Me.lblced.AutoSize = True
        Me.lblced.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblced.Location = New System.Drawing.Point(71, 105)
        Me.lblced.Name = "lblced"
        Me.lblced.Size = New System.Drawing.Size(155, 23)
        Me.lblced.TabIndex = 14
        Me.lblced.Text = "Numero de Cedula"
        '
        'lblapell
        '
        Me.lblapell.AutoSize = True
        Me.lblapell.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblapell.Location = New System.Drawing.Point(81, 69)
        Me.lblapell.Name = "lblapell"
        Me.lblapell.Size = New System.Drawing.Size(83, 23)
        Me.lblapell.TabIndex = 13
        Me.lblapell.Text = "Apellidos"
        '
        'lblnomb
        '
        Me.lblnomb.AutoSize = True
        Me.lblnomb.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomb.Location = New System.Drawing.Point(81, 33)
        Me.lblnomb.Name = "lblnomb"
        Me.lblnomb.Size = New System.Drawing.Size(81, 23)
        Me.lblnomb.TabIndex = 12
        Me.lblnomb.Text = "Nombres"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CmbEstado)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.lblced)
        Me.GroupBox1.Controls.Add(Me.txtap)
        Me.GroupBox1.Controls.Add(Me.lblapell)
        Me.GroupBox1.Controls.Add(Me.Gboxdir)
        Me.GroupBox1.Controls.Add(Me.lblnomb)
        Me.GroupBox1.Controls.Add(Me.Txtnom)
        Me.GroupBox1.Controls.Add(Me.Txtcedula)
        Me.GroupBox1.Controls.Add(Me.Gboxtel)
        Me.GroupBox1.Font = New System.Drawing.Font("Bodoni MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(33, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 611)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'CmbEstado
        '
        Me.CmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmbEstado.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbEstado.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.CmbEstado.Location = New System.Drawing.Point(231, 149)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(121, 26)
        Me.CmbEstado.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(87, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 23)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Estado"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGuardar.Image = Global.Sistema_ventas.My.Resources.Resources.save_changes
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(195, 567)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(184, 40)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtap
        '
        Me.txtap.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtap.Location = New System.Drawing.Point(232, 69)
        Me.txtap.Name = "txtap"
        Me.txtap.Size = New System.Drawing.Size(219, 27)
        Me.txtap.TabIndex = 6
        '
        'Gboxdir
        '
        Me.Gboxdir.Controls.Add(Me.txtdir1)
        Me.Gboxdir.Controls.Add(Me.Label3)
        Me.Gboxdir.Controls.Add(Me.Label4)
        Me.Gboxdir.Controls.Add(Me.Cmbtipodir1)
        Me.Gboxdir.Controls.Add(Me.txtdir)
        Me.Gboxdir.Controls.Add(Me.lbltipodir)
        Me.Gboxdir.Controls.Add(Me.lbldir)
        Me.Gboxdir.Controls.Add(Me.cmbtipodir)
        Me.Gboxdir.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gboxdir.ForeColor = System.Drawing.Color.Yellow
        Me.Gboxdir.Location = New System.Drawing.Point(55, 361)
        Me.Gboxdir.Name = "Gboxdir"
        Me.Gboxdir.Size = New System.Drawing.Size(420, 182)
        Me.Gboxdir.TabIndex = 13
        Me.Gboxdir.TabStop = False
        Me.Gboxdir.Text = "Direccion"
        '
        'txtdir1
        '
        Me.txtdir1.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdir1.Location = New System.Drawing.Point(174, 104)
        Me.txtdir1.Multiline = True
        Me.txtdir1.Name = "txtdir1"
        Me.txtdir1.Size = New System.Drawing.Size(233, 32)
        Me.txtdir1.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 23)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Direccion Exacta2"
        '
        'Cmbtipodir1
        '
        Me.Cmbtipodir1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmbtipodir1.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbtipodir1.FormattingEnabled = True
        Me.Cmbtipodir1.Items.AddRange(New Object() {"DOMICILIO", "RESIDENCIA"})
        Me.Cmbtipodir1.Location = New System.Drawing.Point(174, 142)
        Me.Cmbtipodir1.Name = "Cmbtipodir1"
        Me.Cmbtipodir1.Size = New System.Drawing.Size(121, 26)
        Me.Cmbtipodir1.TabIndex = 23
        '
        'txtdir
        '
        Me.txtdir.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdir.Location = New System.Drawing.Point(174, 21)
        Me.txtdir.Multiline = True
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(233, 32)
        Me.txtdir.TabIndex = 14
        '
        'lbltipodir
        '
        Me.lbltipodir.AutoSize = True
        Me.lbltipodir.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipodir.ForeColor = System.Drawing.Color.White
        Me.lbltipodir.Location = New System.Drawing.Point(40, 62)
        Me.lbltipodir.Name = "lbltipodir"
        Me.lbltipodir.Size = New System.Drawing.Size(47, 23)
        Me.lbltipodir.TabIndex = 12
        Me.lbltipodir.Text = "Tipo"
        '
        'lbldir
        '
        Me.lbldir.AutoSize = True
        Me.lbldir.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldir.ForeColor = System.Drawing.Color.White
        Me.lbldir.Location = New System.Drawing.Point(22, 26)
        Me.lbldir.Name = "lbldir"
        Me.lbldir.Size = New System.Drawing.Size(155, 23)
        Me.lbldir.TabIndex = 13
        Me.lbldir.Text = "Direccion Exacta1"
        '
        'cmbtipodir
        '
        Me.cmbtipodir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbtipodir.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipodir.FormattingEnabled = True
        Me.cmbtipodir.Items.AddRange(New Object() {"DOMICILIO", "RESIDENCIA"})
        Me.cmbtipodir.Location = New System.Drawing.Point(174, 59)
        Me.cmbtipodir.Name = "cmbtipodir"
        Me.cmbtipodir.Size = New System.Drawing.Size(121, 26)
        Me.cmbtipodir.TabIndex = 0
        '
        'Txtnom
        '
        Me.Txtnom.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnom.Location = New System.Drawing.Point(233, 32)
        Me.Txtnom.Name = "Txtnom"
        Me.Txtnom.Size = New System.Drawing.Size(218, 27)
        Me.Txtnom.TabIndex = 5
        '
        'Txtcedula
        '
        Me.Txtcedula.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcedula.Location = New System.Drawing.Point(232, 105)
        Me.Txtcedula.Name = "Txtcedula"
        Me.Txtcedula.Size = New System.Drawing.Size(242, 27)
        Me.Txtcedula.TabIndex = 7
        '
        'Gboxtel
        '
        Me.Gboxtel.Controls.Add(Me.cmbtipotel1)
        Me.Gboxtel.Controls.Add(Me.Label1)
        Me.Gboxtel.Controls.Add(Me.txttel1)
        Me.Gboxtel.Controls.Add(Me.Label2)
        Me.Gboxtel.Controls.Add(Me.lbltipotel)
        Me.Gboxtel.Controls.Add(Me.txttel)
        Me.Gboxtel.Controls.Add(Me.lbltel)
        Me.Gboxtel.Controls.Add(Me.cmbtipotel)
        Me.Gboxtel.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gboxtel.ForeColor = System.Drawing.Color.Yellow
        Me.Gboxtel.Location = New System.Drawing.Point(55, 181)
        Me.Gboxtel.Name = "Gboxtel"
        Me.Gboxtel.Size = New System.Drawing.Size(420, 174)
        Me.Gboxtel.TabIndex = 11
        Me.Gboxtel.TabStop = False
        Me.Gboxtel.Text = "Telefono"
        '
        'cmbtipotel1
        '
        Me.cmbtipotel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbtipotel1.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipotel1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbtipotel1.FormattingEnabled = True
        Me.cmbtipotel1.Items.AddRange(New Object() {"MOVIL", "CONVENCIONAL"})
        Me.cmbtipotel1.Location = New System.Drawing.Point(171, 135)
        Me.cmbtipotel1.Name = "cmbtipotel1"
        Me.cmbtipotel1.Size = New System.Drawing.Size(121, 26)
        Me.cmbtipotel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Tipo"
        '
        'txttel1
        '
        Me.txttel1.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel1.Location = New System.Drawing.Point(171, 99)
        Me.txttel1.Name = "txttel1"
        Me.txttel1.Size = New System.Drawing.Size(236, 25)
        Me.txttel1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Numero2"
        '
        'lbltipotel
        '
        Me.lbltipotel.AutoSize = True
        Me.lbltipotel.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipotel.ForeColor = System.Drawing.Color.White
        Me.lbltipotel.Location = New System.Drawing.Point(51, 62)
        Me.lbltipotel.Name = "lbltipotel"
        Me.lbltipotel.Size = New System.Drawing.Size(47, 23)
        Me.lbltipotel.TabIndex = 12
        Me.lbltipotel.Text = "Tipo"
        '
        'txttel
        '
        Me.txttel.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel.Location = New System.Drawing.Point(171, 23)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(238, 25)
        Me.txttel.TabIndex = 9
        '
        'lbltel
        '
        Me.lbltel.AutoSize = True
        Me.lbltel.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltel.ForeColor = System.Drawing.Color.White
        Me.lbltel.Location = New System.Drawing.Point(40, 26)
        Me.lbltel.Name = "lbltel"
        Me.lbltel.Size = New System.Drawing.Size(83, 23)
        Me.lbltel.TabIndex = 8
        Me.lbltel.Text = "Numero1"
        '
        'cmbtipotel
        '
        Me.cmbtipotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbtipotel.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipotel.FormattingEnabled = True
        Me.cmbtipotel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbtipotel.Items.AddRange(New Object() {"MOVIL", "CONVENCIONAL"})
        Me.cmbtipotel.Location = New System.Drawing.Point(171, 59)
        Me.cmbtipotel.Name = "cmbtipotel"
        Me.cmbtipotel.Size = New System.Drawing.Size(121, 26)
        Me.cmbtipotel.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(776, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 16
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(776, 312)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 17
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(776, 475)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView3.TabIndex = 18
        '
        'lblcapnum1
        '
        Me.lblcapnum1.AutoSize = True
        Me.lblcapnum1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcapnum1.ForeColor = System.Drawing.Color.White
        Me.lblcapnum1.Location = New System.Drawing.Point(615, 237)
        Me.lblcapnum1.Name = "lblcapnum1"
        Me.lblcapnum1.Size = New System.Drawing.Size(0, 23)
        Me.lblcapnum1.TabIndex = 26
        '
        'lblcaptipotel
        '
        Me.lblcaptipotel.AutoSize = True
        Me.lblcaptipotel.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaptipotel.ForeColor = System.Drawing.Color.White
        Me.lblcaptipotel.Location = New System.Drawing.Point(615, 286)
        Me.lblcaptipotel.Name = "lblcaptipotel"
        Me.lblcaptipotel.Size = New System.Drawing.Size(0, 23)
        Me.lblcaptipotel.TabIndex = 27
        '
        'lblcapnum2
        '
        Me.lblcapnum2.AutoSize = True
        Me.lblcapnum2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcapnum2.ForeColor = System.Drawing.Color.White
        Me.lblcapnum2.Location = New System.Drawing.Point(615, 329)
        Me.lblcapnum2.Name = "lblcapnum2"
        Me.lblcapnum2.Size = New System.Drawing.Size(0, 23)
        Me.lblcapnum2.TabIndex = 28
        '
        'lblcaptipotel2
        '
        Me.lblcaptipotel2.AutoSize = True
        Me.lblcaptipotel2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaptipotel2.ForeColor = System.Drawing.Color.White
        Me.lblcaptipotel2.Location = New System.Drawing.Point(615, 362)
        Me.lblcaptipotel2.Name = "lblcaptipotel2"
        Me.lblcaptipotel2.Size = New System.Drawing.Size(0, 23)
        Me.lblcaptipotel2.TabIndex = 29
        '
        'lblcaptipodir2
        '
        Me.lblcaptipodir2.AutoSize = True
        Me.lblcaptipodir2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaptipodir2.ForeColor = System.Drawing.Color.White
        Me.lblcaptipodir2.Location = New System.Drawing.Point(615, 541)
        Me.lblcaptipodir2.Name = "lblcaptipodir2"
        Me.lblcaptipodir2.Size = New System.Drawing.Size(0, 23)
        Me.lblcaptipodir2.TabIndex = 33
        '
        'lblcapdir2
        '
        Me.lblcapdir2.AutoSize = True
        Me.lblcapdir2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcapdir2.ForeColor = System.Drawing.Color.White
        Me.lblcapdir2.Location = New System.Drawing.Point(615, 508)
        Me.lblcapdir2.Name = "lblcapdir2"
        Me.lblcapdir2.Size = New System.Drawing.Size(0, 23)
        Me.lblcapdir2.TabIndex = 32
        '
        'lblcaptipodir1
        '
        Me.lblcaptipodir1.AutoSize = True
        Me.lblcaptipodir1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcaptipodir1.ForeColor = System.Drawing.Color.White
        Me.lblcaptipodir1.Location = New System.Drawing.Point(615, 465)
        Me.lblcaptipodir1.Name = "lblcaptipodir1"
        Me.lblcaptipodir1.Size = New System.Drawing.Size(0, 23)
        Me.lblcaptipodir1.TabIndex = 31
        '
        'lblcapdir1
        '
        Me.lblcapdir1.AutoSize = True
        Me.lblcapdir1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcapdir1.ForeColor = System.Drawing.Color.White
        Me.lblcapdir1.Location = New System.Drawing.Point(615, 416)
        Me.lblcapdir1.Name = "lblcapdir1"
        Me.lblcapdir1.Size = New System.Drawing.Size(0, 23)
        Me.lblcapdir1.TabIndex = 30
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Teal
        Me.Button2.Image = Global.Sistema_ventas.My.Resources.Resources.back
        Me.Button2.Location = New System.Drawing.Point(569, -4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 46)
        Me.Button2.TabIndex = 53
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_ventas.My.Resources.Resources._44
        Me.PictureBox1.Location = New System.Drawing.Point(193, -10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 52)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(181, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(279, 25)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "EDITAR DATOS DEl CLIENTE"
        '
        'editarclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(607, 711)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblcaptipodir2)
        Me.Controls.Add(Me.lblcapdir2)
        Me.Controls.Add(Me.lblcaptipodir1)
        Me.Controls.Add(Me.lblcapdir1)
        Me.Controls.Add(Me.lblcaptipotel2)
        Me.Controls.Add(Me.lblcapnum2)
        Me.Controls.Add(Me.lblcaptipotel)
        Me.Controls.Add(Me.lblcapnum1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtapell)
        Me.Controls.Add(Me.txtnomb)
        Me.Controls.Add(Me.txtced)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(390, 45)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editarclientes"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "editarclientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gboxdir.ResumeLayout(False)
        Me.Gboxdir.PerformLayout()
        Me.Gboxtel.ResumeLayout(False)
        Me.Gboxtel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtapell As System.Windows.Forms.TextBox
    Friend WithEvents txtnomb As System.Windows.Forms.TextBox
    Friend WithEvents txtced As System.Windows.Forms.TextBox
    Friend WithEvents lblced As System.Windows.Forms.Label
    Friend WithEvents lblapell As System.Windows.Forms.Label
    Friend WithEvents lblnomb As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtap As System.Windows.Forms.TextBox
    Friend WithEvents Gboxdir As System.Windows.Forms.GroupBox
    Friend WithEvents txtdir1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cmbtipodir1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtdir As System.Windows.Forms.TextBox
    Friend WithEvents lbltipodir As System.Windows.Forms.Label
    Friend WithEvents lbldir As System.Windows.Forms.Label
    Friend WithEvents cmbtipodir As System.Windows.Forms.ComboBox
    Friend WithEvents Txtnom As System.Windows.Forms.TextBox
    Friend WithEvents Txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents Gboxtel As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltipotel As System.Windows.Forms.Label
    Friend WithEvents lbltel As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents txttel1 As System.Windows.Forms.TextBox
    Friend WithEvents cmbtipotel1 As System.Windows.Forms.ComboBox
    Friend WithEvents txttel As System.Windows.Forms.TextBox
    Friend WithEvents cmbtipotel As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblcapnum1 As System.Windows.Forms.Label
    Friend WithEvents lblcaptipotel As System.Windows.Forms.Label
    Friend WithEvents lblcapnum2 As System.Windows.Forms.Label
    Friend WithEvents lblcaptipotel2 As System.Windows.Forms.Label
    Friend WithEvents lblcaptipodir2 As System.Windows.Forms.Label
    Friend WithEvents lblcapdir2 As System.Windows.Forms.Label
    Friend WithEvents lblcaptipodir1 As System.Windows.Forms.Label
    Friend WithEvents lblcapdir1 As System.Windows.Forms.Label
    Friend WithEvents CmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
