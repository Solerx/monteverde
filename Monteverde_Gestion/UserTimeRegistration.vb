Public Class UserTimeRegistration

    Private user As User

    Private project As Project

    Private hours As Integer

    Private notes As String

    Private timestamp As DateTime

    Private workCategory As WorkCategory

    Public Property UtWorkTimeCategory() As WorkCategory
        Get
            Return workCategory
        End Get
        Set(ByVal value As WorkCategory)
            workCategory = value
        End Set
    End Property



    Public Property UtTimeStampDate() As DateTime
        Get
            Return timestamp
        End Get
        Set(ByVal value As DateTime)
            timestamp = value
        End Set
    End Property

    Public Property UtUserNotes() As String
        Get
            Return notes
        End Get
        Set(ByVal value As String)
            notes = value
        End Set
    End Property


    Public Property UtWorkTime() As Integer
        Get
            Return hours
        End Get
        Set(ByVal value As Integer)
            hours = value
        End Set
    End Property

    Public Property UtProject() As Project
        Get
            Return Project
        End Get
        Set(ByVal value As Project)
            project = value
        End Set
    End Property


    Public Property UtUser() As User
        Get
            Return user
        End Get
        Set(ByVal value As User)
            user = value
        End Set
    End Property


End Class
