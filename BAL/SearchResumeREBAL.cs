using CommonUtil;
using DAL;
using System.Data;

namespace BAL
{
    public class SearchResumeREBAL
    {
        public DataSet GetClientNameBAL()
        {
            SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
            return searchResumeDAL.GetClientNameDAL();
        }

        public DataSet GetPositionBAL(long clientId)
        {
            SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
            return searchResumeDAL.GetPositionDAL(clientId);
        }

        public int GetRequirementIdBAL(string position)
        {
            SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
            return searchResumeDAL.GetRequirementIdDAL(position);
        }

        /// <summary>
        /// Method to get Industry
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public DataSet GetIndustryBAL()
        {
            return Utility.GetIndustry();
        }

        public DataSet GetFunctionalAreaBAL()
        {
            return Utility.GetFunctionalArea();
        }

        public DataSet GetDepartmentBAL()
        {
            return Utility.GetDepartment();
        }

        public DataTable GetRolesBAL(string prefixText)
        {
            SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
            return searchResumeDAL.GetRolesDAL(prefixText);
        }

        public DataTable GetTechnicalskillBAL(string prefixText)
        {
            SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
            return searchResumeDAL.GetTechnicalSkillsDAL(prefixText);
        }

        public DataTable GetCountryBAL(string prefixText)
        {
            SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
            return searchResumeDAL.GetCountryDAL(prefixText);
        }

        public DataTable GetStateBAL(string prefixText)
        {
            SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
            return searchResumeDAL.GetStateDAL(prefixText);
        }

        public DataTable GetCityBAL(string prefixText)
        {
            SearchResumeREDAL searchResumeDAL = new SearchResumeREDAL();
            return searchResumeDAL.GetCityDAL(prefixText);
        }
    }
}