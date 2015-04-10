Imports System.Data.SqlClient

Public Class frmNewTimeRegistration

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim assignedProjectInstance As AssignedProjectData = New AssignedProjectData

    Dim workCategoryDataInstance As WorkCategoryData

    Dim row2 As Integer

    Private Sub frmNewTimeRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateTable()
        FillCombobox()

    End Sub

    Public Sub UpdateTable()

        Me.dgvAssignedProjects.DataSource = assignedProjectInstance.FillDataGridViewAssignedProject(frmLogin.globalUserId)

    End Sub

    Public Function FillComboBox() As Dictionary(Of String, String)

        Dim category = New Dictionary(Of String, String)()

        connection.Open()

        Dim cmdSelectCategory As New SqlCommand("SELECT workcategory_name FROM Work_Categories", connection)

        Dim reader As SqlDataReader = cmdSelectCategory.ExecuteReader()

        For index = 1 To 10

            While reader.Read()

                category(index) = cbxWorkCategories.Items.Add(reader.Item(0))


            End While

        Next

        connection.Close()

        FillComboBox = category

    End Function

    Public Sub Inputs()

        Dim timeStamp As DateTime
        Dim workCategory As String
        Dim workTime As Integer
        Dim notes As Integer


        workCategory = cbxWorkCategories.SelectedText
        workTime = txtUserWorkedHours.Text
        notes = rtbNotes.Text
        timeStamp = DateTime.Now



    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim timeStamp As DateTime = DateTime.Now
        MsgBox(timeStamp)

    End Sub
End Class