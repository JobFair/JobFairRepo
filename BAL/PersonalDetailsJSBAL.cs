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
        /// Update personal details bal
        /// </summary>
        /// <param name="personalDetailsEntity">PersonalDetailsJSEntity</param>
        /// <returns>System.Int32</returns>
        public int UpdatePersonalDetailsBAL(PersonalDetailsJSEntity personalDetailsEntity)
        {
            PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
            return pdDAL.UpdatePersonalDetailsDAL(personalDetailsEntity);
        }

        /// <summary>
        /// View personal details of job seeker bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewPersonalDetailsBAL(string candidateId)
        {
            PersonalDetailsJSDAL personalDetailsDAL = new PersonalDetailsJSDAL();
            return personalDetailsDAL.ViewPersonalDetailsDAL(candidateId);
        }

        /// <summary>
        /// Get Country
        /// </summary>
        /// <returns>dataset</returns>

        public DataSet GetCountry()
        {
            return Utility.GetCountry();
        }

        /// <summary>
        /// Get state
        /// </summary>
        /// <param name="CountryId">CountryId</param>
        /// <returns>dataset</returns>
        public DataSet GetState(int CountryId)
        {
            return Utility.GetState(CountryId);
        }

        /// <summary>
        /// Get City
        /// </summary>
        /// <param name="stateId">StateId</param>
        /// <returns>dataset</returns>
        public DataSet GetCity(int stateId)
        {
            return Utility.GetCity(stateId);
        }

        /// <summary>
        /// Get area
        /// </summary>
        /// <param name="cityId">cityId</param>
        /// <returns>dataset</returns>
        public DataSet GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }
    }
}