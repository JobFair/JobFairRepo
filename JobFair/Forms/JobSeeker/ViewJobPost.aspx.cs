using BAL;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace JobFair.Forms.JobSeeker
{
    public partial class ViewJobPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsJobPost = new DataSet();
            ViewJobPostBAL viewJobPostBAL = new ViewJobPostBAL();
            dsJobPost = viewJobPostBAL.ViewAllJobPostBAL();
            // Check if dsJobPost is not null
            if (dsJobPost != null)
            {
                rptrJobPost.DataSource = dsJobPost;
                rptrJobPost.DataBind();
            }
        }

        protected void rptrJobPost_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Contact")
            {
                Label lbl = (Label)e.Item.FindControl("lblid");
                int jid = Convert.ToInt32(lbl.Text);
                Response.Redirect("ViewAllJobPost.aspx?jid=" + jid);
            }
        }
    }
}