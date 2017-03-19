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
    public partial class WebForm15 : System.Web.UI.Page
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
            LoadDB("BankStatus", "StatusId", 1, 1);
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
            DataSet ds = (DataSet)Cache["DataSet"];
            DataRow[] dr = ds.Tables["BankStatus"].Select("StatusId = '1'");
            int status = 1;
            foreach (DataRow row in dr)
            {
                if (status.Equals(row["StatusId"]))
                {
                    TextBoxLoanStatus.Text = (string)row["LoanStatus"];
                    TextBoxNotice.Text = (string)row["Notice"];
                }
            }
            Cache["Dataset"] = ds;
        }
        private void UpdateDB()
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
        public void LoadDB(string table, string primary, int seed, int step)
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
            Delete master = (Delete)this.Master;
            Label LabelACNO = (Label)master.FindControl("LabelACNO");
            Label LabelName = (Label)master.FindControl("LabelName");
            Label LabelPos = (Label)master.FindControl("LabelPos");
            LoadDB("Employee", "EmployeeId", 300000, 1);
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
            DataSet ds = (DataSet)Cache["DataSet"];
            DataRow[] dr = ds.Tables["Employee"].Select("EmployeeId = 300000");
            int status = 300000;
            foreach (DataRow row in dr)
            {
                if (status.Equals(row["EmployeeId"]))
                {
                    LabelACNO.Text = row["EmployeeId"].ToString();
                    LabelName.Text = row["Name"].ToString();
                    LabelPos.Text = "Employee";
                }
            }
            Cache["Dataset"] = ds;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setData();
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            LoadDB("Employee", "EmployeeId", 300000, 1);
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
            DataSet ds = (DataSet)Cache["DataSet"];
            DataRow[] dr = ds.Tables["Employee"].Select("EmployeeId = 300000");
            int status = 300000;
            foreach (DataRow row in dr)
            {
                if (status.Equals(row["EmployeeId"]))
                {
                    row["LeaveDate"] = DateTime.Now;
                    row["DeletedById"] = 2000;
                    row["DeletedByName"] = "Pigeon";
                }
            }
            Cache["Dataset"] = ds;
            ds = (DataSet)Cache["DataSet"];
            adapter = (SqlDataAdapter)Cache["Adapter"];
            adapter.Update(ds.Tables["Employee"]);
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/InfoAdmin.aspx");
        }
    }
}