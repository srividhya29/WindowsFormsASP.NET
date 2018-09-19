using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // this.NameLabel.Text = string.Format("Hi {0} ", this.PreviousPage.userName);
            if(this.PreviousPage != null){
                this.NameLabel.Text = $"Hi{this.PreviousPage.userName}";// c#6.2 feature uses string builder
            }
            else
            {
                Response.Redirect("~/WebForm1.aspx");
            }
            

        }
    }
}