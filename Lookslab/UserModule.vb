Imports System.ComponentModel

Public Class UserModule
    Dim sql As New SQLConn
    Dim userexists As Boolean = False
    Dim usercreation As Boolean = False
    Private Sub Username_LostFocus(sender As Object, e As EventArgs) Handles Username.LostFocus
        sql.RunQuery("SELECT Count (UserID) as Usercount " &
                     "FROM LBUsers " &
                   "WHERE username ='" & Username.Text & "' ")
        If sql.SQLDS.Tables(0).Rows(0).Item("Usercount") = 1 Then
            userexists = True
            MsgBox("El usuario ingresado ya existe, favor de intentar con otro nombre", MsgBoxStyle.Critical)
        Else
            userexists = False
        End If

    End Sub

    Private Sub UserModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql.RunQuery("SELECT UserID, Username Nombre_Usuario, SecretQuestion PreguntaSecreta FROM LBUsers")
        If sql.SQLDS.Tables.Count > 0 Then
            DGVUsers.DataSource = sql.SQLDS.Tables(0)
        End If
    End Sub

    Private Sub UserQuery_TextChanged(sender As Object, e As EventArgs) Handles UserQuery.TextChanged
        sql.RunQuery("SELECT UserID, Username Nombre_Usuario, SecretQuestion PreguntaSecreta FROM LBUsers " &
                     "WHERE username LIKE '%" & UserQuery.Text & "%'")
        If sql.SQLDS.Tables.Count > 0 Then
            DGVUsers.DataSource = sql.SQLDS.Tables(0)
        End If
    End Sub

    Private Sub AddNewUser_Click(sender As Object, e As EventArgs) Handles AddNewUser.Click
        sql.RunQuery("INSERT INTO LBUsers (username) " &
                     "VALUES ('')")
        sql.RunQuery("SELECT MAX(UserID) FROM LBUsers")
        If sql.SQLDS.Tables.Count > 0 Then
            DGVUserWorkspace.DataSource = sql.SQLDS.Tables(0)
            CurrentUserID.Text = DGVUserWorkspace.Rows(0).Cells(0).Value
        End If
        Dim obj As Control
        For Each obj In Me.UserData.Controls
            If TypeOf obj Is TextBox Then
                CType(obj, TextBox).Enabled = True
            End If
        Next
        usercreation = True
        AddNewUser.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles DisposeChanges.Click
        If CurrentUserID.Text <> "" Then
            sql.RunQuery("DELETE FROM LBUsers " &
                     "WHERE UserID = '" & CurrentUserID.Text & "'")
            CurrentUserID.Text = ""
            usercreation = False
            Dim obj As Control
            For Each obj In Me.UserData.Controls
                If TypeOf obj Is TextBox Then
                    obj.Text = ""
                    CType(obj, TextBox).Enabled = False
                End If
                AddNewUser.Enabled = True
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SaveChanges.Click
        If CurrentUserID.Text <> "" And userexists = False And Password.Text = ConfirmPassword.Text And SecretQuestion.Text <> "" And SecretAnswer.Text <> "" And NombreCompleto.Text <> "" Then
            CreateNewUser()
            usercreation = False
            AddNewUser.Enabled = True
        ElseIf CurrentUserID.Text = "" Then
            MsgBox("No está seleccionado ningún usuario para guardar, favor de crear nuevo o elegir", MsgBoxStyle.Information)
        ElseIf userexists = True Then
            MsgBox("El usuario que eligió ya existe y no se puede guardar", MsgBoxStyle.Critical)
        ElseIf Password.Text <> ConfirmPassword.Text Then
            MsgBox("Las contraseñas ingresadas no coinciden, favor de validarlas", MsgBoxStyle.Critical)
        ElseIf SecretQuestion.Text = "" Then
            MsgBox("El campo pregunta secreta no puede estar vacío", MsgBoxStyle.Information)
        ElseIf SecretAnswer.Text = "" Then
            MsgBox("La respuesta debe ser ingresada para usarse en el desbloqueo", MsgBoxStyle.Critical)
        ElseIf NombreCompleto.Text = "" Then
            MsgBox("Debe ingresar el nombre completo de la persona antes de continuar", MsgBoxStyle.Critical)
        End If
        Dim obj As Control
        For Each obj In Me.UserData.Controls
            If TypeOf obj Is TextBox Then
                obj.Text = ""
                CType(obj, TextBox).Enabled = False
            End If
            UserQuery.Text = "1"
            UserQuery.Text = ""
            CurrentUserID.Text = "1"
        Next
    End Sub

    Public Sub CreateNewUser()
        Try
            sql.RunQuery("UPDATE LBUsers " &
                     "SET username ='" & Username.Text & "', " &
                     "Password ='" & Password.Text & "', " &
                     "SecretQuestion = '" & SecretQuestion.Text & "', " &
                     "SecretAnswer ='" & SecretAnswer.Text & "', " &
                     "NombreCompleto ='" & NombreCompleto.Text & "' " &
                     "WHERE UserID ='" & CurrentUserID.Text & "'")
            MsgBox("Los datos fueron guardados exitosamente", MsgBoxStyle.Information, "Alta de usuario")
        Catch ex As Exception
            MsgBox(ex.Message)
            If sql.SQLCon.State = ConnectionState.Open Then
                sql.SQLCon.Close()
            End If
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ResetPassword.Click
        If IDToUnlock.Text <> "1256" Then
            sql.RunQuery("SELECT COUNT (UserID) as UserCount " &
                     "FROM LBUsers " &
                     "WHERE UserID = '" & IDToUnlock.Text & "'")
            If sql.SQLDS.Tables(0).Rows(0).Item("UserCount") = 1 Then
                sql.RunQuery("UPDATE LBUsers " &
                             "SET Password = '123456', " &
                             "NeedsChangePsw = 'YES' " &
                             "WHERE UserID ='" & IDToUnlock.Text & "'")
                MsgBox("Se cambió la contraseña por '123456', Al iniciar se pedirá cambio de contraseña", MsgBoxStyle.Information)
            Else
                MsgBox("No fue localizado el usuario, favor de reingresar", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("El usuario master no puede ser modificado ya que es el administrador de la base de datos", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub UserModule_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If usercreation = True Then
            If MsgBox("¿Estas seguro que deseas salir? Se perderán los datos no guardados", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Guardar Cambios") = MsgBoxResult.Yes Then
                DisposeChanges.PerformClick()
                Me.Dispose()
                AddNewUser.Enabled = True
            Else
                MsgBox("Favor de guardar los cambios", MsgBoxStyle.Information)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub EditarContraseñaDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarContraseñaDeUsuarioToolStripMenuItem.Click
        Dim IDToDelete As String = DGVUsers.CurrentRow.Cells(0).Value.ToString
        If IDToDelete <> "1256" Then
            ForgottedPassword.CurrentUserID = IDToDelete
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
        Else
            MsgBox("El usuario Master no se puede modificar ya que es el administrador de la base de datos", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUsuarioToolStripMenuItem.Click

        Dim UserToDelete As String = DGVUsers.CurrentRow.Cells(1).Value.ToString
        Dim IDToDelete As String = DGVUsers.CurrentRow.Cells(0).Value.ToString
        If IDToDelete <> "1256" Then
            If MsgBox("Se eliminará al usuario " + UserToDelete + " ¿Estás seguro que deseas continuar?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Eliminar registro") = MsgBoxResult.Yes Then
                sql.RunQuery("DELETE FROM LBUsers " &
                             "WHERE UserID = '" & IDToDelete & "'")
                MsgBox("Se eliminó el registro satisfactoriamente", MsgBoxStyle.Information)
                UserQuery.Text = "1"
                UserQuery.Text = ""
            End If
        Else
            MsgBox("El usuario Master no se puede eliminar", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub CambiarPreguntaSecretaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarPreguntaSecretaToolStripMenuItem.Click
        If DGVUsers.CurrentRow.Cells(1).Value.ToString <> "master" Then
            ChangeQuestion.CurrentUserID.Text = DGVUsers.CurrentRow.Cells(0).Value.ToString
            ChangeQuestion.Show()
        Else
            MsgBox("El usuario Master no se puede editar ya que es el administrador de la base de datos", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ExitUsers.Click
        Me.Close()
    End Sub
End Class