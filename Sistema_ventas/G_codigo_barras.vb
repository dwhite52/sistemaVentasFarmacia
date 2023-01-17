Imports iTextSharp.text.pdf
Public Class G_codigo_barras
    Dim num As Integer
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
        e.Graphics.DrawImage(bm, 5, 0)
        e.Graphics.DrawString(Lblnum.Text, Lblnum.Font, Brushes.Black, 5, 84)

    End Sub

    Private Sub btngcodigo_Click(sender As Object, e As EventArgs) Handles btngcodigo.Click
        Dim bcode As New Barcode128

        Randomize()
        num = Rnd() * 100000000
        Lblnum.Text = num
        bcode.BarHeight = 80
        bcode.Code = Lblnum.Text
        bcode.GenerateChecksum = True
        bcode.CodeType = Barcode.CODE128
        Try
            Dim bm As New Bitmap(bcode.CreateDrawingImage(Color.Black, Color.White))
            Dim im As Image
            im = New Bitmap(bm.Width, bm.Height)
            Dim gp As Graphics = Graphics.FromImage(im)
            gp.FillRectangle(New SolidBrush(Color.White), 0, 0, bm.Width, bm.Height)
            gp.DrawImage(bm, 0, 0)
            PictureBox1.Image = im

        Catch ex As Exception
            MsgBox("No se pudo generar el codigo de barra")

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Registro_prod.txtcodprod.Text = Lblnum.Text
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub G_codigo_barras_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

  
    Private Sub G_codigo_barras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btngcodigo.PerformClick()
    End Sub
End Class