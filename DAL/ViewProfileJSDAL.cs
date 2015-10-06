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
    public class ViewProfileJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        private DataSet ds = new DataSet();
        public void ViewProfileDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            
        }
    }
}
