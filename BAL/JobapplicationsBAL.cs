using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.JobSeeker;
using DAL;
using System.Data;


namespace BAL
{
  public  class JobApplicationsBAL
    {


      public DataSet GetData()
        {

            JobApplicationDAL jobapplicationDAL = new JobApplicationDAL();
            return jobapplicationDAL.Getdata();
        }
    }
}
