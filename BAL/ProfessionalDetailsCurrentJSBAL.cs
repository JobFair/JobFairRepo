using DAL;
using Entities;
using System.Data.SqlClient;

namespace BAL
{
    public class ProfessionalDetailsCurrentJSBAL
    {
        /// <summary>
        /// Professional details of job seeker
        /// </summary>
        /// <param name="curentity">Professional Details entity</param>
        /// <returns>System.Int32</returns>
        public int CurrentProfessionalDetailsBAL(Current_DesiredJobDetailsEntity curentity)
        {
            ProfessionalDetailsCurrentJSDAL rjsDAL = new ProfessionalDetailsCurrentJSDAL();
            return rjsDAL.CurrentProfessionalDetailsDAL(curentity);
        }
    }
}