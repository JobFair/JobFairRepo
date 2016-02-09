using BAL;
using System;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewQuestionnarie : System.Web.UI.Page
    {
        Int32 questionnarieId=1;
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlGenericControl tr = new HtmlGenericControl("tr");
            HtmlGenericControl td1 = new HtmlGenericControl("td");
            DataSet ds = new DataSet();

            QuestionnarieREBAL questionnarieBAL = new QuestionnarieREBAL();
            ds = questionnarieBAL.ViewQuestionnarieBAL(questionnarieId);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Label lbl = new Label();
                lbl.Text = item.Field<string>("QuestionName");
                td1.Controls.Add(lbl);
                tr.Controls.Add(td1);

                switch (item.Field<string>("QuestionType"))
                {
                    case "TextBox":
                        TextBox1.Visible = true;
                        break;

                    case "List Menu":
                        DropDownList1.Visible = true;
                        ListItem li = new ListItem();
                        li.Text = item.Field<string>("AnswerOption");
                        string asach = li.Text;
                        string[] Wordss = asach.Split(new char[] { ',' });
                        int count = 0;
                        foreach (string Word in Wordss)
                        {
                            count += 1;
                            DropDownList1.Items.Add(Word);
                        }
                        break;

                    case "Radio Button":
                        ListItem lii = new ListItem();
                        lii.Text = item.Field<string>("AnswerOption");
                        string timepass = lii.Text;
                        string[] Words = timepass.Split(new char[] { ',' });
                        int count1 = 0;
                        foreach (string Word in Words)
                        {
                            count1 += 1;
                            RadioButtonList1.Items.Add(Word);
                        }
                        break;

                    case "Check Box":
                        ListItem liii = new ListItem();
                        liii.Text = item.Field<string>("AnswerOption");
                        string sach = liii.Text;
                        string[] Wordsss = sach.Split(new char[] { ',' });
                        int count2 = 0;
                        foreach (string Word in Wordsss)
                        {
                            count2 += 1;
                            CheckBoxList1.Items.Add(Word);
                        }
                        break;

                    default:
                        break;
                }
                PlaceHolder1.Controls.Add(tr);
            }
        }
    }
}