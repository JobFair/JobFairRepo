using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using BAL;
using Entities.JobSeeker;

namespace JobFair.UserControls.JobSeeker
{
    /// <summary>
    /// Class EducationalDetails.
    /// </summary>
    public partial class EducationalDetails : System.Web.UI.UserControl
    {
        private DataSet ds = new DataSet();
        private EducationalDetailsBAL edBAL = new EducationalDetailsBAL();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ddlHQ.DataSource = edBAL.GetEducationalDegreeTypeBAL();
                ddlHQ.DataValueField = "degreeId";
                ddlHQ.DataTextField = "degreeType";
                ddlHQ.DataBind();
                ddlHQ.Items.Insert(0, new ListItem("--Select--", "0"));

                chkList.DataSource = edBAL.GetEducationalDegreeTypeBAL();
                chkList.DataValueField = "degreeId";
                chkList.DataTextField = "degreeType";
                chkList.DataBind();
               
            }
            //var allcheckbox = DemoEducationalDetails.Controls.OfType<CheckBox>();
            //var chkbox = Page.Controls.OfType<CheckBox>().Where(c => c.Checked);
            int cnt = 0;

            foreach (Control ctl in this.Controls)
            {
                if (ctl is CheckBox)
                {
                    cnt++;
                }
            }
        
        }

        protected void chkList_SelectedIndexChanged(object sender, EventArgs e)
        {
                //var chkList = sender as CheckBoxList;
                //foreach (ListItem li in chkList.Items)
                {
                   if (chkList.Items[0].Selected)
                  //  if(chkList.SelectedIndex == 1)
                    {
                        divSSC.Visible = true;
                        pnlCollapsableSSC.Visible = true;
                    }
                   
                     //   divSSC.Visible = false;
                   // pnlCollapsableSSC.Visible = false;
                }
        }
        protected void ddlHSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlHSC.SelectedIndex == 4)
            {
                txtHSCAdd.Visible = true;
                btnHSCAdd.Visible = true;
            }
            else
                txtHSCAdd.Visible = false;
            btnHSCAdd.Visible = false;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

            EducationalDetailsBAL educationalDetails = new EducationalDetailsBAL();
            List<EducationalDetailsEntity> educationDetailsList = new List<EducationalDetailsEntity>();


            // Foreach for all check boxes which is checked = true;


            EducationalDetailsEntity educationDetailsEntities = new EducationalDetailsEntity();
            educationDetailsEntities.CandidateId = "JS10";
            educationDetailsEntities.DegreeId = ddlHQ.SelectedValue.Trim();
            educationDetailsEntities.MediumOfEducation = txtSSCMedium.Text.Trim();
            educationDetailsEntities.Status = rblSSCStat.SelectedValue.Trim();
            educationDetailsEntities.YearOfCompletion = txtSSCYear.Text.Trim();
            educationDetailsEntities.University = txtSSCBoard.Text.Trim();
            educationDetailsEntities.Percantage = txtSSCPercentage.Text.Trim();

            educationalDetails.SaveEducationalDetailsBAL(educationDetailsList);

            educationDetailsList.Add(educationDetailsEntities);



            //XmlTextReader xmlreader = new XmlTextReader(Server.MapPath("D:/Project/JobFair/DAL/EducationalDetailsDAL.xml"));
            //DataSet ds = new DataSet();
            //ds.ReadXml(xmlreader);
            //xmlreader.Close();
            //if (ds.Tables.Count != 0)
            //{
            //    using (SqlConnection con = new SqlConnection("Data Source=PC02;Initial Catalog=JobFairPortal;User ID=sa;Password=sa@123"))
            //    {
            //        con.Open();
            //        SqlCommand cmd = new SqlCommand("prc_readxmldata", con);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.Add("@XMLdata", SqlDbType.Xml).Value = ds.GetXml();
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataSet ds1 = new DataSet();
            //        da.Fill(ds1);
            //        gvDetails.DataSource = ds1;
            //        gvDetails.DataBind();
            //        con.Close();
            //    }
            //}
        }

        //protected void cbCertification_CheckedChanged(object sender, EventArgs e)
        //{
        //    divCertification.Visible = true;
        //    pnlCollapsableCert.Visible = true;
        //}

        //protected void cbWorkshop_CheckedChanged(object sender, EventArgs e)
        //{
        //    divWorkshop.Visible = true;
        //    pnlCollapsableWork.Visible = true;
        //}
    }
}