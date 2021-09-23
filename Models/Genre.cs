using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [DataType(DataType.Date), Required, Display(Name="Release Date")]
        public DateTime? ReleaseDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateAdded { get; set; }
        [Required, Display(Name="Number In Stock"), Range(1, 12)]
        public short NumberInStock { get; set; }
    }
}
