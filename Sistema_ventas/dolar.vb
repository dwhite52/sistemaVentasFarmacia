Public Class dolar
    Dim total As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txttipodecambio.TextChanged
        lblTotalcor.Text = Val(Txtcantidaddolar.Text) * Val(txttipodecambio.Text)
    End Sub

    Private Sub dolar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub Txtcantidaddolar_TextChanged(sender As Object, e As EventArgs) Handles Txtcantidaddolar.TextChanged
        lblTotalcor.Text = Val(Txtcantidaddolar.Text) * Val(txttipodecambio.Text)
    End Sub

    Private Sub Btnok_Click(sender As Object, e As EventArgs) Handles Btnok.Click
        total = lblTotalcor.Text
        arqueo.lbltotaldolar.Text = Me.total
        arqueo.Txtcantidaddolar.Text = Me.Txtcantidaddolar.Text
        arqueo.txttipodecambio.Text = Me.txttipodecambio.Text
        arqueo.lblTotalcor.Text = Me.lblTotalcor.Text

        Me.Dispose()

    End Sub

    Private Sub dolar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dolar_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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

End Class