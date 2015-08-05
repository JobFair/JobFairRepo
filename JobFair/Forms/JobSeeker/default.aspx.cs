using BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = GetCandidateData("0014");
            GridView.DataSource = ds;
            GridView.DataBind();
        }

        public DataSet GetCandidateData(string id)
        {
            DataSet ds = new DataSet();
            CandidateBAL candidate = new CandidateBAL();
            ds= candidate.GetCandidateDataById(id);           
            return ds;
        }

    }
}