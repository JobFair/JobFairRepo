using CommonUtil;
using DAL;
using Entities;

namespace BAL
{
    public class RegisterJobSeekerBAL
    {
        /// <summary>
        /// Registers the new job seeker bal.
        /// </summary>
        /// <param name="jobSeekerEntity">The job seeker entity.</param>
        /// <returns>System.Int32.</returns>
        public string SaveRegisterNewJobSeekerBAL(RegisterEntity jobSeekerEntity)
        {
            RegisterJobSeekerDAL jobSeekerDAL = new RegisterJobSeekerDAL();
            return jobSeekerDAL.SaveRegisterNewJobSeekerDAL(jobSeekerEntity);
        }
        /// <summary>
        /// Method to get country in RegisterJobSeekerBAL class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry();
        }
        /// <summary>
        /// Method to get state in RegisterJobSeekerBAL class
        /// </summary>
        /// <param name="CountryId">Integer Parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetState(int CountryId)
        {
            return Utility.GetState(CountryId);
        }
        /// <summary>
        /// Method to get city in RegisterJobSeekerBAL class
        /// </summary>
        /// <param name="StateId">Integer Parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCity(int StateId)
        {
            return Utility.GetCity(StateId);
        }
        /// <summary>
        /// Method to get city area in RegisterJobSeekerBAL class
        /// </summary>
        /// <param name="cityId">Integer Parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }
    }
}