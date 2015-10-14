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
        private DataSet ds = new DataSet();
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public DataSet GetStateDAL()
        {
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
    }
}
