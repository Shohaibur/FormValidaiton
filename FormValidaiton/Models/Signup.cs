using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidaiton.Models
{
    public class Signup
    {
        [Required(ErrorMessage = "Please provide your name")]

        [RegularExpression(@"^[a-zA-Z\s\- _)]", ErrorMessage = "Validation invalid")]
        public string Name { get; set; }
        


    }
}
