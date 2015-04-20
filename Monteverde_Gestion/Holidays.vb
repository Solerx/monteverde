Public Class Holidays

    Private user As User

    Private holidaysRequested As Int16

    Private fromDate As DateTime

    Private toDate As DateTime

    Private requestStatus As String

    Private notes As String

    Public Property hNotes() As String
        Get
            Return notes
        End Get
        Set(ByVal value As String)
            notes = value
        End Set
    End Property


    Public Property hStatus() As String
        Get
            Return requestStatus
        End Get
        Set(ByVal value As String)
            requestStatus = value
        End Set
    End Property

    Public Property hFromDate() As DateTime
        Get
            Return toDate
        End Get
        Set(ByVal value As DateTime)
            toDate = value
        End Set
    End Property

    Public Property hToDate() As DateTime
        Get
            Return fromDate
        End Get
        Set(ByVal value As DateTime)
            fromDate = value
        End Set
    End Property


    Public Property hRequested() As Int16
        Get
            Return holidaysRequested
        End Get
        Set(ByVal value As Int16)
            holidaysRequested = value
        End Set
    End Property

    Public Property hUser() As User
        Get
            Return user
        End Get
        Set(ByVal value As User)
            user = value
        End Set
    End Property


End Class
