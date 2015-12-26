using DAL;
using System.Data;

namespace BAL
{
    public class ViewProfileREBAL
    {
        public DataSet ViewProfileBAL(int recruiterId)
        {
            ViewProfileREDAL viewProfileDAL = new ViewProfileREDAL();
            return viewProfileDAL.ViewProfileDAL(recruiterId);
        }

        public DataSet ViewPersonalDetails(int recruiterId)
        {
            ViewProfileREDAL viewProfileDAL = new ViewProfileREDAL();
            return viewProfileDAL.ViewPersonalDetailsDAL(recruiterId);
        }
        /// <summary>
        /// ViewProfile of recuiter
        /// </summary>
        /// <param name="viewProfileEntity">The ViewProfile Entity</param>
        /// <returns></returns>
        //public DataSet ViewProfile(ViewProfileEntity viewProfileEntity)
        //{
        //    return viewProfileDAL.ViewProfileDAL(viewProfileEntity);
        //}

        /// <summary>
        /// For display posted job of recruiter
        /// </summary>
        /// <returns></returns>
        //public DataSet ViewJobPostBAL()
        //{
        //    return viewProfileDAL.ViewJobPostDAL();
        //}
    }
}