using CommonUtil;
using DAL;
using Entities;
using System.Data;

namespace BAL
{
    public class PersonalDetailsJSBAL
    {
        /// <summary>
        ///  Personal Details of job seeker bal.
        /// </summary>
        /// <param name="personalDetailsEntity">The Personal Details entity.</param>
        /// <returns>System.Int32</returns>
        public int SavePersonalDetailsBAL(PersonalDetailsJSEntity personalDetailsEntity)
        {
            PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
            return pdDAL.SavePersonalDetails(personalDetailsEntity);
        }
        /// <summary>
        /// Get Country
        /// </summary>
        /// <returns></returns>
        public DataSet GetCountry()
        {
            return Utility.GetCountry();
        }
        /// <summary>
        /// Get state
        /// </summary>
        /// <param name="CountryId"></param>
        /// <returns></returns>
        public DataSet GetState(int CountryId)
        {
            return Utility.GetState(CountryId);
        }
        /// <summary>
        /// Get City
        /// </summary>
        /// <param name="StateId"></param>
        /// <returns></returns>
        public DataSet GetCity(int StateId)
        {
            return Utility.GetCity(StateId);
        }
    }
}