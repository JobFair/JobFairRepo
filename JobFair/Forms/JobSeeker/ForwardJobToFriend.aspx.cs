using BAL;
using System;
using System.Data;
using System.Net.Mail;

namespace JobFair.Forms.JobSeeker
{
    public partial class ForwardJobToFriend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(Request.QueryString["jid"]);
            DateTime postedDate;
            string strBody = "", toemail, jobTitle, experience, minSalary, maxSalary, companyName, link, industryId, jobLocationCity;
            DataSet ds = new DataSet();
            ViewAllJobPostBAL viewAllPostBAL = new ViewAllJobPostBAL();
            ds = viewAllPostBAL.GetData(id);
            jobTitle = Convert.ToString(ds.Tables[0].Rows[0]["JobTitle"]);
            experience = Convert.ToString(ds.Tables[0].Rows[0]["WorkExperience"]);
            minSalary = Convert.ToString(ds.Tables[0].Rows[0]["OfferedAnnualSalaryMin"]);
            maxSalary = Convert.ToString(ds.Tables[0].Rows[0]["OfferedAnnualSalaryMax"]);
            industryId = Convert.ToString(ds.Tables[0].Rows[0]["IndustryName"]);
            postedDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["PostedDate"]);
            companyName = Convert.ToString(ds.Tables[0].Rows[0]["CompanyName"]);
            link = Convert.ToString(ds.Tables[0].Rows[0]["PageLink"]);
            jobLocationCity = Convert.ToString(ds.Tables[0].Rows[0]["CityName"]);

            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(txtEmail.Text.Trim()); 
            toemail = txtEmail.Text;
            string[] Multi = toemail.Split(','); //spiliting input Email id string with comma(,)
            foreach (string Multiemailid in Multi)
            {
                msg.To.Add(new MailAddress(Multiemailid)); //adding multi reciver's Email Id
            }

            //msg.To.Add("backupinfo.logos@gmail.com");
            msg.Subject = "Your Friend " + txtName.Text.Trim() + " has forwarded you the Job: " + jobTitle + " at " + companyName;

            strBody = "<html><body><table><tr><td>" + txtMessage.Text.Trim() + "</td></tr> " +
                " <tr><td></td></tr> " +
               " <tr><td></td></tr> " +
               " <tr><td><h2>Below is the job your friend has shared with you</h2></td></tr> " +
               " <tr><td><h2>" + jobTitle + "</h2></td></tr> " +
               " <tr><td></td></tr> " +
                " <tr><td>Experience </td><td>:</td><td>" + experience + "</td></tr><br /> " +
                " <tr><td>Location</td><td>:</td><td>" + jobLocationCity + "</td></tr><br /> " +
               " <tr><td>Salary </td><td>:</td><td>" + minSalary + "-" + maxSalary + "</td></tr><br /> " +
               " <tr><td>Industry </td><td>:</td><td>" + industryId + "</td></tr><br /> " +
               " <tr><td>Posted Date </td><td>:</td><td>" + postedDate + "</td></tr><br /> " +
                "<tr><td><a href=" + link + ">View And Apply</a></td></tr>" +
               " </table> </body></html>";

            msg.Body = strBody;
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("logos.expertadvice@gmail.com", "logos@gmail");
            smtp.EnableSsl = true;
            smtp.Send(msg);
            msg = null;
            Response.Write("<script language='javascript'>alert('Refer successfully Done...');</script>");
        }
    }
}