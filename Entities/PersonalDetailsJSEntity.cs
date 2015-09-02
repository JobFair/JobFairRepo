using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public class PersonalDetailsJSEntity
    {
        public string userID { get; set; }
        public string PressentAddress { get; set; }
        public string PressentCountry { get; set; }
        public string PressentState { get; set; }
        public string PressentCity { get; set; }
        public string PresentArea { get; set; }
        public int PresentPincode { get; set; }
        public string PermantAddress { get; set; }
        public string PermantCountry { get; set; }
        public string PermantState { get; set; }
        public string PermantCity { get; set; }
        public string PermantArea { get; set; }
        public int PermantPincode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string MaritialStatus { get; set; }
        public int PassportNumber { get; set; }
        public DateTime PassportValidity { get; set; }
        public int Languages { get; set; }
        public string WorkStatus { get; set; }
        public string Photo { get; set; }
     
    }
}
