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
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            return viewProfileJSDAL.ViewProfileDAL(candidateId);
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
