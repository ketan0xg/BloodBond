﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BloodDonationApp.Models
{
	public class SeekerMV
	{
        public int SeekerID { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public int CityID { get; set; }
        public string City { get; set; }
        public string ContactNo { get; set; }
        public string CNIC { get; set; }
        public int GenderID { get; set; }
        public string Gender { get; set; }
        public System.DateTime RegestrationDate { get; set; }
        public string Address { get; set; }
        public int BloodGroupID { get; set; }
        public string BloodGroup { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}