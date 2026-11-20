using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace song.Models
{
    public class Movie
    {
        [Key]

        public int Id { get; set; }

        public string? Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Duration { get; set; }
        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public Genre? Genre { get; set; }

    }
}
