Imports System.Data
Imports MySql.Data.MySqlClient

Module consultas
    Public eror As New ErrorProvider
    Public tabla As New DataTable
    Public tabla1 As New DataTable
    Public conex As New MySqlConnection("server=localhost;UserId=root;password=1234;database=sist_ventas")
    'FUNCION BUSCAR 
    Public Function busqueda(ByVal consulta As String) As DataTable
        Dim datos As New DataTable
        datos.Clear()
        Try
            Dim da As New MySqlDataAdapter(consulta, conex)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(datos)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        Return datos
    End Function
    Public Function funcion(msql As String) As Boolean
        Try 'Inicia la prueba 
            conex.Open()
            Dim cmd As New MySqlCommand(msql, conex) 'la variable cmd contiene el comando para ejecutar 
            cmd.ExecuteNonQuery() 'Ejecuta el comando 
            conex.Close() 'Cierra conexion 
            funcion = True 'asigna a la funcio el valor de true para retornar 
        Catch ex As Exception 'si hubo un error ejecuta el siguiente código… 
            MsgBox("El sistema no pudo guardar el registro, Por favor revíce y vuelva a intentarlo , " + ex.Message, vbCritical, "Error")
            funcion = False 'asigna a la funcio el valor de false para retornar 
            conex.Close()
        End Try 'termina la prueba
    End Function

    'Funcion para generar codigo del cliente'
    Function Generar_codigo_Cliente()
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            conex.Open()
            Dim dr As MySqlDataReader
            Dim cmd As New MySqlCommand() 'la variable cmd contiene el comando para ejecutar 

            cmd = New MySqlCommand("select count(*) as TotalRegistro from clientes", conex)
            dr = cmd.ExecuteReader
            If dr.Read Then
                total = Int(dr.Item("TotalRegistro")) + 1
            End If
            conex.Close()
            dr.Close()
            If total < 10 Then
                codigo = "CL-00000" + total.ToString
            ElseIf total < 100 Then
                codigo = "CL-0000" + total.ToString
            ElseIf total < 1000 Then
                codigo = "CL-000" + total.ToString
            ElseIf total < 10000 Then
                codigo = "CL-00" + total.ToString
            ElseIf total < 100000 Then
                codigo = "CL-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Generar el codigo" + ex.ToString)
        End Try
        Return codigo

    End Function
    'Funcion para generar codigo del Proveedor'
    Function Generar_codigo_Proveedor()
        Dim codigo As String = ""
        Dim total As Integer = 0
        Try
            conex.Open()
            Dim dr As MySqlDataReader
            Dim cmd As New MySqlCommand() 'la variable cmd contiene el comando para ejecutar 

            cmd = New MySqlCommand("select count(*) as TotalRegistro from Proveedor", conex)
            dr = cmd.ExecuteReader
            If dr.Read Then
                total = Int(dr.Item("TotalRegistro")) + 1
            End If
            conex.Close()
            dr.Close()
            If total < 10 Then
                codigo = "PR-00000" + total.ToString
            ElseIf total < 100 Then
                codigo = "PR-0000" + total.ToString
            ElseIf total < 1000 Then
                codigo = "PR-000" + total.ToString
            ElseIf total < 10000 Then
                codigo = "PR-00" + total.ToString
            ElseIf total < 100000 Then
                codigo = "PR-0" + total.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Generar el codigo" + ex.ToString)
        End Try
        Return codigo
    End Function

    Public Function cajero()
        If Frm_Principal.tipo = "Cajero" Then
            Frm_Principal.REGISTROToolStripMenuItem.DropDown = Nothing
            Frm_Principal.PRODUCTOSToolStripMenuItem.DropDown = Nothing
            Frm_Principal.CONFIGURACIONToolStripMenuItem.DropDown = Nothing
            MsgBox("NO POSEE PERMISOS PARA ACCEDER A ESTA HERRAMIENTA " & vbNewLine & " POR FAVOR CONSULTE CON EL ADMINISTRADOR DEL SISTEMA", MsgBoxStyle.Critical, "CAJA")

            cajero = True

        Else

            cajero = False
        End If
    End Function
    Public Function bodega()
        If Frm_Principal.tipo = "Bodega" Then
            Frm_Principal.REGISTROToolStripMenuItem.DropDown = Nothing
            Frm_Principal.CAJAToolStripMenuItem.DropDown = Nothing
            Frm_Principal.CONFIGURACIONToolStripMenuItem.DropDown = Nothing
            Frm_Principal.Btn_Bfacturas.Enabled = False
            Frm_Principal.Btn_Resumen.Enabled = False
            Frm_Principal.BtncuentasXcobrar.Enabled = False
            Frm_Principal.Btninfo_cred.Enabled = False
            Frm_Principal.Btninfo_ventas.Enabled = False
            Frm_Principal.Btnpago_cuentas.Enabled = False

            MsgBox("NO POSEE PERMISOS PARA ACCEDER A ESTA HERRAMIENTA " & vbNewLine & " POR FAVOR CONSULTE CON EL ADMINISTRADOR DEL SISTEMA", MsgBoxStyle.Critical, "BODEGA")
            bodega = True
        Else
            bodega = False
        End If
    End Function
    Public Function Administrador()
        If Frm_Principal.tipo = "Administrador" Then
            Administrador = True
        Else
            Administrador = False
        End If
    End Function

    Function Letras(press As KeyPressEventArgs, ByVal f As TextBox) As Object
        'VALIDACION PARA QUE SOLO SEAN LETRAS
        If Char.IsLetter(press.KeyChar) Then
            press.Handled = False
            eror.SetError(f, "")
        ElseIf Char.IsControl(press.KeyChar) Then
            press.Handled = False
            eror.SetError(f, "")
        ElseIf Char.IsSeparator(press.KeyChar) Then
            press.Handled = False
            eror.SetError(f, "")
        Else
            eror.SetError(f, "El campo es de valor Texto.")
            press.Handled = True
        End If
        Return press
        Return f
    End Function
    'funcion para validar numero y guion'
    Public Function validar_Numeros_y_guion(ByVal press As System.Windows.Forms.KeyPressEventArgs, ByRef f As TextBox) As Boolean
        Dim res As Boolean = False
        If UCase(press.KeyChar) Like "[0-9--]" & Chr(8) Then
            Return True
            eror.SetError(f, "")
        Else


        End If
        If InStr(1, "0123456789-+" & Chr(8), press.KeyChar) = 0 Then
            eror.SetError(f, "El campo es de valor Numerico.")
            press.KeyChar = ""
        Else
            eror.SetError(f, "")
        End If
        Dim c As Short = 0
        If UCase(press.KeyChar) Like "[+]" Then
            If InStr(f.Text, "+") > 0 Then
                eror.SetError(f, "")
                Return True
            Else

                Return False
                Return False
            End If
        End If

        Return res
    End Function

    'funcion para validar los campos que acepte numeros y decimales
    Public Function validar_Numeros_y_punto(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef f As TextBox) As Boolean
        Dim res As Boolean = False
        If UCase(e.KeyChar) Like "[0-9.]" & Chr(8) Then
            Return True
            eror.SetError(f, "")
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            eror.SetError(f, "El campo es de valor Numerico.")
            e.KeyChar = ""
        Else
            eror.SetError(f, "")
        End If
        Dim c As Short = 0
        If UCase(e.KeyChar) Like "[.]" Then
            If InStr(f.Text, ".") > 0 Then
                eror.SetError(f, "")
                Return True
            Else
                Return False
                Return False
            End If
        End If
        Return res
    End Function
    

    'funcion para validar los campos que acepte numeros y decimales
    Public Function validar_solo_Numeros(ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef f As TextBox) As Boolean
        Dim res As Boolean = False
        If UCase(e.KeyChar) Like "[0-9]" & Chr(8) Then
            Return True
            eror.SetError(f, "")
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            eror.SetError(f, "El campo es de valor Numerico.")
            e.KeyChar = ""
        Else
            eror.SetError(f, "")

        End If
        Return res
    End Function


End Module
