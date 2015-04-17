Public Class Holidays

    Private user As User

    Private holidaysRequested As Int16

    Private requestedDate As DateTime

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


    Public Property hDate() As DateTime
        Get
            Return requestedDate
        End Get
        Set(ByVal value As DateTime)
            requestedDate = value
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
