Public Class splash

    Private Sub splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pgrb.Increment(2)
        'Lblvalor.Text = pgrb.Value().ToString
        'If pgrb.Value > 0 And pgrb.Value < 15 Then
        '    lblbd.Visible = True
        '    lbldll.Visible = False
        '    lblnet.Visible = False
        '    lblCompata.Visible = False
        '    Lblcristal.Visible = False
        '    Lbllib.Visible = False
        '    Lblsql.Visible = False
        'ElseIf pgrb.Value > 14 And pgrb.Value < 29 Then
        '    lblbd.Visible = False
        '    lbldll.Visible = True
        '    lblnet.Visible = False
        '    lblCompata.Visible = False
        '    Lblcristal.Visible = False
        '    Lbllib.Visible = False
        '    Lblsql.Visible = False
        'ElseIf pgrb.Value > 28 And pgrb.Value < 43 Then
        '    lblbd.Visible = False
        '    lbldll.Visible = False
        '    lblnet.Visible = True
        '    lblCompata.Visible = False
        '    Lblcristal.Visible = False
        '    Lbllib.Visible = False
        '    Lblsql.Visible = False
        'ElseIf pgrb.Value > 42 And pgrb.Value < 57 Then
        '    lblbd.Visible = False
        '    lbldll.Visible = False
        '    lblnet.Visible = False
        '    lblCompata.Visible = True
        '    Lblcristal.Visible = False
        '    Lbllib.Visible = False
        '    Lblsql.Visible = False
        'ElseIf pgrb.Value > 56 And pgrb.Value < 71 Then
        '    lblbd.Visible = False
        '    lbldll.Visible = False
        '    lblnet.Visible = False
        '    lblCompata.Visible = False
        '    Lblcristal.Visible = True
        '    Lbllib.Visible = False
        '    Lblsql.Visible = False
        'ElseIf pgrb.Value > 70 And pgrb.Value < 85 Then
        '    lblbd.Visible = False
        '    lbldll.Visible = False
        '    lblnet.Visible = False
        '    lblCompata.Visible = False
        '    Lblcristal.Visible = False
        '    Lbllib.Visible = True
        '    Lblsql.Visible = False
        'ElseIf pgrb.Value > 84 And pgrb.Value <= 100 Then
        '    lblbd.Visible = False
        '    lbldll.Visible = False
        '    lblnet.Visible = False
        '    lblCompata.Visible = False
        '    Lblcristal.Visible = False
        '    Lbllib.Visible = False
        '    Lblsql.Visible = True
        'End If
        If pgrb.Value = 100 Then

            Frm_Principal.Show()
            Me.Dispose()
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub
End Class