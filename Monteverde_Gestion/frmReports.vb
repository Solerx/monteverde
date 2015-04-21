
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

'Public Class frmReports

'    Inherits System.

'    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
'        If Not IsPostBack Then
'            BindEmployeesDropDown()
'        End If
'    End Sub

'    Private Sub BindEmployeesDropDown()
'        ddlEmployees.DataSource = GetData("SELECT EmployeeId, (FirstName + ' ' + LastName) Name FROM Employees")
'        ddlEmployees.DataTextField = "Name"
'        ddlEmployees.DataValueField = "EmployeeId"
'        ddlEmployees.DataBind()

'    End Sub

'    Private Function GetData(query As String) As DataTable
'        Dim conString As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
'        Dim cmd As New SqlCommand(query)
'        Using con As New SqlConnection(conString)
'            Using sda As New SqlDataAdapter()
'                cmd.Connection = con

'                sda.SelectCommand = cmd
'                Using dt As New DataTable()
'                    sda.Fill(dt)
'                    Return dt
'                End Using
'            End Using
'        End Using
'    End Function

'    Protected Sub GenerateReport(sender As Object, e As EventArgs)

'        Dim dr As DataRow = GetData("SELECT * FROM Employees where EmployeeId = " + ddlEmployees.SelectedItem.Value).Rows(0)

'        Dim document As New Document(PageSize.A4, 88.0F, 88.0F, 10.0F, 10.0F)
'        Dim NormalFont As Font = FontFactory.GetFont("Arial", 12, Color.BLACK)

'        Using memoryStream As New System.IO.MemoryStream()
'            Dim writer As PdfWriter = PdfWriter.GetInstance(document, memoryStream)
'            Dim phrase As Phrase = Nothing
'            Dim cell As PdfPCell = Nothing
'            Dim table As PdfPTable = Nothing
'            Dim color__1 As Color = Nothing

'            document.Open()

'            'Header Table
'            table = New PdfPTable(2)
'            table.TotalWidth = 500.0F
'            table.LockedWidth = True
'            table.SetWidths(New Single() {0.3F, 0.7F})

'            'Company Logo
'            cell = ImageCell("~/Resourses/Imagen19.png", 30.0F, PdfPCell.ALIGN_CENTER)
'            table.AddCell(cell)

'            'Company Name and Address
'            phrase = New Phrase()
'            phrase.Add(New Chunk("Monteverde Administrator Reports" & vbLf & vbLf, FontFactory.GetFont("Arial", 16, Font.Bold, Color.RED)))
'            cell = PhraseCell(phrase, PdfPCell.ALIGN_LEFT)
'            cell.VerticalAlignment = PdfCell.ALIGN_TOP
'            table.AddCell(cell)

'            'Separater Line
'            color__1 = New Color(System.Drawing.ColorTranslator.FromHtml("#780000"))
'            DrawLine(writer, 25.0F, document.Top - 79.0F, document.PageSize.Width - 25.0F, document.Top - 79.0F, color__1)
'            DrawLine(writer, 25.0F, document.Top - 80.0F, document.PageSize.Width - 25.0F, document.Top - 80.0F, color__1)
'            document.Add(table)

'            table = New PdfPTable(2)
'            table.HorizontalAlignment = Element.ALIGN_LEFT
'            table.SetWidths(New Single() {0.3F, 1.0F})
'            table.SpacingBefore = 20.0F

'            'Employee Details
'            cell = PhraseCell(New Phrase("User: ", FontFactory.GetFont("Arial", 12, Font.Underline, Color.BLACK)), PdfPCell.ALIGN_CENTER)
'            cell.Colspan = 2
'            table.AddCell(cell)
'            cell = PhraseCell(New Phrase(), PdfPCell.ALIGN_CENTER)
'            cell.Colspan = 2
'            cell.PaddingBottom = 30.0F
'            table.AddCell(cell)

'            'Name
'            phrase = New Phrase()
'            phrase.Add(New Chunk(dr("FirstName").ToString, FontFactory.GetFont("Arial", 10, Font.Bold, Color.BLACK)))
'            cell = PhraseCell(phrase, PdfPCell.ALIGN_LEFT)
'            cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE
'            table.AddCell(cell)
'            document.Add(table)

'            DrawLine(writer, 160.0F, 80.0F, 160.0F, 690.0F, Color.BLACK)
'            DrawLine(writer, 115.0F, document.Top - 200.0F, document.PageSize.Width - 100.0F, document.Top - 200.0F, Color.BLACK)

