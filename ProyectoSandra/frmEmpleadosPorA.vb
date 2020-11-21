Imports Npgsql
Public Class frmEmpleadosPorA
    Dim Myconnection As New Npgsql.NpgsqlConnection
    Dim command As Npgsql.NpgsqlCommand
    Dim lector As NpgsqlDataReader
    Private Sub frmEmpleadosPorA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Myconnection.ConnectionString = "Server=localhost;Port=5432; Database=lala;UserId=postgres;Password=bts"
            Myconnection.Open()

            If Myconnection.State = ConnectionState.Open Then
                MessageBox.Show("conectado")
            Else
                MessageBox.Show("Error de coneccion")
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try

        command = New Npgsql.NpgsqlCommand("select * from Empleados;", Myconnection)
        lector = Command.ExecuteReader()
        While lector.Read()
            cboCp.Items.Add(lector(5))
        End While
        lector.Close()
    End Sub

    Private Sub cboDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCp.SelectedIndexChanged
        Dim command = New Npgsql.NpgsqlCommand("select * from Empleados where cp = '" & cboCp.Text & "'", Myconnection)
        lector = command.ExecuteReader()

        While lector.Read()
            DataGridView1.Rows.Add(lector(0), lector(1), lector(6), lector(7))
        End While
        lector.Close()
    End Sub
End Class