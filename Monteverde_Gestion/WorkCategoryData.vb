Imports System.Data.SqlClient

Public Class WorkCategoryData

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim dataTableCategories As New DataTable

    Public Function CreateDataTableProjects() As DataTable

        'Create Users table
        dataTableCategories = New DataTable

        dataTableCategories.Columns.Add("Name")
        dataTableCategories.Columns.Add("Description")

        CreateDataTableProjects = dataTableCategories

    End Function

    Public Function ListOfCategories() As List(Of WorkCategory)

        connection.Close()

        Dim cmdSelectCategory As New SqlCommand("SELECT id, workcategory_name, workcategory_description FROM Work_Categories", connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdSelectCategory.ExecuteReader()
        Dim categoryList As New List(Of WorkCategory)
        Dim category As New WorkCategory

        Do While reader.HasRows

            Do While reader.Read()

                category = New WorkCategory
                category.Id = reader.GetInt32(0)
                category.Name = reader.GetString(1)
                category.Description = reader.GetString(2)

                categoryList.Add(category)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfCategories = categoryList

    End Function


    Public Function Fill_Data_Grid_View() As DataTable

        'Fill table created at Create_Data_Table_User() 

        dataTableCategories = CreateDataTableProjects()

        Dim categoryGridView As List(Of WorkCategory)

        categoryGridView = ListOfCategories()

        Dim row As DataRow

        For i = 0 To categoryGridView.Count - 1 Step 1

            row = dataTableCategories.NewRow
            row("Name") = categoryGridView(i).Name
            row("Description") = categoryGridView(i).Description

            dataTableCategories.Rows.Add(row)

        Next

        Fill_Data_Grid_View = dataTableCategories

    End Function

    Public Sub Insert(ByVal category As WorkCategory)

        connection.Close()

        Dim cmdInsert As New SqlCommand

        cmdInsert = New SqlCommand("insert into Work_Categories(workcategory_name,workcategory_description)" & _
                                   "values(@workcategory_name,@workcategory_description)", connection)
        connection.Open()

        With cmdInsert

            .Parameters.AddWithValue("@workcategory_name", category.Name)
            .Parameters.AddWithValue("@workcategory_description", category.Description)

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
        Fill_Data_Grid_View()
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
