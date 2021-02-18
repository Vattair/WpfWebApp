using Microsoft.EntityFrameworkCore;
using WpfWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfWebApp.Data
{
    class WebAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<PostCategory> PostCategory { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "db.db");
            optionsBuilder.UseSqlite($"Filename={path}");
        }
    }
}
