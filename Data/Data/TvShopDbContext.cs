using Microsoft.EntityFrameworkCore;
using Data.Models;
using Data.Data;

namespace Data
{
    public class TvShopDbContext : DbContext
    {
        public TvShopDbContext() { }
        public TvShopDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TVModel>().HasData(MockData.GetTVs());

            modelBuilder.Entity<Color>().HasData(MockData.GetColors());
        }

        public DbSet<TVModel> TVs { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
