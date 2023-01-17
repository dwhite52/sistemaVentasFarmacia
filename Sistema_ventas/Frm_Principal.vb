'Formulario Principal'
Imports System.Drawing.Drawing2D
Imports System.IO.StreamWriter
Imports System.IO
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Frm_Principal

    Public tipo As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        MenuStrip1.Items.Add(New ToolStripSeparator())
        MenuStrip1.Items.Insert(1, New ToolStripSeparator())
        MenuStrip1.Items.Insert(3, New ToolStripSeparator())
        MenuStrip1.Items.Insert(5, New ToolStripSeparator())
        MenuStrip1.Items.Insert(7, New ToolStripSeparator())
        MenuStrip1.Items.Insert(9, New ToolStripSeparator())


        Dim Dt_logeo As New DataTable

        Dim sql1 As String = "SELECT tipo from login where usuario='" + Login.user + "' and pass='" + Login.pass + "' ;"
        Try
            Dim da As New MySqlDataAdapter(sql1, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(Dt_logeo)
            tipo = Dt_logeo.Rows(0)(0).ToString

            Me.Text = "Usuario: " + Login.user + " Cuenta de " + tipo

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        cajero()
        bodega()

    End Sub
    Private Sub VENTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENTASToolStripMenuItem.Click


        ventas.ShowDialog()
        ventas.txtnomcontadoo.Focus()
    End Sub

    Private Sub ENTRADADEPRODUCTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRADADEPRODUCTOSToolStripMenuItem.Click
       

        Registro_prod.ShowDialog()
        

    End Sub
    Private Sub NUEVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem.Click
        'clientes.limpiar()
        'clientes.ShowDialog()
        Dim cl As New clientes
        cl.ShowDialog()
    End Sub

    Private Sub NUEVOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem1.Click
        'Proveedor.limpiar()
        'Proveedor.ShowDialog()
        Dim pr As New Proveedor
        pr.ShowDialog()
    End Sub

    Private Sub MANEJOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MANEJOToolStripMenuItem1.Click
        manejoclientes.ShowDialog()
    
    End Sub

    Private Sub MANEJOToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MANEJOToolStripMenuItem2.Click

        manejoproveedor.ShowDialog()

    End Sub

    Private Sub ABONOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABONOSToolStripMenuItem.Click

        Dim ab As New abonos
        ab.ShowDialog()

    End Sub

    Private Sub MANEJOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANEJOToolStripMenuItem.Click

        Admin_prod.ShowDialog()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btninfo_ventas.Click

        Dim ivr As New Info_Ventas_realiadas
        ivr.ShowDialog()

    End Sub

    Private Sub USUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USUARIOSToolStripMenuItem.Click

        Usuarios.ShowDialog()
    End Sub


    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        Dim msg As Integer = MessageBox.Show("Deseas Cerrar Session", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then
            Login.txtuser.Clear()
            Login.txtpass.Clear()
            Login.Show()
            Login.txtuser.Focus()
            Me.Dispose()
        Else

        End If
    End Sub

    Private Sub Frm_Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim msg As Integer = MessageBox.Show("Estas seguro Que Deseas Salir Del Sistema", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msg = DialogResult.Yes Then

            Login.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btninfo_cred.Click

        Dim ic As New Informe_credito
        ic.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_Bfacturas.Click

        Dim bf As New Busqueda_Factura
        bf.ShowDialog()

    End Sub

    Private Sub RESPALDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESPALDOToolStripMenuItem.Click

    End Sub

    Private Sub RESTAURACIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RESTAURACIONToolStripMenuItem.Click
        Dim abrir As New OpenFileDialog
        abrir.DefaultExt = "sql"
        Dim carpeta As New FolderBrowserDialog
        Dim pathmysql As String
        Dim comando As String
        Dim arg As String
        abrir.Filter = "File MYSQL (*.sql)|*.sql"
        pathmysql = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\MySQL AB\MYSQL Server 5.7", "Location", 0)
        If pathmysql = Nothing Then
            MsgBox("No se encontro en tu equipo Mysql, escoge la carpeta donde esta ubicado")
            carpeta.ShowDialog()
            pathmysql = carpeta.SelectedPath
        End If

        If abrir.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Try

            comando = pathmysql & "\bin\mysql.exe"
            comando.Replace("\\", "\")
            arg = " --user=root --password=1234 --host=localhost --database Sist_ventas < " & Chr(34) & abrir.FileName & Chr(34)
            Dim proceso As New Process
            proceso.StartInfo.FileName = "cmd.exe"
            proceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            proceso.StartInfo.UseShellExecute = False
            proceso.StartInfo.RedirectStandardOutput = True
            proceso.StartInfo.RedirectStandardInput = True
            proceso.StartInfo.CreateNoWindow = True
            proceso.Start()
            Dim escribeconsola As StreamWriter = proceso.StandardInput
            Dim leyendoconsola As StreamReader = proceso.StandardOutput
            escribeconsola.WriteLine(comando & arg)
            escribeconsola.Close()
            proceso.WaitForExit()
            proceso.Close()
            MsgBox("BASE DE DATOS RESTAURADO EXITOSAMENTE", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub MANUALToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MANUALToolStripMenuItem1.Click
        Dim carpeta As New FolderBrowserDialog
        Dim respaldar As New SaveFileDialog
        respaldar.DefaultExt = "sql"
        Dim pathmysql As String
        Dim comando As String
        'pathmysql = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\MySQL AB\MYSQL Server 5.7", "Location", 0)
        pathmysql = "C:\Program Files\MySQL\MySQL Server 5.7"
        If pathmysql = Nothing Then
            MsgBox("No se encontro en tu equipo Mysql, escoge la carpeta donde esta ubicado")
            carpeta.ShowDialog()
            pathmysql = carpeta.SelectedPath
        End If
        respaldar.Filter = "File MYSQL (*.sql)|*.sql"
        If respaldar.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                comando = pathmysql & "\bin\mysqldump --user=root --password=1234 --databases Sist_Ventas -r """ & respaldar.FileName & """"
                Shell(comando, AppWinStyle.MinimizedFocus, True)
                MsgBox("BASE DE DATOS RESPALDADO EXITOSAMENTE", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Ocurrio un error al respaldar", MsgBoxStyle.Critical, "Informacion")
            End Try

        End If
    End Sub

    Private Sub AUTOMATICOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AUTOMATICOToolStripMenuItem.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "Taskschd.msc"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub Frm_Principal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim td As New DataTable
        Dim commit As String = "SELECT * from aviso;"
        'Try
        '    Dim da As New MySqlDataAdapter(commit, conex)
        '    da.SelectCommand.CommandType = CommandType.Text
        '    da.Fill(td)

        '    If td.Rows.Count > 0 Then
        '        Dim prodespecifico As New DataTable
        '        For i = 0 To td.Rows.Count - 1
        '            Dim sqlquery As String = "SELECT idprod as Codigo,Descripcion,fecha_expiracion,existencia from productos where fecha_expiracion between '" + Date.Now.ToString("yyyy-MM-d") + "' and '" + Date.Now.AddDays(td.Rows(i)(0)).ToString("yyyy-MM-d") + "' and idprod='" + td.Rows(i)(1).ToString + "' ;"

        '            Try
        '                Dim da4 As New MySqlDataAdapter(sqlquery, conex)
        '                da4.SelectCommand.CommandType = CommandType.Text
        '                da4.Fill(prodespecifico)
        '                Avisoprodespecifico.DataGridView1.DataSource = prodespecifico
        '            Catch ex As Exception
        '                MessageBox.Show(ex.Message, "Error")
        '            End Try
        '        Next

        '        If prodespecifico.Rows.Count > 0 Then
        '            Avisoprodespecifico.ShowDialog()
        '        Else
        '            Exit Sub
        '        End If
        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error")
        'End Try

        Dim DT As New DataTable
        Dim sql As String = "SELECT idprod as Codigo,Descripcion,fecha_expiracion,existencia from productos where fecha_expiracion between '" + Date.Now.ToString("yyyy-MM-d") + "' and '" + Date.Now.AddDays(120).ToString("yyyy-MM-d") + "' and existencia>0;"
        Try
            Dim da As New MySqlDataAdapter(sql, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(DT)
            If DT.Rows.Count > 0 Then
                Prod_expirado.DataGridView1.DataSource = DT
                Prod_expirado.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try




        Dim DT1 As New DataTable
        Dim query As String = "SELECT Num_Boleta_cred,fecha_de_vencimiento,monto,saldo_pendiente,Nombre,Apellido FROM credito INNER JOIN cuentas_X_cobrar ON credito.Num_Boleta_cred = cuentas_x_cobrar.credito_Num_Boleta_cred inner join clientes on cuentas_X_cobrar.Clientes_Cod_Clientes= clientes.Cod_Clientes where cuentas_x_cobrar.estado='Pendiente' and fecha_de_vencimiento = '" + Date.Now.ToString("yyyy-MM-d") + "';"
        Try
            Dim da As New MySqlDataAdapter(query, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(DT1)
            If DT1.Rows.Count > 0 And tipo = "Administrador" Then
                cuentas_expiradas.DATAGRIDCREDEXPIRADOS.DataSource = DT1
                cuentas_expiradas.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Private Sub REGISTROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTROToolStripMenuItem.Click
        cajero()
        bodega()
    End Sub


    Private Sub PRODUCTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTOSToolStripMenuItem.Click, PRODUCTOSToolStripMenuItem.MouseDown

        cajero()
        'test()

        validar_pass_productos.Show()
    End Sub

    Private Sub CONFIGURACIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONFIGURACIONToolStripMenuItem.Click
        cajero()
        bodega()
    End Sub

    Private Sub CAJAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CAJAToolStripMenuItem.Click
        bodega()
    End Sub

    Private Sub AVISOPRODAEXPIRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AVISOPRODAEXPIRARToolStripMenuItem.Click
        MsgBox("PROXIMAMENTE, CONTACTE A SUPERADMIN", MsgBoxStyle.Information)
        'Avisoprodexpirar.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Btn_Resumen.Click
        Dim rg As New resumen_general
        rg.ShowDialog()

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtncuentasXcobrar.Click

        Dim ls As New Lista_cuentasxcobrar
        ls.ShowDialog()
    End Sub

    Private Sub Frm_Principal_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim rec As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
        '
        'Create a new brush. Make is a Gradient style brush.
        '
        Dim myBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(rec, Color.Teal, _
          Color.WhiteSmoke, Drawing.Drawing2D.LinearGradientMode.Vertical)
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

    


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
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

   
    Private Sub SOBRENOSOTROSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SOBRENOSOTROSToolStripMenuItem.Click
        Dim ad As New Acerca_de
        ad.ShowDialog()
    End Sub

    Private Sub MANUALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANUALToolStripMenuItem.Click

        Try
            Process.Start("C:\manual\Manual de usuario.pdf")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btnpago_cuentas.Click
        Dim pg As New informe_pagos
        pg.ShowDialog()
    End Sub



    Private Sub ARQUEOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARQUEOToolStripMenuItem.Click
        Dim pg As New Capital_caja
        pg.ShowDialog()
    End Sub

    Private Sub GASTOSDEOPERACIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GASTOSDEOPERACIONToolStripMenuItem.Click
        Dim pg As New Gastos_op
        pg.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btngastos_op_Click(sender As Object, e As EventArgs) Handles Btngastos_op.Click
        Dim pg As New Informe_Gastos
        pg.ShowDialog()
    End Sub

    Private Sub PRODUCTOSToolStripMenuItem_MouseDown(sender As Object, e As MouseEventArgs) Handles PRODUCTOSToolStripMenuItem.MouseDown
       

    End Sub



    Private Sub ARQUEOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ARQUEOToolStripMenuItem1.Click

        arqueo.ShowDialog()
    End Sub


    Private Sub PRODUCTOSToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles PRODUCTOSToolStripMenuItem.MouseEnter
        PRODUCTOSToolStripMenuItem.HideDropDown()
    End Sub

    Private Sub BTNarqueo_Click(sender As Object, e As EventArgs) Handles BTNarqueo.Click
        Dim rg As New informe_arqueo
        rg.ShowDialog()
    End Sub

    Private Sub ITEMPROXIMOAEXPIRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ITEMPROXIMOAEXPIRARToolStripMenuItem.Click
        Prod_expirado.ShowDialog()
    End Sub
End Class






