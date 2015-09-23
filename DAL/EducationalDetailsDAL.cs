using Entities.JobSeeker;
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
    public class EducationalDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// method for converting the object to XML.
        /// </summary>
        /// <param name="adEntity"></param>
        /// <returns></returns>
        private string CreateXML(List<EducationalDetailsEntity> adEntity)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(adEntity.GetType());

            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, adEntity);
                xmlStream.Position = 0;

                xmlDoc.Load(xmlStream);
                return xmlDoc.InnerXml;
            }
        }

        /// <summary>
        /// Saving Educational Deatils JobSeeker.
        /// </summary>
        /// <param name="edEntity">Object for inserting data into database</param>
        /// <returns>True/false</returns>
        public bool SaveEducationalDetailsDAL(List<EducationalDetailsEntity> edEntity)
        {
            try
            {
                //Get xml String data from object
                string adEntity = CreateXML(edEntity);

                SqlParameter[] sqlparams ={
                                            new SqlParameter("@adEntity",adEntity)};
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertEducationalDetails, sqlparams);
                if (result> 0 )
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
    }
}