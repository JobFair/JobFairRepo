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
   public class JobApplicationDAL
    {
       private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public  DataSet Getdata()
        {
            DataSet dsapply = new DataSet();

            connection.Open();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_JS_SelectApplyCandidate", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsapply);

            }
            catch (Exception)
            {
                
                throw;
            }
            return dsapply;
        }
    }
}
