Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Conectar()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try


            If TextBox1.Text = " " Then
                Label5.Visible = True
                Label5.Text = "(Introduzca Usuario)"

            ElseIf TextBox2.Text = " " Then
                Label6.Visible = True
                Label6.Text = "(Introduzca Contraseña)"

            Else

                Label5.Visible = False
                Label6.Visible = False

                Dim comando = New MySqlCommand("SELECT * FROM usuarios WHERE Username = '" + TextBox2.Text + "' AND Password = '" + TextBox1.Text + "';", conex)
                Dim resultado = comando.ExecuteReader
                resultado.Read()

                If resultado.HasRows Then
                    MsgBox("Bienvenido " + resultado("Fullname"))
                    Form2.Show()
                    Me.Hide()
                Else
                    MsgBox("Error: el usuario o contraseña son incorrectos")
                End If
                comando.Dispose()
                resultado.Close()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = True
        TextBox1.UseSystemPasswordChar = True
        TextBox1.Refresh()
        Button2.Visible = False
        Button3.Visible = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = True
        TextBox1.UseSystemPasswordChar = False
        TextBox1.Refresh()
        Button3.Visible = False
        Button2.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Registrar_Usuario.Show()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conex.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Close()
        conex.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
