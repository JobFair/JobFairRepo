using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entities.JobSeeker;


namespace DAL
{
    public class AffirmativeDetailsJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
        /// <summary>
        /// Insert Affirmative Details
        /// </summary>
        /// <param name="adEntity">Object for inserting data into database</param>
        /// <returns>System.Int32</returns>

        public int AffirmativeDetailsDAL(AffirmativeDetailsEntity adEntity)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                SqlParameter[] sqlparams ={
                                          new SqlParameter("@candidateId",adEntity.CandidateId),
                                          new SqlParameter("@language",adEntity.Language),
                                          new SqlParameter("@proficiencyLevel",adEntity.ProficiencyLevel),
                                          new SqlParameter("@read",adEntity.Read),
                                          new SqlParameter("@write",adEntity.Write),
                                          new SqlParameter("@speak",adEntity.Speak),
                                          new SqlParameter("@physicallyChallenged",adEntity.PhysicallyChallenged),
                                          new SqlParameter("@description",adEntity.Description),
                                          new SqlParameter("@sports",adEntity.Sports),
                                          new SqlParameter("@sportsDescription",adEntity.SportsDescription),
                                           new SqlParameter("@usaPermit",adEntity.USAPermit),
                                            new SqlParameter("@otherPermits",adEntity.OtherPermits),
           };
                int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_OtherDetails", sqlparams);
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
