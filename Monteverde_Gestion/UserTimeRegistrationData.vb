Imports System.Data.SqlClient

Public Class UserTimeRegistrationData

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim connection2 As New SqlConnection(strConexion)

    Dim userDataInstance As Userdata = New Userdata

    Dim projectDataInstace As Projectdata = New Projectdata

    Dim dataTableRegisters As New DataTable

    Public Sub Insert(ByVal timeRegistration As UserTimeRegistration)

        connection.Close()

        Dim cmdInsert As New SqlCommand

        cmdInsert = New SqlCommand("insert into Time_Registration(id_user,id_project,hours,user_notes,date,work_category)" & _
                                   "values(@id_user,@id_project,@hours,@user_notes,@date,@work_category)", connection)
        connection.Open()

        With cmdInsert

            .Parameters.AddWithValue("@id_user", timeRegistration.UtUser.user_user_id)
            .Parameters.AddWithValue("@id_project", timeRegistration.UtProject.Project_Id)
            .Parameters.AddWithValue("@hours", timeRegistration.UtWorkTime)
            .Parameters.AddWithValue("@user_notes", timeRegistration.UtUserNotes)
            .Parameters.AddWithValue("@date", timeRegistration.UtTimeStampDate)
            .Parameters.AddWithValue("@work_category", timeRegistration.UtWorkTimeCategory.Name)

        End With

        cmdInsert.ExecuteNonQuery()
        MsgBox("Worked Time added successfully.")
        connection.Close()

    End Sub

    Public Sub Delete(ByVal indexRow As Integer, ByVal name As String, ByVal description As String)

        connection.Close()

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("Delete from Work_Categories " & _
        "WHERE workcategory_name = '" & name & "' and workcategory_description = '" & description & "'", connection)

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        connection.Close()
        MsgBox("Category removed successfully!")


    End Sub

    Public Sub Edit(ByVal category As WorkCategory, ByVal name As String)

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("UPDATE Work_Categories SET " & _
                               "workcategory_name = @workcategory_name, " & _
                               "workcategory_description = @workcategory_description " & _
                               "WHERE workcategory_name = '" & name & "'", connection)

        With cmdUpdate

            .Parameters.AddWithValue("@workcategory_name", category.Name)
            .Parameters.AddWithValue("@workcategory_description", category.Description)


        End With

        cmdUpdate.ExecuteNonQuery()
        connection.Close()
        MsgBox("Category edited successfully!")

    End Sub

    Public Function CreateDataTableRegisteredTime() As DataTable

        dataTableRegisters = New DataTable

        dataTableRegisters.Columns.Add("User")
        dataTableRegisters.Columns.Add("Project")
        dataTableRegisters.Columns.Add("Worked Time")
        dataTableRegisters.Columns.Add("Work Category")
        dataTableRegisters.Columns.Add("Notes")
        dataTableRegisters.Columns.Add("Registered Date")


        CreateDataTableRegisteredTime = dataTableRegisters

    End Function

    Public Function CreateDataTableUserRegisteredTime() As DataTable

        dataTableRegisters = New DataTable

        dataTableRegisters.Columns.Add("Project")
        dataTableRegisters.Columns.Add("Worked Time")
        dataTableRegisters.Columns.Add("Work Category")
        dataTableRegisters.Columns.Add("Notes")
        dataTableRegisters.Columns.Add("Registered Date")


        CreateDataTableUserRegisteredTime = dataTableRegisters

    End Function

    Public Function ListOfWorkedTime() As List(Of UserTimeRegistration)

        connection.Close()

        Dim cmdSelectRegister As New SqlCommand("SELECT id_user,id_project,hours,user_notes,date,work_category FROM Time_Registration", connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectRegister.ExecuteReader()
        Dim timeRegistrationList As New List(Of UserTimeRegistration)
        Dim register As New UserTimeRegistration

        Do While reader.HasRows

            Do While reader.Read()

                register = New UserTimeRegistration
                register.UtUser = userDataInstance.GetUserFromTable(reader.GetInt32(0))
                register.UtProject = projectDataInstace.GetProyectById(reader.GetInt32(1))
                register.UtWorkTime = reader.GetInt32(2)
                register.UtUserNotes = reader.GetString(3)
                register.UtTimeStampDate = reader.GetDateTime(4)
                register.UtWorkTimeCategory = GetWorkCategory(reader.GetString(5))


                timeRegistrationList.Add(register)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfWorkedTime = timeRegistrationList

    End Function

    Public Function FillDataGridView() As DataTable

        dataTableRegisters = CreateDataTableRegisteredTime()

        Dim workedtimeGridView As List(Of UserTimeRegistration)

        workedtimeGridView = ListOfWorkedTime()

        Dim row As DataRow

        For i = 0 To workedtimeGridView.Count - 1 Step 1

            row = dataTableRegisters.NewRow
            row("User") = workedtimeGridView(i).UtUser.user_name
            row("Project") = workedtimeGridView(i).UtProject.Project_Name
            row("Worked Time") = workedtimeGridView(i).UtWorkTime
            row("Work Category") = workedtimeGridView(i).UtWorkTimeCategory.Name
            row("Notes") = workedtimeGridView(i).UtUserNotes
            row("Registered Date") = workedtimeGridView(i).UtTimeStampDate
            dataTableRegisters.Rows.Add(row)

        Next

        FillDataGridView = dataTableRegisters

    End Function

    Public Function GridViewFilteredByUser(ByVal user As String) As DataTable

        dataTableRegisters = CreateDataTableRegisteredTime()

        Dim workedtimeGridView As List(Of UserTimeRegistration)

        workedtimeGridView = ListOfWorkedTime()

        Dim row As DataRow

        For i = 0 To workedtimeGridView.Count - 1 Step 1

            row = dataTableRegisters.NewRow
            row("User") = workedtimeGridView(i).UtUser.user_name
            row("Project") = workedtimeGridView(i).UtProject.Project_Name
            row("Worked Time") = workedtimeGridView(i).UtWorkTime
            row("Work Category") = workedtimeGridView(i).UtWorkTimeCategory.Name
            row("Notes") = workedtimeGridView(i).UtUserNotes
            row("Registered Date") = workedtimeGridView(i).UtTimeStampDate

            If workedtimeGridView(i).UtUser.user_name = user Then

                dataTableRegisters.Rows.Add(row)

            End If

        Next

        GridViewFilteredByUser = dataTableRegisters

    End Function

    Public Function GridViewFilteredByProject(ByVal project As String) As DataTable

        dataTableRegisters = CreateDataTableRegisteredTime()

        Dim workedtimeGridView As List(Of UserTimeRegistration)

        workedtimeGridView = ListOfWorkedTime()

        Dim row As DataRow

        For i = 0 To workedtimeGridView.Count - 1 Step 1

            row = dataTableRegisters.NewRow
            row("User") = workedtimeGridView(i).UtUser.user_name
            row("Project") = workedtimeGridView(i).UtProject.Project_Name
            row("Worked Time") = workedtimeGridView(i).UtWorkTime
            row("Work Category") = workedtimeGridView(i).UtWorkTimeCategory.Name
            row("Notes") = workedtimeGridView(i).UtUserNotes
            row("Registered Date") = workedtimeGridView(i).UtTimeStampDate

            If workedtimeGridView(i).UtProject.Project_Name = project Then

                dataTableRegisters.Rows.Add(row)

            End If

        Next

        GridViewFilteredByProject = dataTableRegisters

    End Function

    Public Function GridViewFilteredByWorkCategory(ByVal category As String) As DataTable

        dataTableRegisters = CreateDataTableRegisteredTime()

        Dim workedtimeGridView As List(Of UserTimeRegistration)

        workedtimeGridView = ListOfWorkedTime()

        Dim row As DataRow

        For i = 0 To workedtimeGridView.Count - 1 Step 1

            row = dataTableRegisters.NewRow
            row("User") = workedtimeGridView(i).UtUser.user_name
            row("Project") = workedtimeGridView(i).UtProject.Project_Name
            row("Worked Time") = workedtimeGridView(i).UtWorkTime
            row("Work Category") = workedtimeGridView(i).UtWorkTimeCategory.Name
            row("Notes") = workedtimeGridView(i).UtUserNotes
            row("Registered Date") = workedtimeGridView(i).UtTimeStampDate

            If workedtimeGridView(i).UtWorkTimeCategory.Name = category Then

                dataTableRegisters.Rows.Add(row)

            End If

        Next

        GridViewFilteredByWorkCategory = dataTableRegisters

    End Function

    Public Function GridViewFilteredByUserProject(ByVal user As String, ByVal project As String) As DataTable

        dataTableRegisters = CreateDataTableRegisteredTime()

        Dim workedtimeGridView As List(Of UserTimeRegistration)

        workedtimeGridView = ListOfWorkedTime()

        Dim row As DataRow

        For i = 0 To workedtimeGridView.Count - 1 Step 1

            row = dataTableRegisters.NewRow
            row("User") = workedtimeGridView(i).UtUser.user_name
            row("Project") = workedtimeGridView(i).UtProject.Project_Name
            row("Worked Time") = workedtimeGridView(i).UtWorkTime
            row("Work Category") = workedtimeGridView(i).UtWorkTimeCategory.Name
            row("Notes") = workedtimeGridView(i).UtUserNotes
            row("Registered Date") = workedtimeGridView(i).UtTimeStampDate

            If workedtimeGridView(i).UtUser.user_name = user And workedtimeGridView(i).UtProject.Project_Name = project Then

                dataTableRegisters.Rows.Add(row)

            End If

        Next

        GridViewFilteredByUserProject = dataTableRegisters

    End Function

    Public Function GridViewFilteredByUserCategory(ByVal user As String, ByVal category As String) As DataTable

        dataTableRegisters = CreateDataTableRegisteredTime()

        Dim workedtimeGridView As List(Of UserTimeRegistration)

        workedtimeGridView = ListOfWorkedTime()

        Dim row As DataRow

        For i = 0 To workedtimeGridView.Count - 1 Step 1

            row = dataTableRegisters.NewRow
            row("User") = workedtimeGridView(i).UtUser.user_name
            row("Project") = workedtimeGridView(i).UtProject.Project_Name
            row("Worked Time") = workedtimeGridView(i).UtWorkTime
            row("Work Category") = workedtimeGridView(i).UtWorkTimeCategory.Name
            row("Notes") = workedtimeGridView(i).UtUserNotes
            row("Registered Date") = workedtimeGridView(i).UtTimeStampDate

            If workedtimeGridView(i).UtUser.user_name = user And workedtimeGridView(i).UtWorkTimeCategory.Name = category Then

                dataTableRegisters.Rows.Add(row)

            End If

        Next

        GridViewFilteredByUserCategory = dataTableRegisters

    End Function

    Public Function GridViewFilteredByProjectCategory(ByVal project As String, ByVal category As String) As DataTable

        dataTableRegisters = CreateDataTableRegisteredTime()

        Dim workedtimeGridView As List(Of UserTimeRegistration)

        workedtimeGridView = ListOfWorkedTime()

        Dim row As DataRow

        For i = 0 To workedtimeGridView.Count - 1 Step 1

            row = dataTableRegisters.NewRow
            row("User") = workedtimeGridView(i).UtUser.user_name
            row("Project") = workedtimeGridView(i).UtProject.Project_Name
            row("Worked Time") = workedtimeGridView(i).UtWorkTime
            row("Work Category") = workedtimeGridView(i).UtWorkTimeCategory.Name
            row("Notes") = workedtimeGridView(i).UtUserNotes
            row("Registered Date") = workedtimeGridView(i).UtTimeStampDate

            If workedtimeGridView(i).UtProject.Project_Name = Project And workedtimeGridView(i).UtWorkTimeCategory.Name = category Then

                dataTableRegisters.Rows.Add(row)

            End If

        Next

        GridViewFilteredByProjectCategory = dataTableRegisters

    End Function

    Public Function GridViewFilteredByUserProjectCategory(ByVal user As String, ByVal project As String, ByVal category As String) As DataTable

        dataTableRegisters = CreateDataTableRegisteredTime()

        Dim workedtimeGridView As List(Of UserTimeRegistration)

        workedtimeGridView = ListOfWorkedTime()

        Dim row As DataRow

        For i = 0 To workedtimeGridView.Count - 1 Step 1

            row = dataTableRegisters.NewRow
            row("User") = workedtimeGridView(i).UtUser.user_name
            row("Project") = workedtimeGridView(i).UtProject.Project_Name
            row("Worked Time") = workedtimeGridView(i).UtWorkTime
            row("Work Category") = workedtimeGridView(i).UtWorkTimeCategory.Name
            row("Notes") = workedtimeGridView(i).UtUserNotes
            row("Registered Date") = workedtimeGridView(i).UtTimeStampDate

            If workedtimeGridView(i).UtUser.user_name = user And workedtimeGridView(i).UtProject.Project_Name = project And workedtimeGridView(i).UtWorkTimeCategory.Name = category Then

                dataTableRegisters.Rows.Add(row)

            End If

        Next

        GridViewFilteredByUserProjectCategory = dataTableRegisters

    End Function

    Public Function ListOfWorkedTimeByUserId(ByVal idUser As Integer) As List(Of UserTimeRegistration)

        connection.Close()

        Dim cmdSelectRegister As New SqlCommand("SELECT id_user,id_project,hours,user_notes,date,work_category FROM Time_Registration WHERE id_user =" & idUser, connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectRegister.ExecuteReader()
        Dim timeRegistrationList As New List(Of UserTimeRegistration)
        Dim register As New UserTimeRegistration

        Do While reader.HasRows

            Do While reader.Read()

                register = New UserTimeRegistration
                register.UtUser = userDataInstance.GetUserFromTable(reader.GetInt32(0))
                register.UtProject = projectDataInstace.GetProyectById(reader.GetInt32(1))
                register.UtWorkTime = reader.GetInt32(2)
                register.UtUserNotes = reader.GetString(3)
                register.UtTimeStampDate = reader.GetDateTime(4)
                register.UtWorkTimeCategory = GetWorkCategory(reader.GetString(5))


                timeRegistrationList.Add(register)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfWorkedTimeByUserId = timeRegistrationList

    End Function

    Public Function ListOfWorkedTimeByCategory(ByVal workCategory As String) As List(Of UserTimeRegistration)

        connection.Close()

        Dim cmdSelectRegister As New SqlCommand("SELECT id_user,id_project,hours,user_notes,date,work_category FROM Time_Registration WHERE work_category = '" & workCategory & "'", connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectRegister.ExecuteReader()
        Dim timeRegistrationList As New List(Of UserTimeRegistration)
        Dim register As New UserTimeRegistration

        Do While reader.HasRows

            Do While reader.Read()

                register = New UserTimeRegistration
                register.UtUser = userDataInstance.GetUserFromTable(reader.GetInt32(0))
                register.UtProject = projectDataInstace.GetProyectById(reader.GetInt32(1))
                register.UtWorkTime = reader.GetInt32(2)
                register.UtUserNotes = reader.GetString(3)
                register.UtTimeStampDate = reader.GetDateTime(4)
                register.UtWorkTimeCategory = GetWorkCategory(reader.GetString(5))


                timeRegistrationList.Add(register)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfWorkedTimeByCategory = timeRegistrationList

    End Function

    Public Function FillDataGridViewWithUserTime(ByVal workedtimeGridView As List(Of UserTimeRegistration)) As DataTable

        'Fill table created at Create_Data_Table_User() 

        dataTableRegisters = CreateDataTableUserRegisteredTime()

        Dim row As DataRow

        For i = 0 To workedtimeGridView.Count - 1 Step 1

            row = dataTableRegisters.NewRow
            row("Project") = workedtimeGridView(i).UtProject.Project_Name
            row("Worked Time") = workedtimeGridView(i).UtWorkTime
            row("Work Category") = workedtimeGridView(i).UtWorkTimeCategory.Name
            row("Notes") = workedtimeGridView(i).UtUserNotes
            row("Registered Date") = workedtimeGridView(i).UtTimeStampDate

            dataTableRegisters.Rows.Add(row)

        Next

        FillDataGridViewWithUserTime = dataTableRegisters

    End Function

    Public Function GetWorkCategory(ByVal category As String) As WorkCategory


        Dim cmdSelectUser As New SqlCommand("SELECT workcategory_name FROM Work_Categories, Time_Registration WHERE Time_Registration.work_category = Work_Categories.workcategory_name AND Time_Registration.work_category='" & category & "'", connection2)

        connection2.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

        Dim workCategory As New WorkCategory

        If reader.HasRows Then

            If reader.Read() Then

                workCategory.Name = reader.GetString(0)
                connection2.Close()

            End If

        End If

        GetWorkCategory = workCategory
        connection2.Close()

    End Function

    Public Sub EditWorkTimeFromUser(ByVal workTime As Integer, ByVal idUser As Integer, ByVal idProject As Integer, ByVal notes As String)

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("UPDATE Time_Registration SET " & _
                               "hours = @hours " & _
                               "WHERE id_user = " & idUser & "AND id_project = " & idProject & "AND user_notes= '" & notes & "'", connection2)
        connection2.Open()

        With cmdUpdate

            .Parameters.AddWithValue("@hours", workTime)

        End With


        cmdUpdate.ExecuteNonQuery()
        MsgBox("User worked time changed succesfully!")
        connection2.Close()

    End Sub

End Class
