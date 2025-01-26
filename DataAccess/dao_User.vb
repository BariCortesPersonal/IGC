
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports Entity
Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.Intrinsics
Imports System.Formats

Public Class dao_User
    Inherits TypeConverter

    Dim objConex As New Conecction
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter



    Public Function FilterUserRoll(ByVal par As ceUser) As DataSet
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand

        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.spFilterUserRoll"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = par.UserID
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = par.Password
            da.SelectCommand = cmd
            da.Fill(ds, "User")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_User.FilterUserRoll Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try
        Exit Function
    End Function




    Public Function RequestAccess(ByVal par As ceUser) As DataSet
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.sp_Insert_NewUser"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = par.FirstName
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = par.LastName
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = par.Phone
            cmd.Parameters.Add("Email", SqlDbType.VarChar).Value = par.Email
            cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = par.UserID
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = par.Password
            da.SelectCommand = cmd
            da.Fill(ds, "User")
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_User.RequestAccess Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try
        Exit Function
    End Function

    Public Function RestartPassword(ByVal par As ceUser) As DataSet
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cmd As New SqlCommand
        Try
            cmd.Connection = objConex.conect()
            cmd.CommandText = "dbo.sp_Restart_Password"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("Email", SqlDbType.VarChar).Value = par.Email
            cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = par.UserID
            cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = par.Password
            da.SelectCommand = cmd
            da.Fill(ds, "User")
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_User.RestartPassword Failure")
            Return Nothing
        Finally
            ds.Dispose()
            da.Dispose()
            cmd.Dispose()
        End Try
        Exit Function
    End Function


    Public Function listUsers() As DataSet
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("SELECT Distinct [Usert_ID] " +
                                     " , [Fist_Name]" +
                                     " ,[Last_Name]" +
                                     " ,[Full_Name]" +
                                     " ,[Phone]" +
                                     " ,[Secondary_Phone]" +
                                     " ,[Email]" +
                                     " ,[Roll]" +
                                     " ,[UserName]" +
                                     " ,[Password]" +
                                     " ,Cast([StartDate] as Date) as 'StartDate'" +
                                     " ,Cast([EndDate] as Date) as 'EndDate'" +
                                     " ,[Active]" +
                                    "From [IG_Crypto].[dbo].[Users] " +
                                    " Order by 2 asc", cn)
            da.SelectCommand.CommandType = CommandType.Text
            With da.SelectCommand.Parameters
            End With
            da.Fill(ds, "User")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_User.listUsers  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function

End Class
