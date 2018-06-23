<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeQuestion
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
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.question = New System.Windows.Forms.TextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.Lblanswer = New System.Windows.Forms.Label()
        Me.answer = New System.Windows.Forms.TextBox()
        Me.CurrentUserID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guardar.Location = New System.Drawing.Point(97, 156)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 0
        Me.Guardar.Text = "Enviar"
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(12, 52)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(260, 20)
        Me.Password.TabIndex = 1
        '
        'question
        '
        Me.question.Location = New System.Drawing.Point(12, 91)
        Me.question.Name = "question"
        Me.question.Size = New System.Drawing.Size(260, 20)
        Me.question.TabIndex = 2
        Me.question.Visible = False
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(12, 36)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(179, 13)
        Me.lblpassword.TabIndex = 3
        Me.lblpassword.Text = "Primero ingresa tu contraseña actual"
        '
        'lblquestion
        '
        Me.lblquestion.AutoSize = True
        Me.lblquestion.Location = New System.Drawing.Point(12, 75)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(84, 13)
        Me.lblquestion.TabIndex = 4
        Me.lblquestion.Text = "Nueva pregunta"
        Me.lblquestion.Visible = False
        '
        'Lblanswer
        '
        Me.Lblanswer.AutoSize = True
        Me.Lblanswer.Location = New System.Drawing.Point(12, 114)
        Me.Lblanswer.Name = "Lblanswer"
        Me.Lblanswer.Size = New System.Drawing.Size(88, 13)
        Me.Lblanswer.TabIndex = 6
        Me.Lblanswer.Text = "Nueva respuesta"
        Me.Lblanswer.Visible = False
        '
        'answer
        '
        Me.answer.Location = New System.Drawing.Point(12, 130)
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(260, 20)
        Me.answer.TabIndex = 5
        Me.answer.Visible = False
        '
        'CurrentUserID
        '
        Me.CurrentUserID.AutoSize = True
        Me.CurrentUserID.Location = New System.Drawing.Point(9, 9)
        Me.CurrentUserID.Name = "CurrentUserID"
        Me.CurrentUserID.Size = New System.Drawing.Size(13, 13)
        Me.CurrentUserID.TabIndex = 7
        Me.CurrentUserID.Text = "1"
        '
        'ChangeQuestion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(284, 184)
        Me.Controls.Add(Me.CurrentUserID)
        Me.Controls.Add(Me.Lblanswer)
        Me.Controls.Add(Me.answer)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.question)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Guardar)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ChangeQuestion"
        Me.Text = "Cambiar pregunta secreta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guardar As Button
    Friend WithEvents Password As TextBox
    Friend WithEvents question As TextBox
    Friend WithEvents lblpassword As Label
    Friend WithEvents lblquestion As Label
    Friend WithEvents Lblanswer As Label
    Friend WithEvents answer As TextBox
    Friend WithEvents CurrentUserID As Label
End Class
