

Imports System.Data.SqlClient
Imports System.ComponentModel
Imports Entity
Imports System.Data
Imports System.Runtime.Intrinsics

Public Class dao_Commissions


    Inherits TypeConverter

    Dim objConex As New Conecction
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter



    Public Function listCommissions(ByVal par As ceCommissions) As DataSet

        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Distinct  " +
                                    "a.Full_Name as Agent,cr.Currency_Name as Currency,c.[Gross_Disbursements_Amount]  as Commission_Gross_Disbursement ,c.Status " +
                                    ",t.Transaction_Date,t.Tranches_Executed ,t.Final_Swap_Tranche_Price,t.Number_of_BTC ,c.CommissionLine_ID " +
                                    "From [IG_Crypto].[dbo].[Commissions_Line] as c " +
                                    "Inner Join  [IG_Crypto].[dbo].[Transactions] as T On t.Transaction_ID = c.Transaction_ID  And t.Active = 1  " +
                                    "Inner Join [IG_Crypto].[dbo].[Currency] as cr On cr.Currency_ID = c.Currency_ID " +
                                    "Inner Join [IG_Crypto].[dbo].[Agents] as a On a.Agent_ID = c.Agent_ID " +
                                    "Where c.Active = 1" +
                                    "and c.[Agent_ID] = @Agent_ID " +
                                    "and c.[Currency_ID] = @Currency_ID " +
                                    "and  c.[Transaction_Date] =   @TransactionDate       " +
                                    "and c.Status = 'Pending' " +
                                    " Order by 1 asc", cn)
            da.SelectCommand.CommandType = CommandType.Text
            With da.SelectCommand.Parameters
                .Add("@Agent_ID", SqlDbType.Char).Value = par.AgentID
                .Add("@Currency_ID", SqlDbType.Char).Value = par.CurrencyID
                .Add("@TransactionDate", SqlDbType.Char).Value = par.TransactionDate
            End With
            da.Fill(ds, "Commissions")
            Return ds

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function daoCommissions.listCommissions  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
        Exit Function
    End Function





    Public Function CreateNewCommissionLine(ByVal par As ceCommissions)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Dim param As New SqlParameter()

        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "dbo.spInsertNewCommissionLine"
            cmd.Connection = objConex.conect()
            param.ParameterName = "@Commissions"
            param.SqlDbType = SqlDbType.Structured
            param.Value = par.dtCommissionLine
            param.TypeName = "Local_Type_CommissionTable"
            cmd.Parameters.Add(param)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function daoCommissions.CreateNewCommissionLine Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try
        Exit Function

    End Function


    Public Function CalculateCommissions(ByVal par As ceCommissions)

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.spCalculateCommissions"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@FinalSwapTranchePrice", SqlDbType.VarChar).Value = par.Final_Swap_Tranche_Price
            cmd.Parameters.Add("@NumberofBTC", SqlDbType.VarChar).Value = par.Number_of_BTC
            cmd.Parameters.Add("@TransactionDate", SqlDbType.VarChar).Value = par.TransactionDate
            cmd.Parameters.Add("@BLUE_TRIANGLES_LTD", SqlDbType.VarChar).Value = par.BLUE_TRIANGLES_LTD
            cmd.Parameters.Add("@JOHN_LUMLEY", SqlDbType.VarChar).Value = par.JOHN_LUMLEY
            cmd.Parameters.Add("@RYAN_FENDLY", SqlDbType.VarChar).Value = par.RYAN_FENDLY
            cmd.Parameters.Add("@ANTHONY_CRISCI", SqlDbType.VarChar).Value = par.ANTHONY_CRISCI
            da.SelectCommand = cmd
            da.Fill(ds, "Commissions")
            Return (ds)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function daoCommissions.CalculateCommissions Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try
        Exit Function

    End Function


    Public Function ClosePendingCommissions(ByVal par As ceCommissions)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim ms As New ceMessage

        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.spClosePendingCommissions"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Commissions", SqlDbType.Structured).Value = par.dtCommissionLine
            cmd.Parameters.Add("@CommissionID", SqlDbType.VarChar).Value = par.CommissionID
            cmd.Parameters.Add("@AgentID", SqlDbType.VarChar).Value = par.AgentID
            cmd.Parameters.Add("@CurrencyID", SqlDbType.VarChar).Value = par.CurrencyID
            cmd.Parameters.Add("@TransactionDate", SqlDbType.VarChar).Value = par.TransactionDate
            cmd.Parameters.Add("@Gross_Disbursement_Amout", SqlDbType.VarChar).Value = par.Gross_Disbursement_Amout
            cmd.Parameters.Add("@GasFee", SqlDbType.VarChar).Value = par.GasFee
            cmd.Parameters.Add("@Net_Disbursement_Amount", SqlDbType.VarChar).Value = par.Net_Disbursement_Amount
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = par.User
            da.SelectCommand = cmd
            da.Fill(ds, "Commissions")
            Return Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function daoCommissions.ClosePendingCommissions Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
            ms.Msg = "The commission has been closed successfully "
            ms.Style = vbDefaultButton2
            ms.Title = "Commission"
            MsgBox(ms.Msg, ms.Style, ms.Title)
        End Try
        Exit Function

    End Function


    Public Function CommissionDefaultValues(ByVal par As ceTransaction) As DataSet

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.spTransactionLineDefaultValues"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Provider_ID", SqlDbType.VarChar).Value = par.ProviderID
            cmd.Parameters.Add("@Currency_ID", SqlDbType.VarChar).Value = par.CurrencyID
            cmd.Parameters.Add("@Price", SqlDbType.VarChar).Value = par.Final_Swap_Tranche_Price
            cmd.Parameters.Add("@TotalCurrency", SqlDbType.VarChar).Value = par.Number_of_BTC
            cmd.Parameters.Add("@GasFee", SqlDbType.VarChar).Value = par.GasFee
            da.SelectCommand = cmd
            da.Fill(ds, "Commission")
            Return ds
        Catch ex As Exception
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try
        Exit Function
    End Function



End Class
