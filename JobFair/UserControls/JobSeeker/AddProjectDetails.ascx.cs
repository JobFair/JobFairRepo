using BAL;
using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class AddProjectDetails : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AddProjectDetailsBAL pdBAL = new AddProjectDetailsBAL();
                ddlRole.DataSource = pdBAL.LoadRole();
                ddlRole.DataTextField = "roleName";
                ddlRole.DataValueField = "roleId";
                ddlRole.DataBind();
                ddlRole.Items.Insert(0, new ListItem("--Select--", "0"));
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
             try
            {
                //DateTime toDate = Convert.ToDateTime(txtToDate.Text);
                //DateTime formDate = Convert.ToDateTime(txtFormDate.Text);
                //TimeSpan objTimeSpan = toDate - formDate;
               
                 TimeSpan i = new TimeSpan(0, 0, 0);
                 DateTime startDate = Convert.ToDateTime(this.txtFormDate.Text.Trim(), new CultureInfo("en-Gb"));
    DateTime endDate = Convert.ToDateTime(this.txtToDate.Text.Trim(), new CultureInfo("en-Gb"));
    i += endDate.Subtract(startDate);
    int days = i.Days;

    //DateTime dt1 = Convert.ToDateTime(Textbox1.text);
    //DateTime dt1 = Convert.ToDateTime(Textbox1.text);
    //TimeSpan ts = dt.subtract(dt1);
    //int NoOfDays = dt.Days;
    //textbox3.text = NoOfDays;

                AddProjectDetailsBAL pdBAL = new AddProjectDetailsBAL();
                AddProjectDetailsEntity pdEntity = new AddProjectDetailsEntity();
                pdEntity.CandidateId = "JS00001";
                pdEntity.CompanyName = txtCompanyName.Text;
                pdEntity.ClientName = txtClientName.Text;
                pdEntity.ProjectTitle = txtProjectTitle.Text;
                pdEntity.Duration=days.ToString();
                pdEntity.ProjectLocation=txtProjectLocation.Text;
                 pdEntity.EmployeeType = string.Empty;
                    if (rbtFulTime.Checked)
                    {
                        pdEntity.EmployeeType = "FullTime";
                    }
                    else if (rbtPartTme.Checked)
                    {
                        pdEntity.EmployeeType = "PartTime";
                    }
                pdEntity.ProjectDescription=txtProjectDescription.Text; 
                pdEntity.YourRole=ddlRole.SelectedItem.Text;
                pdEntity.TeamSize=ddlRole.SelectedItem.Text;
                pdEntity.SkillUsed=txtSkill.Text;
                int result = pdBAL.ProjectDetailsBAL(pdEntity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Project Details Inserted')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Sorry')</script>");
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message.ToString();
            }
        
        }
    }
}