Imports MySql.Data.MySqlClient
Module Conexion
    Public conex As MySqlConnection
    Public Sub Conectar()
        Dim cadenaConection = "Server=localhost;user id=root;Port=3306;password=;Database=Farmacia"


        Try
            conex = New MySqlConnection(cadenaConection)
            conex.ConnectionString = cadenaConection
            conex.Open()

        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try

    End Sub
End Module
