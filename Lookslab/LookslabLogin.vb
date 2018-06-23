Public Class LookslabLogin
    Dim sql As New SQLConn


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" And PasswordTextBox.Text = "" Then
            MsgBox("Favor de insertar los datos completos", MsgBoxStyle.Critical, Title:=("Error al iniciar sesión"))
        ElseIf UsernameTextBox.Text <> "" And PasswordTextBox.Text = "" Then
            MsgBox("La contraseña no puede estar vacia", MsgBoxStyle.Critical, Title:=("Error al iniciar sesión"))
        ElseIf UsernameTextBox.Text = "" And PasswordTextBox.Text <> "" Then
            MsgBox("El campo usuario no puede estar vacío", MsgBoxStyle.Critical, Title:=("Error al iniciar sesión"))
        Else
            If Validado() = True Then
                If PassChange() = False Then
                    PantallaPrincipal.TagName.Text = "Bienvenido: " & UsernameTextBox.Text
                    PantallaPrincipal.LastLogin.Text = "Ult. Sesión: " & DateTime.Now.ToString
                    sql.RunQuery("SELECT * FROM LBUsers " &
                   "WHERE username ='" & UsernameTextBox.Text & "'")
                    If sql.SQLDS.Tables.Count > 0 Then
                        PantallaPrincipal.DGVTemp.DataSource = sql.SQLDS.Tables(0)
                        PantallaPrincipal.CurrentUserID.Text = PantallaPrincipal.DGVTemp.Item(0, 0).Value.ToString
                    End If
                    Me.Hide()
                    PantallaPrincipal.Show()
                ElseIf PassChange = True Then
                    MsgBox("Es necesario cambiar la contraseña para permitir el acceso", MsgBoxStyle.Information, "Contraseña expirada")
                    sql.RunQuery("SELECT * FROM LBUsers " &
                   "WHERE username ='" & UsernameTextBox.Text & "'")
                    If sql.SQLDS.Tables.Count > 0 Then
                        PantallaPrincipal.DGVTemp.DataSource = sql.SQLDS.Tables(0)
                        ForgottedPassword.CurrentUserID = PantallaPrincipal.DGVTemp.Item(0, 0).Value.ToString
                    End If
                    ForgottedPassword.Show()
                    ForgottedPassword.ChangePassGroup.Visible = True
                    Dim obj As Control
                    For Each obj In ForgottedPassword.ChangePassGroup.Controls
                        If TypeOf obj Is Label Then
                            CType(obj, Label).Visible = True
                        End If
                        If TypeOf obj Is TextBox Then
                            CType(obj, TextBox).Visible = True
                        End If
                        If TypeOf obj Is Button Then
                            CType(obj, Button).Visible = True
                        End If
                    Next
                End If
            End If
        End If


    End Sub
    Public Function Validado()
        sql.RunQuery("SELECT Count (UserID) as Usercount " &
                     "FROM LBUsers " &
                   "WHERE username ='" & UsernameTextBox.Text & "' " &
                   "AND Password='" & PasswordTextBox.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS")
        If sql.SQLDS.Tables(0).Rows(0).Item("Usercount") = 1 Then
            Return True
        Else
            MsgBox("Datos incorrectos, reintente", MsgBoxStyle.Critical)
            Return False
        End If
    End Function
    Public Function PassChange()
        sql.RunQuery("SELECT * FROM LBUsers " &
                     "WHERE username = '" & UsernameTextBox.Text & "'")
        If sql.SQLDS.Tables(0).Rows(0).Item("NeedsChangePsw") = "YES" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ForgotPasswordLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPasswordLink.LinkClicked
        ForgottedPassword.Show()
        ForgottedPassword.Label1.Visible = True
        ForgottedPassword.Username.Visible = True
        ForgottedPassword.ValidateUser.Visible = True
    End Sub
End Class
