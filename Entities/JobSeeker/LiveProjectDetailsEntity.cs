using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.JobSeeker
{
   public class LiveProjectDetailsEntity
    {
        public string CandidateId { get; set; }
       public string CompanyName { get; set; }
       public string ProjectTitle { get; set; }
       public int roleId { get; set; }
       public string ClientName { get; set; }
       public string ProjectLink { get; set; }
       public string Duration { get; set; }
       public string ProjectLocation { get; set; }
       public string EmplymentType { get; set; }
       public string ProjectDetails { get; set; }
       public string RolesResponsibility { get; set; }
       public string TeamSize { get; set; }
       public string SkillUsed { get; set; }
    }
}
