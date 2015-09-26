using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entities.Recruiter;

namespace DAL
{
   public class ViewProfileREDAL
    {
       DataSet ds = new DataSet();
       
       private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
       public DataSet ViewProfileDAL(ViewProfileEntity viewProfileEntity)
       {
           SqlDataAdapter sda = new SqlDataAdapter();
           ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from RE_RegisterDetails where RecruiterID='RE11'");
          
           viewProfileEntity.name = ds.Tables["temp"].Rows[0]["RecruiterfullName"].ToString();
           viewProfileEntity.companyName = ds.Tables["temp"].Rows[0]["Company"].ToString();
           viewProfileEntity.mobNo = ds.Tables["temp"].Rows[0]["MobileNumber"].ToString();
           viewProfileEntity.emailId = ds.Tables["temp"].Rows[0]["OficialEmail_ID"].ToString();
           viewProfileEntity.city = ds.Tables["temp"].Rows[0]["City"].ToString();
           viewProfileEntity.photo = ds.Tables["temp"].Rows[0]["PhotoPath"].ToString() + "L1-whte" + ".jpg";
           return ds;
       }
    }
}
