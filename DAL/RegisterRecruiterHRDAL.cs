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

                SqlParameter[] param = new SqlParameter[26];
                param[0] = new SqlParameter("@recrName", recruiterRegisterEntity.FullName);
                param[1] = new SqlParameter("@hrId", recruiterRegisterEntity.HrId);
                param[2] = new SqlParameter("@company", recruiterRegisterEntity.Company);
                param[3] = new SqlParameter("@officialContactNo", recruiterRegisterEntity.OfficialContactNo);
                param[4] = new SqlParameter("@mobNo", recruiterRegisterEntity.MobileNo);
                param[5] = new SqlParameter("@alternateNo", recruiterRegisterEntity.AlternateNo);
                param[6] = new SqlParameter("@officialEmailid", recruiterRegisterEntity.OfficialEmailId);
                param[7] = new SqlParameter("@personalMailId", recruiterRegisterEntity.PersonalMailId);
                param[8] = new SqlParameter("@freelancerOrEmployee", recruiterRegisterEntity.FreelanceOrEmployee);
                param[9] = new SqlParameter("@amountPerMonth", recruiterRegisterEntity.AmountPerMonth);
                param[10] = new SqlParameter("@percentPerClosure", recruiterRegisterEntity.PercentPerClosure);
                param[11] = new SqlParameter("@employeeSalary", recruiterRegisterEntity.EmployeeSalary);
                param[12] = new SqlParameter("@address", recruiterRegisterEntity.Address);
                param[13] = new SqlParameter("@presentCountry", recruiterRegisterEntity.PresentCountry);
                param[14] = new SqlParameter("@presentState", recruiterRegisterEntity.PresentState);
                param[15] = new SqlParameter("@presentCity", recruiterRegisterEntity.PresentCity);
                param[16] = new SqlParameter("@presentArea", recruiterRegisterEntity.PresentArea);
                param[17] = new SqlParameter("@pinCode", recruiterRegisterEntity.Pincode);
                param[18] = new SqlParameter("@employmentStatus", recruiterRegisterEntity.EmploymentStatus);
                param[19] = new SqlParameter("@jobType", recruiterRegisterEntity.JobType);
                param[20] = new SqlParameter("@clientSite", recruiterRegisterEntity.ClientSite);
                param[21] = new SqlParameter("@clientName", recruiterRegisterEntity.ClientName);
                param[22] = new SqlParameter("@panCardNo", recruiterRegisterEntity.PANCardNo);
                param[23] = new SqlParameter("@photoPath", recruiterRegisterEntity.PhotoPath);
                param[24] = new SqlParameter("@password", recruiterRegisterEntity.Password);
                //param[24] = new SqlParameter("@isMailSent", recruiterRegisterEntity.IsMailSent);
                param[25] = new SqlParameter("@setrecruiterid", SqlDbType.VarChar, 500);
                param[25].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_HR_InsertRecruiterRegisterDetails, param);
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

        public void UpdateMailsentDAL(Entities.HR.RecruiterRegisterEntity registerRecruiterEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[2];
                sparams[0] = new SqlParameter("@recruiterID", registerRecruiterEntity.Recruiterid);
                sparams[1] = new SqlParameter("@isMailsent", registerRecruiterEntity.IsMailSent);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_HR_UpdateRecruiterIsMailSent, sparams);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}