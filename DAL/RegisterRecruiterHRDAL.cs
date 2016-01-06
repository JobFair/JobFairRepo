using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RegisterRecruiterHRDAL
    {
       
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Add New Recruiter DAL
        /// </summary>
        /// <param name="recruiterRegisterEntity">Object for Recruiter entity</param>
        /// <returns>System.String</returns>
        public string SaveNewRecruiterDAL(Entities.HR.RecruiterRegisterEntity recruiterRegisterEntity)
        {
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[26];
                param[0] = new SqlParameter("@recrName", recruiterRegisterEntity.FullName);
                param[1] = new SqlParameter("@company", recruiterRegisterEntity.Company);
                param[2] = new SqlParameter("@officialContactNo", recruiterRegisterEntity.OfficialContactNo);
                param[3] = new SqlParameter("@mobNo", recruiterRegisterEntity.MobileNo);
                param[4] = new SqlParameter("@alternateNo", recruiterRegisterEntity.AlternateNo);               
                param[5] = new SqlParameter("@officialEmailid", recruiterRegisterEntity.OfficialEmailId);
                param[6] = new SqlParameter("@personalMailId", recruiterRegisterEntity.PersonalMailId);
                param[7] = new SqlParameter("@freelancerOrEmployee", recruiterRegisterEntity.FreelanceOrEmployee);
                param[8] = new SqlParameter("@amountPerMonth", recruiterRegisterEntity.AmountPerMonth);
                param[9] = new SqlParameter("@percentPerClosure", recruiterRegisterEntity.PercentPerClosure);
                param[10] = new SqlParameter("@employeeSalary", recruiterRegisterEntity.EmployeeSalary);
                param[11] = new SqlParameter("@address", recruiterRegisterEntity.Address);
                param[12] = new SqlParameter("@presentCountry", recruiterRegisterEntity.PresentCountry);
                param[13] = new SqlParameter("@presentState", recruiterRegisterEntity.PresentState);
                param[14] = new SqlParameter("@presentCity", recruiterRegisterEntity.PresentCity);
                param[15] = new SqlParameter("@presentArea", recruiterRegisterEntity.PresentArea);
                param[16] = new SqlParameter("@pinCode", recruiterRegisterEntity.Pincode);
                param[17] = new SqlParameter("@employmentStatus", recruiterRegisterEntity.EmploymentStatus);
                param[18] = new SqlParameter("@jobType", recruiterRegisterEntity.JobType);
                param[19] = new SqlParameter("@clientSite", recruiterRegisterEntity.ClientSite);
                param[20] = new SqlParameter("@clientName", recruiterRegisterEntity.ClientName);
                param[21] = new SqlParameter("@panCardNo", recruiterRegisterEntity.PANCardNo);
                param[22] = new SqlParameter("@photoPath", recruiterRegisterEntity.PhotoPath);
                param[23] = new SqlParameter("@password", recruiterRegisterEntity.Password);
                param[24] = new SqlParameter("@isMailSent", recruiterRegisterEntity.IsMailSent);
                param[25] = new SqlParameter("@setrecruiterid", SqlDbType.VarChar, 500);
                param[25].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure,Constants.sp_HR_InsertRecruiterRegisterDetails , param);
                string recruiterID = Convert.ToString(param[25].Value);

                if (string.IsNullOrEmpty(recruiterID))
                {
                    return null;
                }
                return recruiterID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}