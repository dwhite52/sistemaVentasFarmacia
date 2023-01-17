Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Busqueda_Factura
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim dt2 As DataTable
    Dim dt3 As DataTable
    Dim cmd As MySqlCommand
    Dim valoractual As Integer
    Dim valordevol As Integer
    Dim resultadofinal As Integer
    Dim suma As Double
    Dim result As Integer

    Dim mult As Double
    Dim cant_mayor As Integer

    Public Sub cargar_datos_Factura_cred()

        Dim da As New MySqlDataAdapter
        Try

            Dim sql As String = "SELECT num_Boleta_cred as codigo,credito.vendedor, credito.fecha,credito.subtotal,cuentas_x_cobrar.Clientes_Cod_Clientes, credito.total, credito.iva, cuentas_x_cobrar.fecha_de_vencimiento,cuentas_x_cobrar.estado FROM detalle_credito INNER JOIN credito ON detalle_credito.Credito_Num_Boleta_cred = credito.Num_Boleta_cred inner join cuentas_x_cobrar on credito.Num_Boleta_cred= cuentas_x_cobrar.Credito_Num_Boleta_cred;"
            cmd = New MySqlCommand(sql, conex)
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)



            Dim sql2 As String = "SELECT  num_Boleta_cred as codigo, detalle_credito.Inventario_idprod as Id_producto, detalle_credito.descripcion as Descripcion, detalle_credito.catidad as Cantidad, detalle_credito.precio, detalle_credito.subtotal as Subtotal_Unit FROM detalle_credito INNER JOIN credito ON detalle_credito.Credito_Num_Boleta_cred = credito.Num_Boleta_cred;"
            cmd = New MySqlCommand(sql2, conex)
            dt3 = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt3)



        Catch ex As Exception
        End Try
    End Sub
    Public Sub cargar_datos_Factura_contd()

        Dim da As New MySqlDataAdapter
        Try

            Dim sql As String = "SELECT ventas.Num_Boleta_contd as codigo,ventas.vendedor, ventas.fecha_venta ,ventas.subtotal1, ventas.Nombre_Cliente_contd, ventas.neto, ventas.iva, ventas.descuento_total, ventas.total FROM detalle_venta INNER JOIN ventas ON detalle_venta.Num_Boleta_contd = ventas.Num_Boleta_contd;"
            cmd = New MySqlCommand(sql, conex)
            dt1 = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt1)
         
           

            Dim caragar_detalles As String = "SELECT ventas.Num_Boleta_contd as codigo, detalle_venta.cod_prod as Id_Producto,detalle_venta.descripcion as Descripcion,detalle_venta.cantidad, detalle_venta.precio, detalle_venta.subtotal_unit FROM detalle_venta INNER JOIN ventas ON detalle_venta.Num_Boleta_contd = ventas.Num_Boleta_contd;"
            cmd = New MySqlCommand(caragar_detalles, conex)
            dt2 = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt2)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub actualizar_devolucion()

        Try
            Dim insertar_devolucion As String = "UPDATE `sist_ventas`.`detalle_venta` SET `cantidad` = '" & resultadofinal & "', `subtotal_unit` = '" & txtsubnuevo.Text & "' WHERE (`cod_prod` = '" & txtcod.Text & "') and (`Num_Boleta_contd` = '" & txtnumfact.Text & "'); "
            If consultas.funcion(insertar_devolucion) = True Then

            End If

            Dim insertar_devolucion_detalle As String = "UPDATE `sist_ventas`.`ventas` SET `subtotal1` = '" & txtsubtot.Text & "', `neto` = '" & txttotal.Text & "' WHERE (`Num_Boleta_contd` = '" & txtnumfact.Text & "');"
            If consultas.funcion(insertar_devolucion_detalle) = True Then
                MsgBox("Devolucion Realizada Correctamente", MsgBoxStyle.Information)
            End If

        Catch ex As Exception

        End Try



    End Sub

    Private Sub Radcontado_CheckedChanged(sender As Object, e As EventArgs) Handles Radcontado.CheckedChanged
        cargar_datos_Factura_contd()
        Lblfecha_limite.Visible = False
        txtfecha_liite.Visible = False
        lbldescuento.Visible = True
        txtdescuento.Visible = True
        lblestado.Visible = False
        txtestado.Visible = False
        lblnomcliente.Text = "Nombre del Cliente"
        Txtfiltrar.Enabled = True
        Txtfiltrar.Clear()
        Txtfiltrar.BackColor = Color.White
    End Sub

    Private Sub Radcontado_Click(sender As Object, e As EventArgs) Handles Radcontado.Click

      
        cargar_datos_Factura_contd()
        Lblfecha_limite.Visible = False
        txtfecha_liite.Visible = False
        lbldescuento.Visible = True
        txtdescuento.Visible = True
        lblestado.Visible = False
        txtestado.Visible = False
        lblnomcliente.Text = "Nombre del Cliente"
        Txtfiltrar.Enabled = True
        Txtfiltrar.Clear()
        Txtfiltrar.BackColor = Color.White
    End Sub

    Private Sub Radcredito_Click(sender As Object, e As EventArgs) Handles Radcredito.Click
        cargar_datos_Factura_cred()
        lbldescuento.Visible = False
        txtdescuento.Visible = False
        Lblfecha_limite.Visible = True
        txtfecha_liite.Visible = True
        lblestado.Visible = True
        txtestado.Visible = True
        lblnomcliente.Text = "Codigo del Cliente"
        Txtfiltrar.Enabled = True
        Txtfiltrar.Clear()
        Txtfiltrar.BackColor = Color.White
    End Sub

    Private Sub Busqueda_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Txtfiltrar.Enabled = False
        Txtfiltrar.Enabled = True
        Txtfiltrar.Focus()
        Lblfecha_limite.Visible = False
        txtfecha_liite.Visible = False
        lblestado.Visible = False
        txtestado.Visible = False
        btnGuardar.Visible = False
    End Sub

    Private Sub Txtfiltrar_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltrar.TextChanged
        If Radcontado.Checked = True Then

            Dim dv As New DataView(dt2)
            dv.RowFilter = "Convert([codigo],System.String) = '" + Txtfiltrar.Text + "'"


            DataGridView1.DataSource = dv
            If DataGridView1.Rows.Count > 0 Then
                Txtfiltrar.BackColor = Color.LimeGreen
            Else
                Txtfiltrar.BackColor = Color.Tomato
            End If

            If Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.White
            End If


            With DataGridView1
                .Columns(0).Visible = False
                .Columns(1).Width = 180
                .Columns(2).Width = 230
                .Columns(5).Width = 165

            End With

            Dim dv1 As New DataView(dt1)
            dv1.RowFilter = "Convert([codigo],System.String) = '" + Txtfiltrar.Text + "'"
            DataGridView2.DataSource = dv1
            If DataGridView2.Rows.Count > 0 Then
                txtnumfact.Text = DataGridView2.Rows(0).Cells(0).Value.ToString
                txtvendedor.Text = DataGridView2.Rows(0).Cells(1).Value.ToString
                txtfecha.Text = CDate(DataGridView2.Rows(0).Cells(2).Value).ToString("dd/MM/yyyy")
                txtsubtot.Text = DataGridView2.Rows(0).Cells(3).Value.ToString
                txtnomclinte.Text = DataGridView2.Rows(0).Cells(4).Value.ToString
                txttotal.Text = DataGridView2.Rows(0).Cells(5).Value.ToString
                txtiva.Text = DataGridView2.Rows(0).Cells(6).Value.ToString
                txtdescuento.Text = DataGridView2.Rows(0).Cells(7).Value.ToString
            Else
                txtnumfact.Clear()
                txtvendedor.Clear()
                txtfecha.Clear()
                txtsubtot.Clear()
                txtnomclinte.Clear()
                txttotal.Clear()
                txtiva.Clear()
                txtdescuento.Clear()
            End If

        End If

        If Radcredito.Checked = True Then

            Dim dv1 As New DataView(dt)
            dv1.RowFilter = "Convert([codigo],System.String) = '" + Txtfiltrar.Text + "'"
            DataGridView2.DataSource = dv1
            If DataGridView2.Rows.Count > 0 Then
                txtnumfact.Text = DataGridView2.Rows(0).Cells(0).Value.ToString
                txtvendedor.Text = DataGridView2.Rows(0).Cells(1).Value.ToString
                txtfecha.Text = DataGridView2.Rows(0).Cells(2).Value.ToString
                txtsubtot.Text = DataGridView2.Rows(0).Cells(3).Value.ToString
                txtnomclinte.Text = DataGridView2.Rows(0).Cells(4).Value.ToString
                txttotal.Text = DataGridView2.Rows(0).Cells(5).Value.ToString
                txtiva.Text = DataGridView2.Rows(0).Cells(6).Value.ToString
                txtfecha_liite.Text = DataGridView2.Rows(0).Cells(7).Value.ToString
                txtestado.Text = DataGridView2.Rows(0).Cells(8).Value.ToString
            Else
                txtnumfact.Clear()
                txtvendedor.Clear()
                txtfecha.Clear()
                txtsubtot.Clear()
                txtnomclinte.Clear()
                txttotal.Clear()
                txtiva.Clear()
                txtfecha_liite.Clear()
                txtestado.Clear()
            End If

            Dim dv2 As New DataView(dt3)
            dv2.RowFilter = "Convert([codigo],System.String) = '" + Txtfiltrar.Text + "'"
            DataGridView1.DataSource = dv2
            If DataGridView1.Rows.Count > 0 Then
                Txtfiltrar.BackColor = Color.LimeGreen
            ElseIf Txtfiltrar.Text = "" Then
                Txtfiltrar.BackColor = Color.White
            ElseIf DataGridView1.Rows.Count < 1 Then
                Txtfiltrar.BackColor = Color.Tomato
            End If

       


            With DataGridView1
                .Columns(0).Visible = False
                .Columns(1).Width = 180
                .Columns(2).Width = 230
                .Columns(5).Width = 165

            End With

        End If
    End Sub

    Private Sub Busqueda_Factura_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        If (e.Button = MouseButtons.Right) Then
            If DataGridView1.Rows.Count > 0 Then
                DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
                DEVOLUCION.ShowDropDown()

                'ContextMenuStrip1.Items.Add("Devolucion").Name = "DEVOLUCION"
                'ContextMenuStrip1.Items.Add("Eliminar").Name = "ELIMINAR"

            Else
                DEVOLUCION.HideDropDown()
                MsgBox("No hay Datos", vbExclamation)
            End If


        End If




    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs)
        Dim msg As Integer = MessageBox.Show("Deseas eliminar seleccion?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'el sistema pregunta al usuario'
        'espera la respuesta y ejecuta una opcion
        If msg = DialogResult.Yes Then
            'elimina la seleccion'
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

            Dim suma As Double
            For i = 0 To DataGridView1.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGridView1.Rows(i).Cells(5).Value)
            Next
            txtsubtot.Text = suma.ToString
            'txtiva.Text = Val(txtsubtotal.Text) * 0.15
            txttotal.Text = Val(txtsubtot.Text) + Val(txtiva.Text)
        Else
            DataGridView1.Refresh()
            'mantiene la seleccion'
            ' DataGridcontado.Rows.Contains(DataGridcontado.CurrentRow)
        End If
    End Sub

    Private Sub DEVOLUCION_Click(sender As Object, e As EventArgs) Handles DEVOLUCION.Click
        'elimina la seleccion'
        'DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter
        Label10.Text = Date.Today
        Dim fecha_hoy As String
        Dim fecha_hoy1 As Date
        fecha_hoy1 = Label10.Text
        fecha_hoy = Format(fecha_hoy1, "dd/MM/yyyy")
       
        Dim msg As Integer = MessageBox.Show("Deseas Devolver Item?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'el sistema pregunta al usuario'
        'espera la respuesta y ejecuta una opcion
        Try
            If msg = DialogResult.Yes Then
                result = InputBox("Cantidad a Devolver:", "", "")


                If fecha_hoy = txtfecha.Text Then


                    Dim j As Integer = DataGridView1.CurrentRow.Index
                    If result > Val(DataGridView1.Rows(j).Cells(3).Value) Then
                        MsgBox("Eror en Cantidad a devolver", vbExclamation)
                        Exit Sub
                    Else

                        Dim res As Integer = Convert.ToInt32(result)
                        btnGuardar.Visible = True

                        txtcantidad_devolucion.Text = DataGridView1.Rows(j).Cells(3).Value
                        cant_mayor = Val(txtcantidad_devolucion.Text)
                        resultadofinal = Val(txtcantidad_devolucion.Text) - res
                        DataGridView1.Rows(j).Cells(3).Value = resultadofinal
                        txtcod.Text = DataGridView1.Rows(j).Cells(1).Value
                        'txtsubtot.Text = suma.ToString

                        Txtprecio.Text = DataGridView1.Rows(j).Cells(4).Value
                        txtsubnuevo.Text = Val(resultadofinal) * Val(Txtprecio.Text)

                        DataGridView1.Rows(j).Cells(5).Value = txtsubnuevo.Text

                    End If


                    'txtiva.Text = Val(txtsubtotal.Text) * 0.15
                    'txttotal.Text = Val(txtsubtot.Text) + Val(txtiva.Text)
                Else
                    MsgBox("No se Puede Realizar Devolucion", MsgBoxStyle.Critical, "Error de Fecha")
                    DataGridView1.Refresh()
                    'mantiene la seleccion'
                    ' DataGridcontado.Rows.Contains(DataGridcontado.CurrentRow)

                End If
            End If
                'End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtcantidad_devolucion_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad_devolucion.TextChanged
       
    End Sub

    Private Sub txtsubnuevo_TextChanged(sender As Object, e As EventArgs) Handles txtsubnuevo.TextChanged
        Dim suma As Double
        Dim grantotal1 As Double
        Dim grantotal2 As Double
        Dim subtt As Double

        For i = 0 To DataGridView1.RowCount - 1
            'hace la suma de todas las filas del subtotal'
            suma += Val(DataGridView1.Rows(i).Cells(5).Value)

           


        Next
        mult = Txtprecio.Text * result

        subtt = suma - mult
        grantotal1 = (Val(txtsubtot.Text) + Val(txtiva.Text))
        grantotal2 = grantotal1 - mult
        txtsubtot.Clear()
        txtsubtot.Text = subtt
        txttotal.Clear()
        txttotal.Text = grantotal2

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim msg As Integer = MessageBox.Show("Deseas Guardar Devolucion?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = DialogResult.Yes Then
                Dim sumar_existencia As String = "UPDATE `sist_ventas`.`productos` SET `existencia`=`existencia` + '" & result & "' WHERE `idprod`='" & txtcod.Text & "';"

                consultas.funcion(sumar_existencia)

                actualizar_devolucion()
            Else
                Exit Sub

            End If

        Catch ex As Exception
        End Try
    End Sub

End Class