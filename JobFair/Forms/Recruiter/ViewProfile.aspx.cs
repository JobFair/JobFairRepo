using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BAL;
using Entities.Recruiter;


namespace JobFair.Forms.Recruiter
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ViewProfileREBAL viewProfileBAL = new ViewProfileREBAL();
            ViewProfileEntity viewProfileEntity = new ViewProfileEntity();
             Label3.Text = viewProfileEntity.name;
             Label4.Text = viewProfileEntity.companyName;
            Label5.Text= viewProfileEntity.mobNo;
            Label6.Text= viewProfileEntity.emailId;
            Label7.Text= viewProfileEntity.city;
           Image1.ImageUrl=  viewProfileEntity.photo;
            viewProfileBAL.ViewProfile(viewProfileEntity);
        }

       
    }
}