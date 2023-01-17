Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Buscarprov
    Dim dt As New DataTable

    Private Sub Txtfiltrar_TextChanged(sender As Object, e As EventArgs) Handles Txtfiltrar.TextChanged
        dt.Reset()
        Dim sql As String = "SELECT cod_proveedor,Nombres,apellidos,nombre_comercial FROM sist_ventas.proveedor where Nombres like '" + Txtfiltrar.Text + "%'; "
        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        ListView1.Items.Clear()
        For Each reg In dt.Rows
            Dim fila As ListViewItem
            fila = ListView1.Items.Add(reg("cod_proveedor"))
            With fila
                .SubItems.Add(reg("Nombres"))
                .SubItems.Add(reg("apellidos"))
                .SubItems.Add(reg("nombre_comercial"))
                

            End With
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Registro_prod.TxtIdProv.Text = ListView1.FocusedItem.SubItems(0).Text

    End Sub

    Private Sub Buscarprov_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Buscarprov_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt.Reset()
        Dim sql As String = "SELECT * FROM sist_ventas.proveedor; "
        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        ListView1.Items.Clear()
        For Each reg In dt.Rows
            Dim fila As ListViewItem
            fila = ListView1.Items.Add(reg("cod_proveedor"))
            With fila
                .SubItems.Add(reg("Nombres"))
                .SubItems.Add(reg("apellidos"))
                .SubItems.Add(reg("nombre_comercial"))

            End With
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class