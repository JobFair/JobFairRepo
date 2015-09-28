using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Recruiter
{
    public class ClientRequirementsEntitiy
    {
        //ClientRequirements Recruiter
        public string RecruiterID { get; set; }
        public int ClientId { get; set; }
        public string Position { get; set; }
        public string JobDescription { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfRequirementSent { get; set; }
        public DateTime DueDate { get; set; }
        public int NumberOfVacancies { get; set; }
        public bool PositionClosed { get; set; }
    }
}
