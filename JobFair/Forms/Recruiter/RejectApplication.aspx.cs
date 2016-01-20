using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using System.Data;

namespace JobFair.Forms.Recruiter
{
    public partial class RejectApplication : System.Web.UI.Page
    {
        public string candidateId="1";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                BindRejectApplication(candidateId);
            }
        }

        private void BindRejectApplication(string candidateId)
        {

            DataSet dsrejectapplication = new DataSet();
            RejectApplicationBAL rejectapplicationBAL = new RejectApplicationBAL();
            dsrejectapplication = rejectapplicationBAL.GetRejectApplication(candidateId);
            rptrRejectApplication.DataSource = dsrejectapplication;
            rptrRejectApplication.DataBind();
        }
    }
}