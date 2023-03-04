using System.ComponentModel.DataAnnotations;

namespace BlogWeb.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(8)]
        public string TenTaiKhoan { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(8)]
        public string MatKhau { get; set; }
        public string? AnhDaiDien { get; set; }
        [MaxLength(50)]
        public string? HoTen { get; set; }
        public bool GioiTinh { get; set; } = true;
        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }
        [MaxLength(12)]
        [MinLength(10)]
        public string? SDT { get; set; }
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        public string? Email { get; set; }
        public bool Khoa { get; set; } = false;
        public string? LyDoKhoa { get; set; }
        public bool Admin { get; set; } = false;

        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
