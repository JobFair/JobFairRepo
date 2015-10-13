using System;

namespace Entities
{
    public class PersonalDetailsJSEntity
    {
        //PersonalDetailsJSEntity
        public string candidateId { get; set; }

        public string presentAddress { get; set; }
        public int presentCountryId { get; set; }
        public int presentStateId { get; set; }
        public int presentCityId { get; set; }
        public string presentArea { get; set; }
        public int presentPincode { get; set; }
        public string permantAddress { get; set; }
        public int permantCountryId { get; set; }
        public int permantStateId { get; set; }
        public int permantCityId { get; set; }
        public string permantArea { get; set; }
        public int permantPincode { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public string maritialStatus { get; set; }
        public int passportNumber { get; set; }
        public DateTime passportValidity { get; set; }
        public string photo { get; set; }
    }
}