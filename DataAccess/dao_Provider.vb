

Imports System.Data.SqlClient
Imports System.ComponentModel
Imports Entity
Imports System.Data

Public Class dao_Provider

    Inherits TypeConverter

    Dim objConex As New Conecction
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter



    Public Function listProviders() As DataSet

        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Distinct  " +
                                         "Provider_ID " +
                                         ",Full_Name " +
                                    "From [dbo].[Providers]  " +
                                    "Where Active = 1" +
                                    "Union " +
                                    "Select '','' " +
                                    "Order by 1  ", cn)
            da.SelectCommand.CommandType = CommandType.Text

            da.Fill(ds, "Provider")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Provider.listProviders  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

    Public Function listProvidersPendingTransactions() As DataSet
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Distinct  " +
                                         "p.Provider_ID " +
                                         ",p.Full_Name " +
                                    "From [dbo].[Providers] as p " +
                                    "Inner Join [IG_Crypto].[dbo].[Transactions_Line] tl On p.Provider_ID = tl.Provider_ID " +
                                    "and  tl.Active = 1 and  tl.Transaction_Status = 'Pending' " +
                                    "Where p.Active = 1 " +
                                    "Union " +
                                    "Select '','' " +
                                    "Order by 1  ", cn)
            da.SelectCommand.CommandType = CommandType.Text

            da.Fill(ds, "Provider")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Provider.listProviders  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function


    Public Function listProviders(ByVal par As ceProvider) As DataSet
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.sp_List_Providers"
            cmd.CommandType = CommandType.StoredProcedure
            da.SelectCommand = cmd
            da.Fill(ds, "Providers")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Provider.listProviders Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try
        Exit Function
    End Function


    Public Function FilterProviders(ByVal par As ceProvider) As DataSet
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.sp_Filter_Providers"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = par.First_Name
            cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = par.Last_Name
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = par.Phone
            cmd.Parameters.Add("@Phone2", SqlDbType.VarChar).Value = par.Phone2
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = par.Email
            da.SelectCommand = cmd
            da.Fill(ds, "Providers")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Provider.listProviders Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try
        Exit Function

    End Function


    Public Function InsertNewProvider(ByVal par As ceProvider, ByVal parUser As ceUser)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Dim ms As New ceMessage
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.sp_Insert_Provider"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Provider_ID", SqlDbType.VarChar).Value = par.Provider_ID
            cmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = par.First_Name
            cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = par.Last_Name
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = par.Phone
            cmd.Parameters.Add("@Phone2", SqlDbType.VarChar).Value = par.Phone2
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = par.Email
            cmd.Parameters.Add("@Rate", SqlDbType.VarChar).Value = par.Rate
            '  cmd.Parameters.Add("@ContractStart", SqlDbType.VarChar).Value = par.ContractStart
            '  cmd.Parameters.Add("@ContractEnd", SqlDbType.VarChar).Value = par.ContractEnd
            cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = parUser.UserID
            da.SelectCommand = cmd
            da.Fill(ds, "Provider")
            Return Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Provider.InsertNewProvider Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
            ms.Msg = "The Provider has been Created or Updated Successfully "
            ms.Style = vbDefaultButton2
            ms.Title = "Crate Or Update Providers"
            MsgBox(ms.Msg, ms.Style, ms.Title)
        End Try
    End Function


End Class
