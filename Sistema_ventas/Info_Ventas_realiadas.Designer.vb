<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_Ventas_realiadas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chktodo = New System.Windows.Forms.CheckBox()
        Me.Radfecha = New System.Windows.Forms.RadioButton()
        Me.Raddia = New System.Windows.Forms.RadioButton()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnver = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dateal = New System.Windows.Forms.DateTimePicker()
        Me.Datedel = New System.Windows.Forms.DateTimePicker()
        Me.Btnimprimir = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbltitulo
        '
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbltitulo.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.Color.White
        Me.Lbltitulo.Location = New System.Drawing.Point(416, 88)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(216, 25)
        Me.Lbltitulo.TabIndex = 17
        Me.Lbltitulo.Text = "VENTAS REALIZADAS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Chktodo)
        Me.Panel2.Controls.Add(Me.Radfecha)
        Me.Panel2.Controls.Add(Me.Raddia)
        Me.Panel2.Controls.Add(Me.Lbltotal)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Btnver)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Dateal)
        Me.Panel2.Controls.Add(Me.Datedel)
        Me.Panel2.Location = New System.Drawing.Point(0, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1008, 462)
        Me.Panel2.TabIndex = 2
        '
        'Chktodo
        '
        Me.Chktodo.AutoSize = True
        Me.Chktodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chktodo.ForeColor = System.Drawing.Color.White
        Me.Chktodo.Location = New System.Drawing.Point(774, 139)
        Me.Chktodo.Name = "Chktodo"
        Me.Chktodo.Size = New System.Drawing.Size(126, 17)
        Me.Chktodo.TabIndex = 12
        Me.Chktodo.Text = "MOSTRAR TODO"
        Me.Chktodo.UseVisualStyleBackColor = True
        '
        'Radfecha
        '
        Me.Radfecha.AutoSize = True
        Me.Radfecha.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radfecha.ForeColor = System.Drawing.Color.White
        Me.Radfecha.Location = New System.Drawing.Point(397, 35)
        Me.Radfecha.Name = "Radfecha"
        Me.Radfecha.Size = New System.Drawing.Size(325, 26)
        Me.Radfecha.TabIndex = 11
        Me.Radfecha.Text = "SELECCIONE EL RANGO DE FECHA"
        Me.Radfecha.UseVisualStyleBackColor = True
        '
        'Raddia
        '
        Me.Raddia.AutoSize = True
        Me.Raddia.Checked = True
        Me.Raddia.Font = New System.Drawing.Font("Bodoni MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Raddia.ForeColor = System.Drawing.Color.White
        Me.Raddia.Location = New System.Drawing.Point(166, 35)
        Me.Raddia.Name = "Raddia"
        Me.Raddia.Size = New System.Drawing.Size(176, 26)
        Me.Raddia.TabIndex = 10
        Me.Raddia.TabStop = True
        Me.Raddia.Text = "VENTAS DEL DIA"
        Me.Raddia.UseVisualStyleBackColor = True
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotal.ForeColor = System.Drawing.Color.Lime
        Me.Lbltotal.Location = New System.Drawing.Point(739, 431)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(0, 24)
        Me.Lbltotal.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(553, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "TOTAL DE VENTAS C$"
        '
        'Btnver
        '
        Me.Btnver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnver.Location = New System.Drawing.Point(670, 132)
        Me.Btnver.Name = "Btnver"
        Me.Btnver.Size = New System.Drawing.Size(86, 29)
        Me.Btnver.TabIndex = 7
        Me.Btnver.Text = "VER"
        Me.Btnver.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(983, 250)
        Me.DataGridView1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(148, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(519, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AL"
        '
        'Dateal
        '
        Me.Dateal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dateal.Location = New System.Drawing.Point(585, 82)
        Me.Dateal.Name = "Dateal"
        Me.Dateal.Size = New System.Drawing.Size(253, 22)
        Me.Dateal.TabIndex = 1
        '
        'Datedel
        '
        Me.Datedel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datedel.Location = New System.Drawing.Point(218, 82)
        Me.Datedel.Name = "Datedel"
        Me.Datedel.Size = New System.Drawing.Size(253, 22)
        Me.Datedel.TabIndex = 0
        '
        'Btnimprimir
        '
        Me.Btnimprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnimprimir.Image = Global.Sistema_ventas.My.Resources.Resources.Print
        Me.Btnimprimir.Location = New System.Drawing.Point(796, 553)
        Me.Btnimprimir.Name = "Btnimprimir"
        Me.Btnimprimir.Size = New System.Drawing.Size(119, 35)
        Me.Btnimprimir.TabIndex = 6
        Me.Btnimprimir.Text = "Imprimir"
        Me.Btnimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btnimprimir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Teal
        Me.Button2.Image = Global.Sistema_ventas.My.Resources.Resources.back
        Me.Button2.Location = New System.Drawing.Point(965, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 46)
        Me.Button2.TabIndex = 57
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_ventas.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(432, -43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'Info_Ventas_realiadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1007, 599)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Lbltitulo)
        Me.Controls.Add(Me.Btnimprimir)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Info_Ventas_realiadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Info_Ventas_realiadas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dateal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Datedel As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btnimprimir As System.Windows.Forms.Button
    Friend WithEvents Btnver As System.Windows.Forms.Button
    Friend WithEvents Radfecha As System.Windows.Forms.RadioButton
    Friend WithEvents Raddia As System.Windows.Forms.RadioButton
    Friend WithEvents Lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Chktodo As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
