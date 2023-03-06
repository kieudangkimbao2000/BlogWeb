using BlogWeb.Data;
using Microsoft.EntityFrameworkCore;

namespace BlogWeb.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlogWebContext(serviceProvider.GetRequiredService<DbContextOptions<BlogWebContext>>()))
            {
                //Blog
                if (context.Blog.Any())
                {
                    return;
                }

                Account account = new Account { TenTaiKhoan = "kimbao123", MatKhau = "kimbao123456" };

                context.Blog.AddRange(
                    new Blog { TieuDe = "[e34 xuyên Việt] Ngày 122: Mênh mông “rừng sạc” ở Phú Quốc", AnhTieuDe = ".\\Uploads\\1.png", NoiDung = "Ra đến đảo ngọc Phú Quốc, Bụi hết cả hồn khi nhìn thấy trạm sạc của VinFast ở đây. Trên suốt hành trình đi xuyên Việt, chưa từng có nơi nào nhiều trụ sạc như ở Phú Quốc.\r\n\r\nNhiều đến mức không cần đếm mọi người à. Phải đến 500 trụ sạc có lẻ ấy. Mênh mông luôn, chấp hết cả nước đưa xe điện ra đây thì vẫn đủ chỗ sạc cho mọi người.\r\n\r\nCó đủ loại trụ sạc từ 11kw đến tận 250kw. Loại 11kw Bụi thấy phù hợp cho việc đỗ xe lâu. Cứ thoải mái vui chơi tắm biển, đi ra đầy bình điện là vừa. Chứ nếu cắm trụ to, chỉ sau 1-2 tiếng đầy là bạn phải chạy ra rút súng sạc rất là mất công.", XuatBan=true, NgayXuatBan = DateTime.Now, Account = account },
                    new Blog { TieuDe = "[e34 xuyên Việt] Ngày 121: Kết thúc chặng ven đường biển Việt Nam", AnhTieuDe = ".\\Uploads\\2.png", NoiDung = "Ra đến đảo ngọc Phú Quốc, Bụi hết cả hồn khi nhìn thấy trạm sạc của VinFast ở đây. Trên suốt hành trình đi xuyên Việt, chưa từng có nơi nào nhiều trụ sạc như ở Phú Quốc.\r\n\r\nNhiều đến mức không cần đếm mọi người à. Phải đến 500 trụ sạc có lẻ ấy. Mênh mông luôn, chấp hết cả nước đưa xe điện ra đây thì vẫn đủ chỗ sạc cho mọi người.\r\n\r\nCó đủ loại trụ sạc từ 11kw đến tận 250kw. Loại 11kw Bụi thấy phù hợp cho việc đỗ xe lâu. Cứ thoải mái vui chơi tắm biển, đi ra đầy bình điện là vừa. Chứ nếu cắm trụ to, chỉ sau 1-2 tiếng đầy là bạn phải chạy ra rút súng sạc rất là mất công.", XuatBan = true, NgayXuatBan = DateTime.Now, Account = account },
                    new Blog { TieuDe = "[e34 xuyên Việt] Ngày 114: Khám phá 9 cửa sông Mekong (Cửu Long)", AnhTieuDe = ".\\Uploads\\3.png", NoiDung = "Hôm nay là ngày thứ 114 Bụi đi xuyên Việt, vỡ kế hoạch mọi người ạ. Dự kiến 4 tháng xong mà giờ mới được có 28 thành phố (sáng nay là Trà Vinh), còn 58 thành phố nữa cần đến.\r\n\r\nBa ngày qua (16 đến 18/10) là Bụi đi 9 cửa sông Mekong. Choáng ngợp cảnh sông nước giao với biển. Thực sự phấn khích và biết ơn tinh thần tiến ra biển lớn, khai hoang mở đất của ông cha ta ngày xưa.", XuatBan = true, NgayXuatBan = DateTime.Now, Account = account },
                    new Blog { TieuDe = "[e34 xuyên Việt] Ngày 99: Đi phà biển từ Vũng Tàu qua Cần Giờ", AnhTieuDe = ".\\Uploads\\4.png", NoiDung = "Hôm nay Bụi khởi hành từ thành phố Vũng Tàu đi tiếp về phương Nam. Do hành trình ven biển nên Bụi không chọn cách đi theo quốc lộ, cao tốc để tới TP HCM mà sẽ đi bằng phà vượt biển.\r\n\r\nĐây là tuyến phà nối Vũng Tàu với huyện Cần Giờ. Phả chở được ô tô, với mức giá 350k một vé kèm tài xế. Phà chạy theo giờ chẵn, cứ cách một tiếng là phà chạy.", XuatBan = true, NgayXuatBan = DateTime.Now, Account = account },
                    new Blog { TieuDe = "[e34 xuyên Việt] Ngày 81: Gặp gia đình dân tộc Châu Ro", AnhTieuDe = ".\\Uploads\\5.png", NoiDung = "Trong hành trình xuyên Việt này, Bụi có kế hoạch tìm gặp đủ 53 dân tộc anh em (Bụi là dân tộc Kinh, đủ 54). Hôm nay từ TP Bà Rịa đi lên xã Bàu Chinh, huyện Châu Đức để tìm gặp người đồng bào Châu Ro.\r\n\r\nTrên đường, đoạn qua thị trấn Ngãi Giao thì có trạm sạc VinFast nhé. Ở đây là trạm xăng, có sẵn 3 trụ nhưng mới có một trụ kích hoạt điện thôi.\r\n\r\nThực sự thấy rất thuận tiện, đi xe điện không phải lo lắng gì nhiều. Khắp cả nước, vùng sâu xa đều có trạm của VinFast rồi.\r\n\r\nLúc tới ấp Tân Châu, xã Bàu Chinh thì nhà rông sinh hoạt cộng đồng đã đóng cửa. Khung cảnh hoang vắng, nói chung không có thông tin gì ở đây.\r\n\r\nBụi tiếp tục đi sâu vào trong làng. Thấy khung cảnh cũng như người Kinh mình thôi, không có gì khác biệt. Trong lòng cũng hơi lăn tăn là không biết chuyến này có gặp được ai không.\r\n\r\nThấy có một chú đang đi bộ trên đường, Bụi túm lại hỏi có thể tìm ai để hỏi về dân tộc Châu Ro. Chú nhiệt tình chỉ luôn: “Kia kìa, cái nhà của bà kia. Bà ấy hay ra Hà Nội lắm, biết hết đấy”.\r\n\r\nBụi đỗ xe ven đường, đi bộ đến cổng xin phép vào trong. Một phụ nữ tầm hơn 60 tuổi ra tiếp chuyện. Biết Bụi có nhã ý tìm hiểu nét đẹp văn hoá dân tộc Châu Ro nên bà hồ hởi kể chuyện.", XuatBan = true, NgayXuatBan = DateTime.Now, Account = account }
                );
                context.SaveChanges();
            }
        }
    }
}
