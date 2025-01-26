

Imports System.Data
Imports DataAccess
Imports Entity

Public Class cnTransaction
    Dim objTrasaction As New dao_Transaction



    Public Function GetTransactionLineDefaultValues(ByVal par As ceTransaction) As DataSet
        Return objTrasaction.TransactionLineDefaultValues(par)
    End Function

    Public Function GetTransactionDefaultValues(ByVal par As ceTransaction) As DataSet
        Return objTrasaction.TransactionDefaultValues(par)
    End Function


    Public Function GetTrancheID(ByVal par As ceTransaction) As DataSet
        Return objTrasaction.listTrancheID(par)
    End Function

    Public Function NewTransaction(ByVal par As ceTransaction) As DataSet
        Return objTrasaction.CreateNewTransaction(par)
    End Function

    Public Function NewTransactionLine(ByVal par As ceTransaction) As DataSet
        Return objTrasaction.CreateNewTransaction_Line(par)
    End Function

    Public Function GetTadrossWeeklyNet(ByVal par As ceTransaction) As DataSet
        Return objTrasaction.CalculateTadrossTotalWeeklyNet(par)
    End Function


    Public Function GetTotalDailyTransactions() As DataSet
        Return objTrasaction.CalculateTotalWeeclyTransactions()
    End Function

    Public Function GetPendingsDailyTransactions() As DataSet
        Return objTrasaction.CalculatePendingsWeeclyTransactions()
    End Function

    Public Function GetListPendingsTransactions(ByVal par As ceTransaction) As DataSet
        Return objTrasaction.listPendingTransactions(par)
    End Function

    Public Function GetClosePendingsTransactions(ByVal par As ceTransaction) As DataSet
        Return objTrasaction.ClosePendingTransactions(par)
    End Function

    Public Function GetFilterTransactions(ByVal par As ceTransaction) As DataSet
        Return objTrasaction.FilterTransactions(par)
    End Function

End Class
