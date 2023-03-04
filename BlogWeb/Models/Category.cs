using System.ComponentModel.DataAnnotations;

namespace BlogWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Ten { get; set; }

        public ICollection<Blog> Blogs { get; set;}
    }
}
