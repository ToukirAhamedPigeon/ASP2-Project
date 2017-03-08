using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void go(string a)
        {
            Session["UserType"] = a;
            Response.Redirect("~/"+a+"LogIn.aspx");
        }
        protected void DropDownListUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListUser.SelectedValue == "Customer")
            {
                go(DropDownListUser.SelectedValue);
                //Session["UserType"] = "Customer";
                //Response.Redirect("~/CustomerLogIn.aspx");
            }
            else if (DropDownListUser.SelectedValue == "Employee")
            {
                go(DropDownListUser.SelectedValue);
               // Session["UserType"] = "Employee";
               // Response.Redirect("~/EmployeeLogIn.aspx");
            }
            else if (DropDownListUser.SelectedValue == "Admin")
            {
                go(DropDownListUser.SelectedValue);
                //Session["UserType"] = "Admin";
                //Response.Redirect("~/AdminLogIn.aspx");
            }
            else
            {
                Session["UserType"] = null;
                Response.Redirect("~/Home.aspx");
            }
        }
    }
}