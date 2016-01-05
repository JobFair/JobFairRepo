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
        public bool SaveLanguageDetailsBAL(List<Entities.Common.LanguageEntity> languageDetailsList)
        {
            AffirmativeDetailsREDAL affirmativeDetailsREDAL = new AffirmativeDetailsREDAL();
            return affirmativeDetailsREDAL.SaveLanguageDetailsDAL(languageDetailsList);
        }

        public bool SaveAffirmaiveDetailsBAL(Entities.Common.AffirmativeDetailsEntity affirmativeDetailsEntity)
        {
            AffirmativeDetailsREDAL affirmativeDetailsREDAL = new AffirmativeDetailsREDAL();
            return affirmativeDetailsREDAL.SaveAffirmativeDetailsDAL(affirmativeDetailsEntity);
        }

        public System.Data.DataSet GetLanguageBAL()
        {
            return Utility.GetLanguage();
        }
    }
}
