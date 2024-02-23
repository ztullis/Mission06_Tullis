using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Tullis.Models
{
    public class Application
    {
        //[Key]
        //[Required]
        //public int ApplicationID { get; set; }

        //[Required]
        //public string Category { get; set; }
        [Key]
        [Required]
        public int MovieId { get;set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get;set; }
        public Category? CategoryName { get;set; }

        [Required(ErrorMessage = "Please enter a movie title")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Please enter the movie's year")]
        public int Year { get; set; }

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