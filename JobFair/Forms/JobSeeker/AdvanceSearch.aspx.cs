using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class AdvanceSearch : System.Web.UI.Page
    {
        private string candidateId;
       
        protected void Page_Load(object sender, EventArgs e)
        {
           
            candidateId = Convert.ToString(Session["candidateId"]);
            //if (candidateId == "")
            //{
            //    //string message = "Sorry your session has been expired !!!!";
            //    //string url = "LogIn.aspx";
            //    //string script = "window.onload = function(){ alert('";
            //    //script += message;
            //    //script += "');";
            //    //script += "window.location = '";
            //    //script += url;
            //    //script += "'; }";
            //    //ClientScript.RegisterStartupScript(this.GetType(), "Redirect", script, true);
            //     Response.Redirect("LogIn.aspx");
        
            //}
          
            

            if (!IsPostBack)
            {
                BindState();
                BindIndustry();
            }
        }

        private void BindIndustry()
        {
            try
            {
                object ds;
                ds = AdvanceJobSearchBAL.GetIndustry();
                chkIndustry.DataSource = ds;
                chkIndustry.DataTextField = "IndustryName";
                chkIndustry.DataValueField = "IndustryId";
                chkIndustry.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object ds;
                int cityId = Convert.ToInt32(ddlCity.SelectedValue);
                ds = AdvanceJobSearchBAL.GetArea(cityId);
                chkarea.DataSource = ds;
                chkarea.DataTextField = "AreaName";
                chkarea.DataValueField = "AreaId";
                chkarea.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object ds;
                int stateId = Convert.ToInt32(ddlState.SelectedValue);
                ds = AdvanceJobSearchBAL.GetCity(stateId);
                ddlCity.DataSource = ds;
                ddlCity.DataTextField = "cityName";
                ddlCity.DataValueField = "cityID";
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Bind industry to dropdown and stored in database
        /// </summary>
       
      

        private void BindState()
        {
            try
            {
                object ds;
                AdvanceJobSearchBAL advaceJobSearchBAL = new AdvanceJobSearchBAL();
                ds = advaceJobSearchBAL.GetState();
                ddlState.DataSource = ds;
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateId";
                ddlState.DataBind();
                ddlState.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        ///  Searchrecord on click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnsearch_Click(object sender, EventArgs e)
        {
            AdvanceSearchDetailsEntity advanceSearchEntity = new AdvanceSearchDetailsEntity();
            advanceSearchEntity.KeySkill = txtkeyskill.Text.Trim();
            advanceSearchEntity.State = ddlState.SelectedValue.Trim();
            advanceSearchEntity.City = ddlCity.SelectedValue.Trim();
            advanceSearchEntity.Area = chkarea.SelectedValue.Trim();
            advanceSearchEntity.WorkExp = ddlWorkExperience.SelectedItem.Text.Trim();
            advanceSearchEntity.MinSalary = ddlMinSalary.SelectedItem.Text.Trim();
            advanceSearchEntity.MaxSalary = ddlMaxSalary.SelectedItem.Text.Trim();
            advanceSearchEntity.Industry = Convert.ToInt32(chkIndustry.SelectedValue.Trim());
            advanceSearchEntity.EmpStatus = chkEmploymentStatus.SelectedItem.Text.Trim();
            advanceSearchEntity.JobType = chkJobType.SelectedItem.Text.Trim();
            advanceSearchEntity.RecruitmentType = chkRecruitmentType.SelectedItem.Text.Trim();
            //AdvanceJobSearchBAL advancesearchBAL = new AdvanceJobSearchBAL();
           //DataSet result = advancesearchBAL.GetSearch(advanceSearchEntity);
            AdvanceSearchDetailsEntity  search = new AdvanceSearchDetailsEntity();
            Session["myObject"] = advanceSearchEntity;
            Response.Redirect("jobSearch.aspx");
        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string>GetRoles(string prefixText)
        {
            DataTable dt = new DataTable();

            AdvanceJobSearchBAL advanceSearchBAL = new AdvanceJobSearchBAL();
            dt = advanceSearchBAL.GetRoles(prefixText);
            List<string> rolename = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                rolename.Add(dt.Rows[i][1].ToString());
            }
            return rolename;
        }

       
        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }

      
        /// <summary>
        ///  Bind area to checkboxlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            var  selectedArea = chkarea.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
             txtarea.Text = string.Join(",", selectedArea.Select(x=>x.Text));
        }
        /// <summary>
        /// Bind industry to checkboxlist 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkIndustry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectIndustry = chkIndustry.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
            txtindusry.Text = string.Join(",",selectIndustry.Select(x=>x.Text));
        }
            
        protected void btnarea_Click(object sender, EventArgs e)
        {
            Panelarea.Visible = true;
         }
        
   }
                    
}
        









