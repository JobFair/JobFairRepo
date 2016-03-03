using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.HR
{
    public class EmployerDetailsHREntity
    {
        public int EmployerId { get; set; }
        public int HrId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyProfile { get; set; }
        public string EmployerHRFullName { get; set; }
        public string CompanyContactNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public int Pincode { get; set; }
        public string OfficialEmailId { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string Photo { get; set; }
    }
}
