Namespace QueryParametersRuntime
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.catID = New DevExpress.XtraReports.Parameters.Parameter()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
            Me.Detail.HeightF = 23F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 50F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 50F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.75F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(112.5F, 23F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.75F)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(112.5F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(370.5F, 23F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UsePadding = False
            Me.xrLabel2.Text = "xrLabel2"
            ' 
            ' catID
            ' 
            Me.catID.Description = "Category ID"
            Me.catID.Name = "catID"
            Me.catID.Type = GetType(Integer)
            Me.catID.ValueInfo = "1"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel4, Me.xrLabel3})
            Me.PageHeader.HeightF = 23F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(112.5F, 23F)
            Me.xrLabel3.StylePriority.UseFont = False
            Me.xrLabel3.StylePriority.UsePadding = False
            Me.xrLabel3.Text = "Category ID"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.75F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(112.5F, 0F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(370.5F, 23F)
            Me.xrLabel4.StylePriority.UseFont = False
            Me.xrLabel4.StylePriority.UsePadding = False
            Me.xrLabel4.Text = "Product Name"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader})
            Me.Margins = New DevExpress.Drawing.DXMargins(50, 50, 50, 50)
            Me.PageHeight = 827
            Me.PageWidth = 583
            Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A5
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.catID})
            Me.Version = "14.2"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private catID As DevExpress.XtraReports.Parameters.Parameter
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
