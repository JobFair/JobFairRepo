using BAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class jobSearch : System.Web.UI.Page
    {
        private EducationalDetailsBAL educationalDetails = null;
        public string keySkill, city, state, experience, minSalary, maxSalary, candidateId;

        protected void Page_Load(object sender, EventArgs e)
        {
            candidateId = Convert.ToString(Session["candidateId"]);
            if (candidateId == "")
            {
                string message = "Sorry your session has been expired !!!!";
                string url = "LogIn.aspx";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "');";
                script += "window.location = '";
                script += url;
                script += "'; }";
                ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
                // Response.Redirect("LogIn.aspx");
            }
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
            minSalary = Request.QueryString["minSalary"];
            maxSalary = Request.QueryString["maxSalary"];
            rptr_bind();
            rptrJobPost.Visible = true;
        }

        private void rptr_bind()
        {
            DataSet ds = new DataSet();
            JobSearchBAL jobSearchBAL = new JobSearchBAL();
            ds = jobSearchBAL.JobSearch(keySkill, city, experience, minSalary, maxSalary);
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
           
        }


        protected void chkRole_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }


        /// <summary>
        /// Filter used for Company Level
        /// </summary>
        private void BindRept()
        {
            string conString = ConfigurationManager.ConnectionStrings["JobPortalCon"].ConnectionString;
            string query = "SELECT * FROM RE_JobPost";

            string condition = string.Empty;
            foreach (ListItem item in chkCompanyLevel.Items)
            {
                condition += item.Selected ? string.Format("'{0}',", item.Value) : "";
            }
            if (!string.IsNullOrEmpty(condition))
            {
                condition = string.Format(" where CompanyLevel in ({0})", condition.Substring(0, condition.Length - 1));
            }
            SqlCommand cmd = new SqlCommand(query + condition);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    sda.SelectCommand = cmd;
                    using (DataSet ds = new DataSet())
                    {
                        sda.Fill(ds);
                        rptrJobPost.DataSource = ds;
                        rptrJobPost.DataBind();
                    }
                }
            }
        }

        protected void chkCompanyLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BindRept();
        }


        /// <summary>
        /// Filter used for Industry
        /// </summary>
        private void BindreptIndustry()
        {
            string conString = ConfigurationManager.ConnectionStrings["JobPortalCon"].ConnectionString;
            string query = "SELECT * FROM RE_JobPost";

            string condition = string.Empty;
            foreach (ListItem item in chkIndustry.Items)
            {
                condition += item.Selected ? string.Format("'{0}',", item.Value) : "";
            }
            if (!string.IsNullOrEmpty(condition))
            {
                condition = string.Format(" where IndustryId in ({0})", condition.Substring(0, condition.Length - 1));
            }
            SqlCommand cmd = new SqlCommand(query + condition);
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;

                    sda.SelectCommand = cmd;
                    using (DataSet ds = new DataSet())
                    {
                        sda.Fill(ds);
                        rptrJobPost.DataSource = ds;
                        rptrJobPost.DataBind();
                    }
                }
            }
        }

        protected void chkIndustry_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BindreptIndustry();
        }
    }
}