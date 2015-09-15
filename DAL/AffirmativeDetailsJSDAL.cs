using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entities.JobSeeker;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


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
        public int LanguageDetailsDAL(LanguageEntity language)
        {

            connection.Open();
            SqlCommand cmd = new SqlCommand();

            // Get xml string data from object
            string languageDetails = CreateXML(language);

            SqlParameter[] sqlparams ={new SqlParameter("@languageDetails",languageDetails)};

            int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_InsertLanguageDetails", sqlparams);
            return result;
        }
        
        /// <summary>
        /// Load the Languages
        /// </summary>
        /// <returns></returns>
        public DataTable GetLanguage()
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Language", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            return table;
        }
        /// <summary>
        /// Insert Affirmative Details
        /// </summary>
        /// <param name="adEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int AffirmativeDetailsDAL(AffirmativeDetailsEntity adEntity)
        {
            int result;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams ={
                                          new SqlParameter("@candidateId",adEntity.CandidateId),
                                          new SqlParameter("@physicallyChallenged",adEntity.PhysicallyChallenged),
                                          new SqlParameter("@description",adEntity.Description),
                                          new SqlParameter("@sports",adEntity.Sports),
                                          new SqlParameter("@sportsDescription",adEntity.SportsDescription),
                                          new SqlParameter("@usaPermit",adEntity.USAPermit),
                                          new SqlParameter("@otherPermits",adEntity.OtherPermits),
                                          };
                 result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_OtherDetails", sqlparams);
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
