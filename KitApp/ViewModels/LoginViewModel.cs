using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitApp.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(6 ,ErrorMessage = "Please enter at least 6 characters")]
        [MaxLength(12)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
