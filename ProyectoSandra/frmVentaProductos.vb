Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmVentaProductos
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim res As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection(sqlServerC)
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select * from Clientes"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombre.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        res = False
        DataGridView1.Rows.Clear()
        comando.CommandText = "Select s.lugar, Pr.nombre, DP.cantidad, P.total, P.fecha  From detallePedido AS DP inner join pedidos as P On DP.idPedido =P.idPedido inner join Productos as Pr on Dp.idProducto = Pr.idProducto inner join sucursales as s on P.claveS = s.claveS
        Where P.idCliente = " & txtIdProvedor.Text
        lector = comando.ExecuteReader
        While lector.Read()
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            res = True
        End While
        If res <> True Then
            MsgBox("No a realizado ningun pedido este proveedor")
        End If
        lector.Close()
    End Sub

    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged

        comando.CommandText = "Select * from Clientes where nombreOrazonS = '" & cboNombre.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdProvedor.Text = lector(0)
        lector.Close()
        btnGenerar.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.Close()
        Dispose()

    End Sub

    Private Sub frmVentaProductos_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conexion.Close()
    End Sub
End Class