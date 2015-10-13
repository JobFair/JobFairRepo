using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Recruiter
{
    /// <summary>
    /// jobpostentity
    /// </summary>
    public class AddJobPostEntity
    {
       
        public string RecruiterID { get; set; }
        public string JobTitle { get; set; }
        public string JobLocationCity { get; set; }
        public string JobLocationArea { get; set; }
        public string CompanyLevel { get; set; }
        public int IndustryId { get; set; }
        public int DepartmentId { get; set; }
        public int FunctionalAreaId { get; set; }
        public string JobDescription { get; set; }
        public string KeywordsRoles { get; set; }
        public string KeywordsTechnical { get; set; }
        public string Workexperience { get; set; }
        public string  Gender { get; set; }
        public string OfferedAnnualSalaryMin { get; set; }
        public string OfferedAnnualSalaryMax { get; set; }
        public string OtherSalaryDetails { get; set; }
        public int NumberOfVacancies { get; set; }
        public  DateTime PostedDate { get; set; }
    }
}
