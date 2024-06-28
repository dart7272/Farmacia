Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Diagnostics.Eventing.Reader


Public Class Registrar_Usuario
    Private Sub Registrar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
        TextBox3.UseSystemPasswordChar = True
    End Sub
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


        If (TextBox2.Text = TextBox3.Text) Then
            Try


                Dim veri = New MySqlCommand("SELECT * FROM usuarios WHERE Username = '" + TextBox4.Text + "';", conex)
                Dim resultado = veri.ExecuteReader
                resultado.Read()
                resultado.Close()



                Try
                    Dim comando = New MySqlCommand("INSERT INTO usuarios (Username,Password,Fullname) VALUES ('" & TextBox4.Text & "','" & TextBox3.Text & "','" & TextBox1.Text & "')", conex)
                    Dim res = comando.ExecuteNonQuery
                    MsgBox("Dato ingresado ", MsgBoxStyle.Information, "Registro Exitoso :)")
                    Form1.Show()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Label8.Visible = True
            Label8.Text = "No es igual a la contraseña"
            TextBox2.Text = ""
        End If
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = True
        TextBox3.UseSystemPasswordChar = False
        TextBox3.Refresh()
        Button3.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Visible = True
        TextBox3.UseSystemPasswordChar = True
        TextBox3.Refresh()
        Button4.Visible = False
        Button3.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Visible = True
        TextBox2.UseSystemPasswordChar = False
        TextBox2.Refresh()
        Button6.Visible = False
        Button7.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Visible = True
        TextBox2.UseSystemPasswordChar = True
        TextBox2.Refresh()
        Button7.Visible = False
        Button6.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Close()
    End Sub

    Private Sub Registrar_Usuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
End Class