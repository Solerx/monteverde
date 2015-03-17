Public Class User

    Private userName As String

    Private email As String

    Private password As String

    Private vacation_days As Int16

    Private last_login As Date

    Private user_type As Int16

    Private worked_hours As Integer

    Private proyects_assigned As Proyect

    Private user_id As Integer

    Public Property user_UserId() As Integer
        Get
            Return user_id
        End Get
        Set(ByVal value As Integer)
            user_id = value
        End Set
    End Property


    Public Property user_Name() As String
        Get
            Return userName
        End Get
        Set(ByVal value As String)
            userName = value
        End Set
    End Property


    Public Property user_Email() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property

    Public Property user_UserType() As Int16
        Get
            Return user_type
        End Get
        Set(ByVal value As Int16)
            user_type = value
        End Set
    End Property

    Public Property user_ProyectsAssigned() As Proyect
        Get
            Return proyects_assigned
        End Get
        Set(ByVal value As Proyect)
            proyects_assigned = value
        End Set
    End Property

    Public Property user_WorkedHours() As String
        Get
            Return worked_hours
        End Get
        Set(ByVal value As String)
            worked_hours = value
        End Set
    End Property

    Public Property user_LastLogin() As Date
        Get
            Return last_login
        End Get
        Set(ByVal value As Date)
            last_login = value
        End Set
    End Property

    Public Property user_VacationDays() As Int16
        Get
            Return vacation_days
        End Get
        Set(ByVal value As Int16)
            vacation_days = value
        End Set
    End Property


    Public Property user_Password() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property



End Class
