Imports System.Data
Imports MySql.Data.MySqlClient

Public Class Registro_prod
    Dim dt As New DataTable
    Function validar_vacio_cont()

        If txtcantidad.Text = "" Or txtcodprod.Text = "" Or txtdescprod.Text = "" Or txtprecioventa.Text = "" Or cmbclasificacion.Text = "" Then
            MsgBox("Por favor llene todos los campos necesarios", vbInformation)
            validar_vacio_cont = True
            Exit Function

        Else
            validar_vacio_cont = False
        End If
    End Function
    Function cargar_prod()
        tabla.Reset()
        Dim sql As String = "SELECT Descripcion,precio_de_venta_unit,clasificacion,precio_de_compra,fecha_expiracion FROM sist_ventas.productos where idprod='" + txtcodprod.Text + "'; "
        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        If tabla.Rows.Count = 1 Then
            txtdescprod.Text = tabla.Rows(0)(0).ToString()
            txtprecioventa.Text = tabla.Rows(0)(1).ToString()
            cmbclasificacion.Text = tabla.Rows(0)(2).ToString()
            txtcosto.Text = tabla.Rows(0)(3).ToString()
            dtpf_exp.Text = tabla.Rows(0)(4).ToString()
            cargar_prod = True
        Else
            cargar_prod = False
            txtdescprod.Clear()
            txtprecioventa.Clear()
            cmbclasificacion.Text = Nothing
            txtcosto.Clear()
            txtcantidad.Clear()

        End If
    End Function
    Public Sub boton()
        If DataGridView1.RowCount < 1 Then
            btnmodificar_seleccion.Enabled = False
            btnQuitar_seleccion.Enabled = False
        Else
            btnmodificar_seleccion.Enabled = True
            btnQuitar_seleccion.Enabled = True
        End If
    End Sub


    Private Sub Registro_prod_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
     
        If DataGridView1.RowCount > 0 Then
            If txtNumFactProv.Text = "" Or TxtIdProv.Text = "" Then
                MsgBox("Por Ingrese los datos del proveedor", MessageBoxIcon.Warning, "N.factura Vacio")
                e.Cancel = True
                Exit Sub
            Else

                Dim Guardar_fact As String = "INSERT INTO `sist_ventas`.`prod_nuevo` (`Num_fact_prov`, `Fecha_ingreso`, `Provveedor_cod_proveedor`) VALUES ('" & txtNumFactProv.Text & "', '" & DateFIngreso.Value.ToString("yyyy-M-d") & "', '" & TxtIdProv.Text & "');"

                Try
                    consultas.funcion(Guardar_fact)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try


                Try

                    For i = 0 To DataGridView1.Rows.Count - 1
                        Dim ingresar_detalle_prod As String = "INSERT INTO `sist_ventas`.`detalle_prod` (`Prod_nuevo_Num_fact`, `Inventario_idprod`, `cantidad`, `Precio_nuevo`) VALUES ('" & txtNumFactProv.Text & "', '" & DataGridView1.Rows(i).Cells(0).Value & "', '" & DataGridView1.Rows(i).Cells(2).Value & "', '" & DataGridView1.Rows(i).Cells(4).Value & "');"

                        consultas.funcion(ingresar_detalle_prod)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
        End If
        Me.Dispose()
        Frm_Principal.Show()
    End Sub

    Private Sub Registro_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boton()


    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        Dim bp As New Buscarprov
        bp.ShowDialog()
        'Buscarprov.ShowDialog()


    End Sub

    Private Sub txtcodprod_TextChanged(sender As Object, e As EventArgs) Handles txtcodprod.TextChanged
        cargar_prod()
    End Sub

    Private Sub btnagregarr_Click(sender As Object, e As EventArgs) Handles btnagregarr.Click, btnagregarr.Enter

        Try
            If validar_vacio_cont() = True Then
                Exit Sub
            End If
            If txtcantidad.Text = "" Then

                MsgBox("No se esta ingresando Ninguna Cantidad de Este Producto", MessageBoxIcon.Stop, "Cantidad Vacio")
                Exit Sub
            ElseIf txtcantidad.Text = 0 Then
                MsgBox("No se puede Ingresar esa Cantidad", MessageBoxIcon.Stop, "Cantidad Zero")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Fatal")
        End Try
        For a = 0 To DataGridView1.Rows.Count - 1
            If txtcodprod.Text = DataGridView1.Rows(a).Cells(0).Value Then
                MsgBox("Producto Duplicado, Porfavor Edita", MsgBoxStyle.Exclamation)

                Exit Sub
            End If
        Next
        If tabla.Rows.Count = 1 Then
            Dim actualizar As String = "UPDATE `sist_ventas`.`productos` SET `Descripcion`='" & txtdescprod.Text & "', `clasificacion`='" & cmbclasificacion.Text & "', `fecha_expiracion`='" & dtpf_exp.Value.ToString("yyyy-M-d") & "', `precio_de_compra`='" & txtcosto.Text & "', `precio_de_venta_unit`='" & txtprecioventa.Text & "',`existencia`=`existencia`+'" & txtcantidad.Text & "' WHERE `idprod`='" + txtcodprod.Text + "';"

            Try
                If consultas.funcion(actualizar) = True Then

                    MsgBox("Se agrego (" + txtcantidad.Text + " " + txtdescprod.Text + ") a Inventario", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try

        Else
            Dim ingresar As String = "INSERT INTO `sist_ventas`.`productos` (`idprod`, `Descripcion`, `clasificacion`, `fecha_expiracion`, `precio_de_compra`, `precio_de_venta_unit`,`existencia`) VALUES ('" & txtcodprod.Text & "', '" & txtdescprod.Text & "', '" & cmbclasificacion.Text & "', '" & dtpf_exp.Value.ToString("yyyy-M-d") & "', '" & txtcosto.Text & "', '" & txtprecioventa.Text & "','" & txtcantidad.Text & "');"

            Try
                If consultas.funcion(ingresar) = True Then

                    MsgBox("Se Ingreso un Nuevo Producto al Invetario", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If

        DataGridView1.Rows.Add()
        Dim fila As Integer = DataGridView1.RowCount - 1
        'pasa el valor nuevo de los Texbox a las filas del datagridview
        DataGridView1.Rows(fila).Cells(0).Value = txtcodprod.Text
        DataGridView1.Rows(fila).Cells(1).Value = txtdescprod.Text
        DataGridView1.Rows(fila).Cells(2).Value = txtcantidad.Text
        DataGridView1.Rows(fila).Cells(3).Value = txtcosto.Text
        DataGridView1.Rows(fila).Cells(4).Value = txtprecioventa.Text
        DataGridView1.Rows(fila).Cells(5).Value = cmbclasificacion.Text
        DataGridView1.Rows(fila).Cells(6).Value = dtpf_exp.Value.ToString("yyyy-M-d")

        txtcodprod.Clear()

        txtcodprod.Focus()
        boton()
    End Sub

    Private Sub btnmodificar_seleccion_Click(sender As Object, e As EventArgs) Handles btnmodificar_seleccion.Click
        'obtiene el valor correspondiente de cada celda y fila referente al textbox 
        txtcodprod.ReadOnly = True
        btnagregarr.Visible = False
        btngcamb.Visible = True
        btnQuitar_seleccion.Enabled = False
        Dim contar As Integer
        contar = DataGridView1.CurrentRow.Index
        'pasa los valores de la fila seleccionada a cada una de los textbox correspondientes'
        txtcodprod.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        txtdescprod.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
        txtcantidad.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        txtcosto.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
        txtprecioventa.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
        cmbclasificacion.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
        dtpf_exp.Value = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
        Dim actualizar_ext As String = "UPDATE `sist_ventas`.`productos` SET `existencia`=`existencia`-'" & txtcantidad.Text & "' WHERE `idprod`='" + txtcodprod.Text + "';"

        Try
            If consultas.funcion(actualizar_ext) = True Then
                'MsgBox("Datos actualizados Correctamente", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try


    End Sub

    Private Sub btngcamb_Click(sender As Object, e As EventArgs) Handles btngcamb.Click
        Try
            If txtcantidad.Text = "" Then

                MsgBox("No se esta ingresando Ninguna Cantidad de Este Producto", MessageBoxIcon.Stop, "Cantidad Vacio")
                Exit Sub
            ElseIf txtcantidad.Text = 0 Then
                MsgBox("No se puede Ingresar esa Cantidad", MessageBoxIcon.Stop, "Cantidad Zero")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Fatal")
        End Try

        Dim actualizar As String = "UPDATE `sist_ventas`.`productos` SET `Descripcion`='" & txtdescprod.Text & "', `clasificacion`='" & cmbclasificacion.Text & "', `fecha_expiracion`='" & dtpf_exp.Value.ToString("yyyy-M-d") & "', `precio_de_compra`='" & txtcosto.Text & "', `precio_de_venta_unit`='" & txtprecioventa.Text & "',`existencia`=`existencia`+'" & txtcantidad.Text & "' WHERE `idprod`='" + txtcodprod.Text + "';"

        Try
            If consultas.funcion(actualizar) = True Then
                MsgBox("Datos Modificado Correctamente", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        Dim fila As Integer
        DataGridView1.Rows(fila).Cells(0).Value = txtcodprod.Text
        DataGridView1.Rows(fila).Cells(1).Value = txtdescprod.Text
        DataGridView1.Rows(fila).Cells(2).Value = txtcantidad.Text
        DataGridView1.Rows(fila).Cells(3).Value = txtcosto.Text
        DataGridView1.Rows(fila).Cells(4).Value = txtprecioventa.Text
        DataGridView1.Rows(fila).Cells(5).Value = cmbclasificacion.Text
        DataGridView1.Rows(fila).Cells(6).Value = dtpf_exp.Value.ToString("yyyy-M-d")
        txtcodprod.ReadOnly = False
        btnagregarr.Visible = True
        btngcamb.Visible = False
        btnQuitar_seleccion.Enabled = True
        txtcodprod.Clear()

        txtcodprod.Focus()
    End Sub

    Private Sub btnQuitar_seleccion_Click(sender As Object, e As EventArgs) Handles btnQuitar_seleccion.Click
        lblext.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
        lblgcod.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
        lblfecha_expiracio.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value
        Dim msg As Integer = MessageBox.Show("Deseas eliminar seleccion?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'el sistema pregunta al usuario'
        'espera la respuesta y ejecuta una opcion
        If msg = DialogResult.Yes Then
            'elimina la seleccion'
            Dim actualizar_ext As String = "UPDATE `sist_ventas`.`productos` SET `existencia`=`existencia`-'" + lblext.Text + "',fecha_expiracion='" + lblfecha_expiracio.Text + "' WHERE `idprod`='" + lblgcod.Text + "';"

            Try
                If consultas.funcion(actualizar_ext) = True Then
                    MsgBox("Registro eliminado", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            boton()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        G_codigo_barras.ShowDialog()

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbclasificacion.KeyPress
        e.Handled = True
    End Sub

    Private Sub Registro_prod_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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



        Dim msg As Integer = MessageBox.Show("Deseas Cancelar el Registro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            For a = 0 To DataGridView1.Rows.Count - 1
                Try
                    Dim actualizar_cancelo As String = "UPDATE `sist_ventas`.`productos` SET `existencia`=`existencia`-'" + DataGridView1.Rows(a).Cells(2).Value + "' WHERE `idprod`='" + DataGridView1.Rows(a).Cells(0).Value + "';"


                    If consultas.funcion(actualizar_cancelo) = True Then

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")

                End Try

            Next
            DataGridView1.Rows.Clear()
            boton()
        End If
    End Sub


   
    Private Sub txtNumFactProv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumFactProv.KeyPress
        'e.Handled = validar_solo_Numeros(e, txtNumFactProv)
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        e.Handled = validar_solo_Numeros(e, txtcantidad)
    End Sub

    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcosto.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txtcosto)
    End Sub

    Private Sub txtprecioventa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecioventa.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txtprecioventa)
    End Sub

    Private Sub txtdescprod_TextChanged(sender As Object, e As EventArgs) Handles txtdescprod.TextChanged

    End Sub

    Private Sub TxtIdProv_TextChanged(sender As Object, e As EventArgs) Handles TxtIdProv.TextChanged

    End Sub

    Private Sub txtNumFactProv_TextChanged(sender As Object, e As EventArgs) Handles txtNumFactProv.TextChanged

    End Sub
End Class