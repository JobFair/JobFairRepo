using DAL;

namespace BAL
{
    public class RegisterRecruiterBAL
    {
        /// <summary>
        /// Register the new Recruiter BAL
        /// </summary>
        /// <param name="rrentity">The recruiter enitity </param>
        /// <returns>System.String</returns>
        public string SaveNewRecruiterBAL(Entities.Recruiter.RegisterRecruiterEntity rrentity)
        {
            RegisterRecruiterDAL rrDAL = new RegisterRecruiterDAL();
            return rrDAL.SaveNewRecruiterDAL(rrentity);
        }
    }
}