using CommonUtil;
using DAL;
using Entities.Recruiter;
namespace BAL
{
    public class AdvanceJobSearchBAL
    {
        /// <summary>
        /// create method in Bal 
        /// </summary>
        /// <returns></returns>
        public static object GetIndustry()
        {
            return Utility.GetIndustry();
        }
    }
}
