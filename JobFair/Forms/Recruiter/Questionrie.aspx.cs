using BAL;
using Entities.Recruiter;
using System;
using System.Web.UI.WebControls;

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

        //protected void txtquestionType_TextChanged(object sender, EventArgs e)
        //{
        //    txtquestionType.Visible = true;
        //    txtquestionType.Enabled = true;
        //}

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            try
            {
                QuestionrieEntity questionrientity = new QuestionrieEntity();
                QuestionrieBAL questionrieBAL = new QuestionrieBAL();
                questionrientity.Question = txtquestion.Text.Trim();
                questionrientity.Answer = txtanswer.Text.Trim();
                questionrientity.QuestionType = ddlquestiontype.SelectedValue.Trim();

                int result = questionrieBAL.addquestionrie(questionrientity);
                if (result > 0)
                {
                    Response.Write("<script language='javascript'>alert('SubmitQuestion')</script>");
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


        protected void ddlquestiontype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlquestiontype.SelectedValue == "1")
            {
                TextBox1.Visible = true;
                QuestionrieEntity questionrientity = new QuestionrieEntity();
                questionrientity.QuestionType = TextBox1.Text;
            }
            else if (ddlquestiontype.SelectedValue == "2")
            {
                CheckBoxList1.Visible = true;
                QuestionrieEntity questionrientity = new QuestionrieEntity();
                questionrientity.QuestionType = CheckBoxList1.Text;
            }
            else if (ddlquestiontype.SelectedValue == "3")
            {
                RadioButtonList1.Visible = true;
                QuestionrieEntity questionrientity = new QuestionrieEntity();
                questionrientity.QuestionType = RadioButtonList1.Text;
            }
        }

    }
}