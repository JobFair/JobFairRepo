using CommonUtil;
using DAL;

namespace BAL
{
    public class RegisterRecruiterHRBAL
    {
        /// <summary>
        /// Register the new RegisterRecruiterHRBAL BAL
        /// </summary>
        /// <param name="recruiterRegisterEntity">The recruiter enitity </param>
        /// <returns>System.String</returns>
        public string SaveNewRecruiterBAL(Entities.HR.RecruiterRegisterEntity recruiterRegisterEntity)
        {
            RegisterRecruiterHRDAL registerRecruiterHRDAL = new RegisterRecruiterHRDAL();
            return registerRecruiterHRDAL.SaveNewRecruiterDAL(recruiterRegisterEntity);
        }
        /// <summary>
        /// Method to get country in RegisterRecruiterHRBAL class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry();
        }
        /// <summary>
        /// Method to get state in RegisterRecruiterHRBAL class
        /// </summary>
        /// <param name="CountryId">Integer Parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetState(int CountryId)
        {
            return Utility.GetState(CountryId);
        }
        /// <summary>
        /// Method to get city in RegisterRecruiterHRBAL class
        /// </summary>
        /// <param name="CountryId">Integer Parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCity(int StateId)
        {
            return Utility.GetCity(StateId);
        }
        /// <summary>
        /// Method to get Area in RegisterRecruiterHRBAL class
        /// </summary>
        /// <param name="cityId">Integer Parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }
        /// <summary>
        /// Method to get CountryCode in RegisterRecruiterHRBAL class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCountryCode()
        {
            return Utility.GetCountryCode();
        }

        public void UpdateMailsentBAL(Entities.HR.RecruiterRegisterEntity registerRecruiterEntity)
        {
            RegisterRecruiterHRDAL registerRecruiterHRDAL = new RegisterRecruiterHRDAL();
            registerRecruiterHRDAL.UpdateMailsentDAL(registerRecruiterEntity);
        }
    }
}