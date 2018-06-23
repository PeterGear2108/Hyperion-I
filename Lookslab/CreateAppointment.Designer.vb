<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateAppointment
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerID = New System.Windows.Forms.TextBox()
        Me.CBCustomers = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateAppointment = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HoraInicio = New System.Windows.Forms.ComboBox()
        Me.HoraFin = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DescripcionServ = New System.Windows.Forms.TextBox()
        Me.GuardarCita = New System.Windows.Forms.Button()
        Me.UsuarioAsignado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 27)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(321, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agendar Nueva Cita"
        '
        'CustomerID
        '
        Me.CustomerID.Location = New System.Drawing.Point(65, 35)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.ReadOnly = True
        Me.CustomerID.Size = New System.Drawing.Size(100, 20)
        Me.CustomerID.TabIndex = 1
        '
        'CBCustomers
        '
        Me.CBCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCustomers.FormattingEnabled = True
        Me.CBCustomers.Location = New System.Drawing.Point(65, 59)
        Me.CBCustomers.Name = "CBCustomers"
        Me.CBCustomers.Size = New System.Drawing.Size(274, 21)
        Me.CBCustomers.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha de Cita"
        '
        'DateAppointment
        '
        Me.DateAppointment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateAppointment.Location = New System.Drawing.Point(85, 84)
        Me.DateAppointment.MinDate = New Date(2017, 12, 28, 0, 0, 0, 0)
        Me.DateAppointment.Name = "DateAppointment"
        Me.DateAppointment.Size = New System.Drawing.Size(111, 20)
        Me.DateAppointment.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Horario inicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Horario Fin"
        '
        'HoraInicio
        '
        Me.HoraInicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.HoraInicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HoraInicio.FormattingEnabled = True
        Me.HoraInicio.Location = New System.Drawing.Point(69, 109)
        Me.HoraInicio.Name = "HoraInicio"
        Me.HoraInicio.Size = New System.Drawing.Size(96, 21)
        Me.HoraInicio.TabIndex = 10
        '
        'HoraFin
        '
        Me.HoraFin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.HoraFin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HoraFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HoraFin.FormattingEnabled = True
        Me.HoraFin.Location = New System.Drawing.Point(241, 110)
        Me.HoraFin.Name = "HoraFin"
        Me.HoraFin.Size = New System.Drawing.Size(98, 21)
        Me.HoraFin.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Descripcion del Servicio"
        '
        'DescripcionServ
        '
        Me.DescripcionServ.Location = New System.Drawing.Point(6, 212)
        Me.DescripcionServ.Multiline = True
        Me.DescripcionServ.Name = "DescripcionServ"
        Me.DescripcionServ.Size = New System.Drawing.Size(333, 130)
        Me.DescripcionServ.TabIndex = 13
        '
        'GuardarCita
        '
        Me.GuardarCita.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GuardarCita.Location = New System.Drawing.Point(12, 356)
        Me.GuardarCita.Name = "GuardarCita"
        Me.GuardarCita.Size = New System.Drawing.Size(94, 23)
        Me.GuardarCita.TabIndex = 2
        Me.GuardarCita.Text = "Guardar"
        Me.GuardarCita.UseVisualStyleBackColor = False
        '
        'UsuarioAsignado
        '
        Me.UsuarioAsignado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UsuarioAsignado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UsuarioAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UsuarioAsignado.FormattingEnabled = True
        Me.UsuarioAsignado.Location = New System.Drawing.Point(69, 136)
        Me.UsuarioAsignado.Name = "UsuarioAsignado"
        Me.UsuarioAsignado.Size = New System.Drawing.Size(270, 21)
        Me.UsuarioAsignado.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Atiende"
        '
        'CreateAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 382)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.UsuarioAsignado)
        Me.Controls.Add(Me.GuardarCita)
        Me.Controls.Add(Me.DescripcionServ)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.HoraFin)
        Me.Controls.Add(Me.HoraInicio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateAppointment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBCustomers)
        Me.Controls.Add(Me.CustomerID)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateAppointment"
        Me.Text = "CreateAppointment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerID As TextBox
    Friend WithEvents CBCustomers As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateAppointment As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents HoraInicio As ComboBox
    Friend WithEvents HoraFin As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DescripcionServ As TextBox
    Friend WithEvents GuardarCita As Button
    Friend WithEvents UsuarioAsignado As ComboBox
    Friend WithEvents Label8 As Label
End Class
