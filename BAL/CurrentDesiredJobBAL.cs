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

        /// <summary>
        /// Get roles skills bal
        /// </summary>
        /// <returns>dataset</returns>
        public DataSet GetRoleSkillsBAL()
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.GetRoleSkillsDAL();
        }

        /// <summary>
        /// Save roles skills bal
        /// </summary>
        /// <param name="dt">dt</param>
        /// <returns>datatable</returns>
        public DataTable SaveRoleSkillsBAL(DataTable dt)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.SaveRoleSkillsDAL(dt);
        }

        /// <summary>
        /// View current job details bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewCurrentJobDetailsBAL(string candidateId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.ViewCurrentJobDetailsDAL(candidateId);
        }

        /// <summary>
        /// Update job looking for bal
        /// </summary>
        /// <param name="currentDesiredJobEntity">CurrentDesiredJobEntity</param>
        public void UpdateJobLookingBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.UpdateJobLookingForDAL(currentDesiredJobEntity);
        }

        /// <summary>
        /// Delete job looking for bal
        /// </summary>
        /// <param name="JobpostlookingId">JobpostlookingId</param>
        public void DeleteJobPostLookingForBAL(int JobpostlookingId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.DeleteJobPostLookingForDAL(JobpostlookingId);
        }

        /// <summary>
        /// View  job looking for bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewJobPostLookingBAL(string candidateId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.ViewJobPostLookingForDAL(candidateId);
        }

        /// <summary>
        /// View current and past job details bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewCurrentPastJobDetailsBAL(string candidateId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.ViewCurrentPastJobDetailsDAL(candidateId);
        }

        /// <summary>
        /// Update current and past experience details bal
        /// </summary>
        /// <param name="currentDesiredJobEntity">CurrentDesiredJobEntity</param>
        public void UpdateCurrentPastExperienceDetailsBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.UpdateCurrentPastExperienceDetailsDAL(currentDesiredJobEntity);
        }

        /// <summary>
        /// Delete current and past job details
        /// </summary>
        /// <param name="expId">expId</param>
        public void DeleteCurrentPastJobDetailsBAL(int expId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.DeleteCurrentPastJobDetailsDAL(expId);
        }

        /// <summary>
        /// Get country bal
        /// </summary>
        /// <returns>dataset</returns>
        public DataSet GetCountryBAL()
        {
            return Utility.GetCountry();
        }

        /// <summary>
        /// Get city bal
        /// </summary>
        /// <param name="stateId">stateId</param>
        /// <returns>dataset</returns>
        public DataSet GetCityBAL(string stateId)
        {
            return Utility.GetCity(stateId);
        }

        /// <summary>
        /// View technical skills details bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewTechnicalSkillDetailsBAL(string candidateId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.ViewTechSkillDetailsDAL(candidateId);
        }

        /// <summary>
        /// Update technical skills bal
        /// </summary>
        /// <param name="currentDesiredJobEntity">CurrentDesiredJobEntity</param>
        public void UpdateTechnicalSkillsBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.UpdateTechnicalSkillsDAL(currentDesiredJobEntity);
        }

        /// <summary>
        /// Delete technical skills bal
        /// </summary>
        /// <param name="skillId">SkillId</param>
        public void DeleteTechnicalSkillBAL(int skillId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.DeleteTechnicalSkillDAL(skillId);
        }

        /// <summary>
        /// View roles skills details bal
        /// </summary>
        /// <param name="candidateId">candidateId</param>
        /// <returns>dataset</returns>
        public DataSet ViewRoleSkillDetailsBAL(string candidateId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            return currentDesiredJobDAL.ViewRoleSkillDetailsDAL(candidateId);
        }

        /// <summary>
        /// Update roles skills bal
        /// </summary>
        /// <param name="currentDesiredJobEntity">CurrentDesiredJobEntity</param>
        public void UpdateRoleSkillsBAL(CurrentDesiredJobEntity currentDesiredJobEntity)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.UpdateRoleSkillsDAL(currentDesiredJobEntity);
        }

        /// <summary>
        /// Delete role skills bal
        /// </summary>
        /// <param name="skillId">SkillId</param>
        public void DeleteRoleSkillBAL(int skillId)
        {
            CurrentDesiredJobDAL currentDesiredJobDAL = new CurrentDesiredJobDAL();
            currentDesiredJobDAL.DeleteRoleSkillDAL(skillId);
        }
    }
}