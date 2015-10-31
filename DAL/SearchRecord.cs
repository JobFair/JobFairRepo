using Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
   public class SearchRecordDAL
    {
       private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

       public DataSet searchrecordDAL(string searchvar)
       {
           DataSet ds = new DataSet();
           connection.Open();
           SqlCommand cmd = new SqlCommand("select PermantAddress  from JS_PersonalDetails where PermantAddress Like @PermantAddress+'%';", connection);
           cmd.Parameters.AddWithValue("@PermantAddress", searchvar);
           SqlDataAdapter ada = new SqlDataAdapter(cmd);
           //ada.SelectCommand = cmd;
           ada.Fill(ds);
           return ds;
       }
    }
}
