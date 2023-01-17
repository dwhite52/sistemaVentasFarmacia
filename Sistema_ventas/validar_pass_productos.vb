Public Class validar_pass_productos
    Public Sub validar_pass()
        Dim pass As String

        pass = Txtpass.Text

        If Frm_Principal.tipo = "Administrador" And Login.pass = pass.ToString Then

            Txtpass.Focus()
            Txtpass.Clear()
            Windows.Forms.Cursor.Position = New Point(450, 200)
            Me.Dispose()
            Frm_Principal.PRODUCTOSToolStripMenuItem.ShowDropDown()
            Exit Sub
        ElseIf pass = "  " Then
            MsgBox("Campo Vacio", MsgBoxStyle.Information)
        ElseIf pass = "" Then
            Exit Sub
        Else
            MsgBox("Acceso Denegado", MsgBoxStyle.Critical)
            Me.Dispose()
        End If

    End Sub

    Private Sub Btnok_Click(sender As Object, e As EventArgs) Handles Btnok.Click, Btnok.Enter
        validar_pass()
    End Sub

    Private Sub validar_pass_productos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

  
    Private Sub validar_pass_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class