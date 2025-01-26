Public Class ceUser


    Private _UserID As String
    Private _Password As String
    Private _UserRoll As String

    Private _FirstName As String
    Private _LastName As String
    Private _Phone As String
    Private _Email As String



    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _LastName
        End Get
        Set(value As String)
            _LastName = value
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


    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property



    Public Property UserID As String
        Get
            Return _UserID
        End Get
        Set(value As String)
            _UserID = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

    Public Property UserRoll As String
        Get
            Return _UserRoll
        End Get
        Set(value As String)
            _UserRoll = value
        End Set
    End Property





End Class
