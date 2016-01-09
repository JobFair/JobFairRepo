using System;
using System.Web.UI.WebControls;
using System.Data;
using BAL;

namespace JobFair.Forms.JobSeeker
{
    public partial class ViewJobPost : System.Web.UI.Page
    {
        Int64 candidateId = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsJobPost = new DataSet();
            ViewJobPostBAL viewJobPostBAL=new ViewJobPostBAL();
            dsJobPost = viewJobPostBAL.ViewAllJobPostBAL();
            if(dsJobPost!=null)
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