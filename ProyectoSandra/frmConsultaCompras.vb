Imports MySql.Data.MySqlClient
Public Class frmConsultaCompras
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Private Sub frmConsultaCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lala;")
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select idCompra from compras"
        lector = comando.ExecuteReader
        While lector.Read()
            cboCompra.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        DataGridView1.Rows.Clear()
        comando.CommandText = "Select concepto, cantidad, precio from detallecompra where idCompra =" & cboCompra.Text
        lector = comando.ExecuteReader
        While lector.Read()
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2))
        End While
        lector.Close()
    End Sub
    Private Sub cboCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCompra.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        comando.CommandText = "Select fecha, total from compras where idCompra =" & cboCompra.Text
        lector = comando.ExecuteReader
        lector.Read()
        txtFecha.Text = lector(0).ToString.Substring(0, 10)
        txtTotal.Text = lector(1)
        lector.Close()
    End Sub
End Class