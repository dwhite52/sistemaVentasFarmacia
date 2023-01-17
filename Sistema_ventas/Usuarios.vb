Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Usuarios
    Public dt As DataTable

    Public Sub cargar_usuario()
        Dim sql As String = "SELECT Usuario as Nombre_Usuario, pass as Contraseña,tipo as Tipo FROM sist_ventas.login; "
        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            With DataGridView1
                .Columns(0).Width = 230
                .Columns(1).Width = 230
                .Columns(2).Width = 250
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
    Private Sub btnagregarr_Click(sender As Object, e As EventArgs) Handles btnagregarr.Click
        Me.Opacity -= (Me.Opacity * 0.99)
        Dim agu As New agregar_usuario
        agu.ShowDialog()


    End Sub

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargar_usuario()
    End Sub

    Private Sub Usuarios_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        If DataGridView1.CurrentRow.Cells(0).Value.ToString = "admin" And DataGridView1.CurrentRow.Cells(2).Value.ToString = "Administrador" Then
            MsgBox("No Se puede eliminar el Usuario", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Dim msg As Integer = MessageBox.Show("Deseas Eliminar el Registro", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If msg = DialogResult.Yes Then
                Dim ELIMINAR As String = " DELETE FROM `sist_ventas`.`login` WHERE `Usuario`='" + DataGridView1.CurrentRow.Cells(0).Value.ToString + "' and pass='" + DataGridView1.CurrentRow.Cells(1).Value.ToString + "';"
                Try
                    If consultas.funcion(ELIMINAR) = True Then
                        MsgBox("Registro Eliminado", MsgBoxStyle.Information)
                        DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error")
                End Try
            End If
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Update()
        DataGridView1.DataSource = dt
        With DataGridView1
            .Columns(0).Width = 230
            .Columns(1).Width = 230
            .Columns(2).Width = 250
        End With
    End Sub

    Private Sub btnmodificar_seleccion_Click(sender As Object, e As EventArgs) Handles btnmodificar_seleccion.Click
        If DataGridView1.Rows.Count <= 0 Then
            MsgBox("Porfavor Seleccione un Registro", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            Me.Opacity -= (Me.Opacity * 0.99)
            Dim eu As New Editar_usuario
            eu.ShowDialog()

        End If

     
    End Sub
End Class