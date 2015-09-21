using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Recruiter
{
    public class AddJobPostEntity
    {
        public string JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobLocationCity { get; set; }
        public string JobLocationArea { get; set; }
        public string CompanyLevel { get; set; }
        public Int32 Industry { get; set; }
        public Int32 Department { get; set; }
        public Int32 FunctionalArea { get; set; }
        public string JobDescription { get; set; }
        public string KeywordsRoles { get; set; }
        public string KeywordsTechnical { get; set; }
        public string WorkExprience { get; set; }
        public string Gender { get; set; }
        public string OfferedAnnualSalary { get; set; }
        public string OtherSalaryDetails { get; set; }
        public string NumberOfVacancies { get; set; }
    }
}
