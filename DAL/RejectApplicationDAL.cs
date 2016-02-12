using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   
    public class RejectApplicationDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        ///   Create  DAL for rejet Application
        /// </summary>
        /// <param name="candidateId"></param>
        /// <returns></returns>
        public System.Data.DataSet GetRejectAplication(int candidateId)
        {
            DataSet dsrejectapplication = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsrejectapplication = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectRejectApplication, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return dsrejectapplication;

        }


    }
}
