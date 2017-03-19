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
    public partial class WebForm4 : System.Web.UI.Page
    {

        public void LoadDB(string sql,string table, string primary, int seed, int step)
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
        private void setData()
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
            string sql = "SELECT * FROM Admin";
            LoadDB(sql,"Admin", "AdminId", 2000, 1);
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
            DataSet ds = (DataSet)Cache["DataSet"];
            DataRow[] dr = ds.Tables["Admin"].Select("AdminId = 2002");
            int status = 2002;
            foreach (DataRow row in dr)
            {
                if (status.Equals(row["AdminId"]))
                {
                    LabelID.Text = row["AdminId"].ToString();
                    LabelName.Text = (string)row["Name"];
                    LabelDob.Text = (string)row["DOB"];
                    LabelAddress.Text = (string)row["Address"];
                    LabelNID.Text = (string)row["NIDNO"];
                    LabelNIDType.Text = (string)row["NIDType"];
                    LabelPhone.Text = (string)row["Phone"];
                    LabelEmail.Text = (string)row["Email"];
                    LabelJoin.Text = (string)row["JoinDate"];
                    LabelLeave.Text = (string)row["LeaveDate"];
                    LabelStatus.Text = "Admin";
                    LabelAbout.Text = row["Message"].ToString();
                    /*LabelBalance.Text = (string)row["LoanStatus"];
                    LabelUsable.Text = (string)row["Notice"];*/
                }
            }
            Cache["Dataset"] = ds;
            sql = "SELECT * FROM BankStatus";
            LoadDB(sql,"BankStatus", "StatusId", 1, 1);
            adapter = (SqlDataAdapter)Cache["Adapter"];
            ds = (DataSet)Cache["DataSet"];
            dr = ds.Tables["BankStatus"].Select("StatusId = 1");
            status = 1;
            foreach (DataRow row in dr)
            {
                if (status.Equals(row["StatusId"]))
                {
                    LabelBalance.Text = row["TotalBalance"].ToString();
                }
            }
            Cache["Dataset"] = ds;

        }
        private void BindData()
        {

            string sql = "select * from ChangeStatus where (ChangerId=2000)";
                LoadDB(sql,"ChangeStatus", "ChangeId", 400000, 1);

            DataSet ds = (DataSet)Cache["DataSet"];
            GridViewWorkHistory.DataSource = ds.Tables["ChangeStatus"];
            GridViewWorkHistory.DataBind();
        }
       /* private void UpdateDB()
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
            if (!IsPostBack)
            {
                setData();
                BindData();
            }
        }

        protected void DropDownListAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListAction.SelectedValue == "Add New Customer")
            {
                Response.Redirect("~/RegistrationCustomer.aspx");
            }
            else if (DropDownListAction.SelectedValue == "Add New Employee")
            {
                Response.Redirect("~/RegistrationEmployee.aspx");
            }
            else if (DropDownListAction.SelectedValue == "Add New Admin")
            {
                Response.Redirect("~/RegistrationAdmin.aspx");
            }
        }
    }
}