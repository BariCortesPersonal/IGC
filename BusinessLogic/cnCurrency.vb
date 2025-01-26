
Imports System.Data
Imports DataAccess
Imports Entity

Public Class cnCurrency
    Dim objCurrency As New dao_Currency

    Public Function GetCurrency() As DataSet
        Return objCurrency.listCurrency()
    End Function

    Public Function GetFilterCurrency(ByVal par As ceAgent) As DataSet
        Return objCurrency.FilterCurrency(par)
    End Function


    'Public Function GetAgenty() As DataSet
    '    Return objCurrency.listCurrency()
    'End Function


    Public Function GetFilterCurrencyPendingTransaction(ByVal par As ceProvider) As DataSet
        Return objCurrency.FilterCurrencyPendingTransaction(par)
    End Function


    Public Function GetFilterCurrencyByName(ByVal par As ceCurrency) As DataSet
        Return objCurrency.FilterCurrencyByName(par)
    End Function


    Public Function GetCreateNewCurrency(ByVal par As ceCurrency) As DataSet
        Return objCurrency.CreateNewCurrency(par)
    End Function





End Class
