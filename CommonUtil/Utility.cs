﻿using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CommonUtil
{
    /// <summary>
    /// Class Utility.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Forget password method in Utility class
        /// </summary>
        /// <param name="forgotPasswordEntity">The forgot password entity.</param>
        /// <returns>System.Data.DataSet.</returns>
        public static DataSet ForgetPasswordJobSeeker(ForgetPasswordEntity forgotPasswordEntity)
        {
            ForgetPasswordDAL jobSeekerDAL = new ForgetPasswordDAL();
            try
            {
                return jobSeekerDAL.GetEmailDetailsDAL(forgotPasswordEntity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Change password method in Utility class
        /// </summary>
        /// <param name="changepasswordEntity">The change password entity</param>
        /// <returns>System.Int32</returns>
        public static int ChangePassword(ChangePasswordEnitity changepasswordEntity)
        {
            ChangePasswordDAL cpDAL = new ChangePasswordDAL();
            return cpDAL.ChangePasswordDALMethod(changepasswordEntity);
        }

        /// <summary>
        /// GetCountry() Method in Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>

        public static DataSet GetCountry()
        {
            Common common = new Common();
            return common.GetCountryDAL();
        }

        /// <summary>
        /// GetState() method of Utility class
        /// </summary>
        /// <param name="countryid">Parameter to get state of desired country </param>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetState(int countryid)
        {
            Common common = new Common();
            return common.GetStateDAL(countryid);
        }

        /// <summary>
        /// GetCity() Method of Utility class
        /// </summary>
        /// <param name="stateid">Parameter to get city of desired state</param>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetCity(int stateid)
        {
            Common common = new Common();
            return common.GetCityDAL(stateid);
        }
        public static DataSet GetArea(int cityId)
        {
            Common common = new Common();
            return common.GetAreaDAL(cityId);
        }
        public static DataSet GetFunctionalArea()
        {
            Common common = new Common();
            return common.GetFunctionalAreaDAL();
        }

        /// <summary>
        /// Get Industries
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetIndustry()
        {
            Common common = new Common();
            return common.GetIndustryDAL();
        }
        /// <summary>
        /// Get Departments
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetDepartment()
        {
            Common common = new Common();
            return common.GetDepartmentDAL();
        }
        /// <summary>
        /// GetEducationalDegreeTypeDAL() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetEducationalDegreeTypeDAL()
        {
            Common common = new Common();
            return common.GetEducationalDegreeTypeDAL();
        }
        /// <summary>
        /// GetLanguage() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetLanguage()
        {
            Common common = new Common();
            return common.GetLanguagesDAL();
        }
        /// <summary>
        /// GetClientName() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetClientName()
        {
            Common common = new Common();
            return common.GetClientNameDAL();
        }
        /// <summary>
        /// GetUnderGraduateDiploma() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetUnderGraduateDiplomaDAL()
        {
            Common common = new Common();
            return common.GetUnderGraduateDiplomaDAL();
        }
        /// <summary>
        /// GetBachelorDegree() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetBachelorDegreeDAL()
        {
            Common common = new Common();
            return common.GetBachelorDegreeDAL();
        }
        /// <summary>
        /// GetPostGraduateDiploma() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetPostGraduateDiplomaDAL()
        {
            Common common = new Common();
            return common.GetPostGraduateDiplomaDAL();
        }
        /// <summary>
        /// GetMasterDegree() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetMasterDegreeDAL()
        {
            Common common = new Common();
            return common.GetMasterDegreeDAL();
        }
        /// <summary>
        /// GetDoctorOfPhilosophy() method of Utility class
        /// </summary>
        /// <returns>System.Data.DataSet</returns>
        public static DataSet GetDoctorOfPhilosophyDAL()
        {
            Common common = new Common();
            return common.GetDoctorOfPhilosophyDAL();
        }
        /// <summary>
        /// GetRoles() method Of utility Class
        /// </summary>
        /// <returns>System.Data.Set</returns>
        public static DataSet GetRoles()
        {
            Common common = new Common();
            return common.GetRole();
        }

        public static DataSet GetLocation()
        {
            Common common = new Common();
            return common.GetLocation();
        }

        public static List<string> GetYears()
        {
            List<string> yearList = new List<string>();
            int i = DateTime.Now.Year;
            for (i = i - 60; i <= DateTime.Now.Year + 10; i++)
                yearList.Add(Convert.ToString(i));
            return yearList;
        }
        public static List<string> GetMonths()
        {
            string[] months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            List<string> monthList = new List<string>(months);
             //monthList = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
             //Arrays.asList(months) = List<string> monthList;
            //int i = DateTime.Now.Month;
            //for (i = 1; i <= DateTime.Now.Month; i++)
            //    monthList.Add(Convert.ToString(i));
            return monthList;
        }
    }
}