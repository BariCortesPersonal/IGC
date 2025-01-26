


Public Class ceMessage

    Private _Msg As String
    Private _Style As String
    Private _Title As String
    Private _Help As String
    Private _Ctxt As String



    Public Property Msg As Object
        Get
            Return _Msg
        End Get
        Set(value As Object)
            _Msg = value
        End Set
    End Property

    Public Property Style As Object
        Get
            Return _Style
        End Get
        Set(value As Object)
            _Style = value
        End Set
    End Property

    Public Property Title As Object
        Get
            Return _Title
        End Get
        Set(value As Object)
            _Title = value
        End Set
    End Property

    Public Property Help As Object
        Get
            Return _Help
        End Get
        Set(value As Object)
            _Help = value
        End Set
    End Property

    Public Property Ctxt As Object
        Get
            Return _Ctxt
        End Get
        Set(value As Object)
            _Ctxt = value
        End Set
    End Property



End Class
