Public Class UserTimeRegistration

    Private user As Integer

    Private project As Integer

    Private hours As Integer

    Private notes As String

    Private timestamp As DateTime

    Public Property TimeStampDate() As DateTime
        Get
            Return timestamp
        End Get
        Set(ByVal value As DateTime)
            timestamp = value
        End Set
    End Property

    Public Property UserNotes() As String
        Get
            Return notes
        End Get
        Set(ByVal value As String)
            notes = value
        End Set
    End Property


    Public Property WorkTime() As Integer
        Get
            Return hours
        End Get
        Set(ByVal value As Integer)
            hours = value
        End Set
    End Property

    Public Property IdProject() As Integer
        Get
            Return project
        End Get
        Set(ByVal value As Integer)
            project = value
        End Set
    End Property


    Public Property IdUser() As Integer
        Get
            Return user
        End Get
        Set(ByVal value As Integer)
            user = value
        End Set
    End Property


End Class
