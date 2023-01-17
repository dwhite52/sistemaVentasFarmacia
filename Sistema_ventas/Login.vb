Imports System.Data
Imports MySql.Data.MySqlClient
Public Class Login
    Public dt As DataTable
    Public user As String = ""
    Public pass As String = ""
    Public Sub cargar_usuario()
        Dim sql As String = "SELECT * FROM sist_ventas.login; "
        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            dt = New DataTable
            da.Fill(dt)
            For i = 0 To dt.Rows.Count - 1

                If txtuser.Text = dt.Rows(i)(0).ToString And txtpass.Text = dt.Rows(i)(1).ToString Then
                    user = txtuser.Text
                    pass = txtpass.Text

                    splash.Show()
                    Me.Hide()

                    Exit Sub

                End If

            Next

            MsgBox("Usuario y/o Contraseña Incorrecto", MsgBoxStyle.Exclamation)

            txtuser.Focus()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub
  

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtuser.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim msg As Integer = MessageBox.Show("Deseas Salir", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            Me.Dispose()

        Else

        End If
    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click, btnAceptar.Enter
        cargar_usuario()
    End Sub

    Private Sub Login_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

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