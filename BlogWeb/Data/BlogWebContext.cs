using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogWeb.Models;

namespace BlogWeb.Data
{
    public class BlogWebContext : DbContext
    {
        public BlogWebContext (DbContextOptions<BlogWebContext> options)
            : base(options)
        {
        }

        public DbSet<BlogWeb.Models.Account> Account { get; set; } = default!;

        public DbSet<BlogWeb.Models.Blog> Blog { get; set; }

        public DbSet<BlogWeb.Models.Category> Category { get; set; }

        public DbSet<BlogWeb.Models.Comment> Comment { get; set; }
    }
}
