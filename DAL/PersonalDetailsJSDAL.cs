using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entities;
using System.IO;

namespace DAL
{
   public class PersonalDetailsJSDAL
    {
       private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
     
       public DataSet LoadCountryAll()
       {

           DataSet ds = new DataSet();
           //SqlCommand cmd = new SqlCommand("select * from Country", connection);
           //SqlDataAdapter da = new SqlDataAdapter(cmd);
           //da.Fill(ds);
           //return ds;
           //string query = "SELECT * FROM Country";
           //DataSet ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, query);
           DataSet result = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Country");
          return ds; 

       }
       public DataTable LoadStateAll(int CountryId)
       {
           DataTable table = new DataTable();
           SqlCommand cmd = new SqlCommand("select * from State where CountryId="+CountryId,connection);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(table);
           return table;
       }
       public DataTable LoadCityAll(int StateId)
       {
           DataTable table = new DataTable();
           SqlCommand cmd = new SqlCommand("select * from City where StateId="+StateId,connection);
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(table);
           return table;
       }

       /// <summary>
       /// Pesonal Details of job seeker
       /// </summary>
       /// <param name="pdEntity">Object for inserting data into database</param>
       /// <returns>System.Int32</returns>
       public int PersonalDetailsInsert(PersonalDetailsJSEntity pdEntity)
       {
           try
           {
           connection.Open();
           SqlCommand cmd = new SqlCommand();
          
           SqlParameter[] sqlparams = {
                                              new SqlParameter("@candidateId",pdEntity.candidateId),
                                              new SqlParameter("@pressentAddress",pdEntity.presentAddress),
                                              new SqlParameter("@presentCountry",pdEntity.presentCountry),
                                              new SqlParameter("@presentState",pdEntity.presentState),
                                              new SqlParameter("@presentCity",pdEntity.presentCity),
                                              new SqlParameter("@presentArea",pdEntity.presentArea),
                                              new SqlParameter("@presentPincode",pdEntity.presentPincode),
                                              new SqlParameter("@permantAddress",pdEntity.permantAddress),
                                              new SqlParameter("@permantCountry",pdEntity.permantCountry),
                                              new SqlParameter("@permantState",pdEntity.permantState),
                                              new SqlParameter("@permantCity",pdEntity.permantCity),
                                              new SqlParameter("@permantArea",pdEntity.permantArea),
                                              new SqlParameter("@permantPincode",pdEntity.permantPincode),
                                              new SqlParameter("@dateOfBirth", pdEntity.dateOfBirth.Date),
                                              new SqlParameter("@gender",pdEntity.gender),
                                              new SqlParameter("@maritialStatus",pdEntity.maritialStatus),
                                              new SqlParameter("@passportNumber", pdEntity.passportNumber),
                                              new SqlParameter("@passportValidity",pdEntity.passportValidity.Date),
                                              new SqlParameter("@workStatus", pdEntity.workStatus),
                                              new SqlParameter("@photo", "~/UploadImages/"+pdEntity.photo)
                                              
                                            };
           int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertPersonalDetails", sqlparams);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
       }
    }
}
