Imports MySql.Data.MySqlClient

Public Class Clientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox4.Text = "") Then
            Label6.Visible = True
            Label6.Text = "(Campo Obligatorio)"
            Exit Sub
        Else
            Label6.Visible = False
        End If
        If (TextBox3.Text = "") Then
            Label7.Visible = True
            Label7.Text = "(Campo Obligatorio)"
            Exit Sub
        Else
            Label7.Visible = False
        End If
        If (TextBox2.Text = "") Then
            Label8.Visible = True
            Label8.Text = "(Campo Obligatorio)"
            Exit Sub
        Else
            Label8.Visible = False
        End If
        If (TextBox1.Text = "") Then
            Label9.Visible = True
            Label9.Text = "(Campo Obligatorio)"
            Exit Sub
        Else
            Label9.Visible = False
        End If

        Try
            Dim comando = New MySqlCommand("INSERT INTO clientes (ID,NomCliente,Sexo,Ubicacion) VALUES ('" & TextBox4.Text & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & TextBox1.Text & "')", conex)
            Dim res = comando.ExecuteNonQuery
            MsgBox("Cliente ingresado correctamente", MsgBoxStyle.Information, "Registro Exitoso :)")
            Form1.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = "Masculino"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = "Femenino"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class