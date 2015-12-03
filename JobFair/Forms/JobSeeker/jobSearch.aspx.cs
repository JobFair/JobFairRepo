using BAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using Entities.JobSeeker;
using System.Web.UI;

namespace JobFair.Forms.JobSeeker
{
    public partial class jobSearch : System.Web.UI.Page
    {
        private EducationalDetailsBAL educationalDetails = null;
        public string keySkill, city, state, experience, minSalary, maxSalary, candidateId;
        public int functionalArea;

        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["myObject"] != null)
            {
                DataSet ds = new DataSet();
                AdvanceSearchDetailsEntity advanceSearchEntity = (AdvanceSearchDetailsEntity)Session["myObject"];
                JobSearchBAL jobsearchBAL = new JobSearchBAL();
                ds = jobsearchBAL.GetSearch(advanceSearchEntity);
                rptrJobPost.DataSource = ds;
                rptrJobPost.DataBind();

                //   ds.Tables[0].Rows.Clear();
                //  Session["myObject"] = ds;
            }

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

            //    keySkill = Request.QueryString["keySkills"];
            //    city = Request.QueryString["city"];
            //    experience = Request.QueryString["experience"];
            //    minSalary = Request.QueryString["minSalary"];
            //    maxSalary = Request.QueryString["maxSalary"];
            //    functionalArea = Convert.ToInt32(Request.QueryString["functionalArea"]);
            //    rptr_bind();
            //    rptrJobPost.Visible = true;
        }

        //private void rptr_bind()
        //{
        //    DataSet ds = new DataSet();
        //    JobSearchBAL jobSearchBAL = new JobSearchBAL();
        //    ds = jobSearchBAL.JobSearch(keySkill, city, experience, minSalary, maxSalary,functionalArea);
        //    rptrJobPost.DataSource = ds;
        //    rptrJobPost.DataBind();
        //}

        private void BindIndustry()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = JobSearchBAL.GetIndustry();
                chkIndustry.DataSource = ds;
                chkIndustry.DataTextField = "IndustryName";
                chkIndustry.DataValueField = "IndustryId";
                chkIndustry.DataBind();

            }
            catch (Exception)
            {

                //  throw;
            }


        }

        private void BindRoles()
        {

            try
            {
                DataSet ds = new DataSet();
                ds = JobSearchBAL.GetRoles();
                chkRole.DataSource = ds;
                chkRole.DataTextField = "TechnicalSkillName";
                chkRole.DataValueField = "TechnicalSkillId";
                chkRole.DataBind();
            }
            catch (Exception)
            {

                // throw;
            }

        }

        private void BindFunctionalArea()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = JobSearchBAL.GetFunctionalArea();
                chkFunctArea.DataSource = ds;
                chkFunctArea.DataTextField = "FunctionalArea";
                chkFunctArea.DataValueField = "FunctionalAreaId";
                chkFunctArea.DataBind();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void BindLocation()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = JobSearchBAL.GetLocation();
                chkLocation.DataSource = ds;
                chkLocation.DataTextField = "location";
                chkLocation.DataValueField = "locationId";
                chkLocation.DataBind();
            }
            catch (Exception)
            {

                // throw;
            }
        }

        private void BindEducation()
        {
            try
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
            catch (Exception)
            {

                // throw;
            }

        }

        protected void chkFreshness_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Response.Write((sender as CheckBoxList).SelectedValue);
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
        //private void BindRept()
        //{
        //    string conString = ConfigurationManager.ConnectionStrings["JobPortalCon"].ConnectionString;
        //    string query = "SELECT * FROM RE_JobPost";

        //    string condition = string.Empty;
        //    foreach (ListItem item in chkCompanyLevel.Items)
        //    {
        //        condition += item.Selected ? string.Format("'{0}',", item.Value) : "";
        //    }
        //    if (!string.IsNullOrEmpty(condition))
        //    {
        //        condition = string.Format(" where CompanyLevel in ({0})", condition.Substring(0, condition.Length - 1));
        //    }
        //    SqlCommand cmd = new SqlCommand(query + condition);
        //    using (SqlConnection con = new SqlConnection(conString))
        //    {
        //        using (SqlDataAdapter sda = new SqlDataAdapter())
        //        {
        //            cmd.Connection = con;

        //            sda.SelectCommand = cmd;
        //            using (DataSet ds = new DataSet())
        //            {
        //                sda.Fill(ds);
        //                rptrJobPost.DataSource = ds;
        //                rptrJobPost.DataBind();
        //            }
        //        }
        //    }
        //}

        protected void chkCompanyLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //   this.BindRept();
        }

        protected void chkIndustry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void rptrJobPost_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Contact")
            {

                Label lbl = (Label)e.Item.FindControl("lblid");
                //Session["jobid"] = lbl.Text;
                //Server.Transfer("ViewAllJobPost.aspx");
                int jid = Convert.ToInt32(lbl.Text);
                //ScriptManager1.GetRegisteredStartupScripts(Page, typeof(Page), "OpenWindow", "Window.Open('ViewAllJobPost.aspx?jid=" + jid + "');");
                //string script = string.Format("window.Open('{0}');", "ViewAllJobPost.aspx?jid=" + jid);
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "newPage", script, true);
                Response.Redirect("ViewAllJobPost.aspx?jid=" + jid);
            }
        }

        //protected void btnapply_Click(object sender, EventArgs e)
        //
        //    System.Web.UI.WebControls.Label la = (System.Web.UI.WebControls.Label)rptrJobPost.FindControl("Label1");
        //    int jid =Convert.ToInt32( la.Text);
        // // int jobId= Convert.ToString(ds.Tables[0].Rows[0]["JobId"]);
        // Response.Redirect("ViewAllJobPost.aspx?jid=" + la);
        //}





        /// <summary>
        /// Filter used for Industry
        /// </summary>
        //private void BindreptIndustry()
        //{
        //    string conString = ConfigurationManager.ConnectionStrings["JobPortalCon"].ConnectionString;
        //    string query = "SELECT * FROM RE_JobPost";

        //    string condition = string.Empty;
        //    foreach (ListItem item in chkIndustry.Items)
        //    {
        //        condition += item.Selected ? string.Format("'{0}',", item.Value) : "";
        //    }
        //    if (!string.IsNullOrEmpty(condition))
        //    {
        //        condition = string.Format(" where IndustryId in ({0})", condition.Substring(0, condition.Length - 1));
        //    }
        //    SqlCommand cmd = new SqlCommand(query + condition);
        //    using (SqlConnection con = new SqlConnection(conString))
        //    {
        //        using (SqlDataAdapter sda = new SqlDataAdapter())
        //        {
        //            cmd.Connection = con;

        //            sda.SelectCommand = cmd;
        //            using (DataSet ds = new DataSet())
        //            {
        //                sda.Fill(ds);
        //                rptrJobPost.DataSource = ds;
        //                rptrJobPost.DataBind();
        //            }
        //        }
        //    }
        //}

        //protected void chkIndustry_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //   this.BindreptIndustry();
        //}

    }
}