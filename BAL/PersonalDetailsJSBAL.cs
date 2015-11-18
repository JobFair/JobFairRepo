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
            try
            {
                PersonalDetailsJSDAL pdDAL = new PersonalDetailsJSDAL();
                return pdDAL.SavePersonalDetails(personalDetailsEntity);
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }

        public DataSet ViewPersonalDetailsBAL(string candidateId)
        {
            PersonalDetailsJSDAL personalDetailsDAL = new PersonalDetailsJSDAL();
            return personalDetailsDAL.ViewPersonalDetailsDAL(candidateId);
        }
        /// <summary>
        /// Get Country
        /// </summary>
        /// <returns></returns>

        public DataSet GetCountry()
        {
            try
            {
                return Utility.GetCountry();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }
        /// <summary>
        /// Get state
        /// </summary>
        /// <param name="CountryId"></param>
        /// <returns></returns>
        public DataSet GetState(int CountryId)
        {
            try
            {
                return Utility.GetState(CountryId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
        /// <summary>
        /// Get City
        /// </summary>
        /// <param name="StateId"></param>
        /// <returns></returns>
        public DataSet GetCity(int StateId)
        {
            try
            {
                return Utility.GetCity(StateId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
        public DataSet GetArea(int cityId)
        {
            try
            {
                return Utility.GetArea(cityId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
    }
}