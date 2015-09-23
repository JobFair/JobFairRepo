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
        /// <param name="affirmativeDetailsEntity">AffirmativeDetailsEntity</param>
        /// <returns>System.Int32</returns>
        public int SaveAffirmaiveDetailsBAL(AffirmativeDetailsEntity affirmativeDetailsEntity)
        {
            AffirmativeDetailsJSDAL affirmativeDetailsDAL = new AffirmativeDetailsJSDAL();
            return affirmativeDetailsDAL.SaveAffirmativeDetailsDAL(affirmativeDetailsEntity);
        }

        /// <summary>
        /// Language Details
        /// </summary>
        /// <param name="languageEntity">LanguageEntity</param>
        /// <returns>System.Int32</returns>
        public int SaveLanguageDetailsBAL(LanguageEntity languageEntity)
        {
            AffirmativeDetailsJSDAL affirmativeDetailsBAL = new AffirmativeDetailsJSDAL();
            return affirmativeDetailsBAL.SaveLanguageDetailsDAL(languageEntity);
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