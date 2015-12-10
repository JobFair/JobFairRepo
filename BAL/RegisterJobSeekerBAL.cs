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

        public System.Data.DataSet GetCountry()
        {
            return Utility.GetCountry();
        }

        public System.Data.DataSet GetState(int CountryId)
        {
            return Utility.GetState(CountryId);
        }

        public System.Data.DataSet GetCity(int StateId)
        {
            return Utility.GetCity(StateId);
        }

        public System.Data.DataSet GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }
    }
}