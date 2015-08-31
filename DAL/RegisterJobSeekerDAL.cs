using Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class RegisterJobSeekerDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Register Jobseeker
        /// </summary>
        /// <param name="rjsEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int RegisterNewJobSeekerDAL(RegisterJobSeekerEntity rjsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
                                              new SqlParameter("@uid", rjsEntity.UserId),
                                              new SqlParameter("@fname", rjsEntity.FirstName ),
                                              new SqlParameter("@lname", rjsEntity.LastName),
                                              new SqlParameter("@emailId", rjsEntity.EmailId),
                                              new SqlParameter("@gender", rjsEntity.Gender),
                                              new SqlParameter("@desiredUserName", rjsEntity.DesiredUserName),
                                              new SqlParameter("@mobNo", rjsEntity.MobileNo),
                                              new SqlParameter("@currCity", rjsEntity.CurrentCity),
                                              new SqlParameter("@address", rjsEntity.CurrentAddress),
                                              new SqlParameter("@password",rjsEntity.Password),
                                              new SqlParameter("@uploadresumepath", rjsEntity.UploadResumepath.ToString())
                                              
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "InsertJSRegister", sqlparams);

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

        /// <summary>
        /// Forget Password of job seeker
        /// </summary>
        /// <param name="fpEntity">To get parameters from database</param>
        ///
        /// <returns>DataSet</returns>
        public DataSet GetEmailDetailsDAL(ForgetPasswordEntity fpEntity)
        {
            connection.Open();

            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("ForgetPassword", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", fpEntity.EmailId.ToString());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "EmailDetails");
                connection.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Login of jobseeker
        /// </summary>
        /// <param name="logjsEntity">To add parameters into database</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader JobSeekerLoginDAL(LogInJobSeekerEnitity logjsEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = { new SqlParameter("@userName", logjsEntity.UserName), 
                                               new SqlParameter("@password", logjsEntity.Password)
                                               
                                           };
                SqlDataReader dr = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, "selectJobSeeker", sqlparams);
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //connection.Close();
            }
        }

        /// <summary>
        /// Changing Password of Jobseeker
        /// </summary>
        /// <param name="cpentity">To add parameters into database</param>
        /// <returns>System.Int32</returns>
        public int ChangePasswordDAL(ChangePasswordEnitity cpentity)
        {
            connection.Close();
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
               
                SqlParameter[] sparams = { new SqlParameter("@userName", cpentity.UserName), new SqlParameter("@newpassword", cpentity.NewPassword), new SqlParameter("@oldpassword", cpentity.OldPassword) };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "ChangePassword", sparams);

                connection.Close();

                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return -1;
                }
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

       /// <summary>
       /// Current Professional Details of job seeker
       /// </summary>
       /// <param name="curentity">To add parameters into database</param>
       /// <returns>System.Int32</returns>

        public int CurrentProfessionalDetailsDAL(Current_DesiredJobDetailsEntity curentity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sparams = { new SqlParameter("@userid",curentity.Userid),
                                       new SqlParameter("@resumeheadline",curentity.ResumeHeadline),
                                       new SqlParameter("@totalExp",curentity.TotalExperience),
                                       new SqlParameter("@industry",curentity.Industry),
                                       new SqlParameter("@department",curentity.Department),
                                       new SqlParameter("@currentjobrole",curentity.CurrentJobRole),
                                       new SqlParameter("@currentemployer",curentity.CurrentEmployer),
                                       new SqlParameter("@primfunrole",curentity.PrimFunctionalRole),
                                       new SqlParameter("@primjobdesrip",curentity.PrimJobDescrip),
                                       new SqlParameter("@primtechskills",curentity.PrimTechSkills),
                                       new SqlParameter("@secfunrole",curentity.SecFunctionalRole),
                                       new SqlParameter("@secjobdescrip",curentity.SecJobDescrip),
                                       new SqlParameter("@sectechskills",curentity.SecTechSkills),
                                       new SqlParameter("@technicalskills",curentity.TechnicalSkills),
                                       new SqlParameter("@reasonforjobchange",curentity.ReasonforJobChange),
                                       new SqlParameter("@designation",curentity.Designation)};
                int res = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "InsertProfessionalCurrentDetails", sparams);
                return res;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
           
        }
      

  
       

        public DataSet LoadCityAll(CityEntity cityentity)
        {

            // DataTable table = new DataTable();
            //// SqlCommand cmd = new SqlCommand("select * from CityMaster where stateID="+stateID, connection);
            //// cmd.Parameters.AddWithValue("@stateID",stateID);
            // SqlDataAdapter da = new SqlDataAdapter(cmd);
            // da.Fill(table);
            // return table;



            try
            {
                connection.Open();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand("selectcity", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cityID", cityentity.cityID);
                cmd.Parameters.AddWithValue("@cityName", cityentity.cityName);
                cmd.Parameters.AddWithValue("@stateID", cityentity.stateID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "EmailDetails");
                connection.Close();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //connection.Close();
            }
        }
              
            
    
        }
    }
