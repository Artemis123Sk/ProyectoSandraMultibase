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
        Me.ProvedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasPorProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasPorProvedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosPorCPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProvedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.HorariosToolStripMenuItem, Me.DepartamentosToolStripMenuItem, Me.SucursalesToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.OperacionesToolStripMenuItem.Text = "Catálogos"
        '
        'ProvedoresToolStripMenuItem
        '
        Me.ProvedoresToolStripMenuItem.Name = "ProvedoresToolStripMenuItem"
        Me.ProvedoresToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.ProvedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'SucursalesToolStripMenuItem
        '
        Me.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem"
        Me.SucursalesToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.SucursalesToolStripMenuItem.Text = "Sucursales"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosToolStripMenuItem1, Me.RegistrarComprasToolStripMenuItem, Me.ContratarEmpleadoToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'PedidosToolStripMenuItem1
        '
        Me.PedidosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarPedidosToolStripMenuItem})
        Me.PedidosToolStripMenuItem1.Name = "PedidosToolStripMenuItem1"
        Me.PedidosToolStripMenuItem1.Size = New System.Drawing.Size(226, 26)
        Me.PedidosToolStripMenuItem1.Text = "Registrar pedidos"
        '
        'ConsultarPedidosToolStripMenuItem
        '
        Me.ConsultarPedidosToolStripMenuItem.Name = "ConsultarPedidosToolStripMenuItem"
        Me.ConsultarPedidosToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.ConsultarPedidosToolStripMenuItem.Text = "Consultar pedidos"
        '
        'RegistrarComprasToolStripMenuItem
        '
        Me.RegistrarComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarComprasToolStripMenuItem})
        Me.RegistrarComprasToolStripMenuItem.Name = "RegistrarComprasToolStripMenuItem"
        Me.RegistrarComprasToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.RegistrarComprasToolStripMenuItem.Text = "Registrar Compras"
        '
        'ConsultarComprasToolStripMenuItem
        '
        Me.ConsultarComprasToolStripMenuItem.Name = "ConsultarComprasToolStripMenuItem"
        Me.ConsultarComprasToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ConsultarComprasToolStripMenuItem.Text = "Consultar Compras"
        '
        'ContratarEmpleadoToolStripMenuItem
        '
        Me.ContratarEmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaEmpleadosToolStripMenuItem})
        Me.ContratarEmpleadoToolStripMenuItem.Name = "ContratarEmpleadoToolStripMenuItem"
        Me.ContratarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(226, 26)
        Me.ContratarEmpleadoToolStripMenuItem.Text = "Contratar Empleado"
        '
        'ConsultaEmpleadosToolStripMenuItem
        '
        Me.ConsultaEmpleadosToolStripMenuItem.Name = "ConsultaEmpleadosToolStripMenuItem"
        Me.ConsultaEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.ConsultaEmpleadosToolStripMenuItem.Text = "Consulta Empleados"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasPorProductosToolStripMenuItem, Me.ComprasPorProvedoresToolStripMenuItem, Me.EmpleadosPorCPToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentasPorProductosToolStripMenuItem
        '
        Me.VentasPorProductosToolStripMenuItem.Name = "VentasPorProductosToolStripMenuItem"
        Me.VentasPorProductosToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
        Me.VentasPorProductosToolStripMenuItem.Text = "Ventas por Productos"
        '
        'ComprasPorProvedoresToolStripMenuItem
        '
        Me.ComprasPorProvedoresToolStripMenuItem.Name = "ComprasPorProvedoresToolStripMenuItem"
        Me.ComprasPorProvedoresToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
        Me.ComprasPorProvedoresToolStripMenuItem.Text = "Compras por provedores"
        '
        'EmpleadosPorCPToolStripMenuItem
        '
        Me.EmpleadosPorCPToolStripMenuItem.Name = "EmpleadosPorCPToolStripMenuItem"
        Me.EmpleadosPorCPToolStripMenuItem.Size = New System.Drawing.Size(257, 26)
        Me.EmpleadosPorCPToolStripMenuItem.Text = "Empleados por C.P."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents VentasPorProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasPorProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SucursalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarPedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosPorCPToolStripMenuItem As ToolStripMenuItem
End Class
