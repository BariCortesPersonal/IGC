
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports Entity
Imports System.Data

Public Class dao_ID
    Inherits TypeConverter

    Dim objConex As New Conecction
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter


    Public Function listID() As DataSet
        Dim ds As New DataSet

        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Cast(newid() as varchar (250))  as UsrID  ", cn)
            da.SelectCommand.CommandType = CommandType.Text

            da.Fill(ds, "ID")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Currency.listCurrency  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function



End Class
