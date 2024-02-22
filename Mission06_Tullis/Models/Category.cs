using System.ComponentModel.DataAnnotations;

namespace Mission06_Tullis.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
    }
}
