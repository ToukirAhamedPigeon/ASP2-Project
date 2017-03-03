using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank
{
    public partial class HomeBtn : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButtonHome_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }
    }
}