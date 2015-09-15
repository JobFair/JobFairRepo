using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Entities.JobSeeker;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DAL
{
    public class EducationalDetailsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        /// <summary>
        /// Saving Educational Deatils JobSeeker.
        /// </summary>
        /// <param name="edEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int SaveEducationalDetailsDAL(EducationalDetailsEntity edEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams ={
                                          new SqlParameter("@candidateId",edEntity.CandidateId),
                                          new SqlParameter("@degreeId",edEntity.DegreeId),
                                          new SqlParameter("@mediumOfEducation",edEntity.MediumOfEducation),
                                          new SqlParameter("@status",edEntity.Status),
                                          new SqlParameter("@specialization",edEntity.Specialization),
                                          new SqlParameter("@yearOfCompletion",edEntity.YearOfCompletion),
                                          new SqlParameter("@university",edEntity.University),
                                          new SqlParameter("@percantage",edEntity.Percantage),
           };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_InsertEducationalDetails", sqlparams);
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
        public string CreateXML(EducationalDetailsEntity adEntity)
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
    }
}
