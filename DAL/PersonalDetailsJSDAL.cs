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
   public class PersonalDetailsJSDAL
    {
       private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
       public DataTable LoadCountryAll()
       {

           DataTable table = new DataTable();
           SqlCommand cmd = new SqlCommand("select * from CountryMaster", connection);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(table);
           return table;


       }
       public DataTable LoadStateAll(int CountryId)
       {
           DataTable table = new DataTable();
           SqlCommand cmd = new SqlCommand("select * from StateMaster where CountryId="+CountryId,connection);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(table);
           return table;
       }
       public DataTable LoadCityAll(int StateId)
       {
           DataTable table = new DataTable();
           SqlCommand cmd = new SqlCommand("select * from CityMaster where StateId="+StateId,connection);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(table);
           return table;
       }

    }
}
