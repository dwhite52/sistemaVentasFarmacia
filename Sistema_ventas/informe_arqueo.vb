Imports MySql.Data.MySqlClient
Public Class informe_arqueo

    Public Sub cargar_usuario()
        Dim sql As String = "SELECT * from sist_ventas.arqueo where fecha = '" + Date_informe_gastos.Value.ToString("yyyy-M-d") + "' and arqueo.Usuario='" + Login.user + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            dt1.Reset()
            da.Fill(dt1)

            DataGrid_info_gastos.DataSource = dt1
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub
    Public Sub cargar_admin()
        Dim sql As String = "SELECT * from sist_ventas.arqueo where fecha = '" + Date_informe_gastos.Value.ToString("yyyy-M-d") + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            dt1.Reset()
            da.Fill(dt1)

            DataGrid_info_gastos.DataSource = dt1
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub informe_arqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Principal.tipo = "Administrador" Then
            Chktodo.Visible = True
        Else
            Chktodo.Visible = False
        End If
    End Sub

    Private Sub informe_arqueo_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
    Dim dt1 As New DataTable
    Private Sub Btnver_Click(sender As Object, e As EventArgs) Handles Btnver.Click
        cargar_usuario()
    End Sub

    Private Sub Chktodo_CheckedChanged(sender As Object, e As EventArgs) Handles Chktodo.CheckedChanged
        If Chktodo.Checked = True Then
            cargar_admin()
        Else
            Btnver.PerformClick()
        End If
    End Sub
End Class