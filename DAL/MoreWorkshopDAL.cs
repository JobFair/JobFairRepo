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
    public class MoreWorkshopDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// method for converting the object to XML.
        /// </summary>
        /// <param name="workshopEntity"></param>
        /// <returns></returns>
        private string CreateXML(List<WorkshopEntity> workshopEntity)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(workshopEntity.GetType());

            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, workshopEntity);
                xmlStream.Position = 0;

                xmlDoc.Load(xmlStream);
                return xmlDoc.InnerXml;
            }
        }

        /// <summary>
        /// Saving MoreWorkshop Deatils JobSeeker.
        /// </summary>
        /// <param name="workshopEntity">Object for inserting data into database</param>
        /// <returns>True/false</returns>
        public bool SaveMoreWorkshopDAL(List<WorkshopEntity> workEntity)
        {
            try
            {
                //Get xml String data from object
                string workshopEntity = CreateXML(workEntity);

                SqlParameter[] sqlparams ={
                                            new SqlParameter("@workshopEntity",workshopEntity)};
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_InsertMoreWorkshop, sqlparams);
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
