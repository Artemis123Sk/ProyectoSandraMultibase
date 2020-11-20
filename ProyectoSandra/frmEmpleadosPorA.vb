Imports Npgsql
Public Class frmEmpleadosPorA
    Dim Myconnection As New Npgsql.NpgsqlConnection
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
    End Sub
End Class