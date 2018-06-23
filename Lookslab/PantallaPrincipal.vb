Public Class PantallaPrincipal
    Dim SQL As New SQLConn
    Dim LBEv As New LBEvents
    Public IsEdited As Boolean = True
    Public CustID As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("¿Estás seguro que deseas salir? Se perderán los cambios no guardados", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, Title:="Confirmación de Salida") = MsgBoxResult.Yes Then
            Application.ExitThread()
            TimerPurchase.Stop()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustType.SelectedIndexChanged
        If CustType.Text = "PERSONA FISICA (CON FACTURAS)" Or CustType.Text = "PERSONA MORAL" Then
            SocialReason.Visible = True
            SocialDesc.Visible = True
            RFC.Visible = True
            RFCDesc.Visible = True
            Address.Visible = True
            AddressDesc.Visible = True
        Else
            SocialReason.Visible = False
            SocialDesc.Visible = False
            RFC.Visible = False
            RFCDesc.Visible = False
            Address.Visible = False
            AddressDesc.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles RequiereFactura.CheckedChanged
        If RequiereFactura.Checked = True Then
            InvoiceData.Visible = True
        Else
            InvoiceData.Visible = False
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        SQL.RunQuery("SELECT A.IDSERVICIO, A.SERVICIO, A.COSTOSERVICIO, A.DESCRIPCIONSERVICIO, B.CATEGORIASERVICIO FROM LBSERVICIOS A " &
                     "INNER JOIN LBCATSERVICIOS B ON B.IDCATEGORIA = A.CATEGORIASERVICIO")
        If SQL.SQLDS.Tables.Count > 0 Then
            DGVService.DataSource = SQL.SQLDS.Tables(0)
        End If
        SQL.RunQuery("SELECT IDCategoria, CategoriaServicio FROM LBCatServicios")
        If SQL.SQLDS.Tables.Count > 0 Then
            ServCat.DataSource = SQL.SQLDS.Tables(0)
            ServCat.DisplayMember = "CategoriaServicio"
            ServCat.ValueMember = "IDCategoria"
            ServCat.SelectedIndex = -1
        End If
        SQL.RunQuery("SELECT * FROM LBProducts")
        If SQL.SQLDS.Tables.Count > 0 Then
            DGVStorage.DataSource = SQL.SQLDS.Tables(0)
        End If
        If CurrentUserID.Text <> "1256" Then
            MainTabs.Controls.Remove(MainTabs.TabPages(5))
        End If
        SQL.RunQuery("SELECT CustID, CustName Nombre, CustPhone Telefono, CustEmail Email, HaveCredit Credito, CustType Tipo_Cliente FROM LBCustomers  ")
        If SQL.SQLDS.Tables.Count > 0 Then
            CustomerGrid.DataSource = SQL.SQLDS.Tables(0)
        End If
        SQL.RunQuery("SELECT SupplierID, SupplierName FROM LBSuppliers")
        If SQL.SQLDS.Tables.Count > 0 Then
            ProductList.DataSource = SQL.SQLDS.Tables(0)
            ProductList.DisplayMember = "SupplierName"
            ProductList.ValueMember = "SupplierID"
        End If
        SQL.RunQuery("SELECT CustID, CustName FROM LBCustomers")
        If SQL.SQLDS.Tables.Count > 0 Then
            NombreCliente.DataSource = SQL.SQLDS.Tables(0)
            NombreCliente.DisplayMember = "CustName"
            NombreCliente.ValueMember = "CustID"
        End If
        SQL.RunQuery("SELECT IDMedio, MedioPago FROM LBMediosPago")
        If SQL.SQLDS.Tables.Count > 0 Then
            MetodoPago.DataSource = SQL.SQLDS.Tables(0)
            MetodoPago.DisplayMember = "MedioPago"
            MetodoPago.ValueMember = "IDMedio"
        End If
        MetodoPago.SelectedIndex = -1
        NombreCliente.SelectedIndex = -1
        ProductList.SelectedIndex = -1
        ServCat.SelectedIndex = -1
        LBEv.TriggerCompra()
        IdCompra.Text = LBEv.TriggerCompra()
        TimerPurchase.Start()
    End Sub

    Private Sub PantallaPrincipal_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            SQL.RunQuery("INSERT INTO LBLastSession (UserId, LastSession) " &
                 "VALUES('" & CurrentUserID.Text & "', " &
                 "'" & DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss ") & "')")
            Dim accion As String = "INICIO DE SESION"
            LBEv.LogUsuario(Convert.ToInt32(CurrentUserID.Text), accion)
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try

    End Sub

    Private Sub ExecuteQuery_Click(sender As Object, e As EventArgs) Handles ExecuteQuery.Click
        If ManualSQLCmd.Text <> "" Then
            Try
                SQL.RunQuery(ManualSQLCmd.Text)
                If SQL.SQLDS.Tables.Count > 0 Then
                    DGVTemp.DataSource = SQL.SQLDS.Tables(0)
                End If
            Catch ex As Exception
                MsgBox("La consulta no fue completada debido al error: " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub ServiceQuery_TextChanged(sender As Object, e As EventArgs) Handles ServiceQuery.TextChanged
        SQL.RunQuery("SELECT A.IDSERVICIO, A.SERVICIO, A.COSTOSERVICIO, A.DESCRIPCIONSERVICIO, B.CATEGORIASERVICIO FROM LBSERVICIOS A " &
                     "INNER JOIN LBCATSERVICIOS B ON B.IDCATEGORIA = A.CATEGORIASERVICIO " &
                     "WHERE A.SERVICIO LIKE '%" & ServiceQuery.Text & "%'")
        If SQL.SQLDS.Tables.Count > 0 Then
            DGVService.DataSource = SQL.SQLDS.Tables(0)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        LoadingScreen.Show()
    End Sub

    Private Sub ServCat_DoubleClick(sender As Object, e As EventArgs)
        SQL.RunQuery("SELECT A.ServiceID Codigo, A.ServiceName Servicio, A.ServiceDesc Descripcion, CAST(A.ServiceCost as Money) Costo, B.ServiceCatDesc Categoria FROM LBServices A " &
                     "INNER JOIN LBServiceCat B on B.ServiceCat = A.ServiceCat " &
                     "WHERE b.ServiceCatDesc LIKE '%" & ServCat.Text & "%'")
        If SQL.SQLDS.Tables.Count > 0 Then
            DGVService.DataSource = SQL.SQLDS.Tables(0)
        End If

    End Sub


    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        If CustDisplayedID.Text <> "" Then
            If MsgBox("¿Estás seguro que deseas eliminar el registro del cliente actual? Los datos no podrán recuperarse", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                Try
                    SQL.RunQuery("DELETE FROM LBCustomers " &
                             "WHERE CustID ='" & CustDisplayedID.Text & "'")
                    MsgBox("El elemento fue eliminado exitosamente", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs)
        If IsEdited = False Then
            If CustType.Text = "PERSONA FISICA (SIN FACTURAS)" Then
                If CustName.Text <> "" And CustPhone.Text <> "" And CustEmail.Text <> "" And CustType.Text <> "" And HasCredit.Text <> "" And HasMembership.Text <> "" Then
                    RecordCustomer()
                Else
                    MsgBox("Son requeridos al menos Nombre, Teléfono y Email para el registro", MsgBoxStyle.Information, "Registro de Clientes")
                End If
            ElseIf CustType.Text = "PERSONA MORAL" Or CustType.Text = "PERSONA FISICA (CON FACTURAS)" Then
                If CustName.Text <> "" And CustPhone.Text <> "" And CustEmail.Text <> "" And CustType.Text <> "" And HasCredit.Text <> "" And HasMembership.Text <> "" And SocialDesc.Text <> "" And RFCDesc.Text <> "" And AddressDesc.Text <> "" Then
                    RecordCustomer()
                Else
                    MsgBox("Son requeridos los datos personales como Nombre, Teléfono y Email, así mismo como los datos de facturación como Razón Social, RFC y Domicilio Fiscal", MsgBoxStyle.Information, "Registro de Clientes")
                End If
            End If
        ElseIf IsEdited = True Then
            If CustType.Text = "PERSONA FISICA (SIN FACTURAS)" Then
                If CustName.Text <> "" And CustPhone.Text <> "" And CustEmail.Text <> "" And CustType.Text <> "" And HasCredit.Text <> "" And HasMembership.Text <> "" Then
                    UpdateCustomer()
                Else
                    MsgBox("Son requeridos al menos Nombre, Teléfono y Email para el registro", MsgBoxStyle.Information, "Registro de Clientes")
                End If
            ElseIf CustType.Text = "PERSONA MORAL" Or CustType.Text = "PERSONA FISICA (CON FACTURAS)" Then
                If CustName.Text <> "" And CustPhone.Text <> "" And CustEmail.Text <> "" And CustType.Text <> "" And HasCredit.Text <> "" And HasMembership.Text <> "" And SocialDesc.Text <> "" And RFCDesc.Text <> "" And AddressDesc.Text <> "" Then
                    UpdateCustomer()
                Else
                    MsgBox("Son requeridos los datos personales como Nombre, Teléfono y Email, así mismo como los datos de facturación como Razón Social, RFC y Domicilio Fiscal", MsgBoxStyle.Information, "Registro de Clientes")
                End If
            End If
        End If
        SQL.RunQuery("SELECT * FROM LBCustomers")
        CustQuery.Text = "1"
        CustQuery.Text = ""
    End Sub
    Public Sub RecordCustomer()
        Try
            SQL.RunQuery("INSERT INTO LBCustomers (CustName, CustPhone, CustBirthday, CustEmail, HaveCredit, CustType, CustSocialName, RFC, CustAddress, IsVIP, MembershipID, UserWhoRegister, DateRegistered) " &
                         " VALUES ('" & CustName.Text & "', " &
                         "'" & CustPhone.Text & "', " &
                         "'" & CustBDay.Value.ToString("yyyy-MM-dd") & "', " &
                         "'" & CustEmail.Text & "', " &
                         "'" & HasCredit.Text & "', " &
                         "'" & CustType.Text & "', " &
                         "'" & SocialDesc.Text & "', " &
                         "'" & RFCDesc.Text & "', " &
                         "'" & AddressDesc.Text & "', " &
                         "'" & HasMembership.Text & "', " &
                         "'" & MembershipID.Text & "', " &
                         "'" & CurrentUserID.Text & "', " &
                         "'" & DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss") & "')")
            Dim obj As Control
            For Each obj In Me.CustRegister.Controls
                If TypeOf (obj) Is TextBox Then
                    CType(obj, TextBox).ReadOnly = True
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
        MsgBox("Datos almacenados correctamente", MsgBoxStyle.Information)
        LBEv.TriggerNuevoUsuario()
        CustDisplayedID.Text = LBEv.TriggerNuevoUsuario()
        LBEv.LogUsuario(Convert.ToInt32(CurrentUserID.Text), "AGREGAR USUARIO " & CustName.Text)
    End Sub
    Public Sub UpdateCustomer()
        Try
            SQL.RunQuery("UPDATE LBCustomers " &
                         "SET CustName = '" & CustName.Text & "', " &
                         "CustPhone = '" & CustPhone.Text & "', " &
                         "CustBirthDay = '" & CustBDay.Value.ToString("yyyy-MM-dd") & "', " &
                         "CustEmail = '" & CustEmail.Text & "', " &
                         "HaveCredit = '" & HasCredit.Text & "', " &
                         "CustType = '" & CustType.Text & "', " &
                         "CustSocialName = '" & SocialDesc.Text & "', " &
                         "RFC = '" & RFCDesc.Text & "', " &
                         "CustAddress = '" & AddressDesc.Text & "', " &
                         "IsVIP = '" & HasMembership.Text & "', " &
                         "MembershipID = '" & MembershipID.Text & "' " &
                         "WHERE CustID = '" & CustDisplayedID.Text & "'")
            Dim obj As Control
            For Each obj In Me.CustRegister.Controls
                If TypeOf (obj) Is TextBox Then
                    CType(obj, TextBox).ReadOnly = True
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
        MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information)
        LBEv.LogUsuario(Convert.ToInt32(CurrentUserID.Text), "EDITA USUARIO " & CustName.Text)
    End Sub

    Private Sub UpdCustGrid_Click(sender As Object, e As EventArgs) Handles UpdCustGrid.Click
        SQL.RunQuery("SELECT CustID, CustName NombreCliente, CustPhone Teléfono, CustBirthDay Cumpleaños, CustEmail CorreoElectronico, HaveCredit Credito, AmountDue MontoAdeudo, CustType TipoCliente FROM LBCustomers ")
        If SQL.SQLDS.Tables.Count > 0 Then
            CustomerGrid.DataSource = SQL.SQLDS.Tables(0)
        End If
    End Sub
    Private Sub CustQuery_TextChanged(sender As Object, e As EventArgs) Handles CustQuery.TextChanged
        SQL.RunQuery("SELECT CustID, CustName NombreCliente, CustPhone Teléfono, CustBirthDay Cumpleaños, CustEmail CorreoElectronico, HaveCredit Credito, AmountDue MontoAdeudo, CustType TipoCliente FROM LBCustomers " &
                     "WHERE CustName LIKE '%" & CustQuery.Text & "%'")
        If SQL.SQLDS.Tables.Count > 0 Then
            CustomerGrid.DataSource = SQL.SQLDS.Tables(0)
        End If


    End Sub

    Private Sub NuevoToolStripButton_Click(sender As Object, e As EventArgs)
        Dim obj As Control
        For Each obj In Me.CustRegister.Controls
            If TypeOf (obj) Is TextBox Then
                obj.Text = ""
                CType(obj, TextBox).ReadOnly = False
            End If
        Next
        CustDisplayedID.Text = ""
        HasCredit.Text = ""
        CustType.Text = ""
        HasMembership.Text = ""
        CustBDay.Value = Date.Today
        IsEdited = False
    End Sub

    Private Sub CustEditItem_Click(sender As Object, e As EventArgs)
        Dim obj As Control
        For Each obj In Me.CustRegister.Controls
            If TypeOf (obj) Is TextBox Then
                CType(obj, TextBox).ReadOnly = False
            End If
        Next
        IsEdited = True
    End Sub

    Private Sub SearchImg_Click(sender As Object, e As EventArgs) Handles SearchImg.Click
        CustQuery.Enabled = True
        CustQuery.ReadOnly = False
    End Sub

    Private Sub HasMembership_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HasMembership.SelectedIndexChanged
        If HasMembership.Text = "SI" Then
            LblCardMembership.Show()
            MembershipID.Show()
        Else
            LblCardMembership.Hide()
            MembershipID.Hide()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles UsersSystem.Click
        UserModule.Show()
        UserModule.BringToFront()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles CustGridShow.Click
        MainTabs.SelectTab(1)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If MsgBox("¿Estás seguro que deseas cerrar la sesión?", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Cierre de sesión") = MsgBoxResult.Yes Then
            Me.Dispose()
            LookslabLogin.Show()
            LookslabLogin.UsernameTextBox.Text = ""
            LookslabLogin.PasswordTextBox.Text = ""
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MainTabs.SelectTab(2)
    End Sub



    Private Sub CustomerGrid_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerGrid.CellContentDoubleClick
        Dim LocalCust As String = CustomerGrid.CurrentRow.Cells(0).Value
        If LocalCust <> "" Then
            DetalleCliente.IDCliente.Text = LocalCust
            DetalleCliente.Show()
            DetalleCliente.BringToFront()
        Else
            MsgBox("Celda inválida, por favor elegir otra", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TimerPurchase_Tick(sender As Object, e As EventArgs) Handles TimerPurchase.Tick
        FechaCompra.Text = DateTime.Now
    End Sub

    Private Sub ElegirClienteCompra_Click(sender As Object, e As EventArgs) Handles ElegirClienteCompra.Click
        MainTabs.SelectTab(1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles CalendarioCitasOpen.Click
        CalendarAppointments.Show()
        CalendarAppointments.BringToFront()

    End Sub

    Private Sub ServCat_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetodoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetodoPago.SelectedIndexChanged
        If IsNumeric(MetodoPago.SelectedValue) Then
            If MetodoPago.SelectedValue = 4 Then
                lblmetodopagoperso.Show()
                MetodoPagoPerso.Show()
            ElseIf MetodoPago.SelectedValue = 1 Then
                lblmetodopagoperso.Show()
                TipoTarjeta.Show()
                GranTotal.Text = Convert.ToString(Convert.ToSingle(GranTotal.Text) * 1.025)
            Else
                lblmetodopagoperso.Hide()
                MetodoPagoPerso.Hide()
                TipoTarjeta.Hide()
            End If
        End If
    End Sub

    Private Sub AddCustomer_Click(sender As Object, e As EventArgs) Handles AddCustomer.Click
        Dim obj As Control
        For Each obj In Me.CustRegister.Controls
            If TypeOf (obj) Is TextBox Then
                CType(obj, TextBox).ReadOnly = False
                CType(obj, TextBox).Text = ""
            End If
        Next
        AddCustomer.Enabled = False
        SaveCustomer.Enabled = True
        EditCustomer.Enabled = False
        DeleteCustomer.Enabled = False
        CustDisplayedID.Text = ""
        HasCredit.Text = ""
        CustType.Text = ""
        HasMembership.Text = ""
        CustBDay.Value = Date.Today
        IsEdited = False

    End Sub

    Private Sub EditCustomer_Click(sender As Object, e As EventArgs) Handles EditCustomer.Click
        If CustDisplayedID.Text <> "" Then
            Dim obj As Control
            For Each obj In Me.CustRegister.Controls
                If TypeOf (obj) Is TextBox Then
                    CType(obj, TextBox).ReadOnly = False
                End If
            Next
            AddCustomer.Enabled = False
            SaveCustomer.Enabled = True
            EditCustomer.Enabled = False
            DeleteCustomer.Enabled = False
            IsEdited = True
        Else
            MsgBox("Es necesario elegir primero un usuario para editar", MsgBoxStyle.Critical, "Registro de usuarios")
        End If
    End Sub

    Private Sub DeleteCustomer_Click(sender As Object, e As EventArgs) Handles DeleteCustomer.Click
        If CustDisplayedID.Text <> "" Then
            If MsgBox("¿Estás seguro que deseas eliminar el usuario " & CustName.Text & "? No podrá ser recuperado una vez sea borrado", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Confirmar Eliminacion") = MsgBoxResult.Yes Then
                Try
                    SQL.RunQuery("DELETE FROM LBCustomers WHERE CustID ='" & CustDisplayedID.Text & "'")
                    LBEv.LogUsuario(Convert.ToInt32(CurrentUserID.Text), "ELIMINACION DEL USUARIO " & CustName.Text)
                    MsgBox("El elemento fue eliminado exitosamente", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    If SQL.SQLCon.State = ConnectionState.Open Then
                        SQL.SQLCon.Close()
                    End If
                End Try
                Dim obj As Control
                For Each obj In Me.CustRegister.Controls
                    If TypeOf (obj) Is TextBox Then
                        CType(obj, TextBox).ReadOnly = True
                        CType(obj, TextBox).Text = ""
                    End If
                Next
            End If
        End If
        CustDisplayedID.Text = ""
        CustQuery.Text = "1"
        CustQuery.Text = ""
    End Sub

    Private Sub SaveCustomer_Click(sender As Object, e As EventArgs) Handles SaveCustomer.Click
        If IsEdited = False Then
            If CustType.Text = "PERSONA FISICA (SIN FACTURAS)" Then
                If CustName.Text <> "" And CustPhone.Text <> "" And CustEmail.Text <> "" And CustType.Text <> "" And HasCredit.Text <> "" And HasMembership.Text <> "" Then
                    RecordCustomer()
                Else
                    MsgBox("Son requeridos al menos Nombre, Teléfono y Email para el registro", MsgBoxStyle.Information, "Registro de Clientes")
                End If
            ElseIf CustType.Text = "PERSONA MORAL" Or CustType.Text = "PERSONA FISICA (CON FACTURAS)" Then
                If CustName.Text <> "" And CustPhone.Text <> "" And CustEmail.Text <> "" And CustType.Text <> "" And HasCredit.Text <> "" And HasMembership.Text <> "" And SocialDesc.Text <> "" And RFCDesc.Text <> "" And AddressDesc.Text <> "" Then
                    RecordCustomer()
                Else
                    MsgBox("Son requeridos los datos personales como Nombre, Teléfono y Email, así mismo como los datos de facturación como Razón Social, RFC y Domicilio Fiscal", MsgBoxStyle.Information, "Registro de Clientes")
                End If
            End If
        ElseIf IsEdited = True Then
            If CustType.Text = "PERSONA FISICA (SIN FACTURAS)" Then
                If CustName.Text <> "" And CustPhone.Text <> "" And CustEmail.Text <> "" And CustType.Text <> "" And HasCredit.Text <> "" And HasMembership.Text <> "" Then
                    UpdateCustomer()
                Else
                    MsgBox("Son requeridos al menos Nombre, Teléfono y Email para el registro", MsgBoxStyle.Information, "Registro de Clientes")
                End If
            ElseIf CustType.Text = "PERSONA MORAL" Or CustType.Text = "PERSONA FISICA (CON FACTURAS)" Then
                If CustName.Text <> "" And CustPhone.Text <> "" And CustEmail.Text <> "" And CustType.Text <> "" And HasCredit.Text <> "" And HasMembership.Text <> "" And SocialDesc.Text <> "" And RFCDesc.Text <> "" And AddressDesc.Text <> "" Then
                    UpdateCustomer()
                Else
                    MsgBox("Son requeridos los datos personales como Nombre, Teléfono y Email, así mismo como los datos de facturación como Razón Social, RFC y Domicilio Fiscal", MsgBoxStyle.Information, "Registro de Clientes")
                End If
            End If
        End If
        SQL.RunQuery("SELECT * FROM LBCustomers")
        CustQuery.Text = "1"
        CustQuery.Text = ""
        AddCustomer.Enabled = True
        EditCustomer.Enabled = True
        DeleteCustomer.Enabled = True
        SQL.RunQuery("SELECT CustID, CustName FROM LBCustomers")
        If SQL.SQLDS.Tables.Count > 0 Then
            NombreCliente.DataSource = SQL.SQLDS.Tables(0)
            NombreCliente.DisplayMember = "CustName"
            NombreCliente.ValueMember = "CustID"
        End If
    End Sub

    Private Sub CustomerGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerGrid.CellContentClick
        Dim CCuser As String = CustomerGrid.CurrentRow.Cells(0).Value
        If CCuser <> "" Then
            CustDisplayedID.Text = CCuser
            SQL.RunQuery("EXEC dbo.CustStandardInfo '" & CCuser & "'")
            If SQL.SQLDS.Tables.Count > 0 Then
                AuxCustDGV.DataSource = SQL.SQLDS.Tables(0)
                Dim Row As DataGridViewRow
                Row = AuxCustDGV.Rows(0)
                CustName.Text = Row.Cells(0).Value
                CustPhone.Text = Row.Cells(1).Value
                CustBDay.Value = Row.Cells(2).Value
                CustEmail.Text = Row.Cells(3).Value
                HasCredit.SelectedItem = Row.Cells(4).Value
                CustType.SelectedItem = Row.Cells(5).Value
                SocialDesc.Text = Row.Cells(6).Value
                RFCDesc.Text = Row.Cells(7).Value
                AddressDesc.Text = Row.Cells(8).Value
                HasMembership.Text = Row.Cells(9).Value
                MembershipID.Text = Row.Cells(10).Value
            End If
        End If
    End Sub

    Private Sub MembershipID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MembershipID.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CustPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CustPhone.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AgregarProducto_Click(sender As Object, e As EventArgs) Handles AgregarProducto.Click
        AgregarProductosServicios.Show()
    End Sub

    Private Sub ProductQuery_TextChanged(sender As Object, e As EventArgs) Handles ProductQuery.TextChanged
        If ProductQuery.Text <> "" Then
            SQL.RunQuery("SELECT A.PRODUCTCODE CODIGO, A.PRODUCTNAME NOMBRE_PRODUCTO, A.PRODUCTDESC DESCRIPCION, A.SALEPRICE PRECIO_UNITARIO, A.STOCKAMMOUNT EN_INVENTARIO, B.SUPPLIERNAME PROVEEDOR FROM LBProducts A " &
                "INNER JOIN LBSuppliers B ON B.SupplierID = A.IDSupplier " &
                "WHERE A.PRODUCTNAME LIKE '%" & ProductQuery.Text & "%'")
            If SQL.SQLDS.Tables.Count > 0 Then
                DGVStorage.DataSource = SQL.SQLDS.Tables(0)
            End If
        End If
    End Sub

    Private Sub ServCat_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ServCat.SelectedIndexChanged
        If IsNumeric(ServCat.SelectedValue) Then
            SQL.RunQuery("SELECT A.IDSERVICIO, A.SERVICIO, A.COSTOSERVICIO, A.DESCRIPCIONSERVICIO, B.CATEGORIASERVICIO FROM LBSERVICIOS A " &
                     "INNER JOIN LBCATSERVICIOS B ON B.IDCATEGORIA = A.CATEGORIASERVICIO " &
                     "WHERE A.CATEGORIASERVICIO = '" & ServCat.SelectedValue & "'")
            If SQL.SQLDS.Tables.Count > 0 Then
                DGVService.DataSource = SQL.SQLDS.Tables(0)
            End If
        End If
    End Sub

    Private Sub ProductList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductList.SelectedIndexChanged
        If IsNumeric(ProductList.SelectedValue) Then
            SQL.RunQuery("SELECT A.PRODUCTCODE CODIGO, A.PRODUCTNAME NOMBRE_PRODUCTO, A.PRODUCTDESC DESCRIPCION, A.SALEPRICE PRECIO_UNITARIO, A.STOCKAMMOUNT EN_INVENTARIO, B.SUPPLIERNAME PROVEEDOR FROM LBProducts A " &
                "INNER JOIN LBSuppliers B ON B.SupplierID = A.IDSupplier " &
                "WHERE A.IDSupplier = '" & ProductList.SelectedValue & "'")
            If SQL.SQLDS.Tables.Count > 0 Then
                DGVStorage.DataSource = SQL.SQLDS.Tables(0)
            End If
        End If
    End Sub

    Private Sub DGVStorage_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVStorage.CellContentClick
        Dim ccproduct As String = DGVStorage.CurrentRow.Cells(0).Value
        If ccproduct <> "" Then
            CodProd.Text = ccproduct
            SQL.RunQuery("SELECT A.PRODUCTCODE CODIGO, A.PRODUCTNAME NOMBRE_PRODUCTO, A.PRODUCTDESC DESCRIPCION, A.SALEPRICE PRECIO_UNITARIO, A.STOCKAMMOUNT EN_INVENTARIO, B.SUPPLIERNAME PROVEEDOR,  B.SupplierRep, B.LastItemRegistration FROM LBProducts A " &
                "INNER JOIN LBSuppliers B ON B.SupplierID = A.IDSupplier " &
                "WHERE A.PRODUCTCODE = '" & ccproduct & "'")
            If SQL.SQLDS.Tables.Count > 0 Then
                AuxCustDGV.DataSource = SQL.SQLDS.Tables(0)
                Dim Row As DataGridViewRow
                Row = AuxCustDGV.Rows(0)
                NombreProd.Text = Row.Cells(1).Value
                DescProd.Text = Row.Cells(2).Value
                CostProd.Text = Row.Cells(3).Value
                StockAmmount.Text = Row.Cells(4).Value
                IDProv.Text = Row.Cells(5).Value
                NombreProv.Text = Row.Cells(6).Value
                UltVisita.Text = Row.Cells(7).Value
            End If

        End If

    End Sub

    Private Sub AddToCart_Click(sender As Object, e As EventArgs) Handles AddToCart.Click
        Dim operacion As Single
        If CodigoVenta.Text <> "" And CantidadVenta.Text <> "" Then
            SQL.RunQuery("SELECT COUNT (*) as BusqProd FROM LBProducts WHERE ProductCode ='" & CodigoVenta.Text & "' AND StockAmmount > 0")
            If SQL.SQLDS.Tables(0).Rows(0).Item("BusqProd") = 1 Then
                If ExisteEnLista(CodigoVenta.Text) = False Then
                    SQL.RunQuery("SELECT ProductName, ProductCost, StockAmmount FROM LBProducts WHERE ProductCode='" & CodigoVenta.Text & "'")
                    If SQL.SQLDS.Tables.Count > 0 Then
                        AuxDGVCompra.DataSource = SQL.SQLDS.Tables(0)
                        Dim OriginRow As DataGridViewRow = AuxDGVCompra.Rows(0)
                        Dato1.Text = OriginRow.Cells(0).Value
                        Dato2.Text = OriginRow.Cells(1).Value
                        Dato3.Text = OriginRow.Cells(2).Value
                        Dim Item1 As Single = Convert.ToSingle(Dato2.Text)
                        Dim Item2 As Single = Convert.ToSingle(CantidadVenta.Text)
                        operacion = Item1 * Item2
                        Dim totalOperacion As Single = Convert.ToSingle(STotal.Text)
                        totalOperacion = totalOperacion + operacion
                        STotal.Text = totalOperacion.ToString
                        If Convert.ToInt32(Dato3.Text) >= Convert.ToInt32(CantidadVenta.Text) Then
                            Dim RegistroNuevo As String() = New String() {CodigoVenta.Text, CantidadVenta.Text, Dato1.Text, Dato2.Text, operacion.ToString}
                            DGVSale.Rows.Add(RegistroNuevo)
                            If IsNumeric(STotal.Text) Then
                                Dim IVA As Single = Convert.ToSingle(STotal.Text) * 0.16
                                Impuesto.Text = IVA.ToString
                                GranTotal.Text = STotal.Text
                                CancelItem.Enabled = True
                            End If
                        Else
                            MsgBox("La cantidad ingresada supera el número de artículos en Stock, favor de validar", MsgBoxStyle.Exclamation, "Stock Insuficiente")
                        End If
                    End If
                End If
            Else
                SQL.RunQuery("SELECT COUNT (*) as BusqServ FROM LBServicios WHERE IDServicio ='" & CodigoVenta.Text & "'")
                If SQL.SQLDS.Tables(0).Rows(0).Item("BusqServ") = 1 Then
                    SQL.RunQuery("SELECT Servicio, CostoServicio FROM LBServicios WHERE IDServicio ='" & CodigoVenta.Text & "'")
                    If SQL.SQLDS.Tables.Count > 0 Then
                        AuxDGVCompra.DataSource = SQL.SQLDS.Tables(0)
                        Dim OriginRow As DataGridViewRow = AuxDGVCompra.Rows(0)
                        Dato1.Text = OriginRow.Cells(0).Value
                        Dato2.Text = OriginRow.Cells(1).Value
                        Dim Item1 As Single = Convert.ToSingle(Dato2.Text)
                        Dim Item2 As Single = Convert.ToSingle(CantidadVenta.Text)
                        operacion = Item1 * Item2
                        Dim totalOperacion As Single = Convert.ToSingle(STotal.Text)
                        totalOperacion = totalOperacion + operacion
                        STotal.Text = totalOperacion.ToString
                        Dim RegistroNuevo As String() = New String() {CodigoVenta.Text, CantidadVenta.Text, Dato1.Text, Dato2.Text, operacion.ToString}
                        DGVSale.Rows.Add(RegistroNuevo)
                        If IsNumeric(STotal.Text) Then
                            Dim IVA As Single = Convert.ToSingle(STotal.Text) * 0.16
                            Impuesto.Text = IVA.ToString
                            GranTotal.Text = STotal.Text
                            CancelItem.Enabled = True
                        End If
                    End If
                Else
                    MsgBox("No se pudo encontrar el articulo solicitado, favor de validarlo", MsgBoxStyle.Critical, "Error en ingreso de datos")
                    CodigoVenta.Clear()
                End If
            End If
        End If
        CodigoVenta.Clear()
        CodigoVenta.Focus()
    End Sub

    Private Sub CancelPurchase_Click(sender As Object, e As EventArgs) Handles CancelItem.Click
        Dim Row As DataGridViewRow = DGVSale.CurrentRow
        Dim StrValue As String = Row.Cells(2).Value
        If MsgBox("¿Deseas eliminar el elemento " & StrValue & " de la lista actual?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Remover elemento") = MsgBoxResult.Yes Then
            DGVSale.Rows.Remove(Row)
            MsgBox("Se eliminó de la lista el registro", MsgBoxStyle.Information)
            Dim i As Integer = 0
            Dim Sum As Single = 0
            Dim CRows As Integer = DGVSale.Rows.Count() - 1
            If CRows < 1 Then
                Sum = 0
            Else
                Do While i < CRows
                    Dim EvRow As DataGridViewRow = DGVSale.Rows(i)
                    Dato3.Text = EvRow.Cells(4).Value
                    Sum = Sum + Convert.ToSingle(Dato3.Text)
                    i = i + 1
                Loop
            End If
            STotal.Text = Sum.ToString
            If IsNumeric(STotal.Text) Then
                Dim IVA As Single = Convert.ToSingle(STotal.Text) * 0.16
                Impuesto.Text = IVA.ToString
                GranTotal.Text = STotal.Text
            End If
        End If
    End Sub
    Private Function ExisteEnLista(ByVal Codigo As String) As Boolean
        Dim existe As Boolean = False
        For Each row As DataGridViewRow In DGVSale.Rows
            Dim verificar As String = Convert.ToString(row.Cells(0).Value)
            If Codigo = verificar Then
                MsgBox("El Codigo Ingresado N° : " + Codigo + "  " + "Ya se encuentra ingresado en la lista, favor de eliminar y modificar con el valor adecuado", MsgBoxStyle.Information)
                existe = True
            End If
        Next
        Return existe

    End Function





    Private Sub CancelSale_Click(sender As Object, e As EventArgs) Handles CancelSale.Click
        If MsgBox("¿Estás seguro que deseas eliminar todos los elementos de la compra?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DGVSale.Rows.Clear()
            STotal.Text = "0"
            Impuesto.Text = "0"
            GranTotal.Text = "0"
        End If
    End Sub

    Private Sub CodigoVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CodigoVenta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CantidadVenta.Focus()
        ElseIf Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CantidadVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantidadVenta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            AddToCart.PerformClick()
        ElseIf Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NombreCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NombreCliente.SelectedIndexChanged
        If IsNumeric(NombreCliente.SelectedValue) Then
            IdClienteVenta.Text = NombreCliente.SelectedValue
        End If
    End Sub

    Private Sub VolcarParaCompra_Click(sender As Object, e As EventArgs) Handles VolcarParaCompra.Click
        If CustDisplayedID.Text <> "" Then
            NombreCliente.SelectedValue = Convert.ToInt32(CustDisplayedID.Text)
            If CustType.Text = "PERSONA FISICA (CON FACTURAS)" Or CustType.Text = "PERSONA MORAL" Then
                RazonSocial.Text = SocialDesc.Text
                RFCVentaCliente.Text = RFCDesc.Text
                DomicilioCliente.Text = AddressDesc.Text
                RequiereFactura.Checked = True
                MainTabs.SelectTab(4)
            Else
                RequiereFactura.Checked = False
                MainTabs.SelectTab(4)
            End If
        Else
            MsgBox("Debe seleccionar primero un cliente antes de continuar", MsgBoxStyle.Exclamation)
        End If



    End Sub

    Private Sub VolcarParaCita_Click(sender As Object, e As EventArgs) Handles VolcarParaCita.Click
        If CustDisplayedID.Text <> "" Then
            CalendarAppointments.Show()
            CalendarAppointments.BringToFront()
        Else
            MsgBox("Favor de seleccionar primero un cliente", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub CodigoVenta_TextChanged(sender As Object, e As EventArgs) Handles CodigoVenta.TextChanged

    End Sub




    Private Sub PagarFactura_Click(sender As Object, e As EventArgs) Handles PagarFactura.Click
        Dim Factura As Integer
        If RequiereFactura.Checked = True Then
            Factura = 1
        Else
            Factura = 0
        End If
        If lblmetodopago.Visible = False Then
            PagarFactura.Text = "Pagar Factura"
            lblmetodopago.Visible = True
            MetodoPago.Visible = True
        Else
            'LBEv.AgregarCompra(IdCompra.Text, IdClienteVenta.Text, FechaCompra.Text, Factura, CurrentUserID.Text, 
        End If
        lblmetodopago.Visible = False
        MetodoPago.SelectedValue = -1
        MetodoPago.Visible = False

    End Sub
End Class
