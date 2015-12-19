using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    /// <summary>
    /// Class ViewProfileJSDAL 
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
        /// View educational details dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewEducationalDetailsDAL(string candidateId)
        {
            DataSet dsEducationalDetails = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsEducationalDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_ViewEducationalDetails, sparams);
            }
            catch (Exception)
            {
                // throw;
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
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsViewTechnicalSkills = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectTechnicalSkills, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            return dsViewTechnicalSkills;
        }

        /// <summary>
        /// View role skills dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewRoleSkillsDAL(string candidateId)
        {
            DataSet dsRoleSkills = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsRoleSkills = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectRoleSkills, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            return dsRoleSkills;
        }

        /// <summary>
        /// View workshop dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewWorkshopDAL(string candidateId)
        {
            DataSet dsWorkshop = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsWorkshop = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectMoreWorkshop, sparams);
            }
            catch (Exception)
            {
               // throw;
            }
            return dsWorkshop;
        }

        /// <summary>
        /// View certification dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewCertificationDAL(string candidateId)
        {
            DataSet dsCertification = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsCertification = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectCertification, sparams);
            }
            catch (Exception)
            {
               // throw;
            }
            return dsCertification;
        }

        //public int ChangeConatctNoDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        //{
        //    SqlParameter[] sparams = new SqlParameter[2];
        //    sparams[0] = new SqlParameter("@id", "JS12");
        //    sparams[1] = new SqlParameter("@newmobNo", viewProfileEntity.MobileNumber);
        //    int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateContactDetails, sparams);
        //    return result;
        //}

        //public int ResumeDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        //{
        //    SqlParameter[] sparams = new SqlParameter[2];
        //    sparams[0] = new SqlParameter("@id", "JS12");
        //    int result = 1;
        //    return result;
        //}

        //public int ChangePersonalDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        //{
        //    SqlParameter[] sparams = new SqlParameter[6];
        //    sparams[0] = new SqlParameter("@id", "JS12");
        //    sparams[1] = new SqlParameter("@firstName", viewProfileEntity.FirstName);
        //    sparams[2] = new SqlParameter("@lastName", viewProfileEntity.LastName);
        //    sparams[3] = new SqlParameter("@emailId", viewProfileEntity.EmailId);
        //    sparams[4] = new SqlParameter("@dateOfBirth", viewProfileEntity.Birthdate.ToShortDateString());
        //    sparams[5] = new SqlParameter("@address", viewProfileEntity.Address);
        //    int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_UpdatePersonalDetails", sparams);
        //    return result;
        //}
    }
}