Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class LBEvents
    Dim SQL As New SQLConn
    Public Function TriggerCompra()
        Try
            SQL.RunQuery("EXEC dbo.PurchaseBeacon")
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
        Return SQL.SQLDS.Tables(0).Rows(0)(0)
    End Function
    Public Function TriggerNuevoUsuario()
        Try
            SQL.RunQuery("EXEC dbo.CustomerBeacon")
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
        Return SQL.SQLDS.Tables(0).Rows(0)(0)
    End Function
    Public Sub LogUsuario(ByVal UserID As Integer, ByVal Accion As String)
        Try
            SQL.RunQuery("EXEC dbo.LogActividad '" & UserID & "', '" & Accion & "'")
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
    End Sub
    Public Sub AgregarProducto(ByVal CodProd As String, ByVal NomProd As String, ByVal DescProd As String, ByVal CostProd As String, ByVal Stock As String, ByVal PrecioVenta As String, ByVal IdProv As String, ByVal TotalVenta As String)
        Try
            SQL.RunQuery("EXEC dbo.AgregarProducto '" & CodProd & "', '" & NomProd & "', '" & DescProd & "', '" & CostProd & "', '" & Stock & "', '" & PrecioVenta & "', '" & IdProv & "', '" & TotalVenta & "'")
            MsgBox("Datos Ingresados correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
    End Sub
    Public Sub AgregarProveedor(ByVal Proveedor As String, ByVal Rep As String, ByVal TelRep As String, ByVal Correo As String)
        Try
            SQL.RunQuery("EXEC dbo.AgregarProveedor '" & Proveedor & "', '" & Rep & "', '" & TelRep & "', '" & Correo & "'")
            MsgBox("Proveedor Registrado correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
    End Sub

    Public Function LlenaGridCalendario(ByVal Fecha As String)
        Try
            SQL.RunQuery("EXEC dbo.LlenaGridAppointments '" & Fecha & "'")
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
        Return SQL.SQLDS.Tables(0)

    End Function
    Public Sub InsertaCita(ByVal horainicio As String, ByVal horafin As String, ByVal usuario As String, ByVal cliente As String, ByVal fechacita As String, ByVal descripcion As String)
        Try
            SQL.RunQuery("EXEC dbo.AgregarCita '" & horainicio & "', '" & horafin & "', '" & usuario & "', '" & cliente & "', '" & fechacita & "', '" & descripcion & "'")
            MsgBox("Cita agendada correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
    End Sub

    Public Function BalizaIDServicio()
        Try
            SQL.RunQuery("EXEC dbo.ServiceBeacon")
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
        Return SQL.SQLDS.Tables(0).Rows(0)(0)
    End Function

    Public Sub AgregarServicios(ByVal IDServicio As String, ByVal Servicio As String, ByVal CostoServ As String, ByVal CatServ As String, ByVal DescServ As String)
        Try
            SQL.RunQuery("EXEC dbo.AgregarServicios '" & IDServicio & "', '" & Servicio & "', '" & CostoServ & "', '" & CatServ & "', '" & DescServ & "'")
            MsgBox("Servicio registrado correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQL.SQLCon.State = ConnectionState.Open Then
                SQL.SQLCon.Close()
            End If
        End Try
    End Sub

    Public Sub AgregarCompra(ByVal IdCompra As String, ByVal IdCliente As String, ByVal FechaCompra As String, ByVal Factura As String, ByVal IdUsuario As String, ByVal Membresia As String, ByVal MedioPago As String, ByVal PagoEspecial As String, ByVal Totalcompra As String, ByVal Cuenta As String)
        Try
            SQL.RunQuery("EXEC dbo.AgregarCompra '" & IdCompra & "', '" & IdCliente & "', '" & FechaCompra & "', '" & Factura & "', '" & IdUsuario & "', '" & Membresia & "', '" & MedioPago & "', '" & PagoEspecial & "', '" & Totalcompra & "', '" & Cuenta & "'")
        Catch ex As Exception

        End Try
    End Sub
End Class
