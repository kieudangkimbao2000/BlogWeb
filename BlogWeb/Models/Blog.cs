using System.ComponentModel.DataAnnotations;

namespace BlogWeb.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string TieuDe { get; set; }
        [Required]
        public string AnhTieuDe { get; set; }
        public string? NoiDung { get; set; }
        public int SoView { get; set; } = 0;
        public bool XuatBan { get; set; } = false;
        [DataType(DataType.Date)]
        public DateTime? NgayXuatBan { get; set; }
        public bool Khoa { get; set;} = false;
        public string? LyDoKhoa { get; set; }

        public Account Account { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Category> Categories { get; set; }

    }
}
