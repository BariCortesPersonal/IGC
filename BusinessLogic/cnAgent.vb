
Imports System.Data
Imports DataAccess
Imports Entity

Public Class cnAgent


    Dim objAgent As New dao_Agent
    Public Function GetAgent() As DataSet
        Return objAgent.listAgents()
    End Function


End Class
