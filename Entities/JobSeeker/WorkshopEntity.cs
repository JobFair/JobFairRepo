using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.JobSeeker
{
    public class WorkshopEntity
    {
        //Workshop JobSeekerEntity
        public string CandidateId { get; set; }

        public string WorkshopName { get; set; }
        public string Institute { get; set; }
        public string Duration { get; set; }
        public string YearOfCompletion { get; set; }
        public string Grade { get; set; }
    }
}
