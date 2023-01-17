Imports System.Data
Imports MySql.Data.MySqlClient



Public Class Buscarproductodescripcion
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable
    Public dt As New DataTable
    Dim cmd As MySqlCommand
    Dim da As New MySqlDataAdapter
    Public descripcion As String
    Public Sub cargar_datos_producto()


        Try
            'conex.Open()
            Dim sql As String = "SELECT idprod as Codigo,Descripcion,clasificacion as Clasificacion,fecha_expiracion as Fecha_Expiracion,precio_de_venta_unit as Precio_Venta,existencia as Existencia FROM sist_ventas.productos;"
            cmd = New MySqlCommand(sql, conex)
            da.SelectCommand = cmd
            dt.Reset()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            With DataGridView1
                .Columns(0).Width = 200
                .Columns(1).Width = 190
                .Columns(2).Width = 170
                .Columns(3).Width = 150
                .Columns(4).Width = 150
                .Columns(5).Width = 150
                .Columns(6).Width = 150

            End With
            da.Update(dt)
            'conex.Close()

        Catch ex As Exception
        End Try
    End Sub


    Private Sub Buscarproductodescripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar_datos_producto()
    End Sub
    Dim dv As New DataView
    Private Sub Txtfiltrar_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltrar.TextChanged
        If Cmbfiltrar.Text = "Codigo" Then
            Dim dv As New DataView(dt)
            dv.RowFilter = String.Format("Codigo like '%{0}%'", Txtfiltrar.Text)
            DataGridView1.DataSource = dv
            If DataGridView1.Rows.Count > 0 And Not Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.LimeGreen
            ElseIf DataGridView1.Rows.Count < 1 Then
                Txtfiltrar.BackColor = Color.Tomato
            ElseIf Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.White

            End If
        ElseIf Cmbfiltrar.Text = "Descripcion" Then
            Dim dv As New DataView(dt)
            dv.RowFilter = String.Format("Descripcion like '%{0}%'", Txtfiltrar.Text)
            DataGridView1.DataSource = dv
            If DataGridView1.Rows.Count > 0 And Not Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.LimeGreen
            ElseIf DataGridView1.Rows.Count < 1 Then
                Txtfiltrar.BackColor = Color.Tomato
            ElseIf Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.White

            End If
        ElseIf Cmbfiltrar.Text = "Clasificacion" Then
            Dim dv As New DataView(dt)
            dv.RowFilter = String.Format("Clasificacion like '%{0}%'", Txtfiltrar.Text)
            DataGridView1.DataSource = dv
            If DataGridView1.Rows.Count > 0 And Not Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.LimeGreen
            ElseIf DataGridView1.Rows.Count < 1 Then
                Txtfiltrar.BackColor = Color.Tomato
            ElseIf Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.White

            End If
        End If

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            TextBox1.Text = row.Cells(1).Value.ToString
            descripcion = TextBox1.Text
            ventas.txtdescprod.Text = descripcion
            Me.Dispose()

        End If
   
        'ventas.txtdescprod.Text = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString
        'Me.Close()
    End Sub

  

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        'Dim valor As String
        'valor = DataGridView1.CurrentRow.Cells(1).Value.ToString
        'ventas.txtdescprod.Text = valor
        ventas.txtdescprod.Clear()

       
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Buscarproductodescripcion_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim rec As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
        '
        'Create a new brush. Make is a Gradient style brush.
        '
        Dim myBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(rec, Color.Turquoise, _
          Color.Black, Drawing.Drawing2D.LinearGradientMode.Vertical)
        '
        'draw the gradient onto the form.
        e.Graphics.FillRectangle(myBrush, rec)
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000

            Return cp
        End Get
    End Property 'CreateParams


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class