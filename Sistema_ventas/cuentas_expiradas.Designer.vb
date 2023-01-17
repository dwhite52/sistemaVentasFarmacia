<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuentas_expiradas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DATAGRIDCREDEXPIRADOS = New System.Windows.Forms.DataGridView()
        CType(Me.DATAGRIDCREDEXPIRADOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(954, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CREDITOS PROXIMO A  EXPIRAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DATAGRIDCREDEXPIRADOS
        '
        Me.DATAGRIDCREDEXPIRADOS.AllowUserToAddRows = False
        Me.DATAGRIDCREDEXPIRADOS.AllowUserToDeleteRows = False
        Me.DATAGRIDCREDEXPIRADOS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATAGRIDCREDEXPIRADOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DATAGRIDCREDEXPIRADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAGRIDCREDEXPIRADOS.EnableHeadersVisualStyles = False
        Me.DATAGRIDCREDEXPIRADOS.GridColor = System.Drawing.Color.White
        Me.DATAGRIDCREDEXPIRADOS.Location = New System.Drawing.Point(2, 41)
        Me.DATAGRIDCREDEXPIRADOS.Name = "DATAGRIDCREDEXPIRADOS"
        Me.DATAGRIDCREDEXPIRADOS.ReadOnly = True
        Me.DATAGRIDCREDEXPIRADOS.RowHeadersVisible = False
        Me.DATAGRIDCREDEXPIRADOS.Size = New System.Drawing.Size(952, 471)
        Me.DATAGRIDCREDEXPIRADOS.TabIndex = 3
        '
        'cuentas_expiradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 515)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DATAGRIDCREDEXPIRADOS)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cuentas_expiradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cuentas_expiradas"
        CType(Me.DATAGRIDCREDEXPIRADOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DATAGRIDCREDEXPIRADOS As System.Windows.Forms.DataGridView
End Class
