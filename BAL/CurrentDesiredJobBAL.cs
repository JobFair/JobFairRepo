using CommonUtil;
using DAL;
using Entities.JobSeeker;
using System.Data;

namespace BAL
{
    /// <summary>
    /// CurrentDesiredJobBAL class
    /// </summary>
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
        /// Method to save experience details in CurrentDesiredJobBAL class
        /// </summary>
        /// <param name="dt">Parameter of DataTable </param>
        /// <returns>System.Data.DataTable</returns>
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
        /// <summary>
        /// Method to get Functional Area
        /// </summary>
        /// <returns>System.DataSet</returns>
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
        /// <summary>
        /// Method to save Job Looking Details in CurrentDesiredJobBAL class
        /// </summary>
        /// <param name="dt">Parameter type DataTable</param>
        /// <returns>System.Data.DataTable</returns>
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
        /// <summary>
        /// Method to save Job details in CurrentDesiredJobBAL class
        /// </summary>
        /// <param name="currentDesiredJobEntity">Object of CurrentDesiredJobEntity class</param>
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
        /// <summary>
        /// Method to save desired details in CurrentDesiredJobBAL class
        /// </summary>
        /// <param name="currentDesiredJobEntity">Object of CurrentDesiredJobEntity class</param>
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
        /// <summary>
        /// Method to get State
        /// </summary>
        /// <returns>System.DataSet</returns>
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
       
        /// <summary>
        /// Method to Get CityArea in CurrentDesiredJobBAL class
        /// </summary>
        /// <param name="cityId">String parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public DataSet GetArea(string cityId)
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

        public DataSet GetTechnicalSkillsDetailsBAL()
        {
            try
            {
                CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
                return currentDesiredJobDAL.GetTechnicalSkillsDetailsDAL();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public DataTable SaveTechnicalSkillsBAL(DataTable dt)
        {
            try
            {
                CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
                return currentDesiredJobDAL.SaveTechnicalSkillsDAL(dt);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            

        }

        public DataSet GetRoleSkillsBAL()
        {
            try
            {
                CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
                return currentDesiredJobDAL.GetRoleSkillsDAL();

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public DataTable SaveRoleSkillsBAL(DataTable dt)
        {
            try
            {
                CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
                return currentDesiredJobDAL.SaveRoleSkillsDAL(dt);
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }
    }
}