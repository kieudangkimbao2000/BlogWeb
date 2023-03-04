using BlogWeb.Data;
using BlogWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BlogWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogWebContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(BlogWebContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Blog> Blogs = await _context.Blog.ToListAsync();
            foreach (Blog blog in Blogs)
            {
                int i = 300;
                if (blog.NoiDung.Length > i)
                {
                    while (blog.NoiDung[i] != ' ')
                    {
                        i++;
                    }
                    blog.NoiDung = blog.NoiDung.Substring(0, i) + " ...";
                }
            }
            return View(Blogs);
        }

        public IActionResult Hot()
        {
            return View();
        }

        public IActionResult Category(int id) 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}