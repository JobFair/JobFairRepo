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
        public DataSet ViewProfileDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            try
            {

          
           ds= SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from JS_RegisterDetails where CandidateId='JS12'");
           viewProfileEntity.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
           viewProfileEntity.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
           viewProfileEntity.MobileNumber = ds.Tables[0].Rows[0]["MobileNo"].ToString();           
           viewProfileEntity.EmailId = ds.Tables[0].Rows[0]["EmailId"].ToString();
            }
            catch (Exception)
            {

                throw;
            }
           return ds;

        }

        public int ChangeConatctNoDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams =new SqlParameter[2];
            sparams[0]=new SqlParameter("@id","JS12");
            sparams[1]=new SqlParameter("@newmobNo",viewProfileEntity.MobileNumber);
            int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateContactDetails, sparams);
            return result;
        }

        public int ResumeDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams = new SqlParameter[2];
            sparams[0] = new SqlParameter("@id", "JS12");
            int result=1;
            return result;
 
        }
    }
}
