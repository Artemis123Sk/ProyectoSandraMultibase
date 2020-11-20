Public Class Form1
    Private Sub ProvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvedoresToolStripMenuItem.Click
        frmProvedores.Show()
    End Sub

    Private Sub SucursalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesToolStripMenuItem.Click
        frmSucursales.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmClientes.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        frmProductos.ShowDialog()
    End Sub

    Private Sub RegistrarComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarComprasToolStripMenuItem.Click
        frmCompras.Show()
    End Sub

    Private Sub ConsultarComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarComprasToolStripMenuItem.Click
        frmConsultaCompras.Show()
    End Sub

    Private Sub PedidosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PedidosToolStripMenuItem1.Click
        frmPedidos.ShowDialog()
    End Sub

    Private Sub ComprasPorProvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasPorProvedoresToolStripMenuItem.Click
        frmComprasPorProvedor.Show()
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        FrmDepartamentos.Show()
    End Sub

    Private Sub HorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorariosToolStripMenuItem.Click
        FrmHorarios.Show()
    End Sub
End Class
