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
            try
            {
                AffirmativeDetailsJSDAL affirmativeDetailsDAL = new AffirmativeDetailsJSDAL();
                return affirmativeDetailsDAL.SaveAffirmativeDetailsDAL(affirmativeDetailsEntity);
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }

        /// <summary>
        /// Language Details
        /// </summary>
        /// <param name="languageEntity">LanguageEntity</param>
        /// <returns>System.Int32</returns>
        public bool SaveLanguageDetailsBAL(List<LanguageEntity> languageEntity)
        {
            try
            {
                AffirmativeDetailsJSDAL affirmativeDetailsBAL = new AffirmativeDetailsJSDAL();
                return affirmativeDetailsBAL.SaveLanguageDetailsDAL(languageEntity);
            }
            catch (System.Exception)
            {
                
                throw;
            }
          
        }

        /// <summary>
        /// Load Languages
        /// </summary>
        /// <returns></returns>
        public DataSet GetLanguageBAL()
        {
            try
            {
                return Utility.GetLanguage();
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
    }
}