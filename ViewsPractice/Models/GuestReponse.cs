using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ViewsPractice.Models
{
    public class GuestReponse
    {
        // Each variable requires an input from the user and will display an error message if they do not fill a portion of the form out

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify if you will attend")]
        public bool? WillAttend { get; set; }

    }
}