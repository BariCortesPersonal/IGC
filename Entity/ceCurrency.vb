


Imports System.Data

Public Class ceCurrency


    Private _CurrencyID As String
    Private _CurrencyName As String
    Private _DefaultValue As String
    Private _User As String


    Public Property User As String
        Get
            Return _User
        End Get
        Set(value As String)
            _User = value
        End Set
    End Property

    Public Property CurrencyID As String
        Get
            Return _CurrencyID
        End Get
        Set(value As String)
            _CurrencyID = value
        End Set
    End Property

    Public Property CurrencyName As String
        Get
            Return _CurrencyName
        End Get
        Set(value As String)
            _CurrencyName = value
        End Set
    End Property

    Public Property DefaultValue As String
        Get
            Return _DefaultValue
        End Get
        Set(value As String)
            _DefaultValue = value
        End Set
    End Property


End Class
