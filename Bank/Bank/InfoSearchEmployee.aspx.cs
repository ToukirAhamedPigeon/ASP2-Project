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
    public partial class WebForm8 : System.Web.UI.Page
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
        public void LoadDB(string sql, string table, string primary, int seed, int step)
        {
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
        private void setData(int a)
        {
            Info master = (Info)this.Master;
            Label LabelID = (Label)master.FindControl("LabelID");
            Label LabelName = (Label)master.FindControl("LabelName");
            Label LabelDob = (Label)master.FindControl("LabelDob");
            Label LabelAddress = (Label)master.FindControl("LabelAddress");
            Label LabelNID = (Label)master.FindControl("LabelNID");
            Label LabelNIDType = (Label)master.FindControl("LabelNIDType");
            Label LabelPhone = (Label)master.FindControl("LabelPhone");
            Label LabelEmail = (Label)master.FindControl("LabelEmail");
            Label LabelJoin = (Label)master.FindControl("LabelNIDType");
            Label LabelLeave = (Label)master.FindControl("LabelLeave");
            string sql = "SELECT * FROM Employee";
            LoadDB(sql, "Employee", "EmployeeId", 300000, 1);
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
            DataSet ds = (DataSet)Cache["DataSet"];
            DataRow[] dr = ds.Tables["Employee"].Select("EmployeeId ="+a);
            int status = a;
            foreach (DataRow row in dr)
            {
                if (status.Equals(row["EmployeeId"]))
                {
                    LabelID.Text = row["EmployeeId"].ToString();
                    LabelName.Text = row["Name"].ToString();
                    ImageProfile.ImageUrl = row["ProPic"].ToString();
                    LabelDob.Text = row["DOB"].ToString();
                    LabelAddress.Text = row["Address"].ToString();
                    LabelNID.Text = row["NIDNO"].ToString();
                    LabelNIDType.Text = row["NIDType"].ToString();
                    LabelPhone.Text = row["Phone"].ToString();
                    LabelEmail.Text = row["Email"].ToString();
                    LabelJoin.Text = row["JoinDate"].ToString();
                    LabelLeave.Text = row["LeaveDate"].ToString();
                    LabelPost.Text = row["Post"].ToString();
                    LabelSalary.Text = row["Salary"].ToString();
                }
            }
            Cache["Dataset"] = ds;

        }
        private void BindData(int a)
        {

            string sql = "select * from Transactions where (ActorId="+a+")";
            LoadDB(sql, "Transactions", "TransactionID", 400000, 1);

            DataSet ds = (DataSet)Cache["DataSet"];
            GridViewWorkHistory.DataSource = ds.Tables["Transactions"];
            GridViewWorkHistory.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["Id"] != null)
                {
                    int a = Convert.ToInt32(Request["Id"]);
                    setData(a);
                    BindData(a);
                }
            }
        }
    }
}