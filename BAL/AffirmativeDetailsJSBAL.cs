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
        public DataSet viewAffirmativeDetailsBAL(string candidateId)
        {
            try
            {
                AffirmativeDetailsJSDAL affirmativeDetailsDAL = new AffirmativeDetailsJSDAL();
                return affirmativeDetailsDAL.ViewAffirmativeDetialsDAL(candidateId);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public bool UpdateAffirmativeDetailsBAL(AffirmativeDetailsEntity affirmativeDetailsEntity)
        {
            try
            {
                 AffirmativeDetailsJSDAL affirmativeDetailsDAL = new AffirmativeDetailsJSDAL();
                return affirmativeDetailsDAL.UpdateAffirmativeDetailsDAL(affirmativeDetailsEntity);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public bool UpdateLanguageDetailsBAL(List<LanguageEntity> languageEntity,string candidateId)
        {
            try
            {
                AffirmativeDetailsJSDAL affirmativeDetailsBAL = new AffirmativeDetailsJSDAL();
                return affirmativeDetailsBAL.UpdateLanguageDetailsDAL(languageEntity,candidateId);
            }
            catch (System.Exception)
            {
                throw;
            }

        }
    }
}