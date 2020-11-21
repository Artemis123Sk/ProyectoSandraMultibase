Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class frmConsultaPedido
    Dim conexion As New SqlConnection("Data Source = MMHH66M\SQLEXPRESS; Database=lala; Integrated Security = True")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "select * from Pedidos"
        lector = comando.ExecuteReader
        While lector.Read()
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.Close()
        Dispose()
    End Sub

    Private Sub frmConsultaPedido_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        conexion.Close()
        Dispose()
    End Sub
End Class