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
            try
            {
                return Utility.GetIndustry();
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }
        public static object GetFunctionalArea()
        {
            try
            {
                return Utility.GetFunctionalArea();
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
        public static object GetCity(int StateId)
        {
            try
            {
                return Utility.GetCity(StateId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
        public static object GetArea(int cityId)
        {
            try
            {
                return Utility.GetArea(cityId);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            
        }
        public DataSet GetState()
        {
            try
            {
                return advanceSearchDAL.GetStateDAL();
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
        public DataTable GetTechnicalSkillBAL(string prefixText)
        {
            try
            {
                return advanceSearchDAL.GetTechnicalSkillDAL(prefixText);
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
    }
}
