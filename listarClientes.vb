Imports MySql.Data.MySqlClient

Public Class listarClientes
    Private Sub listarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String = "SELECT * FROM clientes"
        Dim adaptador As New MySqlDataAdapter(consulta, conex)
        Dim dt As New DataTable
        adaptador.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            TextBox1.Text = DataGridView1.SelectedCells(0).Value
            TextBox2.Text = DataGridView1.SelectedCells(1).Value
            TextBox3.Text = DataGridView1.SelectedCells(2).Value
            TextBox4.Text = DataGridView1.SelectedCells(3).Value
        Catch ex As Exception

        End Try


    End Sub
End Class