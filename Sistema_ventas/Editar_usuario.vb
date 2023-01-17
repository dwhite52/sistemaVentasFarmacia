Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Editar_usuario
    Public Sub limpiar()
        txtnom_usuario.Clear()
        txtpass.Clear()
        txtconfpass.Clear()
        cmbtipousuario.Text = ""
        txtpass.BackColor = Color.White
        txtconfpass.BackColor = Color.White
    End Sub
    Private Sub cargar_usuario()
        tabla.Reset() 'vaciamos la tabla si contiene datos
        Dim Sql As String = "SELECT * FROM sist_ventas.login where usuario='" + Usuarios.DataGridView1.CurrentRow.Cells(0).Value.ToString + "'and pass='" + Usuarios.DataGridView1.CurrentRow.Cells(1).Value.ToString + "';" 'hacemos la consulta a la base de datos
        Try
            Dim da As New MySqlDataAdapter(Sql, conex) ' abrimos conexion y ejecutamos la consulta 
            da.SelectCommand.CommandType = CommandType.Text 'captura los datos producidos de la consulta
            da.Fill(tabla) 'llenamos la tabla
            conex.Close() 'cerramos la conexion

            txtnom_usuario.Text = tabla.Rows(0)(0) 'pasa el valor de la primera fila, segunda columna de la tabla al textbox nombre
            txtpass.Text = tabla.Rows(0)(1) 'pasa el valor de la primera fila, tercera columna de la tabla al textbox apellido
            txtconfpass.Text = tabla.Rows(0)(1) 'pasa el valor de la primera fila, cuarta columna de la tabla al textbox N-Cedula
            cmbtipousuario.Text = tabla.Rows(0)(2)
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub

    Private Sub Editar_usuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Usuarios.Opacity += (Me.Opacity * 0.99)
    End Sub

    Private Sub Editar_usuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Usuarios.dt.Rows.Clear()
        Usuarios.cargar_usuario()
        Usuarios.Update()
    End Sub

    Private Sub Editar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_usuario()
    End Sub

    Private Sub Editar_usuario_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtconfpass.Text = "" Or txtnom_usuario.Text = "" Or txtpass.Text = "" Then
            MsgBox("Por favor llene todos los campos necesarios", MsgBoxStyle.Information)
            Exit Sub
        End If
        '/////********** Modifica los datos personales del usuario*********/////
        If txtpass.Text = txtconfpass.Text Then
            Dim Actualizar_usuario As String = " UPDATE `sist_ventas`.`login` SET `usuario`='" & txtnom_usuario.Text & "', `pass`='" & txtpass.Text & "',`tipo`='" & cmbtipousuario.SelectedItem.ToString & "' WHERE `usuario`='" + Usuarios.DataGridView1.CurrentRow.Cells(0).Value.ToString + "' and pass='" + Usuarios.DataGridView1.CurrentRow.Cells(1).Value.ToString + "' ;"
            Try
                If consultas.funcion(Actualizar_usuario) = True Then 'llamamos a la funcion de ejecutar consultas,, si se logro ingresar los datos
                    MsgBox("Datos Actualizados Correctamente", MsgBoxStyle.Information) ' se muestra el mensaje
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error") ' sino se muestra el error
            End Try
        Else
            MsgBox(" Error", MsgBoxStyle.Critical)
            txtpass.BackColor = Color.Tomato
            txtconfpass.BackColor = Color.Tomato
            txtpass.Focus()
        End If
    End Sub

    
    Private Sub txtnom_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnom_usuario.KeyPress
        Letras(e, txtnom_usuario)
    End Sub

    Private Sub cmbtipousuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbtipousuario.KeyPress
        e.Handled = True
    End Sub
End Class