Imports System.Data
Imports MySql.Data.MySqlClient
Public Class informe_pagos
    Dim dtsaldop As DataTable
    Public Sub cargar_pago()

        Dim da As New MySqlDataAdapter

        Dim cmd As MySqlCommand

        Try
            tabla.Reset()

            Dim sql As String = "SELECT abono.idabono as N°pago,abono.cuentas_x_cobrar_num_de_credito as N°Factura,abono.fecha_pago,cuentas_x_cobrar.saldo_pendiente,abono.cantidad as Monto_de_pago,clientes.Nombre,clientes.Apellido,abono.vendedor FROM sist_ventas.abono inner join cuentas_X_cobrar on abono.cuentas_x_cobrar_num_de_credito=cuentas_X_cobrar.num_de_credito inner join clientes on cuentas_X_cobrar.Clientes_Cod_Clientes= clientes.Cod_Clientes where abono.cuentas_x_cobrar_num_de_credito='" + Txtfiltrar.Text + "';"
            cmd = New MySqlCommand(sql, conex)
            tabla = New DataTable
            da.SelectCommand = cmd
            da.Fill(tabla)
            If tabla.Rows.Count < 1 Then
                MsgBox("No se encontraron pagos con ese Numero", MsgBoxStyle.Exclamation)
                lblsaldop.Text = ""
            Else

                lblsaldop.Text = tabla.Rows(0)(3).ToString
                DataGridView1.DataSource = tabla
                With DataGridView1
                    .Columns(0).Width = 130
                    .Columns(1).Width = 130
                    .Columns(2).Width = 150
                    .Columns(3).Visible = False
                    .Columns(4).Width = 150
                    .Columns(5).Width = 150
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub informe_pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtfiltrar.Focus()
    End Sub

    Private Sub informe_pagos_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        cargar_pago()
    End Sub
End Class