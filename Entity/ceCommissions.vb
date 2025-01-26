


Imports System.Data

Public Class ceCommissions

    Private _AgentID As String
    Private _TransactionID As String
    Private _TrancheID As String
    ' Private _TransactioDate As String
    Private _CurrencyID As String
    Private _ProviderID As String
    Private _CommissionID As String
    Private _CommissionLineID As String

    Private _GasFee As String
    Private _Gross_Disbursement_Amout As String
    Private _Net_Disbursement_Amount As String

    Private _BLUE_TRIANGLES_LTD As String
    Private _JOHN_LUMLEY As String
    Private _RYAN_FENDLY As String
    Private _ANTHONY_CRISCI As String

    Private _Final_Swap_Tranche_Price As String
    Private _Number_of_BTC As String
    Private _TransactionDate As String
    Private _User As String

    Private _dtCommissionLine As Object


    Public Property User As String
        Get
            Return _User
        End Get
        Set(value As String)
            _User = value
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

    Public Property BLUE_TRIANGLES_LTD As Object
        Get
            Return _BLUE_TRIANGLES_LTD
        End Get
        Set(value As Object)
            _BLUE_TRIANGLES_LTD = value
        End Set
    End Property

    Public Property JOHN_LUMLEY As Object
        Get
            Return _JOHN_LUMLEY
        End Get
        Set(value As Object)
            _JOHN_LUMLEY = value
        End Set
    End Property

    Public Property RYAN_FENDLY As Object
        Get
            Return _RYAN_FENDLY
        End Get
        Set(value As Object)
            _RYAN_FENDLY = value
        End Set
    End Property

    Public Property ANTHONY_CRISCI As Object
        Get
            Return _ANTHONY_CRISCI
        End Get
        Set(value As Object)
            _ANTHONY_CRISCI = value
        End Set
    End Property
    Public Property dtCommissionLine As Object
        Get
            Return _dtCommissionLine
        End Get
        Set(value As Object)
            _dtCommissionLine = value
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

    Public Property Gross_Disbursement_Amout As String
        Get
            Return _Gross_Disbursement_Amout
        End Get
        Set(value As String)
            _Gross_Disbursement_Amout = value
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


    Public Property AgentID As String
        Get
            Return _AgentID
        End Get
        Set(value As String)
            _AgentID = value
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

    'Public Property TransactioDate As String
    '    Get
    '        Return _TransactioDate
    '    End Get
    '    Set(value As String)
    '        _TransactioDate = value
    '    End Set
    'End Property


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


    Public Property CommissionID As String
        Get
            Return _CommissionID
        End Get
        Set(value As String)
            _CommissionID = value
        End Set
    End Property

    Public Property CommissionLineID As String
        Get
            Return _CommissionLineID
        End Get
        Set(value As String)
            _CommissionLineID = value
        End Set
    End Property





End Class
