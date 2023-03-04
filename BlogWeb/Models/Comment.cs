using System.ComponentModel.DataAnnotations;

namespace BlogWeb.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NoiDung { get; set; }

        public Account? Account { get; set;}
        public Blog? Blog { get; set;}
    }
}
