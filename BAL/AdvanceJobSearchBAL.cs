using CommonUtil;
using DAL;
using System.Data;

namespace BAL
{
    public class AdvanceJobSearchBAL
    {
        /// <summary>
        /// create method in BAL
        /// </summary>
        /// <returns></returns>

        public static object GetIndustry()
        {
            return Utility.GetIndustry();
        }

        public static object GetFunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }

        public static object GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }

        public DataSet GetState()
        {
            AdvanceSearchDAL advanceSearchDAL = new AdvanceSearchDAL();
            return advanceSearchDAL.GetStateDAL();
        }

        public DataTable GetTechnicalSkillBAL(string prefixText)
        {
            AdvanceSearchDAL advanceSearchDAL = new AdvanceSearchDAL();
            return advanceSearchDAL.GetTechnicalSkillDAL(prefixText);
        }

        public static object GetCity(int stateId)
        {
            return Utility.GetCity(stateId);
        }

        public static object GetArea()
        {
            return Utility.GetArea();
        }

        public DataTable GetRoles(string prefixText)
        {
            AdvanceSearchDAL advancesearchDAL = new AdvanceSearchDAL();
            return advancesearchDAL.GetRoles(prefixText);
        }
    }
}