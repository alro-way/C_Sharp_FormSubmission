using System;
using System.ComponentModel.DataAnnotations;

namespace C_Sharp_FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4,ErrorMessage = "First Name must contain at least 4 characters")]
        [Display(Name = "Field 'First Name'")] 
        public string FirstName { get; set; }
 
        [Required]
        [MinLength(4,ErrorMessage = "Last Name must contain at least 4 characters")]
        [Display(Name = "Field 'Last Name'")] 
        public string LastName { get; set; }

        [Required]
        [Range(1,120,ErrorMessage = "Enter a valid Age")]
        [Display(Name = "Field 'Age'")] 
        public int Age { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid Email")]
        [Display(Name = "Field 'Email'")] 
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password must contain at least 8 characters")]
        [DataType(DataType.Password, ErrorMessage = "Enter a valid Password")]
        [Display(Name = "Field 'Password'")] 

        public string Password { get; set; }


 
     
    }
}