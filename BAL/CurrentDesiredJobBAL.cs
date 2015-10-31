using CommonUtil;
using DAL;
using Entities.JobSeeker;

namespace BAL
{
    public class CurrentDesiredJobBAL
    {
        /// <summary>
        /// Method for Current professional details
        /// </summary>
        /// <param name="currentJobEntity">Object of CurrentDesiredJobEntity entity class</param>
        /// <returns>System.Int32</returns>
        public int CurrentProfessionalDetailsBAL(CurrentDesiredJobEntity currentJobEntity)
        {
            CurrentDesiredJobDAL currentjobDAL = new CurrentDesiredJobDAL();
            return currentjobDAL.SaveCurrentProfessionalDetailsDAL(currentJobEntity);
        }
        /// <summary>
        /// Method for Desired job details
        /// </summary>
        /// <param name="desiredJobEntity">Object of CurrentDesiredJobEntity entity class</param>
        /// <returns>System.Int32</returns>
        public int DesiredJobDetailsBAL(CurrentDesiredJobEntity desiredJobEntity)
        {
            CurrentDesiredJobDAL desiredjobDAL = new CurrentDesiredJobDAL();
            return desiredjobDAL.SaveDesiredJobDetailsDAL(desiredJobEntity);
        }

        /// <summary>
        /// Method to get Country
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry();
        }

        /// <summary>
        /// Method to get Departments
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetDepartment()
        {
            return Utility.GetDepartment();
        }

        /// <summary>
        /// Method to get Industry
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetIndustry()
        {
            return Utility.GetIndustry();
        }

        /// <summary>
        /// Method to get State
        /// </summary>
        /// <param name="CountryId">Parameter of Country table to get State accordingly</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetState(int CountryId)
        {
            return Utility.GetState(CountryId);
        }
        /// <summary>
        /// Method to get City
        /// </summary>
        /// <param name="StateId">Parameter of State table to get City accordingly</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCity(int StateId)
        {
            return Utility.GetCity(StateId);
        }

        public System.Data.DataTable GetPreferredCityBAL(string PrefixText)
        {
             CurrentDesiredJobDAL desiredjobDAL = new CurrentDesiredJobDAL();
             return desiredjobDAL.GetPreferredCityDAL(PrefixText);

        }

        public System.Data.DataTable GetPreferredAreaBAL(string prefixText)
        {
            CurrentDesiredJobDAL desiredjobDAL = new CurrentDesiredJobDAL();
            return desiredjobDAL.GetPreferredAreaDAL(prefixText);
        }

       
    }
}