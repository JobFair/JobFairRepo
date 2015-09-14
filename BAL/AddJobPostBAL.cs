using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Entities.Recruiter;

namespace BAL
{
   public class AddJobPostBAL
   {
       public int JobPostBAL(AddJobPostEntity JPentity)
       {
           AddJobPostDAL JPDAL = new AddJobPostDAL();
           return JPDAL.JobPostDAL(JPentity);
       }
    }
}

