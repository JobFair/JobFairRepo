using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ViewProfileJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        private DataSet ds = new DataSet();

        //public DataSet ViewProfileDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        //{
        //}
        /// <summary>
        /// Change Mobile number of Jobseeker Candidate
        /// </summary>
        /// <param name="viewProfileEntity">Object of ViewProfileEntity</param>
        /// <returns>System.Int32</returns>
        public int ChangeConatctNoDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams = new SqlParameter[2];
            sparams[0] = new SqlParameter("@id", "JS12");
            sparams[1] = new SqlParameter("@newmobNo", viewProfileEntity.MobileNumber);
            int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateContactDetails, sparams);
            return result;
        }

        //public int ResumeDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        //{
        //    SqlParameter[] sparams = new SqlParameter[2];
        //    sparams[0] = new SqlParameter("@id", "JS12");
        //    int result=1;
        //    return result;

        //}

        public int ChangePersonalDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams = new SqlParameter[6];
            sparams[0] = new SqlParameter("@id", "JS12");
            sparams[1] = new SqlParameter("@firstName", viewProfileEntity.FirstName);
            sparams[2] = new SqlParameter("@lastName", viewProfileEntity.LastName);
            sparams[3] = new SqlParameter("@emailId", viewProfileEntity.EmailId);
            sparams[4] = new SqlParameter("@dateOfBirth", viewProfileEntity.Birthdate.ToShortDateString());
            sparams[5] = new SqlParameter("@address", viewProfileEntity.Address);
            int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_UpdatePersonalDetails", sparams);
            return result;
        }

        public DataSet RegisterDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams1 = new SqlParameter[1];
            sparams1[0] = new SqlParameter("@id", "JS12");
            ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_JS_SelectRegisterDetails", sparams1);
            viewProfileEntity.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
            viewProfileEntity.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
            viewProfileEntity.MobileNumber = ds.Tables[0].Rows[0]["MobileNo"].ToString();
            viewProfileEntity.EmailId = ds.Tables[0].Rows[0]["EmailId"].ToString();
            return ds;
        }

        public DataSet PersonalDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams = new SqlParameter[1];
            sparams[0] = new SqlParameter("@id", "JS12");
            ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_JS_SelectPersonalDetails", sparams);
            viewProfileEntity.Address = ds.Tables[0].Rows[0]["CurrentAddress"].ToString();
            viewProfileEntity.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
            viewProfileEntity.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
            viewProfileEntity.EmailId = ds.Tables[0].Rows[0]["EmailId"].ToString();
            viewProfileEntity.Birthdate = Convert.ToDateTime(ds.Tables[0].Rows[0]["DateOfBirth"].ToString());
            return ds;
        }

        public DataSet ProfessionalDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams2 = new SqlParameter[1];
            sparams2[0] = new SqlParameter("@id", "JS12");
            ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_JS_SelectProfessionalDetails", sparams2);
            viewProfileEntity.WorkExperience = ds.Tables[0].Rows[0]["TotalExpriance"].ToString();
            viewProfileEntity.CurrentEmployer = ds.Tables[0].Rows[0]["CurrentEmployer"].ToString();
            viewProfileEntity.DesignationCurrent = ds.Tables[0].Rows[0]["Designation"].ToString();
            viewProfileEntity.AnnualSalary = ds.Tables[0].Rows[0]["CurrentAnualSalary"].ToString();
            viewProfileEntity.ExpectedSalary = ds.Tables[0].Rows[0]["ExpectedAnualSalary"].ToString();
            viewProfileEntity.CompanyType = ds.Tables[0].Rows[0]["CompanyType"].ToString();
            return ds;
        }

        public int ChangeProfessionalDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams = new SqlParameter[7];
            sparams[0] = new SqlParameter("@id", "JS12");
            sparams[1] = new SqlParameter("@workExperience", viewProfileEntity.WorkExperience);
            sparams[2] = new SqlParameter("@currentEmployer", viewProfileEntity.CurrentEmployer);
            sparams[3] = new SqlParameter("@designationCurrent", viewProfileEntity.DesignationCurrent);
            sparams[4] = new SqlParameter("@annualSalary", viewProfileEntity.AnnualSalary);
            sparams[5] = new SqlParameter("@expectedSalary", viewProfileEntity.ExpectedSalary);
            sparams[6] = new SqlParameter("@companyType", viewProfileEntity.CompanyType);
            int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_UpdateProfessionalDetails", sparams);
            return result;
        }
    }
}