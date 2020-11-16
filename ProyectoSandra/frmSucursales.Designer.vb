<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSucursales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lugar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.txtIdSucursal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(219, 169)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(85, 26)
        Me.btnModificar.TabIndex = 53
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(35, 169)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 26)
        Me.btnAgregar.TabIndex = 51
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Enabled = False
        Me.btnGrabar.Location = New System.Drawing.Point(133, 169)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(80, 26)
        Me.btnGrabar.TabIndex = 50
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(310, 169)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 26)
        Me.btnSalir.TabIndex = 52
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUltimo)
        Me.GroupBox2.Controls.Add(Me.btnInicio)
        Me.GroupBox2.Controls.Add(Me.btnSiguiente)
        Me.GroupBox2.Controls.Add(Me.btnAnterior)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 49)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(257, 13)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(75, 23)
        Me.btnUltimo.TabIndex = 43
        Me.btnUltimo.Text = "Ultimo"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(10, 13)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(75, 23)
        Me.btnInicio.TabIndex = 42
        Me.btnInicio.Text = "Inicio"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(95, 13)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 16
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(176, 13)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 23)
        Me.btnAnterior.TabIndex = 17
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSucursal, Me.lugar})
        Me.DataGridView1.Location = New System.Drawing.Point(399, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(271, 180)
        Me.DataGridView1.TabIndex = 48
        '
        'idSucursal
        '
        Me.idSucursal.HeaderText = "idSucursal"
        Me.idSucursal.Name = "idSucursal"
        '
        'lugar
        '
        Me.lugar.HeaderText = "Lugar"
        Me.lugar.Name = "lugar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLugar)
        Me.GroupBox1.Controls.Add(Me.txtIdSucursal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(49, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 93)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(125, 51)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(159, 20)
        Me.txtLugar.TabIndex = 42
        '
        'txtIdSucursal
        '
        Me.txtIdSucursal.Enabled = False
        Me.txtIdSucursal.Location = New System.Drawing.Point(125, 16)
        Me.txtIdSucursal.Name = "txtIdSucursal"
        Me.txtIdSucursal.Size = New System.Drawing.Size(100, 20)
        Me.txtIdSucursal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Lugar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "idSucursal"
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Blue
        Me.lblTitulo.Location = New System.Drawing.Point(1, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(704, 38)
        Me.lblTitulo.TabIndex = 76
        Me.lblTitulo.Text = "Registrar sucursal"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 281)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSucursales"
        Me.Text = "frmSucursales"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGrabar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents idSucursal As DataGridViewTextBoxColumn
    Friend WithEvents lugar As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtLugar As TextBox
    Friend WithEvents txtIdSucursal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitulo As Label
End Class
