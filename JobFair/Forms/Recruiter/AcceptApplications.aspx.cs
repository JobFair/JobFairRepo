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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public  int candidateId ='1';
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindAcceptCandidate(candidateId);

            }
        }
        /// <summary>
        ///  Bind Accept  candidate to repeater 
        /// </summary>
        /// <param name="candidateId"></param>

        private void BindAcceptCandidate(int candidateId)
        {
            try
            {
                DataSet dsAcceptApplications = new DataSet();
                AcceptApplicationsBAL acceptapplicationBAL = new AcceptApplicationsBAL();
                dsAcceptApplications = acceptapplicationBAL.GetAcceptCandidate(candidateId);
                rptrAcceptApplication.DataSource = dsAcceptApplications;
                rptrAcceptApplication.DataBind();
             

            }
            catch (Exception)
            {
                
                throw;
            }
          
        }
    }
}