using Microsoft.AspNetCore.Mvc;
using Web_API_Versioning.Models.DTOs;

namespace Web_API_Versioning.Controllers
{
    [ApiController]
    [Route("api/v{version:apiversion}/[controller]")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class CountryController : Controller
    {
        
        [MapToApiVersion("1.0")]
        [HttpGet]
        public IActionResult GetV1()
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

        [MapToApiVersion("2.0")]
        [HttpGet]
        public IActionResult GetV2()
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
