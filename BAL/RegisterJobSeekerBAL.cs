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
        /// Professional details of job seeker
        /// </summary>
        /// <param name="curentity">Professional Details entity</param>
        /// <returns>System.Int32</returns>
        public int CurrentProfessionalDetailsBAL(Current_DesiredJobDetailsEntity curentity)
        {
            RegisterJobSeekerDAL rjsDAL=new RegisterJobSeekerDAL();
            return rjsDAL.CurrentProfessionalDetailsDAL(curentity);
        }

       

       
      

       public DataSet LoadCityAll(CityEntity cityentity)
       {
           RegisterJobSeekerDAL cdDAL = new RegisterJobSeekerDAL();
           return cdDAL.LoadCityAll(cityentity);
       }

      
    }
}