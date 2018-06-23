<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleCliente
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
        Me.SalirModulo = New System.Windows.Forms.Button()
        Me.AppName = New System.Windows.Forms.Label()
        Me.DomicilioFiscal = New System.Windows.Forms.TextBox()
        Me.RFC = New System.Windows.Forms.TextBox()
        Me.PersonaFiscal = New System.Windows.Forms.TextBox()
        Me.SaldoMembresia = New System.Windows.Forms.TextBox()
        Me.membresiaID = New System.Windows.Forms.TextBox()
        Me.adeudocredito = New System.Windows.Forms.TextBox()
        Me.Credito = New System.Windows.Forms.TextBox()
        Me.tipocliente = New System.Windows.Forms.TextBox()
        Me.cumpleañoscliente = New System.Windows.Forms.TextBox()
        Me.correocliente = New System.Windows.Forms.TextBox()
        Me.telcliente = New System.Windows.Forms.TextBox()
        Me.nombrecliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lblnombre = New System.Windows.Forms.Label()
        Me.IDCliente = New System.Windows.Forms.Label()
        Me.InfoClienteDGV = New System.Windows.Forms.DataGridView()
        Me.DGVCredito = New System.Windows.Forms.DataGridView()
        Me.FacturasVencidas = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MontoDeuda = New System.Windows.Forms.Label()
        Me.PromedioVisitas = New System.Windows.Forms.Label()
        Me.GoodCust = New System.Windows.Forms.Label()
        Me.AverageCust = New System.Windows.Forms.Label()
        Me.BadCust = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.InfoClienteDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturasVencidas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.SalirModulo)
        Me.Panel1.Controls.Add(Me.AppName)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 24)
        Me.Panel1.TabIndex = 1
        '
        'SalirModulo
        '
        Me.SalirModulo.BackColor = System.Drawing.Color.Red
        Me.SalirModulo.Location = New System.Drawing.Point(716, 0)
        Me.SalirModulo.Name = "SalirModulo"
        Me.SalirModulo.Size = New System.Drawing.Size(26, 23)
        Me.SalirModulo.TabIndex = 1
        Me.SalirModulo.Text = "X"
        Me.SalirModulo.UseVisualStyleBackColor = False
        '
        'AppName
        '
        Me.AppName.AutoSize = True
        Me.AppName.Location = New System.Drawing.Point(4, 5)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(90, 13)
        Me.AppName.TabIndex = 0
        Me.AppName.Text = "Detalle de Cliente"
        '
        'DomicilioFiscal
        '
        Me.DomicilioFiscal.Location = New System.Drawing.Point(82, 263)
        Me.DomicilioFiscal.Multiline = True
        Me.DomicilioFiscal.Name = "DomicilioFiscal"
        Me.DomicilioFiscal.ReadOnly = True
        Me.DomicilioFiscal.Size = New System.Drawing.Size(196, 85)
        Me.DomicilioFiscal.TabIndex = 48
        '
        'RFC
        '
        Me.RFC.Location = New System.Drawing.Point(70, 242)
        Me.RFC.Name = "RFC"
        Me.RFC.ReadOnly = True
        Me.RFC.Size = New System.Drawing.Size(196, 20)
        Me.RFC.TabIndex = 47
        '
        'PersonaFiscal
        '
        Me.PersonaFiscal.Location = New System.Drawing.Point(70, 222)
        Me.PersonaFiscal.Name = "PersonaFiscal"
        Me.PersonaFiscal.ReadOnly = True
        Me.PersonaFiscal.Size = New System.Drawing.Size(280, 20)
        Me.PersonaFiscal.TabIndex = 46
        '
        'SaldoMembresia
        '
        Me.SaldoMembresia.Location = New System.Drawing.Point(113, 202)
        Me.SaldoMembresia.Name = "SaldoMembresia"
        Me.SaldoMembresia.ReadOnly = True
        Me.SaldoMembresia.Size = New System.Drawing.Size(153, 20)
        Me.SaldoMembresia.TabIndex = 45
        '
        'membresiaID
        '
        Me.membresiaID.Location = New System.Drawing.Point(83, 182)
        Me.membresiaID.Name = "membresiaID"
        Me.membresiaID.ReadOnly = True
        Me.membresiaID.Size = New System.Drawing.Size(183, 20)
        Me.membresiaID.TabIndex = 44
        '
        'adeudocredito
        '
        Me.adeudocredito.Location = New System.Drawing.Point(83, 162)
        Me.adeudocredito.Name = "adeudocredito"
        Me.adeudocredito.ReadOnly = True
        Me.adeudocredito.Size = New System.Drawing.Size(183, 20)
        Me.adeudocredito.TabIndex = 43
        '
        'Credito
        '
        Me.Credito.Location = New System.Drawing.Point(83, 142)
        Me.Credito.Name = "Credito"
        Me.Credito.ReadOnly = True
        Me.Credito.Size = New System.Drawing.Size(79, 20)
        Me.Credito.TabIndex = 42
        '
        'tipocliente
        '
        Me.tipocliente.Location = New System.Drawing.Point(83, 122)
        Me.tipocliente.Name = "tipocliente"
        Me.tipocliente.ReadOnly = True
        Me.tipocliente.Size = New System.Drawing.Size(183, 20)
        Me.tipocliente.TabIndex = 41
        '
        'cumpleañoscliente
        '
        Me.cumpleañoscliente.Location = New System.Drawing.Point(166, 102)
        Me.cumpleañoscliente.Name = "cumpleañoscliente"
        Me.cumpleañoscliente.ReadOnly = True
        Me.cumpleañoscliente.Size = New System.Drawing.Size(100, 20)
        Me.cumpleañoscliente.TabIndex = 40
        '
        'correocliente
        '
        Me.correocliente.Location = New System.Drawing.Point(104, 82)
        Me.correocliente.Name = "correocliente"
        Me.correocliente.ReadOnly = True
        Me.correocliente.Size = New System.Drawing.Size(246, 20)
        Me.correocliente.TabIndex = 39
        '
        'telcliente
        '
        Me.telcliente.Location = New System.Drawing.Point(104, 61)
        Me.telcliente.Name = "telcliente"
        Me.telcliente.ReadOnly = True
        Me.telcliente.Size = New System.Drawing.Size(100, 20)
        Me.telcliente.TabIndex = 38
        '
        'nombrecliente
        '
        Me.nombrecliente.Location = New System.Drawing.Point(104, 40)
        Me.nombrecliente.Name = "nombrecliente"
        Me.nombrecliente.ReadOnly = True
        Me.nombrecliente.Size = New System.Drawing.Size(246, 20)
        Me.nombrecliente.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Saldo en Membresía"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Membresía VIP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(0, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Domicilio Fiscal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Credito"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Tipo de Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(2, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Monto Adeudo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Razon Social"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "RFC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Fecha Nacimiento / Cumpleaños"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Correo Electronico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Telefono"
        '
        'Lblnombre
        '
        Me.Lblnombre.AutoSize = True
        Me.Lblnombre.Location = New System.Drawing.Point(0, 43)
        Me.Lblnombre.Name = "Lblnombre"
        Me.Lblnombre.Size = New System.Drawing.Size(96, 13)
        Me.Lblnombre.TabIndex = 25
        Me.Lblnombre.Text = "Nombre del Cliente"
        '
        'IDCliente
        '
        Me.IDCliente.AutoSize = True
        Me.IDCliente.Location = New System.Drawing.Point(2, 27)
        Me.IDCliente.Name = "IDCliente"
        Me.IDCliente.Size = New System.Drawing.Size(0, 13)
        Me.IDCliente.TabIndex = 49
        Me.IDCliente.Visible = False
        '
        'InfoClienteDGV
        '
        Me.InfoClienteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InfoClienteDGV.Location = New System.Drawing.Point(0, 411)
        Me.InfoClienteDGV.Name = "InfoClienteDGV"
        Me.InfoClienteDGV.Size = New System.Drawing.Size(45, 24)
        Me.InfoClienteDGV.TabIndex = 50
        Me.InfoClienteDGV.Visible = False
        '
        'DGVCredito
        '
        Me.DGVCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCredito.Location = New System.Drawing.Point(6, 38)
        Me.DGVCredito.Name = "DGVCredito"
        Me.DGVCredito.Size = New System.Drawing.Size(349, 121)
        Me.DGVCredito.TabIndex = 51
        Me.DGVCredito.Visible = False
        '
        'FacturasVencidas
        '
        Me.FacturasVencidas.Controls.Add(Me.Label19)
        Me.FacturasVencidas.Controls.Add(Me.Label18)
        Me.FacturasVencidas.Controls.Add(Me.BadCust)
        Me.FacturasVencidas.Controls.Add(Me.AverageCust)
        Me.FacturasVencidas.Controls.Add(Me.GoodCust)
        Me.FacturasVencidas.Controls.Add(Me.PromedioVisitas)
        Me.FacturasVencidas.Controls.Add(Me.MontoDeuda)
        Me.FacturasVencidas.Controls.Add(Me.Label15)
        Me.FacturasVencidas.Controls.Add(Me.Label14)
        Me.FacturasVencidas.Controls.Add(Me.Label13)
        Me.FacturasVencidas.Controls.Add(Me.Label12)
        Me.FacturasVencidas.Controls.Add(Me.DGVCredito)
        Me.FacturasVencidas.Location = New System.Drawing.Point(367, 40)
        Me.FacturasVencidas.Name = "FacturasVencidas"
        Me.FacturasVencidas.Size = New System.Drawing.Size(361, 324)
        Me.FacturasVencidas.TabIndex = 52
        Me.FacturasVencidas.TabStop = False
        Me.FacturasVencidas.Text = "Estado Crediticio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Facturas Pendientes"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Saldo Deudor    $"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "N° de Visitas (Promedio por mes)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Estado Cliente"
        '
        'MontoDeuda
        '
        Me.MontoDeuda.AutoSize = True
        Me.MontoDeuda.Location = New System.Drawing.Point(102, 182)
        Me.MontoDeuda.Name = "MontoDeuda"
        Me.MontoDeuda.Size = New System.Drawing.Size(28, 13)
        Me.MontoDeuda.TabIndex = 56
        Me.MontoDeuda.Text = "0.00"
        '
        'PromedioVisitas
        '
        Me.PromedioVisitas.AutoSize = True
        Me.PromedioVisitas.Location = New System.Drawing.Point(172, 198)
        Me.PromedioVisitas.Name = "PromedioVisitas"
        Me.PromedioVisitas.Size = New System.Drawing.Size(13, 13)
        Me.PromedioVisitas.TabIndex = 57
        Me.PromedioVisitas.Text = "0"
        '
        'GoodCust
        '
        Me.GoodCust.AutoSize = True
        Me.GoodCust.BackColor = System.Drawing.Color.Lime
        Me.GoodCust.Location = New System.Drawing.Point(131, 232)
        Me.GoodCust.Name = "GoodCust"
        Me.GoodCust.Size = New System.Drawing.Size(38, 13)
        Me.GoodCust.TabIndex = 58
        Me.GoodCust.Text = "Bueno"
        Me.GoodCust.Visible = False
        '
        'AverageCust
        '
        Me.AverageCust.AutoSize = True
        Me.AverageCust.BackColor = System.Drawing.Color.Yellow
        Me.AverageCust.Location = New System.Drawing.Point(214, 232)
        Me.AverageCust.Name = "AverageCust"
        Me.AverageCust.Size = New System.Drawing.Size(44, 13)
        Me.AverageCust.TabIndex = 59
        Me.AverageCust.Text = "Regular"
        Me.AverageCust.Visible = False
        '
        'BadCust
        '
        Me.BadCust.AutoSize = True
        Me.BadCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BadCust.Location = New System.Drawing.Point(299, 232)
        Me.BadCust.Name = "BadCust"
        Me.BadCust.Size = New System.Drawing.Size(30, 13)
        Me.BadCust.TabIndex = 60
        Me.BadCust.Text = "Malo"
        Me.BadCust.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 215)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 13)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Facturas Vencidas"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(106, 215)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 13)
        Me.Label19.TabIndex = 62
        Me.Label19.Text = "0"
        '
        'DetalleCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 435)
        Me.Controls.Add(Me.FacturasVencidas)
        Me.Controls.Add(Me.InfoClienteDGV)
        Me.Controls.Add(Me.IDCliente)
        Me.Controls.Add(Me.DomicilioFiscal)
        Me.Controls.Add(Me.RFC)
        Me.Controls.Add(Me.PersonaFiscal)
        Me.Controls.Add(Me.SaldoMembresia)
        Me.Controls.Add(Me.membresiaID)
        Me.Controls.Add(Me.adeudocredito)
        Me.Controls.Add(Me.Credito)
        Me.Controls.Add(Me.tipocliente)
        Me.Controls.Add(Me.cumpleañoscliente)
        Me.Controls.Add(Me.correocliente)
        Me.Controls.Add(Me.telcliente)
        Me.Controls.Add(Me.nombrecliente)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lblnombre)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DetalleCliente"
        Me.Text = "DetalleCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.InfoClienteDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturasVencidas.ResumeLayout(False)
        Me.FacturasVencidas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SalirModulo As Button
    Friend WithEvents AppName As Label
    Friend WithEvents DomicilioFiscal As TextBox
    Friend WithEvents RFC As TextBox
    Friend WithEvents PersonaFiscal As TextBox
    Friend WithEvents SaldoMembresia As TextBox
    Friend WithEvents membresiaID As TextBox
    Friend WithEvents adeudocredito As TextBox
    Friend WithEvents Credito As TextBox
    Friend WithEvents tipocliente As TextBox
    Friend WithEvents cumpleañoscliente As TextBox
    Friend WithEvents correocliente As TextBox
    Friend WithEvents telcliente As TextBox
    Friend WithEvents nombrecliente As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lblnombre As Label
    Friend WithEvents IDCliente As Label
    Friend WithEvents InfoClienteDGV As DataGridView
    Friend WithEvents DGVCredito As DataGridView
    Friend WithEvents FacturasVencidas As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents BadCust As Label
    Friend WithEvents AverageCust As Label
    Friend WithEvents GoodCust As Label
    Friend WithEvents PromedioVisitas As Label
    Friend WithEvents MontoDeuda As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
End Class
