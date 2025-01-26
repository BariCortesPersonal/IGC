
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports Entity
Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.Intrinsics
Imports System.Formats

Public Class dao_Transaction
    Inherits TypeConverter

    Dim objConex As New Conecction
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter


    Public Function listTrancheID(ByVal par As ceTransaction) As DataSet
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Isnull(MAX(Tranches_Executed) ,0)  +1  as Tranches_Executed " +
                                    "From [IG_Crypto].[dbo].[Transactions] " +
                                    "Where Active = 1" +
                                    "and [Transaction_Date] = Cast(Getdate() as Date) " +
                                    "and [Provider_ID] = @Provider_ID " +
                                    "and [Currency_ID] = @Currency_ID " +
                                    " Order by 1 asc", cn)
            da.SelectCommand.CommandType = CommandType.Text
            With da.SelectCommand.Parameters
                .Add("@Provider_ID", SqlDbType.Char).Value = par.ProviderID
                .Add("@Currency_ID", SqlDbType.Char).Value = par.CurrencyID
            End With
            da.Fill(ds, "Tranche")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Transaction.listTrancheID  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function



    Public Function CalculateTadrossTotalWeeklyNet(ByVal par As ceTransaction)
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Distinct " +
                                        "c.Currency_Name " +
                                       ",Case When c.Currency_Name = 'USD' Then 1 " +
                                             "When c.Currency_Name = 'USDT' Then 2 " +
                                             "When c.Currency_Name = 'BTC' Then 3 " +
                                        "End As cColumn  " +
                                       ",isnull(Sum(tl.Nets_Disbursements_Amount),0) as 'Total_Net_Disbursement_Amount'  " +
                                  "From [IG_Crypto].[dbo].[Transactions_Line] as tl " +
                                       "Inner Join [IG_Crypto].[dbo].[Currency] as c On c.Currency_ID = tl.Currency_ID " +
                                                                                        "And c.Active = 1 " +
                                       "Inner Join [IG_Crypto].[dbo].[Providers] as p On p.Provider_ID = tl.Provider_ID " +
                                                                                        "And p.Active = 1 " +
                                  "Where tl.Active = 1 " +
                                       "And tl.[Transaction_Date] = @TransactionDate  " +
                                       "And p.Full_Name = 'TADROSS' " +
                                  "Group by c.Currency_Name " +
                                  "Order by 2 ", cn)
            da.SelectCommand.CommandType = CommandType.Text
            With da.SelectCommand.Parameters
                .Add("@TransactionDate", SqlDbType.VarChar).Value = par.TransactionDate
            End With
            da.Fill(ds, "TotalTadrossGross")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Transaction.CalculateTadrossTotalWeeklyNet  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function





    Public Function CreateNewTransaction(ByVal par As ceTransaction)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Dim ms As New ceMessage
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.spInsertNewTransaction"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Transaction_ID", SqlDbType.VarChar).Value = par.TransactionID
            cmd.Parameters.Add("@Provider_ID", SqlDbType.VarChar).Value = par.ProviderID
            cmd.Parameters.Add("@Currency_ID", SqlDbType.VarChar).Value = par.CurrencyID
            cmd.Parameters.Add("@Transaction_Date", SqlDbType.VarChar).Value = par.TransactionDate
            cmd.Parameters.Add("@TransactioType", SqlDbType.VarChar).Value = par.TransactioType
            cmd.Parameters.Add("@Final_Swap_Tranche_Price", SqlDbType.VarChar).Value = par.Final_Swap_Tranche_Price
            cmd.Parameters.Add("@Number_of_BTC", SqlDbType.VarChar).Value = par.Number_of_BTC
            cmd.Parameters.Add("@Tranches_Executed", SqlDbType.VarChar).Value = par.TrancheID
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = par.User
            da.SelectCommand = cmd
            da.Fill(ds, "Transaction")
            Return Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Transaction.CretaeNewTransaction Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
            ms.Msg = "The Transaction has been Created Successfully "
            ms.Style = vbDefaultButton2
            ms.Title = "Transaction"
            MsgBox(ms.Msg, ms.Style, ms.Title)
        End Try
    End Function




    Public Function CreateNewTransaction_Line(ByVal par As ceTransaction)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Dim param As New SqlParameter()

        Try
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "dbo.spInsertNewTransactionLine"
            cmd.Connection = objConex.conect()
            param.ParameterName = "@Transactions"
            param.SqlDbType = SqlDbType.Structured
            param.Value = par.dtTransactionsLine
            param.TypeName = "Local_Type_TransactionTable"
            cmd.Parameters.Add(param)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Transaction.CretaeNewTransaction Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try

    End Function



    Public Function CalculateTotalWeeclyTransactions()
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Isnull(Count (Case When [Transaction_Date] = Cast(Getdate() as Date) Then Tranches_Executed End) ,0) Daily_Tranches_Executed " +
                                     ", Isnull(Count(Case When [Transaction_Date] Between  Cast(DATEADD(week, DateDiff(week, 0, Getdate() - 1), 0) As Date) " +
                                                 " and  DATEADD(DAY, 8 - DATEPART(WEEKDAY, Getdate()),  Getdate())    " +
                                                 " Then Tranches_Executed End) ,0) Weekly_Tranches_Executed  " +
                                    "From [IG_Crypto].[dbo].[Transactions]  " +
                                    "Where Active = 1 ", cn)
            da.SelectCommand.CommandType = CommandType.Text
            With da.SelectCommand.Parameters
            End With
            da.Fill(ds, "TotalWeekly")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Transaction.CalculateTotalWeeclyTransactions  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Public Function CalculatePendingsWeeclyTransactions()
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Isnull(Count (Case When tl.[Transaction_Status] = 'Pending' Then tl.Tranches_Executed End) ,0) Pending_Transaction  " +
                                     "  ,c.Pending_Commissions  " +
                              "  From [IG_Crypto].[dbo].[Transactions_Line] as tl  " +
                              "  Cross Join( Select Isnull(Count ( distinct [CommissionLine_ID]  ), 0)as Pending_Commissions  " +
                                             "From [IG_Crypto].[dbo].[Commissions_Line]  " +
                                            " Where Active = 1  " +
                                             "and [Status] = 'Pending'  " +
                                             "And [Transaction_Date]  Between  Cast(DATEADD(week, DATEDIFF(week, 0, Getdate() - 1), 0) as Date)  " +
                                                                                  "and  DATEADD(DAY, 8 - DATEPART(WEEKDAY, Getdate()),  Getdate())  " +
                                            " ) as c  " +
                               " Where tl.[Transaction_Date]  Between  Cast(DATEADD(week, DATEDIFF(week, 0, Getdate() - 1), 0) as Date)  " +
                                                                                  "And  DATEADD(DAY, 8 - DATEPART(WEEKDAY, Getdate()),  Getdate())  " +
                                "Group by c.Pending_Commissions		  " +
                                "Order by 1 asc", cn)
            da.SelectCommand.CommandType = CommandType.Text
            With da.SelectCommand.Parameters
            End With
            da.Fill(ds, "TotalPending")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Transaction.CalculatePendingsWeeclyTransactions  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function



    Public Function listPendingTransactions(ByVal par As ceTransaction) As DataSet
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("SELECT Distinct " +
                                           "tl.[TransactionLine_ID] " +
                                          ",tl.[Transaction_ID] " +
                                          ",p.Full_Name as 'ProviderName' " +
                                          ",c.Currency_Name as 'Currency' " +
                                          ",tl.Transaction_Date " +
                                          ",tl.Tranches_Executed " +
                                          ",tl.Gross_Disbursement_Amount " +
                                          ",tl.Nets_Disbursements_Amount " +
                                          ",tl.Transaction_Status " +
                                     " FROM [IG_Crypto].[dbo].[Transactions_Line] tl " +
                                           "Inner Join [IG_Crypto].[dbo].[Providers] As p On p.Provider_ID = tl.Provider_ID " +
                                           "Inner Join [IG_Crypto].[dbo].[Currency] as c On c.Currency_ID = tl.Currency_ID " +
                                     "Where tl.Active = 1 " +
                                            "and tl.Transaction_Status = 'Pending' " +
                                            "And  tl.[Provider_ID] = @Provider " +
                                            "And tl.[Currency_ID] = @Currency " +
                                            "And tl.Transaction_Date = @TransactionDate " +
                                    "Order by Transaction_Date " +
                                            ",Tranches_Executed", cn)
            da.SelectCommand.CommandType = CommandType.Text
            With da.SelectCommand.Parameters
                .Add("@Provider", SqlDbType.Char).Value = par.ProviderID
                .Add("@Currency", SqlDbType.Char).Value = par.CurrencyID
                .Add("@TransactionDate", SqlDbType.Char).Value = par.TransactionDate
            End With
            da.Fill(ds, "PendingTransactions")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Transaction.listPendingTransactions  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function




    Public Function ClosePendingTransactions(ByVal par As ceTransaction)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        '  Dim dt As New DataTable
        Dim ms As New ceMessage
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.spClosePendingTransactions"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Transactions", SqlDbType.Structured).Value = par.dtTransactionsLine
            cmd.Parameters.Add("@TransactionID", SqlDbType.VarChar).Value = par.TransactionID
            cmd.Parameters.Add("@ProviderID", SqlDbType.VarChar).Value = par.ProviderID
            cmd.Parameters.Add("@CurrencyID", SqlDbType.VarChar).Value = par.CurrencyID
            cmd.Parameters.Add("@TransactionDate", SqlDbType.VarChar).Value = par.TransactionDate
            cmd.Parameters.Add("@Gross_Disbursement_Amout", SqlDbType.VarChar).Value = par.Gross_Disbursement_Amou
            cmd.Parameters.Add("@GasFee", SqlDbType.VarChar).Value = par.GasFee
            cmd.Parameters.Add("@Net_Disbursement_Amount", SqlDbType.VarChar).Value = par.Net_Disbursement_Amount
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = par.User

            da.SelectCommand = cmd
            da.Fill(ds, "Transaction")
            Return Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Transaction.ClosePendingTransactions Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
            ms.Msg = "The Transaction has been Closed Successfully "
            ms.Style = vbDefaultButton2
            ms.Title = "Transaction"
            MsgBox(ms.Msg, ms.Style, ms.Title)
        End Try
        Exit Function

    End Function



    Public Function FilterTransactions(ByVal par As ceTransaction) As DataSet
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.spFilterTransaction"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Provider_ID", SqlDbType.VarChar).Value = par.ProviderID
            cmd.Parameters.Add("@Currency_ID", SqlDbType.VarChar).Value = par.CurrencyID
            cmd.Parameters.Add("@Transaction_Date", SqlDbType.VarChar).Value = par.TransactionDate
            da.SelectCommand = cmd
            da.Fill(ds, "Transaction")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Transaction.ClosePendingTransactions Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try
        Exit Function
    End Function



    Public Function TransactionDefaultValues(ByVal par As ceTransaction) As DataSet
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.spTransactionDefaultValues"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Provider_ID", SqlDbType.VarChar).Value = par.ProviderID
            cmd.Parameters.Add("@Currency_ID", SqlDbType.VarChar).Value = par.CurrencyID
            da.SelectCommand = cmd
            da.Fill(ds, "Transaction")
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

    Public Function TransactionLineDefaultValues(ByVal par As ceTransaction) As DataSet

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
            da.Fill(ds, "Transaction")
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
