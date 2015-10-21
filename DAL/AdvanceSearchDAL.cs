using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AdvanceSearchDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public DataSet GetStateDAL()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from State");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetTechnicalSkillDAL(string prefixText)
        {
            DataTable dt = new DataTable();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from TechnicalSkillsDetails where TechnicalSkillName like @KeySkills+'%'", connection);
            cmd.Parameters.AddWithValue("@KeySkills", prefixText);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            return dt;
        }
    }
}