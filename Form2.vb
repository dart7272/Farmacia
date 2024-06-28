Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        error_inicio.Show()

    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        Me.Hide()
        listarproductos.Show()
    End Sub

    Private Sub ExistenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenteToolStripMenuItem.Click
        ProdExistentes.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        productos.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem1.Click
        Clientes.Show()
    End Sub

    Private Sub ListarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem1.Click
        listarClientes.Show()
    End Sub

    Private Sub ListarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem3.Click
        listarUser.Show()
    End Sub

    Private Sub VenderUnProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenderUnProductoToolStripMenuItem.Click
        vender.Show()
    End Sub
End Class