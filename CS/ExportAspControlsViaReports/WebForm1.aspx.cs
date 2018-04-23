using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraPrintingLinks;
using ExportAspControlsViaReports.App_Code;
// ...

namespace ExportAspControlsViaReports {
    public partial class WebForm1 : System.Web.UI.Page {

        // Generate sample data.
        public IList<Person> GetData() {
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { 
                Gender = "Male", Name = "Steven", Surname = "Buchanan", Age = 45 });
            persons.Add(new Person() { 
                Gender = "Female", Name = "Anne", Surname = "Dodsworth", Age = 34 });
            persons.Add(new Person() { 
                Gender = "Male", Name = "Andrew", Surname = "Fuller", Age = 48 });
            persons.Add(new Person() { 
                Gender = "Female", Name = "Nancy", Surname = "Davolio", Age = 52 });
            persons.Add(new Person() { 
                Gender = "Female", Name = "Janet", Surname = "Leverling", Age = 37 });
            persons.Add(new Person() { 
                Gender = "Female", Name = "Margaret", Surname = "Peacock", Age = 63 });
            return persons;
        }

        protected void Button1_Click(object sender, EventArgs e) {
            // Bind the data source to the server controls.
            DataBind();

            // Create a new report instance.
            Report1 report = new Report1();

            // Link the required controls with the 
            // Printable Component Containers of a report.
            report.gridContainer.PrintableComponent = ASPxGridViewExporter1;
            report.chartContainer.PrintableComponent = 
            new PrintableComponentLinkBase() { 
                Component = ((IChartContainer)WebChartControl1).Chart 
            };

            // Assemble the report document and publish it 
            // (e.g., save it to a memory stream in a third-party format).
            using (MemoryStream stream = new MemoryStream()) {
                report.CreateDocument();
                report.PrintingSystem.ExportToPdf(stream);

                Response.ClearContent();
                Response.ContentType = "application/pdf";
                byte[] buffer = stream.ToArray();
                Response.OutputStream.Write(buffer, 0, (int)stream.Length);
                Response.Flush();
            }
        }
    }
}