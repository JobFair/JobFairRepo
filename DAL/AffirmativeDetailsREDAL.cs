using Entities.Recruiter;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DAL
{
    public class AffirmativeDetailsREDAL
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Method for converting the object to XML.
        /// </summary>
        /// <param name="languageDetails">Parameter languageDetails</param>
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
        /// Method to Save language details in AffirmativeDetailsREDAL class
        /// </summary>
        /// <param name="languageDetailsList">Parameter of List of LanguageEntity class</param>
        /// <returns>System.Boolean</returns>
        public bool SaveLanguageDetailsDAL(List<Entities.Recruiter.LanguageEntity> languageDetailsList)
        {
            try
            {
                // Get xml string data from object
                string languageDetails = CreateXML(languageDetailsList);

                SqlParameter[] sqlparams = { new SqlParameter("@adEntity", languageDetails) };

                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_InsertLanguageDetails, sqlparams);
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
        /// Method to save affirmative details in AffirmativeDetailsREDAL class
        /// </summary>
        /// <param name="affirmativeDetailsEntity">Parameter of AffirmativeDetailsEntity class</param>
        /// <returns>System.Boolean</returns>
        public bool SaveAffirmativeDetailsDAL(Entities.Recruiter.AffirmativeDetailsEntity affirmativeDetailsEntity)
        {
            int result;
            try
            {
                SqlParameter[] sqlparams ={
                                          new SqlParameter("@recruiterId",affirmativeDetailsEntity.ID),
                                          new SqlParameter("@physicallyChallenged",affirmativeDetailsEntity.PhysicallyChallenged),
                                          new SqlParameter("@description",affirmativeDetailsEntity.Description),
                                          new SqlParameter("@sports",affirmativeDetailsEntity.Sports),
                                          new SqlParameter("@sportsDescription",affirmativeDetailsEntity.SportsDescription),
                                          new SqlParameter("@usaPermit",affirmativeDetailsEntity.USAPermit),
                                          new SqlParameter("@otherPermits",affirmativeDetailsEntity.OtherPermits),
                                          new SqlParameter ("@hobbies",affirmativeDetailsEntity.Hobbies),
                                          new SqlParameter ("@extraActivity",affirmativeDetailsEntity.ExtraActivity)                                         
                                          };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_RE_InsertOtherDetails, sqlparams);
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
