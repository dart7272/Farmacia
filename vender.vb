Imports MySql.Data.MySqlClient

Public Class vender
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim idProducto As String = TextBox4.Text
            Dim valorAsumar As Integer = TextBox2.Text


            Dim comandoLeerCantidad As New MySqlCommand("SELECT Cantidad FROM productos WHERE ID = '" + TextBox4.Text + "';", conex)
            comandoLeerCantidad.Parameters.AddWithValue(TextBox4.Text, idProducto)

            Dim cantidadActual As Integer = comandoLeerCantidad.ExecuteScalar()

            Dim nuevoValorCantidad As Integer = cantidadActual - valorAsumar
            TextBox2.Text = nuevoValorCantidad
            Dim comandoActualizar As New MySqlCommand("UPDATE productos SET Cantidad = " + TextBox2.Text + " WHERE ID = '" + TextBox4.Text + "';", conex)
            comandoActualizar.Parameters.AddWithValue(TextBox4.Text, idProducto)
            comandoActualizar.Parameters.AddWithValue(TextBox2.Text, nuevoValorCantidad)
            MsgBox("Producto vendido", MsgBoxStyle.Information, "Registro Exitoso :)")
            comandoActualizar.ExecuteNonQuery()
            comandoLeerCantidad.Dispose()
            comandoActualizar.Dispose()



    End Sub
End Class