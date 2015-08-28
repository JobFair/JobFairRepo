using DAL;
using Entities;
using System.Data.SqlClient;

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

        /// <summary>
        /// Jobs the seeker log in.
        /// </summary>
        /// <param name="loginEntity">The login entity.</param>
        /// <returns>SqlDataReader.</returns>
        public SqlDataReader JobSeekerLogIn(LogInJobSeekerEnitity loginEntity)
        {
            RegisterJobSeekerDAL loginDAL = new RegisterJobSeekerDAL();
            SqlDataReader dataReader = loginDAL.JobSeekerLoginDAL(loginEntity);
            return dataReader;
        }

        /// <summary>
        /// Changes the password bal.
        /// </summary>
        /// <param name="changePasswordEntity">The change password entity.</param>
        /// <returns>System.Int32.</returns>
        public int ChangePasswordBAL(ChangePasswordEnitity changePasswordEntity)
        {
            RegisterJobSeekerDAL jobSeekerDAL = new RegisterJobSeekerDAL();
            return jobSeekerDAL.ChangePasswordDAL(changePasswordEntity);
        }


        /// <summary>
        /// Fill Contact Details of job seeker bal.
        /// </summary>
        /// <param name="cdEntity">The contact details entity</param>
        /// <returns>System.Int32.</returns>
        public int ContactDetailsJobSeeker(ContactDetailsJobSeekerEntity cdEntity)
        {
            RegisterJobSeekerDAL cdDAL = new RegisterJobSeekerDAL();
            return cdDAL.InsertContactInfo(cdEntity);
        }
    }
}