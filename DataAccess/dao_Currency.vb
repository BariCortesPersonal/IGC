
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports Entity
Imports System.Data
Imports System.Formats


Public Class dao_Currency

    Inherits TypeConverter

    Dim objConex As New Conecction
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter


    Public Function listCurrency() As DataSet
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Distinct  " +
                                         "Currency_ID " +
                                         ",Currency_Name " +
                                    "From [dbo].[Currency]  " +
                                    "Where Active = 1" +
                                    "Union " +
                                    "Select '','' " +
                                    "Order by 1  ", cn)
            da.SelectCommand.CommandType = CommandType.Text

            da.Fill(ds, "Currency")
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

    Public Function FilterCurrency(ByVal par As ceAgent) As DataSet
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Distinct  " +
                                         "c.Currency_ID " +
                                         ",c.Currency_Name " +
                                    "From [dbo].[Currency] as c " +
                                    "Inner Join [IG_Crypto].[dbo].[Commissions_Line] as cl  On cl.Currency_ID = c.Currency_ID " +
                                    "Where c.Active = 1 " +
                                    "and cl.Active =  1 " +
                                    "and cl.Status = 'Pending'   " +
                                    "and cl.Agent_ID =  @Agent_ID " +
                                    "Union " +
                                    "Select '','' " +
                                    "Order by 1  ", cn)
            da.SelectCommand.CommandType = CommandType.Text
            With da.SelectCommand.Parameters
                .Add("@Agent_ID", SqlDbType.VarChar).Value = par.Agent
            End With
            da.Fill(ds, "Currency")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Currency.FilterCurrency  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Public Function FilterCurrencyPendingTransaction(ByVal par As ceProvider) As DataSet
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Distinct  " +
                                         "c.Currency_ID " +
                                         ",c.Currency_Name " +
                                    "From [dbo].[Currency] as c " +
                                    "Inner Join [IG_Crypto].[dbo].[Transactions_Line] as tl  On tl.Currency_ID = c.Currency_ID " +
                                    "Where c.Active = 1 " +
                                    "and tl.Active =  1 " +
                                    "and tl.Transaction_Status = 'Pending'   " +
                                    "and tl.Provider_ID =  @Provider_ID " +
                                    "Union " +
                                    "Select '','' " +
                                    "Order by 1  ", cn)
            da.SelectCommand.CommandType = CommandType.Text
            With da.SelectCommand.Parameters
                .Add("@Provider_ID", SqlDbType.VarChar).Value = par.Provider
            End With
            da.Fill(ds, "Currency")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Currency.FilterCurrency  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function


    Public Function FilterCurrencyByName(ByVal par As ceCurrency) As DataSet
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("SELECT Distinct " +
                                    "[Currency_Name] " +
                                "From [IG_Crypto].[dbo].[Currency] " +
                                "Where Active = 1 " +
                                    "And [Currency_Name] Like IIF(Len(@Currency) > 0 ,('%'+@Currency+'%')  ,[Currency_Name])", cn)
            da.SelectCommand.CommandType = CommandType.Text
            With da.SelectCommand.Parameters
                .Add("@Currency", SqlDbType.VarChar).Value = par.CurrencyName
            End With
            da.Fill(ds, "Currency")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Currency.FilterCurrencyByName  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function


    Public Function CreateNewCurrency(ByVal par As ceCurrency)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Dim ms As New ceMessage
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.spInsertNewCurrency"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Currency", SqlDbType.VarChar).Value = par.CurrencyName
            da.SelectCommand = cmd
            da.Fill(ds, "Currency")
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Currency.CreateNewTransaction Failure")
            Return Nothing

        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
            ms.Msg = "The Crurrency has been Created Successfully "
            ms.Style = vbDefaultButton2
            ms.Title = "Currency"
            MsgBox(ms.Msg, ms.Style, ms.Title)
        End Try
    End Function








End Class
