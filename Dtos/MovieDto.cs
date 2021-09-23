using System.ComponentModel.DataAnnotations;


namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        //Navigation Properties

        //Foreign
        [Required]
        public int GenreId { get; set; }
    }
}
