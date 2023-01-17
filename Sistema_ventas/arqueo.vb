Public Class arqueo

    Function validar_vacio()
        If txtmil.Text = "" Or Txtquinientos.Text = "" Or Txtdoscientos.Text = "" Or Txtcien.Text = "" Or Txtcincuenta.Text = "" Or Txtveinte.Text = "" Or Txtdiez.Text = "" Or Txtcinco.Text = "" Or Txtuno.Text = "" Or Txtentrega_admin.Text = "" Then
            MsgBox("Porfavor Llene Todos los Campos Necesarios", MsgBoxStyle.Information)
            validar_vacio = True

        Else
            validar_vacio = False
        End If
    End Function

    Private Sub txtmil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmil.KeyPress
        e.Handled = validar_Numeros_y_punto(e, txtmil)
    End Sub

    Private Sub txtcnom_TextChanged(sender As Object, e As EventArgs) Handles txtmil.TextChanged
        Lblresultadomil.Text = Val(txtmil.Text) * 1000
        Lblgtotal.Text = Val(Lblresultadomil.Text) + Val(Lblresultadoquinientos.Text) + Val(Lblresultadodoscientos.Text) + Val(Lblresultadocien.Text) + Val(Lblresultadocincuenta.Text) + Val(lblresultadoveinte.Text) + Val(Lblresultadodiez.Text) + Val(Lblresultadocinco.Text) + Val(Lblresultadouno.Text) + Val(lbltotaldolar.Text)
    End Sub

    Private Sub Txtquinientos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtquinientos.KeyPress
        e.Handled = validar_Numeros_y_punto(e, Txtquinientos)
    End Sub

    Private Sub Texquinientos_TextChanged(sender As Object, e As EventArgs) Handles Txtquinientos.TextChanged
        Lblresultadoquinientos.Text = Val(Txtquinientos.Text) * 500
        Lblgtotal.Text = Val(Lblresultadomil.Text) + Val(Lblresultadoquinientos.Text) + Val(Lblresultadodoscientos.Text) + Val(Lblresultadocien.Text) + Val(Lblresultadocincuenta.Text) + Val(lblresultadoveinte.Text) + Val(Lblresultadodiez.Text) + Val(Lblresultadocinco.Text) + Val(Lblresultadouno.Text) + Val(lbltotaldolar.Text)
    End Sub

    Private Sub Txtdoscientos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdoscientos.KeyPress
        e.Handled = validar_Numeros_y_punto(e, Txtdoscientos)
    End Sub

    Private Sub Txtdoscientos_TextChanged(sender As Object, e As EventArgs) Handles Txtdoscientos.TextChanged
        Lblresultadodoscientos.Text = Val(Txtdoscientos.Text) * 200
        Lblgtotal.Text = Val(Lblresultadomil.Text) + Val(Lblresultadoquinientos.Text) + Val(Lblresultadodoscientos.Text) + Val(Lblresultadocien.Text) + Val(Lblresultadocincuenta.Text) + Val(lblresultadoveinte.Text) + Val(Lblresultadodiez.Text) + Val(Lblresultadocinco.Text) + Val(Lblresultadouno.Text) + Val(lbltotaldolar.Text)
    End Sub

    Private Sub Txtcien_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcien.KeyPress
        e.Handled = validar_Numeros_y_punto(e, Txtcien)
    End Sub

    Private Sub Txtcien_TextChanged(sender As Object, e As EventArgs) Handles Txtcien.TextChanged
        Lblresultadocien.Text = Val(Txtcien.Text) * 100
        Lblgtotal.Text = Val(Lblresultadomil.Text) + Val(Lblresultadoquinientos.Text) + Val(Lblresultadodoscientos.Text) + Val(Lblresultadocien.Text) + Val(Lblresultadocincuenta.Text) + Val(lblresultadoveinte.Text) + Val(Lblresultadodiez.Text) + Val(Lblresultadocinco.Text) + Val(Lblresultadouno.Text) + Val(lbltotaldolar.Text)
    End Sub

    Private Sub Txtcincuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcincuenta.KeyPress
        e.Handled = validar_Numeros_y_punto(e, Txtcincuenta)
    End Sub

    Private Sub Txtcincuenta_TextChanged(sender As Object, e As EventArgs) Handles Txtcincuenta.TextChanged
        Lblresultadocincuenta.Text = Val(Txtcincuenta.Text) * 50
        Lblgtotal.Text = Val(Lblresultadomil.Text) + Val(Lblresultadoquinientos.Text) + Val(Lblresultadodoscientos.Text) + Val(Lblresultadocien.Text) + Val(Lblresultadocincuenta.Text) + Val(lblresultadoveinte.Text) + Val(Lblresultadodiez.Text) + Val(Lblresultadocinco.Text) + Val(Lblresultadouno.Text) + Val(lbltotaldolar.Text)
    End Sub

    Private Sub Txtveinte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtveinte.KeyPress
        e.Handled = validar_Numeros_y_punto(e, Txtveinte)
    End Sub

    Private Sub Txtveinte_TextChanged(sender As Object, e As EventArgs) Handles Txtveinte.TextChanged
        lblresultadoveinte.Text = Val(Txtveinte.Text) * 20
        Lblgtotal.Text = Val(Lblresultadomil.Text) + Val(Lblresultadoquinientos.Text) + Val(Lblresultadodoscientos.Text) + Val(Lblresultadocien.Text) + Val(Lblresultadocincuenta.Text) + Val(lblresultadoveinte.Text) + Val(Lblresultadodiez.Text) + Val(Lblresultadocinco.Text) + Val(Lblresultadouno.Text) + Val(lbltotaldolar.Text)
    End Sub

    Private Sub Txtdiez_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtdiez.KeyPress
        e.Handled = validar_Numeros_y_punto(e, Txtdiez)
    End Sub

    Private Sub Txtdiez_TextChanged(sender As Object, e As EventArgs) Handles Txtdiez.TextChanged
        Lblresultadodiez.Text = Val(Txtdiez.Text) * 10
        Lblgtotal.Text = Val(Lblresultadomil.Text) + Val(Lblresultadoquinientos.Text) + Val(Lblresultadodoscientos.Text) + Val(Lblresultadocien.Text) + Val(Lblresultadocincuenta.Text) + Val(lblresultadoveinte.Text) + Val(Lblresultadodiez.Text) + Val(Lblresultadocinco.Text) + Val(Lblresultadouno.Text) + Val(lbltotaldolar.Text)
    End Sub

    Private Sub Txtcinco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcinco.KeyPress
        e.Handled = validar_Numeros_y_punto(e, Txtcinco)
    End Sub

    Private Sub Txtcinco_TextChanged(sender As Object, e As EventArgs) Handles Txtcinco.TextChanged
        Lblresultadocinco.Text = Val(Txtcinco.Text) * 5
        Lblgtotal.Text = Val(Lblresultadomil.Text) + Val(Lblresultadoquinientos.Text) + Val(Lblresultadodoscientos.Text) + Val(Lblresultadocien.Text) + Val(Lblresultadocincuenta.Text) + Val(lblresultadoveinte.Text) + Val(Lblresultadodiez.Text) + Val(Lblresultadocinco.Text) + Val(Lblresultadouno.Text) + Val(lbltotaldolar.Text)
    End Sub

    Private Sub Txtuno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtuno.KeyPress
        e.Handled = validar_Numeros_y_punto(e, Txtuno)
    End Sub

    Private Sub Txtuno_TextChanged(sender As Object, e As EventArgs) Handles Txtuno.TextChanged
        Lblresultadouno.Text = Val(Txtuno.Text) * 1
        Lblgtotal.Text = Val(Lblresultadomil.Text) + Val(Lblresultadoquinientos.Text) + Val(Lblresultadodoscientos.Text) + Val(Lblresultadocien.Text) + Val(Lblresultadocincuenta.Text) + Val(lblresultadoveinte.Text) + Val(Lblresultadodiez.Text) + Val(Lblresultadocinco.Text) + Val(Lblresultadouno.Text) + Val(lbltotaldolar.Text)
    End Sub

    Private Sub arqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmil.Text = "0"
        Txtquinientos.Text = "0"
        Txtdoscientos.Text = "0"
        Txtcien.Text = "0"
        Txtcincuenta.Text = "0"
        Txtveinte.Text = "0"
        Txtdiez.Text = "0"
        Txtcinco.Text = "0"
        Txtuno.Text = "0"
        lbltotaldolar.Text = "0"
        Lblgtotal.Text = "0"
        Txtentrega_admin.Text = "0"
        Lblsldcaja.Text = "0"
    End Sub

    Private Sub arqueo_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim msg As Integer = MessageBox.Show(" Estas Seguro de Guardar Registro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then


            If validar_vacio() = True Then
                MsgBox("Campos Vacio, Favor Ingrese 0", MsgBoxStyle.Exclamation)
                Exit Sub

            Else
                Dim ingresar As String = " INSERT INTO `sist_ventas`.`arqueo` (`uno`, `cinco`, `diez`, `viente`, `cincuenta`, `cien`, `doscientos`, `quinientos`, `mil`,`total`,`fecha`,`entrega_admin`,`sldcaja`,`cantidad_dolar`, `tipo_cambio`, `total_conversion`, `Usuario`) VALUES ('" & Txtuno.Text & "', '" & Txtcinco.Text & "', '" & Txtdiez.Text & "', '" & Txtveinte.Text & "', '" & Txtcincuenta.Text & "', '" & Txtcien.Text & "', '" & Txtdoscientos.Text & "', '" & Txtquinientos.Text & "', '" & txtmil.Text & "','" & Lblgtotal.Text.ToString() & "','" & date_egreso.Value.ToString("yyyy-M-d") & "','" & Txtentrega_admin.Text & "','" & Lblsldcaja.Text.ToString() & "','" & Txtcantidaddolar.Text & "','" & txttipodecambio.Text & "','" & lblTotalcor.Text.ToString & "', '" + Login.user + "');"
                Try

                    If consultas.funcion(ingresar) = True Then
                        MsgBox("Datos ingresados Correctamente", MsgBoxStyle.Information)
                        MsgBox("THANK YOU JESUS!", MsgBoxStyle.Information)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")

                End Try


            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Txtentrega_admin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtentrega_admin.KeyPress
        e.Handled = validar_Numeros_y_punto(e, Txtentrega_admin)
    End Sub

    Private Sub Txtentrega_admin_TextChanged(sender As Object, e As EventArgs) Handles Txtentrega_admin.TextChanged
        Lblsldcaja.Text = Val(Lblgtotal.Text) - Val(Txtentrega_admin.Text)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        dolar.Show()
    End Sub

    Private Sub lbltotaldolar_TextChanged(sender As Object, e As EventArgs) Handles lbltotaldolar.TextChanged
        Lblgtotal.Text = Val(Lblresultadomil.Text) + Val(Lblresultadoquinientos.Text) + Val(Lblresultadodoscientos.Text) + Val(Lblresultadocien.Text) + Val(Lblresultadocincuenta.Text) + Val(lblresultadoveinte.Text) + Val(Lblresultadodiez.Text) + Val(Lblresultadocinco.Text) + Val(Lblresultadouno.Text) + Val(lbltotaldolar.Text)

    End Sub
End Class