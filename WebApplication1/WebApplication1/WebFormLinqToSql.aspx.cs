using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFormLinqToSql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           DemoOfLinqToSqlDataContext db = new DemoOfLinqToSqlDataContext();
            var query = from cust in db.Employees
                       
                        select new { cust.EmployeeID, cust.LastName };
           
            this.GridView1.DataSource = query;
            this.GridView1.DataBind();
        }
    }
}