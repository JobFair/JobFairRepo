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
        public List<string> Area { get; set; }
        public List<string> Industry { get; set; }
        public string JobCategory { get; set; }
        public string WorkExp { get; set; }
        public string MinSalary { get; set; }
        public string MaxSalary { get; set; }
        public List<string> EmpStatus { get; set; }
        public List<string> JobType { get; set; }
        public List<string> RecruitmentType { get; set; }
        public string Freshness { get; set; }
    }
}
