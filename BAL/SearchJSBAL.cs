using DAL;
using Entities.JobSeeker;
using System.Data;

namespace BAL
{
    public class SearchJSBAL
    {
        /// <summary>
        /// Get technical skills BAL
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>DataTable</returns>
        public DataTable GetTechnicalskillBAL(string prefixText)
        {
            SearchJSDAL searchDal = new SearchJSDAL();
            return searchDal.GetTechnicalSkill(prefixText);
        }

        /// <summary>
        /// Get city BAL
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>DataTable</returns>
        public DataTable GetCityBAL(string prefixText)
        {
            SearchJSDAL searchDal = new SearchJSDAL();
            return searchDal.GetCity(prefixText);
        }

        /// <summary>
        /// Get job from search bal
        /// </summary>
        /// <param name="searchEntity">AdvanceSearchDetailsEntity</param>
        /// <returns>DataSet</returns>
        public DataSet JobSearchBAL(AdvanceSearchDetailsEntity searchEntity)
        {
            SearchJSDAL searchDal = new SearchJSDAL();
            return searchDal.JobSearchDAL(searchEntity);
        }
    }
}