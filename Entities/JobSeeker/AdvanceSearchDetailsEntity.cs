using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.JobSeeker
{
    public class AdvanceSearchDetailsEntity
    {

        public string KeySkill { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string WorkExp { get; set; }
        public string MinSalary { get; set; }
        public string MaxSalary { get; set; }
        public int Industry { get; set; }
        public string EmpStatus { get; set; }
        public string JobType { get; set; }
        public string RecruitmentType { get; set; }
    }
}
