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
  public   class ViewApplicationsDAL
    {
      private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public System.Data.DataSet GetCandidateDetails(   string candidateId)
        {
            DataSet dsviewapplications = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsviewapplications = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectViewAllCandidate, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return dsviewapplications;
        }
    }
}
