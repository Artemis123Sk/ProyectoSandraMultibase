<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosPorAñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasPorProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasPorProvedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProvedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.HorariosToolStripMenuItem, Me.DepartamentosToolStripMenuItem, Me.SucursalesToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.OperacionesToolStripMenuItem.Text = "Catálogos"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosToolStripMenuItem1, Me.RegistrarComprasToolStripMenuItem, Me.ContratarEmpleadoToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'PedidosToolStripMenuItem1
        '
        Me.PedidosToolStripMenuItem1.Name = "PedidosToolStripMenuItem1"
        Me.PedidosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PedidosToolStripMenuItem1.Text = "Registrar pedidos"
        '
        'RegistrarComprasToolStripMenuItem
        '
        Me.RegistrarComprasToolStripMenuItem.Name = "RegistrarComprasToolStripMenuItem"
        Me.RegistrarComprasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrarComprasToolStripMenuItem.Text = "Registrar Compras"
        '
        'ContratarEmpleadoToolStripMenuItem
        '
        Me.ContratarEmpleadoToolStripMenuItem.Name = "ContratarEmpleadoToolStripMenuItem"
        Me.ContratarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContratarEmpleadoToolStripMenuItem.Text = "Contratar Empleado"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosPorAñoToolStripMenuItem, Me.VentasPorProductosToolStripMenuItem, Me.ComprasPorProvedoresToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EmpleadosPorAñoToolStripMenuItem
        '
        Me.EmpleadosPorAñoToolStripMenuItem.Name = "EmpleadosPorAñoToolStripMenuItem"
        Me.EmpleadosPorAñoToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EmpleadosPorAñoToolStripMenuItem.Text = "Empleados por año"
        '
        'VentasPorProductosToolStripMenuItem
        '
        Me.VentasPorProductosToolStripMenuItem.Name = "VentasPorProductosToolStripMenuItem"
        Me.VentasPorProductosToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.VentasPorProductosToolStripMenuItem.Text = "Ventas por Productos"
        '
        'ComprasPorProvedoresToolStripMenuItem
        '
        Me.ComprasPorProvedoresToolStripMenuItem.Name = "ComprasPorProvedoresToolStripMenuItem"
        Me.ComprasPorProvedoresToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ComprasPorProvedoresToolStripMenuItem.Text = "Compras por provedores"
        '
        'ProvedoresToolStripMenuItem
        '
        Me.ProvedoresToolStripMenuItem.Name = "ProvedoresToolStripMenuItem"
        Me.ProvedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProvedoresToolStripMenuItem.Text = "Provedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegistrarComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosPorAñoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasPorProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasPorProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As ToolStripMenuItem
End Class
