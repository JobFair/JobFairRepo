using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.HR
{
    class ClientRequirementsHREntity
    {
        public string HrId { get; set; }
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientProfile { get; set; }
        public string Position { get; set; }
        public int Industry { get; set; }
        public int FunctionalArea { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public int Pincode { get; set; }
        public int Skillsets { get; set; }
        public int DateOfRequirementSent { get; set; }
        public int DueDate { get; set; }
        public int Status { get; set; }
        public int RecruiterID { get; set; }
    }
}
