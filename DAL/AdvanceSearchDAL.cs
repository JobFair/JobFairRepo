using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
   
   public class AdvanceSearchDAL
    {
        
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public DataSet GetStateDAL()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from State");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetSkills(string skills)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from City where CityName like %'" + skills +"'%'");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
