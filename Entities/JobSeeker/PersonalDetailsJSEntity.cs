using System;

namespace Entities
{
    public class PersonalDetailsJSEntity
    {
        //PersonalDetailsJSEntity
        public string candidateId { get; set; }
        public string presentAddress { get; set; }
        public string presentCountry { get; set; }
        public string presentState { get; set; }
        public string presentCity { get; set; }
        public string presentArea { get; set; }
        public int presentPincode { get; set; }
        public string permantAddress { get; set; }
        public string permantCountry { get; set; }
        public string permantState { get; set; }
        public string permantCity { get; set; }
        public string permantArea { get; set; }
        public int permantPincode { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public string maritialStatus { get; set; }
        public int passportNumber { get; set; }
        public DateTime passportValidity { get; set; }
        public string workStatus { get; set; }
        public string photo { get; set; }
    }
}