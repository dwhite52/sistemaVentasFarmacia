<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Factura
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtfiltrar = New System.Windows.Forms.TextBox()
        Me.Radcredito = New System.Windows.Forms.RadioButton()
        Me.Radcontado = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DEVOLUCION = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnumfact = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.lblnomcliente = New System.Windows.Forms.Label()
        Me.txtnomclinte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtsubtot = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.lbldescuento = New System.Windows.Forms.Label()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Lblfecha_limite = New System.Windows.Forms.Label()
        Me.txtfecha_liite = New System.Windows.Forms.TextBox()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtcantidad_devolucion = New System.Windows.Forms.TextBox()
        Me.txtsubnuevo = New System.Windows.Forms.TextBox()
        Me.Txtprecio = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(508, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = " Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(324, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese Su N° fact "
        '
        'Txtfiltrar
        '
        Me.Txtfiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfiltrar.Location = New System.Drawing.Point(596, 142)
        Me.Txtfiltrar.Name = "Txtfiltrar"
        Me.Txtfiltrar.Size = New System.Drawing.Size(131, 26)
        Me.Txtfiltrar.TabIndex = 8
        '
        'Radcredito
        '
        Me.Radcredito.AutoSize = True
        Me.Radcredito.BackColor = System.Drawing.Color.Transparent
        Me.Radcredito.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radcredito.ForeColor = System.Drawing.Color.White
        Me.Radcredito.Location = New System.Drawing.Point(684, 109)
        Me.Radcredito.Name = "Radcredito"
        Me.Radcredito.Size = New System.Drawing.Size(124, 26)
        Me.Radcredito.TabIndex = 13
        Me.Radcredito.Text = "A CREDITO"
        Me.Radcredito.UseVisualStyleBackColor = False
        Me.Radcredito.Visible = False
        '
        'Radcontado
        '
        Me.Radcontado.AutoSize = True
        Me.Radcontado.BackColor = System.Drawing.Color.Transparent
        Me.Radcontado.Checked = True
        Me.Radcontado.Font = New System.Drawing.Font("Bodoni MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radcontado.ForeColor = System.Drawing.Color.White
        Me.Radcontado.Location = New System.Drawing.Point(453, 109)
        Me.Radcontado.Name = "Radcontado"
        Me.Radcontado.Size = New System.Drawing.Size(93, 22)
        Me.Radcontado.TabIndex = 12
        Me.Radcontado.TabStop = True
        Me.Radcontado.Text = "CONTADO"
        Me.Radcontado.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(84, 316)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Size = New System.Drawing.Size(778, 203)
        Me.DataGridView1.TabIndex = 15
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DEVOLUCION})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'DEVOLUCION
        '
        Me.DEVOLUCION.Name = "DEVOLUCION"
        Me.DEVOLUCION.Size = New System.Drawing.Size(152, 22)
        Me.DEVOLUCION.Text = "DEVOLUCION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(102, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "N° Factura"
        '
        'txtnumfact
        '
        Me.txtnumfact.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtnumfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumfact.Location = New System.Drawing.Point(246, 199)
        Me.txtnumfact.Name = "txtnumfact"
        Me.txtnumfact.ReadOnly = True
        Me.txtnumfact.Size = New System.Drawing.Size(131, 26)
        Me.txtnumfact.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(102, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Fecha de Venta"
        '
        'txtfecha
        '
        Me.txtfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(246, 235)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.ReadOnly = True
        Me.txtfecha.Size = New System.Drawing.Size(131, 26)
        Me.txtfecha.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(452, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 22)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Vendedor"
        '
        'txtvendedor
        '
        Me.txtvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendedor.Location = New System.Drawing.Point(617, 199)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.ReadOnly = True
        Me.txtvendedor.Size = New System.Drawing.Size(223, 26)
        Me.txtvendedor.TabIndex = 20
        '
        'lblnomcliente
        '
        Me.lblnomcliente.AutoSize = True
        Me.lblnomcliente.BackColor = System.Drawing.Color.Transparent
        Me.lblnomcliente.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomcliente.ForeColor = System.Drawing.Color.White
        Me.lblnomcliente.Location = New System.Drawing.Point(440, 239)
        Me.lblnomcliente.Name = "lblnomcliente"
        Me.lblnomcliente.Size = New System.Drawing.Size(159, 22)
        Me.lblnomcliente.TabIndex = 23
        Me.lblnomcliente.Text = "Nombre del Cliente "
        '
        'txtnomclinte
        '
        Me.txtnomclinte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomclinte.Location = New System.Drawing.Point(617, 236)
        Me.txtnomclinte.Name = "txtnomclinte"
        Me.txtnomclinte.ReadOnly = True
        Me.txtnomclinte.Size = New System.Drawing.Size(223, 26)
        Me.txtnomclinte.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(667, 553)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 22)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Subtotal"
        '
        'txtsubtot
        '
        Me.txtsubtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtot.Location = New System.Drawing.Point(755, 551)
        Me.txtsubtot.Name = "txtsubtot"
        Me.txtsubtot.ReadOnly = True
        Me.txtsubtot.Size = New System.Drawing.Size(131, 26)
        Me.txtsubtot.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(424, 553)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 22)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "IVA"
        '
        'txtiva
        '
        Me.txtiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiva.Location = New System.Drawing.Point(512, 551)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.ReadOnly = True
        Me.txtiva.Size = New System.Drawing.Size(131, 26)
        Me.txtiva.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(667, 596)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 22)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Total"
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(755, 594)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(131, 26)
        Me.txttotal.TabIndex = 28
        '
        'lbldescuento
        '
        Me.lbldescuento.AutoSize = True
        Me.lbldescuento.BackColor = System.Drawing.Color.Transparent
        Me.lbldescuento.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescuento.ForeColor = System.Drawing.Color.White
        Me.lbldescuento.Location = New System.Drawing.Point(424, 596)
        Me.lbldescuento.Name = "lbldescuento"
        Me.lbldescuento.Size = New System.Drawing.Size(89, 22)
        Me.lbldescuento.TabIndex = 31
        Me.lbldescuento.Text = "Descuento"
        '
        'txtdescuento
        '
        Me.txtdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuento.Location = New System.Drawing.Point(512, 594)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.ReadOnly = True
        Me.txtdescuento.Size = New System.Drawing.Size(131, 26)
        Me.txtdescuento.TabIndex = 30
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(1125, 215)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(79, 203)
        Me.DataGridView2.TabIndex = 32
        '
        'Lblfecha_limite
        '
        Me.Lblfecha_limite.AutoSize = True
        Me.Lblfecha_limite.BackColor = System.Drawing.Color.Transparent
        Me.Lblfecha_limite.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfecha_limite.ForeColor = System.Drawing.Color.White
        Me.Lblfecha_limite.Location = New System.Drawing.Point(102, 274)
        Me.Lblfecha_limite.Name = "Lblfecha_limite"
        Me.Lblfecha_limite.Size = New System.Drawing.Size(111, 22)
        Me.Lblfecha_limite.TabIndex = 34
        Me.Lblfecha_limite.Text = "Fecha Limite"
        '
        'txtfecha_liite
        '
        Me.txtfecha_liite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha_liite.Location = New System.Drawing.Point(246, 270)
        Me.txtfecha_liite.Name = "txtfecha_liite"
        Me.txtfecha_liite.ReadOnly = True
        Me.txtfecha_liite.Size = New System.Drawing.Size(131, 26)
        Me.txtfecha_liite.TabIndex = 33
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.BackColor = System.Drawing.Color.Transparent
        Me.lblestado.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblestado.ForeColor = System.Drawing.Color.White
        Me.lblestado.Location = New System.Drawing.Point(472, 278)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(62, 22)
        Me.lblestado.TabIndex = 36
        Me.lblestado.Text = "Estado"
        '
        'txtestado
        '
        Me.txtestado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtestado.Location = New System.Drawing.Point(617, 274)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.ReadOnly = True
        Me.txtestado.Size = New System.Drawing.Size(131, 26)
        Me.txtestado.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_ventas.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(370, -42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(445, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 25)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "FACTURAS"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Teal
        Me.Button2.Image = Global.Sistema_ventas.My.Resources.Resources.back
        Me.Button2.Location = New System.Drawing.Point(1004, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 46)
        Me.Button2.TabIndex = 57
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtcantidad_devolucion
        '
        Me.txtcantidad_devolucion.Location = New System.Drawing.Point(61, 58)
        Me.txtcantidad_devolucion.Name = "txtcantidad_devolucion"
        Me.txtcantidad_devolucion.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad_devolucion.TabIndex = 58
        Me.txtcantidad_devolucion.Visible = False
        '
        'txtsubnuevo
        '
        Me.txtsubnuevo.Location = New System.Drawing.Point(61, 114)
        Me.txtsubnuevo.Name = "txtsubnuevo"
        Me.txtsubnuevo.Size = New System.Drawing.Size(100, 20)
        Me.txtsubnuevo.TabIndex = 59
        Me.txtsubnuevo.Visible = False
        '
        'Txtprecio
        '
        Me.Txtprecio.Location = New System.Drawing.Point(61, 86)
        Me.Txtprecio.Name = "Txtprecio"
        Me.Txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.Txtprecio.TabIndex = 60
        Me.Txtprecio.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGuardar.Image = Global.Sistema_ventas.My.Resources.Resources.save_changes
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(894, 426)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(129, 53)
        Me.btnGuardar.TabIndex = 61
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(61, 27)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(100, 20)
        Me.txtcod.TabIndex = 62
        Me.txtcod.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(214, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 22)
        Me.Label10.TabIndex = 63
        Me.Label10.Visible = False
        '
        'Busqueda_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1045, 665)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Txtprecio)
        Me.Controls.Add(Me.txtsubnuevo)
        Me.Controls.Add(Me.txtcantidad_devolucion)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.txtestado)
        Me.Controls.Add(Me.Lblfecha_limite)
        Me.Controls.Add(Me.txtfecha_liite)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.lbldescuento)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsubtot)
        Me.Controls.Add(Me.lblnomcliente)
        Me.Controls.Add(Me.txtnomclinte)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtvendedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnumfact)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Radcredito)
        Me.Controls.Add(Me.Radcontado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtfiltrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Busqueda_Factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtfiltrar As System.Windows.Forms.TextBox
    Friend WithEvents Radcredito As System.Windows.Forms.RadioButton
    Friend WithEvents Radcontado As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnumfact As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtfecha As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtvendedor As System.Windows.Forms.TextBox
    Friend WithEvents lblnomcliente As System.Windows.Forms.Label
    Friend WithEvents txtnomclinte As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsubtot As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents lbldescuento As System.Windows.Forms.Label
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Lblfecha_limite As System.Windows.Forms.Label
    Friend WithEvents txtfecha_liite As System.Windows.Forms.TextBox
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents txtestado As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtcantidad_devolucion As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DEVOLUCION As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtsubnuevo As System.Windows.Forms.TextBox
    Friend WithEvents Txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
