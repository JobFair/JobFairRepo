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
    /// ManageEmployerHRBAL class
    /// </summary>
    public class ManageEmployerHRBAL
    {
        public DataSet ManageEmployerDetailsBAL(long hrId)
        {
            ManageEmployerHRDAL manageEmployerHRDAL = new ManageEmployerHRDAL();
            return manageEmployerHRDAL.ManageEmployerDetailsDAL(hrId);
        }
    }
}
