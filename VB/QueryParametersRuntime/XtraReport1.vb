#Region "#reference"
Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.Configuration
Imports DevExpress.XtraReports.UI
' ...
#End Region ' #reference

Namespace QueryParametersRuntime
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

#Region "#code"
Public Sub New()
    InitializeComponent()
    BindToData()
End Sub

Private Sub BindToData()
    ' Create a data source with the required connection parameters.   
    Dim connectionParameters As New Access97ConnectionParameters("../../Data/nwind.mdb", "", "")
    Dim ds As New SqlDataSource(connectionParameters)

    ' Create a query to access fields of the Products data table. 
    Dim query As SelectQuery = SelectQueryFluentBuilder.AddTable("Products").SelectColumns("CategoryID", "ProductName").Build("Products")

    ' Add a query parameter to be used as a criterion for data source level data filtering.
    ' In this example the query parameter has the Expression type and contains
    ' a simple expression that references a value of a report parameter named "catID".
    Dim parameter As New QueryParameter() With { _
        .Name = "catID", _
        .Type = GetType(Expression), _
        .Value = New Expression("[Parameters.catID]", GetType(System.Int32)) _
    }
    query.Parameters.Add(parameter)
    query.FilterString = "CategoryID = ?catID"

    ds.Queries.Add(query)

    ' Assign the data source to the report.
    Me.DataSource = ds
    Me.DataMember = "Products"

    ' Bind report controls to appropriate data fields depending on the report's data binding mode.
    If Settings.Default.UserDesignerOptions.DataBindingMode = DataBindingMode.Bindings Then
        xrLabel1.DataBindings.Add("Text", ds, "Products.CategoryID")
        xrLabel2.DataBindings.Add("Text", ds, "Products.ProductName")
    Else
        xrLabel1.ExpressionBindings.Add(New ExpressionBinding("BeforePrint", "Text", "[CategoryID]"))
        xrLabel2.ExpressionBindings.Add(New ExpressionBinding("BeforePrint", "Text", "[ProductName]"))
    End If
End Sub
#End Region ' #code
    End Class
End Namespace
