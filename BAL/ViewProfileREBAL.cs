using DAL;
using Entities.Recruiter;
using System.Data;

namespace BAL
{
    public class ViewProfileREBAL
    {
        private ViewProfileREDAL viewProfileDAL = new ViewProfileREDAL();

        /// <summary>
        /// ViewProfile of recuiter
        /// </summary>
        /// <param name="viewProfileEntity">The ViewProfile Entity</param>
        /// <returns></returns>
        public DataSet ViewProfile(ViewProfileEntity viewProfileEntity)
        {
            return viewProfileDAL.ViewProfileDAL(viewProfileEntity);
        }

        /// <summary>
        /// For display posted job of recruiter
        /// </summary>
        /// <returns></returns>
        public DataSet ViewJobPostBAL()
        {
            return viewProfileDAL.ViewJobPostDAL();
        }
    }
}