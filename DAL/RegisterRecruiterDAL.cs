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
                cmd.Parameters.AddWithValue("@recrName", rrentity.FullName);
                cmd.Parameters.AddWithValue("@company", rrentity.Company);
                cmd.Parameters.AddWithValue("@mobNo", rrentity.MobileNo);
                cmd.Parameters.AddWithValue("@oficialEmailid", rrentity.OficialEmailId);
                cmd.Parameters.AddWithValue("@city", rrentity.City);
                cmd.Parameters.AddWithValue("@password", rrentity.Password);
                cmd.Parameters.AddWithValue("@photoPath", rrentity.PhotoPath);
                cmd.Parameters.Add("@setrecruiterid", SqlDbType.VarChar, 500);
                cmd.Parameters["@setrecruiterid"].Direction = ParameterDirection.Output;
                int result = cmd.ExecuteNonQuery();
                string recId = cmd.Parameters["@setrecruiterid"].Value.ToString();
                if (result > 0)
                {
                    if (recId != null)
                    {
                        return recId;
                    }
                }
                return null;



                ///code to check

                //SqlParameter[] sparams ={new SqlParameter("@recrName",rrentity.FullName),
                //                   new SqlParameter("@company",rrentity.Company),
                //                   new SqlParameter("@mobNo",rrentity.MobileNo),
                //                   new SqlParameter("@oficialEmailid",rrentity.OficialEmailId),
                //                   new SqlParameter("@city",rrentity.City),
                //                   new SqlParameter("@password",rrentity.Password),
                //                   new SqlParameter("@photoPath",rrentity.PhotoPath),
                //                   new SqlParameter("@setrecruiterid",SqlDbType.VarChar,500,ParameterDirection.Output,true,0,0,"RecruiterID",DataRowVersion.Current,null)
                //                        };
               
                //int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_RE_InsertRegisterDetails", sparams);
                //string id =  ???? ;
                //if (result > 0)
                //{
                //    return id;
                //}
                //else
                //{
                //    return null;
                //}

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
