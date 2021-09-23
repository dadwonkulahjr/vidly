using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<SelectListItem> DropdownListForMembershipTypes { get; set; }
        public IEnumerable<SelectListItem> DropdownListForGenders { get; set; }
        public Customer Customer { get; set; }
    }
}
