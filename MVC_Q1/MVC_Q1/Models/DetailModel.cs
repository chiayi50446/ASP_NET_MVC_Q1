using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Q1.Models
{
    public class DetailModel
    {
        public string Name { get; set; }
        [StringLength(35)]
        [RegularExpression(@"^\d{10}$"
            , ErrorMessage = "Invalid Phone Number"
        )]
        public string Phone { get; set; }
        [Required()]
        [EmailAddress]
        public string Email { get; set; }
    }
}