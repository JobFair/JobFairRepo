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
        public DataSet ViewProfileBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
           
            return viewProfileJSDAL.ViewProfileDAL(viewProfileEntity);
        }

        public int ChangeContactNoBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            return viewProfileJSDAL.ChangeConatctNoDAL(viewProfileEntity);
        }



        public int ResumeDetailsBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            return viewProfileJSDAL.ResumeDetailsDAL(viewProfileEntity);
        }
    }
}
