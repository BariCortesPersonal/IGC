
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports Entity
Imports System.Data



Public Class dao_Agent
    Inherits TypeConverter

    Dim objConex As New Conecction
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    Public Function listAgents() As DataSet
        Dim ds As New DataSet
        cn = objConex.conect()
        Try
            cn.Open()
            da = New SqlDataAdapter("Select Distinct  " +
                                         "Agent_ID " +
                                         ",Full_Name " +
                                    "From [dbo].[Agents]  " +
                                    "Where Active = 1" +
                                    " Order by 1 asc", cn)
            da.SelectCommand.CommandType = CommandType.Text

            da.Fill(ds, "Agent")
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.DefaultButton1, "The Function dao_Agent.listAgents  Failure")
            Return Nothing
        Finally
            cn.Close()
            ds.Dispose()
            da.Dispose()
        End Try
    End Function



End Class
