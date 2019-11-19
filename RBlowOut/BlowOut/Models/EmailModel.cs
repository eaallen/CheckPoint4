﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class EmailModel
    {
        
        [Required, Display(Name = "Your name")]
        public string toname { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string toemail { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        public string message { get; set; }
        
    }
}
