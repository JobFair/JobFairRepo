using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.HR
{
   public class RecruiterRegisterEntity
    {
        public string Recruiterid { get; set; }
        public string FullName { get; set; }
        public string Company { get; set; }
        public string MobileNo { get; set; }
        public string FreelanceOrEmployee { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
       
        public string AmountPerMonth { get; set; }
        public string PercentPerClosure { get; set; }
        public string OfficialEmailId { get; set; }
        public string EmployeeSalary { get; set; }
        public int PresentCountry { get; set; }
        public int PresentState { get; set; }
        public int PresentCity { get; set; }
        public int PresentArea { get; set; }
        public string Pincode { get; set; }
        public string EmploymentStatus { get; set;}
        public string JobType { get; set; }
        public string ClientSite { get; set; }
        public string ClientName { get; set; }
        public string PANCardNo { get; set; }
        public string PhotoPath { get; set; }



        public string Address { get; set; }

        public bool IsMailSent { get; set; }
    }
}
