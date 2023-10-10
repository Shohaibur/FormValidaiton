using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidaiton.Models
{
    public class Signup
    {
        [Required(ErrorMessage = "Please provide valid name")]
     //   [StringLength(50,MinimumLength =5 ,ErrorMessage="Name must be between 5 and 50 characters.")]
        [RegularExpression(@"^[a-z-A-Z.\s]{5,50}$", ErrorMessage = "Please input valid name with length 5~50")]

        public string Name { get; set; }
        


    }
}
