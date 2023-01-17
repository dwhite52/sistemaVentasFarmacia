
Public Class agregar_usuario
    Public Sub limpiar()
        txtnom_usuario.Clear()
        txtpass.Clear()
        txtconfpass.Clear()
        cmbtipousuario.Text = ""
        txtpass.BackColor = Color.White
        txtconfpass.BackColor = Color.White
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtconfpass.Text = "" Or txtnom_usuario.Text = "" Or txtpass.Text = "" Then
            MsgBox("Por favor llene todos los campos necesarios", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtpass.Text = txtconfpass.Text Then
            Dim Agregar As String = "INSERT INTO `sist_ventas`.`login` (`Usuario`, `pass`, `tipo`) VALUES ('" & txtnom_usuario.Text & "', '" & txtpass.Text & "', '" & cmbtipousuario.Text.ToString & "');"
            Try
                If consultas.funcion(Agregar) = True Then
                    MsgBox("Usuario Agregado Correctamente", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
            Dim msg As Integer = MessageBox.Show("Deseas Registar Otro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = DialogResult.Yes Then
                limpiar()
                txtnom_usuario.Focus()
            Else
                Me.Close()
                Usuarios.Show()
            End If
        Else
            MsgBox(" Error", MsgBoxStyle.Critical)
            txtpass.BackColor = Color.Tomato
            txtconfpass.BackColor = Color.Tomato
            txtpass.Focus()
        End If
    End Sub

    Private Sub Btncancelar_Click(sender As Object, e As EventArgs) Handles Btncancelar.Click
        Dim msg As Integer = MessageBox.Show("Deseas Salir", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            limpiar()

        Else

        End If
    End Sub

    Private Sub agregar_usuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Usuarios.Opacity += (Me.Opacity * 0.99)
    End Sub

    Private Sub agregar_usuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Usuarios.dt.Rows.Clear()
        Usuarios.cargar_usuario()
        Usuarios.Update()


    End Sub

    Private Sub agregar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbtipousuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbtipousuario.KeyPress
        e.Handled = True
    End Sub

    Private Sub agregar_usuario_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub txtnom_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnom_usuario.KeyPress
        Letras(e, txtnom_usuario)
    End Sub
End Class