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
using System.Xml.Linq;


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
        private string CreateXML(EducationalDetailsEntity adEntity)
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

            //var xmlfromLINQ = new XElement("customers",
            //from c in adEntity
            //select new XElement("customer",
            //    new XElement("CustomerId", c.CandidateId),
            //    new XElement("CustomerName", c.DegreeId),
            //    new XElement("PhoneNumber", c.MediumOfEducation),
            //    new XElement("Email", c.Percantage),
            //    new XElement("Email", c.Specialization),
            //    new XElement("Email", c.Status),
            //    new XElement("Email", c.University)
            //    ));



        }
        /// <summary>
        /// Saving Educational Deatils JobSeeker.
        /// </summary>
        /// <param name="edEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>
        public int SaveEducationalDetailsDAL(List<EducationalDetailsEntity> edEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                //Get xml String data from object
                string adEntity = CreateXML(edEntity.First());

                SqlParameter[] sqlparams ={ 
                                            new SqlParameter("@adEntity",adEntity)
                                          //new SqlParameter("@candidateId",edEntity.CandidateId),
                                          //new SqlParameter("@degreeId",edEntity.DegreeId),
                                          //new SqlParameter("@mediumOfEducation",edEntity.MediumOfEducation),
                                          //new SqlParameter("@status",edEntity.Status),
                                          //new SqlParameter("@specialization",edEntity.Specialization),
                                          //new SqlParameter("@yearOfCompletion",edEntity.YearOfCompletion),
                                          //new SqlParameter("@university",edEntity.University),
                                          //new SqlParameter("@percantage",edEntity.Percantage),
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
