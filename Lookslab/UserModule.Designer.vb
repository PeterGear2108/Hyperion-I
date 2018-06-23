<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserModule
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVUsers = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarContraseñaDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarPreguntaSecretaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDToUnlock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResetearPassword = New System.Windows.Forms.GroupBox()
        Me.ResetPassword = New System.Windows.Forms.Button()
        Me.UserQuery = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserData = New System.Windows.Forms.GroupBox()
        Me.DisposeChanges = New System.Windows.Forms.Button()
        Me.SaveChanges = New System.Windows.Forms.Button()
        Me.LblAnswer = New System.Windows.Forms.Label()
        Me.SecretAnswer = New System.Windows.Forms.TextBox()
        Me.SecretQuestion = New System.Windows.Forms.TextBox()
        Me.LblQuestion = New System.Windows.Forms.Label()
        Me.CurrentUserID = New System.Windows.Forms.Label()
        Me.LblConfirmPass = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.AddNewUser = New System.Windows.Forms.Button()
        Me.LblUserID = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.DGVUserWorkspace = New System.Windows.Forms.DataGridView()
        Me.TipsContraseña = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ExitUsers = New System.Windows.Forms.Button()
        Me.ModuleTitle = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NombreCompleto = New System.Windows.Forms.TextBox()
        CType(Me.DGVUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ResetearPassword.SuspendLayout()
        Me.UserData.SuspendLayout()
        CType(Me.DGVUserWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVUsers
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGVUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsers.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVUsers.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVUsers.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVUsers.Location = New System.Drawing.Point(12, 69)
        Me.DGVUsers.Name = "DGVUsers"
        Me.DGVUsers.ReadOnly = True
        Me.DGVUsers.RowHeadersVisible = False
        Me.DGVUsers.Size = New System.Drawing.Size(260, 265)
        Me.DGVUsers.TabIndex = 12
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarContraseñaDeUsuarioToolStripMenuItem, Me.EliminarUsuarioToolStripMenuItem, Me.CambiarPreguntaSecretaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(224, 70)
        '
        'EditarContraseñaDeUsuarioToolStripMenuItem
        '
        Me.EditarContraseñaDeUsuarioToolStripMenuItem.Name = "EditarContraseñaDeUsuarioToolStripMenuItem"
        Me.EditarContraseñaDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.EditarContraseñaDeUsuarioToolStripMenuItem.Text = "Editar contraseña de usuario"
        '
        'EliminarUsuarioToolStripMenuItem
        '
        Me.EliminarUsuarioToolStripMenuItem.Name = "EliminarUsuarioToolStripMenuItem"
        Me.EliminarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.EliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario"
        '
        'CambiarPreguntaSecretaToolStripMenuItem
        '
        Me.CambiarPreguntaSecretaToolStripMenuItem.Name = "CambiarPreguntaSecretaToolStripMenuItem"
        Me.CambiarPreguntaSecretaToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.CambiarPreguntaSecretaToolStripMenuItem.Text = "Cambiar pregunta secreta"
        '
        'IDToUnlock
        '
        Me.IDToUnlock.Location = New System.Drawing.Point(69, 31)
        Me.IDToUnlock.Name = "IDToUnlock"
        Me.IDToUnlock.Size = New System.Drawing.Size(100, 20)
        Me.IDToUnlock.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Usuario"
        '
        'ResetearPassword
        '
        Me.ResetearPassword.Controls.Add(Me.ResetPassword)
        Me.ResetearPassword.Controls.Add(Me.Label1)
        Me.ResetearPassword.Controls.Add(Me.IDToUnlock)
        Me.ResetearPassword.ForeColor = System.Drawing.Color.Snow
        Me.ResetearPassword.Location = New System.Drawing.Point(278, 280)
        Me.ResetearPassword.Name = "ResetearPassword"
        Me.ResetearPassword.Size = New System.Drawing.Size(314, 100)
        Me.ResetearPassword.TabIndex = 14
        Me.ResetearPassword.TabStop = False
        Me.ResetearPassword.Text = "Reestablecer contraseña"
        '
        'ResetPassword
        '
        Me.ResetPassword.BackColor = System.Drawing.SystemColors.Highlight
        Me.ResetPassword.Location = New System.Drawing.Point(175, 31)
        Me.ResetPassword.Name = "ResetPassword"
        Me.ResetPassword.Size = New System.Drawing.Size(81, 20)
        Me.ResetPassword.TabIndex = 9
        Me.ResetPassword.Text = "Reestablecer"
        Me.ResetPassword.UseVisualStyleBackColor = False
        '
        'UserQuery
        '
        Me.UserQuery.Location = New System.Drawing.Point(95, 43)
        Me.UserQuery.Name = "UserQuery"
        Me.UserQuery.Size = New System.Drawing.Size(177, 20)
        Me.UserQuery.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Buscar usuario"
        '
        'UserData
        '
        Me.UserData.Controls.Add(Me.Label3)
        Me.UserData.Controls.Add(Me.NombreCompleto)
        Me.UserData.Controls.Add(Me.DisposeChanges)
        Me.UserData.Controls.Add(Me.SaveChanges)
        Me.UserData.Controls.Add(Me.LblAnswer)
        Me.UserData.Controls.Add(Me.SecretAnswer)
        Me.UserData.Controls.Add(Me.SecretQuestion)
        Me.UserData.Controls.Add(Me.LblQuestion)
        Me.UserData.Controls.Add(Me.CurrentUserID)
        Me.UserData.Controls.Add(Me.LblConfirmPass)
        Me.UserData.Controls.Add(Me.ConfirmPassword)
        Me.UserData.Controls.Add(Me.Password)
        Me.UserData.Controls.Add(Me.LblPass)
        Me.UserData.Controls.Add(Me.LblUsername)
        Me.UserData.Controls.Add(Me.AddNewUser)
        Me.UserData.Controls.Add(Me.LblUserID)
        Me.UserData.Controls.Add(Me.Username)
        Me.UserData.ForeColor = System.Drawing.Color.Snow
        Me.UserData.Location = New System.Drawing.Point(278, 41)
        Me.UserData.Name = "UserData"
        Me.UserData.Size = New System.Drawing.Size(314, 233)
        Me.UserData.TabIndex = 15
        Me.UserData.TabStop = False
        Me.UserData.Text = "Usuario Actual"
        '
        'DisposeChanges
        '
        Me.DisposeChanges.BackColor = System.Drawing.SystemColors.Highlight
        Me.DisposeChanges.Location = New System.Drawing.Point(126, 198)
        Me.DisposeChanges.Name = "DisposeChanges"
        Me.DisposeChanges.Size = New System.Drawing.Size(92, 29)
        Me.DisposeChanges.TabIndex = 6
        Me.DisposeChanges.Text = "Descartar"
        Me.DisposeChanges.UseVisualStyleBackColor = False
        '
        'SaveChanges
        '
        Me.SaveChanges.BackColor = System.Drawing.SystemColors.Highlight
        Me.SaveChanges.Location = New System.Drawing.Point(233, 198)
        Me.SaveChanges.Name = "SaveChanges"
        Me.SaveChanges.Size = New System.Drawing.Size(74, 29)
        Me.SaveChanges.TabIndex = 7
        Me.SaveChanges.Text = "Guardar"
        Me.SaveChanges.UseVisualStyleBackColor = False
        '
        'LblAnswer
        '
        Me.LblAnswer.AutoSize = True
        Me.LblAnswer.Location = New System.Drawing.Point(9, 176)
        Me.LblAnswer.Name = "LblAnswer"
        Me.LblAnswer.Size = New System.Drawing.Size(58, 13)
        Me.LblAnswer.TabIndex = 13
        Me.LblAnswer.Text = "Respuesta"
        '
        'SecretAnswer
        '
        Me.SecretAnswer.Enabled = False
        Me.SecretAnswer.Location = New System.Drawing.Point(118, 173)
        Me.SecretAnswer.Name = "SecretAnswer"
        Me.SecretAnswer.Size = New System.Drawing.Size(189, 20)
        Me.SecretAnswer.TabIndex = 5
        '
        'SecretQuestion
        '
        Me.SecretQuestion.Enabled = False
        Me.SecretQuestion.Location = New System.Drawing.Point(118, 147)
        Me.SecretQuestion.Name = "SecretQuestion"
        Me.SecretQuestion.Size = New System.Drawing.Size(189, 20)
        Me.SecretQuestion.TabIndex = 4
        Me.TipsContraseña.SetToolTip(Me.SecretQuestion, "Elige una pregunta que solo tu puedes responder. Ejemplo: Nombre del primer amor," &
        " Segundo nombre de tu abuelo, Etc. ")
        '
        'LblQuestion
        '
        Me.LblQuestion.AutoSize = True
        Me.LblQuestion.Location = New System.Drawing.Point(6, 150)
        Me.LblQuestion.Name = "LblQuestion"
        Me.LblQuestion.Size = New System.Drawing.Size(88, 13)
        Me.LblQuestion.TabIndex = 10
        Me.LblQuestion.Text = "Pregunta secreta"
        '
        'CurrentUserID
        '
        Me.CurrentUserID.AutoSize = True
        Me.CurrentUserID.Location = New System.Drawing.Point(69, 28)
        Me.CurrentUserID.Name = "CurrentUserID"
        Me.CurrentUserID.Size = New System.Drawing.Size(13, 13)
        Me.CurrentUserID.TabIndex = 9
        Me.CurrentUserID.Text = "1"
        '
        'LblConfirmPass
        '
        Me.LblConfirmPass.AutoSize = True
        Me.LblConfirmPass.Location = New System.Drawing.Point(6, 124)
        Me.LblConfirmPass.Name = "LblConfirmPass"
        Me.LblConfirmPass.Size = New System.Drawing.Size(108, 13)
        Me.LblConfirmPass.TabIndex = 8
        Me.LblConfirmPass.Text = "Confirmar Contraseña"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Enabled = False
        Me.ConfirmPassword.Location = New System.Drawing.Point(119, 121)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.Size = New System.Drawing.Size(189, 20)
        Me.ConfirmPassword.TabIndex = 3
        Me.TipsContraseña.SetToolTip(Me.ConfirmPassword, "Las contraseñas deben coincidir para poder continuar")
        '
        'Password
        '
        Me.Password.Enabled = False
        Me.Password.Location = New System.Drawing.Point(119, 95)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(189, 20)
        Me.Password.TabIndex = 2
        Me.TipsContraseña.SetToolTip(Me.Password, "Puedes escoger cualquier password, pero te recomendamos usar al menos mayúsculas," &
        " numeros y carácteres especiales")
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Location = New System.Drawing.Point(6, 98)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(61, 13)
        Me.LblPass.TabIndex = 5
        Me.LblPass.Text = "Contraseña"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(4, 73)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(83, 13)
        Me.LblUsername.TabIndex = 4
        Me.LblUsername.Text = "Nombre Usuario"
        '
        'AddNewUser
        '
        Me.AddNewUser.BackColor = System.Drawing.SystemColors.Highlight
        Me.AddNewUser.Location = New System.Drawing.Point(6, 198)
        Me.AddNewUser.Name = "AddNewUser"
        Me.AddNewUser.Size = New System.Drawing.Size(105, 29)
        Me.AddNewUser.TabIndex = 11
        Me.AddNewUser.Text = "Agregar Usuario"
        Me.AddNewUser.UseVisualStyleBackColor = False
        '
        'LblUserID
        '
        Me.LblUserID.AutoSize = True
        Me.LblUserID.Location = New System.Drawing.Point(6, 28)
        Me.LblUserID.Name = "LblUserID"
        Me.LblUserID.Size = New System.Drawing.Size(57, 13)
        Me.LblUserID.TabIndex = 2
        Me.LblUserID.Text = "ID Usuario"
        '
        'Username
        '
        Me.Username.Enabled = False
        Me.Username.Location = New System.Drawing.Point(118, 70)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(189, 20)
        Me.Username.TabIndex = 1
        '
        'DGVUserWorkspace
        '
        Me.DGVUserWorkspace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUserWorkspace.Location = New System.Drawing.Point(12, 340)
        Me.DGVUserWorkspace.Name = "DGVUserWorkspace"
        Me.DGVUserWorkspace.Size = New System.Drawing.Size(260, 34)
        Me.DGVUserWorkspace.TabIndex = 13
        Me.DGVUserWorkspace.Visible = False
        '
        'TipsContraseña
        '
        Me.TipsContraseña.AutoPopDelay = 5000
        Me.TipsContraseña.InitialDelay = 2
        Me.TipsContraseña.IsBalloon = True
        Me.TipsContraseña.ReshowDelay = 100
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.Controls.Add(Me.ExitUsers)
        Me.Panel1.Controls.Add(Me.ModuleTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 26)
        Me.Panel1.TabIndex = 16
        '
        'ExitUsers
        '
        Me.ExitUsers.BackColor = System.Drawing.Color.Red
        Me.ExitUsers.Location = New System.Drawing.Point(574, 2)
        Me.ExitUsers.Name = "ExitUsers"
        Me.ExitUsers.Size = New System.Drawing.Size(28, 23)
        Me.ExitUsers.TabIndex = 1
        Me.ExitUsers.Text = "X"
        Me.ExitUsers.UseVisualStyleBackColor = False
        '
        'ModuleTitle
        '
        Me.ModuleTitle.AutoSize = True
        Me.ModuleTitle.Location = New System.Drawing.Point(3, 9)
        Me.ModuleTitle.Name = "ModuleTitle"
        Me.ModuleTitle.Size = New System.Drawing.Size(132, 13)
        Me.ModuleTitle.TabIndex = 0
        Me.ModuleTitle.Text = "Administracion de usuarios"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nombre Completo"
        '
        'NombreCompleto
        '
        Me.NombreCompleto.Enabled = False
        Me.NombreCompleto.Location = New System.Drawing.Point(119, 44)
        Me.NombreCompleto.Name = "NombreCompleto"
        Me.NombreCompleto.Size = New System.Drawing.Size(189, 20)
        Me.NombreCompleto.TabIndex = 14
        '
        'UserModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(604, 389)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVUserWorkspace)
        Me.Controls.Add(Me.UserData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserQuery)
        Me.Controls.Add(Me.ResetearPassword)
        Me.Controls.Add(Me.DGVUsers)
        Me.ForeColor = System.Drawing.Color.Snow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserModule"
        Me.Text = "UserModule"
        CType(Me.DGVUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResetearPassword.ResumeLayout(False)
        Me.ResetearPassword.PerformLayout()
        Me.UserData.ResumeLayout(False)
        Me.UserData.PerformLayout()
        CType(Me.DGVUserWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVUsers As DataGridView
    Friend WithEvents IDToUnlock As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ResetearPassword As GroupBox
    Friend WithEvents ResetPassword As Button
    Friend WithEvents UserQuery As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UserData As GroupBox
    Friend WithEvents CurrentUserID As Label
    Friend WithEvents LblConfirmPass As Label
    Friend WithEvents ConfirmPassword As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents LblPass As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents AddNewUser As Button
    Friend WithEvents LblUserID As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents SaveChanges As Button
    Friend WithEvents LblAnswer As Label
    Friend WithEvents SecretAnswer As TextBox
    Friend WithEvents SecretQuestion As TextBox
    Friend WithEvents LblQuestion As Label
    Friend WithEvents DisposeChanges As Button
    Friend WithEvents DGVUserWorkspace As DataGridView
    Friend WithEvents TipsContraseña As ToolTip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarContraseñaDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarPreguntaSecretaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExitUsers As Button
    Friend WithEvents ModuleTitle As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NombreCompleto As TextBox
End Class
