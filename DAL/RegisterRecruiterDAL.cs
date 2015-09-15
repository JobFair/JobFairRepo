using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RegisterRecruiterDAL
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public string NewRecruiterDAL(Entities.Recruiter.RegisterRecruiterEntity rrentity)
        {
            try
            {
                connection.Open();
                // SqlCommand cmd = new SqlCommand();
                SqlCommand cmd = new SqlCommand("sp_RE_InsertRegisterDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@recrName", rrentity.FullName);
                //cmd.Parameters.AddWithValue("@company", rrentity.Company);
                //cmd.Parameters.AddWithValue("@mobNo", rrentity.MobileNo);
                //cmd.Parameters.AddWithValue("@oficialEmailid", rrentity.OficialEmailId);
                //cmd.Parameters.AddWithValue("@city", rrentity.City);
                //cmd.Parameters.AddWithValue("@password", rrentity.Password);
                //cmd.Parameters.AddWithValue("@photoPath", rrentity.PhotoPath);
                //cmd.Parameters.Add("@setrecruiterid", SqlDbType.VarChar, 500);
                //cmd.Parameters["@setrecruiterid"].Direction = ParameterDirection.Output;
                //int result = cmd.ExecuteNonQuery();
                //string recId = cmd.Parameters["@setrecruiterid"].Value.ToString();
                //if (result > 0)
                //{
                //    if (recId != null)
                //    {
                //        return recId;
                //    }
                //}
                //return null;



                ///code to check

                SqlParameter[] param = new SqlParameter[7];
                param[0] = new SqlParameter("@recrName", rrentity.FullName);
                param[1] = new SqlParameter("@company", rrentity.Company);
                param[2] = new SqlParameter("@mobNo", rrentity.MobileNo);
                param[3] = new SqlParameter("@oficialEmailid", rrentity.OficialEmailId);
                param[4] = new SqlParameter("@city", rrentity.City);
                param[5] = new SqlParameter("@password", rrentity.Password);
                param[6] = new SqlParameter("@photoPath", rrentity.PhotoPath);
                param[7] = new SqlParameter("@setrecruiterid", SqlDbType.VarChar);
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
