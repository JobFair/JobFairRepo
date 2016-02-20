using BAL;
using Entities.JobSeeker;
using System;
using System.Collections;
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

        protected void btnSearchJob_Click(object sender, EventArgs e)
        {
            BindRepeater();
        }

        private void BindRepeater()
        {
            try
            {
                AdvanceSearchDetailsEntity advanceSearchEntity = new AdvanceSearchDetailsEntity();
                SearchJSBAL searchBal = new SearchJSBAL();
                // advanceSearchEntity.KeySkill = txtkeyskill.Text.Trim();
                if (txtKeywords.Text == "")
                {
                    advanceSearchEntity.KeySkill = null;
                }
                else
                {
                    advanceSearchEntity.KeySkill = txtKeywords.Text.Trim();
                }

                if (txtLocation.Text == "")
                {
                    advanceSearchEntity.City = null;
                }
                else
                {
                    advanceSearchEntity.City = txtLocation.UniqueID.ToString();
                }

                if (ddlExperience.SelectedValue == "" || ddlExperience.Text == "Experience")
                {
                    advanceSearchEntity.WorkExp = null;
                }
                else
                {
                    advanceSearchEntity.WorkExp = ddlExperience.SelectedValue.Trim();
                }

                if (ddlSalary.SelectedValue == "" || ddlSalary.Text == "Salary")
                {
                    advanceSearchEntity.MaxSalary = null;
                }
                else
                {
                    advanceSearchEntity.MaxSalary = ddlSalary.SelectedValue.Trim();
                }
                DataSet ds = new DataSet();
                ds = searchBal.JobSearchBAL(advanceSearchEntity);
                //rptrJobPost.DataSource = ds;
                //rptrJobPost.DataBind();

                //PagedDataSource pgitems = new PagedDataSource();
                ////pgitems.DataSource = ds.DefaultView;
                //pgitems.AllowPaging = true;

                ////Control page size from here
                //pgitems.PageSize = 2;
                //pgitems.CurrentPageIndex = PageNumber;
                //if (pgitems.PageCount > 1)
                //{
                //    rptPaging.Visible = true;
                //    ArrayList pages = new ArrayList();
                //    for (int i = 0; i <= pgitems.PageCount - 1; i++)
                //    {
                //        pages.Add((i + 1).ToString());
                //    }
                //    rptPaging.DataSource = pages;
                //    rptPaging.DataBind();
                //}
                //else
                //{
                //    rptPaging.Visible = true;
                //}

                //Finally, set the datasource of the repeater
                rptrJobPost.DataSource = ds;
                rptrJobPost.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void rptrJobPost_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
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