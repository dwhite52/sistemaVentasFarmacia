Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Avisoprodexpirar

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles Txtdias.Click
        Txtdias.ForeColor = Color.Black
        Txtdias.Clear()

    End Sub
    Function validar_vaciobtnagregar()

        If Txtdias.Text = "" Or TxtIdProv.Text = "" Then
            MsgBox("Porfavor llene los campos", vbCritical, "Error")
            validar_vaciobtnagregar = True
            Exit Function
        Else
            validar_vaciobtnagregar = False
        End If
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txtdias.TextChanged

    End Sub

 

    Private Sub Avisoprodexpirar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtIdProv.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tabla.Reset()
        If validar_vaciobtnagregar() = True Then
            Exit Sub
        End If
        Dim actualizar_sql As String = "SELECT cod_prod from aviso where cod_prod='" + TxtIdProv.Text + "' ;"

        Try

            Dim da As New MySqlDataAdapter(actualizar_sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(tabla)
            If tabla.Rows.Count > 0 Then
                Dim actualizar_codigo As String = "UPDATE aviso set `cod_prod`='" & TxtIdProv.Text & "',`aviso_prod`='" & Txtdias.Text & "' where `cod_prod`='" + tabla.Rows(0)(0).ToString + "';"

                consultas.funcion(actualizar_codigo)
                MsgBox("EL SISTEMA AVISARA " + Txtdias.Text.ToString + " DIAS ANTES DE QUE EXPIRE EL PRODUCTO SELECIONADO", MsgBoxStyle.Information)
            Else
                Dim ingresar As String = " Insert into `sist_ventas`.`aviso` ( `aviso_prod`,`cod_prod`) Values('" & Txtdias.Text & "','" & TxtIdProv.Text & "');"


                consultas.funcion(ingresar)
                MsgBox("EL SISTEMA AVISARA " + Txtdias.Text.ToString + " DIAS ANTES DE QUE EXPIRE EL PRODUCTO SELECIONADO", MsgBoxStyle.Information)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        TxtIdProv.Clear()
        Txtdias.Clear()
    End Sub


    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        Dim adp As New Admin_prod
        Admin_prod.GroupBox4.Visible = False
        adp.ShowDialog()

    End Sub

    Private Sub TxtIdProv_TextChanged(sender As Object, e As EventArgs) Handles TxtIdProv.TextChanged

    End Sub
End Class