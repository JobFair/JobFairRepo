using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Entities.Recruiter;
using BAL;

namespace JobFair.Forms.Recruiter
{
    public partial class Questionrie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            txtquestion.Visible = true;
            txtquestion.Enabled = true;
        }

        protected void btnAddAnswer_Click(object sender, EventArgs e)
        {
            txtanswer.Visible = true;
            txtanswer.Enabled = true;
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            //QuestionrieEntity questionrientity = new QuestionrieEntity();
            //QuestionrieBAL questionrieBAL = new QuestionrieBAL();
            //questionrientity.QuestionType = ;
        }

       
       
      

      
    }
}