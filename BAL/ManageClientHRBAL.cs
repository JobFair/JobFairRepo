using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonUtil;
using DAL;
using System.Data;

namespace BAL
{
    /// <summary>
    /// ManageClientHRBAL class
    /// </summary>
    public class ManageClientHRBAL
    {

        public DataSet ManageClientDetailsBAL(long hrId)
        {
            ManageClientHRDAL manageClientHRDAL = new ManageClientHRDAL();
            return manageClientHRDAL.ManageClientDetailsDAL(hrId);
        }
    }
}
