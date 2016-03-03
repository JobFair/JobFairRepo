using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod()]
        public static List<string> GetKeywords(string prefixText)
        {
            try
            {
                DataTable dt = new DataTable();
                SearchJSBAL search = new SearchJSBAL();
                dt = search.GetTechnicalskillBAL(prefixText);
                List<string> skillname = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    skillname.Add(dt.Rows[i][1].ToString());
                }
                return skillname;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod()]
        public static List<string> GetCity(string prefixText)
        {
            try
            {
                DataTable dt = new DataTable();
                SearchJSBAL search = new SearchJSBAL();
                dt = search.GetCityBAL(prefixText);
                List<string> cityname = new List<string>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cityname.Add(dt.Rows[i][0].ToString());
                }
                return cityname;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSearchJob control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnSearchJob_Click(object sender, EventArgs e)
        {
            BindRepeater();
        }

        /// <summary>
        /// Bind data to rptrJobPost control
        /// </summary>
        private void BindRepeater()
        {
            try
            {
                AdvanceSearchDetailsEntity advanceSearchEntity = new AdvanceSearchDetailsEntity();
                SearchJSBAL searchBal = new SearchJSBAL();
                // Check if txtKeywords is equal to null
                if (txtKeywords.Text == "")
                {
                    advanceSearchEntity.KeySkill = null;
                }
                else
                {
                    advanceSearchEntity.KeySkill = txtKeywords.Text.Trim();
                }
                // Check if txtLocation is equal to null
                if (txtLocation.Text == "")
                {
                    advanceSearchEntity.City = null;
                }
                else
                {
                    advanceSearchEntity.City = txtLocation.Text.Trim();
                }
                // Check if ddlExperience is equal to null
                if (ddlExperience.SelectedValue == "" || ddlExperience.Text == "Experience")
                {
                    advanceSearchEntity.WorkExp = null;
                }
                else
                {
                    advanceSearchEntity.WorkExp = ddlExperience.SelectedValue.Trim();
                }
                // Check if ddlSalary is equal to null
                if (ddlSalary.SelectedValue == "" || ddlSalary.Text == "Salary")
                {
                    advanceSearchEntity.MaxSalary = null;
                }
                else
                {
                    advanceSearchEntity.MaxSalary = ddlSalary.SelectedValue.Trim();
                }
                DataSet dsSearch = new DataSet();
                dsSearch = searchBal.JobSearchBAL(advanceSearchEntity);
                // Check if dsSearch is not null
                if (dsSearch != null)
                {
                    // Set the datasource of the repeater
                    rptrJobPost.DataSource = dsSearch;
                    rptrJobPost.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void rptrJobPost_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            // Check if commandname equal to contact
            if (e.CommandName == "Contact")
            {
                Label lbl = (Label)e.Item.FindControl("lblid");
                int jid = Convert.ToInt32(lbl.Text);
                Response.Redirect("ViewAllJobPost.aspx?jid=" + jid);
            }
        }

        protected void rptPaging_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            //PageNumber = Convert.ToInt32(e.CommandArgument) - 1;
            //BindRepeater();
        }

        //public int PageNumber
        //{
        //    get
        //    {
        //        if (ViewState["PageNumber"] != null)
        //        {
        //            return Convert.ToInt32(ViewState["PageNumber"]);
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    set { ViewState["PageNumber"] = value; }
        //}
    }
}