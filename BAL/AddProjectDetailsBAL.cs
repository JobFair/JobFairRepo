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
  public  class AddProjectDetailsBAL
    {
      public DataTable LoadRole()
      {
          AddProjectDetailsDAL pdDAL = new AddProjectDetailsDAL();
          return pdDAL.LoadRole();
      }
      public int ProjectDetailsBAL(AddProjectDetailsEntity pdEntity)
      {
          AddProjectDetailsDAL pdDAL = new AddProjectDetailsDAL();
          return pdDAL.ProjectDetailsDAL(pdEntity);
      }
    }
}
