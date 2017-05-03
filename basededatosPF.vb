Imports MySql.Data
Imports MySql.Data.MySqlClient
Module basededatosPF
    Public conexion As New MySqlConnection

    Sub Conectarsql()
        Try
            conexion.ConnectionString = "server=localhost;user id=root; password=''; database=prestaafacil"
            conexion.Open()
            MsgBox("Conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Sub InsertUsuariosql(ByVal Usuario, ByVal Clave)
        Try
            sql = "Insert Into Usuario(Usuario,Clave)value('" & Usuario & "','" & Clave & "')"
            da = New MySqlDataAdapter(sql, conexion)
            dt = New DataTable
            da.Fill(dt)
            MsgBox("Usuario guardado con èxito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Module
