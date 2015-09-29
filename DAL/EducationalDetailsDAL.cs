﻿using Entities.JobSeeker;
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
        /// <summary>
        /// Method for adding Under Graduate Diploma Details in database
        /// </summary>
        /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity</param>
        public void AddUnderGraduateDiplomaDAL(EducationalDetailsEntity educationalDetailsEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[1];
                //Add parameter for stored procedure
                sparams[0] = new SqlParameter("@UGDName", educationalDetailsEntity.AddUnderGraduateDiplomaName);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_InsertUnderGraduateDiploma", sparams);
            }
            catch (System.Exception)
            {
                throw;
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
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[1];
                //Add parameter for stored procedure
                sparams[0] = new SqlParameter("@BDName", educationalDetailsEntity.AddBachelorDegreeName);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_InsertBachelorDegree", sparams);
            }
            catch (System.Exception)
            {
                throw;
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
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[1];
                //Add parameter for stored procedure
                sparams[0] = new SqlParameter("@PGDName", educationalDetailsEntity.AddPostGraduateDiplomaName);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_InsertPostGraduateDiploma", sparams);
            }
            catch (System.Exception)
            {
                throw;
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
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[1];
                //Add parameter for stored procedure
                sparams[0] = new SqlParameter("@MDName", educationalDetailsEntity.AddMasterDegreeName);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_InsertMasterDegree", sparams);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Method for adding Doctor Of Philosophy Details in database
        /// </summary>
        /// <param name="educationalDetailsEntity">Object of EducationalDetailsEntity</param>
        public void AddDoctorOfPhilosophyDAL(EducationalDetailsEntity educationalDetailsEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparams = new SqlParameter[1];
                //Add parameter for stored procedure
                sparams[0] = new SqlParameter("@PHDName", educationalDetailsEntity.AddDoctorOfPhilosophyName);
                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_InsertDoctorOfPhilosophy", sparams);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}