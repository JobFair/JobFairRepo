using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace JobFair.Forms.Recruiter
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        public string name, companyName, mobNo, emailId, city, photo;
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            BindReapeter();
        }

        private void BindReapeter()
        {
            DataTable dt = new DataTable();

            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from RE_RegisterDetails where RecruiterID='RE11'", connection);

            ds = new DataSet();
            sda.Fill(ds, "language");
            name = ds.Tables["language"].Rows[0]["RecruiterfullName"].ToString();
            companyName = ds.Tables["language"].Rows[0]["Company"].ToString();
            mobNo = ds.Tables["language"].Rows[0]["MobileNumber"].ToString();
            emailId = ds.Tables["language"].Rows[0]["OficialEmail_ID"].ToString();
            city = ds.Tables["language"].Rows[0]["City"].ToString();
            photo = ds.Tables["language"].Rows[0]["PhotoPath"].ToString() + "L1-whte"+".jpg";
            Image1.ImageUrl = photo;
        }
    }
}