Imports System.Data.SqlClient

Public Class AssignedProjectData

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim userDataInstance As New Userdata

    Dim projectDataInstance As New Projectdata

    Dim dataTableUsers As New DataTable

    Dim dataTableProjects As New DataTable

    Dim dataTableAssignedProject As New DataTable

    Dim dataTableAssignedUser As New DataTable

    Public Sub Insert(ByVal userProject As AssignedProject)

        connection.Close()

        Dim cmdInsert As New SqlCommand

        cmdInsert = New SqlCommand("insert into User_Project(id_user,id_project,work_time)" & _
                                   "values(@id_user,@id_project,@work_time)", connection)
        connection.Open()

        With cmdInsert

            .Parameters.AddWithValue("@id_user", userProject.apUser.user_user_id)
            .Parameters.AddWithValue("@id_project", userProject.apProject.Project_Id)
            .Parameters.AddWithValue("@work_time", userProject.apWorkTime)

        End With

        cmdInsert.ExecuteNonQuery()
        connection.Close()

    End Sub

    Public Sub Delete(ByVal idUser As Integer, ByVal idProject As Integer)

        connection.Close()

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("Delete from User_Project " & _
        " WHERE id_user = " & idUser & " AND id_project = " & idProject, connection)

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        connection.Close()

    End Sub
    Public Function CreateDataTableAssignedUser() As DataTable

        'Create Users table
        dataTableAssignedUser = New DataTable
        dataTableAssignedUser.Columns.Add("ID")
        dataTableAssignedUser.Columns.Add("User Name")
        dataTableAssignedUser.Columns.Add("Hours Assigned")

        CreateDataTableAssignedUser = dataTableAssignedUser

    End Function

    Public Function ListOfAssignedUser(ByVal idProject As Integer) As List(Of AssignedProject)

        connection.Close()

        Dim cmdSelectUser As New SqlCommand("SELECT id_user,work_time FROM User_Project WHERE id_project = " & idProject, connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()
        Dim userList As New List(Of AssignedProject)
        Dim assignedUser As New AssignedProject

        Do While reader.HasRows

            Do While reader.Read()

                assignedUser = New AssignedProject
                assignedUser.apUser = userDataInstance.GetUserFromTable(reader.GetInt32(0))
                assignedUser.apWorkTime = reader.GetInt32(1)

                userList.Add(assignedUser)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfAssignedUser = userList

    End Function

    Public Function FillDataGridViewAssignedUser(ByVal idProject As Integer) As DataTable

        dataTableAssignedUser = CreateDataTableAssignedUser()

        Dim assignedUserGridView As List(Of AssignedProject)

        assignedUserGridView = ListOfAssignedUser(idProject)

        Dim row As DataRow

        For i = 0 To assignedUserGridView.Count - 1 Step 1

            row = dataTableAssignedUser.NewRow
            row("ID") = assignedUserGridView(i).apUser.user_user_id
            row("User Name") = assignedUserGridView(i).apUser.user_name
            row("Hours Assigned") = assignedUserGridView(i).apWorkTime
            dataTableAssignedUser.Rows.Add(row)

        Next

        FillDataGridViewAssignedUser = dataTableAssignedUser

    End Function

    Public Function CreateDataTableAssignedProject() As DataTable

        'Create Users table
        dataTableAssignedProject = New DataTable
        dataTableAssignedProject.Columns.Add("ID")
        dataTableAssignedProject.Columns.Add("Project Name")
        dataTableAssignedProject.Columns.Add("Hours")

        CreateDataTableAssignedProject = dataTableAssignedProject

    End Function

    Public Function ListOfAssignedProjects(ByVal idUser As Integer) As List(Of AssignedProject)

        connection.Close()

        Dim cmdSelectUser As New SqlCommand("SELECT id_project,work_time FROM User_Project WHERE id_User = " & idUser, connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()
        Dim projectList As New List(Of AssignedProject)
        Dim assignedProject As New AssignedProject

        Do While reader.HasRows

            Do While reader.Read()

                assignedProject = New AssignedProject
                assignedProject.apProject = projectDataInstance.getProyectById(reader.GetInt32(0))
                assignedProject.apWorkTime = reader.GetInt32(1)

                projectList.Add(assignedProject)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfAssignedProjects = projectList

    End Function

    Public Function FillDataGridViewAssignedProject(ByVal idUser As Integer) As DataTable

        dataTableAssignedProject = CreateDataTableAssignedProject()

        Dim assignedprojectGridView As List(Of AssignedProject)

        assignedprojectGridView = ListOfAssignedProjects(idUser)

        Dim row As DataRow

        For i = 0 To assignedprojectGridView.Count - 1 Step 1

            row = dataTableAssignedProject.NewRow
            row("ID") = assignedprojectGridView(i).apProject.Project_Id
            row("Project Name") = assignedprojectGridView(i).apProject.Project_Name
            row("Hours") = assignedprojectGridView(i).apWorkTime
            dataTableAssignedProject.Rows.Add(row)

        Next

        FillDataGridViewAssignedProject = dataTableAssignedProject

    End Function

    Public Function CreateDataTableProjects() As DataTable

        'Create Users table
        dataTableProjects = New DataTable

        dataTableProjects.Columns.Add("ID")
        dataTableProjects.Columns.Add("Project Name")
        dataTableProjects.Columns.Add("Hours")

        CreateDataTableProjects = dataTableProjects

    End Function

    Public Function ListOfProjects() As List(Of Project)

        connection.Close()

        Dim cmdSelectUser As New SqlCommand("SELECT id_project,project_name,project_hours FROM Projectsdb WHERE project_status = 'New' OR project_status = 'On Progress'", connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()
        Dim projectList As New List(Of Project)
        Dim project As New Project

        Do While reader.HasRows

            Do While reader.Read()

                project = New Project
                project.Project_Id = reader.GetInt32(0)
                project.Project_Name = reader.GetString(1)
                project.Project_Hours = reader.GetInt32(2)

                projectList.Add(project)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfProjects = projectList

    End Function

    Public Function FillDataGridViewProject() As DataTable


        dataTableProjects = CreateDataTableProjects()

        Dim projectGridView As List(Of Project)

        projectGridView = ListOfProjects()

        Dim row As DataRow

        For i = 0 To projectGridView.Count - 1 Step 1

            row = dataTableProjects.NewRow
            row("ID") = projectGridView(i).Project_Id
            row("Project Name") = projectGridView(i).Project_Name
            row("Hours") = projectGridView(i).Project_Hours

            dataTableProjects.Rows.Add(row)

        Next

        FillDataGridViewProject = dataTableProjects

    End Function

    Public Function CreateDataTableUser() As DataTable

        dataTableUsers = New DataTable
        dataTableUsers.Columns.Add("ID")
        dataTableUsers.Columns.Add("Name")
        dataTableUsers.Columns.Add("Email")
        CreateDataTableUser = dataTableUsers


    End Function

    Public Function ListOfUsers() As List(Of User)

        'From table Usersdb, obtain all the rows.
        connection.Close()
        Dim cmdSelectUser As New SqlCommand("SELECT id_user,name,email,worked_hours FROM Usersdb WHERE is_active ='" & True & "'", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()
        Dim userList As New List(Of User)

        Dim user As New User

        Do While reader.HasRows

            Do While reader.Read()

                user = New User
                user.user_user_id = reader.GetInt32(0)
                user.user_name = reader.GetString(1)
                user.user_email = reader.GetString(2)
                userList.Add(user)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfUsers = userList


    End Function

    Public Function FillDataGridViewUser() As DataTable


        dataTableUsers = CreateDataTableUser()
        Dim userProjectGridView As List(Of User)

        userProjectGridView = ListOfUsers()

        Dim row As DataRow

        For i = 0 To userProjectGridView.Count - 1 Step 1

            row = dataTableUsers.NewRow
            row("Id") = userProjectGridView(i).user_user_id
            row("Name") = userProjectGridView(i).user_name
            row("Email") = userProjectGridView(i).user_email

            dataTableUsers.Rows.Add(row)

        Next

        FillDataGridViewUser = dataTableUsers

    End Function


End Class
