using CommonUtil;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class jobSearch : System.Web.UI.Page
    {
        private DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetDataFromSession();
            if (!Page.IsPostBack)
            {
                FillIndustryCheckBoxList();
                FillcityCheckBoxList();
                BindDropDownIndustry();
                BindDropDownDepartment();
                BindDropDownFunctionalArea();
                BindRepeaterData();
            }
        }

        //private void GetDataFromSession()
        //{
        //    lblJobPost.Text = Session["JobPost"].ToString();

        //}
        private void BindDropDownIndustry()
        {
            ds = Utility.GetIndustry();
            ddlIndustry.DataSource = ds;
            ddlIndustry.DataTextField = "IndustryName";
            ddlIndustry.DataValueField = "IndustryId";
            ddlIndustry.DataBind();
            ddlIndustry.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void BindDropDownDepartment()
        {
            ds = Utility.GetDepartment();
            ddlDepartment.DataSource = ds;
            ddlDepartment.DataTextField = "DepartmentName";
            ddlDepartment.DataValueField = "DepartmentId";
            ddlDepartment.DataBind();
            ddlDepartment.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void BindDropDownFunctionalArea()
        {
            ddlFunArea.DataSource = Utility.GetFunctionalAreaBAL();
            ddlFunArea.DataTextField = "FunctionalArea";
            ddlFunArea.DataBind();
            ddlFunArea.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        private void FillIndustryCheckBoxList()
        {
            SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Industry", con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cblIndustry.DataSource = dt;
            cblIndustry.DataTextField = "IndustryName";
            cblIndustry.DataBind();
            con.Close();
        }

        private void FillcityCheckBoxList()
        {
            SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
            con.Open();
            SqlCommand Cmd = new SqlCommand("Select * from City", con);
            SqlDataAdapter adp = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            cblLocation.DataSource = dt;
            cblLocation.DataTextField = "CityName";
            cblLocation.DataBind();
            con.Close();
        }

        protected void BindRepeaterData()
        {
            SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from RE_JobPost", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            con.Close();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
        }

        protected void lnks_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("JobType", typeof(string));

            dt.Rows.Add("Link 1");
            dt.Rows.Add("Link 2");
            dt.Rows.Add("Link 3");
            dt.Rows.Add("Link 4");


        }

        protected void btnsend_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM RE_JobPost", new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123"));

            cmd.Connection.Open();
            //Repeater1.DataSource = cmd.ExecuteReader();
            //Repeater1.DataBind();

            gvJobDetails.DataSource = cmd.ExecuteReader();
            gvJobDetails.DataBind();

            if (gvJobDetails.Rows.Count > 0)
            {
                lblTotalCount.Text = gvJobDetails.Rows.Count.ToString();
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();
        }

        protected void gvJobDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int JobId = 0;
            try
            {
                if (e.CommandName.Equals("SelectJob"))
                {
                    JobId = Convert.ToInt32(e.CommandArgument);

                    GridViewRow row = (GridViewRow)(((Control)e.CommandSource).NamingContainer);
                    
                    //Find Controls and bind corresponding values
                    Label lblCity = (Label)row.FindControl("lblCity");
                    Label lblJobLocationArea = (Label)row.FindControl("lblJobLocationArea");
                     


                }
            }
            catch (Exception ex)
            {
                //   throw;
            }
        }

        //protected void gvJobDetails_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    txtJobtitle.Text = gvJobDetails.SelectedRow.Cells[2].Text;
        //    txtJobDescription.Text = gvJobDetails.SelectedRow.Cells[9].Text;
        //    txtKeyRoles.Text = gvJobDetails.SelectedRow.Cells[10].Text;
        //    txtKeyTechnical.Text = gvJobDetails.SelectedRow.Cells[11].Text;
        //    txtAnnualSalary.Text = gvJobDetails.SelectedRow.Cells[14].Text;
        //    txtOtherSalary.Text = gvJobDetails.SelectedRow.Cells[15].Text;
        //    txtVacancies.Text = gvJobDetails.SelectedRow.Cells[16].Text;
        //}
    }
}