using DAL;
using System.Data;

namespace BAL
{
    public class TechnicalSkillsDetailsBAL
    {
        private TechnicalSkillsDetailsDAL technicalSkillsDAL = new TechnicalSkillsDetailsDAL();

        public DataSet TechnicalSkillsLanguageBAL()
        {
            return technicalSkillsDAL.TechnicalSkillLanguageDAL();
        }

        public DataSet DatabaseBAL()
        {
            return technicalSkillsDAL.DatabaseDAL();
        }

        public DataSet SoftwaresBAL()
        {
            return technicalSkillsDAL.SoftwaresDAL();
        }

        public DataSet OperatingSystemBAL()
        {
            return technicalSkillsDAL.OperatingSystemDAL();
        }
    }
}