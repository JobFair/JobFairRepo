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

        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public int EducationalDetailsDAL(EducationalDetailsEntity adEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams ={
                                          new SqlParameter("@candidateId",adEntity.CandidateId),
                                          new SqlParameter("@degreeId",adEntity.DegreeId),
                                          new SqlParameter("@mediumOfEducation",adEntity.MediumOfEducation),
                                          new SqlParameter("@status",adEntity.Status),
                                          new SqlParameter("@specialization",adEntity.Specialization),
                                          new SqlParameter("@yearOfCompletion",adEntity.YearOfCompletion),
                                          new SqlParameter("@university",adEntity.University),
                                          new SqlParameter("@percantage",adEntity.Percantage),
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
    }
}
