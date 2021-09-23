using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }

        //Navigation Properties
        public Genre Genre { get; set; }

        //Foreign Keys
        [Display(Name="Genre")]
        public int GenreId { get; set; }
       
    }
}
