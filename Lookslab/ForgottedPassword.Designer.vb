<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgottedPassword
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
#Disable Warning BC30269 ' 'Protected Overrides Sub Dispose(disposing As Boolean)' tiene varias definiciones con firmas idénticas.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
#Enable Warning BC30269 ' 'Protected Overrides Sub Dispose(disposing As Boolean)' tiene varias definiciones con firmas idénticas.
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
#Disable Warning BC30269 ' 'Private Sub InitializeComponent()' tiene varias definiciones con firmas idénticas.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ValidateUser = New System.Windows.Forms.Button()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SecretAnswer = New System.Windows.Forms.TextBox()
        Me.SecretQuestion = New System.Windows.Forms.Label()
        Me.Lblanswer = New System.Windows.Forms.Label()
        Me.ValidateAnswer = New System.Windows.Forms.Button()
        Me.ChangePassGroup = New System.Windows.Forms.GroupBox()
        Me.SavePasswordChange = New System.Windows.Forms.Button()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.DGVResetUser = New System.Windows.Forms.DataGridView()
        Me.ChangePassGroup.SuspendLayout()
        CType(Me.DGVResetUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ValidateUser
        '
        Me.ValidateUser.Location = New System.Drawing.Point(118, 23)
        Me.ValidateUser.Name = "ValidateUser"
        Me.ValidateUser.Size = New System.Drawing.Size(71, 23)
        Me.ValidateUser.TabIndex = 0
        Me.ValidateUser.Text = "Validar"
        Me.ValidateUser.UseVisualStyleBackColor = True
        Me.ValidateUser.Visible = False
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(12, 25)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(100, 20)
        Me.Username.TabIndex = 1
        Me.Username.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingresa tu nombre de usuario"
        Me.Label1.Visible = False
        '
        'SecretAnswer
        '
        Me.SecretAnswer.Location = New System.Drawing.Point(16, 113)
        Me.SecretAnswer.Name = "SecretAnswer"
        Me.SecretAnswer.Size = New System.Drawing.Size(177, 20)
        Me.SecretAnswer.TabIndex = 3
        Me.SecretAnswer.Visible = False
        '
        'SecretQuestion
        '
        Me.SecretQuestion.AutoSize = True
        Me.SecretQuestion.Location = New System.Drawing.Point(13, 72)
        Me.SecretQuestion.Name = "SecretQuestion"
        Me.SecretQuestion.Size = New System.Drawing.Size(0, 13)
        Me.SecretQuestion.TabIndex = 4
        Me.SecretQuestion.Visible = False
        '
        'Lblanswer
        '
        Me.Lblanswer.AutoSize = True
        Me.Lblanswer.Location = New System.Drawing.Point(13, 97)
        Me.Lblanswer.Name = "Lblanswer"
        Me.Lblanswer.Size = New System.Drawing.Size(61, 13)
        Me.Lblanswer.TabIndex = 5
        Me.Lblanswer.Text = "Respuesta:"
        Me.Lblanswer.Visible = False
        '
        'ValidateAnswer
        '
        Me.ValidateAnswer.Location = New System.Drawing.Point(16, 140)
        Me.ValidateAnswer.Name = "ValidateAnswer"
        Me.ValidateAnswer.Size = New System.Drawing.Size(75, 23)
        Me.ValidateAnswer.TabIndex = 6
        Me.ValidateAnswer.Text = "Enviar"
        Me.ValidateAnswer.UseVisualStyleBackColor = True
        Me.ValidateAnswer.Visible = False
        '
        'ChangePassGroup
        '
        Me.ChangePassGroup.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ChangePassGroup.Controls.Add(Me.SavePasswordChange)
        Me.ChangePassGroup.Controls.Add(Me.ConfirmPassword)
        Me.ChangePassGroup.Controls.Add(Me.Password)
        Me.ChangePassGroup.Controls.Add(Me.lblConfirmPass)
        Me.ChangePassGroup.Controls.Add(Me.lblNewPass)
        Me.ChangePassGroup.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ChangePassGroup.Location = New System.Drawing.Point(242, 10)
        Me.ChangePassGroup.Name = "ChangePassGroup"
        Me.ChangePassGroup.Size = New System.Drawing.Size(200, 201)
        Me.ChangePassGroup.TabIndex = 7
        Me.ChangePassGroup.TabStop = False
        Me.ChangePassGroup.Text = "Cambiar Contraseña"
        Me.ChangePassGroup.Visible = False
        '
        'SavePasswordChange
        '
        Me.SavePasswordChange.Location = New System.Drawing.Point(9, 149)
        Me.SavePasswordChange.Name = "SavePasswordChange"
        Me.SavePasswordChange.Size = New System.Drawing.Size(75, 23)
        Me.SavePasswordChange.TabIndex = 8
        Me.SavePasswordChange.Text = "Guardar"
        Me.SavePasswordChange.UseVisualStyleBackColor = True
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Location = New System.Drawing.Point(9, 103)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassword.Size = New System.Drawing.Size(185, 20)
        Me.ConfirmPassword.TabIndex = 11
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(9, 39)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(185, 20)
        Me.Password.TabIndex = 10
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Location = New System.Drawing.Point(6, 87)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(107, 13)
        Me.lblConfirmPass.TabIndex = 9
        Me.lblConfirmPass.Text = "Confirmar contraseña"
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Location = New System.Drawing.Point(6, 23)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(95, 13)
        Me.lblNewPass.TabIndex = 8
        Me.lblNewPass.Text = "Nueva contraseña"
        '
        'DGVResetUser
        '
        Me.DGVResetUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVResetUser.Location = New System.Drawing.Point(1, 211)
        Me.DGVResetUser.Name = "DGVResetUser"
        Me.DGVResetUser.Size = New System.Drawing.Size(10, 10)
        Me.DGVResetUser.TabIndex = 8
        Me.DGVResetUser.Visible = False
        '
        'ForgottedPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(455, 223)
        Me.Controls.Add(Me.ChangePassGroup)
        Me.Controls.Add(Me.ValidateAnswer)
        Me.Controls.Add(Me.Lblanswer)
        Me.Controls.Add(Me.SecretQuestion)
        Me.Controls.Add(Me.SecretAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.ValidateUser)
        Me.Controls.Add(Me.DGVResetUser)
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ForgottedPassword"
        Me.ShowIcon = False
        Me.Text = "Cambio de contraseña"
        Me.ChangePassGroup.ResumeLayout(False)
        Me.ChangePassGroup.PerformLayout()
        CType(Me.DGVResetUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ValidateUser As Button
    Friend WithEvents Username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SecretAnswer As TextBox
    Friend WithEvents SecretQuestion As Label
    Friend WithEvents Lblanswer As Label
    Friend WithEvents ValidateAnswer As Button
    Friend WithEvents ChangePassGroup As GroupBox
    Friend WithEvents SavePasswordChange As Button
    Friend WithEvents ConfirmPassword As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents lblConfirmPass As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents DGVResetUser As DataGridView
End Class
