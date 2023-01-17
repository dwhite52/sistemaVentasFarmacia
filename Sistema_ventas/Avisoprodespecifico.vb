Public Class Avisoprodespecifico

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Avisoprodespecifico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1
            .Columns(0).Width = 180
            .Columns(1).Width = 250
            .Columns(2).Width = 200
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class