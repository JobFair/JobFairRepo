using Entities.JobSeeker;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MoreCertificationDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// method for converting the object to XML.
        /// </summary>
        /// <param name="certificationEntity"></param>
        /// <returns></returns>
        private string CreateXML(List<CertificationEntity> certificationEntity)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(certificationEntity.GetType());

            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, certificationEntity);
                xmlStream.Position = 0;

                xmlDoc.Load(xmlStream);
                return xmlDoc.InnerXml;
            }
        }

        /// <summary>
        /// Saving MoreCertification Deatils JobSeeker.
        /// </summary>
        /// <param name="certificationEntity">Object for inserting data into database</param>
        /// <returns>True/false</returns>
        public bool SaveMoreCertificationDAL(List<CertificationEntity> certEntity)
        {
            try
            {
                //Get xml String data from object
                string certificationEntity = CreateXML(certEntity);

                SqlParameter[] sqlparams ={
                                            new SqlParameter("@certificationEntity",certificationEntity)};
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertMoreCertification, sqlparams);
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
    }
}
