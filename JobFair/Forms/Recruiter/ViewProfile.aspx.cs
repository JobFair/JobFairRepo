using BAL;
using Entities.Recruiter;
using System;
using System.Data;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            ViewProfileREBAL viewProfileBAL = new ViewProfileREBAL();
            ViewProfileEntity viewProfileEntity = new ViewProfileEntity();
           // viewProfileEntity.name = ds.Tables["RecruiterfullName"].ToString();
            viewProfileBAL.ViewProfile(viewProfileEntity);
            Label3.Text = viewProfileEntity.name;
            Label4.Text = viewProfileEntity.companyName;
            Label5.Text = viewProfileEntity.mobNo;
            Label6.Text = viewProfileEntity.emailId;
            Label7.Text = viewProfileEntity.city;
            Image1.ImageUrl = viewProfileEntity.photo;
           
        }
    }
}