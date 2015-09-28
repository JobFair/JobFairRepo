using BAL;
using Entities.Recruiter;
using System;
using System.Data;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        /// <summary>
        /// Class ViewProfile
        /// </summary>

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ViewProfileREBAL viewProfileBAL = new ViewProfileREBAL();
            ViewProfileEntity viewProfileEntity = new ViewProfileEntity();
            viewProfileBAL.ViewProfile(viewProfileEntity);
            //Set the value of viewProfileEntity
            lblRecruiterName.Text = viewProfileEntity.name;
            lblCompanyName.Text = viewProfileEntity.companyName;
            lblMobile.Text = viewProfileEntity.mobNo;
            lblEmail.Text = viewProfileEntity.emailId;
            lblCity.Text = viewProfileEntity.city;
            Image1.ImageUrl = viewProfileEntity.photo;
            //Bind repeater control
            ds = viewProfileBAL.ViewJobPostBAL();
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }
    }
}