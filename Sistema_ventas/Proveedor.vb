Public Class Proveedor
    Public Sub limpiar()
        txtnomb.Clear()
        txtapell.Clear()
        txtnomcom.Clear()
        txtdir.Clear()
        txtdir1.Clear()
        txttel1.Clear()
        Txttel.Clear()
        txtcorreo.Clear()
        Txtcoreo2.Clear()
        cmbtipodir.Text = Nothing
        Cmbtipodir1.Text = Nothing
        cmbtipotel.Text = Nothing
        Cmbtipotel1.Text = Nothing
        cmbtipocorreo.Text = Nothing
        Cmbtipocoreo2.Text = Nothing
    End Sub
    Function validar_vacio()
        If txtnomb.Text = "" Or txtapell.Text = "" Or txtcorreo.Text = "" Or txtdir.Text = "" Or cmbtipodir.SelectedItem = Nothing Or Txttel.Text = "" Or Cmbtipotel.SelectedItem = Nothing Or cmbtipocorreo.SelectedItem = Nothing Then
            MsgBox("Porfavor Llene Todos los Campos Necesarios", MsgBoxStyle.Information)
            validar_vacio = True

        Else
            validar_vacio = False
        End If
    End Function

    Private Sub Proveedor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Proveedor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Proveedor_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        txtcodprov.Text = consultas.Generar_codigo_Proveedor
        txtnomb.Focus()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Do Until Pandir.Height < 88
            Pandir.Height = Pandir.Height - 1
        Loop
        Btndiragregar.Visible = True
        txtdir1.Clear()
        Cmbtipodir1.Text = Nothing
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Do Until pantel.Height < 96
            pantel.Height = pantel.Height - 1
        Loop
        btnagregartel.Visible = True
        txttel1.Clear()
        Cmbtipotel1.Text = ""
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Do Until Panemail.Height < 86
            Panemail.Height = Panemail.Height - 1
        Loop
        Btnagregaremail.Visible = True
        Txtcoreo2.Clear()
        Cmbtipocoreo2.Text = Nothing
    End Sub
    Private Sub btnagregartel_Click(sender As Object, e As EventArgs) Handles btnagregartel.Click
        Do Until pantel.Height > 174
            pantel.Height = pantel.Height + 1
        Loop
        btnagregartel.Visible = False

        txttel1.Focus()
        Cmbtipotel1.Text = "CONVENCIONAL"
       
    End Sub

    Private Sub Btndiragregar_Click_1(sender As Object, e As EventArgs) Handles Btndiragregar.Click
        Do Until Pandir.Height > 182
            Pandir.Height = Pandir.Height + 2
        Loop
        Btndiragregar.Visible = False
        txtdir1.Focus()
        Cmbtipodir1.Text = "TRABAJO"
    End Sub

    Private Sub Btnagregaremail_Click(sender As Object, e As EventArgs) Handles Btnagregaremail.Click
        Do Until Panemail.Height > 171
            Panemail.Height = Panemail.Height + 2
        Loop
        Btnagregaremail.Visible = False
        Txtcoreo2.Focus()
        Cmbtipocoreo2.Text = "INSTITUCIONAL"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If validar_vacio() = True Then
            Exit Sub
        Else
            Dim ingresar As String = "INSERT INTO `sist_ventas`.`proveedor` (`cod_proveedor`, `nombres`, `apellidos`, `nombre_comercial`) VALUES ('" & txtcodprov.Text & "', '" & txtnomb.Text & "', '" & txtapell.Text & "', '" & txtnomcom.Text & "');"
            Try

                If consultas.funcion(ingresar) = True Then
                    MsgBox("Datos ingresados Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")

            End Try
            If Not txtdir1.Text = "" And Not Cmbtipodir1.Text = Nothing Then

                Dim ingresar_dir As String = "INSERT INTO `sist_ventas`.`detalle_dir_prov` (`cod_dir_prov`, `direccion`, `tipo`)VALUES('" & txtcodprov.Text & "', '" & txtdir.Text & "', '" & cmbtipodir.SelectedItem.ToString & "');"

                Dim ingresar_dir1 As String = "INSERT INTO `sist_ventas`.`detalle_dir_prov` (`cod_dir_prov`, `direccion`, `tipo`) VALUES ('" & txtcodprov.Text & "', '" & txtdir1.Text & "', '" & Cmbtipodir1.SelectedItem.ToString & "');"
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

                Dim ingresar_dir As String = "INSERT INTO `sist_ventas`.`detalle_dir_prov` (`cod_dir_prov`, `direccion`, `tipo`)VALUES('" & txtcodprov.Text & "', '" & txtdir.Text & "', '" & cmbtipodir.SelectedItem.ToString & "');"
                Try

                    If consultas.funcion(ingresar_dir) = True Then
                        'MsgBox("Datos de localizacion ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")

                End Try
            End If
            If Not txttel1.Text = "" And Not Cmbtipotel1.Text = Nothing Then
                Dim ingresar_tel As String = "INSERT INTO `sist_ventas`.`detalle_telefono_prov` (`cod_telefono_prov`, `telefono`, `tipo`) VALUES ('" & txtcodprov.Text & "', '" & Txttel.Text & "', '" & Cmbtipotel.SelectedItem.ToString & "');"
                Dim ingresar_tel1 As String = "INSERT INTO `sist_ventas`.`detalle_telefono_prov` (`cod_telefono_prov`, `telefono`, `tipo`) VALUES ('" & txtcodprov.Text & "', '" & txttel1.Text & "', '" & Cmbtipotel1.SelectedItem.ToString & "');"
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
                Dim ingresar_tel As String = "INSERT INTO `sist_ventas`.`detalle_telefono_prov` (`cod_telefono_prov`, `telefono`, `tipo`) VALUES ('" & txtcodprov.Text & "', '" & Txttel.Text & "', '" & Cmbtipotel.SelectedItem.ToString & "');"
                Try
                    If consultas.funcion(ingresar_tel) = True Then
                        'MsgBox("Datos telefonicos ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
            If Not Txtcoreo2.Text = "" And Not Cmbtipocoreo2.Text = Nothing Then
                Dim ingresar_cor As String = "INSERT INTO `sist_ventas`.`detalle_email_prov` (`cod_email_prov`, `email`, `tipo`) VALUES ('" & txtcodprov.Text & "', '" & txtcorreo.Text & "', '" & cmbtipocorreo.SelectedItem.ToString & "');"
                Dim ingresar_cor1 As String = "INSERT INTO `sist_ventas`.`detalle_email_prov` (`cod_email_prov`, `email`, `tipo`) VALUES ('" & txtcodprov.Text & "', '" & Txtcoreo2.Text & "', '" & Cmbtipocoreo2.SelectedItem.ToString & "');"
                Try
                    If consultas.funcion(ingresar_cor) = True Then
                        'MsgBox("Datos telefonicos ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
                Try
                    If consultas.funcion(ingresar_cor1) = True Then
                        'MsgBox("Datos telefonicos ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            Else
                Dim ingresar_cor As String = "INSERT INTO `sist_ventas`.`detalle_email_prov` (`cod_email_prov`, `email`, `tipo`) VALUES ('" & txtcodprov.Text & "', '" & txtcorreo.Text & "', '" & cmbtipocorreo.SelectedItem.ToString & "');"
                Try
                    If consultas.funcion(ingresar_cor) = True Then
                        'MsgBox("Datos telefonicos ingresados Correctamente", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
            Dim msg As Integer = MessageBox.Show("Deseas Registar Otro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = DialogResult.Yes Then
                Me.Dispose()
                Frm_Principal.NUEVOToolStripMenuItem1().PerformClick()
            Else
                Me.Dispose()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As Integer = MessageBox.Show("Deseas Cancelar el Registro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            limpiar()
            Me.Dispose()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Proveedor_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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


    Private Sub txtnomb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnomb.KeyPress
        Letras(e, txtnomb)
    End Sub

    Private Sub txtapell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapell.KeyPress
        Letras(e, txtapell)
    End Sub

    Private Sub txtcorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcorreo.KeyPress

    End Sub

    Private Sub Txttel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txttel.KeyPress
        e.Handled = validar_Numeros_y_guion(e, Txttel)
    End Sub

    Private Sub txttel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttel1.KeyPress
        e.Handled = validar_Numeros_y_guion(e, txttel1)
    End Sub

    Private Sub Cmbtipotel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmbtipotel1.KeyPress, Cmbtipotel.KeyPress, Cmbtipodir1.KeyPress, cmbtipodir.KeyPress, cmbtipocorreo.KeyPress, Cmbtipocoreo2.KeyPress
        e.Handled = True
    End Sub
End Class