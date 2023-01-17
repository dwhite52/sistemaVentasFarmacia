Imports System.Data
Imports MySql.Data.MySqlClient
Public Class manejoinventario
    Public Sub limpiar()
        txtcodprod.Clear()
        txtcosto.Clear()
        txtdescprod.Clear()
        txtprecioventa.Clear()
        cmbclasificacion.Text = Nothing
        dtpf_exp.Value = Date.Now
    End Sub

    Dim dt As New DataTable
    Private Sub cargar_productos()
        dt.Reset() 'vaciamos la tabla si contiene datos
        Dim sql As String = "SELECT idprod,Descripcion,precio_de_compra,clasificacion,precio_de_venta_unit,fecha_expiracion FROM sist_ventas.productos where idprod='" + Admin_prod.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';" 'hacemos la consulta a la base de datos
        Try
            Dim da As New MySqlDataAdapter(sql, conex) ' abrimos conexion y ejecutamos la consulta 
            da.SelectCommand.CommandType = CommandType.Text 'captura los datos producidos de la consulta
            da.Fill(dt) 'llenamos la tabla

            conex.Close() 'cerramos la conexion

            txtcodprod.Text = dt.Rows(0)(0) 'pasa el valor de la primera fila, primer columna
            txtdescprod.Text = dt.Rows(0)(1)
            txtcosto.Text = dt.Rows(0)(2)
            cmbclasificacion.Text = dt.Rows(0)(3)
            txtprecioventa.Text = dt.Rows(0)(4)
            dtpf_exp.Value = dt.Rows(0)(5)

        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub

    Private Sub manejoinventario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Admin_prod.Opacity += (Me.Opacity * 0.99)
    End Sub

    Private Sub manejoinventario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Me.Dispose()
        Admin_prod.Txtfiltrar.Clear()
        Admin_prod.dt.Rows.Clear()
        Admin_prod.cargar_datos_producto()
        Admin_prod.Update()

    End Sub
    Private Sub manejoinventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_productos()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim actualizar As String = "UPDATE `sist_ventas`.`productos` SET `Descripcion`='" & txtdescprod.Text & "', `clasificacion`='" & cmbclasificacion.Text & "', `fecha_expiracion`='" & dtpf_exp.Value.ToString("yyyy-M-d") & "', `precio_de_compra`='" & txtcosto.Text & "', `precio_de_venta_unit`='" & txtprecioventa.Text & "' WHERE `idprod`='" + txtcodprod.Text + "';"

        Try
            If consultas.funcion(actualizar) = True Then
                MsgBox("Datos Guardados ", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub manejoinventario_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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


    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Dim msg As Integer = MessageBox.Show("Deseas Cancelar", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            limpiar()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcosto.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txtcosto)
    End Sub

    Private Sub cmbclasificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbclasificacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtprecioventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioventa.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txtprecioventa)
    End Sub

    Private Sub dtpf_exp_ValueChanged(sender As Object, e As EventArgs) Handles dtpf_exp.ValueChanged

    End Sub
End Class