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
            try
            {
                RegisterJobSeekerDAL jobSeekerDAL = new RegisterJobSeekerDAL();
                return jobSeekerDAL.SaveRegisterNewJobSeekerDAL(jobSeekerEntity);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}