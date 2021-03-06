﻿using System;

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
        public int presentArea { get; set; }
        public int presentPincode { get; set; }
        public string permantAddress { get; set; }
        public int permantCountryId { get; set; }
        public int permantStateId { get; set; }
        public int permantCityId { get; set; }
        public int permantArea { get; set; }
        public int permantPincode { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string maritialStatus { get; set; }
        public int passportNumber { get; set; }
        public string passportValidity { get; set; }
        public string photo { get; set; }
    }
}