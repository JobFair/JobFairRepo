using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.HR;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Class ManageClientHRDAL
    /// </summary>
    public class ManageClientHRDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        
        /// <summary>
        /// Method of class ManageClientHRDAL for Managing ClientDetails in database
        /// </summary>
        /// <returns>System.Int32</returns>
        public DataSet ManageClientDetailsDAL(long HrId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = {
                                             new SqlParameter("@hrId",HrId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_HR_ManageClientDetails, sparams);
            }
            catch (Exception)
            {
                //throw;
            }
            return ds;
        }
    }
}
