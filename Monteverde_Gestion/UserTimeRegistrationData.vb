Imports System.Data.SqlClient

Public Class UserTimeRegistrationData

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)


    Public Sub Insert(ByVal timeRegistration As UserTimeRegistration)

        connection.Close()

        Dim cmdInsert As New SqlCommand

        cmdInsert = New SqlCommand("insert into Time_Registration(id_user,id_project,hours,user_notes,date)" & _
                                   "values(@id_user,@id_project,@hours,@user_notes,@date)", connection)
        connection.Open()

        With cmdInsert

            .Parameters.AddWithValue("@id_user", timeRegistration.IdUser)
            .Parameters.AddWithValue("@id_project", timeRegistration.IdProject)
            .Parameters.AddWithValue("@hours", timeRegistration.WorkTime)
            .Parameters.AddWithValue("@user_notes", timeRegistration.UserNotes)
            .Parameters.AddWithValue("@date", timeRegistration.TimeStampDate)


        End With

        cmdInsert.ExecuteNonQuery()
        MsgBox("Category added successfully.")
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

    Public Function GetCategoryByName(ByVal Name As String) As WorkCategory

        connection.Close()

        Dim cmdSelectUser As New SqlCommand("SELECT workcategory_name, workcategory_description FROM Work_Categories WHERE workcategory_name = '" & Name & "'", connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

        Dim category As New WorkCategory

        reader.Read()

        category = New WorkCategory
        category.Name = reader.GetString(0)
        category.Description = reader.GetString(1)


        reader.Close()

        GetCategoryByName = category

    End Function

End Class
