<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpleados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboClaveS = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtSeguro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHoraSalida = New System.Windows.Forms.TextBox()
        Me.txtHoraEntrada = New System.Windows.Forms.TextBox()
        Me.txtTurno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboIdHorario = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtNombreD = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboIdDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idDepartamentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seguroSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idHorario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claveS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtLugar)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cboClaveS)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(36, 93)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(725, 73)
        Me.GroupBox3.TabIndex = 88
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sucursal"
        '
        'txtLugar
        '
        Me.txtLugar.Enabled = False
        Me.txtLugar.Location = New System.Drawing.Point(350, 30)
        Me.txtLugar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(354, 24)
        Me.txtLugar.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(282, 33)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 18)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Lugar:"
        '
        'cboClaveS
        '
        Me.cboClaveS.Enabled = False
        Me.cboClaveS.FormattingEnabled = True
        Me.cboClaveS.Location = New System.Drawing.Point(116, 26)
        Me.cboClaveS.Margin = New System.Windows.Forms.Padding(4)
        Me.cboClaveS.Name = "cboClaveS"
        Me.cboClaveS.Size = New System.Drawing.Size(127, 26)
        Me.cboClaveS.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 26)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 18)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "idClaveS:"
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(780, 120)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(123, 32)
        Me.btnAgregar.TabIndex = 92
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(780, 174)
        Me.btnGrabar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(123, 32)
        Me.btnGrabar.TabIndex = 91
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(778, 230)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(125, 32)
        Me.btnSalir.TabIndex = 93
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Location = New System.Drawing.Point(145, 59)
        Me.txtIdEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(132, 22)
        Me.txtIdEmpleado.TabIndex = 90
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(32, 60)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 24)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "idEmpleado:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCp)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.txtSeguro)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 174)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(725, 138)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "personal"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(104, 24)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(354, 22)
        Me.txtNombre.TabIndex = 57
        '
        'txtCp
        '
        Me.txtCp.Enabled = False
        Me.txtCp.Location = New System.Drawing.Point(562, 61)
        Me.txtCp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(131, 22)
        Me.txtCp.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(506, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "C.P:"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Enabled = False
        Me.txtDomicilio.Location = New System.Drawing.Point(104, 61)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(374, 22)
        Me.txtDomicilio.TabIndex = 55
        '
        'txtSeguro
        '
        Me.txtSeguro.Enabled = False
        Me.txtSeguro.Location = New System.Drawing.Point(143, 98)
        Me.txtSeguro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSeguro.Name = "txtSeguro"
        Me.txtSeguro.Size = New System.Drawing.Size(220, 22)
        Me.txtSeguro.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 61)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 18)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Domicilio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 18)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Seguro social:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(163, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(543, 47)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Contratar Empleado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHoraSalida)
        Me.GroupBox2.Controls.Add(Me.txtHoraEntrada)
        Me.GroupBox2.Controls.Add(Me.txtTurno)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cboIdHorario)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 320)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(726, 101)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Horario"
        '
        'txtHoraSalida
        '
        Me.txtHoraSalida.Enabled = False
        Me.txtHoraSalida.Location = New System.Drawing.Point(121, 65)
        Me.txtHoraSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoraSalida.Name = "txtHoraSalida"
        Me.txtHoraSalida.Size = New System.Drawing.Size(132, 22)
        Me.txtHoraSalida.TabIndex = 56
        '
        'txtHoraEntrada
        '
        Me.txtHoraEntrada.Enabled = False
        Me.txtHoraEntrada.Location = New System.Drawing.Point(585, 29)
        Me.txtHoraEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHoraEntrada.Name = "txtHoraEntrada"
        Me.txtHoraEntrada.Size = New System.Drawing.Size(132, 22)
        Me.txtHoraEntrada.TabIndex = 55
        '
        'txtTurno
        '
        Me.txtTurno.Enabled = False
        Me.txtTurno.Location = New System.Drawing.Point(307, 28)
        Me.txtTurno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(149, 22)
        Me.txtTurno.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Hora salida:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(463, 30)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 18)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Hora entrada:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(245, 29)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 18)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Turno:"
        '
        'cboIdHorario
        '
        Me.cboIdHorario.Enabled = False
        Me.cboIdHorario.FormattingEnabled = True
        Me.cboIdHorario.Location = New System.Drawing.Point(106, 25)
        Me.cboIdHorario.Margin = New System.Windows.Forms.Padding(4)
        Me.cboIdHorario.Name = "cboIdHorario"
        Me.cboIdHorario.Size = New System.Drawing.Size(127, 24)
        Me.cboIdHorario.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 27)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "idHorario:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNombreD)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.cboIdDepartamento)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Location = New System.Drawing.Point(36, 429)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(768, 68)
        Me.GroupBox4.TabIndex = 90
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Departamento"
        '
        'txtNombreD
        '
        Me.txtNombreD.Enabled = False
        Me.txtNombreD.Location = New System.Drawing.Point(382, 29)
        Me.txtNombreD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreD.Name = "txtNombreD"
        Me.txtNombreD.Size = New System.Drawing.Size(345, 22)
        Me.txtNombreD.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(298, 30)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 18)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Nombre:"
        '
        'cboIdDepartamento
        '
        Me.cboIdDepartamento.Enabled = False
        Me.cboIdDepartamento.FormattingEnabled = True
        Me.cboIdDepartamento.Location = New System.Drawing.Point(157, 27)
        Me.cboIdDepartamento.Margin = New System.Windows.Forms.Padding(4)
        Me.cboIdDepartamento.Name = "cboIdDepartamento"
        Me.cboIdDepartamento.Size = New System.Drawing.Size(127, 24)
        Me.cboIdDepartamento.TabIndex = 50
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 30)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(132, 18)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "idDepartamento:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idDepartamentos, Me.Nombre, Me.idEmpleado, Me.seguroSocial, Me.Domicilio, Me.cp, Me.idHorario, Me.claveS})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(35, 514)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(853, 141)
        Me.DataGridView1.TabIndex = 94
        '
        'idDepartamentos
        '
        Me.idDepartamentos.HeaderText = "idDepartamento"
        Me.idDepartamentos.MinimumWidth = 6
        Me.idDepartamentos.Name = "idDepartamentos"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "idEmpleado"
        Me.idEmpleado.MinimumWidth = 6
        Me.idEmpleado.Name = "idEmpleado"
        '
        'seguroSocial
        '
        Me.seguroSocial.HeaderText = "Seguro Social"
        Me.seguroSocial.MinimumWidth = 6
        Me.seguroSocial.Name = "seguroSocial"
        '
        'Domicilio
        '
        Me.Domicilio.HeaderText = "Domicilio"
        Me.Domicilio.MinimumWidth = 6
        Me.Domicilio.Name = "Domicilio"
        '
        'cp
        '
        Me.cp.HeaderText = "C.P."
        Me.cp.MinimumWidth = 6
        Me.cp.Name = "cp"
        '
        'idHorario
        '
        Me.idHorario.HeaderText = "idHorario"
        Me.idHorario.MinimumWidth = 6
        Me.idHorario.Name = "idHorario"
        '
        'claveS
        '
        Me.claveS.HeaderText = "ClaveS"
        Me.claveS.MinimumWidth = 6
        Me.claveS.Name = "claveS"
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 668)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtIdEmpleado)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmEmpleados"
        Me.Text = "frmEmpleados"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtLugar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboClaveS As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtIdEmpleado As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtSeguro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboIdHorario As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtHoraSalida As TextBox
    Friend WithEvents txtHoraEntrada As TextBox
    Friend WithEvents txtTurno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cboIdDepartamento As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNombreD As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents idDepartamentos As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents seguroSocial As DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As DataGridViewTextBoxColumn
    Friend WithEvents cp As DataGridViewTextBoxColumn
    Friend WithEvents idHorario As DataGridViewTextBoxColumn
    Friend WithEvents claveS As DataGridViewTextBoxColumn
    Friend WithEvents txtNombre As TextBox
End Class