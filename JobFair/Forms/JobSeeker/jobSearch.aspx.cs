using BAL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class jobSearch : System.Web.UI.Page
    {
        private EducationalDetailsBAL educationalDetails = null;
        public string keySkill, city, state, experience;

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetDataFromSession();
            if (!Page.IsPostBack)
            {
                BindIndustry();
                BindLocation();
                BindRoles();
                BindFunctionalArea();
                BindEducation();
            }
            keySkill = Request.QueryString["keySkills"];
            city = Request.QueryString["city"];
            experience = Request.QueryString["experience"];
            rptr_bind();
            rptrJobPost.Visible = true;
        }

        private void rptr_bind()
        {
            DataSet ds = new DataSet();
            JobSearchBAL jobSearchBAL = new JobSearchBAL();
            ds = jobSearchBAL.JobSearch(keySkill, city, experience);
            rptrJobPost.DataSource = ds;
            rptrJobPost.DataBind();
        }

        private void BindIndustry()
        {
            DataSet ds = new DataSet();
            ds = JobSearchBAL.GetIndustry();
            chkIndustry.DataSource = ds;
            chkIndustry.DataTextField = "IndustryName";
            chkIndustry.DataValueField = "IndustryId";
            chkIndustry.DataBind();
        }

        private void BindRoles()
        {
            DataSet ds = new DataSet();
            ds = JobSearchBAL.GetRoles();
            chkRole.DataSource = ds;
            chkRole.DataTextField = "roleName";
            chkRole.DataValueField = "roleId";
            chkRole.DataBind();
        }

        private void BindFunctionalArea()
        {
            DataSet ds = new DataSet();
            ds = JobSearchBAL.GetFunctionalArea();
            chkFunctArea.DataSource = ds;
            chkFunctArea.DataTextField = "FunctionalArea";
            chkFunctArea.DataValueField = "FunctionalAreaId";
            chkFunctArea.DataBind();
        }

        private void BindLocation()
        {
            DataSet ds = new DataSet();
            ds = JobSearchBAL.GetLocation();
            chkLocation.DataSource = ds;
            chkLocation.DataTextField = "location";
            chkLocation.DataValueField = "locationId";
            chkLocation.DataBind();
        }

        private void BindEducation()
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