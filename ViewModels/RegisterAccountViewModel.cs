using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class RegisterAccountViewModel
    {
        [EmailAddress, Required]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Confirmed Password"), Required, DataType(DataType.Password),
            Compare(nameof(Password), ErrorMessage ="Password and confirmation password do not match.")]
        public string ConfirmedPassword { get; set; }
    }
}
