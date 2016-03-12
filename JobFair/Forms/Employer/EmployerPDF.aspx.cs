using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BAL;
using iTextSharp.text.xml;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using System.Text;
using System.Web.UI.HtmlControls;
using System.IO;

namespace JobFair.Forms.Employer
  

{

    public partial class EmployerPDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                Bindrepeater();
            
            }

        }



        private void Bindrepeater()
        {
            DataSet ds = new DataSet();
            try
            {
                EmployerpdfBAL  employerpdf = new EmployerpdfBAL();
                ds = employerpdf.GetEmployerDetails();
                rptremployerdetails.DataSource = ds;
                rptremployerdetails.DataBind();
                    

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void btngeneratepdf_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Panel.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            panel1.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
        }

    }
}