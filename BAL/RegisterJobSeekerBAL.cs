using DAL;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace BAL
{
    public class RegisterJobSeekerBAL
    {
        /// <summary>
        /// Registers the new job seeker bal.
        /// </summary>
        /// <param name="jobSeekerEntity">The job seeker entity.</param>
        /// <returns>System.Int32.</returns>
        public int RegisterNewJobSeekerBAL(RegisterJobSeekerEntity jobSeekerEntity)
        {
            RegisterJobSeekerDAL jobSeekerDAL = new RegisterJobSeekerDAL();
            return jobSeekerDAL.RegisterNewJobSeekerDAL(jobSeekerEntity);
        }

       
      
    }
}