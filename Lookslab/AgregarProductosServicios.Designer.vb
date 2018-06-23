<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProductosServicios
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NuevoProducto = New System.Windows.Forms.RadioButton()
        Me.NuevoServicio = New System.Windows.Forms.RadioButton()
        Me.TitleTxtLbl = New System.Windows.Forms.Label()
        Me.FormNuevoProducto = New System.Windows.Forms.GroupBox()
        Me.ProductoSinCodigo = New System.Windows.Forms.LinkLabel()
        Me.DescartarProd = New System.Windows.Forms.Button()
        Me.GuardarProd = New System.Windows.Forms.Button()
        Me.GuardarProv = New System.Windows.Forms.Button()
        Me.lblemailrep = New System.Windows.Forms.Label()
        Me.CorreoProv = New System.Windows.Forms.TextBox()
        Me.TelefonoProv = New System.Windows.Forms.TextBox()
        Me.lbltelrep = New System.Windows.Forms.Label()
        Me.AgregarProveedor = New System.Windows.Forms.Button()
        Me.TotalCompraProductos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CantidadAStock = New System.Windows.Forms.TextBox()
        Me.RepresentanteProv = New System.Windows.Forms.TextBox()
        Me.NombreProv = New System.Windows.Forms.TextBox()
        Me.ListaProveedores = New System.Windows.Forms.ComboBox()
        Me.PrecioPorUnidad = New System.Windows.Forms.TextBox()
        Me.CostoUnitario = New System.Windows.Forms.TextBox()
        Me.DescProd = New System.Windows.Forms.TextBox()
        Me.NombreProd = New System.Windows.Forms.TextBox()
        Me.CodigoProd = New System.Windows.Forms.TextBox()
        Me.lblprov = New System.Windows.Forms.Label()
        Me.lblrep = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FormNuevoServicio = New System.Windows.Forms.GroupBox()
        Me.NuevoCodigo = New System.Windows.Forms.Button()
        Me.DescartarServ = New System.Windows.Forms.Button()
        Me.GuardarServ = New System.Windows.Forms.Button()
        Me.Guardarcategoria = New System.Windows.Forms.Button()
        Me.AgregarCategoria = New System.Windows.Forms.Button()
        Me.txtcategoria = New System.Windows.Forms.TextBox()
        Me.CategoriaServ = New System.Windows.Forms.ComboBox()
        Me.CostServ = New System.Windows.Forms.TextBox()
        Me.DescServ = New System.Windows.Forms.TextBox()
        Me.NombreServ = New System.Windows.Forms.TextBox()
        Me.CodigoServ = New System.Windows.Forms.TextBox()
        Me.lblcategoria = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.FormNuevoProducto.SuspendLayout()
        Me.FormNuevoServicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 25)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(672, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alta de productos y servicios"
        '
        'NuevoProducto
        '
        Me.NuevoProducto.AutoSize = True
        Me.NuevoProducto.Location = New System.Drawing.Point(12, 49)
        Me.NuevoProducto.Name = "NuevoProducto"
        Me.NuevoProducto.Size = New System.Drawing.Size(102, 17)
        Me.NuevoProducto.TabIndex = 1
        Me.NuevoProducto.TabStop = True
        Me.NuevoProducto.Text = "Nuevo producto"
        Me.NuevoProducto.UseVisualStyleBackColor = True
        '
        'NuevoServicio
        '
        Me.NuevoServicio.AutoSize = True
        Me.NuevoServicio.Location = New System.Drawing.Point(120, 49)
        Me.NuevoServicio.Name = "NuevoServicio"
        Me.NuevoServicio.Size = New System.Drawing.Size(96, 17)
        Me.NuevoServicio.TabIndex = 2
        Me.NuevoServicio.TabStop = True
        Me.NuevoServicio.Text = "Nuevo servicio"
        Me.NuevoServicio.UseVisualStyleBackColor = True
        '
        'TitleTxtLbl
        '
        Me.TitleTxtLbl.AutoSize = True
        Me.TitleTxtLbl.Location = New System.Drawing.Point(4, 33)
        Me.TitleTxtLbl.Name = "TitleTxtLbl"
        Me.TitleTxtLbl.Size = New System.Drawing.Size(137, 13)
        Me.TitleTxtLbl.TabIndex = 2
        Me.TitleTxtLbl.Text = "Elegir categoría para el alta"
        '
        'FormNuevoProducto
        '
        Me.FormNuevoProducto.Controls.Add(Me.ProductoSinCodigo)
        Me.FormNuevoProducto.Controls.Add(Me.DescartarProd)
        Me.FormNuevoProducto.Controls.Add(Me.GuardarProd)
        Me.FormNuevoProducto.Controls.Add(Me.GuardarProv)
        Me.FormNuevoProducto.Controls.Add(Me.lblemailrep)
        Me.FormNuevoProducto.Controls.Add(Me.CorreoProv)
        Me.FormNuevoProducto.Controls.Add(Me.TelefonoProv)
        Me.FormNuevoProducto.Controls.Add(Me.lbltelrep)
        Me.FormNuevoProducto.Controls.Add(Me.AgregarProveedor)
        Me.FormNuevoProducto.Controls.Add(Me.TotalCompraProductos)
        Me.FormNuevoProducto.Controls.Add(Me.Label11)
        Me.FormNuevoProducto.Controls.Add(Me.Label10)
        Me.FormNuevoProducto.Controls.Add(Me.CantidadAStock)
        Me.FormNuevoProducto.Controls.Add(Me.RepresentanteProv)
        Me.FormNuevoProducto.Controls.Add(Me.NombreProv)
        Me.FormNuevoProducto.Controls.Add(Me.ListaProveedores)
        Me.FormNuevoProducto.Controls.Add(Me.PrecioPorUnidad)
        Me.FormNuevoProducto.Controls.Add(Me.CostoUnitario)
        Me.FormNuevoProducto.Controls.Add(Me.DescProd)
        Me.FormNuevoProducto.Controls.Add(Me.NombreProd)
        Me.FormNuevoProducto.Controls.Add(Me.CodigoProd)
        Me.FormNuevoProducto.Controls.Add(Me.lblprov)
        Me.FormNuevoProducto.Controls.Add(Me.lblrep)
        Me.FormNuevoProducto.Controls.Add(Me.Label7)
        Me.FormNuevoProducto.Controls.Add(Me.Label6)
        Me.FormNuevoProducto.Controls.Add(Me.Label5)
        Me.FormNuevoProducto.Controls.Add(Me.Label4)
        Me.FormNuevoProducto.Controls.Add(Me.Label3)
        Me.FormNuevoProducto.Controls.Add(Me.Label2)
        Me.FormNuevoProducto.Location = New System.Drawing.Point(7, 72)
        Me.FormNuevoProducto.Name = "FormNuevoProducto"
        Me.FormNuevoProducto.Size = New System.Drawing.Size(682, 300)
        Me.FormNuevoProducto.TabIndex = 3
        Me.FormNuevoProducto.TabStop = False
        Me.FormNuevoProducto.Text = "Alta de Producto"
        Me.FormNuevoProducto.Visible = False
        '
        'ProductoSinCodigo
        '
        Me.ProductoSinCodigo.AutoSize = True
        Me.ProductoSinCodigo.Location = New System.Drawing.Point(273, 30)
        Me.ProductoSinCodigo.Name = "ProductoSinCodigo"
        Me.ProductoSinCodigo.Size = New System.Drawing.Size(101, 13)
        Me.ProductoSinCodigo.TabIndex = 28
        Me.ProductoSinCodigo.TabStop = True
        Me.ProductoSinCodigo.Text = "Producto sin codigo"
        '
        'DescartarProd
        '
        Me.DescartarProd.Location = New System.Drawing.Point(154, 224)
        Me.DescartarProd.Name = "DescartarProd"
        Me.DescartarProd.Size = New System.Drawing.Size(139, 23)
        Me.DescartarProd.TabIndex = 27
        Me.DescartarProd.Text = "Descartar Cambios"
        Me.DescartarProd.UseVisualStyleBackColor = True
        '
        'GuardarProd
        '
        Me.GuardarProd.Location = New System.Drawing.Point(9, 224)
        Me.GuardarProd.Name = "GuardarProd"
        Me.GuardarProd.Size = New System.Drawing.Size(139, 23)
        Me.GuardarProd.TabIndex = 26
        Me.GuardarProd.Text = "Guardar productos"
        Me.GuardarProd.UseVisualStyleBackColor = True
        '
        'GuardarProv
        '
        Me.GuardarProv.Location = New System.Drawing.Point(382, 224)
        Me.GuardarProv.Name = "GuardarProv"
        Me.GuardarProv.Size = New System.Drawing.Size(139, 23)
        Me.GuardarProv.TabIndex = 25
        Me.GuardarProv.Text = "Guardar proveedor"
        Me.GuardarProv.UseVisualStyleBackColor = True
        Me.GuardarProv.Visible = False
        '
        'lblemailrep
        '
        Me.lblemailrep.AutoSize = True
        Me.lblemailrep.Location = New System.Drawing.Point(380, 184)
        Me.lblemailrep.Name = "lblemailrep"
        Me.lblemailrep.Size = New System.Drawing.Size(117, 13)
        Me.lblemailrep.TabIndex = 24
        Me.lblemailrep.Text = "Email del representante"
        Me.lblemailrep.Visible = False
        '
        'CorreoProv
        '
        Me.CorreoProv.Location = New System.Drawing.Point(519, 181)
        Me.CorreoProv.Name = "CorreoProv"
        Me.CorreoProv.Size = New System.Drawing.Size(157, 20)
        Me.CorreoProv.TabIndex = 12
        Me.CorreoProv.Visible = False
        '
        'TelefonoProv
        '
        Me.TelefonoProv.Location = New System.Drawing.Point(519, 154)
        Me.TelefonoProv.Name = "TelefonoProv"
        Me.TelefonoProv.Size = New System.Drawing.Size(157, 20)
        Me.TelefonoProv.TabIndex = 11
        Me.TelefonoProv.Visible = False
        '
        'lbltelrep
        '
        Me.lbltelrep.AutoSize = True
        Me.lbltelrep.Location = New System.Drawing.Point(379, 157)
        Me.lbltelrep.Name = "lbltelrep"
        Me.lbltelrep.Size = New System.Drawing.Size(134, 13)
        Me.lbltelrep.TabIndex = 21
        Me.lbltelrep.Text = "Telefono del representante"
        Me.lbltelrep.Visible = False
        '
        'AgregarProveedor
        '
        Me.AgregarProveedor.Location = New System.Drawing.Point(442, 55)
        Me.AgregarProveedor.Name = "AgregarProveedor"
        Me.AgregarProveedor.Size = New System.Drawing.Size(234, 23)
        Me.AgregarProveedor.TabIndex = 20
        Me.AgregarProveedor.Text = "El proveedor no esta en la lista"
        Me.AgregarProveedor.UseVisualStyleBackColor = True
        '
        'TotalCompraProductos
        '
        Me.TotalCompraProductos.Location = New System.Drawing.Point(82, 185)
        Me.TotalCompraProductos.Name = "TotalCompraProductos"
        Me.TotalCompraProductos.Size = New System.Drawing.Size(92, 20)
        Me.TotalCompraProductos.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Coste total   $"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Unidades a Inventario"
        '
        'CantidadAStock
        '
        Me.CantidadAStock.Location = New System.Drawing.Point(118, 157)
        Me.CantidadAStock.Name = "CantidadAStock"
        Me.CantidadAStock.Size = New System.Drawing.Size(56, 20)
        Me.CantidadAStock.TabIndex = 6
        '
        'RepresentanteProv
        '
        Me.RepresentanteProv.Location = New System.Drawing.Point(519, 127)
        Me.RepresentanteProv.Name = "RepresentanteProv"
        Me.RepresentanteProv.Size = New System.Drawing.Size(157, 20)
        Me.RepresentanteProv.TabIndex = 10
        Me.RepresentanteProv.Visible = False
        '
        'NombreProv
        '
        Me.NombreProv.Location = New System.Drawing.Point(476, 102)
        Me.NombreProv.Name = "NombreProv"
        Me.NombreProv.Size = New System.Drawing.Size(200, 20)
        Me.NombreProv.TabIndex = 9
        Me.NombreProv.Visible = False
        '
        'ListaProveedores
        '
        Me.ListaProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListaProveedores.FormattingEnabled = True
        Me.ListaProveedores.Location = New System.Drawing.Point(442, 27)
        Me.ListaProveedores.Name = "ListaProveedores"
        Me.ListaProveedores.Size = New System.Drawing.Size(234, 21)
        Me.ListaProveedores.TabIndex = 8
        '
        'PrecioPorUnidad
        '
        Me.PrecioPorUnidad.Location = New System.Drawing.Point(105, 131)
        Me.PrecioPorUnidad.Name = "PrecioPorUnidad"
        Me.PrecioPorUnidad.Size = New System.Drawing.Size(69, 20)
        Me.PrecioPorUnidad.TabIndex = 5
        '
        'CostoUnitario
        '
        Me.CostoUnitario.Location = New System.Drawing.Point(105, 105)
        Me.CostoUnitario.Name = "CostoUnitario"
        Me.CostoUnitario.Size = New System.Drawing.Size(69, 20)
        Me.CostoUnitario.TabIndex = 4
        '
        'DescProd
        '
        Me.DescProd.Location = New System.Drawing.Point(87, 79)
        Me.DescProd.Name = "DescProd"
        Me.DescProd.Size = New System.Drawing.Size(287, 20)
        Me.DescProd.TabIndex = 3
        '
        'NombreProd
        '
        Me.NombreProd.Location = New System.Drawing.Point(118, 53)
        Me.NombreProd.Name = "NombreProd"
        Me.NombreProd.Size = New System.Drawing.Size(256, 20)
        Me.NombreProd.TabIndex = 2
        '
        'CodigoProd
        '
        Me.CodigoProd.Location = New System.Drawing.Point(109, 27)
        Me.CodigoProd.Name = "CodigoProd"
        Me.CodigoProd.Size = New System.Drawing.Size(158, 20)
        Me.CodigoProd.TabIndex = 1
        '
        'lblprov
        '
        Me.lblprov.AutoSize = True
        Me.lblprov.Location = New System.Drawing.Point(379, 105)
        Me.lblprov.Name = "lblprov"
        Me.lblprov.Size = New System.Drawing.Size(90, 13)
        Me.lblprov.TabIndex = 7
        Me.lblprov.Text = "Nuevo proveedor"
        Me.lblprov.Visible = False
        '
        'lblrep
        '
        Me.lblrep.AutoSize = True
        Me.lblrep.Location = New System.Drawing.Point(380, 130)
        Me.lblrep.Name = "lblrep"
        Me.lblrep.Size = New System.Drawing.Size(129, 13)
        Me.lblrep.TabIndex = 6
        Me.lblrep.Text = "Nombre del representante"
        Me.lblrep.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(380, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Proveedor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Precio de venta   $"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Costo por unidad  $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre del producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo del producto"
        '
        'FormNuevoServicio
        '
        Me.FormNuevoServicio.Controls.Add(Me.NuevoCodigo)
        Me.FormNuevoServicio.Controls.Add(Me.DescartarServ)
        Me.FormNuevoServicio.Controls.Add(Me.GuardarServ)
        Me.FormNuevoServicio.Controls.Add(Me.Guardarcategoria)
        Me.FormNuevoServicio.Controls.Add(Me.AgregarCategoria)
        Me.FormNuevoServicio.Controls.Add(Me.txtcategoria)
        Me.FormNuevoServicio.Controls.Add(Me.CategoriaServ)
        Me.FormNuevoServicio.Controls.Add(Me.CostServ)
        Me.FormNuevoServicio.Controls.Add(Me.DescServ)
        Me.FormNuevoServicio.Controls.Add(Me.NombreServ)
        Me.FormNuevoServicio.Controls.Add(Me.CodigoServ)
        Me.FormNuevoServicio.Controls.Add(Me.lblcategoria)
        Me.FormNuevoServicio.Controls.Add(Me.Label20)
        Me.FormNuevoServicio.Controls.Add(Me.Label21)
        Me.FormNuevoServicio.Controls.Add(Me.Label23)
        Me.FormNuevoServicio.Controls.Add(Me.Label24)
        Me.FormNuevoServicio.Controls.Add(Me.Label25)
        Me.FormNuevoServicio.Location = New System.Drawing.Point(7, 72)
        Me.FormNuevoServicio.Name = "FormNuevoServicio"
        Me.FormNuevoServicio.Size = New System.Drawing.Size(682, 300)
        Me.FormNuevoServicio.TabIndex = 28
        Me.FormNuevoServicio.TabStop = False
        Me.FormNuevoServicio.Text = "Alta de Servicio"
        Me.FormNuevoServicio.Visible = False
        '
        'NuevoCodigo
        '
        Me.NuevoCodigo.Location = New System.Drawing.Point(235, 24)
        Me.NuevoCodigo.Name = "NuevoCodigo"
        Me.NuevoCodigo.Size = New System.Drawing.Size(106, 23)
        Me.NuevoCodigo.TabIndex = 28
        Me.NuevoCodigo.Text = "Asignar Código"
        Me.NuevoCodigo.UseVisualStyleBackColor = True
        '
        'DescartarServ
        '
        Me.DescartarServ.Location = New System.Drawing.Point(167, 134)
        Me.DescartarServ.Name = "DescartarServ"
        Me.DescartarServ.Size = New System.Drawing.Size(139, 23)
        Me.DescartarServ.TabIndex = 27
        Me.DescartarServ.Text = "Descartar Cambios"
        Me.DescartarServ.UseVisualStyleBackColor = True
        '
        'GuardarServ
        '
        Me.GuardarServ.Location = New System.Drawing.Point(9, 134)
        Me.GuardarServ.Name = "GuardarServ"
        Me.GuardarServ.Size = New System.Drawing.Size(139, 23)
        Me.GuardarServ.TabIndex = 26
        Me.GuardarServ.Text = "Guardar servicio"
        Me.GuardarServ.UseVisualStyleBackColor = True
        '
        'Guardarcategoria
        '
        Me.Guardarcategoria.Location = New System.Drawing.Point(383, 134)
        Me.Guardarcategoria.Name = "Guardarcategoria"
        Me.Guardarcategoria.Size = New System.Drawing.Size(126, 23)
        Me.Guardarcategoria.TabIndex = 25
        Me.Guardarcategoria.Text = "Guardar Categoria"
        Me.Guardarcategoria.UseVisualStyleBackColor = True
        Me.Guardarcategoria.Visible = False
        '
        'AgregarCategoria
        '
        Me.AgregarCategoria.Location = New System.Drawing.Point(442, 55)
        Me.AgregarCategoria.Name = "AgregarCategoria"
        Me.AgregarCategoria.Size = New System.Drawing.Size(234, 23)
        Me.AgregarCategoria.TabIndex = 20
        Me.AgregarCategoria.Text = "La categoria no esta en la lista"
        Me.AgregarCategoria.UseVisualStyleBackColor = True
        '
        'txtcategoria
        '
        Me.txtcategoria.Location = New System.Drawing.Point(476, 102)
        Me.txtcategoria.Name = "txtcategoria"
        Me.txtcategoria.Size = New System.Drawing.Size(200, 20)
        Me.txtcategoria.TabIndex = 14
        Me.txtcategoria.Visible = False
        '
        'CategoriaServ
        '
        Me.CategoriaServ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoriaServ.FormattingEnabled = True
        Me.CategoriaServ.Location = New System.Drawing.Point(442, 27)
        Me.CategoriaServ.Name = "CategoriaServ"
        Me.CategoriaServ.Size = New System.Drawing.Size(234, 21)
        Me.CategoriaServ.TabIndex = 13
        '
        'CostServ
        '
        Me.CostServ.Location = New System.Drawing.Point(105, 105)
        Me.CostServ.Name = "CostServ"
        Me.CostServ.Size = New System.Drawing.Size(69, 20)
        Me.CostServ.TabIndex = 12
        '
        'DescServ
        '
        Me.DescServ.Location = New System.Drawing.Point(87, 79)
        Me.DescServ.Name = "DescServ"
        Me.DescServ.Size = New System.Drawing.Size(287, 20)
        Me.DescServ.TabIndex = 10
        '
        'NombreServ
        '
        Me.NombreServ.Location = New System.Drawing.Point(118, 53)
        Me.NombreServ.Name = "NombreServ"
        Me.NombreServ.Size = New System.Drawing.Size(256, 20)
        Me.NombreServ.TabIndex = 9
        '
        'CodigoServ
        '
        Me.CodigoServ.Location = New System.Drawing.Point(109, 27)
        Me.CodigoServ.Name = "CodigoServ"
        Me.CodigoServ.ReadOnly = True
        Me.CodigoServ.Size = New System.Drawing.Size(120, 20)
        Me.CodigoServ.TabIndex = 8
        '
        'lblcategoria
        '
        Me.lblcategoria.AutoSize = True
        Me.lblcategoria.Location = New System.Drawing.Point(379, 105)
        Me.lblcategoria.Name = "lblcategoria"
        Me.lblcategoria.Size = New System.Drawing.Size(86, 13)
        Me.lblcategoria.TabIndex = 7
        Me.lblcategoria.Text = "Nueva categoria"
        Me.lblcategoria.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(380, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Categoria"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(2, 108)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Costo del servicio  $"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 13)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Descripcion"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 13)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Nombre del servicio"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 30)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Codigo del Servicio"
        '
        'AgregarProductosServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 407)
        Me.Controls.Add(Me.TitleTxtLbl)
        Me.Controls.Add(Me.NuevoServicio)
        Me.Controls.Add(Me.NuevoProducto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FormNuevoProducto)
        Me.Controls.Add(Me.FormNuevoServicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarProductosServicios"
        Me.Text = "AgregarProductosServicios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FormNuevoProducto.ResumeLayout(False)
        Me.FormNuevoProducto.PerformLayout()
        Me.FormNuevoServicio.ResumeLayout(False)
        Me.FormNuevoServicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NuevoProducto As RadioButton
    Friend WithEvents NuevoServicio As RadioButton
    Friend WithEvents TitleTxtLbl As Label
    Friend WithEvents FormNuevoProducto As GroupBox
    Friend WithEvents DescartarProd As Button
    Friend WithEvents GuardarProd As Button
    Friend WithEvents GuardarProv As Button
    Friend WithEvents lblemailrep As Label
    Friend WithEvents CorreoProv As TextBox
    Friend WithEvents TelefonoProv As TextBox
    Friend WithEvents lbltelrep As Label
    Friend WithEvents AgregarProveedor As Button
    Friend WithEvents TotalCompraProductos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CantidadAStock As TextBox
    Friend WithEvents RepresentanteProv As TextBox
    Friend WithEvents NombreProv As TextBox
    Friend WithEvents ListaProveedores As ComboBox
    Friend WithEvents PrecioPorUnidad As TextBox
    Friend WithEvents CostoUnitario As TextBox
    Friend WithEvents DescProd As TextBox
    Friend WithEvents NombreProd As TextBox
    Friend WithEvents CodigoProd As TextBox
    Friend WithEvents lblprov As Label
    Friend WithEvents lblrep As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FormNuevoServicio As GroupBox
    Friend WithEvents NuevoCodigo As Button
    Friend WithEvents DescartarServ As Button
    Friend WithEvents GuardarServ As Button
    Friend WithEvents Guardarcategoria As Button
    Friend WithEvents AgregarCategoria As Button
    Friend WithEvents txtcategoria As TextBox
    Friend WithEvents CategoriaServ As ComboBox
    Friend WithEvents CostServ As TextBox
    Friend WithEvents DescServ As TextBox
    Friend WithEvents NombreServ As TextBox
    Friend WithEvents CodigoServ As TextBox
    Friend WithEvents lblcategoria As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents ProductoSinCodigo As LinkLabel
End Class
