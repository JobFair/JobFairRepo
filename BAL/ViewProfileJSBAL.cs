using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Entities.JobSeeker;
namespace BAL
{
    public class ViewProfileJSBAL
    {
        
        public DataSet ViewProfileBAL(string candidateId)
        {
            try
            {
                ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
                return viewProfileJSDAL.ViewProfileDAL(candidateId);
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public DataSet ViewContactDetailsBAL(string candidateId)
        {
            try
            {
                ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
                return viewProfileJSDAL.ViewContactDetailsDAL(candidateId);
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public DataSet ViewPersonalDetailsBAL(string candidateId)
        {
            try
            {
                 ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
                 return viewProfileJSDAL.ViewPersonalDetailsDAL(candidateId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public DataSet ViewAffirmativeDetailsBAL(string candidateId)
        {
            try
            {
                 ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
                 return viewProfileJSDAL.ViewAffirmativeDetailsDAL(candidateId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataSet ViewProjectDetailsBAL(string candidateId)
        {
            try
            {
                ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
                return viewProfileJSDAL.ViewProjectDetailsDAL(candidateId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataSet ViewTechnicalSkillBAL(string candidateId)
        {
            try
            {
                ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
                return viewProfileJSDAL.ViewTechnicalSkillsDAL(candidateId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public int ChangeContactNoBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ChangeConatctNoDAL(viewProfileEntity);
        }



        public int ResumeDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ResumeDetailsDAL(viewProfileEntity);
        }

        public int ChangePersonalDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ChangePersonalDetailsDAL(viewProfileEntity);
        }

    }
}
