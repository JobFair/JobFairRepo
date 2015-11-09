using CommonUtil;
using DAL;
using Entities.JobSeeker;
using System.Data;

namespace BAL
{
    public class CurrentDesiredJobBAL
    {
        
       

       
        /// <summary>
        /// Method to get Country
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCountry()
        {
            try
            {
                return Utility.GetCountry();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get Departments
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetDepartment()
        {
            try
            {
                return Utility.GetDepartment();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get Industry
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetIndustry()
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

        /// <summary>
        /// Method to get State
        /// </summary>
        /// <param name="CountryId">Parameter of Country table to get State accordingly</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetState(int CountryId)
        {
            try
            {
                return Utility.GetState(CountryId);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Method to get City
        /// </summary>
        /// <param name="StateId">Parameter of State table to get City accordingly</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCity(int StateId)
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="PrefixText"></param>
        /// <returns></returns>
        public System.Data.DataTable GetPreferredCityBAL(string PrefixText)
        {
            try
            {
                CurrentDesiredJobDAL desiredjobDAL = new CurrentDesiredJobDAL();
                return desiredjobDAL.GetPreferredCityDAL(PrefixText);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public System.Data.DataTable GetPreferredAreaBAL(string prefixText)
        {
            try
            {
                CurrentDesiredJobDAL desiredjobDAL = new CurrentDesiredJobDAL();
                return desiredjobDAL.GetPreferredAreaDAL(prefixText);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public System.Data.DataSet GetCity()
        {
            try
            {
                return Utility.GetCity();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public System.Data.DataSet GetArea()
        {
            try
            {
                return Utility.GetArea();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public DataTable SaveExperienceDetailsBAL(System.Data.DataTable dt)
        {
            try
            {
                CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
                return currentDesiredJobDAL.SaveExperienceDetailsDAL(dt);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public DataSet GetFunctionalArea()
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

        public DataTable SaveJobLookingDetailsBAL(DataTable dt)
        {
            try
            {
                CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
                return currentDesiredJobDAL.SaveJobLookingDetailsDAL(dt);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void SaveJobDetailsBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            try
            {
                CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
                currentDesiredJobDAL.SaveJobDetailsDAL(currentDesiredJobEntity);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public void SaveDesiredJobDetailsBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {

            try
            {
                CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
                currentDesiredJobDAL.SaveDesiredJobDetailsDAL(currentDesiredJobEntity);

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public DataSet GetStateBAL()
        {
            try
            {
                return Utility.GetState();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}