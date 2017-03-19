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
    public partial class WebForm20 : System.Web.UI.Page
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
            Edit_Info master = (Edit_Info)this.Master;
            Label LabelACNO = (Label)master.FindControl("LabelACNO");
            TextBox TextBoxName = (TextBox)master.FindControl("TextBoxName");
            TextBox TextBoxDOB = (TextBox)master.FindControl("TextBoxDOB");
            TextBox TextBoxNIDNo = (TextBox)master.FindControl("TextBoxNIDNo");
            TextBox TextBoxPhone = (TextBox)master.FindControl("TextBoxPhone");
            TextBox TextBoxAddress = (TextBox)master.FindControl("TextBoxAddress");
            TextBox TextBoxEmail = (TextBox)master.FindControl("TextBoxEmail");
            LoadDB("Admin", "AdminId", 2000, 1);
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
            DataSet ds = (DataSet)Cache["DataSet"];
            DataRow[] dr = ds.Tables["Admin"].Select("AdminId = 2000");
            int status = 2000;
            foreach (DataRow row in dr)
            {
                if (status.Equals(row["AdminId"]))
                {
                    LabelACNO.Text = row["AdminId"].ToString();
                    TextBoxName.Text = row["Name"].ToString();
                    TextBoxDOB.Text=row["DOB"].ToString() ;
                    TextBoxNIDNo.Text = row["NIDNO"].ToString();
                    TextBoxPhone.Text = row["Phone"].ToString();
                    TextBoxAddress.Text = row["Address"].ToString();
                    TextBoxEmail.Text = row["Email"].ToString();//Session["UserId"];
                }
            }
            Cache["Dataset"] = ds;
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
         }*/

        private void UpdateDB()
        {
            Edit_Info master = (Edit_Info)this.Master;
            TextBox TextBoxName = (TextBox)master.FindControl("TextBoxName");
            TextBox TextBoxDOB = (TextBox)master.FindControl("TextBoxDOB");
            TextBox TextBoxNIDNo = (TextBox)master.FindControl("TextBoxNIDNo");
            TextBox TextBoxPhone = (TextBox)master.FindControl("TextBoxPhone");
            TextBox TextBoxAddress = (TextBox)master.FindControl("TextBoxAddress");
            TextBox TextBoxEmail = (TextBox)master.FindControl("TextBoxEmail");
            RadioButtonList RadioButtonListGender = (RadioButtonList)master.FindControl("RadioButtonListGender");
            RadioButtonList RadioButtonListNIDType = (RadioButtonList)master.FindControl("RadioButtonListNIDType");
            FileUpload fileup = (FileUpload)master.FindControl("FileUploadProPic");
            Label fileErr = (Label)master.FindControl("FileErr");
            string fileEx = System.IO.Path.GetExtension(fileup.FileName);
            string name = TextBoxName.Text + TextBoxPhone.Text;
            string filePath = Server.MapPath("~/Images/ProPic/" + name + fileEx);
            if (fileup.HasFile)
            {

                if (fileEx.ToLower() != ".jpeg" && fileEx.ToLower() != ".jpg" && fileEx.ToLower() != ".png")
                {
                    fileErr.Text = "Only .jpeg, .jpg and .png file is allowed";
                }
                else
                {
                    int filesize = fileup.PostedFile.ContentLength;
                    if (filesize > 4194304)
                    {
                        fileErr.Text = "File should be less than 4mb";
                    }
                    else
                    {
                        fileup.SaveAs(filePath);
                    }
                }
            }
            LoadDB("Admin", "AdminId", 2000, 1);
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
            DataSet ds = (DataSet)Cache["DataSet"];
           // DataRow dr =new DataRow( ds.Tables["Admin"]);
            // dr["ChangeId"] = "400001";
             DataRow[] row = ds.Tables["Admin"].Select("AdminId = 2000");
             int status = 2000;
             foreach (DataRow dr in row)
             {
                 if (status.Equals(dr["AdminId"]))
                 {
                     dr["Name"] = TextBoxName.Text;
                     dr["DOB"] = TextBoxDOB.Text; //Session["UserId"];
                     dr["Gender"] = RadioButtonListGender.SelectedValue; //Session["UserName"];
                     dr["NIDNO"] = TextBoxNIDNo.Text;
                     dr["NIDType"] = RadioButtonListNIDType.SelectedValue;
                     dr["Phone"] = TextBoxPhone.Text;
                     dr["Address"] = TextBoxAddress.Text; //Session["UserId"];
                     dr["Email"] = TextBoxEmail.Text; //Session["UserName"];
                     dr["ProPic"] = "~/Images/ProPic/" + name + fileEx;
                     Cache["Dataset"] = ds;
                     ds = (DataSet)Cache["DataSet"];
                     adapter = (SqlDataAdapter)Cache["Adapter"];
                     adapter.Update(ds.Tables["Admin"]);
                 }
             }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setData();
            }
        }

        protected void ButtonConfirm_Click(object sender, EventArgs e)
        {
            UpdateDB();
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/InfoAdmin.aspx");
        }
    }
}