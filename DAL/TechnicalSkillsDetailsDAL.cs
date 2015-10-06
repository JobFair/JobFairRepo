﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TechnicalSkillsDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        private DataSet ds = new DataSet();

        public DataSet TechnicalSkillDAL()
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
    }
}