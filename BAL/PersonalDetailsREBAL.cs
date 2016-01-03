using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities.Recruiter;
using System.Data;
using CommonUtil;

namespace BAL
{
   public class PersonalDetailsREBAL
    {
        /// <summary>
        ///  Personal Details of recruiter bal.
        /// </summary>
        /// <param name="personalDetailsEntity">The Personal Details entity.</param>
        /// <returns>System.Int32</returns>
        public int SavePersonalDetailsBAL(PersonalDetailsEntity personalDetailsEntity)
        {
            PersonalDetailsREDAL personalDetailsDAL = new PersonalDetailsREDAL();
            return personalDetailsDAL.SavePersonalDetails(personalDetailsEntity);
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
