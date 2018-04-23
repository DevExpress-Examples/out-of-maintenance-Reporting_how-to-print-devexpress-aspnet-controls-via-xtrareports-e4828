Imports System
Imports System.Collections.Generic
Imports System.IO
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraPrintingLinks
Imports ExportAspControlsViaReports.App_Code
' ...

Namespace ExportAspControlsViaReports
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        ' Generate sample data.
        Public Function GetData() As IList(Of Person)
            Dim persons As New List(Of Person)()
            persons.Add(New Person() With { _
                .Gender = "Male", _
                .Name = "Steven", _
                .Surname = "Buchanan", _
                .Age = 45 _
            })
            persons.Add(New Person() With { _
                .Gender = "Female", _
                .Name = "Anne", _
                .Surname = "Dodsworth", _
                .Age = 34 _
            })
            persons.Add(New Person() With { _
                .Gender = "Male", _
                .Name = "Andrew", _
                .Surname = "Fuller", _
                .Age = 48 _
            })
            persons.Add(New Person() With { _
                .Gender = "Female", _
                .Name = "Nancy", _
                .Surname = "Davolio", _
                .Age = 52 _
            })
            persons.Add(New Person() With { _
                .Gender = "Female", _
                .Name = "Janet", _
                .Surname = "Leverling", _
                .Age = 37 _
            })
            persons.Add(New Person() With { _
                .Gender = "Female", _
                .Name = "Margaret", _
                .Surname = "Peacock", _
                .Age = 63 _
            })
            Return persons
        End Function

        Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Bind the data source to the server controls.
            DataBind()

            ' Create a new report instance.
            Dim report As New Report1()

            ' Link the required controls with the 
            ' Printable Component Containers of a report.
            report.gridContainer.PrintableComponent = ASPxGridViewExporter1
            report.chartContainer.PrintableComponent = New PrintableComponentLinkBase() With {.Component = DirectCast(WebChartControl1, IChartContainer).Chart}

            ' Assemble the report document and publish it 
            ' (e.g., save it to a memory stream in a third-party format).
            Using stream As New MemoryStream()
                report.CreateDocument()
                report.PrintingSystem.ExportToPdf(stream)

                Response.ClearContent()
                Response.ContentType = "application/pdf"

                Dim buffer_Renamed() As Byte = stream.ToArray()
                Response.OutputStream.Write(buffer_Renamed, 0, CInt(stream.Length))
                Response.Flush()
            End Using
        End Sub
    End Class
End Namespace