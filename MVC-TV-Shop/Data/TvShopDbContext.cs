using Microsoft.EntityFrameworkCore;
using MVC_TV_Shop.Models;

namespace MVC_TV_Shop.Data
{
    public class TvShopDbContext : DbContext
    {
        public TvShopDbContext() { }
        public TvShopDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TVModel>().HasData(MockData.GetTVs());
        }

        public DbSet<TVModel> TVs { get; set; }
    }
}
