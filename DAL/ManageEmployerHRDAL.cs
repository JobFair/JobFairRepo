using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.HR;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DAL
{
    /// <summary>
    /// Class ManageEmployerHRDAL
    /// </summary>
    public class ManageEmployerHRDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Method of class ManageEmployerHRDAL for Managing EmployerDetails in database
        /// </summary>
        /// <returns>System.Int32</returns>
        public DataSet ManageEmployerDetailsDAL(long HrId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = {
                                             new SqlParameter("@hrId",HrId)
                                         };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_HR_ManageEmployerDetails, sparams);
            }
            catch (Exception)
            {
                //throw;
            }
            return ds;
        }
    }
}
