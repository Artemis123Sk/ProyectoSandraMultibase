Imports Npgsql
Public Class frmConsultaEmpleados
    Dim Myconnection As New Npgsql.NpgsqlConnection
    Dim command As Npgsql.NpgsqlCommand
    Dim lector As NpgsqlDataReader
    Private Sub frmConsultaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        DataGridView1.Rows.Clear()

        Dim command As Npgsql.NpgsqlCommand = New Npgsql.NpgsqlCommand("select * from Empleados;", Myconnection)
        command.ExecuteNonQuery()
        While lector.Read()
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7))
        End While
        lector.Close()
    End Sub
End Class