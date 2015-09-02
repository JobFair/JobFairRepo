using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entities;

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

       public int PersonalDetailsInsert(PersonalDetailsJSEntity pdEntity)
       {
           try
           {
           connection.Open();
           SqlCommand cmd = new SqlCommand();
           SqlParameter[] sqlparams = {
                                              new SqlParameter("@userID",pdEntity.userID),
                                              new SqlParameter("@PressentAddress",pdEntity.PressentAddress),
                                              new SqlParameter("@PresentCountry",pdEntity.PressentCountry),
                                              new SqlParameter("@PresentState",pdEntity.PressentState),
                                              new SqlParameter("@PresentCity",pdEntity.PressentCity),
                                              new SqlParameter("@PresentArea",pdEntity.PresentArea),
                                              new SqlParameter("@PresentPincode",pdEntity.PresentPincode),
                                              new SqlParameter("@PermantAddress",pdEntity.PermantAddress),
                                              new SqlParameter("@PermantCountry",pdEntity.PermantCountry),
                                              new SqlParameter("@PermantState",pdEntity.PermantState),
                                              new SqlParameter("@PermantCity",pdEntity.PermantCity),
                                              new SqlParameter("@PermantArea",pdEntity.PermantArea),
                                              new SqlParameter("@PermantPincode",pdEntity.PermantPincode),
                                              new SqlParameter("@DateOfBirth", pdEntity.DateOfBirth),
                                              new SqlParameter("@Gender",pdEntity.Gender),
                                              new SqlParameter("@MaritialStatus",pdEntity.MaritialStatus),
                                              new SqlParameter("@PassportNumber", pdEntity.PassportNumber),
                                              new SqlParameter("@PassportValidity",pdEntity.PassportValidity),
                                              new SqlParameter("@Languages", pdEntity.Languages),
                                              new SqlParameter("@WorkStatus", pdEntity.WorkStatus),
                                              new SqlParameter("@Photo", pdEntity.Photo)
                                              
                                            };
           int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "InsertJSPersonalDetails", sqlparams);

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
