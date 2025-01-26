
Imports System.Data
Imports DataAccess
Imports Entity

Public Class cnCommissions
    Dim objCommissions As New dao_Commissions


    Public Function GetCommissionDefaultValues(ByVal par As ceTransaction) As DataSet
        Return objCommissions.CommissionDefaultValues(par)
    End Function

    Public Function GetCommissions(ByVal par As ceCommissions) As DataSet
        Return objCommissions.listCommissions(par)
    End Function

    Public Function GetAddNewCommissions(ByVal par As ceCommissions) As DataSet
        Return objCommissions.CreateNewCommissionLine(par)
    End Function

    Public Function CalculateTransactionCommission(ByVal par As ceCommissions) As DataSet
        Return objCommissions.CalculateCommissions(par)
    End Function


    Public Function GetClosePendingCommissions(ByVal par As ceCommissions) As DataSet
        Return objCommissions.ClosePendingCommissions(par)
    End Function






End Class
