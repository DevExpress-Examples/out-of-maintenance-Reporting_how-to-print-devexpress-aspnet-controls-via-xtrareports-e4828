using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraPrintingLinks;
using ExportAspControlsViaReports.App_Code;

namespace ExportAspControlsViaReports {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }
        public IList<Person> GetData() {
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Gendor = "Male", Name = "Steven", Surname = "Buchanan", Age = 45 });
            persons.Add(new Person() { Gendor = "Female", Name = "Anne", Surname = "Dodsworth", Age = 34 });
            persons.Add(new Person() { Gendor = "Male", Name = "Andrew", Surname = "Fuller", Age = 48 });
            persons.Add(new Person() { Gendor = "Female", Name = "Nancy", Surname = "Davolio", Age = 52 });
            persons.Add(new Person() { Gendor = "Female", Name = "Janet", Surname = "Leverling", Age = 37 });
            persons.Add(new Person() { Gendor = "Female", Name = "Margaret", Surname = "Peacock", Age = 63 });
            return persons;
        }

        protected void Button1_Click(object sender, EventArgs e) {
            DataBind();

            Report1 report = new Report1();
            report.gridContainer.PrintableComponent = new PrintableComponentLinkBase() { Component = ASPxGridViewExporter1 };
            report.chartContainer.PrintableComponent = new PrintableComponentLinkBase() { Component = ((IChartContainer)WebChartControl1).Printable };

            using (MemoryStream stream = new MemoryStream()) {
                report.CreateDocument();
                report.PrintingSystem.ExportToPdf(stream);

                Response.ClearContent();
                Response.ContentType = "application/pdf";
                byte[] buffer = stream.GetBuffer();
                Response.OutputStream.Write(buffer, 0, (int)stream.Length);
                Response.Flush();
            }
        }
    }
}