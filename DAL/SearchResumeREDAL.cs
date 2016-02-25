using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SearchResumeREDAL
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataSet GetClientNameDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectActiveClientName);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        public DataSet GetPositionDAL(long clientId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@clientId", clientId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectActiveRequirementPosition, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return ds;
        }

        public int GetRequirementIdDAL(string position)
        {
            Int32 requirementId = 0;
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@position", position) };
                requirementId = Convert.ToInt32(SqlHelper.ExecuteScalar(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectRequirementId, sparams));
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return requirementId;
        }

        public DataTable GetRolesDAL(string prefixText)
        {
            connection.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Constants.sp_SelectRoleSkills, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleName", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataTable GetTechnicalSkillsDAL(string prefixText)
        {
            connection.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Constants.sp_SelectTechnicalSkills, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TechnicalSkillName", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}