Public Class Capital_caja

    Private Sub Arqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Por favor Ingrese el Capital Inicial de Caja", MsgBoxStyle.Information)
    End Sub

    Private Sub Arqueo_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Txtcantidad.Text = "" Then
            MsgBox("Por favor llene todos los campos necesarios", MsgBoxStyle.Information)
            Exit Sub
        Else
            Dim Agregar As String = "INSERT INTO `sist_ventas`.`capital_caja` (`Cantidad`, `fecha`, `Usuario`) VALUES ('" & Txtcantidad.Text & "', '" & date_capital.Value.ToString("yyyy-M-d") & "','" + Login.user + "' );"
            Try
                If consultas.funcion(Agregar) = True Then
                    MsgBox("Capital Registrado Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcantidad.KeyPress
        e.Handled = validar_Numeros_y_punto(e, Txtcantidad)
    End Sub

    Private Sub Txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles Txtcantidad.TextChanged

    End Sub
End Class