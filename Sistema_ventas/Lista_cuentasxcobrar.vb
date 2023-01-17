Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Lista_cuentasxcobrar
    Public Sub cargar_todas()
        tabla.Reset()
        Dim sql As String
        sql = "SELECT credito.Num_Boleta_cred as N_factura ,credito.vendedor,credito.fecha,credito.subtotal,credito.iva,credito.total,cuentas_x_cobrar.Clientes_Cod_Clientes as Codigo_clientes,clientes.nombre,cuentas_x_cobrar.fecha_de_vencimiento,cuentas_x_cobrar.estado FROM credito inner join cuentas_x_cobrar on credito.Num_Boleta_cred= cuentas_x_cobrar.Credito_Num_Boleta_cred inner join clientes on clientes.Cod_Clientes=cuentas_x_cobrar.Clientes_Cod_Clientes;"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            tabla = New DataTable()
            da.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub
    Public Sub cargar_pendiente()
        tabla.Reset()
        Dim sql As String
        sql = "SELECT credito.Num_Boleta_cred as N_factura,credito.vendedor,credito.fecha,credito.subtotal,credito.iva,credito.total,cuentas_x_cobrar.Clientes_Cod_Clientes as Codigo_clientes,clientes.nombre,cuentas_x_cobrar.fecha_de_vencimiento,cuentas_x_cobrar.estado FROM credito inner join cuentas_x_cobrar on credito.Num_Boleta_cred= cuentas_x_cobrar.Credito_Num_Boleta_cred inner join clientes on clientes.Cod_Clientes=cuentas_x_cobrar.Clientes_Cod_Clientes where cuentas_x_cobrar.estado='pendiente';"
       
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            tabla = New DataTable()
            da.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub
    Public Sub cargar_cancelado()
        tabla.Reset()
        Dim sql As String
       
        sql = "SELECT credito.Num_Boleta_cred as N_factura,credito.vendedor,credito.fecha,credito.subtotal,credito.iva,credito.total,cuentas_x_cobrar.Clientes_Cod_Clientes as Codigo_clientes,clientes.nombre,cuentas_x_cobrar.fecha_de_vencimiento,cuentas_x_cobrar.estado FROM credito inner join cuentas_x_cobrar on credito.Num_Boleta_cred= cuentas_x_cobrar.Credito_Num_Boleta_cred inner join clientes on clientes.Cod_Clientes=cuentas_x_cobrar.Clientes_Cod_Clientes where cuentas_x_cobrar.estado='Cancelado';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            tabla = New DataTable()
            da.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub

    Private Sub Txtfiltrar_GotFocus(sender As Object, e As EventArgs) Handles Txtfiltrar.GotFocus
        Txtfiltrar.BackColor = Color.White
    End Sub
    Private Sub Txtfiltrar_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltrar.TextChanged
        If Cmbfiltrar.Text = "Nombre de Cliente" Then

            Dim dv As New DataView(tabla)
            dv.RowFilter = String.Format("nombre like '%{0}%'", Txtfiltrar.Text)
            DataGridView1.DataSource = dv
            If DataGridView1.Rows.Count > 0 And Not Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.LimeGreen
                Dim suma As Double
                For i = 0 To DataGridView1.RowCount - 1
                    'hace la suma de todas las filas del subtotal'
                    suma += Val(DataGridView1.Rows(i).Cells(5).Value)
                Next
                lbltotal.Text = suma.ToString
                lbltotal.Visible = True
                Label2.Visible = True
            ElseIf Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.White
            ElseIf DataGridView1.Rows.Count < 1 Then
                Txtfiltrar.BackColor = Color.Tomato

            End If
        ElseIf Cmbfiltrar.Text = "N factura" Then

            Dim dv As New DataView(tabla)
            dv.RowFilter = "Convert([N_factura],System.String) like '%" + Txtfiltrar.Text + "'"
            DataGridView1.DataSource = dv
            If DataGridView1.Rows.Count > 0 And Not Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.LimeGreen
            ElseIf Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.White
            ElseIf DataGridView1.Rows.Count < 1 Then
                Txtfiltrar.BackColor = Color.Tomato

            End If
        End If

    End Sub

    Private Sub Lista_cuentasxcobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_todas()
        With DataGridView1
            .Columns(0).Width = 100
            .Columns(1).Width = 100
            .Columns(2).Width = 100
            .Columns(3).Width = 150
            .Columns(4).Width = 100
            .Columns(5).Width = 150
            .Columns(6).Width = 150
            .Columns(8).Width = 150

        End With

        lbltotal.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub Lista_cuentasxcobrar_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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



    Private Sub Radpendiente_CheckedChanged(sender As Object, e As EventArgs) Handles Radpendiente.CheckedChanged
        cargar_pendiente()
        With DataGridView1
            .Columns(0).Width = 200
            .Columns(1).Width = 190
            .Columns(2).Width = 170
            .Columns(3).Width = 150
            .Columns(4).Width = 150
            .Columns(5).Width = 150
            .Columns(6).Width = 150
            .Columns(8).Width = 150

        End With

        Dim suma As Double
        For i = 0 To DataGridView1.RowCount - 1
            'hace la suma de todas las filas del subtotal'
            suma += Val(DataGridView1.Rows(i).Cells(5).Value)
        Next
        lbltotal.Text = suma.ToString
        lbltotal.Visible = True
        Label2.Visible = True
    End Sub

    Private Sub RadCancelado_CheckedChanged(sender As Object, e As EventArgs) Handles RadCancelado.CheckedChanged
        cargar_cancelado()
        With DataGridView1
            .Columns(0).Width = 200
            .Columns(1).Width = 190
            .Columns(2).Width = 170
            .Columns(3).Width = 150
            .Columns(4).Width = 150
            .Columns(5).Width = 150
            .Columns(6).Width = 150
            .Columns(8).Width = 150
            
        End With
        lbltotal.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub RadTodas_CheckedChanged(sender As Object, e As EventArgs) Handles RadTodas.CheckedChanged
        cargar_todas()
        With DataGridView1
            .Columns(0).Width = 200
            .Columns(1).Width = 190
            .Columns(2).Width = 170
            .Columns(3).Width = 150
            .Columns(4).Width = 150
            .Columns(5).Width = 150
            .Columns(6).Width = 150
            .Columns(8).Width = 150
           
        End With
        lbltotal.Visible = False
        Label2.Visible = False
    End Sub

    Private Sub Cmbfiltrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbfiltrar.SelectedIndexChanged
        Txtfiltrar.Clear()
        Txtfiltrar.Focus()
        If Cmbfiltrar.Text = "Nº factura" Then
            Panel1.Visible = False
        Else
            Panel1.Visible = True
            RadTodas.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class