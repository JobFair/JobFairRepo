using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BAL
{
    public class ViewProfileJSBAL
    {
        ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
        //public DataSet ViewProfileBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        //{

        //    return viewProfileJSDAL.ViewProfileDAL(viewProfileEntity);
        //}

        public int ChangeContactNoBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            return viewProfileJSDAL.ChangeConatctNoDAL(viewProfileEntity);
        }



        //public int ResumeDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        //{
        //    return viewProfileJSDAL.ResumeDetailsDAL(viewProfileEntity);
        //}

        public int ChangePersonalDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            return viewProfileJSDAL.ChangePersonalDetailsDAL(viewProfileEntity);
        }


        public DataSet RegisterDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            return viewProfileJSDAL.RegisterDetailsDAL(viewProfileEntity);
        }

        public DataSet PersonalDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            return viewProfileJSDAL.PersonalDetailsBAL(viewProfileEntity);
        }

        public DataSet ProfessionalDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            return viewProfileJSDAL.ProfessionalDetailsBAL(viewProfileEntity);
        }

        public int ChangeProfessionalDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            return viewProfileJSDAL.ChangeProfessionalDetailsDAL(viewProfileEntity);
        }
    }
}
