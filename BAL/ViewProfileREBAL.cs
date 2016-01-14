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

        public DataSet ViewContactDetailsBAL(int recruiterId)
        {
            ViewProfileREDAL viewProfileDAL = new ViewProfileREDAL();
            return viewProfileDAL.ViewContactDetailsDAL(recruiterId);
        }

        public DataSet ViewAffirmativeDetailsBAL(long recruiterId)
        {
            ViewProfileREDAL viewProfileREDAL = new ViewProfileREDAL();
            return viewProfileREDAL.ViewAffirmativeDetailsDAL(recruiterId);
        }

       
    }
}