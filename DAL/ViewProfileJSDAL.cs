using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    ///
    /// </summary>
    public class ViewProfileJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// View profile summary dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewProfileDAL(string candidateId)
        {
            // try
            // {
            //ds= SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from JS_RegisterDetails where CandidateId='JS12'");
            //viewProfileEntity.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
            //viewProfileEntity.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
            //viewProfileEntity.MobileNumber = ds.Tables[0].Rows[0]["MobileNo"].ToString();
            //viewProfileEntity.EmailId = ds.Tables[0].Rows[0]["EmailId"].ToString();
            //   SqlParameter[] sparams1=new SqlParameter[1];
            //     sparams1[0]=new SqlParameter("@id","JS12");
            //ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_JS_SelectPersonalDetails",sparams1);
            //     viewProfileEntity.Birthdate=Convert.ToDateTime(ds.Tables[0].Rows[0]["DateOfBirth"].ToString());
            //     viewProfileEntity.Address=ds.Tables[0].Rows[0]["CurrentAddress"].ToString();
            // }
            // catch (Exception)
            // {
            //     throw;
            // }
            //return ds;
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_ViewProfile, sparams);
            }
            catch (Exception)
            {
                //  throw;
            }
            return ds;
        }

        /// <summary>
        /// View contact details dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewContactDetailsDAL(string candidateId)
        {
            DataSet dsContactDetails = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsContactDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectContactDetails, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            return dsContactDetails;
        }

        /// <summary>
        /// View personal details dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewPersonalDetailsDAL(string candidateId)
        {
            DataSet dsPersonalDetails = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsPersonalDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectPersonalDetails, sparams);
            }
            catch (Exception)
            {
                //  throw;
            }
            return dsPersonalDetails;
        }

        /// <summary>
        /// View affirmative details dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewAffirmativeDetailsDAL(string candidateId)
        {
            DataSet dsAffirmativeDetails = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsAffirmativeDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectAffirmativeDetails, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            return dsAffirmativeDetails;
        }

        /// <summary>
        /// View project details dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewProjectDetailsDAL(string candidateId)
        {
            DataSet dsProjectDetails = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsProjectDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectProjectDetails, sparams);
            }
            catch (Exception)
            {
                //  throw;
            }
            return dsProjectDetails;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="candidateId"></param>
        /// <returns></returns>
        public DataSet ViewEducationalDetailsDAL(string candidateId)
        {
            DataSet dsEducationalDetails = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsEducationalDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_Test", sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return dsEducationalDetails;
        }

        /// <summary>
        /// View technical skills dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewTechnicalSkillsDAL(string candidateId)
        {
            DataSet dsViewTechnicalSkills = new DataSet();
            SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
            dsViewTechnicalSkills = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectTechnicalSkills, sparams);
            return dsViewTechnicalSkills;
        }

        public int ChangeConatctNoDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams = new SqlParameter[2];
            sparams[0] = new SqlParameter("@id", "JS12");
            sparams[1] = new SqlParameter("@newmobNo", viewProfileEntity.MobileNumber);
            int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateContactDetails, sparams);
            return result;
        }

        public int ResumeDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams = new SqlParameter[2];
            sparams[0] = new SqlParameter("@id", "JS12");
            int result = 1;
            return result;
        }

        public int ChangePersonalDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams = new SqlParameter[6];
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