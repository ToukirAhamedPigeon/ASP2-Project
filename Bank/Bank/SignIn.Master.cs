using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank
{
    public partial class SignIn : System.Web.UI.MasterPage
    {
       /* public void LoadDB(string table, string primary, int seed, int step)
        {
            string sql = "SELECT * FROM " + table;
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds, table);
            ds.Tables[table].PrimaryKey = new DataColumn[] { ds.Tables[table].Columns[primary] };
            DataColumn[] dc = ds.Tables[table].PrimaryKey;
            foreach (DataColumn coulmn in dc)
            {
                coulmn.AutoIncrement = true;
                //coulmn.AutoIncrementSeed = seed;
                coulmn.AutoIncrementStep = step;
            }
            Cache["DataSet"] = ds;
            Cache["Adapter"] = adapter;
        }
        private void setData()
        {

        }
        /*private void UpdateDB()
        {
            LoadDB("BankStatus", "StatusId", 1, 1);
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
            DataSet ds = (DataSet)Cache["DataSet"];
            DataRow[] dr = ds.Tables["BankStatus"].Select("StatusId = '1'");
            int status = 1;
            foreach (DataRow row in dr)
            {
                if (status.Equals(row["StatusId"]))
                {
                    row["LoanStatus"] = TextBoxLoanStatus.Text;
                    row["Notice"] = TextBoxNotice.Text;
                }
            }
            Cache["Dataset"] = ds;
            ds = (DataSet)Cache["DataSet"];
            adapter = (SqlDataAdapter)Cache["Adapter"];
            adapter.Update(ds.Tables["BankStatus"]);
        }

        private void InsertDB()
        {
            LoadDB("ChangeStatus", "ChangeId", 400004, 1);
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
            DataSet ds = (DataSet)Cache["DataSet"];
            DataRow dr = ds.Tables["ChangeStatus"].NewRow();
            // dr["ChangeId"] = "400001";
            dr["ChangeTime"] = DateTime.Now;
            dr["ChangerId"] = "2000"; //Session["UserId"];
            dr["ChangerName"] = "Pigeon"; //Session["UserName"];
            dr["LoanStatus"] = TextBoxLoanStatus.Text;
            dr["Notice"] = TextBoxNotice.Text;
            ds.Tables["ChangeStatus"].Rows.Add(dr);
            Cache["Dataset"] = ds;
            ds = (DataSet)Cache["DataSet"];
            adapter = (SqlDataAdapter)Cache["Adapter"];
            adapter.Update(ds.Tables["ChangeStatus"]);
        }
        private void alert()
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Change Updated Successfully')", true);
        }*/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] == null)
            {
                Response.Redirect("~/Home.aspx");
            }
        }

      /*  protected void ImageButtonSignIn_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["UserType"] == "Customer")
            {
                LoadDB("Customer", "CustomerId", 1, 1);
                SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
                DataSet ds = (DataSet)Cache["DataSet"];
                DataRow[] dr = ds.Tables["Customer"].Select("CustomerId =" + Convert.ToInt32(TextBoxAccNo.Text));
                int status = Convert.ToInt32(TextBoxAccNo.Text);
                foreach (DataRow row in dr)
                {
                    if (status.Equals(row["CustomerId"]))
                    {
                        if (TextBoxPass.Text == row["Password"].ToString())
                        {
                            Session["UserId"] = Convert.ToInt32(TextBoxAccNo.Text);
                            Session["Propic"] = row["ProPic"];
                            Response.Redirect("~/InfoCustomer.aspx");
                        }
                        else
                        {
                            Response.Redirect("~/SignInCustomer.aspx");
                        }
                    }
                }
                Cache["Dataset"] = ds;
            }
            else if (Session["UserType"] == "Admin")
            {
                LoadDB("Admin", "AdminId", 1, 1);
                SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
                DataSet ds = (DataSet)Cache["DataSet"];
                DataRow[] dr = ds.Tables["Admin"].Select("AdminId =" + Convert.ToInt32(TextBoxAccNo.Text));
                int status = Convert.ToInt32(TextBoxAccNo.Text);
                foreach (DataRow row in dr)
                {
                    if (status.Equals(row["AdminId"]))
                    {
                        if (row["Password"].ToString() == TextBoxPass.Text)
                        {
                            /*Session["UserId"] = Convert.ToInt32(TextBoxAccNo.Text);
                            Session["Propic"] = row["ProPic"];
                            Response.Redirect("~/InfoAdmin.aspx");
                        }
                        else
                        {
                            Response.Redirect("~/SignInAdmin.aspx");
                        }
                    }
                }
            }
            else
            {
                LoadDB("Employee", "EmployeeId", 1, 1);
                SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
                DataSet ds = (DataSet)Cache["DataSet"];
                DataRow[] dr = ds.Tables["Employee"].Select("EmployeeId =" + Convert.ToInt32(TextBoxAccNo.Text));
                int status = Convert.ToInt32(TextBoxAccNo.Text);
                foreach (DataRow row in dr)
                {
                    if (status.Equals(row["EmployeeId"]))
                    {
                        if (row["Password"].ToString() == TextBoxPass.Text)
                        {
                            /*Session["UserId"] = Convert.ToInt32(TextBoxAccNo.Text);
                            Session["Propic"] = row["ProPic"];
                            Response.Redirect("~/InfoAdmin.aspx");
                        }
                        else
                        {
                            Response.Redirect("~/SignInEmployee.aspx");
                        }
                    }*/
                }
            }
        