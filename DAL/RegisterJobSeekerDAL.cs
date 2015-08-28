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
    public class RegisterJobSeekerDAL
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        /// <summary>
        /// Register Jobseeker 
        /// </summary>
        /// <param name="rjsEntity">Object for inserting data into database</param>
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// <returns></returns>
        public SqlDataReader JobSeekerLoginDAL(LogInJobSeekerEnitity logjsEntity)
        {

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = { new SqlParameter("@userName", logjsEntity.UserName), new SqlParameter("@password", logjsEntity.Password) };
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
        /// <returns></returns>
        public int ChangePasswordDAL(ChangePasswordEnitity cpentity)
        {

            connection.Close();
            try
            {


                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
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
        public int InsertContactInfo(ContactDetailsJobSeekerEntity Cdentity)
        {
            connection.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams = {
  new SqlParameter("@uId", Cdentity.UserID), 
  new SqlParameter("@altMobNo",Cdentity.AltMobileNo ),
  new SqlParameter("@landNo", Cdentity.LandLineNo),
  new SqlParameter("@whatsappNo",Cdentity.WhatsAppNo ),
  new SqlParameter("@linkedId", Cdentity.LinkedID),
  new SqlParameter("@fbId",Cdentity.FacebookID ),
  new SqlParameter("@twitterId",Cdentity.TwitterID ),
  new SqlParameter("@Gtalk",Cdentity.GtalkID),
  new SqlParameter("@skypeId",Cdentity.SkypeID),
  new SqlParameter("@googleP",Cdentity.GooglePlus)
  
};
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "insertJSContactDetails", sqlparams);

                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
