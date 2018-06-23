Imports System.ComponentModel
Public Class ForgottedPassword
    Dim SQL As New SQLConn
    Public CurrentUserID As String = ""
    Private Sub ForgottedPassword_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim obj As Control
        For Each obj In Me.Controls
            CType(obj, Label).Visible = False
            CType(obj, TextBox).Visible = False
            CType(obj, TextBox).Enabled = True
            CType(obj, GroupBox).Visible = False
            CType(obj, Button).Visible = False
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ValidateUser.Click
        SQL.RunQuery("SELECT UserID as UserCount " &
                     "FROM LBUsers " &
                     "WHERE username ='" & Username.Text & "'")
        If SQL.SQLDS.Tables.Count > 0 Then
            DGVResetUser.DataSource = SQL.SQLDS.Tables(0)
            CurrentUserID = DGVResetUser.Rows(0).Cells(0).Value
        End If
        If CurrentUserID <> "" Then
            SQL.RunQuery("SELECT SecretQuestion FROM LBUsers " &
                         "WHERE UserID = '" & CurrentUserID & "'")
            If SQL.SQLDS.Tables.Count > 0 Then
                DGVResetUser.DataSource = SQL.SQLDS.Tables(0)
                SecretQuestion.Text = DGVResetUser.Rows(0).Cells(0).Value.ToString
                If SecretQuestion.Text <> "" Then
                    SecretQuestion.Visible = True
                    SecretAnswer.Visible = True
                    Lblanswer.Visible = True
                    ValidateAnswer.Visible = True
                Else
                    MsgBox("El usuario que seleccionaste no cuenta con pregunta secreta, por favor pide a tu administrador del sistema el desbloqueo de la misma y el alta de pregunta y respuesta secreta", MsgBoxStyle.Information, "Error en reinicio de contraseña")
                End If

            End If
            Else
            MsgBox("No se pudo validar el usuario, favor de reintentar", MsgBoxStyle.Critical, "Reestablecer contraseña")
        End If

    End Sub

    Private Sub ValidateAnswer_Click(sender As Object, e As EventArgs) Handles ValidateAnswer.Click
        If SecretQuestion.Text <> "" And SecretAnswer.Text <> "" Then
            SQL.RunQuery("SELECT COUNT (UserID) as UserCount " &
                        "FROM LBUsers " &
                        "WHERE UserID ='" & CurrentUserID & "' " &
                        "AND SecretAnswer ='" & SecretAnswer.Text & "'")
            If SQL.SQLDS.Tables(0).Rows(0).Item("UserCount") = 1 Then
                ChangePassGroup.Visible = True
                Dim obj As Object
                For Each obj In Me.ChangePassGroup.Controls
                    If TypeOf obj Is TextBox Then
                        CType(obj, TextBox).Visible = True
                    ElseIf TypeOf obj Is Label Then
                        CType(obj, Label).Visible = True
                    ElseIf TypeOf obj Is Button Then
                        CType(obj, Button).Visible = True
                    End If
                Next
                Username.Enabled = False
                SecretAnswer.Enabled = False
            Else
                MsgBox("Respuesta incorrecta, favor de validarlo", MsgBoxStyle.Critical)
            End If
        ElseIf SecretAnswer.Text = "" Then
            MsgBox("El campo de respuesta no puede quedar vacío", MsgBoxStyle.Exclamation, "Reestablecer contraseña")
        ElseIf SecretQuestion.Text = "" Then
            MsgBox("El usuario que seleccionaste no cuenta con pregunta secreta, por favor pide a tu administrador del sistema el desbloqueo de la misma y el alta de pregunta y respuesta secreta", MsgBoxStyle.Information, "Error en reinicio de contraseña")
        End If
    End Sub

    Private Sub SavePasswordChange_Click(sender As Object, e As EventArgs) Handles SavePasswordChange.Click
        If Password.Text = ConfirmPassword.Text Then
            SQL.RunQuery("UPDATE LBUsers " &
                         "SET Password = '" & Password.Text & "', " &
                         "NeedsChangePsw = 'NO' " &
                         "WHERE UserID = '" & CurrentUserID & "'")
            MsgBox("El password se actualizo correctamente, favor de reingresar", MsgBoxStyle.Information, "Cambio de contraseña")
            Me.Dispose()
        ElseIf Password.Text <> ConfirmPassword.Text Then
            MsgBox("Las contraseñas no coinciden, favor de reintentar", MsgBoxStyle.Exclamation, "Cambio de contraseña")
        ElseIf Password.Text = "" Then
            MsgBox("Es necesario ingresar una nueva contraseña", MsgBoxStyle.Information, "Cambio de contraseña")
        ElseIf ConfirmPassword.Text = "" Then
            MsgBox("Es necesario confirmar la contraseña", MsgBoxStyle.Information, "Cambio de contraseña")
        End If

    End Sub

    Private Sub Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password.KeyPress
        If e.KeyChar = Chr(13) Then
            SavePasswordChange.PerformClick()
        End If
    End Sub

    Private Sub ConfirmPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ConfirmPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            SavePasswordChange.PerformClick()
        End If
    End Sub
End Class