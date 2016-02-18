using DAL;
using System.Data;
using Entities.JobSeeker;

namespace BAL
{
    public class SearchJSBAL
    {
        public DataTable GetTechnicalskillBAL(string prefixText)
        {
            SearchJSDAL searchDal = new SearchJSDAL();
            return searchDal.GetTechnicalSkill(prefixText);
        }

        public DataTable GetCityBAL(string prefixText)
        {
            SearchJSDAL searchDal = new SearchJSDAL();
            return searchDal.GetCity(prefixText);
        }

        public DataSet JobSearchBAL(AdvanceSearchDetailsEntity searchEntity)
        {
            SearchJSDAL searchDal = new SearchJSDAL();
            return searchDal.JobSearchDAL(searchEntity);
        }
    }
}