using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.XtraReports.UI;

namespace ExportAspControlsViaReports.App_Code {
    public class Report1 : DevExpress.XtraReports.UI.XtraReport {

        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.PrintableComponentContainer gridContainer;
        public PrintableComponentContainer chartContainer;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;

        public Report1() {
            InitializeComponent();
        } 

        private void InitializeComponent() {
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.chartContainer = new DevExpress.XtraReports.UI.PrintableComponentContainer();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.gridContainer = new DevExpress.XtraReports.UI.PrintableComponentContainer();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.chartContainer,
            this.xrLabel1,
            this.gridContainer});
            this.detailBand1.HeightF = 444.7917F;
            this.detailBand1.Name = "detailBand1";
            // 
            // chartContainer
            // 
            this.chartContainer.LocationFloat = new DevExpress.Utils.PointFloat(152.0833F, 309.3749F);
            this.chartContainer.Name = "chartContainer";
            this.chartContainer.SizeF = new System.Drawing.SizeF(298.9581F, 125.4167F);
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.125F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(649.9998F, 95.83334F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "This is an example of embedding DevExpress ASP.NET controls into an XtraReport.";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // gridContainer
            // 
            this.gridContainer.LocationFloat = new DevExpress.Utils.PointFloat(152.0833F, 127.0833F);
            this.gridContainer.Name = "gridContainer";
            this.gridContainer.SizeF = new System.Drawing.SizeF(298.9582F, 125.4167F);
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // Report1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1});
            this.Version = "13.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}