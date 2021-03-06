﻿using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DAL
{
    public class AffirmativeDetailsJSDAL
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Method for converting the object to XML.
        /// </summary>
        /// <param name="languageDetails">languageDetails</param>
        /// <returns>xml</returns>
        private string CreateXML(List<LanguageEntity> languageDetails)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(languageDetails.GetType());

            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, languageDetails);
                xmlStream.Position = 0;
                xmlDoc.Load(xmlStream);
                return xmlDoc.InnerXml;
            }
        }

        /// <summary>
        /// Insert languageDetails
        /// </summary>
        /// <param name="languageDetails">Object for inserting data into database</param>
        /// <returns>True/false</returns>
        public bool SaveLanguageDetailsDAL(List<LanguageEntity> languageEntity)
        {
            try
            {
                // Get xml string data from object
                string languageDetails = CreateXML(languageEntity);

                SqlParameter[] sqlparams = { new SqlParameter("@adEntity", languageDetails) };

                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertLanguageDetails, sqlparams);
                if (result > 0)
                {
                    return true;
                }
                return false;
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
        /// Insert Affirmative Details
        /// </summary>
        /// <param name="affirmativeDetailsEntity">Object for inserting data into database</param>
        /// <returns>True/false</returns>
        public bool SaveAffirmativeDetailsDAL(AffirmativeDetailsEntity affirmativeDetailsEntity)
        {
            int result;
            try
            {
                SqlParameter[] sqlparams ={
                                          new SqlParameter("@candidateId",affirmativeDetailsEntity.CandidateId),
                                          new SqlParameter("@physicallyChallenged",affirmativeDetailsEntity.PhysicallyChallenged),
                                          new SqlParameter("@description",affirmativeDetailsEntity.Description),
                                          new SqlParameter("@sports",affirmativeDetailsEntity.Sports),
                                          new SqlParameter("@sportsDescription",affirmativeDetailsEntity.SportsDescription),
                                          new SqlParameter("@usaPermit",affirmativeDetailsEntity.USAPermit),
                                          new SqlParameter("@otherPermits",affirmativeDetailsEntity.OtherPermits),
                                          new SqlParameter ("@hobbies",affirmativeDetailsEntity.Hobbies),
                                          new SqlParameter ("@extraActivity",affirmativeDetailsEntity.ExtraActivity)
                                          };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertOtherDetails, sqlparams);
                if (result > 0)
                {
                    return true;
                }
                return false;
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

        public DataSet ViewAffirmativeDetialsDAL(string candidateId)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectAffirmativeDetails, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            return ds;
        }

        public bool UpdateAffirmativeDetailsDAL(AffirmativeDetailsEntity affirmativeDetailsEntity)
        {
            try
            {
                SqlParameter[] sqlparams ={
                                          new SqlParameter("@candidateId",affirmativeDetailsEntity.CandidateId),
                                          new SqlParameter("@physicallyChallenged",affirmativeDetailsEntity.PhysicallyChallenged),
                                          new SqlParameter("@description",affirmativeDetailsEntity.Description),
                                          new SqlParameter("@sports",affirmativeDetailsEntity.Sports),
                                          new SqlParameter("@sportsDescription",affirmativeDetailsEntity.SportsDescription),
                                          new SqlParameter("@usaPermit",affirmativeDetailsEntity.USAPermit),
                                          new SqlParameter("@otherPermits",affirmativeDetailsEntity.OtherPermits),
                                          new SqlParameter ("@hobbies",affirmativeDetailsEntity.Hobbies),
                                          new SqlParameter ("@extraActivity",affirmativeDetailsEntity.ExtraActivity)
                                          };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateAffirmativeDetails, sqlparams);
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateLanguageDetailsDAL(List<LanguageEntity> languageEntity, string candidateId)
        {
            try
            {
                // Get xml string data from object
                string languageDetails = CreateXML(languageEntity);

                SqlParameter[] sqlparams = { new SqlParameter("@adEntity", languageDetails),
                                               new SqlParameter("@candidateId",candidateId)
                                            };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateLanguageDetails, sqlparams);
                if (result > 0)
                {
                    return true;
                }
                return false;
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
    }
}