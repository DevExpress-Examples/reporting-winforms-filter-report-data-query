using DevExpress.DataAccess;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
// ...

namespace QueryParametersRuntime {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
            BindToData();
        }

        private void BindToData() {
            // Create a data source with the required connection parameters.   
            Access97ConnectionParameters connectionParameters =
                new Access97ConnectionParameters("../../Data/nwind.mdb", "", "");
            SqlDataSource ds = new SqlDataSource(connectionParameters);

            // Create a query to access fields of the Products data table. 
            TableQuery query = new TableQuery("Products");
            query.AddTable("Products").SelectColumns("CategoryID", "ProductName");

            // Add a query parameter to be used as a criterion for data source level data filtering.
            // In this example the query parameter has the Expression type and contains
            // a simple expression that references a value of a report parameter named "catID".
            QueryParameter parameter = new QueryParameter() {
                Name = "catID",
                Type = typeof(Expression),
                Value = new Expression("[Parameters.catID]", typeof(System.Int32))
            };
            query.Parameters.Add(parameter);
            query.FilterString = "CategoryID = ?catID";

            ds.Queries.Add(query);

            // Assign the data source to the report.
            this.DataSource = ds;
            this.DataMember = "Products";

            // Bind report controls to appropriate data fields.
            xrLabel1.DataBindings.Add("Text", ds, "Products.CategoryID");
            xrLabel2.DataBindings.Add("Text", ds, "Products.ProductName");
        }
    }
}
