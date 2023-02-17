using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UPDCFacilityManager.Modules.Auth.Core.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [Display(Name = "Remember me")]
        public Boolean RememberMe { get; set; }
    }
}
