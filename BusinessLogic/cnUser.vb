
Imports System.Data
Imports DataAccess
Imports Entity


Public Class cnUser

    Dim objProvider As New dao_User


    Public Function GetUserRoll(ByVal par As ceUser) As DataSet
        Return objProvider.FilterUserRoll(par)
    End Function

    Public Function GetRequestAccess(ByVal par As ceUser) As DataSet
        Return objProvider.RequestAccess(par)
    End Function

    Public Function GetRestartUserPassword(ByVal par As ceUser) As DataSet
        Return objProvider.RestartPassword(par)
    End Function


    Public Function GelistUsersd() As DataSet
        Return objProvider.listUsers()
    End Function


End Class
