Public Class WorkCategory

    Private wcId As Integer

    Private wcName As String

    Private wcDescription As String

    Public Property Description() As String
        Get
            Return wcDescription
        End Get
        Set(ByVal value As String)
            wcDescription = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return wcName
        End Get
        Set(ByVal value As String)
            wcName = value
        End Set
    End Property

    Public Property Id() As Integer
        Get
            Return wcId
        End Get
        Set(ByVal value As Integer)
            wcId = value
        End Set
    End Property



End Class
