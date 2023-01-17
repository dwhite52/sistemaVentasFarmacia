Public Class clientes
    'Funcion para limpiar el los campos del formulario'
    Public Sub limpiar()
        txtnomb.Clear()
        txtapell.Clear()
        txtced.Clear()
        txtdir.Clear()
        txtdir1.Clear()
        txttel1.Clear()
        txtnumtel.Clear()
        'cmbtipodir.Text = Nothing
        'Cmbtipodir1.Text = Nothing
        'cmbtipotel.Text = Nothing
        'Cmbtipotel1.Text = Nothing
    End Sub
    'Validar si hay campos vacios al guardar'
    Function validar_vacio()
        If txtnomb.Text = "" Or txtapell.Text = "" Or txtced.Text = "" Or txtdir.Text = "" Or cmbtipodir.SelectedItem = Nothing Or txtnumtel.Text = "" Or cmbtipotel.SelectedItem = Nothing Then
            MsgBox("Porfavor Llene Todos los Campos Necesarios", MsgBoxStyle.Information)
            validar_vacio = True
            Exit Function
        Else
            validar_vacio = False
        End If
    End Function

    Private Sub clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'El sistema genera el codigo del cliente '
        txtcodcliente.Text = consultas.Generar_codigo_Cliente
        txtnomb.Focus()
    End Sub
    Private Sub Btntelagregar_Click_1(sender As Object, e As EventArgs) Handles Btntelagregar.Click
        Do Until pantel.Height > 174
            pantel.Height = pantel.Height + 2
        Loop
        Btntelagregar.Visible = False
        txttel1.Focus()
        Cmbtipotel1.Text = "CONVENCIONAL"
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Do Until pantel.Height < 96
            pantel.Height = pantel.Height - 2
        Loop
        Btntelagregar.Visible = True
        txttel1.Clear()
        Cmbtipotel1.Text = ""
    End Sub
    Private Sub Btndiragregar_Click_1(sender As Object, e As EventArgs) Handles Btndiragregar.Click
        Do Until Pandir.Height > 176
            Pandir.Height = Pandir.Height + 2
        Loop
        Btndiragregar.Visible = False
        txtdir1.Focus()
        Cmbtipodir1.Text = "TRABAJO"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Do Until Pandir.Height < 96
            Pandir.Height = Pandir.Height - 2
        Loop
        Btndiragregar.Visible = True
        txtdir1.Clear()
        Cmbtipodir1.Text = Nothing
    End Sub
    'Boton de guardar'
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validar_vacio() = True Then
            Exit Sub
        Else
            Dim ingresar As String = "INSERT INTO `sist_ventas`.`clientes` (`Cod_Clientes`, `Nombre`, `Apellido`, `Cedula`,`estado`) VALUES ('" & txtcodcliente.Text & "', '" & txtnomb.Text & "', '" & txtapell.Text & "', '" & txtced.Text & "','Activo');"
            Try
                If consultas.funcion(ingresar) = True Then
                    MsgBox("Datos ingresados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
            If Not txtdir1.Text = "" And Not Cmbtipodir1.Text = Nothing Then
                Dim ingresar_dir As String = "INSERT INTO `sist_ventas`.`detalle_dir_cliente` (`cod_dir_cliente`, `direccion`, `tipo`) VALUES ('" & txtcodcliente.Text & "', '" & txtdir.Text & "', '" & cmbtipodir.SelectedItem.ToString & "');"
                Dim ingresar_dir1 As String = "INSERT INTO `sist_ventas`.`detalle_dir_cliente` (`cod_dir_cliente`, `direccion`, `tipo`) VALUES ('" & txtcodcliente.Text & "', '" & txtdir1.Text & "', '" & Cmbtipodir1.SelectedItem.ToString & "');"
                Try
                    If consultas.funcion(ingresar_dir) = True Then
                        'MsgBox("Datos ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
                Try
                    If consultas.funcion(ingresar_dir1) = True Then
                        'MsgBox("Datos de localizacion ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            Else
                Dim ingresar_dir As String = "INSERT INTO `sist_ventas`.`detalle_dir_cliente` (`cod_dir_cliente`, `direccion`, `tipo`) VALUES ('" & txtcodcliente.Text & "', '" & txtdir.Text & "', '" & cmbtipodir.SelectedItem.ToString & "');"
                Try
                    If consultas.funcion(ingresar_dir) = True Then
                        'MsgBox("Datos de localizacion ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
            If Not txttel1.Text = "" And Not Cmbtipotel1.Text = Nothing Then
                Dim ingresar_tel As String = "INSERT INTO `sist_ventas`.`detalle_telefono_cliente` (`cod_tel_cliente`, `telefono`, `tipo`) VALUES ('" & txtcodcliente.Text & "', '" & txtnumtel.Text & "', '" & cmbtipotel.SelectedItem.ToString & "');"
                Dim ingresar_tel1 As String = "INSERT INTO `sist_ventas`.`detalle_telefono_cliente` (`cod_tel_cliente`, `telefono`, `tipo`) VALUES ('" & txtcodcliente.Text & "', '" & txttel1.Text & "', '" & Cmbtipotel1.SelectedItem.ToString & "');"
                Try
                    If consultas.funcion(ingresar_tel) = True Then
                        'MsgBox("Datos telefonicos ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
                Try
                    If consultas.funcion(ingresar_tel1) = True Then
                        'MsgBox("Datos telefonicos ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            Else
                Dim ingresar_tel As String = "INSERT INTO `sist_ventas`.`detalle_telefono_cliente` (`cod_tel_cliente`, `telefono`, `tipo`) VALUES ('" & txtcodcliente.Text & "', '" & txtnumtel.Text & "', '" & cmbtipotel.SelectedItem.ToString & "');"
                Try
                    If consultas.funcion(ingresar_tel) = True Then
                        'MsgBox("Datos telefonicos ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
            Dim msg As Integer = MessageBox.Show("Deseas Registar Otro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = DialogResult.Yes Then
                Me.Dispose()
                Frm_Principal.NUEVOToolStripMenuItem().PerformClick()
            Else
                Me.Dispose()
            End If
        End If
    End Sub
    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles Btncancelar.Click
        Dim msg As Integer = MessageBox.Show("Deseas Cancelar el Registro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            limpiar()
            Me.Dispose()
        End If
    End Sub

    Private Sub txtnomb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomb.KeyPress
        Letras(e, txtnomb)
    End Sub
    Private Sub txtapell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapell.KeyPress
        Letras(e, txtapell)
    End Sub
    
    Private Sub txtnumtel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnumtel.KeyPress
        e.Handled = validar_Numeros_y_guion(e, txtnumtel)
    End Sub
    Private Sub txttel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel1.KeyPress
        e.Handled = validar_Numeros_y_guion(e, txttel1)
    End Sub

    Private Sub cmbtipotel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbtipotel.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbtipodir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbtipodir.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cmbtipotel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmbtipotel1.KeyPress
        e.Handled = True
    End Sub

    Private Sub Cmbtipodir1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmbtipodir1.KeyPress
        e.Handled = True
    End Sub

    Private Sub clientes_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
    End Property

    Private Sub txtnomb_TextChanged(sender As Object, e As EventArgs) Handles txtnomb.TextChanged
       
    End Sub 'CreateParams


End Class