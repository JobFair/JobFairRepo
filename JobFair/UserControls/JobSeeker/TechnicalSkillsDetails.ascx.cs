using BAL;
using System;
using System.Data;
using System.Web.UI.WebControls;

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

        protected void chkTechnicalLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            for (int chkcount = 0; chkcount < chkTechnicalLanguage.Items.Count; chkcount++) 
            {
                if (chkTechnicalLanguage.Items[chkcount].Selected)
                {
                    Panel1.Visible = true;
                    break;
                }
                else 
                {
                    Panel1.Visible = false;
                }
                  //  lblCheckBoxList.Text += ", " + chkTechnicalLanguage.Items[chkcount].Text; 
            }

            }
              
        
    }
}