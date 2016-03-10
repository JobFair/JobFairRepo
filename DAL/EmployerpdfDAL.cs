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

   
   public class EmployerpdfDAL
    {
       private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public System.Data.DataSet GetEmployerDetails()
        {
            DataSet dsemployerdetails = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Emp_SelectEmployerDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsemployerdetails);




            }
            catch (Exception)
            {
                
                throw;
            }
            return dsemployerdetails;
           
        }
    }
}
