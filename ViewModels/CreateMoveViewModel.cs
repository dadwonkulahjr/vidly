using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CreateMovieViewModel
    {
        public int? Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        [Display(Name="Genre"), Required]
        public byte? GenreId { get; set; }
        [Required, Display(Name="Release Date")]
        public DateTime? ReleaseDate { get; set; }
        [Display(Name="Number in Stock"), Range(1, 12), Required]
        public byte? NumberInStock { get; set; }
        public IEnumerable<SelectListItem> DropdownListForGenre { get; set; }

        public CreateMovieViewModel()
        {
            Id = 0;
        }
        public CreateMovieViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.Genre.ReleaseDate;
            NumberInStock = (byte)movie.Genre.NumberInStock;
            GenreId = (byte)movie.GenreId;
        }
    }
}
