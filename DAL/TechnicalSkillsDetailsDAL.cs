using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TechnicalSkillsDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        private DataSet ds = new DataSet();

        public DataSet TechnicalSkillLanguageDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "SELECT * FROM TechnicalSkillsDetails WHERE TechnicalSkillTypeId= 1");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet DatabaseDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "SELECT * FROM TechnicalSkillsDetails WHERE TechnicalSkillTypeId= 2");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet SoftwaresDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "SELECT * FROM TechnicalSkillsDetails WHERE TechnicalSkillTypeId= 3");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet OperatingSystemDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "SELECT * FROM TechnicalSkillsDetails WHERE TechnicalSkillTypeId= 4");
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}