Public Class Role

    Private id_role As Integer

    Private role_name As String

    Private role_description As String

    Public Property role_role_description() As String
        Get
            Return role_description
        End Get
        Set(ByVal value As String)
            role_description = value
        End Set
    End Property

    Public Property role_role_name() As String
        Get
            Return role_name
        End Get
        Set(ByVal value As String)
            role_name = value
        End Set
    End Property


    Public Property role_id_role() As Integer
        Get
            Return id_role
        End Get
        Set(ByVal value As Integer)
            id_role = value
        End Set
    End Property


End Class
