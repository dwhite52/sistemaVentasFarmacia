Imports System.Data
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Drawing2D
Public Class ventas
    'Esconde estos campos al hacer una venta al contado y los muestra al hacer una venta al credito
    Dim descrip As String

    Public Sub forma_pagos()
        If cmbformapago.Text = "Cheque" Then
            Lblnumreferncia.Visible = True
            txtnumreferencia.Visible = True
            lblcantimporte.Visible = False
            txtcantimporte.Visible = False
            Lbltipocambio.Visible = False
            txttipocambio.Visible = False
            lblmoneda.Visible = False
            txtmoneda.Visible = False
            cmbtipomoneda.Text = ""
            cmbtipomoneda.Visible = False
            Lbltipomoneda.Visible = False
            lblcambio.Visible = False
            txtcantimporte.Clear()
            txttipocambio.Clear()
            txtmoneda.Clear()
            lblcambio.Text = ""
        ElseIf cmbformapago.Text = "Tarjeta" Then
            txtnumreferencia.Text = "0"
            Lblnumreferncia.Visible = False
            txtnumreferencia.Visible = False
            lblcantimporte.Visible = False
            txtcantimporte.Visible = False
            Lbltipocambio.Visible = False
            txttipocambio.Visible = False
            lblmoneda.Visible = False
            txtmoneda.Visible = False
            cmbtipomoneda.Text = ""
            cmbtipomoneda.Visible = False
            Lbltipomoneda.Visible = False
            lblcambio.Visible = False
            txtcantimporte.Clear()
            txttipocambio.Clear()
            txtmoneda.Clear()
            lblcambio.Text = ""
        ElseIf cmbformapago.Text = "Efectivo" Then
            cmbtipomoneda.Text = "Cordoba"
            cmbtipomoneda.Visible = True
            Lbltipomoneda.Visible = True

            Lblnumreferncia.Visible = False
            txtnumreferencia.Visible = False
            lblcambio.Visible = True
        Else
            txtnumreferencia.Text = "0"
            Lblnumreferncia.Visible = False
            txtnumreferencia.Visible = False

            lblcantimporte.Visible = False
            txtcantimporte.Visible = False
            Lbltipocambio.Visible = False
            txttipocambio.Visible = False
            lblmoneda.Visible = False
            txtmoneda.Visible = False
            cmbtipomoneda.Visible = False
            Lbltipomoneda.Visible = False
        End If

    End Sub
    Public Sub tipo_moneda()

        If cmbformapago.Text = "Efectivo" Then
            If cmbtipomoneda.Text = "Cordoba" Then
                lblcantimporte.Visible = True
                txtcantimporte.Visible = True
                lblcambio.Text = Val(txtcantimporte.Text) - Val(lblneto.Text)
                Lbltipocambio.Visible = False
                txttipocambio.Visible = False
                lblmoneda.Visible = False
                txtmoneda.Visible = False
                txtnumreferencia.Text = "0"
            ElseIf cmbtipomoneda.Text = "Dolar" Then
                lblcantimporte.Visible = True
                txtcantimporte.Visible = True
                lblmoneda.Visible = True
                txtmoneda.Visible = True
                Lbltipocambio.Visible = True
                txttipocambio.Visible = True
                txtnumreferencia.Text = "0"
                lblcambio.Text = Val(txtmoneda.Text) - Val(lblneto.Text)
            End If
        End If
    End Sub

    'Agrega los datos del producto a la lista en el datagridview'
    Private Sub btnagregar_fila_Click(sender As Object, e As EventArgs)

    End Sub

    'Elimina la seleccion del datagridview
    Private Sub btnQuitar_seleccion_Click(sender As Object, e As EventArgs) Handles btnQuitar_seleccion.Click
        Dim cred As Boolean
        cred = Rad_credito.Checked
        Select Case cred
            Case 1
                'el sistema pregunta al usuario'
                Dim msg As Integer = MessageBox.Show("Deseas eliminar seleccion?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                'el sistema pregunta al usuario'
                'espera la respuesta y ejecuta una opcion
                If msg = DialogResult.Yes Then
                    'elimina la seleccion'
                    datagridcredito.Rows.Remove(datagridcredito.CurrentRow)
                    boton_cred()
                    Dim suma As Double
                    For i = 0 To datagridcredito.RowCount - 1
                        'hace la suma de todas las filas del subtotal'
                        suma += Val(datagridcredito.Rows(i).Cells(4).Value)
                    Next
                    txtsubtotal.Text = suma.ToString
                    'txtiva.Text = Val(txtsubtotal.Text) * 0.15
                    txttotal.Text = Val(txtsubtotal.Text) + Val(txtiva.Text)
                Else
                    datagridcredito.Refresh()
                    'mantiene la seleccion'
                    ' DataGridcontado.Rows.Contains(DataGridcontado.CurrentRow)
                End If
            Case Else
        End Select
        Dim cont As Boolean
        cont = rad_contado.Checked
        Select Case cont
            Case 1
                Dim msg As Integer = MessageBox.Show("Deseas eliminar seleccion?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                'el sistema pregunta al usuario'
                'espera la respuesta y ejecuta una opcion
                If msg = DialogResult.Yes Then
                    'elimina la seleccion'
                    DataGridcontado.Rows.Remove(DataGridcontado.CurrentRow)
                    boton_cont()
                    Dim suma As Double
                    For i = 0 To DataGridcontado.RowCount - 1
                        'hace la suma de todas las filas del subtotal'
                        suma += Val(DataGridcontado.Rows(i).Cells(4).Value)
                    Next
                    txtsubtotal.Text = suma.ToString
                    'txtiva.Text = Val(txtsubtotal.Text) * 0.15
                    txttotal.Text = Val(txtsubtotal.Text) + Val(txtiva.Text)
                Else
                    DataGridcontado.Refresh()
                    'mantiene la seleccion'
                    ' DataGridcontado.Rows.Contains(DataGridcontado.CurrentRow)
                End If
            Case Else
        End Select
    End Sub
    'opcion de modificar los registros de la lista del datagridview
    Private Sub btnmodificar_seleccion_Click(sender As Object, e As EventArgs) Handles btnmodificar_seleccion.Click
        'obtiene el valor correspondiente de cada celda y fila referente al textbox 
        txtcodprod.ReadOnly = True
        txtdescprod.ReadOnly = True
        btnagregarr.Visible = False
        btngcamb.Visible = True
        btnQuitar_seleccion.Enabled = False
        Dim cred As Boolean
        cred = Rad_credito.Checked
        Select Case cred
            Case 1
                contar = datagridcredito.CurrentRow.Index
                'pasa los valores de la fila seleccionada a cada una de los textbox correspondientes'
                txtcodprod.Text = datagridcredito.Rows(datagridcredito.CurrentRow.Index).Cells(0).Value
                txtdescprod.Text = datagridcredito.Rows(datagridcredito.CurrentRow.Index).Cells(1).Value
                txtcantidadd.Text = datagridcredito.Rows(datagridcredito.CurrentRow.Index).Cells(2).Value
                txtprecio.Text = datagridcredito.Rows(datagridcredito.CurrentRow.Index).Cells(3).Value
                lblneto.Update()
                estado = True
            Case Else
        End Select
        Dim cont As Boolean
        cont = rad_contado.Checked
        Select Case cont
            Case 1
                Try
                    contar = DataGridcontado.CurrentRow.Index
                    'pasa los valores de la fila seleccionada a cada una de los textbox correspondientes'
                    txtcodprod.Text = DataGridcontado.Rows(DataGridcontado.CurrentRow.Index).Cells(0).Value
                    txtdescprod.Text = DataGridcontado.Rows(DataGridcontado.CurrentRow.Index).Cells(1).Value
                    txtcantidadd.Text = DataGridcontado.Rows(DataGridcontado.CurrentRow.Index).Cells(2).Value
                    txtprecio.Text = DataGridcontado.Rows(DataGridcontado.CurrentRow.Index).Cells(3).Value
                    lblneto.Update()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try

            Case Else
        End Select
    End Sub
    'declaracion de variables globales
    Private estado As Boolean = False
    Private contar As Integer
    Private Sub Rad_credito_Click(sender As Object, e As EventArgs) Handles Rad_credito.Click
        'el sistema pregunta al usuario'
        If validar_contiene() = True Then
            rad_contado.Enabled = True
            rad_contado.Checked = True
        Else
            txtnomcred.Focus()
            Lbltitulo.Text = "VENTAS AL CREDITO"
            Lbldescuento.Visible = False
            txtdescuento.Visible = False
            datagridcredito.Visible = True
            DataGridcontado.Visible = False
            lblnomcontadoo.Visible = False
            txtnomcontadoo.Visible = False
            rad_contado.Enabled = False
            datefechalimite.Value = datefecha.Value.Date.AddDays(30)
            Panel5.Visible = False
            Panel2.Width = 1090
        End If
    End Sub
    'Validacion de los campos'
    Private Sub txtdescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescuento.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txtdescuento)
    End Sub
    Private Sub txtdescuento_TextChanged(sender As Object, e As EventArgs) Handles txtdescuento.TextChanged
        lblneto.Text = Val(txttotal.Text) - Val(txtdescuento.Text)
    End Sub
    Private Sub txtcantimporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantimporte.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txtcantimporte)
    End Sub
    Private Sub txtcantimporte_TextChanged(sender As Object, e As EventArgs) Handles txtcantimporte.TextChanged
        If cmbtipomoneda.SelectedItem = "Cordoba" Then
            lblcambio.Text = Val(txtcantimporte.Text) - Val(lblneto.Text)
        ElseIf cmbtipomoneda.SelectedItem = "Dolar" Then
            Dim moneda As Double
            moneda = Val(txtcantimporte.Text) * Val(txttipocambio.Text)
            txtmoneda.Text = moneda.ToString
            lblcambio.Text = Val(txtmoneda.Text) - Val(lblneto.Text)
        End If
    End Sub

    Private Sub txtnumreferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumreferencia.KeyPress
        e.Handled = validar_solo_Numeros(e, txtnumreferencia)
    End Sub

    Private Sub txttipocambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttipocambio.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txttipocambio)
    End Sub
    Function validar_vacio_cont()

        If txtiva.Text = "" Or txtsubtotal.Text = "" Or txttotal.Text = "" Or txtdescuento.Text = "" Or cmbformapago.Text = "" Or txtcantimporte.Text = "" Or DataGridcontado.Rows.Count < 1 Then
            MsgBox("Por favor llene todos los campos necesarios", vbInformation)
            validar_vacio_cont = True
            Exit Function
        Else
            validar_vacio_cont = False
        End If
    End Function
    Function validar_vacio_cred()

        If txtidcliente.Text = "" Or txttotal.Text = "" Or txtiva.Text = "" Or datagridcredito.Rows.Count < 1 Then
            MsgBox("Por favor llene todos los campos necesarios", vbInformation)
            validar_vacio_cred = True
            Exit Function
        Else
            validar_vacio_cred = False
        End If
    End Function
    Function validar_contiene()

        If Not txtiva.Text = "" Or Not txtsubtotal.Text = "" Or Not txttotal.Text = "" Then
            MsgBox("Hay campos con dato, Por favor Termina la venta o cancela", vbCritical, "Error")
            validar_contiene = True
            Exit Function
        Else
            validar_contiene = False
        End If
    End Function
    Function validar_vaciobtnagregar()

        If txtcodprod.Text = "" Or txtcantidadd.Text = "" Or txtdescprod.Text = "" Or txtprecio.Text = "" Then
            MsgBox("Porfavor llene los campos", vbCritical, "Error")
            validar_vaciobtnagregar = True
            Exit Function
        Else
            validar_vaciobtnagregar = False
        End If
    End Function

    Function validar_mayor()
        Dim restpuesta As Boolean = False
        Try
            Dim neto As Integer
            neto = CInt(lblneto.Text)

            If cmbtipomoneda.Text = "Cordoba" Then

                If txtcantimporte.Text < neto Then

                    MsgBox("No se puede realizar La venta, Revisa el pago  ", vbCritical, "Error")
                    validar_mayor = True
                    Exit Function
                Else
                    validar_mayor = False
                End If
            ElseIf cmbtipomoneda.Text = "Dolar" Then
                If txtmoneda.Text < neto Then

                    MsgBox("No se puede realizar La venta, Revisa el pago  ", vbCritical, "Error")
                    validar_mayor = True
                    Exit Function
                Else
                    validar_mayor = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        Return restpuesta
    End Function


    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click

        Dim cont As Boolean
        Dim tabla2 As New DataTable
        cont = rad_contado.Checked
        Select Case cont

            Case 1
                If validar_vacio_cont() = True Then
                    Exit Sub
                End If
                If validar_mayor() = True Then
                    Exit Sub
                End If
                Dim ingresar As String = "insert into sist_ventas.Ventas (`vendedor`,`fecha_venta`,`tipo_moneda`, `subtotal1`, `descuento_total`, `total`, `iva`, `neto`,  `forma_pago`,  `num_ref`,`Nombre_Cliente_contd`)VALUES ('" + Login.user + "','" & datefecha.Value.ToString("yyyy-M-d") & "','" & cmbtipomoneda.SelectedItem & "','" & txtsubtotal.Text & "','" & txtdescuento.Text & "','" & txttotal.Text & "','" & txtiva.Text.ToString() & "','" & lblneto.Text & "','" & cmbformapago.SelectedItem & "','" & txtnumreferencia.Text & "','" & txtnomcontadoo.Text & "'); "
                Try
                    If consultas.funcion(ingresar) = True Then
                        MsgBox("Venta Realizada Exitosamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")

                End Try

                Dim cons As String = "SELECT MAX(Num_Boleta_contd) FROM sist_ventas.ventas; "
                Try
                    Dim da As New MySqlDataAdapter(cons, conex)
                    da.SelectCommand.CommandType = CommandType.Text
                    da.Fill(tabla2)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")

                End Try

                Try
                    Dim num_boleta_contd As Integer
                    num_boleta_contd = tabla2.Rows(0)(0).ToString()
                    For i = 0 To DataGridcontado.Rows.Count - 1
                        Dim con As String = "INSERT INTO sist_ventas.detalle_venta Values ('" & DataGridcontado.Rows(i).Cells(0).Value & "','" & num_boleta_contd & "','" & DataGridcontado.Rows(i).Cells(2).Value & "','" & DataGridcontado.Rows(i).Cells(3).Value & "','" & DataGridcontado.Rows(i).Cells(1).Value & "','" & DataGridcontado.Rows(i).Cells(4).Value & "');"
                        consultas.funcion(con)
                        Dim restar_existencia As String = "UPDATE `sist_ventas`.`productos` SET `existencia`=`existencia`-'" + DataGridcontado.Rows(i).Cells(2).Value + "' WHERE `idprod`='" & DataGridcontado.Rows(i).Cells(0).Value & "';"
                        consultas.funcion(restar_existencia)
                    Next


                    Dim conslt As String = "SELECT detalle_venta.cod_prod,detalle_venta.Num_Boleta_contd,detalle_venta.cantidad, detalle_venta.precio, detalle_venta.descripcion, detalle_venta.subtotal_unit, ventas.vendedor, ventas.fecha_venta,ventas.subtotal1, ventas.Nombre_Cliente_contd, ventas.neto, ventas.iva, ventas.descuento_total, ventas.total FROM detalle_venta INNER JOIN ventas ON detalle_venta.Num_Boleta_contd = ventas.Num_Boleta_contd where  detalle_venta.Num_Boleta_contd ='" + tabla2.Rows(0)(0).ToString + "';"
                    Try
                        Dim sc As New DataSet
                        Dim da As New MySqlDataAdapter(conslt, conex)
                        da.SelectCommand.CommandType = CommandType.Text
                        da.Fill(sc, "Factura_cont")
                        '********// ESTE CODIGO ES PARA IMPRIMIR LA BOLETA AL CLIENTE
                        'Dim rr As New Rpt_contado
                        'Dim cr As New Boleta_contado
                        'cr.SetDataSource(sc)
                        'Dim txtcambio As TextObject
                        'Dim txtimporte As TextObject
                        'Dim num_ref As TextObject
                        'txtcambio = (cr.ReportDefinition.ReportObjects("cambio"))
                        'txtcambio.Text = lblcambio.Text
                        'txtimporte = (cr.ReportDefinition.ReportObjects("importe"))
                        'num_ref = (cr.ReportDefinition.ReportObjects("num_ref"))
                        'num_ref.Text = txtnumreferencia.Text
                        'If cmbtipomoneda.Text = "Dolar" Then
                        'txtimporte.Text = txtmoneda.Text
                        'Else
                        'txtimporte.Text = txtcantimporte.Text
                        'End If

                        'rr.CrystalReportViewer1.ReportSource = cr
                        'rr.ShowDialog()
                        '\\*****TERMINA AQUI!!
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Error")

                    End Try


                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
                Dim msg As Integer = MessageBox.Show("Deseas Registar Otra Venta", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msg = DialogResult.Yes Then
                    limpiar_cont()
                    cmbtipomoneda.Text = "Cordoba"
                    cmbformapago.Text = "Efectivo"
                    lblcantimporte.Visible = True
                    txtcantimporte.Visible = True
                    btnmodificar_seleccion.Enabled = False
                    btnQuitar_seleccion.Enabled = False
                    txtcodprod.Focus()
                Else
                    Me.Dispose()
                End If
            Case Else
        End Select
        Dim cred As Boolean
        Dim tabla3 As New DataTable
        cred = Rad_credito.Checked
        Select Case cred
            Case 1
                If validar_vacio_cred() = True Then
                    Exit Sub
                End If
                Dim ingresar_cred As String = "insert into sist_ventas.Credito (`vendedor`,`fecha`, `subtotal`, `total`, `iva`)VALUES ('" + Login.user + "','" & datefecha.Value.ToString("yyyy-M-d") & "','" & txtsubtotal.Text & "','" & txttotal.Text & "','" & txtiva.Text.ToString() & "'); "
                Try
                    If consultas.funcion(ingresar_cred) = True Then
                        'MsgBox("Datos ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
                Dim cons As String = "SELECT MAX(num_Boleta_cred) FROM sist_ventas.credito; "
                Try
                    Dim da As New MySqlDataAdapter(cons, conex)
                    da.SelectCommand.CommandType = CommandType.Text
                    da.Fill(tabla3)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
                Try
                    Dim num_boleta_cred As Integer
                    num_boleta_cred = tabla3.Rows(0)(0).ToString()
                    For i = 0 To datagridcredito.Rows.Count - 1
                        Dim con As String = "INSERT INTO sist_ventas.detalle_credito Values ('" & datagridcredito.Rows(i).Cells(2).Value & "','" & datagridcredito.Rows(i).Cells(3).Value & "','" & datagridcredito.Rows(i).Cells(1).Value & "','" & datagridcredito.Rows(i).Cells(0).Value & "','" & num_boleta_cred & "','" & datagridcredito.Rows(i).Cells(4).Value & "');"
                        consultas.funcion(con)
                        Dim restar_existencia As String = "UPDATE `sist_ventas`.`productos` SET `existencia`=`existencia`-'" + datagridcredito.Rows(i).Cells(2).Value + "' WHERE `idprod`='" & datagridcredito.Rows(i).Cells(0).Value & "';"
                        consultas.funcion(restar_existencia)
                    Next

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
                Dim num_boleta As Integer
                num_boleta = tabla3.Rows(0)(0).ToString()
                Dim ingresar2 As String = "insert into sist_ventas.cuentas_x_cobrar(`fecha_de_vencimiento`, `Clientes_Cod_Clientes`, `monto`, `Credito_Num_boleta_cred`,`estado`,`saldo_pendiente`)VALUES ('" & datefechalimite.Value.ToString("yyyy-M-d") & "','" & txtidcliente.Text & "','" & txttotal.Text & "','" & num_boleta & "', 'Pendiente' ,'" & txttotal.Text & "'); "
                Try
                    If consultas.funcion(ingresar2) = True Then
                        MsgBox("Venta Realizada con Exito", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
                Dim conslt_cred As String = "SELECT detalle_credito.Inventario_idprod,credito.Num_Boleta_cred,detalle_credito.catidad as cantidad, detalle_credito.precio, detalle_credito.descripcion, detalle_credito.subtotal,credito.vendedor, credito.fecha,credito.subtotal as subtotal_unit,cuentas_x_cobrar.Clientes_Cod_Clientes, credito.total, credito.iva, cuentas_x_cobrar.fecha_de_vencimiento as fecha_vencimiento FROM detalle_credito INNER JOIN credito ON detalle_credito.Credito_Num_Boleta_cred = credito.Num_Boleta_cred inner join cuentas_x_cobrar on credito.Num_Boleta_cred= cuentas_x_cobrar.Credito_Num_Boleta_cred where  detalle_credito.Credito_Num_Boleta_cred ='" + tabla3.Rows(0)(0).ToString() + "';"
                Try
                    Dim sc As New DataSet
                    Dim da As New MySqlDataAdapter(conslt_cred, conex)
                    da.SelectCommand.CommandType = CommandType.Text
                    da.Fill(sc, "Factura_cred")
                    Dim rr As New Rpt_contado
                    Dim cr As New Boleta_credito
                    cr.SetDataSource(sc)
                    rr.CrystalReportViewer1.ReportSource = cr
                    rr.ShowDialog()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")

                End Try

                Dim msg As Integer = MessageBox.Show("Deseas Registar Otra Venta", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msg = DialogResult.Yes Then

                    limpiar_cred()
                    txtcodprod.Focus()


                Else
                    Me.Dispose()
                End If
            Case Else
        End Select
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Dim cont As Boolean
        cont = rad_contado.Checked
        Select Case cont
            Case 1
                Dim msg As Integer = MessageBox.Show("Estas seguro que deseas cancelar la venta al contado", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If msg = DialogResult.Yes Then
                    DataGridcontado.Visible = True
                    datagridcredito.Visible = False
                    txtcodprod.ReadOnly = False
                    txtdescprod.ReadOnly = False
                    DataGridcontado.Rows.Clear()
                    txtnomcontadoo.Clear()
                    txtcantidadd.Clear()
                    txtcodprod.Clear()
                    txtdescprod.Clear()
                    txtsubtotal.Clear()
                    txtiva.Text = "0"
                    txttotal.Clear()
                    txtdescuento.Clear()
                    txtdescuento.Text = "0"
                    txtprecio.Clear()
                    txtcantimporte.Clear()
                    txtmoneda.Clear()
                    txtnumreferencia.Text = "0"
                    txttipocambio.Clear()
                    lblneto.Text = ""
                    lblcambio.Text = ""
                    btnagregarr.Visible = True
                    btngcamb.Visible = False
                    rad_contado.Enabled = True
                    rad_contado.Checked = True
                    Panel5.Visible = True
                    Panel2.Width = 554
                    boton_cont()
                End If
            Case Else
        End Select
        Dim cred As Boolean
        cred = Rad_credito.Checked
        Select Case cred
            Case 1
                Dim msg As Integer = MessageBox.Show("Estas seguro que deseas cancelar la venta al credito?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If msg = DialogResult.Yes Then
                    Lbltitulo.Text = "VENTAS AL CONTADO"
                    DataGridcontado.Visible = True
                    datagridcredito.Visible = False
                    txtcodprod.ReadOnly = False
                    txtdescprod.ReadOnly = False
                    datagridcredito.Rows.Clear()
                    txtcantidadd.Clear()
                    txtcodprod.Clear()
                    txtdescprod.Clear()
                    txtsubtotal.Clear()
                    txtiva.Clear()
                    txttotal.Clear()
                    txtdescuento.Clear()
                    txtdescuento.Text = "0"
                    txtprecio.Clear()
                    txtnomcred.Clear()
                    txtidcliente.Clear()
                    btnagregarr.Visible = True
                    btngcamb.Visible = False
                    rad_contado.Enabled = True
                    rad_contado.Checked = True
                    Lbldescuento.Visible = True
                    txtdescuento.Visible = True
                    Panel5.Visible = True
                    Panel2.Width = 554
                    boton_cred()
                End If
            Case Else
        End Select
    End Sub
    Private Sub rad_contado_CheckedChanged(sender As Object, e As EventArgs) Handles rad_contado.CheckedChanged
        lblnomcontadoo.Visible = True
        txtnomcontadoo.Visible = True
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        clientes.Show()
    End Sub
    Private Sub txtnomcred_TextChanged(sender As Object, e As EventArgs)
    End Sub
    Private Sub btngcamb_Click(sender As Object, e As EventArgs) Handles btngcamb.Click
        Dim cont As Boolean
        cont = rad_contado.Checked
        Select Case cont
            Case 1
                Try

                    If txtcantidadd.Text = 0 Then
                        MsgBox("No se puede realizar, Cantidad = 0", MessageBoxIcon.Stop, "Cantidad Vacio")
                        Exit Sub
                    ElseIf txtcantidadd.Text > consultas.tabla.Rows(0)(2) Then
                        MsgBox("No se puede realizar, Cantidad Existente= " + consultas.tabla.Rows(0)(2).ToString + "", MessageBoxIcon.Stop, "Cantidad Insuficiente")
                        Exit Sub
                    End If
                    txtcodprod.ReadOnly = False
                    txtdescprod.ReadOnly = False

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error Fatal")
                End Try
                DataGridcontado.Rows(contar).Cells(0).Value = txtcodprod.Text
                DataGridcontado.Rows(contar).Cells(1).Value = txtdescprod.Text
                DataGridcontado.Rows(contar).Cells(2).Value = txtcantidadd.Text
                DataGridcontado.Rows(contar).Cells(3).Value = txtprecio.Text
                DataGridcontado.Rows(contar).Cells(4).Value = txtcantidadd.Text * txtprecio.Text
                txtcodprod.Clear()
                txtcantidadd.Clear()
                txtcodprod.Focus()
                boton_cont()
                Dim suma As Double
                For i = 0 To DataGridcontado.RowCount - 1
                    'hace la suma de todas las filas del subtotal'
                    suma += Val(DataGridcontado.Rows(i).Cells(4).Value)
                Next
                txtsubtotal.Text = suma.ToString
                'txtiva.Text = Val(txtsubtotal.Text) * 0.15
                txttotal.Text = Val(txtsubtotal.Text) + Val(txtiva.Text)
            Case Else
        End Select
        Dim cred As Boolean
        cred = Rad_credito.Checked
        Select Case cred
            Case 1
                Try
                    If txtcantidadd.Text = 0 Then
                        MsgBox("No se puede realizar, Cantidad = 0", MessageBoxIcon.Stop, "Cantidad Vacio")
                        Exit Sub
                    ElseIf txtcantidadd.Text > consultas.tabla.Rows(0)(2) Then
                        MsgBox("No se puede realizar, Cantidad Existente= " + consultas.tabla.Rows(0)(2).ToString + "", MessageBoxIcon.Stop, "Cantidad Insuficiente")
                        Exit Sub
                    End If
                    txtcodprod.ReadOnly = False
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error Fatal")
                End Try
                datagridcredito.Rows(contar).Cells(0).Value = txtcodprod.Text
                datagridcredito.Rows(contar).Cells(1).Value = txtdescprod.Text
                datagridcredito.Rows(contar).Cells(2).Value = txtcantidadd.Text
                datagridcredito.Rows(contar).Cells(3).Value = txtprecio.Text
                datagridcredito.Rows(contar).Cells(4).Value = txtcantidadd.Text * txtprecio.Text
                txtcodprod.Clear()
                txtcantidadd.Clear()
                txtcodprod.Focus()
                boton_cred()
                Dim suma2 As Double
                For i = 0 To datagridcredito.RowCount - 1
                    'hace la suma de todas las filas del subtotal'
                    suma2 += Val(datagridcredito.Rows(i).Cells(4).Value)
                Next
                txtsubtotal.Text = suma2.ToString
                ' txtiva.Text = Val(txtsubtotal.Text) * 0.15
                txttotal.Text = Val(txtsubtotal.Text) + Val(txtiva.Text)
            Case Else
        End Select
        btnagregarr.Visible = True
        btngcamb.Visible = False
        btnQuitar_seleccion.Enabled = True
    End Sub

    Private Sub btnagregarr_Click(sender As Object, e As EventArgs) Handles btnagregarr.Click
        If validar_vaciobtnagregar() = True Then
            txtcodprod.Focus()
            Exit Sub
        Else
            Try
                If txtcantidadd.Text = 0 Then
                    MsgBox("No se puede realizar, Cantidad = 0", MessageBoxIcon.Stop, "Cantidad Vacio")
                    Exit Sub
                ElseIf txtcantidadd.Text > consultas.tabla.Rows(0)(2) Then
                    MsgBox("No se puede realizar, Cantidad Existente= " + consultas.tabla.Rows(0)(2).ToString + "", MessageBoxIcon.Hand, "Cantidad Insuficiente")
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Fatal")
            End Try
            Dim cred As Boolean
            cred = Rad_credito.Checked
            Select Case cred
                Case 1
                    For a = 0 To datagridcredito.Rows.Count - 1
                        If txtcodprod.Text = datagridcredito.Rows(a).Cells(0).Value Then
                            MsgBox("Producto Duplicado", MsgBoxStyle.Exclamation)
                            txtcodprod.Clear()
                            txtcantidadd.Clear()
                            txtcodprod.Focus()
                            Exit Sub
                        End If
                    Next
                    datagridcredito.Rows.Add()
                    Dim fila As Integer = datagridcredito.RowCount - 1
                    'pasa el valor nuevo de los Texbox a las filas del datagridview
                    datagridcredito.Rows(fila).Cells(0).Value = txtcodprod.Text
                    datagridcredito.Rows(fila).Cells(1).Value = txtdescprod.Text
                    datagridcredito.Rows(fila).Cells(2).Value = txtcantidadd.Text
                    datagridcredito.Rows(fila).Cells(3).Value = txtprecio.Text
                    datagridcredito.Rows(fila).Cells(4).Value = txtcantidadd.Text * txtprecio.Text
                    txtcodprod.Clear()
                    txtcantidadd.Clear()
                    txtcodprod.Focus()
                    boton_cred()
                    Dim suma2 As Double
                    For i = 0 To datagridcredito.RowCount - 1
                        'hace la suma de todas las filas del subtotal'
                        suma2 += Val(datagridcredito.Rows(i).Cells(4).Value)
                    Next
                    txtsubtotal.Text = suma2.ToString
                    'txtiva.Text = Val(txtsubtotal.Text) * 0.15
                    txttotal.Text = Val(txtsubtotal.Text) + Val(txtiva.Text)
                Case Else
            End Select
            Dim cont As Boolean
            cont = rad_contado.Checked
            Select Case cont
                Case 1
                    For a = 0 To DataGridcontado.Rows.Count - 1
                        If txtcodprod.Text = DataGridcontado.Rows(a).Cells(0).Value Then
                            MsgBox("Producto Duplicado", MsgBoxStyle.Exclamation)
                            txtcodprod.Clear()
                            txtcantidadd.Clear()
                            txtcodprod.Focus()
                            Exit Sub
                        End If
                    Next
                    DataGridcontado.Rows.Add()
                    Dim fila As Integer = DataGridcontado.RowCount - 1
                    'pasa el valor nuevo de los Texbox a las filas del datagridview
                    DataGridcontado.Rows(fila).Cells(0).Value = txtcodprod.Text
                    DataGridcontado.Rows(fila).Cells(1).Value = txtdescprod.Text
                    DataGridcontado.Rows(fila).Cells(2).Value = txtcantidadd.Text
                    DataGridcontado.Rows(fila).Cells(3).Value = txtprecio.Text
                    DataGridcontado.Rows(fila).Cells(4).Value = txtcantidadd.Text * txtprecio.Text
                    txtcodprod.Clear()
                    txtcantidadd.Clear()
                    txtcodprod.Focus()
                    boton_cont()
                    Dim suma As Double
                    For i = 0 To DataGridcontado.RowCount - 1
                        'hace la suma de todas las filas del subtotal'
                        suma += Val(DataGridcontado.Rows(i).Cells(4).Value)
                    Next
                    lblneto.Text = Val(txttotal.Text) - Val(txtdescuento.Text)
                    txtsubtotal.Text = suma.ToString
                    'txtiva.Text = Val(txtsubtotal.Text) * 0.15
                    txttotal.Text = Val(txtsubtotal.Text) + Val(txtiva.Text)
                Case Else
            End Select
        End If
    End Sub

    Private Sub txtcodprod_TextChanged_1(sender As Object, e As EventArgs) Handles txtcodprod.TextChanged
        tabla.Reset()
        Dim sql As String = "SELECT Descripcion,precio_de_venta_unit,existencia,fecha_expiracion FROM sist_ventas.productos where idprod='" + txtcodprod.Text + "'; "
        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(tabla)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        If tabla.Rows.Count = 1 Then
            If tabla.Rows(0)(3).ToString() < Date.Now Then
                MsgBox("Producto Expirado", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            txtdescprod.Text = tabla.Rows(0)(0).ToString()
            txtprecio.Text = tabla.Rows(0)(1).ToString()
        Else
            txtdescprod.Clear()
            txtprecio.Clear()
        End If
    End Sub
    'Validacion de  campos'
    Private Sub txtcantidadd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidadd.KeyPress
        e.Handled = validar_solo_Numeros(e, txtcantidadd)
    End Sub

    Private Sub txtnomcred_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomcred.KeyPress
        Letras(e, txtnomcred)
    End Sub
    Private Sub txtnomcontadoo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomcontadoo.KeyPress
        Letras(e, txtnomcontadoo)
    End Sub
    Private Dat As New DataTable()
    Private Sub txtnomcred_TextChanged_1(sender As Object, e As EventArgs) Handles txtnomcred.TextChanged
        Dat.Reset()
        Dim sql As String = "SELECT Cod_Clientes,Nombre,apellido,estado FROM sist_ventas.clientes where Nombre like '" + txtnomcred.Text + "%'; "
        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text

            da.Fill(Dat)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        ListView1.Items.Clear()
        For Each reg In Dat.Rows
            Dim fila As ListViewItem
            fila = ListView1.Items.Add(reg("cod_clientes"))
            With fila
                .SubItems.Add(reg("Nombre"))
                .SubItems.Add(reg("apellido"))
                If txtnomcred.Text = Nothing Then
                    ListView1.Items.Clear()
                End If
            End With
        Next
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        If Dat.Rows(ListView1.FocusedItem.Index)(3).ToString = "Inactivo" Then
            MsgBox("Este Usuario esta Suspendido, Consulte con el Administardor del Sistema", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            txtidcliente.Text = ListView1.FocusedItem.SubItems(0).Text
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        lblneto.Text = Val(txttotal.Text) - Val(txtdescuento.Text)
    End Sub

    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtnomcontadoo.Clear()
        txtnomcontadoo.Focus()
        boton_cont()
    End Sub
    Public Sub boton_cont()
        If DataGridcontado.RowCount < 1 Then
            btnmodificar_seleccion.Enabled = False
            btnQuitar_seleccion.Enabled = False
        Else
            btnmodificar_seleccion.Enabled = True
            btnQuitar_seleccion.Enabled = True
        End If
    End Sub
    Public Sub boton_cred()
        If datagridcredito.RowCount < 1 Then
            btnmodificar_seleccion.Enabled = False
            btnQuitar_seleccion.Enabled = False
        Else
            btnmodificar_seleccion.Enabled = True
            btnQuitar_seleccion.Enabled = True
        End If
    End Sub
    Public Sub limpiar_cred()
        txtcodprod.ReadOnly = False
        datagridcredito.Rows.Clear()
        txtcantidadd.Clear()
        txtcodprod.Clear()
        txtdescprod.Clear()
        txtsubtotal.Clear()
        txtiva.Clear()
        txttotal.Clear()
        txtprecio.Clear()
        txtnomcred.Clear()
        txtidcliente.Clear()
    End Sub
    Public Sub limpiar_cont()
        txtcodprod.ReadOnly = False
        DataGridcontado.Rows.Clear()
        txtnomcontadoo.Clear()
        txtcantidadd.Clear()
        txtcodprod.Clear()
        txtdescprod.Clear()
        txtsubtotal.Clear()
        txtiva.Clear()
        txtiva.Text = "0"
        txttotal.Clear()
        txtdescuento.Clear()
        txtdescuento.Text = "0"
        txtprecio.Clear()
        txtcantimporte.Clear()
        txtmoneda.Clear()
        txtnumreferencia.Clear()
        txttipocambio.Clear()
        cmbformapago.SelectedItem = Nothing
        cmbtipomoneda.SelectedItem = Nothing
        lblneto.Text = ""
        lblcambio.Text = ""
    End Sub
    Private Sub txtnomcontadoo_TextChanged(sender As Object, e As EventArgs) Handles txtnomcontadoo.TextChanged
        Me.Focus()
    End Sub

    Private Sub cmbformapago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbformapago.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbtipomoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbtipomoneda.KeyPress
        e.Handled = True
    End Sub

    Private Sub Rad_credito_CheckedChanged(sender As Object, e As EventArgs) Handles Rad_credito.CheckedChanged

    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000

            Return cp
        End Get
    End Property 'CreateParams


    'Public Sub New()

    '    ' This call is required by the Windows Form Designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.


    '    Me.SetStyle(System.Windows.Forms.ControlStyles.DoubleBuffer, True)
    '    Me.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, True)
    '    Me.SetStyle(System.Windows.Forms.ControlStyles.ResizeRedraw, True)
    '    Me.SetStyle(System.Windows.Forms.ControlStyles.UserPaint, True)
    'End Sub

    Private Sub ventas_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

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

    Private Sub ventas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        forma_pagos()
        tipo_moneda()
    End Sub

    Private Sub cmbformapago_TextChanged(sender As Object, e As EventArgs) Handles cmbformapago.TextChanged
        forma_pagos()
    End Sub

    Private Sub cmbtipomoneda_TextChanged(sender As Object, e As EventArgs) Handles cmbtipomoneda.TextChanged
        tipo_moneda()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub datagridcredito_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridcredito.CellContentClick

    End Sub

    Private Sub txtcantidadd_TextChanged(sender As Object, e As EventArgs) Handles txtcantidadd.TextChanged

    End Sub


    Private Sub txtdescprod_TextChanged(sender As Object, e As EventArgs) Handles txtdescprod.TextChanged
        Dim dt As New DataTable
        Dim sql As String = "SELECT idprod,Descripcion,precio_de_venta_unit,existencia,fecha_expiracion FROM sist_ventas.productos where Descripcion='" + txtdescprod.Text + "';"
        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(dt)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        If dt.Rows.Count = 1 Then
            If dt.Rows(0)(4).ToString() < Date.Now Then
                MsgBox("Producto Expirado", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            txtcodprod.Text = dt.Rows(0)(0).ToString()
            txtprecio.Text = dt.Rows(0)(2).ToString()
        Else
            txtcodprod.Clear()
            txtprecio.Clear()
        End If



    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        Dim bp As New Buscarproductodescripcion
        bp.Show()

    End Sub
End Class