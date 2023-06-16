Imports DevExpress.DataAccess
Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.Sql

' ...
Namespace QueryParametersRuntime

    Public Partial Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
            BindToData()
        End Sub

        Private Sub BindToData()
            ' Create a data source with the required connection parameters.   
            Dim connectionParameters As Access97ConnectionParameters = New Access97ConnectionParameters("../../Data/nwind.mdb", "", "")
            Dim ds As SqlDataSource = New SqlDataSource(connectionParameters)
            ' Create a query to access fields of the Products data table. 
            Dim query As TableQuery = New TableQuery("Products")
            query.AddTable("Products").SelectColumns("CategoryID", "ProductName")
            ' Add a query parameter to be used as a criterion for data source level data filtering.
            ' In this example the query parameter has the Expression type and contains
            ' a simple expression that references a value of a report parameter named "catID".
            Dim parameter As QueryParameter = New QueryParameter() With {.Name = "catID", .Type = GetType(Expression), .Value = New Expression("[Parameters.catID]", GetType(Integer))}
            query.Parameters.Add(parameter)
            query.FilterString = "CategoryID = ?catID"
            ds.Queries.Add(query)
            ' Assign the data source to the report.
            DataSource = ds
            DataMember = "Products"
            ' Bind report controls to appropriate data fields.
            xrLabel1.DataBindings.Add("Text", ds, "Products.CategoryID")
            xrLabel2.DataBindings.Add("Text", ds, "Products.ProductName")
        End Sub
    End Class
End Namespace
