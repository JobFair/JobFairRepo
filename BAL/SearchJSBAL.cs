using DAL;
using System.Data;

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
    }
}