Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Prod_defectuoso
    Dim dt As New DataTable
    Function validar_vaciobtnagregar()

        If txtcantidad.Text = "" Or txtestado.Text = "" Then
            MsgBox("Porfavor llene los campos", vbCritical, "Error")
            validar_vaciobtnagregar = True
            Exit Function
        Else
            validar_vaciobtnagregar = False
        End If
    End Function
    Private Sub cargar_producto()
        dt.Reset() 'vaciamos la tabla si contiene datos
        Dim sql As String = "SELECT idprod,Descripcion,existencia FROM sist_ventas.productos where idprod='" + Admin_prod.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';" 'hacemos la consulta a la base de datos
        Try
            Dim da As New MySqlDataAdapter(sql, conex) ' abrimos conexion y ejecutamos la consulta 
            da.SelectCommand.CommandType = CommandType.Text 'captura los datos producidos de la consulta
            da.Fill(dt) 'llenamos la tabla
            conex.Close() 'cerramos la conexion
            txtcodigo.Text = dt.Rows(0)(0) 'pasa el valor de la primera fila, segunda columna de la tabla al textbox nombre
            txtdescrp.Text = dt.Rows(0)(1) 'pasa el valor de la primera fila, tercera columna de la tabla al textbox apellido

        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub

    Private Sub Prod_defectuoso_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Prod_defectuoso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Admin_prod.Txtfiltrar.Clear()
        Admin_prod.dt.Rows.Clear()
        Admin_prod.cargar_datos_producto()
        Admin_prod.Update()
    End Sub

    Private Sub Prod_defectuoso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_producto()
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        If validar_vaciobtnagregar() = True Then
            Exit Sub
        End If
        If dt.Rows(0)(2) < txtcantidad.Text Then
            MsgBox("No se puede realizar, cantidad mayor que existencia", vbCritical, "Error")
            Exit Sub
        End If

        Dim ingresar_defectuoso As String = "INSERT INTO `sist_ventas`.`estado_producto` (`id_producto`, `estado`, `cantidad`) VALUES ('" & txtcodigo.Text & "', '" & txtestado.Text & "', '" & txtcantidad.Text & "');"
        Dim restar_existencia As String = "UPDATE `sist_ventas`.`productos` SET `existencia`=`existencia`-'" + txtcantidad.Text + "' WHERE `idprod`='" & txtcodigo.Text & "';"

        Try
            consultas.funcion(restar_existencia)
            If consultas.funcion(ingresar_defectuoso) = True Then
                MsgBox("Se ha deducido '" + txtcantidad.Text + "' '" + txtdescrp.Text + "' de inventario exitosamente", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        Me.Close()
    End Sub
    Private Sub Prod_defectuoso_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
 

    End Sub

    Private Sub txtestado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtestado.KeyPress
        Letras(e, txtestado)
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        e.Handled = validar_solo_Numeros(e, txtcantidad)
    End Sub
End Class