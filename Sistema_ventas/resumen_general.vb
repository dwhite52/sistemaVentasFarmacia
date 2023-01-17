Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class resumen_general
    Dim dt_ventas As New DataTable
    Dim dt_abono As New DataTable
    Dim dt_credito As New DataTable
    'Public Sub cargar_todo()

    '    Dim sql_ventas As String = "SELECT sum(ventas.neto) as total from ventas where ventas.fecha_venta='" + Date.Now.ToString("yyyy-MM-d") + "';"


    '    Try
    '        dt_ventas.Reset()
    '        Dim da As New MySqlDataAdapter(sql_ventas, conex)
    '        da.SelectCommand.CommandType = CommandType.Text
    '        da.Fill(dt_ventas)
    '        txtvcont.Text = dt_ventas.Rows(0)(0).ToString

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error")

    '    End Try

    '//*******AQUI EMPIEZA EL TOTAL DE ABONO
    ' Dim sql_abono As String = "SELECT sum(abono.cantidad) as total2 from abono where abono.fecha_pago='" + Date.Now.ToString("yyyy-MM-d") + "';"
    ' Try
    'dt_abono.Reset()
    'Dim da1 As New MySqlDataAdapter(sql_abono, conex)
    ' da1.SelectCommand.CommandType = CommandType.Text
    ' da1.Fill(dt_abono)
    'If dt_abono.Rows.Count > 0 Then
    '    txtpagcuentas.Text = dt_abono.Rows(0)(0).ToString
    ' End If
    ' Catch ex As Exception
    '  MessageBox.Show(ex.Message, "Error")
    ' End Try

    '\\AQUI TERMINA*****

    '//*************AQUI EMPIEZA EL TOTAL DE CREDITO
    'Dim sql_credito As String = "SELECT sum(credito.total) as total from credito where credito.fecha='" + Date.Now.ToString("yyyy-MM-d") + "';"
    ' Try
    'dt_credito.Reset()
    'Dim da As New MySqlDataAdapter(sql_credito, conex)
    'da.SelectCommand.CommandType = CommandType.Text
    'da.Fill(dt_credito)
    'If dt_credito.Rows.Count > 0 Then
    'txtvcred.Text = dt_credito.Rows(0)(0).ToString
    'End If
    'Catch ex As Exception
    'MessageBox.Show(ex.Message, "Error")
    'End Try
    '\\ AQUI TERMINA ******
    'End Sub

    Dim dt1 As New DataTable

    Public Sub cargar_Todos()

        'Dim sql_ventas As String = "SELECT sum(ventas.neto) as total from ventas where ventas.fecha_venta='" + Date.Now.ToString("yyyy-MM-d") + "'and vendedor='" + Login.user + "';"
        Dim sql As String = "SELECT (select sum(capital_caja.cantidad) from capital_caja where capital_caja.fecha ='" + Date.Now.ToString("yyyy-M-d") + "')as Total_Capital ,(select sum(ventas.neto)  from ventas where ventas.fecha_venta = '" + Date.Now.ToString("yyyy-M-d") + "') AS Total_Ventas,(select sum(egresos.Cantidad)  from egresos where egresos.fecha='" + Date.Now.ToString("yyyy-M-d") + "')as Total_Gastos ;"


        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            dt1.Reset()
            da.Fill(dt1)
            If dt1.Rows(0)(0).ToString = "" Then
                dt1.Rows(0)(0) = 0
            End If

            If dt1.Rows(0)(1).ToString = "" Then
                dt1.Rows(0)(1) = 0
            End If

            If dt1.Rows(0)(2).ToString = "" Then
                dt1.Rows(0)(2) = 0
            End If

            DataGridView1.DataSource = dt1

            With DataGridView1
                .Columns(0).Width = 180
                .Columns(1).Width = 170
                .Columns(2).Width = 170

            End With
            Dim Total As Double
            Total = (Val(DataGridView1.Rows(0).Cells(0).Value) + Val(DataGridView1.Rows(0).Cells(1).Value)) - Val(DataGridView1.Rows(0).Cells(2).Value)
            Lbltotal.Text = Total.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")

        End Try
        '//*************CODIGO PARA CARGAR DATOS ESPECIFICOS
        '    Dim sql_abono As String = "SELECT sum(abono.cantidad) as total2 from abono where abono.fecha_pago='" + Date.Now.ToString("yyyy-MM-d") + "'and vendedor='" + Login.user + "';"
        '    Try
        '        dt_abono.Reset()
        '        Dim da1 As New MySqlDataAdapter(sql_abono, conex)
        '        da1.SelectCommand.CommandType = CommandType.Text
        '        da1.Fill(dt_abono)
        '        If dt_abono.Rows.Count > 0 Then
        '            txtpagcuentas.Text = dt_abono.Rows(0)(0).ToString
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message, "Error")
        '    End Try
        '    Dim sql_credito As String = "SELECT sum(credito.total) as total from credito where credito.fecha='" + Date.Now.ToString("yyyy-MM-d") + "' and vendedor='" + Login.user + "';"
        '    Try
        '        dt_credito.Reset()
        '        Dim da As New MySqlDataAdapter(sql_credito, conex)
        '        da.SelectCommand.CommandType = CommandType.Text
        '        da.Fill(dt_credito)
        '        If dt_credito.Rows.Count > 0 Then
        '            txtvcred.text = dt_credito.rows(0)(0).tostring
        '        End If
        '    Catch ex As exception
        '        messagebox.show(ex.message, "error")
        '    End Try
    End Sub

    Public Sub cargar_usuario()

        'Dim sql_ventas As String = "SELECT sum(ventas.neto) as total from ventas where ventas.fecha_venta='" + Date.Now.ToString("yyyy-MM-d") + "'and vendedor='" + Login.user + "';"
        Dim sql As String = "SELECT (select sum(capital_caja.cantidad) from capital_caja where capital_caja.fecha ='" + Date.Now.ToString("yyyy-M-d") + "' and capital_caja.Usuario= '" + Login.user + "') as Total_capital , (select sum(ventas.neto)  from ventas where ventas.fecha_venta = '" + Date.Now.ToString("yyyy-M-d") + "'  and ventas.vendedor= '" + Login.user + "') AS Total_Ventas ,(select sum(egresos.Cantidad)  from egresos where egresos.fecha='" + Date.Now.ToString("yyyy-M-d") + "' and egresos.Usuario= '" + Login.user + "') as Total_Gastos ;"


        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            dt1.Reset()
            da.Fill(dt1)
            If dt1.Rows(0)(0).ToString = "" Then
                dt1.Rows(0)(0) = 0
            End If

            If dt1.Rows(0)(1).ToString = "" Then
                dt1.Rows(0)(1) = 0
            End If

            If dt1.Rows(0)(2).ToString = "" Then
                dt1.Rows(0)(2) = 0
            End If

            DataGridView1.DataSource = dt1

            With DataGridView1
                .Columns(0).Width = 180
                .Columns(1).Width = 170
                .Columns(2).Width = 170

            End With
            Dim Total As Double
            Total = (Val(DataGridView1.Rows(0).Cells(0).Value) + Val(DataGridView1.Rows(0).Cells(1).Value)) - Val(DataGridView1.Rows(0).Cells(2).Value)
            Lbltotal.Text = Total.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")

        End Try

    End Sub
    Private Sub resumen_general_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lblgrantotal.Text = Val(txtvcont.Text) + Val(txtpagcuentas.Text)
        If Frm_Principal.tipo = "Administrador" Then
            Chktodo.Visible = True
        Else
            Chktodo.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Chktodo_CheckedChanged(sender As Object, e As EventArgs)
        'If Chktodo.Checked = True Then
        '    cargar_todo()
        '    lblgrantotal.Text = Val(txtvcont.Text) + Val(txtpagcuentas.Text)
        'Else
        '    cargar_especifico()
        '    lblgrantotal.Text = Val(txtvcont.Text) + Val(txtpagcuentas.Text)
        'End If
    End Sub

    Private Sub resumen_general_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim rec As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
        '
        'Create a new brush. Make is a Gradient style brush.
        '
        Dim myBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(rec, Color.Teal, _
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

    Private Sub Btnver_Click(sender As Object, e As EventArgs) Handles Btnver.Click

        cargar_usuario()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
  
    End Sub

   
    Private Sub Chktodo_CheckedChanged_1(sender As Object, e As EventArgs) Handles Chktodo.CheckedChanged
        If Chktodo.Checked = True Then
            cargar_Todos()
        Else
            Btnver.PerformClick()
        End If

    End Sub
End Class