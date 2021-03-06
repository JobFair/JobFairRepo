﻿using Entities.JobSeeker;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SearchJSDAL
    {
        private SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());

        /// <summary>
        /// Get technical skill DAL
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>DataTable</returns>
        public DataTable GetTechnicalSkill(string prefixText)
        {
            Connection.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Constants.sp_SelectTechnicalSkills, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TechnicalSkillName", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        /// <summary>
        /// Get city DAL
        /// </summary>
        /// <param name="prefixText">prefixText</param>
        /// <returns>DataTable</returns>
        public DataTable GetCity(string prefixText)
        {
            Connection.Open();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(Constants.sp_SelectCity, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CityName", prefixText);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        /// <summary>
        /// Get jobs from search dal
        /// </summary>
        /// <param name="searchEntity">AdvanceSearchDetailsEntity</param>
        /// <returns>DataSet</returns>
        public DataSet JobSearchDAL(AdvanceSearchDetailsEntity searchEntity)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand(Constants.sp_JS_JobSearch, Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@keywordTechnical", searchEntity.KeySkill);
                cmd.Parameters.AddWithValue("@locationCity", searchEntity.City);
                cmd.Parameters.AddWithValue("@experience", searchEntity.WorkExp);
                cmd.Parameters.AddWithValue("@salary", searchEntity.MaxSalary);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception)
            {
                throw;
            }
            return ds;
        }
    }
}