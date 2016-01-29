using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities.Recruiter;
using BAL;

namespace JobFair.Forms.Recruiter
{
    public partial class ProfessionalDetails : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            ProfessionalDetailsEntity professionaldetailentity = new ProfessionalDetailsEntity();
            ProfessionalDetailBAL professionaldetailBAL = new ProfessionalDetailBAL();

            professionaldetailentity.RecruiterID = "12";
            professionaldetailentity.TotalExprience = txttotalexprience.Text.Trim();
            professionaldetailentity.Designation = txtdesignation.Text.Trim();
            professionaldetailentity.Freelancer = txtfreelancer.Text.Trim();
            professionaldetailentity.EmploymentStaus = rbtemploymentstatus.SelectedItem.Text.Trim();
            professionaldetailentity.jobtype = rbtjobtype.SelectedItem.Text.Trim();

            int result = professionaldetailBAL.InsertDetails(professionaldetailentity);
            {

                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('Recored Inserted ')</script>");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Sorry')</script>");
                }

            }
        }

    }
}