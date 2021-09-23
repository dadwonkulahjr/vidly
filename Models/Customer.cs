using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Utilities;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        [DataType(DataType.Date)]
        [Required, Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }
        //Navigation Properties
        public Gender Gender { get; set; }
        public MembershipType MembershipType { get; set; }

        //Foreign Keys
        [Display(Name="Gender")]
        public int GenderId { get; set; }
        [Display(Name="Membership Type")]
        public byte MembershipTypeId { get; set; }





    }
}
