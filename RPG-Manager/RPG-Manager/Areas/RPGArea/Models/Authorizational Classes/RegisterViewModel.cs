using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea.Models.Authorizational_Classes
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string LoginString { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} but less than {1} characters long")]
        [Display(Name = "Account Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords are not the same. Fix this.")]
        public string ConfirmPassword { get; set; }
    }
}
