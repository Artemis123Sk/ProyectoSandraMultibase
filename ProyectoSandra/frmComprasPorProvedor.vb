Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class frmComprasPorProvedor
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim idsProvedor As String
    Dim res As Boolean
    Private Sub frmComprasPorProvedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lala;")
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select idProvedor, nombre from provedores"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombre.Items.Add(lector(1))
            idsProvedor &= lector(0) & ","
        End While
        lector.Close()
    End Sub
    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged
        Dim arr() As String = idsProvedor.Split(",")
        comando.CommandText = "Select * from provedores where idProvedor = " & arr(cboNombre.SelectedIndex)
        lector = comando.ExecuteReader
        lector.Read()
        txtIdProvedor.Text = lector(0)
        lector.Close()
        btnGenerar.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        res = False
        DataGridView1.Rows.Clear()
        comando.CommandText = "Select S.claveS, S.Lugar,C.idCompra, DC.concepto, DC.Cantidad,
        DC.precio,C.Fecha From detallecompra As DC inner join compras AS C ON DC.idCompra = C.IdCompra 
        inner join provedores AS P ON DC.idProvedor = P.idProvedor inner join sucursales AS S ON C.claveS = S.claveS 
        Where DC.idProvedor = " & txtIdProvedor.Text
        lector = comando.ExecuteReader
        While lector.Read()
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            res = True
        End While
        If res <> True Then
            MsgBox("No se ha hecho ninguna compra a este proveedor")
        End If
        lector.Close()
    End Sub

    Private Sub frmComprasPorProvedor_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conexion.Close()
    End Sub
End Class