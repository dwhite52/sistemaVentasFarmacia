<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnagregarr = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnmodificar_seleccion = New System.Windows.Forms.Button()
        Me.Lbltitulo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bodoni MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(760, 235)
        Me.DataGridView1.TabIndex = 6
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btnagregarr)
        Me.GroupBox4.Controls.Add(Me.btnactualizar)
        Me.GroupBox4.Controls.Add(Me.btncancelar)
        Me.GroupBox4.Controls.Add(Me.btnmodificar_seleccion)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(86, 360)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(561, 66)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
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
        Me.btnagregarr.Location = New System.Drawing.Point(29, 12)
        Me.btnagregarr.Name = "btnagregarr"
        Me.btnagregarr.Size = New System.Drawing.Size(118, 38)
        Me.btnagregarr.TabIndex = 26
        Me.btnagregarr.Text = "AGREGAR"
        Me.btnagregarr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnagregarr.UseVisualStyleBackColor = False
        '
        'btnactualizar
        '
        Me.btnactualizar.BackColor = System.Drawing.Color.Transparent
        Me.btnactualizar.ForeColor = System.Drawing.Color.Teal
        Me.btnactualizar.Image = Global.Sistema_ventas.My.Resources.Resources.refresh
        Me.btnactualizar.Location = New System.Drawing.Point(401, 11)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(141, 39)
        Me.btnactualizar.TabIndex = 10
        Me.btnactualizar.Text = "ACTUALIZAR"
        Me.btnactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnactualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnactualizar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.ForeColor = System.Drawing.Color.Teal
        Me.btncancelar.Image = Global.Sistema_ventas.My.Resources.Resources.Remove
        Me.btncancelar.Location = New System.Drawing.Point(270, 12)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(125, 38)
        Me.btncancelar.TabIndex = 25
        Me.btncancelar.Text = "ELIMINAR"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnmodificar_seleccion
        '
        Me.btnmodificar_seleccion.BackColor = System.Drawing.Color.Transparent
        Me.btnmodificar_seleccion.ForeColor = System.Drawing.Color.Teal
        Me.btnmodificar_seleccion.Image = Global.Sistema_ventas.My.Resources.Resources.edit_client
        Me.btnmodificar_seleccion.Location = New System.Drawing.Point(153, 11)
        Me.btnmodificar_seleccion.Name = "btnmodificar_seleccion"
        Me.btnmodificar_seleccion.Size = New System.Drawing.Size(111, 39)
        Me.btnmodificar_seleccion.TabIndex = 9
        Me.btnmodificar_seleccion.Text = "EDITAR"
        Me.btnmodificar_seleccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmodificar_seleccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnmodificar_seleccion.UseVisualStyleBackColor = False
        '
        'Lbltitulo
        '
        Me.Lbltitulo.AutoSize = True
        Me.Lbltitulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbltitulo.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitulo.ForeColor = System.Drawing.Color.White
        Me.Lbltitulo.Location = New System.Drawing.Point(307, 79)
        Me.Lbltitulo.Name = "Lbltitulo"
        Me.Lbltitulo.Size = New System.Drawing.Size(186, 19)
        Me.Lbltitulo.TabIndex = 49
        Me.Lbltitulo.Text = "USUARIOS DEL SISTEMA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sistema_ventas.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(270, -30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(779, 470)
        Me.Controls.Add(Me.Lbltitulo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar_seleccion As System.Windows.Forms.Button
    Friend WithEvents btnagregarr As System.Windows.Forms.Button
    Friend WithEvents Lbltitulo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
