using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JSAndValidation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "First name is required")]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Enter only alphabets.")]
        [Display(Name ="First Name")]
        public string f_name { get; set; }

        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Invalid Email.!")]
        public string email { get; set; }

        [Required]
        [RegularExpression(@"\+91\-[9876]\d{9}", ErrorMessage = "Invalid Mobile.!")]
        public string mobile { get; set; }

        [Required]
        public int salary { get; set; }

        [Required]
        public string gender { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[a-zA-Z!#$%&? ])[a-zA-Z0-9!#$%&?]{8,20}$", ErrorMessage = "Password is weak.!")]
        public string password { get; set; }

        [Compare("password",ErrorMessage ="Passwords do not match")]
        public string cnfpassword { get; set; }

    }
}
