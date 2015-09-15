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
        /// <param name="languageEntity"></param>
        /// <returns></returns>
        private string CreateXML(LanguageEntity languageEntity)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(languageEntity.GetType());
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, languageEntity);
                xmlStream.Position = 0;
                xmlDoc.Load(xmlStream);
                return xmlDoc.InnerXml;
            }
        }

        /// <summary>
        /// Insert LanguageDetails
        /// </summary>
        /// <param name="languageEntity">Object for inserting data into database</param>
        /// <returns></returns>
        //public int LanguageDetailsDAL(LanguageEntity languageEntity)
        //{

        //    connection.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    SqlParameter[] sqlparams ={
        //                                   new SqlParameter("@candidateId",languageEntity.CandidateId),
        //                                   new SqlParameter("@languageId",languageEntity.LanguageId),
        //                                  new SqlParameter("@proficiencyLevel",languageEntity.ProficiencyLevel),
        //                                  new SqlParameter("@read",languageEntity.Read),
        //                                  new SqlParameter("@write",languageEntity.Write),
        //                                  new SqlParameter("@speak",languageEntity.Speak),
        //                                  };
        //   int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_InsertLanguageDetails", sqlparams);
        //    return result;
        //}
        
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
