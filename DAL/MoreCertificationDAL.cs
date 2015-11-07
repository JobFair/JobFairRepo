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
        /// Saving MoreCertification Deatils JobSeeker.
        /// </summary>
        /// <param name="certificationEntity">Object for inserting data into database</param>
        /// <returns>True/false</returns>
        public DataTable SaveMoreCertificationDAL(DataTable certEntity)
        {
            try
            {
                connection.Open();
                //creating object of SqlBulkCopy
                SqlBulkCopy objbulk = new SqlBulkCopy(connection);
                //assigning Destination table name
                objbulk.DestinationTableName = "JS_MoreCertification";
                //Mapping Table column
                objbulk.ColumnMappings.Add("CandidateId", "CandidateId");
                objbulk.ColumnMappings.Add("CertificationName", "CertificationName");
                objbulk.ColumnMappings.Add("Institute", "Institute");
                objbulk.ColumnMappings.Add("Duration", "Duration");
                objbulk.ColumnMappings.Add("YearOfCompletion", "YearOfCompletion");
                objbulk.ColumnMappings.Add("Grade", "Grade");
                //inserting bulk Records into DataBase
                objbulk.WriteToServer(certEntity);
                return certEntity;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
