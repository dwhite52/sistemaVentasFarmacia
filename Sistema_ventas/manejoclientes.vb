Imports System.Data
Imports MySql.Data.MySqlClient
Public Class manejoclientes
    Dim dt1 As New DataTable 'Tabla direccion de clientes'
    Dim dt2 As New DataTable 'Tabla telefono de clientes'
    Public dt As New DataTable 'Tabla clientes'
    Dim cmd As MySqlCommand 'Comando para ejecutar las consultas'
    Public Sub cargar_datos_clientes()
        Dim da As New MySqlDataAdapter
        Try
            conex.Open()
            Dim sql As String = "SELECT Cod_Clientes as Codigo, Nombre, Apellido, Cedula, estado FROM sist_ventas.clientes;"
            cmd = New MySqlCommand(sql, conex)
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
            da.Update(dt)
            conex.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cargar_datos_clientes_dir()
        dt1.Reset()
        Dim da As New MySqlDataAdapter
        Try
            Dim ds1 As New DataSet
            Dim bs1 As New BindingSource
            Dim da1 As New MySqlDataAdapter
            conex.Open()
            Dim sql As String = "SELECT cod_dir_cliente,direccion , tipo FROM sist_ventas.detalle_dir_cliente where detalle_dir_cliente.cod_dir_cliente= '" + DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value + "' ;"
            cmd = New MySqlCommand(sql, conex)
            da1.SelectCommand = cmd
            da1.Fill(dt1)
            conex.Close()
            da1.Update(dt1)
            If dt1.Rows.Count = 1 Then
                Txtdir1.Enabled = True
                Txtdir1.Text = dt1.Rows(0)(1)
                Txtdir2.Clear()
                Txtdir2.Enabled = False
            ElseIf dt1.Rows.Count = 2 Then
                da1.Update(dt1)
                Txtdir1.Enabled = True
                Txtdir2.Enabled = True
                Txtdir1.Text = dt1.Rows(0)(1)
                Txtdir2.Text = dt1.Rows(1)(1)
            Else
                Txtdir1.Enabled = False
                Txtdir2.Enabled = False
                Txtdir1.Clear()
                Txtdir2.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cargar_datos_clientes_tel()
        dt2.Reset()
        Try
            Dim ds2 As New DataSet
            Dim bs2 As New BindingSource
            Dim da2 As New MySqlDataAdapter
            conex.Open()
            Dim sql As String = "SELECT cod_tel_cliente ,telefono , tipo  FROM sist_ventas.detalle_telefono_cliente where detalle_telefono_cliente.cod_tel_cliente= '" + DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value + "';"
            cmd = New MySqlCommand(sql, conex)
            da2.SelectCommand = cmd
            da2.Fill(dt2)
            conex.Close()
            da2.Update(dt2)
            If dt2.Rows.Count = 1 Then
                Txttel1.Enabled = True
                Txttel1.Text = dt2.Rows(0)(1)
                Txttel2.Clear()
                Txttel2.Enabled = False
            ElseIf dt2.Rows.Count = 2 Then
                da2.Update(dt2)
                Txttel1.Enabled = True
                Txttel2.Enabled = True
                Txttel1.Text = dt2.Rows(0)(1)
                Txttel2.Text = dt2.Rows(1)(1)
            Else
                Txttel1.Enabled = False
                Txttel2.Enabled = False
                Txttel1.Clear()
                Txttel2.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub manejoclientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub manejoclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datos_clientes()
        'se asigna el tamaño de las columnas del datagridview'
        With DataGridView1
            .Columns(0).Width = 140
            .Columns(1).Width = 161
            .Columns(2).Width = 161
            .Columns(3).Width = 161
            .Columns(4).Width = 161
        End With
    End Sub
    Private Sub txtnomb_TextChanged(sender As Object, e As EventArgs) Handles txtbnomb.TextChanged
        ' filtramos el Nombre valor en el textbox'
        Dim dv As New DataView(dt)
        dv.RowFilter = String.Format("Nombre like '%{0}%'", txtbnomb.Text)
        DataGridView1.DataSource = dv

        If DataGridView1.Rows.Count > 0 And Not txtbnomb.Text = "" Then
            txtbnomb.BackColor = Color.LimeGreen
        ElseIf DataGridView1.Rows.Count < 1 Then
            txtbnomb.BackColor = Color.Tomato
            Txtdir1.Clear()
            Txtdir2.Clear()
            Txttel1.Clear()
            Txttel2.Clear()
        ElseIf txtbnomb.Text = "" Then
            txtbnomb.BackColor = Color.White

        End If
    End Sub
    Private Sub Ckcodigo_Click(sender As Object, e As EventArgs) Handles Ckcodigo.Click
        Txtbclave.Visible = True
        Txtbclave.Clear()
        Cknomb.Checked = False
        txtbnomb.Visible = False
    End Sub
    ' filtramos el Nombre valor en el textbox'
    Private Sub Txtbclave_TextChanged(sender As Object, e As EventArgs) Handles Txtbclave.TextChanged
        Dim dv As New DataView(dt)
        dv.RowFilter = String.Format("Codigo like '%{0}%'", Txtbclave.Text)
        DataGridView1.DataSource = dv
        If DataGridView1.Rows.Count > 0 And Not Txtbclave.Text = "" Then
            Txtbclave.BackColor = Color.LimeGreen
        ElseIf DataGridView1.Rows.Count < 1 Then
            Txtbclave.BackColor = Color.Tomato
            Txtdir1.Clear()
            Txtdir2.Clear()
            Txttel1.Clear()
            Txttel2.Clear()
        ElseIf Txtbclave.Text = "" Then
            Txtbclave.BackColor = Color.White

        End If

    End Sub
    Private Sub Cknomb_Click(sender As Object, e As EventArgs) Handles Cknomb.Click
        Ckcodigo.Checked = False
        Txtbclave.Visible = False
        txtbnomb.Visible = True
        txtbnomb.Clear()
    End Sub
    Private Sub btnmodificar_seleccion_Click(sender As Object, e As EventArgs) Handles btnmodificar_seleccion.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Me.Opacity -= (Me.Opacity * 0.99)
            Dim ec As New editarclientes
            ec.ShowDialog()
            'editarclientes.ShowDialog()
        End If
    End Sub

    Private Sub btnQuitar_seleccion_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Me.Txtbclave.Clear()
        Me.txtbnomb.Clear()
        Me.dt.Rows.Clear()
        Me.dt1.Rows.Clear()
        Me.dt2.Rows.Clear()
        Me.cargar_datos_clientes()
        Me.cargar_datos_clientes_dir()
        Me.cargar_datos_clientes_tel()
        Me.Update()
        With DataGridView1
            .Columns(0).Width = 140
            .Columns(1).Width = 161
            .Columns(2).Width = 161
            .Columns(3).Width = 161
            .Columns(4).Width = 161
        End With
        MsgBox("Datos Actualizado", MsgBoxStyle.Information)

    End Sub
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        cargar_datos_clientes_dir()
        cargar_datos_clientes_tel()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else

            Dim msg As Integer = MessageBox.Show("Deseas Eliminar el Registro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = DialogResult.Yes Then
                Dim ELIMINAR As String = " DELETE FROM `sist_ventas`.`clientes` WHERE `cod_clientes`='" + DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
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

    Private Sub manejoclientes_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class