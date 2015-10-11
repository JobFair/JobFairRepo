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
                BindLannguage();
                BindDatabase();
                BindSoftwares();
                BindOperatingSystem();
            }
        }

        private void BindLannguage()
        {
            ds = technicalSkillsBAL.TechnicalSkillsLanguageBAL();
            chkTechnicalLanguage.DataSource = ds;
            chkTechnicalLanguage.DataTextField = "TechnicalSkillName";
            chkTechnicalLanguage.DataValueField = "TechnicalSkillId";
            chkTechnicalLanguage.DataBind();
        }

        private void BindDatabase()
        {
            ds = technicalSkillsBAL.DatabaseBAL();
            chkTechnicalDatabase.DataSource = ds;
            chkTechnicalDatabase.DataTextField = "TechnicalSkillName";
            chkTechnicalDatabase.DataValueField = "TechnicalSkillId";
            chkTechnicalDatabase.DataBind();
        }

        private void BindSoftwares()
        {
            ds = technicalSkillsBAL.SoftwaresBAL();
            chkSoftwares.DataSource = ds;
            chkSoftwares.DataTextField = "TechnicalSkillName";
            chkSoftwares.DataValueField = "TechnicalSkillId";
            chkSoftwares.DataBind();
        }

        private void BindOperatingSystem()
        {
            ds = technicalSkillsBAL.OperatingSystemBAL();
            chkOperatingSystem.DataSource = ds;
            chkOperatingSystem.DataTextField = "TechnicalSkillName";
            chkOperatingSystem.DataValueField = "TechnicalSkillId";
            chkOperatingSystem.DataBind();
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