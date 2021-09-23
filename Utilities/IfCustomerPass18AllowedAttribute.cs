using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Utilities
{
    public class IfCustomerPass18AllowedAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (CustomerDtos)validationContext.ObjectInstance;

            if (MembershipType.Unknown == 0 || MembershipType.PayAsYouGo == 1)
                return ValidationResult.Success;

            if (customer.BirthDate == null)
                return new ValidationResult("The Birthdate field is required.");


            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer should be at least 18 years old to go on a membership.");
        }
    }
}
