using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities.Recruiter;
using System.Data;

namespace BAL
{
    public class ManageResponsesBAL
    {


        public DataSet BindClientNameBAL(ManageResponsesEntity manageResponsesEntity)
        {
            try
            {
                ManageResponsesDAL manageResponsesDAL = new ManageResponsesDAL();
                return manageResponsesDAL.BindClientNameDAL(manageResponsesEntity);
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
    }
}
