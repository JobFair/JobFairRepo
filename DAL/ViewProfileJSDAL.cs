﻿using System;
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

        /// <summary>
        /// View professional summary dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewProfessionalDetailsDAL(string candidateId)
        {
            DataSet dsProfessionalDetails = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsProfessionalDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectCurrentDesiredJobDetails, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return dsProfessionalDetails;
        }

        /// <summary>
        /// View current past job details dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewCurrentPastJobDetailsDAL(string candidateId)
        {
            DataSet dsCurrentPastJobDetails = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsCurrentPastJobDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectCurrentPastJobDeatails, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return dsCurrentPastJobDetails;
        }

        /// <summary>
        /// View job post looking for dal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewJobPostLookingDAL(string candidateId)
        {
            DataSet dsJobPostLooking = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsJobPostLooking = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectJobPostLookingFor, sparams);
            }
            catch (Exception)
            {
                throw;
            }
            return dsJobPostLooking;
        }

    }
}