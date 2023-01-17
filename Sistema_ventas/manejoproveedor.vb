Imports System.Data
Imports MySql.Data.MySqlClient
Public Class manejoproveedor
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable
    Public dt As New DataTable
    Dim cmd As MySqlCommand
    Public Sub cargar_datos_proveedor()
        Dim da As New MySqlDataAdapter
        Try
            conex.Open()
            Dim sql As String = "SELECT cod_proveedor as Codigo,nombres,apellidos,nombre_comercial as Nombre_Comercial FROM sist_ventas.proveedor;"
            cmd = New MySqlCommand(sql, conex)
            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt
            da.Update(dt)
            conex.Close()

        Catch ex As Exception
        End Try
    End Sub
    Private Sub cargar_datos_prov_dir()
        dt1.Reset()
        Dim da As New MySqlDataAdapter
        Try
            Dim bs1 As New BindingSource
            Dim da1 As New MySqlDataAdapter
            conex.Open()
            Dim sql As String = "SELECT cod_dir_prov,direccion,tipo FROM sist_ventas.detalle_dir_prov where cod_dir_prov='" + DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString + "' ;"
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
    Private Sub cargar_datos_prov_telefono()
        dt2.Reset()
        Try
            Dim ds2 As New DataSet
            Dim bs2 As New BindingSource
            Dim da2 As New MySqlDataAdapter
            conex.Open()
            Dim sql As String = "SELECT cod_telefono_prov ,telefono , tipo  FROM sist_ventas.detalle_telefono_prov where detalle_telefono_prov.cod_telefono_prov='" + DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value + "';"
            cmd = New MySqlCommand(sql, conex)
            da2.SelectCommand = cmd
            da2.Fill(dt2)
            conex.Close()
            da2.Update(dt2)
            If dt2.Rows.Count = 1 Then
                Txttel1.Text = dt2.Rows(0)(1)
                Txttel2.Clear()
            ElseIf dt2.Rows.Count = 2 Then
                da2.Update(dt2)
                Txttel1.Text = dt2.Rows(0)(1)
                Txttel2.Text = dt2.Rows(1)(1)
            Else
                Txttel1.Clear()
                Txttel2.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cargar_datos_prov_correo()
        dt3.Reset()
        Try
            Dim ds2 As New DataSet
            Dim bs2 As New BindingSource
            Dim da3 As New MySqlDataAdapter
            conex.Open()
            Dim sql As String = "SELECT cod_email_prov ,email , tipo  FROM sist_ventas.detalle_email_prov where detalle_email_prov.cod_email_prov= '" + DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value + "';"
            cmd = New MySqlCommand(sql, conex)
            da3.SelectCommand = cmd
            da3.Fill(dt3)
            conex.Close()
            da3.Update(dt3)
            If dt3.Rows.Count = 1 Then
                txtcor1.Text = dt3.Rows(0)(1)
                txtcor2.Clear()
            ElseIf dt3.Rows.Count = 2 Then
                da3.Update(dt2)
                txtcor1.Text = dt3.Rows(0)(1)
                txtcor2.Text = dt3.Rows(1)(1)
            Else
                txtcor1.Clear()
                txtcor2.Clear()
                Exit Sub
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub manejoproveedor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
 

    Private Sub manejoproveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datos_proveedor()
        With DataGridView1
            .Columns(0).Width = 200
            .Columns(1).Width = 190
            .Columns(2).Width = 190
            .Columns(3).Width = 190
        End With
    End Sub
    Private Sub txtbnomb_TextChanged(sender As Object, e As EventArgs) Handles txtbnomb.TextChanged
        Dim dv As New DataView(dt)
        dv.RowFilter = String.Format("Nombres like '%{0}%'", txtbnomb.Text)
        DataGridView1.DataSource = dv
        If DataGridView1.Rows.Count > 0 And Not txtbnomb.Text = "" Then
            txtbnomb.BackColor = Color.LimeGreen
        ElseIf DataGridView1.Rows.Count < 1 Then
            txtbnomb.BackColor = Color.Tomato
            txtcor1.Clear()
            txtcor2.Clear()
            Txtdir1.Clear()
            Txtdir2.Clear()
            Txttel1.Clear()
            Txttel2.Clear()
        ElseIf txtbnomb.Text = "" Then
            txtbnomb.BackColor = Color.White
            
        End If

       


    End Sub

    Private Sub Txtbclave_TextChanged(sender As Object, e As EventArgs) Handles Txtbclave.TextChanged
        Dim dv As New DataView(dt)
        dv.RowFilter = String.Format("Codigo like '%{0}%'", Txtbclave.Text)
        DataGridView1.DataSource = dv
        If DataGridView1.Rows.Count > 0 And Not Txtbclave.Text = "" Then
            Txtbclave.BackColor = Color.LimeGreen
        ElseIf DataGridView1.Rows.Count < 1 Then
            Txtbclave.BackColor = Color.Tomato
            txtcor1.Clear()
            txtcor2.Clear()
            Txtdir1.Clear()
            Txtdir2.Clear()
            Txttel1.Clear()
            Txttel2.Clear()
        ElseIf Txtbclave.Text = "" Then
            Txtbclave.BackColor = Color.White
           
        End If

       

    End Sub

    Private Sub Ckcodigo_Click(sender As Object, e As EventArgs) Handles Ckcodigo.Click
        Txtbclave.Visible = True
        Txtbclave.Clear()
        Cknomb.Checked = False
        txtbnomb.Visible = False
    End Sub

    Private Sub Cknomb_Click(sender As Object, e As EventArgs) Handles Cknomb.Click
        Ckcodigo.Checked = False
        Txtbclave.Visible = False
        txtbnomb.Visible = True
        txtbnomb.Clear()
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        cargar_datos_prov_dir()
        cargar_datos_prov_telefono()
        cargar_datos_prov_correo()
    End Sub

    Private Sub btnmodificar_seleccion_Click_1(sender As Object, e As EventArgs) Handles btnmodificar_seleccion.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Me.Opacity -= (Me.Opacity * 0.99)
            Dim ep As New editarproveedor
            ep.ShowDialog()
        End If
    End Sub


    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Dim msg As Integer = MessageBox.Show("Deseas Eliminar el Registro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = DialogResult.Yes Then
                Dim ELIMINAR As String = " DELETE FROM `sist_ventas`.`proveedor` WHERE `cod_proveedor`='" + DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
                Try
                    If consultas.funcion(ELIMINAR) = True Then
                        MsgBox("Registro Eliminado ", MsgBoxStyle.Information)
                        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Me.Txtbclave.Clear()
        Me.txtbnomb.Clear()
        Me.dt.Rows.Clear()
        Me.dt1.Rows.Clear()
        Me.dt2.Rows.Clear()
        Me.dt3.Rows.Clear()
        Me.cargar_datos_proveedor()
        Me.cargar_datos_prov_correo()
        Me.cargar_datos_prov_dir()
        Me.cargar_datos_prov_telefono()
        Me.Update()
        With DataGridView1
            .Columns(0).Width = 200
            .Columns(1).Width = 190
            .Columns(2).Width = 190
            .Columns(3).Width = 190
        End With
        MsgBox("Datos Actualizado", MsgBoxStyle.Information)
    End Sub

    Private Sub manejoproveedor_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

  
End Class