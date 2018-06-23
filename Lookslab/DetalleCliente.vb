Public Class DetalleCliente
    Dim SQL As New SQLConn
    Private Sub DetalleCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IDCliente.Text <> "" Then
            SQL.RunQuery("select custID,
                        Custname, 
                        custphone, 
                        custBirthDay, 
                        CustEmail, 
                        havecredit, 
                        (case when AmountDue Is Null then 0 else AmountDue end) as Adeudo, 
                        (case when isRisky is null then 'SIN INFORMACION' else IsRisky end) as IsRisky, 
                        CustType, 
                        CustSocialName, 
                        RFC, 
                        CustAddress, 
                        IsVIP, 
                        MembershipID
                        from LBCustomers WHERE custID='" & IDCliente.Text & "'")
            If SQL.SQLDS.Tables.Count > 0 Then
                InfoClienteDGV.DataSource = SQL.SQLDS.Tables(0)
                Dim row As DataGridViewRow
                row = InfoClienteDGV.Rows(0)
                nombrecliente.Text = row.Cells(1).Value
                telcliente.Text = row.Cells(2).Value
                cumpleañoscliente.Text = row.Cells(3).Value
                correocliente.Text = row.Cells(4).Value
                Credito.Text = row.Cells(5).Value
                adeudocredito.Text = row.Cells(6).Value
                tipocliente.Text = row.Cells(8).Value
                PersonaFiscal.Text = row.Cells(9).Value
                RFC.Text = row.Cells(10).Value
                DomicilioFiscal.Text = row.Cells(11).Value
                membresiaID.Text = row.Cells(13).Value

            End If
        End If
    End Sub

    Private Sub SalirModulo_Click(sender As Object, e As EventArgs) Handles SalirModulo.Click
        Me.Close()
    End Sub
End Class