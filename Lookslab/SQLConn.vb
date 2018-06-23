Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class SQLConn
    Public SQLCon As New SqlConnection With {.ConnectionString = "Data Source = .\SQLEXPRESS; initial catalog = Lookslab; user id = sa; password = Pedro123"}
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet

    Public Function HasConnection()
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
    End Function

    Public Sub RunQuery(Query As String)
        Try
            SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLCon)
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)
            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
    End Sub
End Class
