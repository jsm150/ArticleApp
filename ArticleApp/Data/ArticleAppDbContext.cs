using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ArticleApp.Data
{
    public class ArticleAppDbContext : DbContext
    {
        public ArticleAppDbContext(DbContextOptions<ArticleAppDbContext> options)
            : base(options) { }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property(t => t.Created)
                .HasDefaultValue(DateTime.Now);
        }
    }
}
