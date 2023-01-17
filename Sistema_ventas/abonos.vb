Imports System.Data
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class abonos
    Dim dt As DataTable
    Dim dt1 As DataTable
    Dim dt2 As DataTable
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
                lblcambio.Text = Val(txtcantimporte.Text) - Val(txtcantidad.Text)
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
                lblcambio.Text = Val(txtmoneda.Text) - Val(lblcambio.Text)
            End If
        End If
    End Sub
    Public Sub cargar_numabono()
        tabla.Reset()
        Dim sql As String = "SELECT max(idabono) from sist_ventas.abono;"

        Try

            Dim da2 As New MySqlDataAdapter(sql, conex)
            da2.SelectCommand.CommandType = CommandType.Text
            tabla = New DataTable()
            da2.Fill(tabla)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
    Public Sub cargar()
        Dim sql As String = "SELECT estado,monto,saldo_pendiente,Clientes_Cod_Clientes,num_de_credito,Num_Boleta_cred FROM cuentas_x_cobrar, credito where Num_Boleta_cred like Credito_Num_Boleta_cred and credito_Num_Boleta_cred ='" + txtnumfact.Text + "';"
       
        Try

            Dim da2 As New MySqlDataAdapter(sql, conex)
            da2.SelectCommand.CommandType = CommandType.Text
            dt = New DataTable()
            da2.Fill(dt)
            If dt.Rows.Count > 0 Then
                Cmbestado.Text = dt.Rows(0)(0).ToString
                txtsaldot.Text = dt.Rows(0)(1).ToString
                txtsaldop.Text = dt.Rows(0)(2).ToString
                txtccod.Text = dt.Rows(0)(4).ToString
            Else
                MsgBox("No se han encontrado Facturas con ese Numero", MsgBoxStyle.Exclamation)
                Cmbestado.Text = ""
                txtsaldop.Clear()
                txtsaldot.Clear()
                txtcnom.Clear()
                txtccod.Clear()
                Exit Sub
            End If

   
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        Dim sql_nombre As String = "SELECT Nombre FROM sist_ventas.clientes where Cod_Clientes ='" + dt.Rows(0)(3).ToString + "';"
        Try

            Dim da2 As New MySqlDataAdapter(sql_nombre, conex)
            da2.SelectCommand.CommandType = CommandType.Text
            dt2 = New DataTable()
            da2.Fill(dt2)
            txtcnom.Text = dt2.Rows(0)(0).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub
    Public Sub limpiar()
        txtnumfact.Clear()
        txtcantidad.Clear()
        txtccod.Clear()
        txtcnom.Clear()
        txtmoneda.Clear()
        txtcantimporte.Clear()
        txtsaldop.Clear()
        txtsaldot.Clear()
        txtrecibi.Clear()
        ComboBox1.Text = ""
        Cmbestado.Text = ""
        Lblsaldopendiente.Text = ""
        txtnumreferencia.Clear()
        txtnumreferencia.Text = "0"
        

    End Sub
    Function validar_vacio()

        If txtccod.Text = "" Or txtcantidad.Text = "" Or cmbformapago.Text = "" Then
            MsgBox("Por favor llene todos los campos necesarios", vbInformation)
            validar_vacio = True
            Exit Function
        Else
            validar_vacio = False
        End If
    End Function
    Function validar_num_mayor()
        Dim restpuesta As Boolean = False
        Try
            Dim saldopen As Integer
            saldopen = CInt(Val(txtsaldop.Text))

            If cmbtipomoneda.Text = "Cordoba" Then

                If txtcantidad.Text > saldopen Then

                    MsgBox("Esta tratando de abonar as de lo que debe  ", vbCritical, "Error")
                    validar_num_mayor = True
                    Exit Function
                Else
                    validar_num_mayor = False
                End If
            ElseIf cmbtipomoneda.Text = "Dolar" Then
                If txtcantidad.Text > saldopen Then

                    MsgBox("Esta tratando de abonar as de lo que debe   ", vbCritical, "Error")
                    validar_num_mayor = True
                    Exit Function
                Else
                    validar_num_mayor = False
                End If

            ElseIf cmbformapago.Text = "Cheque" Then
                If txtcantidad.Text > saldopen Then

                    MsgBox("Esta tratando de abonar as de lo que debe   ", vbCritical, "Error")
                    validar_num_mayor = True
                    Exit Function
                Else
                    validar_num_mayor = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        Return restpuesta
    End Function

    Private Sub abonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        cargar()
        Try
            If dt.Rows(0)(0).ToString = "Cancelado" Then
                Dim msg As Integer = MessageBox.Show("La Cuenta Se Encuentra Cancelada ", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If msg = DialogResult.OK Then
                    limpiar()
                    txtnumfact.Focus()
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btnhecho_Click(sender As Object, e As EventArgs) Handles Btnhecho.Click
        If validar_vacio() = True Then
            Exit Sub
        End If
        If validar_num_mayor() = True Then
            Exit Sub
        End If

        Dim ingresar_datos As String = " INSERT INTO `sist_ventas`.`abono` (`cuentas_x_cobrar_num_de_credito`, `fecha_pago`, `cantidad`, `forma_pago`, `tipo_moneda`, `num_referencia`,`vendedor`) VALUES ('" & txtccod.Text & "', '" & Datefecha.Value.ToString("yyyy-M-d") & "', '" & txtcantidad.Text & "', '" & cmbformapago.Text & "', '" & cmbtipomoneda.Text & "', '" & txtnumreferencia.Text & "','" + Login.user + "');"
        Try
            If consultas.funcion(ingresar_datos) = True Then
                MsgBox("Pago Realizado Con Exito", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        Dim restar_saldo As String = "UPDATE `sist_ventas`.`cuentas_x_cobrar` SET `saldo_pendiente`=`saldo_pendiente` - '" & txtcantidad.Text & "' WHERE `num_de_credito`='" & txtccod.Text & "';"
        Try
            If consultas.funcion(restar_saldo) = True Then
                'MsgBox("Datos ingresados Correctamente", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

        Dim ver_saldo_pendiente As String = "SELECT saldo_pendiente from  sist_ventas.cuentas_x_cobrar where credito_Num_Boleta_cred ='" + txtnumfact.Text + "';"
        Dim act_estado As String = "UPDATE `sist_ventas`.`cuentas_x_cobrar` SET `estado`='Cancelado' WHERE `num_de_credito`='" & txtccod.Text & "';"

        Try

            Dim da2 As New MySqlDataAdapter(ver_saldo_pendiente, conex)
            da2.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            da2.Fill(dt1)
            txtsaldop.Text = dt1.Rows(0)(0).ToString
            If dt1.Rows(0)(0) <= 0.0 Then
                MsgBox("Cuenta Cancelada", MsgBoxStyle.Information)
                consultas.funcion(act_estado)
                Cmbestado.Text = "Cancelado"

            End If
            cargar_numabono()
            Dim conslt As String = "SELECT abono.idabono,abono.cuentas_x_cobrar_num_de_credito,abono.fecha_pago,abono.cantidad,cuentas_x_cobrar.saldo_pendiente,clientes.Nombre,clientes.Apellido FROM sist_ventas.abono inner join cuentas_X_cobrar on abono.cuentas_x_cobrar_num_de_credito=cuentas_X_cobrar.num_de_credito inner join clientes on cuentas_X_cobrar.Clientes_Cod_Clientes= clientes.Cod_Clientes where idabono='" + tabla.Rows(0)(0).ToString + "';"
            Try
                Dim sc As New DataSet
                Dim da As New MySqlDataAdapter(conslt, conex)
                da.SelectCommand.CommandType = CommandType.Text
                da.Fill(sc, "Abono")
                Dim rr As New Rpt_contado
                Dim cr As New abono
                cr.SetDataSource(sc)
                Dim txtcambio As TextObject
                Dim txtimporte As TextObject
                Dim num_ref As TextObject
                txtcambio = (cr.ReportDefinition.ReportObjects("cambio"))
                txtcambio.Text = lblcambio.Text
                txtimporte = (cr.ReportDefinition.ReportObjects("importe"))
                num_ref = (cr.ReportDefinition.ReportObjects("num_ref"))
                num_ref.Text = txtnumreferencia.Text
                If cmbtipomoneda.Text = "Dolar" Then
                    txtimporte.Text = txtmoneda.Text
                Else
                    txtimporte.Text = txtcantimporte.Text
                End If

                rr.CrystalReportViewer1.ReportSource = cr
                rr.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")

            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try


        Dim msg As Integer = MessageBox.Show("Deseas Registar Otro Pago", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then

            limpiar()
            dt.Reset()
            txtnumfact.Focus()
            cmbtipomoneda.Text = "Cordoba"
            cmbformapago.Text = "Efectivo"
            lblcantimporte.Visible = True
            txtcantimporte.Visible = True

        Else
            Me.Dispose()
        End If

    End Sub

    Private Sub txtcantimporte_TextChanged(sender As Object, e As EventArgs) Handles txtcantimporte.TextChanged
        If cmbtipomoneda.SelectedItem = "Cordoba" Then
            lblcambio.Text = Val(txtcantimporte.Text) - Val(txtcantidad.Text)
        ElseIf cmbtipomoneda.SelectedItem = "Dolar" Then
            Dim moneda As Double
            moneda = Val(txtcantimporte.Text) * Val(txttipocambio.Text)
            txtmoneda.Text = moneda.ToString
            lblcambio.Text = Val(txtmoneda.Text) - Val(txtcantidad.Text)
        End If
    End Sub

    Private Sub txttipocambio_TextChanged(sender As Object, e As EventArgs) Handles txttipocambio.TextChanged
        If cmbtipomoneda.SelectedItem = "Cordoba" Then
            lblcambio.Text = Val(txtcantimporte.Text) - Val(txtcantidad.Text)
        ElseIf cmbtipomoneda.SelectedItem = "Dolar" Then
            Dim moneda As Double
            moneda = Val(txtcantimporte.Text) * Val(txttipocambio.Text)
            txtmoneda.Text = moneda.ToString
            lblcambio.Text = Val(txtmoneda.Text) - Val(txtcantidad.Text)
        End If
    End Sub

    Private Sub cmbformapago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbformapago.SelectedIndexChanged

    End Sub

    Private Sub cmbformapago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbformapago.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbtipomoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbtipomoneda.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub abonos_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub txtnumfact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumfact.KeyPress
        e.Handled = validar_solo_Numeros(e, txtnumfact)
    End Sub

    Private Sub txtnumreferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumreferencia.KeyPress
        e.Handled = validar_solo_Numeros(e, txtnumreferencia)
    End Sub

    Private Sub txttipocambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttipocambio.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txttipocambio)
    End Sub

    Private Sub txtcantimporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantimporte.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txtcantimporte)
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txtcantidad)
    End Sub

    Private Sub txtrecibi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrecibi.KeyPress
        Letras(e, txtrecibi)
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged
        If cmbtipomoneda.SelectedItem = "Cordoba" Then
            lblcambio.Text = Val(txtcantimporte.Text) - Val(txtcantidad.Text)
        ElseIf cmbtipomoneda.SelectedItem = "Dolar" Then
            Dim moneda As Double
            moneda = Val(txtcantimporte.Text) * Val(txttipocambio.Text)
            txtmoneda.Text = moneda.ToString
            lblcambio.Text = Val(txtmoneda.Text) - Val(txtcantidad.Text)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub cmbformapago_TextChanged(sender As Object, e As EventArgs) Handles cmbformapago.TextChanged
        forma_pagos()
    End Sub

    Private Sub cmbtipomoneda_TextChanged(sender As Object, e As EventArgs) Handles cmbtipomoneda.TextChanged
        tipo_moneda()
    End Sub

    Private Sub abonos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        forma_pagos()
        tipo_moneda()
    End Sub
End Class