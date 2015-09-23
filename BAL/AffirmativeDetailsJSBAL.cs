using CommonUtil;
using DAL;
using Entities.JobSeeker;
using System.Data;

namespace BAL
{
    public class AffirmativeDetailsJSBAL
    {
        /// <summary>
        /// Affirmative Details of job seeker
        /// </summary>
        /// <param name="adEntity">AffirmativeDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int AffirmaiveDetailsBAL(AffirmativeDetailsEntity adEntity)
        {
            AffirmativeDetailsJSDAL adDAL = new AffirmativeDetailsJSDAL();
            return adDAL.AffirmativeDetailsDAL(adEntity);
        }

        /// <summary>
        /// Language Details
        /// </summary>
        /// <param name="languageEntity">LanguageEntity</param>
        /// <returns>System.Int32</returns>
        public int LanguageDetailsBAL(LanguageEntity languageEntity)
        {
            AffirmativeDetailsJSDAL adBAL = new AffirmativeDetailsJSDAL();
            return adBAL.LanguageDetailsDAL(languageEntity);
        }

        /// <summary>
        /// Load Languages
        /// </summary>
        /// <returns></returns>
        public DataSet GetLanguageBAL()
        {
            return Utility.GetLanguage();
        }
    }
}