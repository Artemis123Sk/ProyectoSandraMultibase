Imports System.ComponentModel
Imports Npgsql
Public Class frmEmpleados
    Dim Myconnection As New Npgsql.NpgsqlConnection
    Dim command As Npgsql.NpgsqlCommand
    Dim lector As NpgsqlDataReader
    Dim tabla As New DataTable
    Dim operacion As Integer
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Myconnection.ConnectionString = postgresC
            Myconnection.Open()
            update()

        Catch ex As Exception
            ''MessageBox.Show(Err.Description)
        End Try
        operacion = 0

        Dim command = New Npgsql.NpgsqlCommand("select * from sucursales;", Myconnection)
        lector = command.ExecuteReader()
        While lector.Read()
            cboClaveS.Items.Add(lector(0))
        End While
        lector.Close()

        command = New Npgsql.NpgsqlCommand("select * from Horario;", Myconnection)
        lector = command.ExecuteReader()
        While lector.Read()
            cboIdHorario.Items.Add(lector(0))
        End While
        lector.Close()

        command = New Npgsql.NpgsqlCommand("select * from Departamento;", Myconnection)
        lector = command.ExecuteReader()
        While lector.Read()
            cboIdDepartamento.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        cboClaveS.Enabled = True
        txtNombre.Enabled = True
        txtDomicilio.Enabled = True
        txtCp.Enabled = True
        txtSeguro.Enabled = True
        cboIdHorario.Enabled = True
        cboIdDepartamento.Enabled = True
        btnAgregar.Enabled = False
        btnGrabar.Enabled = True
        operacion = 1

        command = New Npgsql.NpgsqlCommand("select * from Empleados;", Myconnection)
        lector = command.ExecuteReader
        lector = command.ExecuteReader()
        Dim clave As Integer
        While lector.Read()
            clave = lector(0)
        End While
        lector.Close()
        clave = clave + 1
        txtIdEmpleado.Text = clave

    End Sub

    Private Sub cboClaveS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClaveS.SelectedIndexChanged
        Dim command = New Npgsql.NpgsqlCommand("select * from sucursales where claveS = " & cboClaveS.Text & "", Myconnection)
        lector = command.ExecuteReader()
        lector.Read()
        txtLugar.Text = lector(1)
        lector.Close()
    End Sub

    Private Sub cboIdHorario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdHorario.SelectedIndexChanged
        Dim command = New Npgsql.NpgsqlCommand("select * from Horario where idHorario = " & cboIdHorario.Text & "", Myconnection)
        lector = command.ExecuteReader()
        lector.Read()
        txtTurno.Text = lector(1)
        txtHoraEntrada.Text = lector(2)
        txtHoraSalida.Text = lector(3)
        lector.Close()
    End Sub

    Private Sub cboIdDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIdDepartamento.SelectedIndexChanged
        Dim command = New Npgsql.NpgsqlCommand("select * from Departamento where idDepartamentos = " & cboIdDepartamento.Text & "", Myconnection)
        lector = command.ExecuteReader()
        lector.Read()
        txtNombreD.Text = lector(1)
        lector.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim command As Npgsql.NpgsqlCommand = New Npgsql.NpgsqlCommand("insert into Empleados (idEmpleado , Nombre, idDepartamentos,  seguroSocial, Domicilio, cp, idHorario, claveS) values ('" & txtIdEmpleado.Text & "' , '" & txtNombre.Text & "', '" & cboIdDepartamento.Text & "', '" & txtSeguro.Text & "', '" & txtDomicilio.Text & "', '" & txtCp.Text & "', '" & cboIdHorario.Text & "', '" & cboClaveS.Text & "' );", Myconnection)
        command.ExecuteNonQuery()
        update()

        btnGrabar.Enabled = False
        btnAgregar.Enabled = True
    End Sub

    Private Sub update()
        DataGridView1.Rows.Clear()

        Dim command = New Npgsql.NpgsqlCommand("select * from Empleados;", Myconnection)
        lector = command.ExecuteReader()
        While lector.Read()
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))
        End While
        lector.Close()

        If Not DataGridView1.Rows.Count = 0 Then
            colocar(0)
        End If
    End Sub

    Private Sub colocar(fila As Integer)
        DataGridView1.CurrentCell = DataGridView1(0, fila)
        txtIdEmpleado.Text = DataGridView1.Item(0, fila).Value
        txtNombre.Text = DataGridView1.Item(1, fila).Value
        cboIdDepartamento.Text = DataGridView1.Item(2, fila).Value
        txtSeguro.Text = DataGridView1.Item(3, fila).Value
        txtDomicilio.Text = DataGridView1.Item(4, fila).Value
        txtCp.Text = DataGridView1.Item(5, fila).Value
        cboIdHorario.Text = DataGridView1.Item(6, fila).Value
        cboClaveS.Text = DataGridView1.Item(7, fila).Value
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Myconnection.Close()
        Dispose()
    End Sub

    Private Sub frmEmpleados_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Myconnection.Close()
    End Sub
End Class