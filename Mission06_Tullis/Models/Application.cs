using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Collections.Specialized.BitVector32;

namespace Mission06_Tullis.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieId { get;set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get;set; }

        public Category? Category { get;set; }

        [Required(ErrorMessage = "Please enter a movie title")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Please enter a valid year after 1888.")]
        [Range(1888, int.MaxValue, ErrorMessage = "The year must be 1888 or after")] 
        public int? Year { get; set; } = 1888;

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Please enter if the movie has been edited")]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage ="Please enter in if this has been copied to plex.")]
        public bool CopiedToPlex { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}