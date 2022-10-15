using Data.Models;

namespace Data.Data
{
    public static class MockData
    {
        public static List<TVModel> GetTVs()
        {
            return new List<TVModel>()
            {
                new TVModel()
                {
                    Id = 1,
                    Model = "Samsung QE55QN90BAUXUA Neo",
                    Diagonal = "55″",
                    Resolution = "3840x2160 UHD 4K",
                    Year = 2022,
                    Price = 73999,
                    ColorId = 1,
                    ImagePath = @"https://samsungshop.com.ua/res/cache/images/7d/15/7d153c06cf8aeafa0307b002847130ad/ad6844aa1e4caa49c317ac5114ec9346.jpg"
                },
                new TVModel()
                {
                    Id = 2,
                    Model = "Samsung QE65Q70BAUXUA",
                    Diagonal = "65″",
                    Resolution = "3840x2160 UHD 4K",
                    Year = 2022,
                    Price = 62999,
                    ColorId = 1,
                    ImagePath = @"https://samsungshop.com.ua/res/cache/images/1d/90/1d90f289e972b72228c32289202be042/e8d9a3ca400b66bf8c8c692f14da64a2.jpg"
                },
                new TVModel()
                {
                    Id = 3,
                    Model = "Samsung QE65Q60BAUXUA",
                    Diagonal = "65″",
                    Resolution = "3840x2160 UHD 4K",
                    Year = 2022,
                    Price = 52199,
                    ColorId = 3,
                    ImagePath = @"https://samsungshop.com.ua/res/cache/images/40/19/401937ab040b932e4f2c1e9337ddd3c0/15a98e0cd6a396d4bca1ca2dc6617e43.jpg"
                },
                new TVModel()
                {
                    Id = 4,
                    Model = "Samsung UE55BU8500UXUA",
                    Diagonal = "55″",
                    Resolution = "3840x2160 UHD 4K",
                    Year = 2022,
                    Price = 28399,
                    ColorId = 2,
                    ImagePath = @"https://samsungshop.com.ua/res/cache/images/1c/4f/1c4f73fd470d63249f4a0763dff03d89/4262c548db10324900e61c6853ce44f8.jpg"
                }
            };
        }
        public static TVModel GetTVById(int id)
        {
            return GetTVs().FirstOrDefault(x => x.Id == id);
        }

        public static List<Color> GetColors()
        {
            return new List<Color>()
            {
                new Color()
                {
                    Id = 1,
                    Name = "White"
                },
                new Color()
                {
                    Id = 2,
                    Name = "Black"
                },
                new Color()
                {
                    Id = 3,
                    Name = "Gray"
                },
            };
        }
    }
}
