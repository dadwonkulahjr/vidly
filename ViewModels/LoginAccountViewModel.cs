﻿using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class LoginAccountViewModel
    {
        [EmailAddress, Required]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remember Me?")]
        public bool RememberMe { get; set; }

    }
}
