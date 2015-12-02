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
            return Utility.GetCountry();
        }

        /// <summary>
        /// Method to get Departments
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetDepartment()
        {
            return Utility.GetDepartment();
        }

        /// <summary>
        /// Method to get Industry
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetIndustry()
        {
            return Utility.GetIndustry();
        }

        /// <summary>
        /// Method to get State
        /// </summary>
        /// <param name="CountryId">Parameter of Country table to get State accordingly</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetState(int CountryId)
        {
            return Utility.GetState(CountryId);
        }

        /// <summary>
        /// Method to get City
        /// </summary>
        /// <param name="StateId">Parameter of State table to get City accordingly</param>
        /// <returns>System.Data.DataSet</returns>
        public System.Data.DataSet GetCity(string StateId)
        {
            return Utility.GetCity(StateId);
        }

        /// <summary>
        /// Method to save experience details in CurrentDesiredJobBAL class
        /// </summary>
        /// <param name="dt">Parameter of DataTable </param>
        /// <returns>System.Data.DataTable</returns>
        public DataTable SaveExperienceDetailsBAL(System.Data.DataTable dt)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.SaveExperienceDetailsDAL(dt);
        }

        /// <summary>
        /// Method to get Functional Area
        /// </summary>
        /// <returns>System.DataSet</returns>
        public DataSet GetFunctionalArea()
        {
            return Utility.GetFunctionalArea();
        }

        /// <summary>
        /// Method to save Job Looking Details in CurrentDesiredJobBAL class
        /// </summary>
        /// <param name="dt">Parameter type DataTable</param>
        /// <returns>System.Data.DataTable</returns>
        public DataTable SaveJobLookingDetailsBAL(DataTable dt)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.SaveJobLookingDetailsDAL(dt);
        }

        /// <summary>
        /// Method to save Job details in CurrentDesiredJobBAL class
        /// </summary>
        /// <param name="currentDesiredJobEntity">Object of CurrentDesiredJobEntity class</param>
        public void SaveJobDetailsBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.SaveJobDetailsDAL(currentDesiredJobEntity);
        }

        /// <summary>
        /// Method to save desired details in CurrentDesiredJobBAL class
        /// </summary>
        /// <param name="currentDesiredJobEntity">Object of CurrentDesiredJobEntity class</param>
        public void SaveDesiredJobDetailsBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.SaveDesiredJobDetailsDAL(currentDesiredJobEntity);
        }

        /// <summary>
        /// Method to get State
        /// </summary>
        /// <returns>System.DataSet</returns>
        public DataSet GetStateBAL()
        {
            return Utility.GetState();
        }

        /// <summary>
        /// Method to Get CityArea in CurrentDesiredJobBAL class
        /// </summary>
        /// <param name="cityId">String parameter</param>
        /// <returns>System.Data.DataSet</returns>
        public DataSet GetArea(string cityId)
        {
            return Utility.GetArea(cityId);
        }

        /// <summary>
        /// Method to Get Technical Skills in CurrentDesiredJobBAL
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public DataSet GetTechnicalSkillsDetailsBAL()
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.GetTechnicalSkillsDetailsDAL();
        }

        /// <summary>
        /// Method to Save Technical
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public DataTable SaveTechnicalSkillsBAL(DataTable dt)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.SaveTechnicalSkillsDAL(dt);
        }

        public DataSet GetRoleSkillsBAL()
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.GetRoleSkillsDAL();
        }

        public DataTable SaveRoleSkillsBAL(DataTable dt)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.SaveRoleSkillsDAL(dt);
        }

        public DataSet ViewCurrentJobDetailsBAL(string candidateId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.ViewCurrentJobDetailsDAL(candidateId);
        }

        public void UpdateJobLookingBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.UpdateJobLookingDAL(currentDesiredJobEntity);
        }

        public void DeleteJobPostLookingForBAL(int JobpostlookingId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.DeleteJobPostLookingForDAL(JobpostlookingId);
        }

        public DataSet ViewRepeaterJobPostLookingBAL(string candidateId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.ViewRepeaterJobPostLookingBAL(candidateId);
        }

        public DataSet ViewRepeaterCurrentPastJobDetailsBAL(string candidateId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.ViewRepeaterCurrentPastJobDetailsDAL(candidateId);
        }

        public void UpdateCurrentPastExpDetailsBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.UpdateCurrentPastExpDetailsDAL(currentDesiredJobEntity);
        }

        public void DeleteCurrentPastJobDetailsBAL(int expId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.DeleteCurrentPastJobDetailsDAL(expId);
        }

        public DataSet GetCountryBAL()
        {
            return Utility.GetCountry();
        }

        public DataSet GetCityBAL(string stateId)
        {
            return Utility.GetCity(stateId);
        }

        public DataSet ViewRepeaterTechSkillDetailsBAL(string candidateId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.ViewRepeaterTechSkillDetailsDAL(candidateId);
        }

        public void UpdateTechnicalSkillsBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.UpdateTechnicalSkillsDAL(currentDesiredJobEntity);
        }

        public void DeleteTechnicalSkillBAL(int SkillId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.DeleteTechnicalSkillDAL(SkillId);
        }

        public DataSet ViewRepeaterRoleSkillDetailsBAL(string candidateId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.ViewRepeaterRoleSkillDetailsDAL(candidateId);
        }

        public void UpdateRoleSkillsBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.UpdateRoleSkillsDAL(currentDesiredJobEntity);
        }

        public void DeleteRoleSkillBAL(int SkillId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.DeleteRoleSkillBAL(SkillId);
        }
    }
}