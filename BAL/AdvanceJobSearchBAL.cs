using CommonUtil;
using DAL;
using System.Data;

namespace BAL
{
    public class AdvanceJobSearchBAL
    {
       
        /// <summary>
        /// Get industry bal
        /// </summary>
        /// <returns>dataset</returns>
        public static object GetIndustry()
        {
            return Utility.GetIndustry();
        }
        /// <summary>
        /// Get functional area bal
        /// </summary>
        /// <returns>dataset</returns>
        public static object GetFunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }
        /// <summary>
        /// Get area bal
        /// </summary>
        /// <param name="cityId">cityId</param>
        /// <returns>dataset</returns>
        public static object GetArea(int cityId)
        {
            return Utility.GetArea(cityId);
        }
        /// <summary>
        /// Get state bal
        /// </summary>
        /// <returns>dataset</returns>
        public DataSet GetState()
        {
            AdvanceSearchDAL advanceSearchDAL = new AdvanceSearchDAL();
            return advanceSearchDAL.GetStateDAL();
        }
        /// <summary>
        /// Get technical skill bal
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>datatable</returns>
        public DataTable GetTechnicalSkillBAL(string prefixText)
        {
            AdvanceSearchDAL advanceSearchDAL = new AdvanceSearchDAL();
            return advanceSearchDAL.GetTechnicalSkillDAL(prefixText);
        }
        /// <summary>
        /// Get city bal
        /// </summary>
        /// <param name="stateId">stateId</param>
        /// <returns>datset</returns>
        public static object GetCity(int stateId)
        {
            return Utility.GetCity(stateId);
        }
        /// <summary>
        /// Get roles bal
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>datatable</returns>
        public   DataTable GetRoles(string prefixText)
        {
            AdvanceSearchDAL advancesearchDAL = new AdvanceSearchDAL();
            return advancesearchDAL.GetRoles(prefixText);
        }
    }
}