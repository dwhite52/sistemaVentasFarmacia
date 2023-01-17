Imports MySql.Data.MySqlClient

Public Class Informe_Gastos
    Dim dt1 As New DataTable

    Public Sub Cargar_hoy()
        Dim sql As String = "SELECT Descripcion, cantidad, fecha from sist_ventas.Egresos where fecha='" + Date.Now.ToString("yyyy-M-d") + "' and egresos.Usuario='" + Login.user + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            dt1.Reset()
            da.Fill(dt1)

            DataGrid_info_gastos.DataSource = dt1
            With DataGrid_info_gastos
                .Columns(0).Width = 210
                .Columns(1).Width = 150
            End With
            Dim suma As Double
            For i = 0 To DataGrid_info_gastos.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGrid_info_gastos.Rows(i).Cells(1).Value)
            Next
            Lbltotal.Text = suma.ToString
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub
    Public Sub cargar_rango()
        Dim sql As String = "SELECT Descripcion, cantidad, fecha from sist_ventas.Egresos where fecha between '" + Date_informe_gastos.Value.ToString("yyyy-M-d") + "' and '" + Dateal.Value.ToString("yyyy-M-d") + "' and egresos.Usuario='" + Login.user + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            dt1.Reset()
            da.Fill(dt1)

            DataGrid_info_gastos.DataSource = dt1
            With DataGrid_info_gastos
                .Columns(0).Width = 210
                .Columns(1).Width = 150
            End With

            Dim suma As Double
            For i = 0 To DataGrid_info_gastos.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGrid_info_gastos.Rows(i).Cells(1).Value)
            Next
            Lbltotal.Text = suma.ToString
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub
    Public Sub cargar_hoy_admin()
        Dim sql As String = "SELECT Descripcion, cantidad, fecha, Usuario from sist_ventas.Egresos where fecha='" + Date.Now.ToString("yyyy-M-d") + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            dt1.Reset()
            da.Fill(dt1)

            DataGrid_info_gastos.DataSource = dt1
            With DataGrid_info_gastos
                .Columns(0).Width = 210
                .Columns(1).Width = 150
            End With
            Dim suma As Double
            For i = 0 To DataGrid_info_gastos.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGrid_info_gastos.Rows(i).Cells(1).Value)
            Next
            Lbltotal.Text = suma.ToString
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub
    Public Sub cargar_rango_admin()
        Dim sql As String = "SELECT Descripcion, cantidad, fecha, Usuario from sist_ventas.Egresos where fecha between '" + Date_informe_gastos.Value.ToString("yyyy-M-d") + "' and '" + Dateal.Value.ToString("yyyy-M-d") + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            dt1.Reset()
            da.Fill(dt1)

            DataGrid_info_gastos.DataSource = dt1
            With DataGrid_info_gastos
                .Columns(0).Width = 210
                .Columns(1).Width = 150
            End With

            Dim suma As Double
            For i = 0 To DataGrid_info_gastos.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGrid_info_gastos.Rows(i).Cells(1).Value)
            Next
            Lbltotal.Text = suma.ToString
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub
    Private Sub Informe_Gastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Principal.tipo = "Administrador" Then
            Chktodo.Visible = True
        Else
            Chktodo.Visible = False
        End If
        Cargar_hoy()
    End Sub

    Private Sub Btnver_Click(sender As Object, e As EventArgs) Handles Btnver.Click
        If Frm_Principal.tipo = "Administrador" Then
            cargar_rango_admin()
        Else
            cargar_rango()
        End If
    End Sub

    Private Sub Informe_Gastos_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

    Private Sub DataGrid_info_gastos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_info_gastos.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Date_informe_gastos_ValueChanged(sender As Object, e As EventArgs) Handles Date_informe_gastos.ValueChanged

    End Sub

    Private Sub Lbltitulo_Click(sender As Object, e As EventArgs) Handles Lbltitulo.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Dateal_ValueChanged(sender As Object, e As EventArgs) Handles Dateal.ValueChanged

    End Sub

    Private Sub Chktodo_CheckedChanged(sender As Object, e As EventArgs) Handles Chktodo.CheckedChanged
        If Chktodo.Checked = True Then
            cargar_hoy_admin()
        ElseIf Chktodo.Checked = False Then
            Btnver.PerformClick()
        End If
    End Sub
End Class