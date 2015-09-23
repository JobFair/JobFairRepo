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

        public DataSet GetCountry()
        {
            return Utility.GetCountry();
        }

        public DataSet GetState(int CountryId)
        {
            return Utility.GetState(CountryId);
        }

        public DataSet GetCity(int StateId)
        {
            return Utility.GetCity(StateId);
        }
    }
}