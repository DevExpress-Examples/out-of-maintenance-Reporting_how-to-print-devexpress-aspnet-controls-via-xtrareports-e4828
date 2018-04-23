Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports DevExpress.XtraReports.UI

Namespace ExportAspControlsViaReports.App_Code
	Public Class Report1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private detailBand1 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Public gridContainer As DevExpress.XtraReports.UI.PrintableComponentContainer
		Public chartContainer As PrintableComponentContainer
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub InitializeComponent()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.chartContainer = New DevExpress.XtraReports.UI.PrintableComponentContainer()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.gridContainer = New DevExpress.XtraReports.UI.PrintableComponentContainer()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' detailBand1
			' 
			Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.chartContainer, Me.xrLabel1, Me.gridContainer})
			Me.detailBand1.HeightF = 444.7917F
			Me.detailBand1.Name = "detailBand1"
			' 
			' chartContainer
			' 
			Me.chartContainer.LocationFloat = New DevExpress.Utils.PointFloat(152.0833F, 309.3749F)
			Me.chartContainer.Name = "chartContainer"
			Me.chartContainer.SizeF = New System.Drawing.SizeF(298.9581F, 125.4167F)
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 3.125F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(649.9998F, 95.83334F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "This is an example of embedding DevExpress ASP.NET controls into an XtraReport."
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' gridContainer
			' 
			Me.gridContainer.LocationFloat = New DevExpress.Utils.PointFloat(152.0833F, 127.0833F)
			Me.gridContainer.Name = "gridContainer"
			Me.gridContainer.SizeF = New System.Drawing.SizeF(298.9582F, 125.4167F)
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' Report1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1})
			Me.Version = "13.1"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
	End Class
End Namespace