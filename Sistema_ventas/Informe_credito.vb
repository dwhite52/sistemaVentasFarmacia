Imports System.Data
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Informe_credito
    Dim dt As DataTable
    Dim dt1 As DataTable
    Public Sub rango()
        Dim sql As String = "SELECT credito.Num_Boleta_cred as Nª_Factura,credito.vendedor,credito.fecha,credito.subtotal,credito.iva,credito.total,cuentas_x_cobrar.Clientes_Cod_Clientes as Codigo_Cliente,clientes.nombre as Nombre,cuentas_x_cobrar.fecha_de_vencimiento FROM credito inner join cuentas_x_cobrar on credito.Num_Boleta_cred= cuentas_x_cobrar.Credito_Num_Boleta_cred inner join clientes on clientes.Cod_Clientes=cuentas_x_cobrar.Clientes_Cod_Clientes where Credito.fecha between '" + Datedel.Value.ToString("yyyy-M-d") + "' and '" + Dateal.Value.ToString("yyyy-M-d") + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt = New DataTable()
            da.Fill(dt)
            DataGridView1.DataSource = dt
            With DataGridView1
                .Columns(6).Width = 170
                .Columns(8).Width = 200
            End With
            Dim suma As Double
            For i = 0 To DataGridView1.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGridView1.Rows(i).Cells(5).Value)
            Next
            Lbltot.Text = suma.ToString

        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try

    End Sub
    Public Sub rango_especifico()
        tabla1.Reset()
        Dim sql As String = "SELECT credito.Num_Boleta_cred as Nª_Factura,credito.vendedor,credito.fecha,credito.subtotal,credito.iva,credito.total,cuentas_x_cobrar.Clientes_Cod_Clientes as Codigo_Cliente,clientes.nombre as Nombre,cuentas_x_cobrar.fecha_de_vencimiento FROM credito inner join cuentas_x_cobrar on credito.Num_Boleta_cred= cuentas_x_cobrar.Credito_Num_Boleta_cred inner join clientes on clientes.Cod_Clientes=cuentas_x_cobrar.Clientes_Cod_Clientes where vendedor='" + Login.user + "' and  Credito.fecha between '" + Datedel.Value.ToString("yyyy-M-d") + "' and '" + Dateal.Value.ToString("yyyy-M-d") + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            tabla1 = New DataTable()
            da.Fill(tabla1)
            DataGridView1.DataSource = tabla1
            With DataGridView1
                .Columns(6).Width = 170
                .Columns(8).Width = 200
            End With
            Dim suma As Double
            For i = 0 To DataGridView1.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGridView1.Rows(i).Cells(5).Value)
            Next
            Lbltot.Text = suma.ToString

        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try

    End Sub

    Public Sub dia()
        Dim sql As String = "SELECT credito.Num_Boleta_cred as Nª_Factura,credito.vendedor, credito.fecha,credito.subtotal, credito.iva,credito.total,cuentas_x_cobrar.Clientes_Cod_Clientes as Codigo_Cliente,clientes.nombre as Nombre,cuentas_x_cobrar.fecha_de_vencimiento FROM credito inner join cuentas_x_cobrar on credito.Num_Boleta_cred= cuentas_x_cobrar.Credito_Num_Boleta_cred inner join clientes on clientes.Cod_Clientes=cuentas_x_cobrar.Clientes_Cod_Clientes where Credito.fecha ='" + Date.Now.ToString("yyyy-M-d") + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            da.Fill(dt1)
            DataGridView1.DataSource = dt1
            With DataGridView1
                .Columns(6).Width = 170
                .Columns(8).Width = 200
            End With
            Dim suma As Double
            For i = 0 To DataGridView1.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGridView1.Rows(i).Cells(5).Value)
            Next
            Lbltot.Text = suma.ToString

        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try


    End Sub
    Public Sub dia_especifico()
        Dim sql As String = "SELECT credito.Num_Boleta_cred as Nª_Factura,credito.vendedor, credito.fecha,credito.subtotal, credito.iva,credito.total,cuentas_x_cobrar.Clientes_Cod_Clientes as Codigo_Cliente,clientes.nombre as Nombre,cuentas_x_cobrar.fecha_de_vencimiento FROM credito inner join cuentas_x_cobrar on credito.Num_Boleta_cred= cuentas_x_cobrar.Credito_Num_Boleta_cred inner join clientes on clientes.Cod_Clientes=cuentas_x_cobrar.Clientes_Cod_Clientes where  vendedor='" + Login.user + "'and Credito.fecha ='" + Date.Now.ToString("yyyy-M-d") + "';"
        tabla.Reset()
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            tabla = New DataTable()
            da.Fill(tabla)
            DataGridView1.DataSource = tabla
            With DataGridView1
                .Columns(6).Width = 170
                .Columns(8).Width = 200
            End With
            Dim suma As Double
            For i = 0 To DataGridView1.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGridView1.Rows(i).Cells(5).Value)
            Next
            Lbltot.Text = suma.ToString

        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try


    End Sub
    Private Sub Btnver_Click(sender As Object, e As EventArgs) Handles Btnver.Click
        Try
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


    Private Sub Informe_credito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Principal.tipo = "Administrador" Then
            Chktodo.Visible = True
        Else
            Chktodo.Visible = False
        End If
        Raddia.PerformClick()
    End Sub

    Private Sub Btnimprimir_Click(sender As Object, e As EventArgs) Handles Btnimprimir.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("No hay Registros en la Tabla", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Dim t As New DataTable
            Dim cr As New Credito_realizados
            Dim txt As TextObject

            DataGridView1.DataSource = t
            cr.SetDataSource(t)
            txt = (cr.ReportDefinition.ReportObjects("total"))
            txt.Text = Lbltot.Text
            Dim rr As New Rpt_contado

            rr.CrystalReportViewer1.ReportSource = cr
            rr.ShowDialog()
        End If
    End Sub

    Private Sub Informe_credito_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim rec As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
        '
        'Create a new brush. Make is a Gradient style brush.
        '
        Dim myBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(rec, Color.DarkCyan, _
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

    Private Sub Chktodo_CheckedChanged(sender As Object, e As EventArgs) Handles Chktodo.CheckedChanged
        If Raddia.Checked = True And Chktodo.Checked = True Then
            dia()
        ElseIf Radfecha.Checked = True And Chktodo.Checked = True Then
            rango()
        Else
            Btnver.PerformClick()
        End If

    End Sub

    Private Sub Chktodo_CheckStateChanged(sender As Object, e As EventArgs) Handles Chktodo.CheckStateChanged
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class