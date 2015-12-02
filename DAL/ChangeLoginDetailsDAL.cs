using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class ChangeLoginDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public System.Data.DataSet GetLoginDetailsDAL(string candidateId)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_JS_ChangeLoginDetails", sparams);

                return ds;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
