using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RegisterRecruiterDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Add New Recruiter DAL
        /// </summary>
        /// <param name="rrentity">Object for Recruiter entity</param>
        /// <returns>System.String</returns>
        public string SaveNewRecruiterDAL(Entities.Recruiter.RegisterRecruiterEntity rrentity)
        {
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter[] param = new SqlParameter[8];
                param[0] = new SqlParameter("@recrName", rrentity.FullName);
                param[1] = new SqlParameter("@company", rrentity.Company);
                param[2] = new SqlParameter("@mobNo", rrentity.MobileNo);
                param[3] = new SqlParameter("@oficialEmailid", rrentity.OficialEmailId);
                param[4] = new SqlParameter("@city", rrentity.City);
                param[5] = new SqlParameter("@password", rrentity.Password);
                param[6] = new SqlParameter("@photoPath", rrentity.PhotoPath);
                param[7] = new SqlParameter("@setrecruiterid", SqlDbType.VarChar, 500);
                param[7].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_RE_InsertRegisterDetails", param);
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