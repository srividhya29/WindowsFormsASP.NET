using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DemoOfDataBinding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (NorthwindDataSet ds = new NorthwindDataSet())
            {
                using (WebApplication1.NorthwindDataSetTableAdapters.EmployeesTableAdapter taEmployee
                    = new NorthwindDataSetTableAdapters.EmployeesTableAdapter())
                {
                    //we use adapter only when we use ado.net not while linq to sql. fill is a method in table adatpter to fill the adapter with the data
                    taEmployee.Fill(ds.Employees);
                    this.GridView1.DataSource = ds.Employees;//the data source for this grid is from the dataset
                    this.GridView1.DataBind();// for populating the data
                }

            }
        }
    }
}