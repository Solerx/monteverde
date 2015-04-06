Public Class AssignedProject

    Private idUser As User

    Private idProject As Project

    Private workTime As Integer

    Public Property apWorkTime() As Integer
        Get
            Return WorkTime
        End Get
        Set(ByVal value As Integer)
            workTime = value
        End Set
    End Property

    Public Property apProject() As Project
        Get
            Return idProject
        End Get
        Set(ByVal value As Project)
            idProject = value
        End Set
    End Property

    Public Property apUser() As User
        Get
            Return idUser
        End Get
        Set(ByVal value As User)
            idUser = value
        End Set
    End Property

End Class
