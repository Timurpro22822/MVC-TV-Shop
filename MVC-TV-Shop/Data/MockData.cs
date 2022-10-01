using MVC_TV_Shop.Models;

namespace MVC_TV_Shop.Data
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
                    Price = 73999
                },
                new TVModel()
                {
                    Id = 2,
                    Model = "Samsung QE65Q70BAUXUA",
                    Diagonal = "65″",
                    Resolution = "3840x2160 UHD 4K",
                    Year = 2022,
                    Price = 62999
                },
                new TVModel()
                {
                    Id = 3,
                    Model = "Samsung QE65Q60BAUXUA",
                    Diagonal = "65″",
                    Resolution = "3840x2160 UHD 4K",
                    Year = 2022,
                    Price = 52199
                },
                new TVModel()
                {
                    Id = 4,
                    Model = "Samsung UE55BU8500UXUA",
                    Diagonal = "55″",
                    Resolution = "3840x2160 UHD 4K",
                    Year = 2022,
                    Price = 28399
                }
            };
        }
        public static TVModel GetTVById(int id)
        {
            return GetTVs().FirstOrDefault(x => x.Id == id);
        }
    }
}
