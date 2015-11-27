﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;


namespace DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class ViewProfileJSDAL
    {
        private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["JobPortalCon"].ToString());
       
        public DataSet ViewProfileDAL(string candidateId)
        {
           // try
           // {          
           //ds= SqlHelper.ExecuteDataset(connection, CommandType.Text, "select * from JS_RegisterDetails where CandidateId='JS12'");
           //viewProfileEntity.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
           //viewProfileEntity.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
           //viewProfileEntity.MobileNumber = ds.Tables[0].Rows[0]["MobileNo"].ToString();           
           //viewProfileEntity.EmailId = ds.Tables[0].Rows[0]["EmailId"].ToString();
           //   SqlParameter[] sparams1=new SqlParameter[1];
           //     sparams1[0]=new SqlParameter("@id","JS12");
           //ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, "sp_JS_SelectPersonalDetails",sparams1);
           //     viewProfileEntity.Birthdate=Convert.ToDateTime(ds.Tables[0].Rows[0]["DateOfBirth"].ToString());
           //     viewProfileEntity.Address=ds.Tables[0].Rows[0]["CurrentAddress"].ToString();
           // }
           // catch (Exception)
           // {

           //     throw;
           // }
           //return ds;
            try
            {
                 DataSet ds = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                ds = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_ViewProfile, sparams);
                return ds;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

       public DataSet ViewContactDetailsDAL(string candidateId)
        {
            try
            {
                DataSet dsContactDetails = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsContactDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectContactDetails, sparams);
                return dsContactDetails;
            }
            catch (Exception)
            {
                
                throw;
            }
       }

        public DataSet ViewPersonalDetailsDAL(string candidateId)
       {
           try
           {
               DataSet dsPersonalDetails = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsPersonalDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectPersonalDetails, sparams);
                return dsPersonalDetails;
           }
           catch (Exception)
           {
               
               throw;
           }
       }

        public DataSet ViewAffirmativeDetailsDAL(string candidateId)
        {
            try
            {
                 DataSet dsAffirmativeDetails = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsAffirmativeDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectAffirmativeDetails, sparams);
                return dsAffirmativeDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet ViewProjectDetailsDAL(string candidateId)
        {
            try
            {
                 DataSet dsProjectDetails = new DataSet();
                SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
                dsProjectDetails = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectProjectDetails, sparams);
                return dsProjectDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet ViewTechnicalSkillsDAL(string candidateId)
        {
            DataSet dsViewTechnicalSkills = new DataSet();
            SqlParameter[] sparams = { new SqlParameter("@candidateId", candidateId) };
            dsViewTechnicalSkills = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, Constants.sp_JS_SelectTechnicalSkills, sparams);
            return dsViewTechnicalSkills;
        }
        public int ChangeConatctNoDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams =new SqlParameter[2];
            sparams[0]=new SqlParameter("@id","JS12");
            sparams[1]=new SqlParameter("@newmobNo",viewProfileEntity.MobileNumber);
            int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, Constants.sp_JS_UpdateContactDetails, sparams);
            return result;
        }

        public int ResumeDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams = new SqlParameter[2];
            sparams[0] = new SqlParameter("@id", "JS12");
            int result=1;
            return result;
 
        }

        public int ChangePersonalDetailsDAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            SqlParameter[] sparams=new SqlParameter[6];
            sparams[0] = new SqlParameter("@id", "JS12");
            sparams[1] = new SqlParameter("@firstName", viewProfileEntity.FirstName);
            sparams[2] = new SqlParameter("@lastName", viewProfileEntity.LastName);
            sparams[3] = new SqlParameter("@emailId", viewProfileEntity.EmailId);
            sparams[4] = new SqlParameter("@dateOfBirth", viewProfileEntity.Birthdate.ToShortDateString());
            sparams[5] = new SqlParameter("@address", viewProfileEntity.Address);
            int result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "sp_JS_UpdatePersonalDetails", sparams);
            return result;
        }
    }
}
