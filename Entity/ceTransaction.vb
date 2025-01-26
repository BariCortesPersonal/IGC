


Public Class ceTransaction

    Private _TransactionID As String
    Private _TrancheID As String
    Private _TransactionDate As String
    Private _CurrencyID As String
    Private _ProviderID As String
    Private _Final_Swap_Tranche_Price As String
    Private _Number_of_BTC As String
    Private _TransactioType As String


    Private _GasFee As String
    Private _Gross_Disbursement_Amou As String
    Private _Net_Disbursement_Amount As String
    Private _Transaction_Status As String
    Private _Income As String
    Private _DailyDisbursment As String
    Private _User As String

    Private _dtTransactionsLine As Object



    Public Property dtTransactionsLine As Object
        Get
            Return _dtTransactionsLine
        End Get
        Set(value As Object)
            _dtTransactionsLine = value
        End Set
    End Property

    Public Property Income As String
        Get
            Return _Income
        End Get
        Set(value As String)
            _Income = value
        End Set
    End Property

    Public Property DailyDisbursment As String
        Get
            Return _DailyDisbursment
        End Get
        Set(value As String)
            _DailyDisbursment = value
        End Set
    End Property


    Public Property Transaction_Status As String
        Get
            Return _Transaction_Status
        End Get
        Set(value As String)
            _Transaction_Status = value
        End Set
    End Property

    Public Property TransactioType As String
        Get
            Return _TransactioType
        End Get
        Set(value As String)
            _TransactioType = value
        End Set
    End Property


    Public Property User As String
        Get
            Return _User
        End Get
        Set(value As String)
            _User = value
        End Set
    End Property


    Public Property Gross_Disbursement_Amou As String
        Get
            Return _Gross_Disbursement_Amou
        End Get
        Set(value As String)
            _Gross_Disbursement_Amou = value
        End Set
    End Property

    Public Property Net_Disbursement_Amount As String
        Get
            Return _Net_Disbursement_Amount
        End Get
        Set(value As String)
            _Net_Disbursement_Amount = value
        End Set
    End Property

    Public Property GasFee As String
        Get
            Return _GasFee
        End Get
        Set(value As String)
            _GasFee = value
        End Set
    End Property

    Public Property Final_Swap_Tranche_Price As String
        Get
            Return _Final_Swap_Tranche_Price
        End Get
        Set(value As String)
            _Final_Swap_Tranche_Price = value
        End Set
    End Property

    Public Property Number_of_BTC As String
        Get
            Return _Number_of_BTC
        End Get
        Set(value As String)
            _Number_of_BTC = value
        End Set
    End Property


    Public Property TransactionID As String
        Get
            Return _TransactionID
        End Get
        Set(value As String)
            _TransactionID = value
        End Set
    End Property

    Public Property TrancheID As String
        Get
            Return _TrancheID
        End Get
        Set(value As String)
            _TrancheID = value
        End Set
    End Property

    Public Property TransactionDate As String
        Get
            Return _TransactionDate
        End Get
        Set(value As String)
            _TransactionDate = value
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


    Public Property ProviderID As String
        Get
            Return _ProviderID
        End Get
        Set(value As String)
            _ProviderID = value
        End Set
    End Property

End Class
