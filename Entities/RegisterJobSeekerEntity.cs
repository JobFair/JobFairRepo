using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RegisterJobSeekerEntity
    {//RegisterJobSeekerEntity
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string DesiredUserName { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentAddress { get; set; }

        public string UploadResumepath { get; set; }
    }
}
