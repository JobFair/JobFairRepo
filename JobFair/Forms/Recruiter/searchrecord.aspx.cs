using BAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace JobFair.Forms.Recruiter
{
    public partial class searchrecord : System.Web.UI.Page
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        private string SearchString = "";
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if (!this.IsPostBack)
            {
                for (int i = 1950; i <= DateTime.Now.Year; i++)
                {
                    ddlyear.Items.Add(i.ToString());
                }
              
              
              
                ddlminage.Items.Add(new ListItem("", ""));
                for (int i = 0; i <= 100; i++)
                {
                    ddlminage.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
             

            }
            BindDepartment();
            BindFunctionalArea();
            BindIndustryType();
            BindMasterDegree();
            BindUnderGraduateDiploma();
            BindMasterDegree();
            BindKeyRoles();
        }

        private void BindKeyRoles()
        {
            
        }

        private void BindDepartment()
        {
            ddldepartment.DataSource = SearchRecordBAL.GetDepartment();
            ddldepartment.DataTextField = "DepartmentName";
            ddldepartment.DataValueField = "DepartmentId";
            ddldepartment.DataBind();
            ddldepartment.Items.Insert(0, new ListItem("------select-------", "0"));
        }
       /// <summary>
       /// Bind dropdownlist Under graduate diploma
       /// </summary>
        private void BindUnderGraduateDiploma()
        {
            ddlugqualification.DataSource = SearchRecordBAL.GetUnderGraduateDiplomaBAL();
            ddlugqualification.DataTextField = "UGDName";
            ddlugqualification.DataValueField = "UGDID";
            ddlugqualification.DataBind();
            ddlugqualification.Items.Insert(0, new ListItem("----select-----", "0"));
        }

        private void BindMasterDegree()
        {
            ddlpgqualification.DataSource = SearchRecordBAL.GetMasterDegreeBAL();
            ddlpgqualification.DataTextField = "MDName";
            ddlpgqualification.DataValueField = "MDId";
            ddlpgqualification.DataBind();
            ddlpgqualification.Items.Insert(0, new ListItem("--------select------", "0"));
        }

        private void BindIndustryType()
        {
            ddlindustrytype.DataSource = SearchRecordBAL.industrytype();
            ddlindustrytype.DataTextField = "IndustryName";
            ddlindustrytype.DataValueField = "IndustryId";
            ddlindustrytype.DataBind();
            ddlindustrytype.Items.Insert(0, new ListItem("---select----", "0"));
        }

        private void BindFunctionalArea()
        {
            ddlfunctionalarea.DataSource = SearchRecordBAL.Functionalarea();
            ddlfunctionalarea.DataTextField = "FunctionalArea";
            ddlfunctionalarea.DataValueField = "FunctionalAreaId";
            ddlfunctionalarea.DataBind();
            ddlfunctionalarea.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        //protected void txtkeywords_TextChanged(object sender, EventArgs e)
        //{
        //    connection.Open();
        //    DataSet ds = new DataSet();

        //    SqlDataAdapter da = new SqlDataAdapter("select * from JS_ResumeFormatting  where [Objective] like '" + txtkeywords.Text + "%'", connection);
        //    string text = ((TextBox)sender).Text;
        //    da.Fill(ds);

        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        GridView1.DataSource = ds.Tables[0];
        //        GridView1.DataBind();
        //        Label1.Visible = false;
        //    }
        //    else
        //    {
        //        Label1.Visible = true;
        //        Label1.Text = "No Record Found";
        //        connection.Close();
        //    }
        //}

        protected void txtallkeywords_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from JS_ResumeFormatting where[KeyResultArea] like '" + txtallkeywords.Text + "%'", connection);
            string text = ((TextBox)sender).Text;
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                Label1.Visible = false;
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "No Record Found";
            }
        }

        protected void txtexcludingkeywords_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from JS_ResumeFormatting where[RolesAndResponsiblity] like '" + txtallkeywords.Text + "%'", connection);
            string text = ((TextBox)sender).Text;
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
                Label1.Visible = false;
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "No Record Found";
            }
        }

        protected void ddlfunctionalarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem item in ddlfunctionalarea.Items)
            {
                if (item.Selected)
                {
                    Label2.Text = item.Text;
                }
            }
        }

        protected void ddlindustrytype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
      /// <summary>
      /// code for submit category 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        protected void Submit(object sender, EventArgs e)
        {
            string message = string.Empty;
            foreach (ListItem item in ddlcategory.Items)
            {
                if (item.Selected)
                {
                    message += item.Text + " " + item.Value + "\\n";
                }
            }
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('" + message + "');", true);
        }
        // code for check checkbox select
        protected void chksearchwomen_CheckedChanged(object sender, EventArgs e)
        {
            if (chksearchwomen.Checked == true)
            {
                CheckBox2.Checked = false;

            }


        }
        // code for check checkbox select

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                chksearchwomen.Checked = false;
            
            }
        }

        protected void rdbpermantjob_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbpermantjob.Checked == true)
            {

                rdbparttime.Checked = false; rdbfulltimejob.Checked = false; rdbAny.Checked = false;
                rdbany1.Checked = false; rdbtemproryjob.Checked = false; 

            }
            if (rdbparttime.Checked == true)
            {

                rdbpermantjob.Checked = false; rdbany1.Checked = false; rdbAny.Checked = false;
                rdbtemproryjob.Checked = false; rdbfulltimejob.Checked = false;

            
            }
            if (rdbAny.Checked == true)
            {
                rdbany1.Checked = false; rdbpermantjob.Checked = false; rdbparttime.Checked = false;
                rdbtemproryjob.Checked = false; rdbfulltimejob.Checked = false;
            }
            if (rdbany1.Checked == true)
            {
                rdbAny.Checked = false; rdbpermantjob.Checked = false; rdbparttime.Checked = false;
                rdbfulltimejob.Checked = false; 

            }
            if (rdbfulltimejob.Checked == true)
            {
                rdbAny.Checked = false; rdbany1.Checked = false; rdbparttime.Checked = false;
                rdbfulltimejob.Checked = false; rdbpermantjob.Checked = false;
            }
        }

        public string HighlightText(string inputTxt)
        {
            string Search_Str = txtkeywords.Text;
            Regex regexp = new Regex(Search_Str.Replace("", "|").Trim(), RegexOptions.IgnoreCase);
            return regexp.Replace(inputTxt, new MatchEvaluator(ReplaceKeyWords));
        }

        private string ReplaceKeyWords(Match match)
        {
            return("<span class = highlight>" + match.Value + "<span class>");
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            SearchString = txtkeywords.Text;
        }

    }
}