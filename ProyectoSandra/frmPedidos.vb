Imports System.Data.SqlClient
Public Class frmPedidos
    Dim conexion As New SqlConnection("Data Source = MMHH66M\SQLEXPRESS; Database=lala; Integrated Security = True")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim n, n1 As Integer
    Dim n2 As Integer

    Private Sub cboidSucursal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboidSucursal.SelectedIndexChanged
        comando.CommandText = "Select * from  sucursales where claveS=" & cboidSucursal.Text
        lector = comando.ExecuteReader
        lector.Read()
        txtLugar.Text = lector(1)
        n = lector(0)
        lector.Close()
    End Sub

    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged
        comando.CommandText = "Select * from  Clientes where nombreOrazonS='" & cboNombre.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtidCliente.Text = lector(0)
        n1 = lector(0)
        txtdireccion.Text = lector(2)
        txtcp.Text = lector(3)
        lector.Close()
    End Sub

    Private Sub cboProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProducto.SelectedIndexChanged
        comando.CommandText = "Select count(idProducto) from Productos where nombre='" & cboNombre.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        txtidProducto.Text = CInt(lector(0)) + 1
        n2 = lector(0)
        lector.Close()
    End Sub

    Private Sub btnAgregarProd_Click(sender As Object, e As EventArgs) Handles btnAgregarProd.Click
        Dim total As Single = 0
        Dim con As Integer = 0
        If con <= 0 Then
            total += CDbl(txtPrecio.Text) * CInt(txtCantidad.Text)
            dvRejilla.Rows.Add(txtidProducto.Text, cboProducto.Text, txtCantidad.Text, txtPrecio.Text, total)
            con += 1
        Else
            total += CDbl(txtPrecio.Text) * CInt(txtCantidad.Text)
            dvRejilla.Rows.Add(txtidProducto.Text, cboProducto.Text, txtCantidad.Text, txtPrecio.Text, total)
            con += 1
        End If
        Dim tot As Single
        Dim Col As Integer = Me.dvRejilla.CurrentCell.ColumnIndex
        For Each row As DataGridViewRow In Me.dvRejilla.Rows
            tot += Val(row.Cells(4).Value)
        Next
        txtTotal.Text = tot.ToString
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim s As String = ""
            Dim filas As Integer
            filas = dvRejilla.RowCount
            If filas > 1 Then
                filas -= 2
                If filas = -1 Then
                    filas = 0
                End If
                For i = 0 To filas
                    s = Replace(dvRejilla.Item(3, i).Value, ",", ".")
                    s = "insert into detallePedido(idPedido, idProducto, cantidad, precio) values (" & txtIdPedido.Text & ", " & txtidProducto.Text & ", " & dvRejilla.Item(2, i).Value & ", " & s & ")"
                    comando.CommandText = s
                    comando.ExecuteNonQuery()
                Next
                'comando.CommandText = "insert into compras(idCompra,claveS,total,fecha) values (" & txtIdcompra.Text & "," & cboIdS.Text & "," & Replace(txtTotal.Text, ",", ".") & ",'" & Today.Year & "-" & Today.Month & "-" & Today.Day & "')"
                comando.CommandText = "insert into Pedidos(idPedido, idCliente, claveS, fecha, total) values (" & txtIdPedido.Text & ", " & txtidCliente.Text & ", " & n & ", '" & Today.Year & "-" & Today.Month & "-" & Today.Day & "', " & txtTotal.Text & ")"
                comando.ExecuteNonQuery()
                txtCantidad.Text = ""
                txtPrecio.Text = ""
                txtIdPedido.Text = ""
                cboProducto.Text = ""
                txtTotal.Text = ""
                dvRejilla.Rows.Clear()
                cboNombre.Enabled = True
                MsgBox("Compra agregada correctamente")
            Else
                MsgBox("Antes de grabar agregue un producto")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        comando.CommandText = "SELECT count(idPedido) FROM Pedidos"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdPedido.Text = CInt(lector(0)) + 1
        lector.Close()
        GroupBox3.Enabled = True
        cboNombre.Enabled = True
        GroupBox2.Enabled = True
        btnAgregar.Enabled = False
        btnGuardar.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Dispose()
    End Sub

    Private Sub frmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "Select * from Clientes"
        lector = comando.ExecuteReader
        While lector.Read()
            cboNombre.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from Productos"
        lector = comando.ExecuteReader
        While lector.Read()
            cboProducto.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from sucursales"
        lector = comando.ExecuteReader
        While lector.Read()
            cboidSucursal.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub


End Class