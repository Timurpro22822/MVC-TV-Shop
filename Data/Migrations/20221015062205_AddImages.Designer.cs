// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(TvShopDbContext))]
    [Migration("20221015062205_AddImages")]
    partial class AddImages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Models.TVModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Diagonal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Resolution")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TVs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Diagonal = "55″",
                            ImagePath = "https://samsungshop.com.ua/res/cache/images/7d/15/7d153c06cf8aeafa0307b002847130ad/ad6844aa1e4caa49c317ac5114ec9346.jpg",
                            Model = "Samsung QE55QN90BAUXUA Neo",
                            Price = 73999m,
                            Resolution = "3840x2160 UHD 4K",
                            Year = 2022
                        },
                        new
                        {
                            Id = 2,
                            Diagonal = "65″",
                            ImagePath = "https://samsungshop.com.ua/res/cache/images/1d/90/1d90f289e972b72228c32289202be042/e8d9a3ca400b66bf8c8c692f14da64a2.jpg",
                            Model = "Samsung QE65Q70BAUXUA",
                            Price = 62999m,
                            Resolution = "3840x2160 UHD 4K",
                            Year = 2022
                        },
                        new
                        {
                            Id = 3,
                            Diagonal = "65″",
                            ImagePath = "https://samsungshop.com.ua/res/cache/images/40/19/401937ab040b932e4f2c1e9337ddd3c0/15a98e0cd6a396d4bca1ca2dc6617e43.jpg",
                            Model = "Samsung QE65Q60BAUXUA",
                            Price = 52199m,
                            Resolution = "3840x2160 UHD 4K",
                            Year = 2022
                        },
                        new
                        {
                            Id = 4,
                            Diagonal = "55″",
                            ImagePath = "https://samsungshop.com.ua/res/cache/images/1c/4f/1c4f73fd470d63249f4a0763dff03d89/4262c548db10324900e61c6853ce44f8.jpg",
                            Model = "Samsung UE55BU8500UXUA",
                            Price = 28399m,
                            Resolution = "3840x2160 UHD 4K",
                            Year = 2022
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
