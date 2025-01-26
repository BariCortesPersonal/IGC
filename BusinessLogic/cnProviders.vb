

Imports System.Data
Imports DataAccess
Imports Entity

Public Class cnProviders
    Dim objProvider As New dao_Provider
    Public Function GetProvider() As DataSet
        Return objProvider.listProviders()
    End Function


    Public Function GetlistProvidersPendingTransactions() As DataSet
        Return objProvider.listProvidersPendingTransactions()
    End Function

    Public Function GetlistProviders(ByVal par As ceProvider) As DataSet
        Return objProvider.listProviders(par)
    End Function

    Public Function GetFilterProviders(ByVal par As ceProvider) As DataSet
        Return objProvider.FilterProviders(par)
    End Function

    Public Function GetAddProviders(ByVal par As ceProvider, ByVal parUser As ceUser) As DataSet
        Return objProvider.InsertNewProvider(par, parUser)
    End Function

End Class
