Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Admin_prod
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable
    Public dt As New DataTable
    Dim cmd As MySqlCommand
    Dim da As New MySqlDataAdapter
    Public Sub cargar_datos_producto()


        Try
            conex.Open()
            Dim sql As String = "SELECT idprod as Codigo, Descripcion, clasificacion as Clasificacion, fecha_expiracion as Fecha_Expiracion,precio_de_compra as Costo,precio_de_venta_unit as Precio_Venta,existencia as Existencia FROM sist_ventas.productos;"
            cmd = New MySqlCommand(sql, conex)
            da.SelectCommand = cmd

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
            conex.Close()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Admin_prod_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Avisoprodexpirar.TxtIdProv.Text = DataGridView1.CurrentRow.Cells(0).Value

        Me.Dispose()
    End Sub

    Private Sub Admin_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


    Private Sub btnmodificar_seleccion_Click(sender As Object, e As EventArgs) Handles btnmodificar_seleccion.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else

            'manejoinventario.ShowDialog()
            Me.Opacity -= (Me.Opacity * 0.99)
            Dim mi As New manejoinventario
            mi.ShowDialog()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Dim msg As Integer = MessageBox.Show("Deseas Eliminar el Registro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = DialogResult.Yes Then
                Dim ELIMINAR As String = " DELETE FROM `sist_ventas`.`productos` WHERE `idprod`='" + DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
                Try
                    If consultas.funcion(ELIMINAR) = True Then
                        MsgBox("Registro Eliminado", MsgBoxStyle.Information)
                        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
        End If
    End Sub


    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Me.Txtfiltrar.Clear()
        Me.dt.Rows.Clear()
        Me.cargar_datos_producto()
        Me.Update()
        With DataGridView1
            .Columns(0).Width = 200
            .Columns(1).Width = 190
            .Columns(2).Width = 170
            .Columns(3).Width = 150
            .Columns(4).Width = 150
            .Columns(5).Width = 150
            .Columns(6).Width = 150

        End With
        MsgBox("Datos Actualizado", MsgBoxStyle.Information)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            'Prod_defectuoso.ShowDialog()
            Dim pd As New Prod_defectuoso
            pd.ShowDialog()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Dim dp As New Detalle_prov
            dp.ShowDialog()
        End If
    End Sub

    Private Sub Cmbfiltrar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmbfiltrar.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cmbfiltrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbfiltrar.SelectedIndexChanged
        Txtfiltrar.Clear()
        Txtfiltrar.Focus()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Admin_prod_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Dim cr As New Inventario
            cr.SetDataSource(DataGridView1.DataSource)
            Dim rr As New Rpt_contado
            rr.CrystalReportViewer1.ReportSource = cr
            rr.ShowDialog()
        End If
    End Sub
End Class