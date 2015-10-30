using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities.JobSeeker;

namespace BAL
{
   public class AcademicProjectDetailsBAL
    {
       public int SaveAcademicProjectBAL(AcademicProjectDetailsEntity academicProjectDetailsEntity)
       {
           AcademicProjectDetailsDAL academicProjectDetailsDAL = new AcademicProjectDetailsDAL();
           return academicProjectDetailsDAL.SaveAcademicProjectDAL(academicProjectDetailsEntity);
       }
    }
}
