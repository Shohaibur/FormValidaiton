using System;
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
        [RegularExpression(@"^[a-z-A-Z.\s]{5,50}$", ErrorMessage = "Please provide valid name with length 5~50")]

        public string Name { get; set; }

        [Required(ErrorMessage = "User Id cannot be empty")]
        [RegularExpression(@"^(?!.*[-_]{2,})[a-z-_A-Z0-9]{4,12}$", ErrorMessage = "Please provide an unique user id with length 4~12")]
        public string UId { get; set; }

    }
}
