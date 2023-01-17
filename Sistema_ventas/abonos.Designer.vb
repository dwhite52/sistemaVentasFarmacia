<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class abonos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.Datefecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btnbuscar = New System.Windows.Forms.Button()
        Me.txtnumfact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtsaldot = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cmbestado = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtsaldop = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcnom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtccod = New System.Windows.Forms.TextBox()
        Me.txtnumreferencia = New System.Windows.Forms.TextBox()
        Me.lblcantimporte = New System.Windows.Forms.Label()
        Me.Lbltipocambio = New System.Windows.Forms.Label()
        Me.txttipocambio = New System.Windows.Forms.TextBox()
        Me.Lblnumreferncia = New System.Windows.Forms.Label()
        Me.cmbformapago = New System.Windows.Forms.ComboBox()
        Me.Lblformapago = New System.Windows.Forms.Label()
        Me.cmbtipomoneda = New System.Windows.Forms.ComboBox()
        Me.Lbltipomoneda = New System.Windows.Forms.Label()
        Me.txtmoneda = New System.Windows.Forms.TextBox()
        Me.lblmoneda = New System.Windows.Forms.Label()
        Me.txtcantimporte = New System.Windows.Forms.TextBox()
        Me.Btnhecho = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblcambio = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtrecibi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Lblsaldopendiente = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1171, 64)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_ventas.My.Resources.Resources._44
        Me.PictureBox1.Location = New System.Drawing.Point(452, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 52)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Lbltitulo
        '
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbltitulo.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.Color.White
        Me.Lbltitulo.Location = New System.Drawing.Point(468, 67)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(216, 25)
        Me.Lbltitulo.TabIndex = 17
        Me.Lbltitulo.Text = "PAGOS POR CREDITO"
        '
        'Datefecha
        '
        Me.Datefecha.Enabled = False
        Me.Datefecha.Location = New System.Drawing.Point(401, 32)
        Me.Datefecha.Name = "Datefecha"
        Me.Datefecha.Size = New System.Drawing.Size(262, 27)
        Me.Datefecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(346, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Btnbuscar)
        Me.GroupBox1.Controls.Add(Me.txtnumfact)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(32, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 82)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BUSQUEDA DE FACTURA"
        '
        'Btnbuscar
        '
        Me.Btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbuscar.ForeColor = System.Drawing.Color.Black
        Me.Btnbuscar.Location = New System.Drawing.Point(244, 45)
        Me.Btnbuscar.Name = "Btnbuscar"
        Me.Btnbuscar.Size = New System.Drawing.Size(95, 27)
        Me.Btnbuscar.TabIndex = 5
        Me.Btnbuscar.Text = "BUSCAR"
        Me.Btnbuscar.UseVisualStyleBackColor = True
        '
        'txtnumfact
        '
        Me.txtnumfact.Location = New System.Drawing.Point(24, 45)
        Me.txtnumfact.Name = "txtnumfact"
        Me.txtnumfact.Size = New System.Drawing.Size(198, 27)
        Me.txtnumfact.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "N° FACTURA"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtsaldot)
        Me.GroupBox2.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(846, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(243, 72)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MONTO TOTAL "
        '
        'txtsaldot
        '
        Me.txtsaldot.Location = New System.Drawing.Point(30, 26)
        Me.txtsaldot.Name = "txtsaldot"
        Me.txtsaldot.ReadOnly = True
        Me.txtsaldot.Size = New System.Drawing.Size(198, 27)
        Me.txtsaldot.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Cmbestado)
        Me.GroupBox3.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(393, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 82)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ESTADO DE CUENTA "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ESTADO"
        '
        'Cmbestado
        '
        Me.Cmbestado.Enabled = False
        Me.Cmbestado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmbestado.FormattingEnabled = True
        Me.Cmbestado.Items.AddRange(New Object() {"Pendiente", "Cancelado"})
        Me.Cmbestado.Location = New System.Drawing.Point(16, 45)
        Me.Cmbestado.Name = "Cmbestado"
        Me.Cmbestado.Size = New System.Drawing.Size(121, 28)
        Me.Cmbestado.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtsaldop)
        Me.GroupBox4.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(588, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(243, 72)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SALDO PENDIENTE "
        '
        'txtsaldop
        '
        Me.txtsaldop.Location = New System.Drawing.Point(30, 26)
        Me.txtsaldop.Name = "txtsaldop"
        Me.txtsaldop.ReadOnly = True
        Me.txtsaldop.Size = New System.Drawing.Size(198, 27)
        Me.txtsaldop.TabIndex = 4
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtcnom)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtccod)
        Me.GroupBox5.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(13, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(384, 176)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "INFO CUENTA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CUENTA A NOMBRE DE"
        '
        'txtcnom
        '
        Me.txtcnom.Location = New System.Drawing.Point(157, 43)
        Me.txtcnom.Name = "txtcnom"
        Me.txtcnom.ReadOnly = True
        Me.txtcnom.Size = New System.Drawing.Size(198, 27)
        Me.txtcnom.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CODIGO DE LA CUENTA"
        '
        'txtccod
        '
        Me.txtccod.Location = New System.Drawing.Point(157, 92)
        Me.txtccod.Name = "txtccod"
        Me.txtccod.ReadOnly = True
        Me.txtccod.Size = New System.Drawing.Size(198, 27)
        Me.txtccod.TabIndex = 4
        '
        'txtnumreferencia
        '
        Me.txtnumreferencia.Location = New System.Drawing.Point(146, 113)
        Me.txtnumreferencia.Name = "txtnumreferencia"
        Me.txtnumreferencia.Size = New System.Drawing.Size(220, 27)
        Me.txtnumreferencia.TabIndex = 27
        '
        'lblcantimporte
        '
        Me.lblcantimporte.AutoSize = True
        Me.lblcantimporte.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantimporte.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblcantimporte.Location = New System.Drawing.Point(5, 190)
        Me.lblcantimporte.Name = "lblcantimporte"
        Me.lblcantimporte.Size = New System.Drawing.Size(142, 20)
        Me.lblcantimporte.TabIndex = 30
        Me.lblcantimporte.Text = "Cantidad de importe"
        '
        'Lbltipocambio
        '
        Me.Lbltipocambio.AutoSize = True
        Me.Lbltipocambio.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltipocambio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbltipocambio.Location = New System.Drawing.Point(27, 155)
        Me.Lbltipocambio.Name = "Lbltipocambio"
        Me.Lbltipocambio.Size = New System.Drawing.Size(112, 20)
        Me.Lbltipocambio.TabIndex = 26
        Me.Lbltipocambio.Text = "Tipo de Cambio"
        '
        'txttipocambio
        '
        Me.txttipocambio.Location = New System.Drawing.Point(147, 149)
        Me.txttipocambio.Name = "txttipocambio"
        Me.txttipocambio.Size = New System.Drawing.Size(158, 27)
        Me.txttipocambio.TabIndex = 25
        '
        'Lblnumreferncia
        '
        Me.Lblnumreferncia.AutoSize = True
        Me.Lblnumreferncia.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnumreferncia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lblnumreferncia.Location = New System.Drawing.Point(5, 119)
        Me.Lblnumreferncia.Name = "Lblnumreferncia"
        Me.Lblnumreferncia.Size = New System.Drawing.Size(135, 20)
        Me.Lblnumreferncia.TabIndex = 28
        Me.Lblnumreferncia.Text = "Num de Referencia"
        '
        'cmbformapago
        '
        Me.cmbformapago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbformapago.FormattingEnabled = True
        Me.cmbformapago.Items.AddRange(New Object() {"Efectivo", "Cheque", "Tarjeta"})
        Me.cmbformapago.Location = New System.Drawing.Point(588, 43)
        Me.cmbformapago.Name = "cmbformapago"
        Me.cmbformapago.Size = New System.Drawing.Size(162, 24)
        Me.cmbformapago.TabIndex = 21
        Me.cmbformapago.Text = "Efectivo"
        '
        'Lblformapago
        '
        Me.Lblformapago.AutoSize = True
        Me.Lblformapago.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblformapago.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lblformapago.Location = New System.Drawing.Point(466, 44)
        Me.Lblformapago.Name = "Lblformapago"
        Me.Lblformapago.Size = New System.Drawing.Size(115, 20)
        Me.Lblformapago.TabIndex = 22
        Me.Lblformapago.Text = "Forma de Pago "
        '
        'cmbtipomoneda
        '
        Me.cmbtipomoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipomoneda.FormattingEnabled = True
        Me.cmbtipomoneda.Items.AddRange(New Object() {"Cordoba", "Dolar"})
        Me.cmbtipomoneda.Location = New System.Drawing.Point(587, 84)
        Me.cmbtipomoneda.Name = "cmbtipomoneda"
        Me.cmbtipomoneda.Size = New System.Drawing.Size(159, 24)
        Me.cmbtipomoneda.TabIndex = 23
        Me.cmbtipomoneda.Text = "Cordoba"
        '
        'Lbltipomoneda
        '
        Me.Lbltipomoneda.AutoSize = True
        Me.Lbltipomoneda.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltipomoneda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbltipomoneda.Location = New System.Drawing.Point(465, 83)
        Me.Lbltipomoneda.Name = "Lbltipomoneda"
        Me.Lbltipomoneda.Size = New System.Drawing.Size(115, 20)
        Me.Lbltipomoneda.TabIndex = 24
        Me.Lbltipomoneda.Text = "Tipo de Moneda"
        '
        'txtmoneda
        '
        Me.txtmoneda.Enabled = False
        Me.txtmoneda.Location = New System.Drawing.Point(425, 185)
        Me.txtmoneda.Name = "txtmoneda"
        Me.txtmoneda.ReadOnly = True
        Me.txtmoneda.Size = New System.Drawing.Size(98, 27)
        Me.txtmoneda.TabIndex = 31
        '
        'lblmoneda
        '
        Me.lblmoneda.AutoSize = True
        Me.lblmoneda.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmoneda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblmoneda.Location = New System.Drawing.Point(277, 190)
        Me.lblmoneda.Name = "lblmoneda"
        Me.lblmoneda.Size = New System.Drawing.Size(124, 20)
        Me.lblmoneda.TabIndex = 32
        Me.lblmoneda.Text = "Moneda Nacional"
        '
        'txtcantimporte
        '
        Me.txtcantimporte.Location = New System.Drawing.Point(153, 185)
        Me.txtcantimporte.Name = "txtcantimporte"
        Me.txtcantimporte.Size = New System.Drawing.Size(86, 27)
        Me.txtcantimporte.TabIndex = 29
        '
        'Btnhecho
        '
        Me.Btnhecho.ForeColor = System.Drawing.Color.Black
        Me.Btnhecho.Location = New System.Drawing.Point(869, 124)
        Me.Btnhecho.Name = "Btnhecho"
        Me.Btnhecho.Size = New System.Drawing.Size(112, 43)
        Me.Btnhecho.TabIndex = 6
        Me.Btnhecho.Text = "REALIZAR"
        Me.Btnhecho.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Lbltipomoneda)
        Me.Panel2.Controls.Add(Me.cmbtipomoneda)
        Me.Panel2.Controls.Add(Me.cmbformapago)
        Me.Panel2.Controls.Add(Me.Lblformapago)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Location = New System.Drawing.Point(32, 218)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1137, 278)
        Me.Panel2.TabIndex = 8
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblcambio)
        Me.GroupBox6.Controls.Add(Me.txtnumreferencia)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Lblnumreferncia)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txttipocambio)
        Me.GroupBox6.Controls.Add(Me.lblmoneda)
        Me.GroupBox6.Controls.Add(Me.lblcantimporte)
        Me.GroupBox6.Controls.Add(Me.txtcantimporte)
        Me.GroupBox6.Controls.Add(Me.txtmoneda)
        Me.GroupBox6.Controls.Add(Me.Lbltipocambio)
        Me.GroupBox6.Controls.Add(Me.Datefecha)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(441, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(681, 265)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = " PAGOS"
        '
        'lblcambio
        '
        Me.lblcambio.AutoSize = True
        Me.lblcambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcambio.ForeColor = System.Drawing.Color.Tomato
        Me.lblcambio.Location = New System.Drawing.Point(590, 238)
        Me.lblcambio.Name = "lblcambio"
        Me.lblcambio.Size = New System.Drawing.Size(0, 24)
        Me.lblcambio.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Tomato
        Me.Label6.Location = New System.Drawing.Point(549, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 24)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "C$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Tomato
        Me.Label10.Location = New System.Drawing.Point(471, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 24)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Cambio"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.ComboBox1)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.txtcantidad)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.Btnhecho)
        Me.GroupBox7.Controls.Add(Me.txtrecibi)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(56, 502)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1098, 176)
        Me.GroupBox7.TabIndex = 9
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "POR FAVOR RELLENA"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Abono", "Cancelacion"})
        Me.ComboBox1.Location = New System.Drawing.Point(157, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(158, 26)
        Me.ComboBox1.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "LA CANTIDAD DE "
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(157, 140)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(158, 27)
        Me.txtcantidad.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(7, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "RECIBI DE"
        '
        'txtrecibi
        '
        Me.txtrecibi.Location = New System.Drawing.Point(157, 43)
        Me.txtrecibi.Name = "txtrecibi"
        Me.txtrecibi.Size = New System.Drawing.Size(380, 27)
        Me.txtrecibi.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "POR CUENTA DE"
        '
        'Lblsaldopendiente
        '
        Me.Lblsaldopendiente.AutoSize = True
        Me.Lblsaldopendiente.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsaldopendiente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lblsaldopendiente.Location = New System.Drawing.Point(701, 691)
        Me.Lblsaldopendiente.Name = "Lblsaldopendiente"
        Me.Lblsaldopendiente.Size = New System.Drawing.Size(0, 20)
        Me.Lblsaldopendiente.TabIndex = 25
        '
        'abonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1166, 741)
        Me.Controls.Add(Me.Lblsaldopendiente)
        Me.Controls.Add(Me.Lbltitulo)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "abonos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "abonos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Datefecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtnumfact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsaldot As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cmbestado As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsaldop As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcnom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtccod As System.Windows.Forms.TextBox
    Friend WithEvents txtnumreferencia As System.Windows.Forms.TextBox
    Friend WithEvents lblcantimporte As System.Windows.Forms.Label
    Friend WithEvents Lbltipocambio As System.Windows.Forms.Label
    Friend WithEvents txttipocambio As System.Windows.Forms.TextBox
    Friend WithEvents Lblnumreferncia As System.Windows.Forms.Label
    Friend WithEvents cmbformapago As System.Windows.Forms.ComboBox
    Friend WithEvents Lblformapago As System.Windows.Forms.Label
    Friend WithEvents cmbtipomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Lbltipomoneda As System.Windows.Forms.Label
    Friend WithEvents txtmoneda As System.Windows.Forms.TextBox
    Friend WithEvents lblmoneda As System.Windows.Forms.Label
    Friend WithEvents txtcantimporte As System.Windows.Forms.TextBox
    Friend WithEvents Btnhecho As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtrecibi As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblcambio As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lblsaldopendiente As System.Windows.Forms.Label
End Class
