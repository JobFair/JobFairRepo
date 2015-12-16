using DAL;
using System.Data;

namespace BAL
{
    public class ViewProfileJSBAL
    {
        /// <summary>
        /// View profile summary of jobseeker bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewProfileBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewProfileDAL(candidateId);
        }

        /// <summary>
        /// View conatct details bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewContactDetailsBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewContactDetailsDAL(candidateId);
        }

        /// <summary>
        /// View personal details bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewPersonalDetailsBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewPersonalDetailsDAL(candidateId);
        }

        /// <summary>
        /// View affiramative details bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewAffirmativeDetailsBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewAffirmativeDetailsDAL(candidateId);
        }

        /// <summary>
        /// View project details bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewProjectDetailsBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewProjectDetailsDAL(candidateId);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="candidateId"></param>
        /// <returns></returns>
        public DataSet ViewEducationDetailsBAL(string candidateId)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewEducationalDetailsDAL(candidateId);
        }

        /// <summary>
        /// View technical skills bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
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