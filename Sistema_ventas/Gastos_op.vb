Imports MySql.Data.MySqlClient

Public Class Gastos_op
    Public Sub limpiar()
        Txtcantidad.Clear()
        TxtDescripcion.Clear()
    End Sub

    Public Sub eliminar()

    End Sub

    Public dt1 As New DataTable
    Public Sub cargar()

        Dim sql As String = "SELECT idEgresos as Codigo, Descripcion, cantidad, fecha from sist_ventas.Egresos where fecha='" + Date.Now.ToString("yyyy-M-d") + "' and egresos.Usuario='" + Login.user + "';"
        Try

            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt1 = New DataTable()
            dt1.Reset()
            da.Fill(dt1)

            DataGrid_gastos.DataSource = dt1
            With DataGrid_gastos
                .Columns(1).Width = 220
                .Columns(2).Width = 150
                .Columns(3).Width = 140
            End With

            Dim suma As Double
            For i = 0 To DataGrid_gastos.RowCount - 1
                'hace la suma de todas las filas del subtotal'
                suma += Val(DataGrid_gastos.Rows(i).Cells(2).Value)
            Next
            Lbltotal.Text = suma.ToString
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub
    Private Sub Gastos_op_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub Gastos_op_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
        If TxtDescripcion.Text = "" Or Txtcantidad.Text = "" Then
            MsgBox("Por favor llene todos los campos necesarios", MsgBoxStyle.Information)
            Exit Sub
        Else
            Dim Agregar As String = "INSERT INTO `sist_ventas`.`Egresos` (`Descripcion`, `Cantidad`, `fecha`, `Usuario`) VALUES ('" & TxtDescripcion.Text & "', '" & Txtcantidad.Text & "', '" & date_egreso.Value.ToString("yyyy-M-d") & "', '" + Login.user + "');"
            Try
                If consultas.funcion(Agregar) = True Then
                    Dim fila As Integer = DataGrid_gastos.RowCount - 1
                    'pasa el valor nuevo de los Texbox a las filas del datagridview
                    DataGrid_gastos.Rows(fila).Cells(0).Value = dt1.Rows(0)(0).ToString
                    DataGrid_gastos.Rows(fila).Cells(1).Value = TxtDescripcion.Text
                    DataGrid_gastos.Rows(fila).Cells(2).Value = Txtcantidad.Text
                    DataGrid_gastos.Rows(fila).Cells(3).Value = date_egreso.Value

                    MsgBox("Egreso Registrado Correctamente", MsgBoxStyle.Information)
                    Dim suma As Double
                    For i = 0 To DataGrid_gastos.RowCount - 1
                        'hace la suma de todas las filas del subtotal'
                        suma += Val(DataGrid_gastos.Rows(i).Cells(2).Value)
                    Next
                    Lbltotal.Text = suma.ToString
                    limpiar()
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

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Dim msg As Integer = MessageBox.Show("Deseas Eliminar Registro?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        'el sistema pregunta al usuario'
        'espera la respuesta y ejecuta una opcion
        If msg = DialogResult.Yes Then
            Dim ELIMINAR As String = " DELETE FROM `sist_ventas`.`egresos` WHERE `idEgresos`='" + DataGrid_gastos.CurrentRow.Cells(0).Value.ToString + "';"
            Try
                If consultas.funcion(ELIMINAR) = True Then
                    MsgBox("Registro Eliminado", MsgBoxStyle.Information)
                    DataGrid_gastos.Rows.Remove(DataGrid_gastos.CurrentRow)
                    Dim suma As Double
                    For i = 0 To DataGrid_gastos.RowCount - 1
                        'hace la suma de todas las filas del subtotal'
                        suma += Val(DataGrid_gastos.Rows(i).Cells(2).Value)
                    Next
                    Lbltotal.Text = suma.ToString
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error")
            End Try
        End If
    End Sub

    Private Sub DataGrid_gastos_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_gastos.CellContentClick

    End Sub

    Private Sub DataGrid_gastos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGrid_gastos.CellMouseClick
        If (e.Button = MouseButtons.Right) Then
            If DataGrid_gastos.Rows.Count > 1 Then
                DataGrid_gastos.CurrentCell = DataGrid_gastos.Rows(e.RowIndex).Cells(e.ColumnIndex)
                ELIMINARToolStripMenuItem.ShowDropDown()

                'ContextMenuStrip1.Items.Add("Devolucion").Name = "DEVOLUCION"
                'ContextMenuStrip1.Items.Add("Eliminar").Name = "ELIMINAR"

            Else
                ELIMINARToolStripMenuItem.HideDropDown()
                MsgBox("No hay Datos", vbExclamation)
            End If


        End If
    End Sub
End Class