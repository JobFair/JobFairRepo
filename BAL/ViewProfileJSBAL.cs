using DAL;
using System.Data;

namespace BAL
{
    public class ViewProfileJSBAL
    {
        public DataSet ViewProfileBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewProfileDAL(candidateId);
        }

        public DataSet ViewContactDetailsBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewContactDetailsDAL(candidateId);
        }

        public DataSet ViewPersonalDetailsBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewPersonalDetailsDAL(candidateId);
        }

        public DataSet ViewAffirmativeDetailsBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewAffirmativeDetailsDAL(candidateId);
        }

        public DataSet ViewProjectDetailsBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewProjectDetailsDAL(candidateId);
        }

        public DataSet ViewTechnicalSkillBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewTechnicalSkillsDAL(candidateId);
        }






        public int ChangeContactNoBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ChangeConatctNoDAL(viewProfileEntity);
        }

        public int ResumeDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ResumeDetailsDAL(viewProfileEntity);
        }

        public int ChangePersonalDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ChangePersonalDetailsDAL(viewProfileEntity);
        }
    }
}