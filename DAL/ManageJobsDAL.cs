using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Recruiter;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class ManageJobsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        private DataSet ds = new DataSet();

        /// <summary>
        /// View Manage Jobs of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet ManageJobsDetetailsDAL()
        {
            try
            {
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_RE_SelectViewJobPost");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
