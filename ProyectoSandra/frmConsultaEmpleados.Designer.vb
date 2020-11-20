<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultaEmpleados
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.idEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idDepartamentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seguroSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domicilio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idHorario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claveS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idEmpleado, Me.Nombre, Me.idDepartamentos, Me.seguroSocial, Me.Domicilio, Me.cp, Me.idHorario, Me.claveS})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(33, 104)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(727, 200)
        Me.DataGridView1.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(139, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(529, 51)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Consultar Empleado"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'idEmpleado
        '
        Me.idEmpleado.HeaderText = "idEmpleado"
        Me.idEmpleado.MinimumWidth = 6
        Me.idEmpleado.Name = "idEmpleado"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = " Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        '
        'idDepartamentos
        '
        Me.idDepartamentos.HeaderText = "idDepartamentos"
        Me.idDepartamentos.MinimumWidth = 6
        Me.idDepartamentos.Name = "idDepartamentos"
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
        'frmConsultaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 344)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmConsultaEmpleados"
        Me.Text = "frmConsultaEmpleados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents idEmpleado As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents idDepartamentos As DataGridViewTextBoxColumn
    Friend WithEvents seguroSocial As DataGridViewTextBoxColumn
    Friend WithEvents Domicilio As DataGridViewTextBoxColumn
    Friend WithEvents cp As DataGridViewTextBoxColumn
    Friend WithEvents idHorario As DataGridViewTextBoxColumn
    Friend WithEvents claveS As DataGridViewTextBoxColumn
End Class

