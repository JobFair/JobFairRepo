using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.HR
{
    public class ClientContactPersonDetailsEntity
    {
        public Int64 ClientId { get; set; }
        public int HrId { get; set; }
        public string ContactPersonName { get; set; }
        public string Designation { get; set; }
        public string EmailId { get; set; }
        public int ContactNo { get; set; }
        public string IsActive { get; set; }
    }
}
