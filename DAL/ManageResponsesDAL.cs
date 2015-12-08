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

    public class ManageResponsesDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        public DataSet BindClientNameDAL(Entities.Recruiter.ManageResponsesEntity manageResponsesEntity)
        {
            try
            {
                DataSet datasetClientName = new DataSet();
                SqlParameter[] sparams={new SqlParameter("@recruiterId",manageResponsesEntity.RecruiterId)};
                return datasetClientName = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_RE_SelectClients, sparams);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
