using System.ComponentModel.DataAnnotations;

namespace BlogWeb.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NoiDung { get; set; }

        public ICollection<Account> Accounts { get; set;}
        public ICollection<Blog> Blogs { get; set;}
    }
}
