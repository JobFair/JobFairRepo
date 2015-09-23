using Entities.JobSeeker;
using System;
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
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// method for converting the object to XML.
        /// </summary>
        /// <param name="languageDetails"></param>
        /// <returns></returns>
        private string CreateXML(LanguageEntity languageDetails)
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
        /// <returns></returns>
        public int SaveLanguageDetailsDAL(LanguageEntity languageEntity)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();

            // Get xml string data from object
            string languageDetails = CreateXML(languageEntity);

            SqlParameter[] sqlparams = { new SqlParameter("@languageDetails", languageDetails) };

            int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertLanguageDetails, sqlparams);
            return result;
        }

        /// <summary>
        /// Insert Affirmative Details
        /// </summary>
        /// <param name="affirmativeDetailsEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int SaveAffirmativeDetailsDAL(AffirmativeDetailsEntity affirmativeDetailsEntity)
        {
            int result;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams ={
                                          new SqlParameter("@candidateId",affirmativeDetailsEntity.CandidateId),
                                          new SqlParameter("@physicallyChallenged",affirmativeDetailsEntity.PhysicallyChallenged),
                                          new SqlParameter("@description",affirmativeDetailsEntity.Description),
                                          new SqlParameter("@sports",affirmativeDetailsEntity.Sports),
                                          new SqlParameter("@sportsDescription",affirmativeDetailsEntity.SportsDescription),
                                          new SqlParameter("@usaPermit",affirmativeDetailsEntity.USAPermit),
                                          new SqlParameter("@otherPermits",affirmativeDetailsEntity.OtherPermits),
                                          };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_OtherDetails, sqlparams);
                return result;
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