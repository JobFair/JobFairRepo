using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using BAL;
using System.Collections.Generic;


namespace JobFair.Forms.JobSeeker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string candidateId;
        protected void Page_Load(object sender, EventArgs e)
        {

            //candidateId = Convert.ToString(Session["candidateId"]);
            //Response.Write(candidateId);
        }
        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> GetCity(string PrefixText)
        {
            DataTable dt = new DataTable();
            CurrentDesiredJobBAL currentDesiredJobBAL = new CurrentDesiredJobBAL();
            dt = currentDesiredJobBAL.GetPreferredCityBAL(PrefixText);
            List<string> cityList = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cityList.Add(dt.Rows[i][1].ToString());
            }
            return cityList;
        }
     
    }
}