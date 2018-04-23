Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraPrintingLinks
Imports ExportAspControlsViaReports.App_Code

Namespace ExportAspControlsViaReports
	Partial Public Class WebForm1
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub
		Public Function GetData() As IList(Of Person)
			Dim persons As New List(Of Person)()
			persons.Add(New Person() With {.Gendor = "Male", .Name = "Steven", .Surname = "Buchanan", .Age = 45})
			persons.Add(New Person() With {.Gendor = "Female", .Name = "Anne", .Surname = "Dodsworth", .Age = 34})
			persons.Add(New Person() With {.Gendor = "Male", .Name = "Andrew", .Surname = "Fuller", .Age = 48})
			persons.Add(New Person() With {.Gendor = "Female", .Name = "Nancy", .Surname = "Davolio", .Age = 52})
			persons.Add(New Person() With {.Gendor = "Female", .Name = "Janet", .Surname = "Leverling", .Age = 37})
			persons.Add(New Person() With {.Gendor = "Female", .Name = "Margaret", .Surname = "Peacock", .Age = 63})
			Return persons
		End Function

		Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
			DataBind()

			Dim report As New Report1()
			report.gridContainer.PrintableComponent = New PrintableComponentLinkBase() With {.Component = ASPxGridViewExporter1}
			report.chartContainer.PrintableComponent = New PrintableComponentLinkBase() With {.Component = (CType(WebChartControl1, IChartContainer)).Printable}

			Using stream As New MemoryStream()
				report.CreateDocument()
				report.PrintingSystem.ExportToPdf(stream)

				Response.ClearContent()
				Response.ContentType = "application/pdf"
				Dim buffer() As Byte = stream.GetBuffer()
				Response.OutputStream.Write(buffer, 0, CInt(Fix(stream.Length)))
				Response.Flush()
			End Using
		End Sub
	End Class
End Namespace