using System.ComponentModel.DataAnnotations;

namespace Mission06_Tullis.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }

        //[Required]
        //public string Category { get; set; }
        [Required]
        public int MovieId { get;set; }
        public int? CategoryId { get;set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required]
        public int Edited { get; set; }

        public string? Lent_To { get; set; }

        [Required]
        public int Copied_To_Plex { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
    }
}