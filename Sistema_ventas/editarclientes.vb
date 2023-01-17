Imports System.Data
Imports MySql.Data.MySqlClient
Public Class editarclientes
    Dim dt2 As New DataTable
    Dim dt1 As New DataTable
    Dim dt As New DataTable
    Dim sql As String = ""
    '////////////////****************** Funcion para limpiar todos los campos del formulario******************////////////////
    Private Sub limpiar()
        Txtnom.Clear()
        txtap.Clear()
        Txtcedula.Clear()
        txttel.Clear()
        cmbtipotel.Text = ""
        txttel1.Clear()
        cmbtipotel1.Text = ""
        txtdir.Clear()
        cmbtipodir.Text = ""
        txtdir1.Clear()
        Cmbtipodir1.Text = ""
        CmbEstado.Text = ""
    End Sub
    '////////////////****************** Funcion para cargar los datos de los clientes******************////////////////
    Private Sub cargar_clientes()
        dt.Reset() 'vaciamos la tabla si contiene datos
        sql = "SELECT * FROM sist_ventas.clientes where cod_clientes='" + manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';" 'hacemos la consulta a la base de datos
        Try
            Dim da As New MySqlDataAdapter(sql, conex) ' abrimos conexion y ejecutamos la consulta 
            da.SelectCommand.CommandType = CommandType.Text 'captura los datos producidos de la consulta
            da.Fill(dt) 'llenamos la tabla
            conex.Close() 'cerramos la conexion
            DataGridView1.DataSource = dt '@Override
            Txtnom.Text = dt.Rows(0)(1) 'pasa el valor de la primera fila, segunda columna de la tabla al textbox nombre
            txtap.Text = dt.Rows(0)(2) 'pasa el valor de la primera fila, tercera columna de la tabla al textbox apellido
            Txtcedula.Text = dt.Rows(0)(3) 'pasa el valor de la primera fila, cuarta columna de la tabla al textbox N-Cedula
            CmbEstado.Text = dt.Rows(0)(4)
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub
    '/////////***** funcion para capturar los datos carrgados*******\\\\\\
    Private Sub capturar_datos()
        'captura los datos de localizacion
        lblcapdir1.Text = txtdir.Text.ToString
        lblcaptipodir1.Text = cmbtipodir.Text.ToString
        lblcapdir2.Text = txtdir1.Text.ToString
        lblcaptipodir2.Text = Cmbtipodir1.Text.ToString
        'captura los datos telefonicos
        lblcapnum1.Text = txttel.Text.ToString
        lblcaptipotel.Text = cmbtipotel.Text.ToString
        lblcapnum2.Text = txttel1.Text.ToString
        lblcaptipotel2.Text = cmbtipotel1.Text.ToString
    End Sub
    '////////////////****************** Funcion para cargar los datos de Localizzacion los clientes******************////////////////
    Private Sub cargar_dir_clientes()
        dt1.Reset()
        Dim sql As String = "SELECT * FROM sist_ventas.detalle_dir_cliente where cod_dir_cliente='" + manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(dt1)
            DataGridView2.DataSource = dt1
            If dt1.Rows.Count = 1 Then
                txtdir.Text = dt1.Rows(0)(1).ToString
                cmbtipodir.Text = dt1.Rows(0)(2).ToString
            ElseIf dt1.Rows.Count = 2 Then
                txtdir.Text = dt1.Rows(0)(1).ToString
                cmbtipodir.Text = dt1.Rows(0)(2).ToString
                txtdir1.Text = dt1.Rows(1)(1).ToString
                Cmbtipodir1.Text = dt1.Rows(1)(2).ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
    '////////////////****************** Funcion para cargar los datos Telefonicos de los clientes******************////////////////
    Private Sub cargar_tel_clientes()
        Dim sql As String = "SELECT * FROM sist_ventas.detalle_telefono_cliente where cod_tel_cliente='" + manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
        Try
            dt2.Reset()
            Dim da2 As New MySqlDataAdapter(sql, conex)
            da2.SelectCommand.CommandType = CommandType.Text
            da2.Fill(dt2)
            DataGridView3.DataSource = dt2
            If dt2.Rows.Count.Equals(1) Then
                txttel.Text = dt2.Rows(0)(1).ToString
                cmbtipotel.Text = dt2.Rows(0)(2).ToString
            ElseIf dt2.Rows.Count.Equals(2) Then
                txttel.Text = dt2.Rows(0)(1).ToString
                cmbtipotel.Text = dt2.Rows(0)(2).ToString
                txttel1.Text = dt2.Rows(1)(1).ToString
                cmbtipotel1.Text = dt2.Rows(1)(2).ToString
                cmbtipotel1.Text = dt2.Rows(1)(2).ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub editarclientes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        manejoclientes.Opacity += (Me.Opacity * 0.99)
    End Sub
    Private Sub editarclientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'al cerar el formulario

        manejoclientes.dt.Rows.Clear()
        manejoclientes.cargar_datos_clientes()
        manejoclientes.Update()

    End Sub
    Private Sub editarclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'al abrrir el formulario
        limpiar() 'limpiamos todo
        cargar_clientes() ' cargamos datos clientes
        cargar_dir_clientes()  ' cargamos datos localizacion de clientes'
        cargar_tel_clientes() ' cargamos datos telefonicos de clientes
        capturar_datos() 'capturamos los datos correspondientes
    End Sub
    Private Sub cmbtipotel_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cmbtipotel1_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cmbtipodir_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub Cmbtipodir1_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '/////********** Modifica los datos personales del cliente*********/////
        Dim Actualizar_clientes As String = " UPDATE `sist_ventas`.`clientes` SET `Nombre`='" & Txtnom.Text & "', `Apellido`='" & txtap.Text & "', `Cedula`='" & Txtcedula.Text & "',`estado`='" & CmbEstado.SelectedItem.ToString & "' WHERE `Cod_Clientes`='" + manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
        Try
            If consultas.funcion(Actualizar_clientes) = True Then 'llamamos a la funcion de ejecutar consultas,, si se logro ingresar los datos
                MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Information) ' se muestra el mensaje
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error") ' sino se muestra el error
        End Try
        '/////********** Modifica los datos Telefonicos del cliente*********/////
        If dt2.Rows.Count = 0 And Not txttel.Text = "" And Not cmbtipotel.Text = Nothing Then 'comparamos a ver si no hay valores en la tabla y el usuario ingreso datos en los campos
            Dim ingresar_tel As String = "INSERT INTO `sist_ventas`.`detalle_telefono_cliente` (`cod_tel_cliente`, `telefono`, `tipo`) VALUES ('" & manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString & "', '" & txttel.Text & "', '" & cmbtipotel.SelectedItem.ToString & "');"
            Try

                If consultas.funcion(ingresar_tel) = True Then
                    MsgBox("Datos telefonicos agregados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        ElseIf dt2.Rows.Count = 1 And Not txttel1.Text = "" And Not cmbtipotel1.Text = Nothing Then
            Dim ingresar_tel1 As String = "INSERT INTO `sist_ventas`.`detalle_telefono_cliente` (`cod_tel_cliente`, `telefono`, `tipo`) VALUES ('" & manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString & "', '" & txttel1.Text & "', '" & cmbtipotel1.SelectedItem.ToString & "');"
            Try
                If consultas.funcion(ingresar_tel1) = True Then
                    MsgBox("Datos telefonicos agregados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        ElseIf Not txttel1.Text = "" And Not cmbtipotel1.Text = Nothing Then
            Dim Actualizar_tel1 As String = " UPDATE `sist_ventas`.`detalle_telefono_cliente` SET `telefono`='" & txttel.Text & "',`tipo`='" & cmbtipotel.Text.ToString & "' WHERE `telefono`='" + lblcapnum1.Text + "' and `tipo`='" + lblcaptipotel.Text + "' and `cod_tel_cliente`='" + manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
            Dim Actualizar_tel2 As String = " UPDATE `sist_ventas`.`detalle_telefono_cliente` SET `telefono`='" & txttel1.Text & "',`tipo`='" & cmbtipotel1.Text.ToString & "' WHERE `telefono`='" + lblcapnum2.Text + "' and `tipo`='" + lblcaptipotel2.Text + "' and `cod_tel_cliente`='" + manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
            Try
                If consultas.funcion(Actualizar_tel1) = True Then
                    'MsgBox("Datos Modificados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
            Try
                If consultas.funcion(Actualizar_tel2) = True Then
                    'MsgBox("Datos de telefonicos Modificados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        Else
            Dim Actualizar_tel1 As String = " UPDATE `sist_ventas`.`detalle_telefono_cliente` SET `telefono`='" & txttel.Text & "',`tipo`='" & cmbtipotel.Text.ToString & "' WHERE `telefono`='" + lblcapnum1.Text + "' and `tipo`='" + lblcaptipotel.Text + "' and `cod_tel_cliente`='" + manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
            Try
                If consultas.funcion(Actualizar_tel1) = True Then
                    'MsgBox("Datos Modificados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If
        '/////********** Modifica los datos de localizacion del cliente*********/////

        If dt1.Rows.Count = 0 And Not txtdir.Text = "" And Not cmbtipodir.Text = Nothing Then
            Dim ingresar_dir As String = "INSERT INTO `sist_ventas`.`detalle_dir_cliente` (`cod_dir_cliente`, `direccion`, `tipo`) VALUES ('" & manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString & "', '" & txtdir.Text & "', '" & cmbtipodir.SelectedItem.ToString & "');"
            Try
                If consultas.funcion(ingresar_dir) = True Then
                    MsgBox("Datos localizacion agregados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        ElseIf dt1.Rows.Count = 1 And Not txtdir1.Text = "" And Not Cmbtipodir1.Text = Nothing Then
            Dim ingresar_dir1 As String = "INSERT INTO `sist_ventas`.`detalle_dir_cliente` (`cod_dir_cliente`, `direccion`, `tipo`) VALUES ('" & manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString & "', '" & txtdir1.Text & "', '" & Cmbtipodir1.SelectedItem.ToString & "');"
            Try
                If consultas.funcion(ingresar_dir1) = True Then
                    MsgBox("Datos de localizacion agregados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        ElseIf Not txtdir1.Text = "" And Not Cmbtipodir1.Text = Nothing Then
            Dim Actualizar_dir1 As String = " UPDATE `sist_ventas`.`detalle_dir_cliente` SET `direccion`='" & txtdir.Text & "',`tipo`='" & cmbtipodir.Text.ToString & "' WHERE `direccion`='" + lblcapdir1.Text + "' and `tipo`='" + lblcaptipodir1.Text + "' and `cod_dir_cliente`='" + manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
            Dim Actualizar_dir2 As String = " UPDATE `sist_ventas`.`detalle_dir_cliente` SET `direccion`='" & txtdir1.Text & "',`tipo`='" & Cmbtipodir1.Text.ToString & "' WHERE `direccion`='" + lblcapdir2.Text + "' and `tipo`='" + lblcaptipodir2.Text + "' and `cod_dir_cliente`='" + manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
            Try
                If consultas.funcion(Actualizar_dir1) = True Then
                    'MsgBox("Datos Modificados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
            Try
                If consultas.funcion(Actualizar_dir2) = True Then
                    'MsgBox("Datos de localizacion Modificados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        Else
            Dim Actualizar_dir1 As String = " UPDATE `sist_ventas`.`detalle_dir_cliente` SET `direccion`='" & txtdir.Text & "',`tipo`='" & cmbtipodir.Text.ToString & "' WHERE `direccion`='" + lblcapdir1.Text + "' and `tipo`='" + lblcaptipodir1.Text + "'and `cod_dir_cliente`='" + manejoclientes.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';"
            Try
                If consultas.funcion(Actualizar_dir1) = True Then
                    'MsgBox("Datos Modificados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If
        Me.Close()
        manejoclientes.DataGridView1.Refresh()
        manejoclientes.DataGridView1.Update()

    End Sub

    Private Sub Txtnom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnom.KeyPress
        Letras(e, Txtnom)
    End Sub

    Private Sub txtap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtap.KeyPress
        Letras(e, txtap)
    End Sub
    
    Private Sub txttel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel.KeyPress
        e.Handled = validar_Numeros_y_guion(e, txttel)
    End Sub

    Private Sub txttel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel1.KeyPress
        e.Handled = validar_Numeros_y_guion(e, txttel1)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub editarclientes_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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


    Private Sub CmbEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbtipotel1.KeyPress, cmbtipotel.KeyPress, Cmbtipodir1.KeyPress, cmbtipodir.KeyPress, CmbEstado.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtdir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdir.KeyPress

    End Sub
End Class