﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BAL
{
    public class ViewAllJobPostBAL
    {
        public DataSet ViewCandidateProfileForEmail(string candidateId)
        {
            ViewAllJobPostDAL viewAllJobPostDAL = new ViewAllJobPostDAL();
            return viewAllJobPostDAL.ViewCandidateProfileForEmail(candidateId);
        }

        public DataSet GetData(Int32 id)
        {
            ViewAllJobPostDAL viewAllJobPostDAL = new ViewAllJobPostDAL();
            return viewAllJobPostDAL.GetData(id);
        }

        public int CheckMailSend(Int32 id, string candidateId)
        {
            ViewAllJobPostDAL viewAllJobPostDAL = new ViewAllJobPostDAL();
            return viewAllJobPostDAL.CheckMailSend(id, candidateId);
        }
    }
}
