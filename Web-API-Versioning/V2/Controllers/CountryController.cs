using Microsoft.AspNetCore.Mvc;
using Web_API_Versioning.Models.DTOs;

namespace Web_API_Versioning.V2.Controllers
{
    [ApiController]
    [Route("api/v2/[controller]")]
    public class CountryController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var countryDomain = CountryData.Get();
            var countryDto = new List<CountryDtoV2>();

            foreach (var item in countryDomain)
            {
                countryDto.Add(new CountryDtoV2
                {
                    CountryName = item.Name,
                    Id = item.Id,   
                });
            }

            return Ok(countryDto);
        }
    }
}
