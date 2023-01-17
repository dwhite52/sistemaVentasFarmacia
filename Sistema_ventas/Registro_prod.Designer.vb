<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_prod
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_prod))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblgcod = New System.Windows.Forms.Label()
        Me.lblext = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnQuitar_seleccion = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnmodificar_seleccion = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clasificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expira = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbclasificacion = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnagregarr = New System.Windows.Forms.Button()
        Me.dtpf_exp = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtprecioventa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdescprod = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcodprod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btngcamb = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.DateFIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdProv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumFactProv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblfecha_expiracio = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(6, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1233, 591)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblgcod)
        Me.GroupBox3.Controls.Add(Me.lblext)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox3.Location = New System.Drawing.Point(41, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1196, 521)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle del Producto"
        '
        'lblgcod
        '
        Me.lblgcod.AutoSize = True
        Me.lblgcod.Location = New System.Drawing.Point(688, 569)
        Me.lblgcod.Name = "lblgcod"
        Me.lblgcod.Size = New System.Drawing.Size(0, 22)
        Me.lblgcod.TabIndex = 25
        '
        'lblext
        '
        Me.lblext.AutoSize = True
        Me.lblext.Location = New System.Drawing.Point(545, 566)
        Me.lblext.Name = "lblext"
        Me.lblext.Size = New System.Drawing.Size(0, 22)
        Me.lblext.TabIndex = 25
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnQuitar_seleccion)
        Me.GroupBox4.Controls.Add(Me.btncancelar)
        Me.GroupBox4.Controls.Add(Me.btnmodificar_seleccion)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(1024, 324)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(139, 169)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        '
        'btnQuitar_seleccion
        '
        Me.btnQuitar_seleccion.BackColor = System.Drawing.Color.Transparent
        Me.btnQuitar_seleccion.ForeColor = System.Drawing.Color.Teal
        Me.btnQuitar_seleccion.Image = Global.Sistema_ventas.My.Resources.Resources.Remove
        Me.btnQuitar_seleccion.Location = New System.Drawing.Point(9, 66)
        Me.btnQuitar_seleccion.Name = "btnQuitar_seleccion"
        Me.btnQuitar_seleccion.Size = New System.Drawing.Size(123, 39)
        Me.btnQuitar_seleccion.TabIndex = 15
        Me.btnQuitar_seleccion.Text = "QUITAR"
        Me.btnQuitar_seleccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuitar_seleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuitar_seleccion.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.ForeColor = System.Drawing.Color.Teal
        Me.btncancelar.Image = Global.Sistema_ventas.My.Resources.Resources.Cancel
        Me.btncancelar.Location = New System.Drawing.Point(8, 111)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(125, 38)
        Me.btncancelar.TabIndex = 25
        Me.btncancelar.Text = "CANCELAR"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnmodificar_seleccion
        '
        Me.btnmodificar_seleccion.BackColor = System.Drawing.Color.Transparent
        Me.btnmodificar_seleccion.ForeColor = System.Drawing.Color.Teal
        Me.btnmodificar_seleccion.Image = Global.Sistema_ventas.My.Resources.Resources.Edit
        Me.btnmodificar_seleccion.Location = New System.Drawing.Point(9, 20)
        Me.btnmodificar_seleccion.Name = "btnmodificar_seleccion"
        Me.btnmodificar_seleccion.Size = New System.Drawing.Size(121, 39)
        Me.btnmodificar_seleccion.TabIndex = 96
        Me.btnmodificar_seleccion.Text = "EDITAR"
        Me.btnmodificar_seleccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar_seleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnmodificar_seleccion.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod, Me.Descripcion, Me.Cantidad, Me.costo, Me.p_venta, Me.Clasificacion, Me.Expira})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(46, 293)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(972, 200)
        Me.DataGridView1.TabIndex = 0
        '
        'cod
        '
        Me.cod.HeaderText = "ID Producto"
        Me.cod.Name = "cod"
        Me.cod.ReadOnly = True
        Me.cod.Width = 150
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 200
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 110
        '
        'costo
        '
        Me.costo.HeaderText = "P.Compra"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        '
        'p_venta
        '
        Me.p_venta.HeaderText = "P.Venta"
        Me.p_venta.Name = "p_venta"
        Me.p_venta.ReadOnly = True
        '
        'Clasificacion
        '
        Me.Clasificacion.HeaderText = "Clasificacion"
        Me.Clasificacion.Name = "Clasificacion"
        Me.Clasificacion.ReadOnly = True
        Me.Clasificacion.Width = 135
        '
        'Expira
        '
        Me.Expira.HeaderText = "F.Exp"
        Me.Expira.Name = "Expira"
        Me.Expira.ReadOnly = True
        Me.Expira.Width = 130
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbclasificacion)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnagregarr)
        Me.GroupBox2.Controls.Add(Me.dtpf_exp)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtprecioventa)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtdescprod)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtcosto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtcodprod)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btngcamb)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(46, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(972, 267)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'cmbclasificacion
        '
        Me.cmbclasificacion.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbclasificacion.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbclasificacion.FormattingEnabled = True
        Me.cmbclasificacion.Items.AddRange(New Object() {"Suspension", "Jarabe", "Gotas ", "Tabletas", "Inyeccion", "Caramelo", "Ampollas Bebibles", "Sobres", "Gel", "Pasta", "Locion", "Crema", "Leche", "Alcohol", "Spray", "Supositorio", "Ovulos", "Rollos", "Frasco", "Suero", "Algodon", "Shampoo", "Unguento", "Capsulas", "Efervescente", "Jabon", "Jeringa", "Otros"})
        Me.cmbclasificacion.Location = New System.Drawing.Point(660, 79)
        Me.cmbclasificacion.Name = "cmbclasificacion"
        Me.cmbclasificacion.Size = New System.Drawing.Size(192, 27)
        Me.cmbclasificacion.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Teal
        Me.Button1.Image = Global.Sistema_ventas.My.Resources.Resources.bar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(43, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 48)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "GENERAR CODIGO"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnagregarr
        '
        Me.btnagregarr.BackColor = System.Drawing.Color.Transparent
        Me.btnagregarr.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnagregarr.FlatAppearance.BorderSize = 2
        Me.btnagregarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregarr.ForeColor = System.Drawing.Color.Teal
        Me.btnagregarr.Image = Global.Sistema_ventas.My.Resources.Resources.Add
        Me.btnagregarr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregarr.Location = New System.Drawing.Point(748, 212)
        Me.btnagregarr.Name = "btnagregarr"
        Me.btnagregarr.Size = New System.Drawing.Size(197, 48)
        Me.btnagregarr.TabIndex = 23
        Me.btnagregarr.Text = "AGREGAR Y GUARDAR"
        Me.btnagregarr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnagregarr.UseVisualStyleBackColor = False
        '
        'dtpf_exp
        '
        Me.dtpf_exp.CalendarFont = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpf_exp.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpf_exp.Location = New System.Drawing.Point(660, 168)
        Me.dtpf_exp.Name = "dtpf_exp"
        Me.dtpf_exp.Size = New System.Drawing.Size(301, 27)
        Me.dtpf_exp.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(460, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 22)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Fecha de Expiracion"
        '
        'txtprecioventa
        '
        Me.txtprecioventa.Location = New System.Drawing.Point(660, 125)
        Me.txtprecioventa.Name = "txtprecioventa"
        Me.txtprecioventa.Size = New System.Drawing.Size(125, 30)
        Me.txtprecioventa.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(472, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 22)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Precio de venta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(499, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 22)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Clasificacion"
        '
        'txtdescprod
        '
        Me.txtdescprod.Location = New System.Drawing.Point(660, 35)
        Me.txtdescprod.Name = "txtdescprod"
        Me.txtdescprod.Size = New System.Drawing.Size(306, 30)
        Me.txtdescprod.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(437, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(198, 22)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Descripcion del producto"
        '
        'txtcosto
        '
        Me.txtcosto.Location = New System.Drawing.Point(205, 110)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(142, 30)
        Me.txtcosto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 22)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Costo"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(205, 72)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(142, 30)
        Me.txtcantidad.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 22)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Cantidad"
        '
        'txtcodprod
        '
        Me.txtcodprod.Location = New System.Drawing.Point(205, 34)
        Me.txtcodprod.Name = "txtcodprod"
        Me.txtcodprod.Size = New System.Drawing.Size(210, 30)
        Me.txtcodprod.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 22)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Codigo del Producto"
        '
        'btngcamb
        '
        Me.btngcamb.BackColor = System.Drawing.Color.Transparent
        Me.btngcamb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngcamb.ForeColor = System.Drawing.Color.Teal
        Me.btngcamb.Image = Global.Sistema_ventas.My.Resources.Resources.save_changes
        Me.btngcamb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngcamb.Location = New System.Drawing.Point(764, 214)
        Me.btngcamb.Name = "btngcamb"
        Me.btngcamb.Size = New System.Drawing.Size(181, 46)
        Me.btngcamb.TabIndex = 24
        Me.btngcamb.Text = "GUARDAR CAMBIOS"
        Me.btngcamb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btngcamb.UseVisualStyleBackColor = False
        Me.btngcamb.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Btnbuscar)
        Me.GroupBox1.Controls.Add(Me.DateFIngreso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtIdProv)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNumFactProv)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(41, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1195, 84)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
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
        Me.Btnbuscar.Location = New System.Drawing.Point(680, 45)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(24, 28)
        Me.Btnbuscar.TabIndex = 2
        Me.Btnbuscar.UseVisualStyleBackColor = False
        '
        'DateFIngreso
        '
        Me.DateFIngreso.Enabled = False
        Me.DateFIngreso.Location = New System.Drawing.Point(860, 43)
        Me.DateFIngreso.Name = "DateFIngreso"
        Me.DateFIngreso.Size = New System.Drawing.Size(320, 30)
        Me.DateFIngreso.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(710, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 22)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Fecha de Ingreso"
        '
        'TxtIdProv
        '
        Me.TxtIdProv.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtIdProv.Location = New System.Drawing.Point(521, 44)
        Me.TxtIdProv.Name = "TxtIdProv"
        Me.TxtIdProv.ReadOnly = True
        Me.TxtIdProv.Size = New System.Drawing.Size(162, 30)
        Me.TxtIdProv.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 22)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "ID de Proveedor"
        '
        'txtNumFactProv
        '
        Me.txtNumFactProv.Location = New System.Drawing.Point(241, 41)
        Me.txtNumFactProv.Name = "txtNumFactProv"
        Me.txtNumFactProv.Size = New System.Drawing.Size(126, 30)
        Me.txtNumFactProv.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No.Factura de Proveedor"
        '
        'lblfecha_expiracio
        '
        Me.lblfecha_expiracio.AutoSize = True
        Me.lblfecha_expiracio.Location = New System.Drawing.Point(1300, 409)
        Me.lblfecha_expiracio.Name = "lblfecha_expiracio"
        Me.lblfecha_expiracio.Size = New System.Drawing.Size(0, 13)
        Me.lblfecha_expiracio.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_ventas.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(506, -49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(501, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(281, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "REGISTRO DE MERCADERIA"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Registro_prod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1294, 715)
        Me.Controls.Add(Me.lblfecha_expiracio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registro_prod"
        Me.Text = "Registro_prod"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcosto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcodprod As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateFIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtIdProv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNumFactProv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnagregarr As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpf_exp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtprecioventa As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdescprod As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitar_seleccion As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar_seleccion As System.Windows.Forms.Button
    Friend WithEvents cod As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p_venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clasificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expira As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btngcamb As System.Windows.Forms.Button
    Friend WithEvents lblext As System.Windows.Forms.Label
    Friend WithEvents lblgcod As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbclasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblfecha_expiracio As System.Windows.Forms.Label
End Class
