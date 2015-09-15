using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobFair.UserControls.JobSeeker
{
    public partial class MoreCertifications1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            PlaceHolder PlaceHolder1 = new PlaceHolder();
            int numlabels = 2;
            Label lblCert1 = new Label();
            for (int i = 1; i <= numlabels; i++)
            {
            // Set the label's Text and ID properties.
            lblCert1.Text = "Certificate" + i.ToString();
            lblCert1.ID = "lblCert" + i.ToString();
            PlaceHolder1.Controls.Add(lblCert1);
            // Add a spacer in the form of an HTML <br /> element.
            PlaceHolder1.Controls.Add(new LiteralControl("<br />"));
            }
        }
    }
}