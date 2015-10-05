using BAL;
using CommonUtil;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class jobSearch : System.Web.UI.Page
    {
        private DataSet ds = new DataSet();
          private EducationalDetailsBAL educationalDetails = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //GetDataFromSession();
            if (!Page.IsPostBack)
            {
                FillIndustryCheckBoxList();
                fillLocationCheckboxList();
                FiillRoleesChecboxList();
                FillFunctionalAreaCheckboxList();
                FiilEducationCheckboxList();
                BindRepeaterData();
            }
        }

        private void FillIndustryCheckBoxList()

        {
            ds = JobSearchBAL.GetIndustry();
            chkIndustry.DataSource = ds;
            chkIndustry.DataTextField = "IndustryName";
            chkIndustry.DataValueField = "IndustryId";
            chkIndustry.DataBind();
        }

        private void FiillRoleesChecboxList()
        {
            ds = JobSearchBAL.GetRoles();
            chkRole.DataSource = ds;
            chkRole.DataTextField = "roleName";
            chkRole.DataValueField = "roleId";
            chkRole.DataBind();
        }

        private void FillFunctionalAreaCheckboxList()
        {
            ds = JobSearchBAL.GetFunctionalArea();
            chkFunctArea.DataSource = ds;
            chkFunctArea.DataTextField = "FunctionalArea";
            chkFunctArea.DataValueField = "FunctionalAreaId";
            chkFunctArea.DataBind();
        }

        private void fillLocationCheckboxList()
        {
            ds = JobSearchBAL.GetLocation();
            chkLocation.DataSource = ds;
            chkLocation.DataTextField = "location";
            chkLocation.DataValueField = "locationId";
            chkLocation.DataBind();
        }

        private void FiilEducationCheckboxList()
        {
            educationalDetails = new EducationalDetailsBAL();
            DataSet degreeData = new DataSet();
            // Get educational degree type details
            degreeData = educationalDetails.GetEducationalDegreeTypeBAL();
            chkEducation.DataSource = degreeData;
            chkEducation.DataTextField = "degreeType";
            chkEducation.DataValueField = "degreeId";
            chkEducation.DataBind();
        }

        protected void BindRepeaterData()
        {
            SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123");
            con.Open();
            SqlCommand cmd = new SqlCommand("select  JobTitle,JobLocationCity,CompanyLevel,IndustryId,DepartmentId,FunctionalAreaId,JobDescription,WorkExprience,PostedDate from RE_JobPost", con);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
            con.Close();
        }

        protected void chkFreshness_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write((sender as CheckBoxList).SelectedValue);
        }

        protected void chkLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Text = "You Selected:<br /><i>";
            foreach (ListItem li in chkLocation.Items)
            {
                if (li.Selected == true)
                {
                    Label2.Text += li.Text + "<br />";
                }
            }
            Label2.Text += "</i>";
        }

        protected void chkRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label2.Text = "You Selected:";
            foreach (ListItem li in chkRole.Items)
            {
                if (li.Selected == true)
                {
                    Label3.Text += li.Text;
                
                }
            }
          
        }

    }
}