Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class frmCompras
    Dim conexion As MySqlConnection
    Dim comando As MySqlCommand
    Dim lector As MySqlDataReader
    Dim idsProvedor As String

    Private Sub frmCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        comando.CommandText = "Select claveS from sucursales"
        lector = comando.ExecuteReader
        While lector.Read()
            cboIdS.Items.Add(lector(0))
        End While
        lector.Close()
        txtTotal.Text = "0"
    End Sub
    Private Sub cboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNombre.SelectedIndexChanged
        Dim arr() As String = idsProvedor.Split(",")
        comando.CommandText = "Select * from provedores where idProvedor = " & arr(cboNombre.SelectedIndex)
        lector = comando.ExecuteReader
        lector.Read()

        txtIdProvedor.Text = lector(0)
        txtCelular.Text = lector(2)
        txtTelefono.Text = lector(3)
        lector.Close()
        GroupBox2.Enabled = True
    End Sub
    Private Sub cboIdS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdS.SelectedIndexChanged
        comando.CommandText = "Select * from sucursales where claveS = " & cboIdS.Text
        lector = comando.ExecuteReader
        lector.Read()
        txtLugar.Text = lector(1)
        lector.Close()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        comando.CommandText = "SELECT count(idCompra) FROM compras"
        lector = comando.ExecuteReader
        lector.Read()
        txtIdcompra.Text = CInt(lector(0)) + 1
        lector.Close()
        GroupBox1.Enabled = True
        GroupBox3.Enabled = True
        btnAgregar.Enabled = False
        btnSalir.Enabled = False
        btnGrabar.Enabled = True
        If cboNombre.Text <> "" Then
            GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub btnAgregarC_Click(sender As Object, e As EventArgs) Handles btnAgregarC.Click
        If txtConsepto.Text <> "" And txtCantidad.Text <> "" And txtPrecio.Text <> "" Then
            cboNombre.Enabled = False
            Dim totalS As Double = 0
            totalS += CDbl(txtPrecio.Text) * CInt(txtCantidad.Text)
            DataGridView1.Rows.Add(txtConsepto.Text, txtCantidad.Text, txtPrecio.Text, totalS)
            txtTotal.Text = CDbl(txtTotal.Text) + totalS
        Else
            MsgBox("Complete todos los campos del producto")
        End If

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            Dim s As String = ""
            Dim filas As Integer
            filas = DataGridView1.RowCount
            If filas > 1 Then
                filas -= 2
                If filas = -1 Then
                    filas = 0
                End If
                For i = 0 To filas
                    s = Replace(DataGridView1.Item(2, i).Value, ",", ".")
                    s = "insert into detallecompra(idCompra,idProvedor,concepto,cantidad,precio) values (" & txtIdcompra.Text & "," & txtIdProvedor.Text & ",'" & DataGridView1.Item(0, i).Value & "'," & DataGridView1.Item(1, i).Value & "," & s & ")"
                    comando.CommandText = s
                    comando.ExecuteNonQuery()
                Next
                comando.CommandText = "insert into compras(idCompra,claveS,total,fecha) values (" & txtIdcompra.Text & "," & cboIdS.Text & "," & Replace(txtTotal.Text, ",", ".") & ",'" & Today.Year & "-" & Today.Month & "-" & Today.Day & "')"
                comando.ExecuteNonQuery()
                txtCantidad.Text = ""
                txtPrecio.Text = ""
                txtIdcompra.Text = ""
                txtConsepto.Text = ""
                txtTotal.Text = ""
                DataGridView1.Rows.Clear()
                cboNombre.Enabled = True
                MsgBox("Compra agregada correctamente")
            Else
                MsgBox("Antes de grabar agregue un producto")
            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error al registrar la compra")
        End Try
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        btnAgregar.Enabled = True
        btnSalir.Enabled = True
        btnGrabar.Enabled = False
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Dispose()
    End Sub

    Private Sub frmCompras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conexion.Close()
    End Sub
End Class