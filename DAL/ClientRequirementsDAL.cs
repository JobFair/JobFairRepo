using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Recruiter;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ClientRequirementsDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        public int SaveClientRequirementsDAL(ClientRequirementsEntitiy clientrequirementsEntity)
        {
            try
            {
                connection.Open();
                SqlParameter[] sparam = new SqlParameter[8];
                sparam[0] = new SqlParameter("@recruiterID", "RE2");
                sparam[1] = new SqlParameter("@clientId", clientrequirementsEntity.ClientId);
                sparam[2] = new SqlParameter("@position", clientrequirementsEntity.Position);
                sparam[3] = new SqlParameter("@jobDescription", clientrequirementsEntity.JobDescription);
                sparam[4] = new SqlParameter("@gender", clientrequirementsEntity.Gender);
                sparam[5] = new SqlParameter("@dateOfRequirementSent", clientrequirementsEntity.DateOfRequirementSent.Date);
                sparam[6] = new SqlParameter("@dueDate", clientrequirementsEntity.DueDate.Date);
                sparam[7] = new SqlParameter("@numberOfVacancies", clientrequirementsEntity.NumberOfVacancies);
                sparam[8] = new SqlParameter("@positionClosed", clientrequirementsEntity.PositionClosed);
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_RE_InsertClientRequirement", sparam);
                return result;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
     }
}
