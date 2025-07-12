using Microsoft.AspNetCore.Mvc;
using Web_API_Versioning.Models.DTOs;

namespace Web_API_Versioning.V1.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CountryController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var countryDomain = CountryData.Get();
            var countryDto = new List<CountryDtoV1>();

            foreach (var item in countryDomain)
            {
                countryDto.Add(new CountryDtoV1
                {
                    Name = item.Name,
                    Id = item.Id,   
                });
            }

            return Ok(countryDto);
        }
    }
}
