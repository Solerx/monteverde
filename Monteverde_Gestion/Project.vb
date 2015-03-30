Public Class Project


    Private idProject As Integer

    Private projectName As String

    Private enterpriseName As String

    Private hours As Integer

    Private status As Boolean

    Private contactInfo As String

    Public Property Project_ContactInfo() As String
        Get
            Return contactInfo
        End Get
        Set(ByVal value As String)
            contactInfo = value
        End Set
    End Property


    Public Property Project_Status() As Boolean
        Get
            Return status
        End Get
        Set(ByVal value As Boolean)
            status = value
        End Set
    End Property


    Public Property Project_Hours() As Integer
        Get
            Return hours
        End Get
        Set(ByVal value As Integer)
            hours = value
        End Set
    End Property


    Public Property Project_Enterprise() As String
        Get
            Return enterpriseName
        End Get
        Set(ByVal value As String)
            enterpriseName = value
        End Set
    End Property


    Public Property Project_Name() As String
        Get
            Return projectName
        End Get
        Set(ByVal value As String)
            projectName = value
        End Set
    End Property



    Public Property Project_Id() As Integer
        Get
            Return idProject
        End Get
        Set(ByVal value As Integer)
            idProject = value
        End Set
    End Property

End Class
