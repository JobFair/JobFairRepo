using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.JobSeeker
{
   public class AddProjectDetailsEntity
    {
        public string CandidateId { get; set; }
        public string CompanyName { get; set; }
        public string ProjectTitle { get; set; }
        public string Duration { get; set; }
        public string ProjectLocation { get; set; }
        public string EmployeeType { get; set; }
        public string ProjectDescription { get; set; }
        public string YourRole { get; set; }
        public string TeamSize { get; set; }
        public string SkillUsed { get; set; }
        public string ClientName { get; set; }
    }
}
