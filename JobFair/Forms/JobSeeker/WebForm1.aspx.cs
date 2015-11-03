using BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using BAL;

namespace JobFair.Forms.JobSeeker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string candidateId;
        protected void Page_Load(object sender, EventArgs e)
        {
            BindCity();
            candidateId = Convert.ToString(Session["candidateId"]);
            Response.Write(candidateId);
        }

        private void BindCity()
        {
            DataSet ds = new DataSet();
            CurrentDesiredJobBAL obj=new BAL.CurrentDesiredJobBAL();
            ds = obj.GetCity();
            ddlchbCity.DataSource=ds;
            ddlchbCity.DataTextField = "CityName";
            ddlchbCity.DataValueField = "CityId";
            ddlchbCity.DataBind();

        }
        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> Getcity(string prefixText)
        {
            //DataTable dt = new DataTable();

            //AdvanceJobSearchBAL advanceSearchBAL = new AdvanceJobSearchBAL();
            //dt = advanceSearchBAL.GetTechnicalSkillBAL(prefixText);
            //List<string> TechnicalSkillName = new List<string>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    TechnicalSkillName.Add(dt.Rows[i][2].ToString());
            //}
            //return TechnicalSkillName;
            DataTable dt = new DataTable();
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            dt = currentDesiredJobBAL.GetPreferredCityBAL(prefixText);
            List<string> cityList = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cityList.Add(dt.Rows[i][1].ToString());
            }
            return cityList;

        }
    }
}