using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class ViewProfileJSBAL
    {
        public void ViewProfileBAL(Entities.JobSeeker.ViewProfileEntity viewProfileEntity)
        {
            ViewProfileJSDAL viewProfileJSDAL = new ViewProfileJSDAL();
            viewProfileJSDAL.ViewProfileDAL(viewProfileEntity);
        }
    }
}
