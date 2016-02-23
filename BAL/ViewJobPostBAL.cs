using DAL;
using System.Data;

namespace BAL
{
    public class ViewJobPostBAL
    {
        /// <summary>
        /// View all job post BAL
        /// </summary>
        /// <returns>Dataset</returns>
        public DataSet ViewAllJobPostBAL()
        {
            ViewJobPostJSDAL viewJobPostJSDAL = new ViewJobPostJSDAL();
            return viewJobPostJSDAL.ViewAllJobPostDAL();
        }
    }
}