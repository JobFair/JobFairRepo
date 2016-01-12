using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.HR
{
    public class ClientRequirementsHREntity
    {
        public int HrId { get; set; }
        public int ClientId { get; set; }
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
        public string Skillsets { get; set; }
        public string Contents { get; set; }
        public DateTime DateOfRequirementSent { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public int RecruiterID { get; set; }
    }
}
