Imports System.Data.SqlClient

Public Class Projectdata

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim dataTableProjects As New DataTable

    Public Function CreateDataTableProjects() As DataTable

        dataTableProjects = New DataTable

        dataTableProjects.Columns.Add("ID")
        dataTableProjects.Columns.Add("Project Name")
        dataTableProjects.Columns.Add("Enterprise")
        dataTableProjects.Columns.Add("Hours")
        dataTableProjects.Columns.Add("Status")
        dataTableProjects.Columns.Add("Contact Info")

        CreateDataTableProjects = dataTableProjects

    End Function

    Public Function ListOfProjects() As List(Of Project)

        connection.Close()

        Dim cmdSelectUser As New SqlCommand("SELECT id_project,project_name,enterprise_name,project_hours,project_status,contact_info FROM Projectsdb", connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()
        Dim projectList As New List(Of Project)
        Dim project As New Project

        Do While reader.HasRows

            Do While reader.Read()

                project = New Project
                project.Project_Id = reader.GetInt32(0)
                project.Project_Name = reader.GetString(1)
                project.Project_Enterprise = reader.GetString(2)
                project.Project_Hours = reader.GetInt32(3)
                project.Project_Status = reader.GetString(4)
                project.Project_ContactInfo = reader.GetString(5)

                projectList.Add(project)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfProjects = projectList

    End Function

    Public Function Fill_Data_Grid_View() As DataTable

        'Fill table created at Create_Data_Table_User() 

        dataTableProjects = CreateDataTableProjects()

        Dim projectGridView As List(Of Project)

        projectGridView = ListOfProjects()

        Dim row As DataRow

        For i = 0 To projectGridView.Count - 1 Step 1

            row = dataTableProjects.NewRow
            row("ID") = projectGridView(i).Project_Id
            row("Project Name") = projectGridView(i).Project_Name
            row("Enterprise") = projectGridView(i).Project_Enterprise
            row("Hours") = projectGridView(i).Project_Hours
            row("Status") = projectGridView(i).Project_Status
            row("Contact Info") = projectGridView(i).Project_ContactInfo

            dataTableProjects.Rows.Add(row)

        Next

        Fill_Data_Grid_View = dataTableProjects

    End Function

    Public Sub InsertProject(ByVal project As Project)

        connection.Close()

        Dim cmdInsert As New SqlCommand

        cmdInsert = New SqlCommand("insert into Projectsdb(project_name,enterprise_name,project_hours,project_status,contact_info)" & _
                                   "values(@project_name,@enterprise_name,@project_hours,@project_status,@contact_info)", connection)
        connection.Open()

        With cmdInsert

            .Parameters.AddWithValue("@project_name", project.Project_Name)
            .Parameters.AddWithValue("@enterprise_name", project.Project_Enterprise)
            .Parameters.AddWithValue("@project_hours", project.Project_Hours)
            .Parameters.AddWithValue("@project_status", project.Project_Status)
            .Parameters.AddWithValue("@contact_info", project.Project_ContactInfo)


        End With

        cmdInsert.ExecuteNonQuery()
        MsgBox("User added successfully.")
        connection.Close()
    End Sub

    Public Sub EditProject(ByVal project As Project, ByVal id As Integer)

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("UPDATE Projectsdb SET " & _
                               "project_name = @project_name, " & _
                               "enterprise_name = @enterprise_name, " & _
                               "project_hours = @project_hours, " & _
                               "project_status = @project_status, " & _
                               "contact_info = @contact_info " & _
                               "WHERE id_project = " & id, connection)

        With cmdUpdate

            .Parameters.AddWithValue("@project_name", project.Project_Name)
            .Parameters.AddWithValue("@enterprise_name", project.Project_Enterprise)
            .Parameters.AddWithValue("@project_hours", project.Project_Hours)
            .Parameters.AddWithValue("@project_status", project.Project_Status)
            .Parameters.AddWithValue("@contact_info", project.Project_ContactInfo)

        End With

        cmdUpdate.ExecuteNonQuery()
        connection.Close()
        MsgBox("Project edited successfully!")

    End Sub

    Public Sub DeleteProject(ByVal indexRow As Integer, ByVal id As Integer)

        Try

            connection.Close()

            Dim cmdUpdate As New SqlCommand

            cmdUpdate = New SqlCommand("Delete from Projectsdb " & _
            "WHERE id_project = " & id, connection)

            connection.Open()
            cmdUpdate.ExecuteNonQuery()
            Fill_Data_Grid_View()
            connection.Close()
            MsgBox("Project removed successfully!")

        Catch ex As SqlException

            MessageBox.Show("The project can't be removed because it is already assigned to users.", "Error removing project!")

        End Try

    End Sub

    Public Function GetProyectById(ByVal id As Integer) As Project

        connection.Close()

        Dim cmdSelectUser As New SqlCommand("SELECT id_project,project_name,enterprise_name,project_hours,project_status,contact_info FROM Projectsdb WHERE id_project = " & id, connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

        Dim project As New Project

        reader.Read()

        project = New Project
        project.Project_Id = reader.GetInt32(0)
        project.Project_Name = reader.GetString(1)
        project.Project_Enterprise = reader.GetString(2)
        project.Project_Hours = reader.GetInt32(3)
        project.Project_Status = reader.GetString(4)
        project.Project_ContactInfo = reader.GetString(5)

        reader.Close()

        getProyectById = project

    End Function

    Public Function GetProyectByName(ByVal name As String) As Integer

        connection.Close()

        Dim cmdSelectUser As New SqlCommand("SELECT id_project FROM Projectsdb WHERE project_name = '" & name & "'", connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

        Dim idProject As Integer

        reader.Read()

        idProject = reader.GetInt32(0)

        reader.Close()

        GetProyectByName = idProject

    End Function

End Class
