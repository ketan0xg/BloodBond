﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BloodDonationApp.Models
{
    public class BloodGroupsMV
    {
        public string BloodGroup { get; set; }
        [Required(ErrorMessage = "Required*")]
        [Display(Name = "Blood Group")]
        public int BloodGroupID { get; set; }
    }
}