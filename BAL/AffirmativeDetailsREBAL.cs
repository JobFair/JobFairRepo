using CommonUtil;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class AffirmativeDetailsREBAL
    {
        /// <summary>
        /// Method to Save language details in AffirmativeDetailsREBAL class
        /// </summary>
        /// <param name="languageDetailsList">Parameter of List of LanguageEntity class</param>
        /// <returns>System.Boolean</returns>
        public bool SaveLanguageDetailsBAL(List<Entities.Recruiter.LanguageEntity> languageDetailsList)
        {
            AffirmativeDetailsREDAL affirmativeDetailsREDAL = new AffirmativeDetailsREDAL();
            return affirmativeDetailsREDAL.SaveLanguageDetailsDAL(languageDetailsList);
        }
        /// <summary>
        /// Method to save affirmative details AffirmativeDetailsREBAL class
        /// </summary>
        /// <param name="affirmativeDetailsEntity">Parameter of AffirmativeDetailsEntity class</param>
        /// <returns>System.Boolean</returns>
        public bool SaveAffirmaiveDetailsBAL(Entities.Recruiter.AffirmativeDetailsEntity affirmativeDetailsEntity)
        {
            AffirmativeDetailsREDAL affirmativeDetailsREDAL = new AffirmativeDetailsREDAL();
            return affirmativeDetailsREDAL.SaveAffirmativeDetailsDAL(affirmativeDetailsEntity);
        }
        /// <summary>
        /// Method to get Language in AffirmativeDetailsREBAL class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetLanguageBAL()
        {
            return Utility.GetLanguage();
        }
    }
}
