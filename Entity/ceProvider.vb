



Public Class ceProvider


    Private _Provider As String

    Private _Provider_ID As String
    Private _First_Name As String
    Private _Last_Name As String
    Private _Phone As String
    Private _Phone2 As String
    Private _Rate As String
    Private _Email As String
    Private _ContractStart As String
    Private _ContractEnd As String


    Public Property ContractEnd As String
        Get
            Return _ContractEnd
        End Get
        Set(value As String)
            _ContractEnd = value
        End Set
    End Property

    Public Property ContractStart As String
        Get
            Return _ContractStart
        End Get
        Set(value As String)
            _ContractStart = value
        End Set
    End Property


    Public Property Phone2 As String
        Get
            Return _Phone2
        End Get
        Set(value As String)
            _Phone2 = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Rate As String
        Get
            Return _Rate
        End Get
        Set(value As String)
            _Rate = value
        End Set
    End Property


    Public Property Phone As String
        Get
            Return _Phone
        End Get
        Set(value As String)
            _Phone = value
        End Set
    End Property


    Public Property Last_Name As String
        Get
            Return _Last_Name
        End Get
        Set(value As String)
            _Last_Name = value
        End Set
    End Property


    Public Property First_Name As String
        Get
            Return _First_Name
        End Get
        Set(value As String)
            _First_Name = value
        End Set
    End Property


    Public Property Provider_ID As String
        Get
            Return _Provider_ID
        End Get
        Set(value As String)
            _Provider_ID = value
        End Set
    End Property


    Public Property Provider As String
        Get
            Return _Provider
        End Get
        Set(value As String)
            _Provider = value
        End Set
    End Property

End Class
