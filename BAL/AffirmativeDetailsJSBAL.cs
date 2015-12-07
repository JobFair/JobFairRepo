using CommonUtil;
using DAL;
using Entities.JobSeeker;
using System.Collections.Generic;
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
        public bool SaveAffirmaiveDetailsBAL(AffirmativeDetailsEntity affirmativeDetailsEntity)
        {
            AffirmativeDetailsJSDAL affirmativeDetailsDAL = new AffirmativeDetailsJSDAL();
            return affirmativeDetailsDAL.SaveAffirmativeDetailsDAL(affirmativeDetailsEntity);
        }

        /// <summary>
        /// Language Details
        /// </summary>
        /// <param name="languageEntity">LanguageEntity</param>
        /// <returns>System.Int32</returns>
        public bool SaveLanguageDetailsBAL(List<LanguageEntity> languageEntity)
        {
            AffirmativeDetailsJSDAL affirmativeDetailsBAL = new AffirmativeDetailsJSDAL();
            return affirmativeDetailsBAL.SaveLanguageDetailsDAL(languageEntity);
        }

        /// <summary>
        /// Load Languages
        /// </summary>
        /// <returns>dataset</returns>
        public DataSet GetLanguageBAL()
        {
            return Utility.GetLanguage();
        }

        /// <summary>
        /// View affirmative details of jobseeker bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet viewAffirmativeDetailsBAL(string candidateId)
        {
            AffirmativeDetailsJSDAL affirmativeDetailsDAL = new AffirmativeDetailsJSDAL();
            return affirmativeDetailsDAL.ViewAffirmativeDetialsDAL(candidateId);
        }

        /// <summary>
        /// Update affirmative details of jobseeker bal
        /// </summary>
        /// <param name="affirmativeDetailsEntity">AffirmativeDetailsEntity</param>
        /// <returns>bool</returns>
        public bool UpdateAffirmativeDetailsBAL(AffirmativeDetailsEntity affirmativeDetailsEntity)
        {
            AffirmativeDetailsJSDAL affirmativeDetailsDAL = new AffirmativeDetailsJSDAL();
            return affirmativeDetailsDAL.UpdateAffirmativeDetailsDAL(affirmativeDetailsEntity);
        }

        /// <summary>
        /// Update language details of jobseeker bal
        /// </summary>
        /// <param name="languageEntity">languageEntity</param>
        /// <param name="candidateId">candidateId</param>
        /// <returns>bool</returns>
        public bool UpdateLanguageDetailsBAL(List<LanguageEntity> languageEntity, string candidateId)
        {
            AffirmativeDetailsJSDAL affirmativeDetailsBAL = new AffirmativeDetailsJSDAL();
            return affirmativeDetailsBAL.UpdateLanguageDetailsDAL(languageEntity, candidateId);
        }
    }
}