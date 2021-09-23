using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Data
{
    //Add some properties later
    //to the application user class
    public class ApplicationUser : IdentityUser
    {
        [Required, DataType(DataType.PhoneNumber), StringLength(50)]
        public string DriverLicense{ get; set; }
        [Required, DataType(DataType.PhoneNumber), StringLength(50)]
        public string Phone { get; set; }
    }
}
