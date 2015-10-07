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
              SqlParameter[] sparams1=new SqlParameter[1];
                sparams1[0]=new SqlParameter("@id","JS12");
           ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_JS_SelectPersonalDetails",sparams1);
                viewProfileEntity.Birthdate=Convert.ToDateTime(ds.Tables[0].Rows[0]["DateOfBirth"].ToString());
                viewProfileEntity.Address=ds.Tables[0].Rows[0]["CurrentAddress"].ToString();
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

        public int ChangePersonalDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams=new SqlParameter[6];
            sparams[0] = new SqlParameter("@id", "JS12");
            sparams[1] = new SqlParameter("@firstName", viewProfileEntity.FirstName);
            sparams[2] = new SqlParameter("@lastName", viewProfileEntity.LastName);
            sparams[3] = new SqlParameter("@emailId", viewProfileEntity.EmailId);
            sparams[4] = new SqlParameter("@dateOfBirth", viewProfileEntity.Birthdate.ToShortDateString());
            sparams[5] = new SqlParameter("@address", viewProfileEntity.Address);
            int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_UpdatePersonalDetails", sparams);
            return result;
        }
    }
}
