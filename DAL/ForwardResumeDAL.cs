using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;

namespace DAL
{
    
      
     public class ForwardResumeDAL
    {
         private SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        
        public DataSet GetClientName()
        {
            DataSet dsclientname = new DataSet();
            try
            {
                dsclientname = SqlHelper.ExecuteDataset(Connection, CommandType.Text, "select ClientName,ClientId from HR_ClientDetails");

            }
            catch (Exception)
            {
                
                throw;
            }
            return dsclientname;
        }

        public DataSet GetEmailId(int clientid)
        {
            DataSet dsemailid = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@clientId", clientid) };
                dsemailid = SqlHelper.ExecuteDataset(Connection, CommandType.StoredProcedure, Constants.sp_RE_SelectResumeForward, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
            return dsemailid;
        }
    }
}
