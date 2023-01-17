Public Class cuentas_expiradas

    Private Sub cuentas_expiradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DATAGRIDCREDEXPIRADOS
            .Columns(0).Width = 180
            .Columns(1).Width = 250
            .Columns(4).Width = 200
            .Columns(3).Width = 200
        End With
    End Sub

    Private Sub DATAGRIDCREDEXPIRADOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATAGRIDCREDEXPIRADOS.CellContentClick

    End Sub
End Class