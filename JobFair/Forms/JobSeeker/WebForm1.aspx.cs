using BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
using Entities.Recruiter;
using System.Web.UI;



namespace JobFair.Forms.JobSeeker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    //if (FromYearTxt.Text != "" && ToYearTxt.Text != "")
        //    //{
        //    //    //Storing input Dates
        //    //    DateTime FromYear = Convert.ToDateTime(FromYearTxt.Text);
        //    //    DateTime ToYear = Convert.ToDateTime(ToYearTxt.Text);

        //    //    //Creating object of TimeSpan Class
        //    //    TimeSpan objTimeSpan = ToYear - FromYear;
        //    //    //years
        //    //    int Years = ToYear.Year - FromYear.Year;
        //    //    //months
        //    //    int month = ToYear.Month - FromYear.Month;
        //    //    //TotalDays
        //    //    double Days = Convert.ToDouble(objTimeSpan.TotalDays);
        //    //    //Total Months
        //    //    int TotalMonths = (Years * 12) + month;
        //    //    //Total Hours
        //    //    double TotalHours = objTimeSpan.TotalHours;
        //    //    //Total Minutes
        //    //    double TotalMinutes = objTimeSpan.TotalMinutes;
        //    //    //Total Seconds
        //    //    double TotalSeconds = objTimeSpan.TotalSeconds;
        //    //    //Total Mile Seconds
        //    //    double TotalMileSeconds = objTimeSpan.TotalMilliseconds;
        //    //    //Assining values to td tags
        //    //    Label1.Text = Years + "." + month;

        //    //    Label2.Text = Convert.ToString(TotalMonths);
        //    //    //tdDays.InnerText = Convert.ToString(Days);
        //    //    //tdHrs.InnerText = Convert.ToString(TotalHours);
        //    //    //tdminuts.InnerText = Convert.ToString(TotalMinutes);
        //    //    //tdseconds.InnerText = Convert.ToString(TotalSeconds);
        //    //    //tdmileSec.InnerText = Convert.ToString(TotalMileSeconds);
        //    //    //tblResults.Visible = true;
        //    //}
        //}
    }
}
   

   
    
