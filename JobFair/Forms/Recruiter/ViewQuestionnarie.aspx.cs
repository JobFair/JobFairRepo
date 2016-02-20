using BAL;
using System;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewQuestionnarie : System.Web.UI.Page
    {
        private Int32 questionnarieId = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            QuestionnarieREBAL questionnarieBAL = new QuestionnarieREBAL();
            ds = questionnarieBAL.ViewQuestionnarieBAL(questionnarieId);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                HtmlGenericControl innerDiv = new HtmlGenericControl("div");
                Label lbl = new Label();
                lbl.Text = item.Field<string>("QuestionName");
                innerDiv.Controls.Add(lbl);
                PlaceHolder1.Controls.Add(innerDiv);
                //tr.Controls.Add(td1);

                switch (item.Field<string>("QuestionType"))
                {
                    case "TextBox":
                        HtmlGenericControl textBoxDiv = new HtmlGenericControl("div");
                        TextBox textBox = new TextBox();
                        textBoxDiv.Controls.Add(textBox);
                        PlaceHolder1.Controls.Add(textBoxDiv);
                       
                        break;

                    case "List Menu":
                        HtmlGenericControl dropDownDiv = new HtmlGenericControl("div");
                        DropDownList dropDown = new DropDownList();
                      
                        ListItem li = new ListItem();
                        li.Text = item.Field<string>("AnswerOption");
                        string list = li.Text;
                        string[] listMenu = list.Split(new char[] { ',' });
                        int count = 0;
                        foreach (string dropDownList in listMenu)
                        {
                            count += 1;
                            dropDown.Items.Add(dropDownList);
                        }
                        dropDownDiv.Controls.Add(dropDown);
                        PlaceHolder1.Controls.Add(dropDownDiv);
                        break;

                    case "Radio Button":
                        HtmlGenericControl radioButtonDiv = new HtmlGenericControl("div");
                        RadioButtonList radioButtonList = new RadioButtonList();
                        ListItem liRadioButton = new ListItem();
                        liRadioButton.Text = item.Field<string>("AnswerOption");
                        string radioButton = liRadioButton.Text;
                        string[] radioButtonMenu = radioButton.Split(new char[] { ',' });
                        int radioCount = 0;
                        foreach (string radioButtonLst in radioButtonMenu)
                        {
                            radioCount += 1;
                            radioButtonList.Items.Add(radioButtonLst);
                        }
                        radioButtonDiv.Controls.Add(radioButtonList);
                        PlaceHolder1.Controls.Add(radioButtonDiv);
                        break;

                    case "Check Box":
                        CheckBoxList chkList = new CheckBoxList();
                        HtmlGenericControl checkBoxListDiv = new HtmlGenericControl("div");
                        ListItem liCheckBoxList = new ListItem();
                        liCheckBoxList.Text = item.Field<string>("AnswerOption");
                        string checkBox = liCheckBoxList.Text;
                        string[] checkBoxListMenu = checkBox.Split(new char[] { ',' });
                        int checkCount = 0;
                        foreach (string checkBoxList in checkBoxListMenu)
                        {
                            checkCount += 1;
                            chkList.Items.Add(checkBoxList);
                        }
                        checkBoxListDiv.Controls.Add(chkList);
                        PlaceHolder1.Controls.Add(checkBoxListDiv);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}