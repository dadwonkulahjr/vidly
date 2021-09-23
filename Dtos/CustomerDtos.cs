using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;
using Vidly.Utilities;

namespace Vidly.Dtos
{
    public class CustomerDtos
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        [DataType(DataType.Date)]
        [IfCustomerPass18Allowed, Required]
        public DateTime? BirthDate { get; set; }
        //Navigation Properties
        public MembershipTypeDto MembershipType { get; set; }
        public GenderDto Gender { get; set; }
        //Foreign Keys
        public int GenderId { get; set; }
        public byte MembershipTypeId { get; set; }

    }
}
