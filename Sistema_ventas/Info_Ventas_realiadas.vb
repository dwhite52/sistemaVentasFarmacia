Imports System.Data
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.CrystalReports.Engine.ReportDefinition

Public Class Info_Ventas_realiadas
    Dim dt As New DataTable
    Dim dt1 As New DataTable

    Public Sub rango()
        tabla1.Reset()
        Dim sql As String = "SELECT Num_Boleta_contd as No_Factura,fecha_venta as fecha,subtotal1 as subtotal,descuento_total as Descuento,iva as IVA,total as Total,neto as Neto,vendedor,Nombre_Cliente_contd as Nombre_Cliente,forma_pago,tipo_moneda,num_ref  FROM sist_ventas.ventas WHERE fecha_venta between '" + Datedel.Value.ToString("yyyy-M-d") + "' and '" + Dateal.Value.ToString("yyyy-M-d") + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            tabla1 = New DataTable()
            da.Fill(tabla1)
            DataGridView1.DataSource = tabla1
            With DataGridView1
                .Columns(8).Width = 170
            End With
            Dim suma As Double
            For i = 0 To DataGridView1.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGridView1.Rows(i).Cells(6).Value)
            Next
            Lbltotal.Text = suma.ToString

        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try

    End Sub
    Public Sub rango_especifico()

        Dim sql As String = "SELECT Num_Boleta_contd as No_Factura,fecha_venta as fecha,subtotal1 as subtotal,descuento_total as Descuento,iva as IVA,total as Total,neto as Neto,vendedor,Nombre_Cliente_contd as Nombre_Cliente,forma_pago,tipo_moneda,num_ref  FROM sist_ventas.ventas WHERE vendedor='" + Login.user + "' and fecha_venta between '" + Datedel.Value.ToString("yyyy-M-d") + "' and '" + Dateal.Value.ToString("yyyy-M-d") + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt = New DataTable()

            da.Fill(dt)
            DataGridView1.DataSource = dt
            With DataGridView1
                .Columns(8).Width = 170
            End With
            Dim suma As Double
            For i = 0 To DataGridView1.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGridView1.Rows(i).Cells(6).Value)
            Next
            Lbltotal.Text = suma.ToString

        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try

    End Sub

    Public Sub dia()

        Dim sql As String = "SELECT Num_Boleta_contd as No_Factura,fecha_venta as Fecha,subtotal1 as subtotal,descuento_total as Descuento,iva as IVA,total as Total,neto as Neto,vendedor,Nombre_Cliente_contd as Nombre_Cliente,forma_pago,tipo_moneda,num_ref FROM sist_ventas.ventas WHERE fecha_venta = '" + Date.Now.ToString("yyyy-M-d") + "' ;"
        Try
            tabla.Reset()
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            tabla = New DataTable()
            da.Fill(tabla)
            DataGridView1.DataSource = tabla
            With DataGridView1
                .Columns(8).Width = 170
            End With
            Dim suma As Double
            For i = 0 To DataGridView1.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGridView1.Rows(i).Cells(6).Value)
            Next
            Lbltotal.Text = suma.ToString

        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try

    End Sub

    Public Sub dia_especifico()

        Dim sql As String = "SELECT Num_Boleta_contd as No_Factura,fecha_venta as Fecha,subtotal1 as subtotal,descuento_total as Descuento,iva as IVA,total as Total,neto as Neto,vendedor,Nombre_Cliente_contd as Nombre_Cliente,forma_pago,tipo_moneda,num_ref FROM sist_ventas.ventas WHERE vendedor='" + Login.user + "' and  fecha_venta = '" + Date.Now.ToString("yyyy-M-d") + "' ;"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            dt1.Reset()
            da.Fill(dt1)

            DataGridView1.DataSource = dt1
            With DataGridView1
                .Columns(8).Width = 170
            End With
            Dim suma As Double
            For i = 0 To DataGridView1.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGridView1.Rows(i).Cells(6).Value)
            Next
            Lbltotal.Text = suma.ToString

        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnver.Click
        Try
            'If Raddia.Checked = True And Chktodo.Checked = True Then
            '    dia()
            'ElseIf Radfecha.Checked = True And Chktodo.Checked = True Then
            'rango()
            Chktodo.Checked = False
            If Raddia.Checked = True Then
                dia_especifico()
                If DataGridView1.Rows.Count < 1 Then
                    MsgBox("No hay Registros", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            ElseIf Radfecha.Checked = True Then
                If Datedel.Value > Dateal.Value Then
                    MsgBox("Error en el Rango de fecha, favor revise", MsgBoxStyle.Exclamation)

                    Exit Sub
                Else

                    rango_especifico()
                    If DataGridView1.Rows.Count < 1 Then

                        MsgBox("No hay Registros", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                End If
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Raddia_Click(sender As Object, e As EventArgs) Handles Raddia.Click
        Datedel.Enabled = False
        Dateal.Enabled = False


    End Sub



    Private Sub Radfecha_Click(sender As Object, e As EventArgs) Handles Radfecha.Click
        Datedel.Enabled = True
        Dateal.Enabled = True


    End Sub

    Private Sub Radfecha_CheckedChanged(sender As Object, e As EventArgs) Handles Radfecha.CheckedChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Info_Ventas_realiadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Raddia.PerformClick()
        If Frm_Principal.tipo = "Administrador" Then
            Chktodo.Visible = True
        Else
            Chktodo.Visible = False
        End If
    End Sub

    Private Sub Btnimprimir_Click(sender As Object, e As EventArgs) Handles Btnimprimir.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("No hay Registros en la Tabla", MsgBoxStyle.Exclamation)
            Exit Sub
        Else

            Dim t As New DataTable
            Dim cr As New ventas_realziadas
            cr.SetDataSource(DataGridView1.DataSource)

            Dim rr As New Rpt_contado

            rr.CrystalReportViewer1.ReportSource = cr
            rr.ShowDialog()
        End If
    End Sub

    Private Sub Chktodo_CheckedChanged(sender As Object, e As EventArgs) Handles Chktodo.CheckedChanged
        If Raddia.Checked = True And Chktodo.Checked = True Then
            dia()
        ElseIf Radfecha.Checked = True And Chktodo.Checked = True Then
            rango()
        Else
            Btnver.PerformClick()
        End If

    End Sub

    Private Sub Info_Ventas_realiadas_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class