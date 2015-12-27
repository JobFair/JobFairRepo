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
                // Check if result is greater than zero
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                // throw ;
            }
            return false;
        }

        /// <summary>
        /// View Educational Deatils JobSeeker.
        /// </summary>
        /// <param name="edEntity">Object for Selecting data into database</param>
        /// <returns>True/false</returns>
        public DataSet ViewEducationalDetailsDAL(string candidateId,int DegreeId)
        {
            DataSet dsEducationalDetails = new DataSet();
            try
            {
                SqlParameter[] sparams = { new SqlParameter("@CandidateId", candidateId),
                                           new SqlParameter("@DegreeId", DegreeId)
                                         };
                dsEducationalDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectEducationalDetails, sparams);
            }
            catch (Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
            return dsEducationalDetails;
        }

        /// <summary>
        /// Update Educational Deatils JobSeeker.
        /// </summary>
        /// <param name="edEntity">Object for Updating data into database</param>
        /// <returns>True/false</returns>
        public int UpdateEducationalDetailsDAL(EducationalDetailsEntity educationalDetailsEntity)
        {
            int result = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] sqlparams = {
                                              new SqlParameter("@CandidateId",educationalDetailsEntity.CandidateId),
                                              new SqlParameter("@HighestQualificationId",educationalDetailsEntity.HighestQualificationId),
                                              new SqlParameter("@DegreeId",educationalDetailsEntity.DegreeId),
                                              new SqlParameter("@MediumOfEducation",educationalDetailsEntity.MediumOfEducation),
                                              new SqlParameter("@Status",educationalDetailsEntity.Status),
                                              new SqlParameter("@SpecializationId",educationalDetailsEntity.SpecializationId),
                                              new SqlParameter("@FromYear",educationalDetailsEntity.FromYear),
                                              new SqlParameter("@ToYear",educationalDetailsEntity.ToYear),
                                              new SqlParameter("@College",educationalDetailsEntity.College),
                                              new SqlParameter("@University",educationalDetailsEntity.University),
                                              new SqlParameter("@Percantage",educationalDetailsEntity.Percantage),
                                            };
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateEducationalDetails, sqlparams);
            }
            catch (Exception)
            {
                //throw ;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        /// <summary>
        /// Method for adding Under Graduate Diploma Details in database
        /// </summary>
        /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity</param>
        public void AddUnderGraduateDiplomaDAL(EducationalDetailsEntity educationalDetailsEntity)
        {
            try
            {
                educationalDetailsEntity.DegreeId = 3;
                connection.Open();
                //Add parameter for stored procedure
                SqlParameter[] sqlparams = {
                                               new SqlParameter("@DegreeId",educationalDetailsEntity.DegreeId),
                                               new SqlParameter("@DegreeName",educationalDetailsEntity.AddUnderGraduateDiplomaName),
                                            };
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_InsertDegreeDetails, sqlparams);
                educationalDetailsEntity.DegreeId = 0;
            }
            catch (System.Exception)
            {
                // throw ;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method for adding Bachelor Degree Details in database
        /// </summary>
        /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity</param>
        public void AddBachelorDegreeDAL(EducationalDetailsEntity educationalDetailsEntity)
        {
            try
            {
                educationalDetailsEntity.DegreeId = 4;
                connection.Open();
                //Add parameter for stored procedure
                SqlParameter[] sqlparams = {
                                               new SqlParameter("@DegreeId",educationalDetailsEntity.DegreeId),
                                               new SqlParameter("@DegreeName",educationalDetailsEntity.AddBachelorDegreeName),
                                            };
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_InsertDegreeDetails, sqlparams);
                educationalDetailsEntity.DegreeId = 0;
            }
            catch (System.Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method for adding Post Graduate Diploma Details in database
        /// </summary>
        /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity</param>
        public void AddPostGraduateDiplomaDAL(EducationalDetailsEntity educationalDetailsEntity)
        {
            try
            {
                educationalDetailsEntity.DegreeId = 5;
                connection.Open();
                //Add parameter for stored procedure
                SqlParameter[] sqlparams = {
                                               new SqlParameter("@DegreeId",educationalDetailsEntity.DegreeId),
                                               new SqlParameter("@DegreeName",educationalDetailsEntity.AddPostGraduateDiplomaName),
                                            };
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_InsertDegreeDetails, sqlparams);
                educationalDetailsEntity.DegreeId = 0;
            }
            catch (System.Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method for adding Master Degree Details in database
        /// </summary>
        /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity</param>
        public void AddMasterDegreeDAL(EducationalDetailsEntity educationalDetailsEntity)
        {
            try
            {
                educationalDetailsEntity.DegreeId = 6;
                connection.Open();
                //Add parameter for stored procedure
                SqlParameter[] sqlparams = {
                                               new SqlParameter("@DegreeId",educationalDetailsEntity.DegreeId),
                                               new SqlParameter("@DegreeName",educationalDetailsEntity.AddMasterDegreeName),
                                            };
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_InsertDegreeDetails, sqlparams);
                educationalDetailsEntity.DegreeId = 0;
            }
            catch (System.Exception)
            {
                // throw ;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Method for adding Doctor Of Philosophy Details in database
        /// </summary>
        /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity</param>
        public void AddPHDDAL(EducationalDetailsEntity educationalDetailsEntity)
        {
            try
            {
                educationalDetailsEntity.DegreeId = 7;
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[1];
                //Add parameter for stored procedure
                SqlParameter[] sqlparams = {
                                               new SqlParameter("@DegreeId",educationalDetailsEntity.DegreeId),
                                               new SqlParameter("@DegreeName",educationalDetailsEntity.AddPHDName),
                                            };
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_InsertDegreeDetails, sqlparams);
                educationalDetailsEntity.DegreeId = 0;
            }
            catch (System.Exception)
            {
                // throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}