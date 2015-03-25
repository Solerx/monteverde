Public Class User

    Private userName As String

    Private email As String

    Private password As String

    Private worked_hours As Integer

    Private holidays As Int16

    Private registered_date As Date

    Private user_role As Int16

    Private user_id As Integer

    Private is_active As Boolean

    Public Property user_is_active() As Boolean
        Get
            Return is_active
        End Get
        Set(ByVal value As Boolean)
            is_active = value
        End Set
    End Property


    Public Property user_user_id() As Integer
        Get
            Return user_id
        End Get
        Set(ByVal value As Integer)
            user_id = value
        End Set
    End Property


    Public Property user_name() As String
        Get
            Return userName
        End Get
        Set(ByVal value As String)
            userName = value
        End Set
    End Property


    Public Property user_email() As String
        Get
            Return email
        End Get
        Set(ByVal value As String)
            email = value
        End Set
    End Property

    Public Property user_user_role() As Int16
        Get
            Return user_role
        End Get
        Set(ByVal value As Int16)
            user_role = value
        End Set
    End Property

    Public Property user_worked_hours() As Integer
        Get
            Return worked_hours
        End Get
        Set(ByVal value As Integer)
            worked_hours = value
        End Set
    End Property

    Public Property user_registered_date() As Date
        Get
            Return registered_date
        End Get
        Set(ByVal value As Date)
            registered_date = value
        End Set
    End Property

    Public Property user_holidays() As Int16
        Get
            Return holidays
        End Get
        Set(ByVal value As Int16)
            holidays = value
        End Set
    End Property


    Public Property user_password() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property


End Class
