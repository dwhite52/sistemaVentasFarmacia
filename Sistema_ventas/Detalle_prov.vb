Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Detalle_prov
    Dim dt As New DataTable()
    Dim index As Integer = 0


    Public Sub cargar_producto(posicion As Integer)
        dt.Reset() 'vaciamos la tabla si contiene datos
        Dim sql As String = "SELECT Provveedor_cod_proveedor,nombre_comercial,Num_fact_prov,Fecha_ingreso,cantidad,Inventario_idprod FROM sist_ventas.detalle_prod, sist_ventas.prod_nuevo, sist_ventas.proveedor where proveedor.cod_proveedor like prod_nuevo.Provveedor_cod_proveedor and prod_nuevo.Num_fact_prov like detalle_prod.Prod_nuevo_Num_fact and Inventario_idprod= '" + Admin_prod.DataGridView1.CurrentRow.Cells(0).Value.ToString + "';" 'hacemos la consulta a la base de datos
        Try
            Dim da As New MySqlDataAdapter(sql, conex) ' abrimos conexion y ejecutamos la consulta 
            da.SelectCommand.CommandType = CommandType.Text 'captura los datos producidos de la consulta
            da.Fill(dt) 'llenamos la tabla

            conex.Close() 'cerramos la conexion
            txtcodigo.Text = dt.Rows(posicion)(0).ToString 'pasa el valor de la primera fila, segunda columna de la tabla al textbox nombre
            txtnom.Text = dt.Rows(posicion)(1).ToString 'pasa el valor de la primera fila, tercera columna de la tabla al textbox apellido
            txtnumfact.Text = dt.Rows(posicion)(2).ToString
            mtxtfecha.Text = dt.Rows(posicion)(3).ToString
            txtcantidad.Text = dt.Rows(posicion)(4).ToString
        Catch ex As Exception 'captura mensaje en caso de error
            MessageBox.Show(ex.Message, "Error") 'se muestra el error en pantalla
        End Try
    End Sub

    Private Sub Detalle_prov_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub
    Private Sub Detalle_prov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_producto(index)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnsig.Click
        index += 1
        If index > dt.Rows.Count() - 1 Then
            index = dt.Rows.Count() - 1
        End If
        cargar_producto(index)


    End Sub

    Private Sub Btnanterior_Click(sender As Object, e As EventArgs) Handles Btnprim.Click
        index = 0
        cargar_producto(index)
        MsgBox("Primer Registro", vbInformation)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Btnanterior.Click
        index -= 1
        If index < 0 Then
            index = 0
        End If
        cargar_producto(index)

    End Sub

    Private Sub Btnultimo_Click(sender As Object, e As EventArgs) Handles Btnultimo.Click
        index = dt.Rows.Count() - 1
        cargar_producto(index)
        MsgBox("Ultimo Registro", vbInformation)

    End Sub

    Private Sub Detalle_prov_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class