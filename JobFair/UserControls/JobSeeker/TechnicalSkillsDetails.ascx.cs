using BAL;
using System;
using System.Data;

namespace JobFair.UserControls.JobSeeker
{
    public partial class TechnicalSkillsDetails : System.Web.UI.UserControl
    {
        private DataSet ds = new DataSet();
        private TechnicalSkillsDetailsBAL technicalSkillsBAL = new TechnicalSkillsDetailsBAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ds = technicalSkillsBAL.TechnicalSkillsBAL();
                chkTechnicalLanguage.DataSource = ds;
                chkTechnicalLanguage.DataTextField = "TechnicalSkillName";
                chkTechnicalLanguage.DataValueField = "TechnicalSkillId";
                chkTechnicalLanguage.DataBind();


            }
        }
    }
}