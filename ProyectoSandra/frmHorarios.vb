Imports Npgsql
Public Class FrmHorarios
    Dim Myconnection As New Npgsql.NpgsqlConnection
    Dim command As Npgsql.NpgsqlCommand
    Dim lector As NpgsqlDataReader
    Dim tabla As New DataTable
    Dim operacion As Integer
    Private Sub FrmHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Myconnection.ConnectionString = "Server=localhost;Port=5432; Database=lala;UserId=postgres;Password=bts"
            Myconnection.Open()
            update()

        Catch ex As Exception
            ''MessageBox.Show(Err.Description)
        End Try
        operacion = 0
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If operacion = 1 Then
            Dim command As Npgsql.NpgsqlCommand = New Npgsql.NpgsqlCommand("insert into Horario (idHorario, turno, HoraEntrada, HoraSalida ) values (" & txtIdHorario.Text & " , '" & txtTurno.Text & "', '" & txtHoraEntrada.Text & "', '" & txtHoraSalida.Text & "');", Myconnection)
            command.ExecuteNonQuery()
            update()
        Else

            Dim command As Npgsql.NpgsqlCommand = New Npgsql.NpgsqlCommand("update Horario set turno = '" & txtTurno.Text & "', HoraEntrada = '" & txtHoraEntrada.Text & "', HoraSalida = '" & txtHoraSalida.Text & "' where idHorario = " & txtIdHorario.Text & "", Myconnection)
            command.ExecuteNonQuery()
            update()
        End If

        btnGrabar.Enabled = False
        btnAgregar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtIdHorario.Enabled = True
        txtTurno.Enabled = True
        txtHoraEntrada.Enabled = True
        txtHoraSalida.Enabled = True
        btnAgregar.Enabled = False
        btnGrabar.Enabled = True
        operacion = 1
    End Sub

    Private Sub colocar(fila As Integer)
        DataGridView1.CurrentCell = DataGridView1(0, fila)
        txtIdHorario.Text = DataGridView1.Item(0, fila).Value
        txtTurno.Text = DataGridView1.Item(1, fila).Value
        txtHoraEntrada.Text = DataGridView1.Item(2, fila).Value
        txtHoraSalida.Text = DataGridView1.Item(3, fila).Value
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        txtIdHorario.Enabled = False
        txtTurno.Enabled = True
        txtHoraEntrada.Enabled = True
        txtHoraSalida.Enabled = True
        btnAgregar.Enabled = False
        btnGrabar.Enabled = True
        operacion = 2
    End Sub

    Private Sub update()
        DataGridView1.Rows.Clear()

        Dim command = New Npgsql.NpgsqlCommand("select * from Horario;", Myconnection)
        lector = command.ExecuteReader()
        While lector.Read()
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3))
        End While
        lector.Close()

        If Not DataGridView1.Rows.Count = 0 Then
            colocar(0)
        End If
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        colocar(0)
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim fila As Integer
        fila = DataGridView1.CurrentRow.Index
        fila += 1
        Dim filas As Integer
        filas = DataGridView1.RowCount
        If fila < filas - 1 Then
            colocar(fila)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim fila As Integer
        fila = DataGridView1.CurrentRow.Index
        fila -= 1
        If fila < 0 Then
            fila = 0
        End If
        colocar(fila)
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Dim filas As Integer
        filas = DataGridView1.RowCount
        filas -= 2
        If filas < 1 Then
            filas = 0
        End If
        colocar(filas)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Myconnection.Close()
        Dispose()
    End Sub
End Class