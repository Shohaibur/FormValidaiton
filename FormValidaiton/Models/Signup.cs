﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidaiton.Models
{
    public class Signup
    {
        [Required(ErrorMessage = "Name field cannot be empty")]
     //   [StringLength(50,MinimumLength =5 ,ErrorMessage="Name must be between 5 and 50 characters.")]
        [RegularExpression(@"^(?!.*[.-]{2,})(?!.*\s{2,})[a-z-A-Z.\s]{5,50}$", ErrorMessage = "Provide a valid name (length 5~50)")]

        public string Name { get; set; }

        [Required(ErrorMessage = "User Id cannot be empty")]
        [RegularExpression(@"^[a-z-_A-Z0-9]{4,12}$", ErrorMessage = "Provide a valid unique user id (length 4~12)")]
        public string UId { get; set; }

        [Required(ErrorMessage ="Password cannot be empty")]
        //Syntax: [RegularExpression(@"^$",ErrorMessage"")]
        [RegularExpression(@"^(?=.*[A-Z]{1,})(?=.*[a-z]{2,})[A-Za-z]{4}(?=.*[\d!@#$%^&*]{4,})[A-Za-z0-9!@#$%^&*]{4,}$", ErrorMessage ="Provide an unique password (length minimum 8)")]

        public string password { get; set; }
    }
}
