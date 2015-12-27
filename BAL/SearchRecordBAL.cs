using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonUtil;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class SearchRecordBAL
    {
        public static object Functionalarea()
        {
            return Utility.GetFunctionalArea();
        }

        public static object industrytype()
        {
            return Utility.GetIndustry();
        }



        //public static object GetUnderGraduateDiplomaBAL()
        //{
        //    return Utility.GetUnderGraduateDiplomaDAL();
        //}

        //public static object GetMasterDegreeBAL()
        //{
        //    return Utility.GetMasterDegreeDAL();
        //}

        public static object GetDepartment()
        {
            return Utility.GetDepartment();
        }

        public static object GetKeyroles()
        {
            throw new NotImplementedException();
        }

        public DataSet searchrecordBAL(string searchvar)
        {
            SearchRecordDAL searchrecordDAL = new SearchRecordDAL();
            return searchrecordDAL.searchrecordDAL(searchvar);
        
        }

    }
}
