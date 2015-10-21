using CommonUtil;
using DAL;
using Entities.Recruiter;
using System.Data;
namespace BAL
{
    public class AdvanceJobSearchBAL
    {
        /// <summary>
        /// create method in BAL
        /// </summary>
        /// <returns></returns>
        AdvanceSearchDAL advanceSearchDAL = new AdvanceSearchDAL();
        public static object GetIndustry()
        {
            return Utility.GetIndustry();
        }
        public static object GetFunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }
        public static object GetCity(int StateId)
        {
            return Utility.GetCity(StateId);
        }
        public static object GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }
        public DataSet GetState()
        {
            return advanceSearchDAL.GetStateDAL();
        }
        public DataTable GetTechnicalSkillBAL(string prefixText)
        {
            return advanceSearchDAL.GetTechnicalSkillDAL(prefixText);
        }
    }
}
