Public Class AgregarProductosServicios
    Dim NuevaCategoria As Integer = 0
    Dim NuevoProveedor As Integer = 0
    Dim SQL As New SQLConn
    Dim LBEv As New LBEvents
    Private Sub AgregarProductosServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SQL.HasConnection = True Then
            SQL.RunQuery("SELECT SupplierID, SupplierName FROM LBSuppliers")
            If SQL.SQLDS.Tables.Count > 0 Then
                ListaProveedores.DataSource = SQL.SQLDS.Tables(0)
                ListaProveedores.DisplayMember = "SupplierName"
                ListaProveedores.ValueMember = "SupplierID"
                ListaProveedores.SelectedIndex = -1
            End If
            SQL.RunQuery("SELECT IDCategoria, CategoriaServicio FROM LBCatServicios")
            If SQL.SQLDS.Tables.Count > 0 Then
                CategoriaServ.DataSource = SQL.SQLDS.Tables(0)
                CategoriaServ.DisplayMember = "CategoriaServicio"
                CategoriaServ.ValueMember = "IDCategoria"
                CategoriaServ.SelectedIndex = -1
            End If
        End If
    End Sub
    Private Sub CodigoProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CodigoProd.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub CostoUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CostoUnitario.KeyPress
        NumerosyDecimal(CostoUnitario, e)
    End Sub
    Private Sub PrecioPorUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrecioPorUnidad.KeyPress
        NumerosyDecimal(PrecioPorUnidad, e)
    End Sub

    Private Sub CantidadAStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantidadAStock.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TotalCompraProductos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TotalCompraProductos.KeyPress
        NumerosyDecimal(TotalCompraProductos, e)
    End Sub
    Private Sub CostServ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CostServ.KeyPress
        NumerosyDecimal(CostServ, e)
    End Sub

    Private Sub Guardarcategoria_Click(sender As Object, e As EventArgs) Handles Guardarcategoria.Click
        If txtcategoria.Text <> "" Then
            SQL.RunQuery("INSERT INTO LBCatServicios (CategoriaServicio) " &
                         "VALUES('" & txtcategoria.Text & "')")
            SQL.RunQuery("SELECT IDCategoria, CategoriaServicio FROM LBCatServicios")
            If SQL.SQLDS.Tables.Count > 0 Then
                CategoriaServ.DataSource = SQL.SQLDS.Tables(0)
                CategoriaServ.DisplayMember = "CategoriaServicio"
                CategoriaServ.ValueMember = "IDCategoria"
                CategoriaServ.SelectedIndex = -1
                MsgBox("Favor de validar las categorias nuevamente, ya se encuentra el nuevo registro de categoria", MsgBoxStyle.Information)
                lblcategoria.Visible = False
                txtcategoria.Visible = False
                Guardarcategoria.Visible = False
            End If
        Else
            MsgBox("Favor de ingresar la categoria", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub NuevoProducto_CheckedChanged(sender As Object, e As EventArgs) Handles NuevoProducto.CheckedChanged
        If NuevoProducto.Checked = True Then
            FormNuevoProducto.Visible = True
            FormNuevoServicio.Visible = False
        ElseIf NuevoServicio.Checked = True Then
            FormNuevoServicio.Visible = True
            FormNuevoProducto.Visible = False
        Else
            FormNuevoProducto.Visible = False
            FormNuevoServicio.Visible = False
        End If
    End Sub

    Private Sub AgregarProveedor_Click(sender As Object, e As EventArgs) Handles AgregarProveedor.Click
        lblprov.Visible = True
        lblrep.Visible = True
        lbltelrep.Visible = True
        lblemailrep.Visible = True
        NombreProv.Visible = True
        RepresentanteProv.Visible = True
        TelefonoProv.Visible = True
        CorreoProv.Visible = True
        GuardarProv.Visible = True
    End Sub

    Private Sub GuardarProv_Click(sender As Object, e As EventArgs) Handles GuardarProv.Click
        If NombreProv.Text <> "" And RepresentanteProv.Text <> "" And TelefonoProv.Text <> "" And CorreoProv.Text <> "" Then
            LBEv.AgregarProveedor(NombreProv.Text, RepresentanteProv.Text, TelefonoProv.Text, CorreoProv.Text)
            lblprov.Visible = False
            lblrep.Visible = False
            lbltelrep.Visible = False
            lblemailrep.Visible = False
            NombreProv.Visible = False
            RepresentanteProv.Visible = False
            TelefonoProv.Visible = False
            CorreoProv.Visible = False
            GuardarProv.Visible = False
            If SQL.HasConnection = True Then
                SQL.RunQuery("SELECT SupplierID, SupplierName FROM LBSuppliers")
                If SQL.SQLDS.Tables.Count > 0 Then
                    ListaProveedores.DataSource = SQL.SQLDS.Tables(0)
                    ListaProveedores.DisplayMember = "SupplierName"
                    ListaProveedores.ValueMember = "SupplierID"
                    MsgBox("Favor de validar nuevamente el combo de proveedores, ya aparecerá el nuevo proveedor registrado", MsgBoxStyle.Information)
                    LBEv.LogUsuario(PantallaPrincipal.CurrentUserID.Text, "Registro de Proveedor: " & NombreProv.Text & " FECHA: " & DateTime.Now.ToString)
                End If
            End If
        Else
            MsgBox("El formulario está incompleto, favor de llenar todos los datos necesarios", MsgBoxStyle.Critical, "Faltan datos del formulario")
        End If
    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As System.Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub GuardarProd_Click(sender As Object, e As EventArgs) Handles GuardarProd.Click
        If CodigoProd.Text <> "" And NombreProd.Text <> "" And DescProd.Text <> "" And CostoUnitario.Text <> "" And PrecioPorUnidad.Text <> "" And CantidadAStock.Text <> "" And TotalCompraProductos.Text <> "" And ListaProveedores.Text <> "" Then
            LBEv.AgregarProducto(CodigoProd.Text, NombreProd.Text, DescProd.Text, CostoUnitario.Text, CantidadAStock.Text, PrecioPorUnidad.Text, ListaProveedores.SelectedValue.ToString, TotalCompraProductos.Text)
        Else
            MsgBox("Faltan datos en el formulario, favor de ingresarlos antes de continuar", MsgBoxStyle.Exclamation)
        End If
        Dim UserID As Integer = Convert.ToInt32(PantallaPrincipal.CurrentUserID.Text)
        LBEv.LogUsuario(UserID, "ALTA DE PRODUCTO: " & NombreProd.Text & " CANTIDAD: " & CantidadAStock.Text & " UNIDADES")
        Dim Obj As Control
        For Each Obj In Me.FormNuevoProducto.Controls
            If TypeOf Obj Is TextBox Then
                CType(Obj, TextBox).Clear()
            End If
            If TypeOf Obj Is ComboBox Then
                CType(Obj, ComboBox).Text = ""
            End If
        Next
    End Sub

    Private Sub DescartarProd_Click(sender As Object, e As EventArgs) Handles DescartarProd.Click
        If MsgBox("¿Estás seguro que deseas descartar los cambios?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Borrar Formulario") = MsgBoxResult.Yes Then
            Dim Obj As Control
            For Each Obj In Me.FormNuevoProducto.Controls
                If TypeOf Obj Is TextBox Then
                    CType(Obj, TextBox).Clear()
                End If
                If TypeOf Obj Is ComboBox Then
                    CType(Obj, ComboBox).SelectedIndex = -1
                End If
            Next
        End If
    End Sub

    Private Sub NuevoServicio_CheckedChanged(sender As Object, e As EventArgs) Handles NuevoServicio.CheckedChanged
        If NuevoProducto.Checked = True Then
            FormNuevoProducto.Visible = True
            FormNuevoServicio.Visible = False
        ElseIf NuevoServicio.Checked = True Then
            FormNuevoServicio.Visible = True
            FormNuevoProducto.Visible = False
        Else
            FormNuevoProducto.Visible = False
            FormNuevoServicio.Visible = False
        End If
    End Sub

    Private Sub CostoUnitario_TextChanged(sender As Object, e As EventArgs) Handles CostoUnitario.TextChanged
        If CostoUnitario.Text <> "" And CantidadAStock.Text <> "" Then
            Dim SumaResultados As Single = Convert.ToSingle(CostoUnitario.Text) * Convert.ToInt32(CantidadAStock.Text)
            TotalCompraProductos.Text = SumaResultados.ToString
        End If
    End Sub

    Private Sub CantidadAStock_TextChanged(sender As Object, e As EventArgs) Handles CantidadAStock.TextChanged
        If CostoUnitario.Text <> "" And CantidadAStock.Text <> "" Then
            Dim SumaResultados As Single = Convert.ToSingle(CostoUnitario.Text) * Convert.ToInt32(CantidadAStock.Text)
            TotalCompraProductos.Text = SumaResultados.ToString
        End If
    End Sub

    Private Sub NuevoCodigo_Click(sender As Object, e As EventArgs) Handles NuevoCodigo.Click
        LBEv.BalizaIDServicio()
        CodigoServ.Text = LBEv.BalizaIDServicio
    End Sub

    Private Sub AgregarCategoria_Click(sender As Object, e As EventArgs) Handles AgregarCategoria.Click
        lblcategoria.Visible = True
        txtcategoria.Visible = True
        Guardarcategoria.Visible = True
    End Sub

    Private Sub GuardarServ_Click(sender As Object, e As EventArgs) Handles GuardarServ.Click
        If CodigoServ.Text <> "" And IsNumeric(CodigoServ.Text) Then
            If NombreServ.Text <> "" And DescServ.Text <> "" And CostServ.Text <> "" And CategoriaServ.Text <> "" Then
                LBEv.AgregarServicios(CodigoServ.Text, NombreServ.Text, CostServ.Text, CategoriaServ.SelectedValue, DescServ.Text)
                CategoriaServ.SelectedIndex = -1
                CodigoServ.Clear()
                NombreServ.Clear()
                DescServ.Clear()
                CostServ.Clear()
            End If
        End If
    End Sub

    Private Sub DescartarServ_Click(sender As Object, e As EventArgs) Handles DescartarServ.Click
        If MsgBox("¿Estas seguro que deseas anular los cambios?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CategoriaServ.SelectedIndex = -1
            CodigoServ.Clear()
            NombreServ.Clear()
            DescServ.Clear()
            CostServ.Clear()
        End If
    End Sub

    Private Sub ProductoSinCodigo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ProductoSinCodigo.LinkClicked

    End Sub
End Class