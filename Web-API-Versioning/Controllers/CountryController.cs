using Microsoft.AspNetCore.Mvc;
using Web_API_Versioning.Models.DTOs;

namespace Web_API_Versioning.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var countryDomain = CountryData.Get();
            var countryDto = new List<CountryDto>();

            foreach (var item in countryDomain)
            {
                countryDto.Add(new CountryDto
                {
                    Name = item.Name,
                    Id = item.Id,   
                });
            }

            return Ok(countryDto);
        }
    }
}
