using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        internal string userName
        {
            get
            {
                return this.TxtName.Text;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickMe_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/WebForm2.aspx");
        }
    }
}