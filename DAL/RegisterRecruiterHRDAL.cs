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
                SqlParameter[] param = new SqlParameter[8];
                param[0] = new SqlParameter("@recrName", recruiterRegisterEntity.FullName);
                param[1] = new SqlParameter("@company", recruiterRegisterEntity.Company);
                param[2] = new SqlParameter("@mobNo", recruiterRegisterEntity.MobileNo);
                param[3] = new SqlParameter("@oficialEmailid", recruiterRegisterEntity.OfficialEmailId);
                param[4] = new SqlParameter("@city", recruiterRegisterEntity.City);
                param[5] = new SqlParameter("@password", recruiterRegisterEntity.Password);
                param[6] = new SqlParameter("@photoPath", recruiterRegisterEntity.PhotoPath);
                param[7] = new SqlParameter("@setrecruiterid", SqlDbType.VarChar, 500);
                param[7].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure,Constants.sp_RE_InsertRegisterDetails , param);
                string recruiterID = Convert.ToString(param[7].Value);

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