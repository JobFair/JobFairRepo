using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Entities.Recruiter;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace JobFair.Forms.Recruiter
{
    public partial class ManageJobs : System.Web.UI.Page
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        DataSet dataset = new DataSet();
        ManageJobsBAL manageJobsBAL = new ManageJobsBAL();
        
        /// <summary>
        /// Class ManageJobs
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            //Bind repeater control
            dataset = manageJobsBAL.ManageJobsDetailsBAL();
            repJobsDetails.DataSource = dataset;
            repJobsDetails.DataBind();
        }

        protected void lnkBtnRepost_Click(object sender, EventArgs e)
        {
            LinkButton button = (LinkButton)sender;
            Label label = (Label)button.NamingContainer.FindControl("lblJobID");
            int JobId = Convert.ToInt32(label.Text);

            manageJobsBAL.RePostJobBAL(JobId);
            Response.Redirect("ManageJobs.aspx");
        }
        protected void lnkBtnViewJob_Click(object sender, EventArgs e)
        {
                LinkButton button = (LinkButton)sender;
                Label label = (Label)button.NamingContainer.FindControl("lblJobID");
                int JobId = Convert.ToInt32(label.Text);
                dataset = manageJobsBAL.ViewJobsDetailsBAL(JobId);
                gvViewJob.DataSource = dataset;
                gvViewJob.DataBind();

                divMain.Visible = false;
                divViewJob.Visible = true;
        }

        //private DataTable GetData(SqlCommand cmd)
        //{
        //    DataTable dt = new DataTable();
        //    SqlConnection con = new SqlConnection(JobPortalCon);
        //    SqlDataAdapter sda = new SqlDataAdapter();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con;
        //    con.Open();
        //    sda.SelectCommand = cmd;
        //    sda.Fill(dt);
        //    return dt;
        //}
        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            gvViewJob.DataBind();
            gvViewJob.PageIndex = e.NewPageIndex;
            gvViewJob.DataBind();
        }

        protected void DeleteCustomer(object sender, EventArgs e)
        {
            //LinkButton lnkRemove = (LinkButton)sender;
            //SqlConnection con = new SqlConnection(strConnString);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "delete from  customers where " +
            //"CustomerID=@CustomerID;" +
            // "select CustomerID,ContactName,CompanyName from customers";
            //cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = lnkRemove.CommandArgument;
            //GridView1.DataSource = GetData(cmd);
            //GridView1.DataBind();
        }
        protected void EditCustomer(object sender, GridViewEditEventArgs e)
        {
            divMain.Visible = false;
            divViewJob.Visible = true;
            gvViewJob.EditIndex = e.NewEditIndex;
            gvViewJob.DataBind();
        }
        protected void CancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvViewJob.EditIndex = -1;
            gvViewJob.DataBind();
        }
        protected void UpdateCustomer(object sender, GridViewUpdateEventArgs e)
        {
            //string CustomerID = ((Label)GridView1.Rows[e.RowIndex].FindControl("lblCustomerID")).Text;
            //string Name = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtContactName")).Text;
            //string Company = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtCompany")).Text;
            //SqlConnection con = new SqlConnection(strConnString);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "update customers set ContactName=@ContactName,CompanyName=@CompanyName " +
            // "where CustomerID=@CustomerID;" +
            // "select CustomerID,ContactName,CompanyName from customers";
            //cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = CustomerID;
            //cmd.Parameters.Add("@ContactName", SqlDbType.VarChar).Value = Name;
            //cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = Company;
            //GridView1.EditIndex = -1;
            //GridView1.DataSource = GetData(cmd);
            //GridView1.DataBind();
        }

    }
}