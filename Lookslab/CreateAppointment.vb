Public Class CreateAppointment
    Dim SQL As New SQLConn
    Dim LBEv As New LBEvents
    Public AgendaCliente As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CreateAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL.RunQuery("SELECT CustID, CustName FROM LBCustomers")
        If SQL.SQLDS.Tables.Count > 0 Then
            CBCustomers.DataSource = SQL.SQLDS.Tables(0)
            CBCustomers.DisplayMember = "Custname"
            CBCustomers.ValueMember = "CustID"
            If AgendaCliente <> "" And IsNumeric(AgendaCliente) Then
                Dim SelVal As Integer = Convert.ToInt32(AgendaCliente)
                CBCustomers.SelectedValue = SelVal
            Else
                CBCustomers.SelectedValue = -1
            End If
        End If
        SQL.RunQuery("SELECT IDHorario, Horario FROM CatalogoHorarios")
        If SQL.SQLDS.Tables.Count > 0 Then
            HoraInicio.DataSource = SQL.SQLDS.Tables(0)
            HoraInicio.DisplayMember = "Horario"
            HoraInicio.ValueMember = "IDHorario"
            HoraInicio.SelectedIndex = -1
        End If
        SQL.RunQuery("SELECT IDHorario, Horario FROM CatalogoHorarios")
        If SQL.SQLDS.Tables.Count > 0 Then
            HoraFin.DataSource = SQL.SQLDS.Tables(0)
            HoraFin.DisplayMember = "Horario"
            HoraFin.ValueMember = "IDHorario"
            HoraFin.SelectedIndex = -1
        End If
        SQL.RunQuery("SELECT UserID, Username, NombreCompleto FROM LBUsers")
        If SQL.SQLDS.Tables.Count > 0 Then
            UsuarioAsignado.DataSource = SQL.SQLDS.Tables(0)
            UsuarioAsignado.DisplayMember = "NombreCompleto"
            UsuarioAsignado.ValueMember = "UserID"
            UsuarioAsignado.SelectedIndex = -1
        End If
        DateAppointment.MinDate = Date.Today
    End Sub

    Private Sub CBCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCustomers.SelectedIndexChanged
        Dim IDTemp As String
        Dim value As Object = CBCustomers.SelectedValue
        If value IsNot Nothing Then
            IDTemp = Convert.ToString(value)
            CustomerID.Text = IDTemp
        End If
    End Sub

    Public Function ValidarHorarios()
        Dim HF As Int32 = HoraFin.SelectedValue
        If HoraFin.SelectedValue < HoraInicio.SelectedValue Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function NoEmpalmeCitas()
        SQL.RunQuery("EXEC dbo.MatchDates '" & UsuarioAsignado.SelectedValue & "', '" & HoraInicio.SelectedValue & "', '" & DateAppointment.Value.ToString("yyyy-MM-dd") & "'")
        If SQL.SQLDS.Tables(0).Rows(0).Item("MatchDate") = 0 Then
            Return True
        Else
            MsgBox("El horario asignado se encuentra ya dado de alta para otro usuario, favor de ingresar un horario nuevo", MsgBoxStyle.Critical)
            Return False
        End If
    End Function

    Private Sub GuardarCita_Click(sender As Object, e As EventArgs) Handles GuardarCita.Click
        If ValidarHorarios() = False Then
            MsgBox("El horario fin debe ser igual o mayor que el horario inicio para poder guardar la cita, favor de validar", MsgBoxStyle.Critical)
        ElseIf ValidarHorarios() = True Then
            If IsNumeric(CustomerID.Text) Then
                If DescripcionServ.Text <> "" And HoraFin.Text <> "" And HoraInicio.Text <> "" And UsuarioAsignado.Text <> "" Then
                    If NoEmpalmeCitas() = True Then
                        LBEv.InsertaCita(HoraInicio.SelectedValue, HoraFin.SelectedValue, UsuarioAsignado.SelectedValue, CustomerID.Text, DateAppointment.Value.ToString("yyyy-MM-dd"), DescripcionServ.Text)
                        CBCustomers.SelectedIndex = -1
                        HoraInicio.SelectedIndex = -1
                        HoraFin.SelectedIndex = -1
                        UsuarioAsignado.SelectedIndex = -1
                        CustomerID.Clear()
                        DescripcionServ.Clear()
                    End If
                End If
                Else
                    MsgBox("No ha seleccionado un usuario válido", MsgBoxStyle.Critical)
            End If

        End If
    End Sub


End Class