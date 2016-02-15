using BAL;
using System;
using System.Collections.Generic;
using System.Data;

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

        }
    }
}