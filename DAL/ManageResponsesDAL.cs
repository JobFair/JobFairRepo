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


        public DataSet GetActiveJobs()
        {
            DataSet dsactivejobs = new DataSet();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_RE_ManageResponsesActiveJobs", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsactivejobs);

            }
            catch (Exception)
            {

                throw;
            }
            return dsactivejobs;


        }

        public DataSet GetInActiveJobs()
        {
            DataSet dsinactivejobs = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_RE_ManageReponsesInActiveJobs", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsinactivejobs);
            }
            catch (Exception)
            {
                
                throw;
            }
            return dsinactivejobs;
        }
    }
}