'            table = New PdfPTable(2)
'            table.SetWidths(New Single() {0.5F, 2.0F})
'            table.TotalWidth = 340.0F
'            table.LockedWidth = True
'            table.SpacingBefore = 20.0F
'            table.HorizontalAlignment = Element.ALIGN_RIGHT

'            'Employee Id
'            table.AddCell(PhraseCell(New Phrase("Employee code:", FontFactory.GetFont("Arial", 8, Font.Bold, Color.BLACK)), PdfPCell.ALIGN_LEFT))
'            table.AddCell(PhraseCell(New Phrase("000" + dr("EmployeeId"), FontFactory.GetFont("Arial", 8, Color.BLACK)), PdfPCell.ALIGN_LEFT))
'            cell = PhraseCell(New Phrase(), PdfPCell.ALIGN_CENTER)
'            cell.Colspan = 2
'            cell.PaddingBottom = 10.0F
'            table.AddCell(cell)

'            'Date of Birth
'            table.AddCell(PhraseCell(New Phrase("User Since:", FontFactory.GetFont("Arial", 8, Font.Bold, Color.BLACK)), PdfPCell.ALIGN_LEFT))
'            table.AddCell(PhraseCell(New Phrase(Convert.ToDateTime(dr("BirthDate")).ToString("dd MMMM, yyyy"), FontFactory.GetFont("Arial", 8, Color.BLACK)), PdfPCell.ALIGN_LEFT))
'            cell = PhraseCell(New Phrase(), PdfPCell.ALIGN_CENTER)
'            cell.Colspan = 2
'            cell.PaddingBottom = 10.0F
'            table.AddCell(cell)

'            'Phone
'            table.AddCell(PhraseCell(New Phrase("Phone Number:", FontFactory.GetFont("Arial", 8, Font.Bold, Color.BLACK)), PdfPCell.ALIGN_LEFT))
'            table.AddCell(PhraseCell(New Phrase(dr("HomePhone") + " Ext: " + dr("Extension"), FontFactory.GetFont("Arial", 8, Color.BLACK)), PdfPCell.ALIGN_LEFT))
'            cell = PhraseCell(New Phrase(), PdfPCell.ALIGN_CENTER)
'            cell.Colspan = 2
'            cell.PaddingBottom = 10.0F
'            table.AddCell(cell)

'            'Addtional Information
'            table.AddCell(PhraseCell(New Phrase("Addtional Information:", FontFactory.GetFont("Arial", 8, Font.Bold, Color.BLACK)), PdfPCell.ALIGN_LEFT))
'            table.AddCell(PhraseCell(New Phrase(dr("Notes").ToString(), FontFactory.GetFont("Arial", 8, Color.BLACK)), PdfPCell.ALIGN_JUSTIFIED))
'            document.Add(table)
'            document.Close()
'            Dim bytes As Byte() = memoryStream.ToArray()
'            memoryStream.Close()

'            Response.Clear()
'            Response.ContentType = "application/pdf"
'            Response.AddHeader("Content-Disposition", "attachment; filename=Employee.pdf")
'            Response.ContentType = "application/pdf"
'            Response.Buffer = True
'            Response.Cache.SetCacheability(HttpCacheability.NoCache)
'            Response.BinaryWrite(bytes)
'            Response.[End]()
'            Response.Close()

'        End Using

'    End Sub

'    Private Shared Sub DrawLine(writer As PdfWriter, x1 As Single, y1 As Single, x2 As Single, y2 As Single, color As Color)

'        Dim contentByte As PdfContentByte = writer.DirectContent
'        contentByte.SetColorStroke(color)
'        contentByte.MoveTo(x1, y1)
'        contentByte.LineTo(x2, y2)
'        contentByte.Stroke()

'    End Sub
'    Private Shared Function PhraseCell(phrase As Phrase, align As Integer) As PdfPCell

'        Dim cell As New PdfPCell(phrase)
'        cell.BorderColor = Color.WHITE
'        cell.VerticalAlignment = PdfCell.ALIGN_TOP
'        cell.HorizontalAlignment = align
'        cell.PaddingBottom = 2.0F
'        cell.PaddingTop = 0.0F
'        Return cell

'    End Function
'    Private Shared Function ImageCell(path As String, scale As Single, align As Integer) As PdfPCell

'        Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(HttpContext.Current.Server.MapPath(path))
'        image.ScalePercent(scale)
'        Dim cell As New PdfPCell(image)
'        cell.BorderColor = Color.WHITE
'        cell.VerticalAlignment = PdfCell.ALIGN_TOP
'        cell.HorizontalAlignment = align
'        cell.PaddingBottom = 0.0F
'        cell.PaddingTop = 0.0F
'        Return cell

'    End Function
'End Class