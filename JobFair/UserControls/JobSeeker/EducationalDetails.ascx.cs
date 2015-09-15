using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;
using System.Data.SqlClient;

namespace JobFair.UserControls.JobSeeker
{
    public partial class EducationalDetails : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSSCPercentage_TextChanged(object sender, EventArgs e)
        {
            if (txtSSCYear.Text != "" && txtSSCBoard.Text != "" && txtSSCPercentage.Text != "")
            {
                divHSC.Visible = true;
            }
        }

        protected void cbSSC_CheckedChanged(object sender, EventArgs e)
        {
            divSSC.Visible = true;
            pnlCollapsableSSC.Visible = true;
        }

        protected void cbHSC_CheckedChanged(object sender, EventArgs e)
        {
            divHSC.Visible = true;
            pnlCollapsableHSC.Visible = true;
        }

        protected void cbDip_CheckedChanged(object sender, EventArgs e)
        {
            divDip.Visible = true;
            pnlCollapsableDip.Visible = true;
        }

        protected void cbBD_CheckedChanged(object sender, EventArgs e)
        {
            divBD.Visible = true;
            pnlCollapsableBD.Visible = true;
        }

        protected void cbPgd_CheckedChanged(object sender, EventArgs e)
        {
            divPgd.Visible = true;
            pnlCollapsablePgd.Visible = true;
        }

        protected void cbMD_CheckedChanged(object sender, EventArgs e)
        {
            divMD.Visible = true;
            pnlCollapsableMD.Visible = true;
        }

        protected void cbPHD_CheckedChanged(object sender, EventArgs e)
        {
             divPHD.Visible = true;
             pnlCollapsablePHD.Visible = true;
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
            //       // gvDetails.DataSource = ds1;
            //       // gvDetails.DataBind();
            //        con.Close();
            //    }
            //}
        }

        protected void cbCertification_CheckedChanged(object sender, EventArgs e)
        {
            divCertification.Visible = true;
            pnlCollapsableCert.Visible = true;
        }

        protected void cbWorkshop_CheckedChanged(object sender, EventArgs e)
        {
            divWorkshop.Visible = true;
            pnlCollapsableWork.Visible = true;
        }
    }
}