using Web_API_Versioning.Models.Domain;

namespace Web_API_Versioning
{
    public static class CountryData
    {
        public static List<Country> Get()
        {
            var countryList = new[]
            {
                new {Id = 4 , Name = "Germany"},
                new {Id = 5 , Name = "France"},
                new {Id = 6 , Name = "Australia"},
                new {Id = 7 , Name = "Brazil"},
                new {Id = 8 , Name = "Japan"},
                new {Id = 9 , Name = "South Africa"},
                new {Id = 10, Name = "China"},
                new {Id = 11, Name = "Mexico"},
                new {Id = 12, Name = "Italy"},
                new {Id = 13, Name = "Russia"}

            };
            return countryList.Select(c =>  new Country {Id = c.Id, Name = c.Name}).ToList();
        }
    }
}
