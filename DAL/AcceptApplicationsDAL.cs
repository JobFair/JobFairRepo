using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class AcceptApplicationsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        /// <summary>
        /// create DAL method for get  acceppt candidate
        /// </summary>
        /// <param name="candidateId"></param>
        /// <returns></returns>
        public System.Data.DataSet GetAcceptCandidate(  int candidateId)
        {
            
            DataSet dsacceptcandidate = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsacceptcandidate = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectAcceptApplication, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return  dsacceptcandidate;
           
        }
    }
}
