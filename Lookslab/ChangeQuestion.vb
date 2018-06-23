Public Class ChangeQuestion
    Dim ValidarUsuario As Boolean = False
    Dim SQL As New SQLConn
    Private Sub Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password.KeyPress
        If e.KeyChar = Chr(13) Then
            If Validado() = True Then
                If ValidarUsuario = False Then
                    If Password.Text <> "" Then
                        ValidarUsuario = True
                        lblquestion.Visible = True
                        Lblanswer.Visible = True
                        question.Visible = True
                        answer.Visible = True
                        Guardar.Text = "Guardar"
                    Else
                        MsgBox("Favor de ingresar la contraseña", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub answer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles answer.KeyPress
        If e.KeyChar = Chr(13) Then
            Guardar.PerformClick()
        End If
    End Sub

    Private Sub question_KeyPress(sender As Object, e As KeyPressEventArgs) Handles question.KeyPress
        If e.KeyChar = Chr(13) Then
            Guardar.PerformClick()
        End If
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If ValidarUsuario = True Then
            If question.Text <> "" And answer.Text <> "" Then
                SQL.RunQuery("UPDATE LBUsers " &
                                 "SET SecretQuestion ='" & question.Text & "', " &
                                 "SecretAnswer ='" & answer.Text & "' " &
                                 "WHERE UserID ='" & CurrentUserID.Text & "'")
                MsgBox("Se actualizó la pregunta secreta", MsgBoxStyle.Information)
                Dim obj As Control
                For Each obj In Me.Controls
                    If TypeOf obj Is TextBox Then
                        obj.Text = ""
                    End If
                Next
                ValidarUsuario = False
                Me.Dispose()
                UserModule.UserQuery.Text = "1"
                UserModule.UserQuery.Text = ""
            Else
                MsgBox("No se han ingresado todos los datos, favor de validar", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
    Public Function Validado()
        SQL.RunQuery("SELECT Count (UserID) as Usercount " &
                     "FROM LBUsers " &
                   "WHERE userID ='" & CurrentUserID.Text & "' " &
                   "AND Password='" & Password.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS")
        If Sql.SQLDS.Tables(0).Rows(0).Item("Usercount") = 1 Then
            Return True
        Else
            MsgBox("Datos incorrectos, reintente", MsgBoxStyle.Critical)
            Return False
        End If
    End Function

End Class