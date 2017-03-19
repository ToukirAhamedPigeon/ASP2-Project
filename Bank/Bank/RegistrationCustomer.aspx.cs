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
    public partial class WebForm22 : System.Web.UI.Page
    {
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
        /*private void setData()
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
        */
         private void InsertDB()
        {
            Registration master = (Registration)this.Master;
            TextBox TextBoxName = (TextBox)master.FindControl("TextBoxName");
            TextBox TextBoxDOB = (TextBox)master.FindControl("TextBoxDOB");
            TextBox TextBoxNIDNo = (TextBox)master.FindControl("TextBoxNIDNo");
            TextBox TextBoxPhone = (TextBox)master.FindControl("TextBoxPhone");
            TextBox TextBoxAddress = (TextBox)master.FindControl("TextBoxAddress");
            TextBox TextBoxEmail = (TextBox)master.FindControl("TextBoxEmail");
            RadioButtonList RadioButtonListGender = (RadioButtonList)master.FindControl("RadioButtonListGender");
            RadioButtonList RadioButtonListNIDType = (RadioButtonList)master.FindControl("RadioButtonListNIDType");
            FileUpload fileup = (FileUpload)master.FindControl("FileUploadProPic");
            //FileUpload Nomfileup = (FileUpload)master.FindControl("FileUploadNomProPic");
            Label fileErr = (Label)master.FindControl("FileErr");
            string fileEx = System.IO.Path.GetExtension(fileup.FileName);
            string name = TextBoxName.Text+TextBoxPhone.Text;
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
            string fileExNom = System.IO.Path.GetExtension(FileUploadNomProPic.FileName);
            string nameNom = TextBoxNomName.Text + TextBoxNomPhone.Text;
            string filePathNom = Server.MapPath("~/Images/ProPic/" + nameNom + fileExNom);
            if (FileUploadNomProPic.HasFile)
            {

                if (fileExNom.ToLower() != ".jpeg" && fileExNom.ToLower() != ".jpg" && fileExNom.ToLower() != ".png")
                {
                    fileErr.Text = "Only .jpeg, .jpg and .png file is allowed";
                }
                else
                {
                    int filesize = FileUploadNomProPic.PostedFile.ContentLength;
                    if (filesize > 4194304)
                    {
                        fileErr.Text = "File should be less than 4mb";
                    }
                    else
                    {
                        FileUploadNomProPic.SaveAs(filePathNom);
                    }
                }
            }
            LoadDB("Customer", "CustomerId", 10000000, 1);
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["Adapter"];
            DataSet ds = (DataSet)Cache["DataSet"];
            DataRow dr = ds.Tables["Customer"].NewRow();
            // dr["ChangeId"] = "400001";
            dr["CustomerName"] = TextBoxName.Text;
            dr["DOB"] = TextBoxDOB.Text; //Session["UserId"];
            dr["Gender"] =RadioButtonListGender.SelectedValue; //Session["UserName"];
            dr["NIDNO"] = TextBoxNIDNo.Text;
            dr["NIDType"] = RadioButtonListNIDType.SelectedValue;
            dr["Phone"] = TextBoxPhone.Text;
            dr["Address"] = TextBoxAddress.Text; //Session["UserId"];
            dr["Email"] = TextBoxEmail.Text; //Session["UserName"];
            dr["ProPic"] = "~/Images/ProPic/" + name + fileEx;
            dr["JoinDate"] = DateTime.Now;
            dr["LeaveDate"] = "Pigeon"; //Session["UserName"];
            dr["Password"] =passgenaretor();
            dr["AddedById"] = 2000;
            dr["AddedByName"] = "Pigeon"; //Session["UserName"];
            dr["AccountType"] = RadioButtonList1.SelectedValue;
            dr["NominyName"] = TextBoxNomName.Text;
            dr["NominyDOB"] = TextBoxNomDOB.Text; //Session["UserId"];
            dr["NominyGender"] = RadioButtonListNomGender.SelectedValue; //Session["UserName"];
            dr["NominyNIDNO"] = TextBoxNomNIDNo.Text;
            dr["NominyNIDType"] = RadioButtonListNomNIDType.SelectedValue;
            dr["NominyPhone"] = TextBoxNomPhone.Text;
            dr["NominyAddress"] = TextBoxNomAddress.Text; //Session["UserId"];
            dr["NominyEmail"] = TextBoxNomEmail.Text; //Session["UserName"];
            dr["NominyProPic"] = "~/Images/ProPic/" + nameNom + fileExNom;
            dr["TotalBalance"] = "500";
            ds.Tables["Customer"].Rows.Add(dr);
            Cache["Dataset"] = ds;
            ds = (DataSet)Cache["DataSet"];
            adapter = (SqlDataAdapter)Cache["Adapter"];
            adapter.Update(ds.Tables["Customer"]);
            alert();
        }
        public string passgenaretor()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void alert()
        {
            DataSet ds = (DataSet)Cache["DataSet"];
            DataRow lr = ds.Tables["Customer"].Rows[ds.Tables["Customer"].Rows.Count - 1];
            DataRow lrt = ds.Tables["Customer"].Rows[ds.Tables["Customer"].Rows.Count - 2];
            int Id=(int)lrt["CustomerId"]+1;
            string password=(string)lr["Password"];
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('ID="+Id+" Password="+password+"')", true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            InsertDB();
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Registration master = (Registration)this.Master;
            TextBox TextBoxName = (TextBox)master.FindControl("TextBoxName");
            TextBox TextBoxDOB = (TextBox)master.FindControl("TextBoxDOB");
            TextBox TextBoxNIDNo = (TextBox)master.FindControl("TextBoxNIDNo");
            TextBox TextBoxPhone = (TextBox)master.FindControl("TextBoxPhone");
            TextBox TextBoxAddress = (TextBox)master.FindControl("TextBoxAddress");
            TextBox TextBoxEmail = (TextBox)master.FindControl("TextBoxEmail");
            RadioButtonList RadioButtonListGender = (RadioButtonList)master.FindControl("RadioButtonListGender");
            RadioButtonList RadioButtonListNIDType = (RadioButtonList)master.FindControl("RadioButtonListNIDType");
            FileUpload fileup = (FileUpload)master.FindControl("FileUploadProPic");
            FileUpload Nomfileup = (FileUpload)master.FindControl("FileUploadNomProPic");
            Label fileErr = (Label)master.FindControl("FileErr");
             TextBoxName.Text="";
             TextBoxDOB.Text=""; //Session["UserId"];
             RadioButtonListGender.SelectedIndex=-1; //Session["UserName"];
             TextBoxNIDNo.Text="";
             RadioButtonListNIDType.SelectedIndex=-1;
             TextBoxPhone.Text="";
             TextBoxAddress.Text=""; //Session["UserId"];
             TextBoxEmail.Text=""; //Session["UserName"];
             RadioButtonList1.SelectedIndex=-1;
             TextBoxNomName.Text="";
             TextBoxNomDOB.Text=""; //Session["UserId"];
             RadioButtonListNomGender.SelectedIndex=-1; //Session["UserName"];
             TextBoxNomNIDNo.Text="";
             RadioButtonListNomNIDType.SelectedIndex=-1;
             TextBoxNomPhone.Text="";
             TextBoxNomAddress.Text=""; //Session["UserId"];
             TextBoxNomEmail.Text=""; //Session["UserName"];
        }

        protected void CalendarNominy_SelectionChanged(object sender, EventArgs e)
        {
            TextBoxNomDOB.Text = CalendarNominy.SelectedDate.ToString();
        }
    }
}